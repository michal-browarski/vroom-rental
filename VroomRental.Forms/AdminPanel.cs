using VroomRental.Backend.Model;

namespace VroomRental.Forms
{
    public partial class AdminPanel : Form
    {
        private Form? activeFormInstance;
        private readonly Employee _currentUser;
        public AdminPanel(Employee currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void ReservationsButton_Click(object sender, EventArgs e)
        {
            if (activeFormInstance == null || activeFormInstance!.IsDisposed)
            {
                activeFormInstance = new CarReservationsForm(_currentUser);
                activeFormInstance.Show();
            }
            else
            {
                activeFormInstance.Focus();
            }
        }

        private void CarsButton_Click(object sender, EventArgs e)
        {
            if (activeFormInstance == null || activeFormInstance!.IsDisposed)
            {
                activeFormInstance = new CarsForm(_currentUser);
                activeFormInstance.Show();
            }
            else
            {
                activeFormInstance.Focus();
            }
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            if (activeFormInstance == null || activeFormInstance!.IsDisposed)
            {
                activeFormInstance = new StatsForm();
                activeFormInstance.Show();
            }
            else
            {
                activeFormInstance.Focus();
            }
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            if (activeFormInstance == null || activeFormInstance!.IsDisposed)
            {
                activeFormInstance = new CustomersForm();
                activeFormInstance.Show();
            }
            else
            {
                activeFormInstance.Focus();
            }
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            if (activeFormInstance == null || activeFormInstance!.IsDisposed)
            {
                activeFormInstance = new EmployeesForm();
                activeFormInstance.Show();
            }
            else
            {
                activeFormInstance.Focus();
            }
        }

        private void RepairsButton_Click(object sender, EventArgs e)
        {
            if (activeFormInstance == null || activeFormInstance!.IsDisposed)
            {
                activeFormInstance = new RepairsForm();
                activeFormInstance.Show();
            }
            else
            {
                activeFormInstance.Focus();
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            if (_currentUser.Role == "Admin")
            {
                EmployeesButton.Visible = true;
                CustomersButton.Visible = true;
                StatsButton.Visible = true;
                ReservationsButton.Visible = true;
                CarsButton.Visible = true;
                RepairsButton.Visible = true;

                //Admin View
                StatsButton.Location = new Point(130, 42);
                CustomersButton.Location = new Point(130, 235);
                EmployeesButton.Location = new Point(130, 421);
                CarsButton.Location = new Point(130, 632);
                RepairsButton.Location = new Point(130, 840);
                ReservationsButton.Location = new Point(130, 1026);
            }

            if (_currentUser.Role == "Customer Service")
            {
                ReservationsButton.Visible = true;
                CarsButton.Visible = true;

                //Customer Service View
                CarsButton.Location = new Point(130, 42);
                ReservationsButton.Location = new Point(130, 235);
            }

            if (_currentUser.Role == "Repairs")
            {
                RepairsButton.Visible = true;
                RepairsButton.Location = new Point(130, 42);
            }

            LoginLabel.Text = "Login: " + _currentUser.Login;
            FirstNameLabel.Text = "First Name: " + _currentUser.FirstName;
            LastNameLabel.Text = "Last Name: " + _currentUser.LastName;
            RoleLabel.Text = "Role: " + _currentUser.Role;
            IdLabel.Text = "User ID:" + _currentUser.Id.ToString();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
