namespace VroomRental.Forms
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ReservationsButton = new Button();
            CarsButton = new Button();
            EmployeesButton = new Button();
            CustomersButton = new Button();
            StatsButton = new Button();
            SuspendLayout();
            // 
            // ReservationsButton
            // 
            ReservationsButton.Font = new Font("Segoe UI", 50F);
            ReservationsButton.Location = new Point(24, 24);
            ReservationsButton.Name = "ReservationsButton";
            ReservationsButton.Size = new Size(749, 159);
            ReservationsButton.TabIndex = 0;
            ReservationsButton.Text = "Reservations";
            ReservationsButton.UseVisualStyleBackColor = true;
            ReservationsButton.Click += ReservationsButton_Click;
            // 
            // CarsButton
            // 
            CarsButton.Font = new Font("Segoe UI", 50F);
            CarsButton.Location = new Point(1161, 34);
            CarsButton.Name = "CarsButton";
            CarsButton.Size = new Size(749, 159);
            CarsButton.TabIndex = 1;
            CarsButton.Text = "Cars";
            CarsButton.UseVisualStyleBackColor = true;
            CarsButton.Click += CarsButton_Click;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Font = new Font("Segoe UI", 50F);
            EmployeesButton.Location = new Point(24, 264);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(749, 159);
            EmployeesButton.TabIndex = 2;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseVisualStyleBackColor = true;
            // 
            // CustomersButton
            // 
            CustomersButton.Font = new Font("Segoe UI", 50F);
            CustomersButton.Location = new Point(1161, 277);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(749, 159);
            CustomersButton.TabIndex = 3;
            CustomersButton.Text = "Customers";
            CustomersButton.UseVisualStyleBackColor = true;
            // 
            // StatsButton
            // 
            StatsButton.Font = new Font("Segoe UI", 50F);
            StatsButton.Location = new Point(24, 513);
            StatsButton.Name = "StatsButton";
            StatsButton.Size = new Size(749, 159);
            StatsButton.TabIndex = 4;
            StatsButton.Text = "Statistics";
            StatsButton.UseVisualStyleBackColor = true;
            StatsButton.Click += StatsButton_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1955, 1054);
            Controls.Add(StatsButton);
            Controls.Add(CustomersButton);
            Controls.Add(EmployeesButton);
            Controls.Add(CarsButton);
            Controls.Add(ReservationsButton);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Admin Panel";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button ReservationsButton;
        private Button CarsButton;
        private Button EmployeesButton;
        private Button CustomersButton;
        private Button StatsButton;
    }
}