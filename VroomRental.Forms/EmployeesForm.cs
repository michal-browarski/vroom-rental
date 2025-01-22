using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;

namespace VroomRental.Forms
{
    public partial class EmployeesForm : Form
    {
        private readonly EmployeeService _employeeService;

        public EmployeesForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);

            _employeeService = new EmployeeService(databaseService);

            InitializeDataGridView();

            LoadEmployees();

            AddButton.Click += AddButton_Click;
            EditButton.Click += EditButton_Click;
            RemoveButton.Click += RemoveButton_Click;
            ResetButton.Click += ResetButton_Click;
            SearchButton.Click += SearchButton_Click;
            SearchResetButton.Click += SearchResetButton_Click;
            dataGridEmployees.CellClick += DataGridEmployees_CellClick;
        }

        private void LoadEmployees()
        {
            try
            {
                List<Employee> employees = _employeeService.GetAllEmployeesWithRole();
                dataGridEmployees.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void InitializeDataGridView()
        {
            dataGridEmployees.AutoGenerateColumns = false;

            dataGridEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "First Name",
                DataPropertyName = "FirstName",
                Name = "ColumnFirstName"
            });

            dataGridEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Last Name",
                DataPropertyName = "LastName",
                Name = "ColumnLastName"
            });

            dataGridEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Role",
                DataPropertyName = "Role",
                Name = "ColumnRole"
            });

            dataGridEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Login",
                DataPropertyName = "Login",
                Name = "ColumnLogin"
            });

            dataGridEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                try
                {
                    var roleId = GetRoleId(RoleTextBox.Text);
                    if (roleId == null)
                    {
                        MessageBox.Show("Invalid role. Please select a valid role (Admin, Customer Service, Repairs).");
                        return;
                    }

                    var newEmployee = new Employee
                    {
                        FirstName = FirstNameTextBox.Text,
                        LastName = LastNameTextBox.Text,
                        RoleId = roleId.Value, // Przypisanie ID roli
                        Login = LoginTextBox.Text,
                        Password = HashPassword(PasswordMaskedTextBox.Text) // Konwersja hasła na hash
                    };

                    _employeeService.AddEmployee(newEmployee);
                    LoadEmployees();
                    ResetInputs();
                    MessageBox.Show("Employee added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding employee: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private int? GetRoleId(string roleName)
        {
            var roles = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                { "Admin", 1 },
                { "Customer Service", 2 },
                { "Repairs", 3 }
            };

            if (roles.TryGetValue(roleName, out int roleId))
            {
                return roleId;
            }

            return null; // Jeśli nazwa roli jest nieprawidłowa
        }

        private byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridEmployees.CurrentRow != null && IsInputValid())
            {
                try
                {
                    var selectedEmployee = dataGridEmployees.CurrentRow.DataBoundItem as Employee;

                    if (selectedEmployee != null)
                    {
                        var roleId = GetRoleId(RoleTextBox.Text);
                        if (roleId == null)
                        {
                            MessageBox.Show("Invalid role. Please select a valid role (Admin, Customer Service, Repairs).");
                            return;
                        }

                        selectedEmployee.FirstName = FirstNameTextBox.Text;
                        selectedEmployee.LastName = LastNameTextBox.Text;
                        selectedEmployee.RoleId = roleId.Value; // Przypisanie ID roli
                        selectedEmployee.Login = LoginTextBox.Text;
                        selectedEmployee.Password = HashPassword(PasswordMaskedTextBox.Text); // Zakładamy, że hasło jest wprowadzone jako plain text

                        _employeeService.EditEmployee(selectedEmployee);
                        LoadEmployees();
                        ResetInputs();
                        MessageBox.Show("Employee updated successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating employee: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee and fill in all fields.");
            }
        }


        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (dataGridEmployees.CurrentRow != null)
            {
                var selectedEmployee = dataGridEmployees.CurrentRow.DataBoundItem as Employee;

                if (selectedEmployee != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this employee?",
                                                        "Delete Confirmation",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        _employeeService.RemoveEmployee(selectedEmployee.Id);
                        LoadEmployees();
                        ResetInputs();
                        MessageBox.Show("Employee has been removed successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to remove.");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetInputs();
            dataGridEmployees.ClearSelection();
        }

        private void ResetInputs()
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            RoleTextBox.Clear();
            LoginTextBox.Clear();
            PasswordMaskedTextBox.Clear();
        }

        private bool IsInputValid()
        {
            return !string.IsNullOrWhiteSpace(FirstNameTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(LastNameTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(RoleTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(LoginTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(PasswordMaskedTextBox.Text);
        }

        private void SearchEmployees()
        {
            try
            {
                List<Employee> employees = _employeeService.GetAllEmployeesWithRole();

                if (!string.IsNullOrWhiteSpace(SearchFirstNameTextBox.Text))
                {
                    employees = employees.Where(e => e.FirstName.Contains(SearchFirstNameTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (!string.IsNullOrWhiteSpace(SearchLastNameTextBox.Text))
                {
                    employees = employees.Where(e => e.LastName.Contains(SearchLastNameTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (!string.IsNullOrWhiteSpace(SearchRoleTextBox.Text))
                {
                    employees = employees.Where(e => e.Role.Contains(SearchRoleTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (!string.IsNullOrWhiteSpace(SearchLoginTextBox.Text))
                {
                    employees = employees.Where(e => e.Login.Contains(SearchLoginTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                dataGridEmployees.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during the search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetEmployees()
        {
            SearchFirstNameTextBox.Clear();
            SearchLastNameTextBox.Clear();
            SearchRoleTextBox.Clear();
            SearchLoginTextBox.Clear();
            LoadEmployees();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchEmployees();
        }

        private void SearchResetButton_Click(object sender, EventArgs e)
        {
            ResetEmployees();
        }

        private void DataGridEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedEmployee = dataGridEmployees.Rows[e.RowIndex].DataBoundItem as Employee;

                if (selectedEmployee != null)
                {
                    FirstNameTextBox.Text = selectedEmployee.FirstName;
                    LastNameTextBox.Text = selectedEmployee.LastName;
                    LoginTextBox.Text = selectedEmployee.Login;
                    PasswordMaskedTextBox.Text = "should-not-see";
                    RoleTextBox.Text = selectedEmployee.Role;
                }
            }
        }
    }
}
