using System;
using System.Windows.Forms;
using VroomRental.Backend.Model;

namespace VroomRental.Forms
{
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeDetailsForm(Employee employee)
        {
            InitializeComponent();

            // Wypełnij pola tekstowe danymi pracownika
            txtId.Text = employee.Id.ToString();
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtRole.Text = employee.Role;
            txtLogin.Text = employee.Login;
        }
    }
}
