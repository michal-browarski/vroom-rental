using System.Net;
using System.Net.Mail;
using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;
using System.Configuration;

namespace VroomRental.Forms
{
    public partial class EndRentalForm : Form
    {
        private readonly CarReservationService _reservationService;
        private readonly CarReservation _selectedReservation;

        private string GeneratedBlikCode;

        public EndRentalForm(CarReservationService reservationService, CarReservation selectedReservation)
        {
            InitializeComponent();
            _reservationService = reservationService;
            _selectedReservation = selectedReservation;

            InitializeForm();
        }

        private void InitializeForm()
        {
            // Ustawienia początkowe
            FinalMileageNumericUpDown.Minimum = _selectedReservation.Car.Mileage;
            FinalMileageNumericUpDown.Value = _selectedReservation.Car.Mileage;

            RepairCostNumericUpDown.Enabled = false;
            RepairDescriptionTextBox.Enabled = false;
            TotalAmountLabel.Text = "Total Amount: 0 zł";
            MileageStatusLabel.Text = "Mileage within allowed limit.";

            RepairCheckBox.CheckedChanged += RepairCheckbox_CheckedChanged;
            FinalMileageNumericUpDown.ValueChanged += FinalMileageNumericUpDown_ValueChanged;
            RepairCostNumericUpDown.ValueChanged += RepairCostNumericUpDown_ValueChanged;

            ConfirmPaymentButton.Click += ConfirmPaymentButton_Click;

            CashRadioButton.CheckedChanged += PaymentMethodChanged;
            BlikRadioButton.CheckedChanged += PaymentMethodChanged;

            // Ustawienia radiobuttonów
            CashRadioButton.Checked = true;
            BlikCodeTextBox.Enabled = false;
            GeneratedBlikCode = null;

            UpdateTotalAmountLabel();
        }

        private void ConfirmPaymentButton_Click(object sender, EventArgs e)
        {
            if (BlikRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(BlikCodeTextBox.Text))
                {
                    MessageBox.Show("Please enter the Blik code.", "Blik Code Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (BlikCodeTextBox.Text != GeneratedBlikCode)
                {
                    MessageBox.Show("Invalid Blik code. Please try again.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            var confirmResult = MessageBox.Show(
                "Are you sure you want to confirm this payment?",
                "Confirm Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Finalizacja płatności
                    int finalMileage = (int)FinalMileageNumericUpDown.Value;
                    bool requiresRepair = RepairCheckBox.Checked;
                    decimal repairCost = requiresRepair ? RepairCostNumericUpDown.Value : 0;

                    decimal totalPrice = CalculateTotalPrice(_selectedReservation, finalMileage, requiresRepair, repairCost);

                    int traveledKilometers = finalMileage - _selectedReservation.Car.Mileage;

                    _selectedReservation.ActualEndDate = DateTime.Now;
                    _selectedReservation.Status = ReservationStatus.Ended;
                    _selectedReservation.Car.Mileage = finalMileage;

                    _reservationService.UpdateReservation(_selectedReservation, traveledKilometers);
                    _reservationService.UpdateCarStatus(_selectedReservation.Car.Id, CarStatus.Available);
                    _reservationService.UpdateCarMileage(_selectedReservation.Car.Id, finalMileage);

                    // Zapis płatności w bazie danych
                    int paymentMethodId = BlikRadioButton.Checked ? 1 : 2; // 1 = Blik, 2 = Cash
                    _reservationService.SavePayment(_selectedReservation.Id, totalPrice, paymentMethodId);

                    // Zapis naprawy, jeśli zaznaczono
                    if (requiresRepair)
                    {
                        string repairDescription = RepairDescriptionTextBox.Text;

                        _reservationService.SaveRepair(_selectedReservation.Car.Id, repairDescription, 1, repairCost);
                    }

                    MessageBox.Show($"Rental has been successfully ended.\nTotal Amount Paid: {totalPrice:C}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FinalMileageNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalAmountLabel();
        }

        private void RepairCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            RepairCostNumericUpDown.Enabled = RepairCheckBox.Checked;
            RepairDescriptionTextBox.Enabled = RepairCheckBox.Checked;
            UpdateTotalAmountLabel();
        }


        private void RepairCostNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalAmountLabel();
        }

        private void UpdateTotalAmountLabel()
        {
            try
            {
                int finalMileage = (int)FinalMileageNumericUpDown.Value;
                bool requiresRepair = RepairCheckBox.Checked;
                decimal repairCost = requiresRepair ? RepairCostNumericUpDown.Value : 0;

                decimal totalPrice = CalculateTotalPrice(_selectedReservation, finalMileage, requiresRepair, repairCost);

                TotalAmountLabel.Text = $"Total Amount: {totalPrice:C}";
            }
            catch (Exception ex)
            {
                TotalAmountLabel.Text = "Error calculating amount.";
                MessageBox.Show($"An error occurred while updating the total amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalculateTotalPrice(CarReservation reservation, int finalMileage, bool requiresRepair, decimal repairCost)
        {
            decimal totalPrice = 0;

            // Domyślna kara za każdy przekroczony kilometr (ustawiona na stałe w kodzie)
            const decimal PenaltyPerKilometer = 2.00m;

            // Oblicz liczbę dni wypożyczenia
            int rentalDays = (DateTime.Now - reservation.StartDate).Days + 1;

            // Cena bazowa za wypożyczenie samochodu
            totalPrice += reservation.Car.PricePerDay * rentalDays;

            // Dodaj koszt opcji dodatkowych
            if (reservation.AdditionalOptions != null && reservation.AdditionalOptions.Any())
            {
                foreach (var option in reservation.AdditionalOptions)
                {
                    totalPrice += option.Price;
                }
            }

            // Oblicz różnicę między końcowym a początkowym stanem licznika
            int mileageUsed = finalMileage - reservation.Car.Mileage;

            // Sprawdź, czy różnica jest prawidłowa
            if (mileageUsed < 0)
            {
                MileageStatusLabel.Text = "Invalid final mileage. Final mileage must be greater than or equal to the starting mileage.";
                return totalPrice;
            }

            // Dodaj koszt pakietu kilometrów
            if (reservation.DailyMileagePackage != null)
            {
                totalPrice += reservation.DailyMileagePackage.Price * rentalDays;

                // Oblicz, czy limit kilometrów został przekroczony
                int allowedMileage = reservation.DailyMileagePackage.MaxKilometersPerDay * rentalDays;
                if (mileageUsed > allowedMileage)
                {
                    int overage = mileageUsed - allowedMileage;
                    decimal overageCost = overage * PenaltyPerKilometer;
                    totalPrice += overageCost;

                    MileageStatusLabel.Text = $"Mileage exceeded.\nPenalty:\n{overageCost:C}";
                }
                else
                {
                    MileageStatusLabel.Text = "Mileage within allowed limit.";
                }
            }
            else
            {
                MileageStatusLabel.Text = "No mileage package selected.";
            }


            // Dodaj koszt naprawy, jeśli wymagane
            if (requiresRepair)
            {
                totalPrice += repairCost;
            }

            return totalPrice;
        }

        private string GenerateBlikCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SendBlikCodeToEmail(string email, string blikCode)
        {
            // Konfiguracja SMTP
            string smtpServer = "smtp.sendgrid.net";
            int smtpPort = 587;
            string apiKey = ConfigurationManager.AppSettings["ApiKey"];

            MailMessage mail = new MailMessage
            {
                From = new MailAddress("vroomrentalpayments@gmail.com", "VroomRental"),
                Subject = "Your Blik Code",
                Body = $"Your Blik code is: {blikCode}",
                IsBodyHtml = false
            };
            mail.To.Add(email);

            using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
            {
                smtp.Credentials = new NetworkCredential("apikey", apiKey);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
        }

        private void PaymentMethodChanged(object sender, EventArgs e)
        {
            if (BlikRadioButton.Checked)
            {
                if (GeneratedBlikCode == null)
                {
                    BlikCodeTextBox.Enabled = true;

                    // Generowanie i wysyłanie kodu BLIK
                    GeneratedBlikCode = GenerateBlikCode();
                    try
                    {
                        if (string.IsNullOrWhiteSpace(_selectedReservation.Customer.Email))
                        {
                            MessageBox.Show("The customer's email address is missing. Please verify the reservation details.",
                                            "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        SendBlikCodeToEmail(_selectedReservation.Customer.Email, GeneratedBlikCode);
                        MessageBox.Show($"Blik code sent to {_selectedReservation.Customer.Email}", "Blik Code Sent",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to send Blik code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Reset, jeśli wybrano gotówkę
                BlikCodeTextBox.Enabled = false;
                GeneratedBlikCode = null;
            }
        }
    }
}
