using System.Configuration;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;

namespace VroomRental.Forms
{
    public partial class CarsForm : Form
    {
        private readonly CarService _carService;

        public CarsForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);
            _carService = new CarService(databaseService);

            InitializeDataGridView();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dataGridCars.AutoGenerateColumns = false;

            dataGridCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Marka",
                DataPropertyName = "Brand",
                Name = "ColumnBrand"
            });

            dataGridCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Model",
                DataPropertyName = "Model",
                Name = "ColumnModel"
            });

            dataGridCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Rok Produkcji",
                DataPropertyName = "ProductionYear",
                Name = "ColumnProductionYear"
            });

            dataGridCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Kolor",
                DataPropertyName = "Color",
                Name = "ColumnColor"
            });

            dataGridCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cena za Dzień",
                DataPropertyName = "PricePerDay",
                Name = "ColumnPricePerDay"
            });

            dataGridCars.CellClick += DataGridCars_CellClick;
        }

        private void LoadData()
        {
            try
            {
                List<Car> cars = _carService.GetAllCars();
                dataGridCars.DataSource = cars;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania danych: " + ex.Message);
            }
        }

        private void DataGridCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCars.Rows[e.RowIndex];
                Car selectedCar = row.DataBoundItem as Car;

                if (selectedCar != null)
                {
                    BrandTextBox.Text = selectedCar.Brand;
                    ModelTextBox.Text = selectedCar.Model;
                    YearTextBox.Text = selectedCar.ProductionYear;
                    ColorTextBox.Text = selectedCar.Color;
                    PriceTextBox.Text = selectedCar.PricePerDay.ToString();
                    StatusTextBox.Text = selectedCar.Status.ToString();
                    MileageTextBox.Text = selectedCar.Mileage.ToString();
                    LastInspectionTextBox.Text = selectedCar.LastInspectionDate.ToString("yyyy-MM-dd");
                }
            }
        }
    }
}
