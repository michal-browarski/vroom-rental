﻿using VroomRental.Backend.Model;

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
            }

            if (_currentUser.Role == "Customer Service")
            {
                ReservationsButton.Visible = true;
                CarsButton.Visible = true;
            }

            if (_currentUser.Role == "Repairs")
            {
                // Widoki dla napraw
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
    }
}
