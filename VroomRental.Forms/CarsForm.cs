﻿using System.Configuration;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;

namespace VroomRental.Forms
{
    public partial class CarsForm : Form
    {
        private readonly CarService _carService;
        private readonly Employee _currentUser;

        public CarsForm(Employee currentUser)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);
            _carService = new CarService(databaseService);

            InitializeDataGridView();
            LoadData();

            SearchStatusComboBox.Items.Add("Available");
            SearchStatusComboBox.Items.Add("Rented");
            SearchStatusComboBox.Items.Add("In Repair");
            SearchStatusComboBox.SelectedIndex = -1;

            SearchFuelTypeComboBox.Items.Add("Petrol");
            SearchFuelTypeComboBox.Items.Add("Diesel");
            SearchFuelTypeComboBox.Items.Add("Electric");
            SearchFuelTypeComboBox.Items.Add("Hybrid");
            SearchFuelTypeComboBox.SelectedIndex = -1;

            SearchPriceNumericUpDown.Minimum = 0;
            SearchPriceNumericUpDown2.Minimum = 0;
            SearchPriceNumericUpDown2.Value = 200;
            SearchYearNumericUpDown.Minimum = 1990;
            SearchYearNumericUpDown2.Minimum = 1990;
            SearchYearNumericUpDown2.Value = DateTime.Now.Year;
            SearchYearNumericUpDown.Maximum = DateTime.Now.Year;
            SearchYearNumericUpDown2.Maximum = DateTime.Now.Year;

            SearchButton.Click += SearchButton_Click;
            ResetButton.Click += ResetButton_Click;
            _currentUser = currentUser;
        }

        private void InitializeDataGridView()
        {
            dataGridCars.AutoGenerateColumns = false;

            dataGridCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Brand",
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
                HeaderText = "Production Year",
                DataPropertyName = "ProductionYear",
                Name = "ColumnProductionYear"
            });

            dataGridCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Color",
                DataPropertyName = "Color",
                Name = "ColumnColor"
            });

            dataGridCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price Per Day",
                DataPropertyName = "PricePerDay",
                Name = "ColumnPricePerDay"
            });

            dataGridCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Body Type",
                DataPropertyName = "BodyType",
                Name = "ColumnBodyType"
            });

            dataGridCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",
                Name = "ColumnStatus"
            });

            dataGridCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fuel Type",
                DataPropertyName = "FuelType",
                Name = "ColumnFuelType"
            });

            var rentButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Rent",
                Text = "Rent",
                UseColumnTextForButtonValue = true,
                Name = "RentButtonColumn"
            };
            dataGridCars.Columns.Add(rentButtonColumn);

            dataGridCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCars.CellClick += DataGridCars_CellClick;
            dataGridCars.CellContentClick += DataGridCars_CellContentClick;
            dataGridCars.CellFormatting += DataGridCars_CellFormatting;

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
                MessageBox.Show("Data loading error: " + ex.Message);
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
                    FuelTypeTextBox.Text = selectedCar.FuelType.ToString();
                    MileageTextBox.Text = selectedCar.Mileage.ToString();
                    LastInspectionTextBox.Text = selectedCar.LastInspectionDate.ToString("yyyy-MM-dd");
                    BodyTypeTextBox.Text = selectedCar.BodyType.ToString();
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchCars();
        }

        private void SearchCars()
        {
            try
            {
                List<Car> cars = _carService.GetAllCars();

                if (!string.IsNullOrWhiteSpace(SearchBrandTextBox.Text))
                {
                    cars = cars.Where(c => c.Brand.Contains(SearchBrandTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (!string.IsNullOrWhiteSpace(SearchModelTextBox.Text))
                {
                    cars = cars.Where(c => c.Model.Contains(SearchModelTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (SearchYearNumericUpDown.Value > 0 && SearchYearNumericUpDown2.Value >= SearchYearNumericUpDown.Value)
                {
                    cars = cars.Where(c => Convert.ToInt32(c.ProductionYear) >= SearchYearNumericUpDown.Value && Convert.ToInt32(c.ProductionYear) <= SearchYearNumericUpDown2.Value).ToList();
                }

                if (!string.IsNullOrWhiteSpace(SearchColorTextBox.Text))
                {
                    cars = cars.Where(c => c.Color.Contains(SearchColorTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (SearchPriceNumericUpDown.Value >= 0 && SearchPriceNumericUpDown2.Value >= SearchPriceNumericUpDown.Value)
                {
                    cars = cars.Where(c => c.PricePerDay >= SearchPriceNumericUpDown.Value && c.PricePerDay <= SearchPriceNumericUpDown2.Value).ToList();
                }

                if (!string.IsNullOrWhiteSpace(SearchBodyTypeTextBox.Text))
                {
                    cars = cars.Where(c => c.BodyType.Contains(SearchBodyTypeTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (SearchStatusComboBox.SelectedIndex != -1)
                {
                    CarStatus selectedStatus = (CarStatus)Enum.Parse(typeof(CarStatus), SearchStatusComboBox.SelectedItem.ToString());
                    cars = cars.Where(c => c.Status == selectedStatus).ToList();
                }

                if (SearchFuelTypeComboBox.SelectedIndex != -1)
                {
                    string selectedFuelType = SearchFuelTypeComboBox.SelectedItem.ToString();
                    cars = cars.Where(c => c.FuelType.Equals(selectedFuelType, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                dataGridCars.DataSource = cars;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetFilters();
            LoadData();
        }

        private void ResetFilters()
        {
            SearchBrandTextBox.Clear();
            SearchModelTextBox.Clear();
            SearchColorTextBox.Clear();
            SearchBodyTypeTextBox.Clear();

            SearchYearNumericUpDown.Value = 1990;
            SearchYearNumericUpDown2.Value = 2024;
            SearchPriceNumericUpDown.Value = 0;
            SearchPriceNumericUpDown2.Value = 200;
            SearchStatusComboBox.SelectedIndex = -1;
            SearchFuelTypeComboBox.SelectedIndex = -1;
        }

        private bool IsInputValid()
        {
            return !string.IsNullOrWhiteSpace(BrandTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(ModelTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(BodyTypeTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(ColorTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(FuelTypeTextBox.Text) &&
                   decimal.TryParse(PriceTextBox.Text, out _) &&
                   int.TryParse(MileageTextBox.Text, out _) &&
                   DateTime.TryParse(LastInspectionTextBox.Text, out _);
        }

        private Car GetCarFromInputs()
        {
            return new Car
            {
                Brand = BrandTextBox.Text,
                Model = ModelTextBox.Text,
                ProductionYear = YearTextBox.Text,
                BodyType = BodyTypeTextBox.Text,
                Color = ColorTextBox.Text,
                Mileage = int.Parse(MileageTextBox.Text),
                Status = (CarStatus)Enum.Parse(typeof(CarStatus), StatusTextBox.Text),
                FuelType = FuelTypeTextBox.Text,
                PricePerDay = decimal.Parse(PriceTextBox.Text),
                LastInspectionDate = DateTime.Parse(LastInspectionTextBox.Text)
            };
        }

        private void ResetInputs()
        {
            BrandTextBox.Clear();
            ModelTextBox.Clear();
            BodyTypeTextBox.Clear();
            ColorTextBox.Clear();
            FuelTypeTextBox.Clear();
            PriceTextBox.Clear();
            MileageTextBox.Clear();
            YearTextBox.Clear();
            LastInspectionTextBox.Clear();
            StatusTextBox.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                Car car = GetCarFromInputs();
                _carService.AddCar(car);
                LoadData();
                ResetInputs();
            }
            else
            {
                MessageBox.Show("Fill all fields before adding a new car.");
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (dataGridCars.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataGridCars.CurrentRow;
                Car selectedCar = selectedRow.DataBoundItem as Car;

                if (selectedCar != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to remove this car?",
                                                        "Confirm deletion",
                                                        MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        _carService.RemoveCar(selectedCar.Id);
                        LoadData();
                        ResetInputs();
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose car to delete.");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridCars.CurrentRow != null && IsInputValid())
            {
                DataGridViewRow selectedRow = dataGridCars.CurrentRow;
                Car selectedCar = selectedRow.DataBoundItem as Car;

                if (selectedCar != null)
                {
                    Car carToUpdate = new Car
                    {
                        Id = selectedCar.Id,
                        Brand = BrandTextBox.Text,
                        Model = ModelTextBox.Text,
                        ProductionYear = YearTextBox.Text,
                        BodyType = BodyTypeTextBox.Text,
                        Color = ColorTextBox.Text,
                        Mileage = int.Parse(MileageTextBox.Text),
                        Status = (CarStatus)Enum.Parse(typeof(CarStatus), StatusTextBox.Text),
                        FuelType = FuelTypeTextBox.Text,
                        PricePerDay = decimal.Parse(PriceTextBox.Text),
                        LastInspectionDate = DateTime.Parse(LastInspectionTextBox.Text)
                    };

                    _carService.EditCar(carToUpdate);
                    LoadData();
                    ResetInputs();
                }
            }
            else
            {
                MessageBox.Show("Fill all fields and choose car to edit");
            }
        }

        private void DataGridCars_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridCars.Columns[e.ColumnIndex].Name == "RentButtonColumn" && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCars.Rows[e.RowIndex];
                Car car = row.DataBoundItem as Car;

                if (car != null)
                {
                    var cell = row.Cells["RentButtonColumn"] as DataGridViewButtonCell;

                    if (car.Status != CarStatus.Available)
                    {
                        // Ustaw styl przycisku jako nieaktywny
                        cell.Style.BackColor = Color.LightGray;
                        cell.Style.ForeColor = Color.DarkGray;
                        cell.FlatStyle = FlatStyle.Flat;
                    }
                    else
                    {
                        // Przywróć domyślny styl dla aktywnych przycisków
                        cell.Style.BackColor = Color.LightGreen;
                        cell.Style.ForeColor = Color.Black;
                        cell.FlatStyle = FlatStyle.Standard;
                    }
                }
            }
        }

        private void DataGridCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridCars.Columns["RentButtonColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCars.Rows[e.RowIndex];
                Car car = row.DataBoundItem as Car;

                if (car != null && car.Status == CarStatus.Available)
                {
                    using (var rentForm = new RentForm(car, GetCurrentEmployeeId()))
                    {
                        if (rentForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This car is not available for rent.",
                                    "Unavailable",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private int GetCurrentEmployeeId()
        {
            // TODO: Zwracaj faktyczne ID zalogowanego pracownika
            return 1;
        }

        private void ResetCarButton_Click(object sender, EventArgs e)
        {
            ResetInputs();
            dataGridCars.ClearSelection();
        }
    }
}
