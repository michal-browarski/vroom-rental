using System.Configuration;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;

namespace VroomRental.Forms
{
    public partial class TestForm : Form
    {
        private readonly CarService _carService;
        private readonly CarReservationService _carReservationService;
        private readonly EmployeeService _employeeService;
        private readonly CustomerService _customerService;
        private readonly RepairService _repairService;

        public TestForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);

            _carService = new(databaseService);

            _carReservationService = new(databaseService);

            _employeeService = new EmployeeService(databaseService);

            _customerService = new CustomerService(databaseService);

            _repairService = new RepairService(databaseService);


            dataGridViewTest.AutoGenerateColumns = false;

            ConfigureDataGridView();

            LoadData();
        }

        private void ConfigureDataGridView()
        {
            // Dodanie kolumny dla Imienia
            dataGridViewTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FirstName",
                HeaderText = "Imię",
                DataPropertyName = "FirstName"
            });

            // Dodanie kolumny dla Nazwiska
            dataGridViewTest.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LastName",
                HeaderText = "Nazwisko",
                DataPropertyName = "LastName"
            });
        }

        private void LoadData()
        {
            try
            {
                //List<Car> cars = _carService.GetAllCars();
                //dataGridViewTest.DataSource = cars;

                //List<CarReservation> carReservations = _carReservationService.GetAllCarReservations();
                //dataGridViewTest.DataSource = carReservations;

                List<Employee> employees = _employeeService.GetAllEmployeesWithRole();
                dataGridViewTest.DataSource = employees;

                //List<Repair> repairs = _repairService.GetAllRepairs();
                //dataGridViewTest.DataSource = repairs;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Wystąpił błąd podczas ładowania danych: " + ex.Message);
            }

        }
        private void LoadEmployeeData()
        {
            try
            {
                // Pobranie danych pracowników
                List<Employee> employees = _employeeService.GetAllEmployeesWithRole();
                dataGridViewTest.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania danych pracowników: " + ex.Message);
            }
        }

        private void LoadCustomerData()
        {
            try
            {
                // Pobranie danych klientów
                List<Customer> customers = _customerService.GetAllCustomersWithAddress();

                // Przypisanie danych do DataGridView
                dataGridViewTest.DataSource = null;
                dataGridViewTest.DataSource = customers;

                // Ukrycie kolumny Address, która wyświetla nazwę typu
                if (dataGridViewTest.Columns["Address"] != null)
                {
                    dataGridViewTest.Columns["Address"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania danych klientów: " + ex.Message);
            }
        }


        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void dataGridViewTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sprawdzenie, czy kliknięto prawidłowy wiersz
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewTest.Rows.Count)
            {
                if (dataGridViewTest.DataSource is List<Customer>)
                {
                    // Jeśli wyświetlani są klienci, otwórz formularz szczegółów klienta
                    Customer selectedCustomer = (Customer)dataGridViewTest.Rows[e.RowIndex].DataBoundItem;
                    CustomerDetailsForm customerDetailsForm = new CustomerDetailsForm(selectedCustomer);
                    customerDetailsForm.ShowDialog();
                }
                else if (dataGridViewTest.DataSource is List<Employee>)
                {
                    // Jeśli wyświetlani są pracownicy, otwórz formularz szczegółów pracownika
                    Employee selectedEmployee = (Employee)dataGridViewTest.Rows[e.RowIndex].DataBoundItem;
                    EmployeeDetailsForm employeeDetailsForm = new EmployeeDetailsForm(selectedEmployee);
                    employeeDetailsForm.ShowDialog();
                }
            }
        }
    }
}
