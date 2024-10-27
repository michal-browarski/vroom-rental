using System.Configuration;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;

namespace VroomRental.Forms
{
    public partial class TestForm : Form
    {
        //private readonly CarService _carService;
        //private readonly CarReservationService _carReservationService;
        //private readonly EmployeeService _employeeService;
        private readonly RepairService _repairService;
        public TestForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);
            //_carService = new (databaseService);

            //_carReservationService = new(databaseService);

            //_employeeService = new EmployeeService(databaseService);
            
            _repairService = new RepairService(databaseService);

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                //List<Car> cars = _carService.GetAllCars();
                //dataGridViewTest.DataSource = cars;

                //List<CarReservation> carReservations = _carReservationService.GetAllCarReservations();
                //dataGridViewTest.DataSource = carReservations;

                //List<Employee> employees = _employeeService.GetAllEmployees();
                //dataGridViewTest.DataSource = employees;

                List<Repair> repairs = _repairService.GetAllRepairs();
                dataGridViewTest.DataSource = repairs;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Wystąpił błąd podczas ładowania danych: " + ex.Message);
            }

        }
    }
}
