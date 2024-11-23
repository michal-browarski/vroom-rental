using System.Configuration;
using System.Windows.Forms;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;

namespace VroomRental.Forms
{
    public partial class CarReservationsForm : Form
    {
        private readonly CarReservationService _carReservationService;

        public CarReservationsForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);
            _carReservationService = new CarReservationService(databaseService);

            InitializeDataGridView();
            LoadData();

            ResetButton.Click += ResetButton_Click;
        }

        private void InitializeDataGridView()
        {
            dataGridCarReservations.AutoGenerateColumns = false;

            // Konfiguracja kolumn DataGridView
            dataGridCarReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Customer Name",
                DataPropertyName = "CustomerFullName",
                Name = "CustomerFullNameColumn"
            });

            dataGridCarReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Car Details",
                DataPropertyName = "CarDetails",
                Name = "CarDetailsColumn"
            });

            dataGridCarReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Start Date",
                DataPropertyName = "StartDate",
                Name = "StartDateColumn"
            });

            dataGridCarReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Planned End Date",
                DataPropertyName = "PlannedEndDate",
                Name = "PlannedEndDateColumn"
            });

            dataGridCarReservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",
                Name = "StatusColumn"
            });

            var endRentalButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "End Rental",
                Text = "End Rental",
                UseColumnTextForButtonValue = true,
                Name = "EndRentalButtonColumn"
            };
            dataGridCarReservations.Columns.Add(endRentalButtonColumn);

            dataGridCarReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCarReservations.CellContentClick += DataGridCarReservations_CellContentClick;
            dataGridCarReservations.CellClick += DataGridCarReservations_CellClick;
            dataGridCarReservations.CellFormatting += DataGridCarReservations_CellFormatting;
        }

        private void LoadData()
        {
            try
            {
                List<CarReservation> carReservations = _carReservationService.GetAllCarReservations();

                // Dodaj właściwości niestandardowe dla wyświetlania danych w DataGridView
                foreach (var reservation in carReservations)
                {
                    reservation.CustomerFullName = $"{reservation.Customer.FirstName} {reservation.Customer.LastName}";
                    reservation.CarDetails = $"{reservation.Car.Brand} {reservation.Car.Model}";
                }

                dataGridCarReservations.DataSource = carReservations;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridCarReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCarReservations.Rows[e.RowIndex];
                CarReservation selectedReservation = row.DataBoundItem as CarReservation;

                if (selectedReservation != null)
                {
                    // Wypełnij pola tekstowe szczegółami rezerwacji
                    CustomerNameTextBox.Text = $"{selectedReservation.Customer.FirstName} {selectedReservation.Customer.LastName}";
                    CarDetailsTextBox.Text = $"{selectedReservation.Car.Brand} {selectedReservation.Car.Model}";
                    StartDateTextBox.Text = selectedReservation.StartDate.ToString("dd-MM-yyyy");
                    PlannedEndDateTextBox.Text = selectedReservation.PlannedEndDate.ToString("dd-MM-yyyy");
                    ActualEndDateTextBox.Text = selectedReservation.ActualEndDate?.ToString("dd-MM-yyyy") ?? "N/A";
                    StatusTextBox.Text = selectedReservation.Status.ToString();
                    EmployeeNameTextBox.Text = selectedReservation.Employee != null
                        ? $"{selectedReservation.Employee.FirstName} {selectedReservation.Employee.LastName}"
                        : "N/A";
                    PaymentDetailsTextBox.Text = selectedReservation.Payment != null
                        ? $"Amount: {selectedReservation.Payment.Amount:C}, Date: {selectedReservation.Payment.PaymentDate:dd-MM-yyyy}"
                        : "N/A";

                    // Zaktualizuj stan CheckedListBox dla opcji rezerwacji
                    UpdateReservationOptionsCheckedListBox(selectedReservation.Id);
                }
            }
        }

        private void UpdateReservationOptionsCheckedListBox(int reservationId)
        {
            try
            {
                // Wyczyszczenie istniejących elementów w CheckedListBox
                AdditionalOptionsCheckedListBox.Items.Clear();

                // Pobranie wszystkich dostępnych opcji z bazy danych
                var allOptions = _carReservationService.GetAllAdditionalOptions();

                // Pobranie opcji przypisanych do danego wypożyczenia
                var reservationOptions = _carReservationService.GetOptionsFromReservation(reservationId);

                // Iteracja po wszystkich opcjach i dodanie ich do CheckedListBox
                foreach (var option in allOptions)
                {
                    bool isChecked = reservationOptions.Any(o => o.Id == option.Id);
                    AdditionalOptionsCheckedListBox.Items.Add(option, isChecked);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading additional options: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetFilters();
            LoadData();
        }

        private void ResetFilters()
        {
            // Resetuj wszystkie pola tekstowe
            CustomerNameTextBox.Clear();
            CarDetailsTextBox.Clear();
            StartDateTextBox.Clear();
            PlannedEndDateTextBox.Clear();
            ActualEndDateTextBox.Clear();
            StatusTextBox.Clear();
            EmployeeNameTextBox.Clear();
            PaymentDetailsTextBox.Clear();

            // Odznacz wszystkie opcje w CheckedListBox
            for (int i = 0; i < AdditionalOptionsCheckedListBox.Items.Count; i++)
            {
                AdditionalOptionsCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void DataGridCarReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obsługa przycisku "End Rental"
            if (dataGridCarReservations.Columns[e.ColumnIndex].Name == "EndRentalButtonColumn")
            {
                var selectedReservation = dataGridCarReservations.Rows[e.RowIndex].DataBoundItem as CarReservation;

                if (selectedReservation == null)
                {
                    MessageBox.Show("Could not read the selected reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Sprawdzenie, czy rezerwacja może zostać zakończona
                if (selectedReservation.Status != ReservationStatus.Active)
                {
                    MessageBox.Show("Only active reservations can be ended.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Potwierdzenie zakończenia wypożyczenia
                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to end the rental for customer {selectedReservation.Customer.FirstName} {selectedReservation.Customer.LastName}?",
                    "Confirm End Rental",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Aktualizacja bazy danych: zakończenie wypożyczenia
                        selectedReservation.ActualEndDate = DateTime.Now;
                        selectedReservation.Status = ReservationStatus.Ended;

                        // Zaktualizuj rezerwację
                        _carReservationService.UpdateReservation(selectedReservation);

                        // Zaktualizuj status samochodu na "Available"
                        _carReservationService.UpdateCarStatus(selectedReservation.Car.Id, CarStatus.Available);

                        // Sukces
                        MessageBox.Show("Rental has been successfully ended.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Odśwież dane
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while ending the rental: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void DataGridCarReservations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridCarReservations.Columns[e.ColumnIndex].Name == "EndRentalButtonColumn" && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCarReservations.Rows[e.RowIndex];
                CarReservation reservation = row.DataBoundItem as CarReservation;

                if (reservation != null)
                {
                    var cell = row.Cells["EndRentalButtonColumn"] as DataGridViewButtonCell;

                    if (reservation.Status != ReservationStatus.Active)
                    {
                        cell.Style.BackColor = Color.LightGray;
                        cell.Style.ForeColor = Color.DarkGray;
                        cell.FlatStyle = FlatStyle.Flat;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.LightGreen;
                        cell.Style.ForeColor = Color.Black;
                        cell.FlatStyle = FlatStyle.Standard;
                    }
                }
            }
        }
    }
}
