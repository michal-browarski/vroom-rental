using Newtonsoft.Json.Bson;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;

namespace VroomRental.Forms
{
    public partial class LoginForm : Form
    {
        private readonly EmployeeService _employeeService;
        private Employee? _currentUser;
        public LoginForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);

            _employeeService = new EmployeeService(databaseService);
            _currentUser = null;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!VerifyPassword(PasswordMaskedTextBox.Text, LoginTextBox.Text))
            {
                MessageBox.Show("Nieprawidłowy login lub hasło. Spróbuj ponownie");
            }
            else
            {
                SetCurrentUser(LoginTextBox.Text);
                EnterAdminPanel();
            }
        }
        private byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPassword(string enteredPassword, string login)
        {
            byte[] enteredPasswordHash = HashPassword(enteredPassword);

            byte[] storedPasswordHash = _employeeService.GetStoredPasswordHashFromDatabase(login);

            if (storedPasswordHash == null)
                return false;

            return enteredPasswordHash.SequenceEqual(storedPasswordHash);
        }

        private void SetCurrentUser(string login)
        {
            _currentUser = _employeeService.GetAllEmployeesWithRole()
                .Where(e => e.Login == login)
                .FirstOrDefault();
        }

        private void EnterAdminPanel()
        {
            this.Hide();
            AdminPanel adminPanel = new AdminPanel(_currentUser);
            adminPanel.FormClosed += (s, args) => this.Close();
            adminPanel.Show();
        }
    }
}
