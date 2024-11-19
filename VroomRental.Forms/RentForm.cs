using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;

namespace VroomRental.Forms
{
    public partial class RentForm : Form
    {
        private readonly CustomerService _customerService;
        private readonly CarReservationService _reservationService;
        private readonly CarService _carService;

        public Car SelectedCar { get; set; }
        public int CurrentEmployeeId { get; set; }

        public RentForm(Car selectedCar, int currentEmployeeId)
        {
            InitializeComponent();

            SelectedCar = selectedCar;
            CurrentEmployeeId = currentEmployeeId;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);

            _customerService = new CustomerService(databaseService);
            _reservationService = new CarReservationService(databaseService);
            _carService = new CarService(databaseService);

            InitializeDataGridView();
            InitializeMonthCalendar();

            LoadCustomers();

            RentButton.Click += RentButton_Click;
            AddButton.Click += AddButton_Click;
            EditButton.Click += EditButton_Click;
            RemoveButton.Click += RemoveButton_Click;
            ResetButton.Click += ResetButton_Click;
            SearchButton.Click += SearchButton_Click;
            SearchResetButton.Click += SearchResetButton_Click;

            dataGridCustomers.CellClick += DataGridCustomers_CellClick;
        }

        private void InitializeDataGridView()
        {
            dataGridCustomers.AutoGenerateColumns = false;

            dataGridCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "First Name",
                DataPropertyName = "FirstName",
                Name = "ColumnFirstName"
            });

            dataGridCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Last Name",
                DataPropertyName = "LastName",
                Name = "ColumnLastName"
            });

            dataGridCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phone",
                DataPropertyName = "Phone",
                Name = "ColumnPhone"
            });

            dataGridCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email",
                Name = "ColumnEmail"
            });

            dataGridCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Driver Licence",
                DataPropertyName = "DriverLicenceNumber",
                Name = "ColumnDriverLicence"
            });

            dataGridCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Address",
                DataPropertyName = "FullAddress",
                Name = "ColumnAddress"
            });

            dataGridCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DataGridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedCustomer = dataGridCustomers.Rows[e.RowIndex].DataBoundItem as Customer;

                if (selectedCustomer != null)
                {
                    FirstNameTextBox.Text = selectedCustomer.FirstName;
                    LastNameTextBox.Text = selectedCustomer.LastName;
                    PhoneTextBox.Text = selectedCustomer.Phone;
                    EmailTextBox.Text = selectedCustomer.Email;
                    DriverLicenceTextBox.Text = selectedCustomer.DriverLicenceNumber;

                    if (selectedCustomer.Address != null)
                    {
                        StreetTextBox.Text = selectedCustomer.Address.Street;
                        HomeNumberTextBox.Text = selectedCustomer.Address.HomeNumber;
                        CityTextBox.Text = selectedCustomer.Address.City;
                        ZipCodeTextBox.Text = selectedCustomer.Address.ZipCode;
                    }
                }
            }
        }

        private void InitializeMonthCalendar()
        {
            PlannedEndDateCalendar.MinDate = DateTime.Now;
        }

        private void LoadCustomers()
        {
            try
            {
                List<Customer> customers = _customerService.GetAllCustomersWithAddress();
                dataGridCustomers.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            if (dataGridCustomers.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer to rent the car to.", "No Customer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedCustomer = dataGridCustomers.CurrentRow.DataBoundItem as Customer;

            if (selectedCustomer == null)
            {
                MessageBox.Show("Invalid customer selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime plannedEndDate = PlannedEndDateCalendar.SelectionStart;
            if (plannedEndDate <= DateTime.Now.Date)
            {
                MessageBox.Show("Please select a valid planned end date. The date cannot be in the past.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SelectedCar == null)
            {
                MessageBox.Show("No car has been selected for rental.", "No Car Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dodanie pytania o potwierdzenie
            var confirmResult = MessageBox.Show(
                $"Are you sure you want to rent the car '{SelectedCar.Brand} {SelectedCar.Model}' to {selectedCustomer.FirstName} {selectedCustomer.LastName} until {plannedEndDate:yyyy-MM-dd}?",
                "Confirm Rent",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var newReservation = new CarReservation
                {
                    Customer = selectedCustomer,
                    Car = SelectedCar,
                    StartDate = DateTime.Now,
                    PlannedEndDate = plannedEndDate,
                    ActualEndDate = null,
                    Status = ReservationStatus.Active,
                    Employee = new Employee { Id = CurrentEmployeeId },
                    Payment = null
                };

                _reservationService.AddReservation(newReservation);

                SelectedCar.Status = CarStatus.Rented;
                _carService.EditCar(SelectedCar);

                MessageBox.Show($"Car has been successfully rented to {selectedCustomer.FirstName} {selectedCustomer.LastName} until {plannedEndDate:yyyy-MM-dd}!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the rental: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                var newCustomer = new Customer
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    Email = EmailTextBox.Text,
                    DriverLicenceNumber = DriverLicenceTextBox.Text,
                    Address = new Address
                    {
                        Street = StreetTextBox.Text,
                        HomeNumber = HomeNumberTextBox.Text,
                        City = CityTextBox.Text,
                        ZipCode = ZipCodeTextBox.Text
                    }
                };

                _customerService.AddCustomerWithAddress(newCustomer);
                LoadCustomers();
                ResetInputs();
                MessageBox.Show("Customer and address added successfully.");
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridCustomers.CurrentRow != null && IsInputValid())
            {
                var selectedCustomer = dataGridCustomers.CurrentRow.DataBoundItem as Customer;

                if (selectedCustomer != null)
                {
                    selectedCustomer.FirstName = FirstNameTextBox.Text;
                    selectedCustomer.LastName = LastNameTextBox.Text;
                    selectedCustomer.Phone = PhoneTextBox.Text;
                    selectedCustomer.Email = EmailTextBox.Text;
                    selectedCustomer.DriverLicenceNumber = DriverLicenceTextBox.Text;
                    selectedCustomer.Address = new Address
                    {
                        Street = StreetTextBox.Text,
                        HomeNumber = HomeNumberTextBox.Text,
                        City = CityTextBox.Text,
                        ZipCode = ZipCodeTextBox.Text
                    };

                    _customerService.EditCustomerWithAddress(selectedCustomer);
                    LoadCustomers();
                    ResetInputs();
                    MessageBox.Show("Customer and address updated successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer and fill in all fields.");
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (dataGridCustomers.CurrentRow != null)
            {
                var selectedCustomer = dataGridCustomers.CurrentRow.DataBoundItem as Customer;

                if (selectedCustomer != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this customer and their address?",
                                                        "Delete Confirmation",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        _customerService.RemoveCustomerWithAddress(selectedCustomer.Id);
                        LoadCustomers();
                        ResetInputs();
                        MessageBox.Show("Customer and their address have been removed successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to remove.");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetInputs();
            dataGridCustomers.ClearSelection();
        }

        private void ResetInputs()
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            PhoneTextBox.Clear();
            EmailTextBox.Clear();
            DriverLicenceTextBox.Clear();
            StreetTextBox.Clear();
            HomeNumberTextBox.Clear();
            CityTextBox.Clear();
            ZipCodeTextBox.Clear();
        }

        private bool IsInputValid()
        {
            return !string.IsNullOrWhiteSpace(FirstNameTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(LastNameTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(PhoneTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(EmailTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(DriverLicenceTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(StreetTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(HomeNumberTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(CityTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(ZipCodeTextBox.Text);
        }

        private void SearchCustomers()
        {
            try
            {
                // Pobierz wszystkich klientów
                List<Customer> customers = _customerService.GetAllCustomersWithAddress();

                // Filtruj według imienia
                if (!string.IsNullOrWhiteSpace(SearchFirstNameTextBox.Text))
                {
                    customers = customers.Where(c => c.FirstName.Contains(SearchFirstNameTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                // Filtruj według nazwiska
                if (!string.IsNullOrWhiteSpace(SearchLastNameTextBox.Text))
                {
                    customers = customers.Where(c => c.LastName.Contains(SearchLastNameTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                // Filtruj według numeru telefonu
                if (!string.IsNullOrWhiteSpace(SearchPhoneTextBox.Text))
                {
                    customers = customers.Where(c => c.Phone.Contains(SearchPhoneTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                // Filtruj według adresu e-mail
                if (!string.IsNullOrWhiteSpace(SearchEmailTextBox.Text))
                {
                    customers = customers.Where(c => c.Email.Contains(SearchEmailTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                // Filtruj według numeru prawa jazdy
                if (!string.IsNullOrWhiteSpace(SearchDriverLicenceTextBox.Text))
                {
                    customers = customers.Where(c => c.DriverLicenceNumber.Contains(SearchDriverLicenceTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                // Zaktualizuj źródło danych dla DataGridView
                dataGridCustomers.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during the search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetCustomers()
        {
            SearchFirstNameTextBox.Clear();
            SearchLastNameTextBox.Clear();
            SearchPhoneTextBox.Clear();
            SearchEmailTextBox.Clear();
            SearchDriverLicenceTextBox.Clear();
            LoadCustomers();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
           SearchCustomers();
        }

        private void SearchResetButton_Click(object sender, EventArgs e)
        {
            ResetCustomers();
        }

    }
}
