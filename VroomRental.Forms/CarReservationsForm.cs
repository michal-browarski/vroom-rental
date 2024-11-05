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
        }

        private void InitializeDataGridView()
        {
            dataGridCarReservations.AutoGenerateColumns = false;

            dataGridCarReservations.CellClick += DataGridCarReservations_CellClick;
        }

        private void LoadData()
        {
            try
            {
                List<CarReservation> carReservations = _carReservationService.GetAllCarReservations();
                dataGridCarReservations.DataSource = carReservations;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania danych: " + ex.Message);
            }
        }

        private void DataGridCarReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCarReservations.Rows[e.RowIndex];
                CarReservation selectedCar = row.DataBoundItem as CarReservation;

                if (selectedCar != null)
                {
                    //BrandTextBox.Text = selectedCar.Brand;
                    //ModelTextBox.Text = selectedCar.Model;
                    //YearTextBox.Text = selectedCar.ProductionYear;
                    //ColorTextBox.Text = selectedCar.Color;
                    //PriceTextBox.Text = selectedCar.PricePerDay.ToString();
                    //StatusTextBox.Text = selectedCar.Status.ToString();
                    //MileageTextBox.Text = selectedCar.Mileage.ToString();
                    //LastInspectionTextBox.Text = selectedCar.LastInspectionDate.ToString("yyyy-MM-dd");
                    //BodyTypeTextBox.Text = selectedCar.BodyType.ToString();
                }
            }
        }
    }
}
