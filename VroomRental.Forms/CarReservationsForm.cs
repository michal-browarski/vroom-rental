using System.Configuration;
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

            SearchStatusComboBox.Items.Add("Active");
            SearchStatusComboBox.Items.Add("Ended");
            SearchStatusComboBox.Items.Add("Canceled");
            SearchStatusComboBox.SelectedIndex = -1;

            SearchButton.Click += SearchButton_Click;
            SearchResetButton.Click += SearchResetButton_Click;

            EditButton.Click += EditButton_Click;
            ResetButton.Click += ResetButton_Click;
        }

        private void InitializeDataGridView()
        {
            dataGridCarReservations.AutoGenerateColumns = false;

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
                List<CarReservation> reservations = _carReservationService.GetAllCarReservations();

                foreach (var reservation in reservations)
                {
                    reservation.CustomerFullName = $"{reservation.Customer.FirstName} {reservation.Customer.LastName}";
                    reservation.CarDetails = $"{reservation.Car.Brand} {reservation.Car.Model}";
                }

                dataGridCarReservations.DataSource = null;
                dataGridCarReservations.DataSource = reservations;
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

                    UpdateReservationOptionsCheckedListBox(selectedReservation.Id);
                }
            }
        }

        private void UpdateReservationOptionsCheckedListBox(int reservationId)
        {
            try
            {
                AdditionalOptionsCheckedListBox.Items.Clear();

                var allOptions = _carReservationService.GetAllAdditionalOptions();

                var reservationOptions = _carReservationService.GetOptionsFromReservation(reservationId);

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
            ResetInputs();
            LoadData();
        }

        private void ResetInputs()
        {
            CustomerNameTextBox.Clear();
            CarDetailsTextBox.Clear();
            StartDateTextBox.Clear();
            PlannedEndDateTextBox.Clear();
            ActualEndDateTextBox.Clear();
            StatusTextBox.Clear();
            EmployeeNameTextBox.Clear();
            PaymentDetailsTextBox.Clear();

            for (int i = 0; i < AdditionalOptionsCheckedListBox.Items.Count; i++)
            {
                AdditionalOptionsCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void DataGridCarReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridCarReservations.Columns[e.ColumnIndex].Name == "EndRentalButtonColumn")
            {
                var selectedReservation = dataGridCarReservations.Rows[e.RowIndex].DataBoundItem as CarReservation;

                if (selectedReservation == null)
                {
                    MessageBox.Show("Could not read the selected reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selectedReservation.Status != ReservationStatus.Active)
                {
                    MessageBox.Show("Only active reservations can be ended.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to end the rental for customer {selectedReservation.Customer.FirstName} {selectedReservation.Customer.LastName}?",
                    "Confirm End Rental",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        selectedReservation.ActualEndDate = DateTime.Now;
                        selectedReservation.Status = ReservationStatus.Ended;

                        _carReservationService.UpdateReservation(selectedReservation);

                        _carReservationService.UpdateCarStatus(selectedReservation.Car.Id, CarStatus.Available);

                        MessageBox.Show("Rental has been successfully ended.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridCarReservations.CurrentRow == null)
            {
                MessageBox.Show("Please select a reservation to edit.", "No Reservation Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedReservation = dataGridCarReservations.CurrentRow.DataBoundItem as CarReservation;

            if (selectedReservation == null)
            {
                MessageBox.Show("Invalid reservation selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                selectedReservation.StartDate = DateTime.Parse(StartDateTextBox.Text);
                selectedReservation.PlannedEndDate = DateTime.Parse(PlannedEndDateTextBox.Text);

                if (string.IsNullOrWhiteSpace(ActualEndDateTextBox.Text) || ActualEndDateTextBox.Text == "N/A")
                {
                    selectedReservation.ActualEndDate = null;
                }
                else
                {
                    selectedReservation.ActualEndDate = DateTime.Parse(ActualEndDateTextBox.Text);
                }

                selectedReservation.Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), StatusTextBox.Text);

                _carReservationService.UpdateReservation(selectedReservation);

                var selectedOptions = new List<AdditionalOption>();
                foreach (var item in AdditionalOptionsCheckedListBox.CheckedItems)
                {
                    if (item is AdditionalOption option)
                    {
                        selectedOptions.Add(option);
                    }
                }

                _carReservationService.UpdateReservationOptions(selectedReservation.Id, selectedOptions);

                LoadData();

                MessageBox.Show("Reservation updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid date format: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchReservations();
        }

        private void SearchResetButton_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void SearchReservations()
        {
            try
            {
                // Pobierz wszystkie rezerwacje
                List<CarReservation> reservations = _carReservationService.GetAllCarReservations();

                // Filtrowanie według imienia i nazwiska klienta
                if (!string.IsNullOrWhiteSpace(SearchCustomerTextBox.Text))
                {
                    reservations = reservations.Where(r =>
                        $"{r.Customer.FirstName} {r.Customer.LastName}".Contains(SearchCustomerTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                // Filtrowanie według danych samochodu
                if (!string.IsNullOrWhiteSpace(SearchCarDetailsTextBox.Text))
                {
                    reservations = reservations.Where(r =>
                        $"{r.Car.Brand} {r.Car.Model}".Contains(SearchCarDetailsTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                // Filtrowanie według daty rozpoczęcia
                if (!string.IsNullOrWhiteSpace(SearchStartDateTextBox.Text) && DateTime.TryParse(SearchStartDateTextBox.Text, out var startDate))
                {
                    reservations = reservations.Where(r => r.StartDate >= startDate).ToList();
                }

                // Filtrowanie według daty zakończenia
                if (!string.IsNullOrWhiteSpace(SearchEndDateTextBox.Text) && DateTime.TryParse(SearchEndDateTextBox.Text, out var endDate))
                {
                    reservations = reservations.Where(r => r.PlannedEndDate <= endDate).ToList();
                }

                // Filtrowanie według statusu
                if (SearchStatusComboBox.SelectedIndex != -1)
                {
                    ReservationStatus selectedStatus = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), SearchStatusComboBox.SelectedItem.ToString());
                    reservations = reservations.Where(r => r.Status == selectedStatus).ToList();
                }

                // Uzupełnij dynamiczne pola CustomerFullName i CarDetails
                foreach (var reservation in reservations)
                {
                    reservation.CustomerFullName = $"{reservation.Customer.FirstName} {reservation.Customer.LastName}";
                    reservation.CarDetails = $"{reservation.Car.Brand} {reservation.Car.Model}";
                }

                // Przypisz wyniki do DataGridView
                dataGridCarReservations.DataSource = null; // Wyczyszczenie źródła danych
                dataGridCarReservations.DataSource = reservations;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching reservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ResetFilters()
        {
            // Wyczyść wszystkie pola wyszukiwania
            SearchCustomerTextBox.Clear();
            SearchCarDetailsTextBox.Clear();
            SearchStartDateTextBox.Clear();
            SearchEndDateTextBox.Clear();
            SearchStatusComboBox.SelectedIndex = -1;

            // Załaduj wszystkie dane
            LoadData();
        }

    }
}
