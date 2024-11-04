using System;
using System.Windows.Forms;

namespace VroomRental.Forms
{
    public partial class CustomerDetailsForm : Form
    {
        public CustomerDetailsForm(Customer customer)
        {
            InitializeComponent();

            // Wypełnij pola tekstowe danymi klienta
            txtId.Text = customer.Id.ToString();
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtPhone.Text = customer.Phone;
            txtEmail.Text = customer.Email;
            txtDriverLicenceNumber.Text = customer.DriverLicenceNumber;
            txtAddress.Text = customer.FullAddress; // Wyświetla pełny adres
        }
    }
}
