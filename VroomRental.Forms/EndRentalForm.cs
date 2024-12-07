using System;
using System.Windows.Forms;
using VroomRental.Backend.Model;
using VroomRental.Backend.DB.QueryServices;

namespace VroomRental.Forms
{
    public partial class EndRentalForm : Form
    {
        private readonly CarReservationService _reservationService;
        private readonly CarReservation _selectedReservation;

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
            TotalAmountLabel.Text = "Total Amount: 0 zł";
            MileageStatusLabel.Text = "Mileage within allowed limit.";

            RepairCheckBox.CheckedChanged += RepairCheckbox_CheckedChanged;
            FinalMileageNumericUpDown.ValueChanged += FinalMileageNumericUpDown_ValueChanged;
            RepairCostNumericUpDown.ValueChanged += RepairCostNumericUpDown_ValueChanged;

            ConfirmPaymentButton.Click += ConfirmPaymentButton_Click;

            UpdateTotalAmountLabel();
        }

        private void ConfirmPaymentButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want to confirm this payment?",
                "Confirm Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Pobierz dane z formularza
                    int finalMileage = (int)FinalMileageNumericUpDown.Value;
                    bool requiresRepair = RepairCheckBox.Checked;
                    decimal repairCost = requiresRepair ? RepairCostNumericUpDown.Value : 0;

                    // Oblicz koszt całkowity
                    decimal totalPrice = CalculateTotalPrice(_selectedReservation, finalMileage, requiresRepair, repairCost);

                    // Aktualizacja stanu rezerwacji
                    _selectedReservation.ActualEndDate = DateTime.Now;
                    _selectedReservation.Status = ReservationStatus.Ended;
                    _selectedReservation.Car.Mileage = finalMileage;

                    _reservationService.UpdateReservation(_selectedReservation);
                    _reservationService.UpdateCarStatus(_selectedReservation.Car.Id, CarStatus.Available);

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

                    MileageStatusLabel.Text = $"Mileage exceeded. Penalty: {overageCost:C}";
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
    }
}
