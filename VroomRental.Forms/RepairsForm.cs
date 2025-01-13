using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;

namespace VroomRental.Forms
{
    public partial class RepairsForm : Form
    {
        private readonly RepairService _repairService;
        private readonly CarService _carService;

        public RepairsForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);

            _repairService = new RepairService(databaseService);
            _carService = new CarService(databaseService);

            InitializeDataGridView();
            InitializeStatusComboBox();

            LoadRepairs();

            EditButton.Click += EditButton_Click;
            RemoveButton.Click += RemoveButton_Click;
            ResetButton.Click += ResetButton_Click;
            dataGridRepairs.CellClick += DataGridRepairs_CellClick;

            foreach (var status in Enum.GetValues(typeof(RepairStatus)))
            {
                SearchStatusComboBox.Items.Add(status.ToString());
            }
            SearchStatusComboBox.SelectedIndex = -1;
            ReportDateFromPicker.Value = DateTime.Now.AddMonths(-1); // Domyślnie ostatni miesiąc
            ReportDateToPicker.Value = DateTime.Now;
            SearchButton.Click += SearchButton_Click;
            ResetSearchButton.Click += ResetSearchButton_Click;
        }

        private void InitializeDataGridView()
        {
            dataGridRepairs.AutoGenerateColumns = false;

            dataGridRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Car",
                DataPropertyName = "CarDetails", // Nazwa wyświetlana w kolumnie
                Name = "ColumnCar"
            });

            dataGridRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Report Date",
                DataPropertyName = "ReportDate",
                Name = "ColumnReportDate"
            });

            dataGridRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Description",
                DataPropertyName = "Description",
                Name = "ColumnDescription"
            });

            dataGridRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",
                Name = "ColumnStatus"
            });

            dataGridRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "End Date",
                DataPropertyName = "EndDate",
                Name = "ColumnEndDate"
            });

            dataGridRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cost",
                DataPropertyName = "Cost",
                Name = "ColumnCost"
            });

            dataGridRepairs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InitializeStatusComboBox()
        {
            // Wypełnianie ComboBox statusami
            RepairStatusComboBox.Items.Clear();
            foreach (RepairStatus status in Enum.GetValues(typeof(RepairStatus)))
            {
                RepairStatusComboBox.Items.Add(status.ToString());
            }
            RepairStatusComboBox.SelectedIndex = -1;
        }

        private void LoadRepairs()
        {
            try
            {
                List<Repair> repairs = _repairService.GetAllRepairs();
                foreach (var repair in repairs)
                {
                    // Dodanie szczegółów auta jako połączenie marki i modelu
                    repair.CarDetails = $"{repair.Car.Brand} {repair.Car.Model}";
                }
                dataGridRepairs.DataSource = repairs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading repairs: " + ex.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridRepairs.CurrentRow != null && IsInputValid())
            {
                var selectedRepair = dataGridRepairs.CurrentRow.DataBoundItem as Repair;

                if (selectedRepair != null)
                {
                    selectedRepair.ReportDate = ReportDatePicker.Value;
                    selectedRepair.Description = DescriptionTextBox.Text;

                    if (Enum.TryParse(RepairStatusComboBox.Text, out RepairStatus status))
                    {
                        selectedRepair.Status = status;

                        // Ustawianie wartości EndDate w zależności od statusu
                        if (status == RepairStatus.Done)
                        {
                            selectedRepair.EndDate = EndDatePicker.Value;
                        }
                        else
                        {
                            selectedRepair.EndDate = null; // Ustaw null dla innych statusów
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid status selected. Please choose a valid status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    selectedRepair.Cost = decimal.TryParse(CostTextBox.Text, out var cost) ? cost : 0;

                    _repairService.UpdateRepair(selectedRepair);
                    LoadRepairs();
                    ResetInputs();
                    MessageBox.Show("Repair updated successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a repair and fill in all fields.");
            }
        }


        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (dataGridRepairs.CurrentRow != null)
            {
                var selectedRepair = dataGridRepairs.CurrentRow.DataBoundItem as Repair;

                if (selectedRepair != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this repair?",
                                                        "Delete Confirmation",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        _repairService.RemoveRepair(selectedRepair.Id);
                        LoadRepairs();
                        ResetInputs();
                        MessageBox.Show("Repair has been removed successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a repair to remove.");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetInputs();
            dataGridRepairs.ClearSelection();
        }

        private void ResetInputs()
        {
            CarTextBox.Clear();
            DescriptionTextBox.Clear();
            RepairStatusComboBox.SelectedIndex = -1;
            CostTextBox.Clear();
            ReportDatePicker.Value = DateTime.Now;
            EndDatePicker.Value = DateTime.Now;
        }

        private bool IsInputValid()
        {
            return !string.IsNullOrWhiteSpace(CarTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(DescriptionTextBox.Text) &&
                   RepairStatusComboBox.SelectedIndex != -1 &&
                   !string.IsNullOrWhiteSpace(CostTextBox.Text);
        }

        private void DataGridRepairs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRepair = dataGridRepairs.Rows[e.RowIndex].DataBoundItem as Repair;

                if (selectedRepair != null)
                {
                    CarTextBox.Text = $"{selectedRepair.Car.Brand} {selectedRepair.Car.Model}";
                    DescriptionTextBox.Text = selectedRepair.Description;
                    RepairStatusComboBox.Text = selectedRepair.Status.ToString();
                    CostTextBox.Text = selectedRepair.Cost.ToString();
                    ReportDatePicker.Value = selectedRepair.ReportDate;
                    EndDatePicker.Value = selectedRepair.EndDate ?? DateTime.Now;
                }
            }
        }

        private void SearchRepairs()
        {
            try
            {
                List<Repair> repairs = _repairService.GetAllRepairs();

                if (!string.IsNullOrWhiteSpace(SearchCarTextBox.Text))
                {
                    repairs = repairs.Where(r =>
                        $"{r.Car.Brand} {r.Car.Model}".Contains(SearchCarTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (SearchStatusComboBox.SelectedIndex != -1)
                {
                    if (Enum.TryParse(SearchStatusComboBox.SelectedItem.ToString(), out RepairStatus status))
                    {
                        repairs = repairs.Where(r => r.Status == status).ToList();
                    }
                }

                if (ReportDateFromPicker.Value.Date <= ReportDateToPicker.Value.Date)
                {
                    repairs = repairs.Where(r =>
                        r.ReportDate.Date >= ReportDateFromPicker.Value.Date &&
                        r.ReportDate.Date <= ReportDateToPicker.Value.Date).ToList();
                }
                else
                {
                    MessageBox.Show("Invalid date range. Please correct the date range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (var repair in repairs)
                {
                    repair.CarDetails = $"{repair.Car.Brand} {repair.Car.Model}";
                }

                dataGridRepairs.DataSource = repairs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching repairs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchRepairs();
        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            ResetSearchFilters();
            LoadRepairs();
        }

        private void ResetSearchFilters()
        {
            SearchCarTextBox.Clear();
            SearchStatusComboBox.SelectedIndex = -1;
            ReportDateFromPicker.Value = DateTime.Now.AddMonths(-1);
            ReportDateToPicker.Value = DateTime.Now;
        }
    }
}
