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
            ReservationsButton.Location = new Point(21, 18);
            ReservationsButton.Margin = new Padding(3, 2, 3, 2);
            ReservationsButton.Name = "ReservationsButton";
            ReservationsButton.Size = new Size(655, 119);
            ReservationsButton.TabIndex = 0;
            ReservationsButton.Text = "Reservations";
            ReservationsButton.UseVisualStyleBackColor = true;
            ReservationsButton.Click += ReservationsButton_Click;
            // 
            // CarsButton
            // 
            CarsButton.Font = new Font("Segoe UI", 50F);
            CarsButton.Location = new Point(1016, 26);
            CarsButton.Margin = new Padding(3, 2, 3, 2);
            CarsButton.Name = "CarsButton";
            CarsButton.Size = new Size(655, 119);
            CarsButton.TabIndex = 1;
            CarsButton.Text = "Cars";
            CarsButton.UseVisualStyleBackColor = true;
            CarsButton.Click += CarsButton_Click;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Font = new Font("Segoe UI", 50F);
            EmployeesButton.Location = new Point(21, 198);
            EmployeesButton.Margin = new Padding(3, 2, 3, 2);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(655, 119);
            EmployeesButton.TabIndex = 2;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseVisualStyleBackColor = true;
            EmployeesButton.Click += EmployeesButton_Click;
            // 
            // CustomersButton
            // 
            CustomersButton.Font = new Font("Segoe UI", 50F);
            CustomersButton.Location = new Point(1016, 208);
            CustomersButton.Margin = new Padding(3, 2, 3, 2);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(655, 119);
            CustomersButton.TabIndex = 3;
            CustomersButton.Text = "Customers";
            CustomersButton.UseVisualStyleBackColor = true;
            CustomersButton.Click += CustomersButton_Click;
            // 
            // StatsButton
            // 
            StatsButton.Font = new Font("Segoe UI", 50F);
            StatsButton.Location = new Point(21, 385);
            StatsButton.Margin = new Padding(3, 2, 3, 2);
            StatsButton.Name = "StatsButton";
            StatsButton.Size = new Size(655, 119);
            StatsButton.TabIndex = 4;
            StatsButton.Text = "Statistics";
            StatsButton.UseVisualStyleBackColor = true;
            StatsButton.Click += StatsButton_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 790);
            Controls.Add(StatsButton);
            Controls.Add(CustomersButton);
            Controls.Add(EmployeesButton);
            Controls.Add(CarsButton);
            Controls.Add(ReservationsButton);
            Margin = new Padding(3, 2, 3, 2);
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