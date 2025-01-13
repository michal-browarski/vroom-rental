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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            ReservationsButton = new Button();
            CarsButton = new Button();
            EmployeesButton = new Button();
            CustomersButton = new Button();
            StatsButton = new Button();
            RepairsButton = new Button();
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
            ReservationsButton.Visible = false;
            ReservationsButton.Click += ReservationsButton_Click;
            // 
            // CarsButton
            // 
            CarsButton.Font = new Font("Segoe UI", 50F);
            CarsButton.Location = new Point(21, 166);
            CarsButton.Margin = new Padding(3, 2, 3, 2);
            CarsButton.Name = "CarsButton";
            CarsButton.Size = new Size(655, 119);
            CarsButton.TabIndex = 1;
            CarsButton.Text = "Cars";
            CarsButton.UseVisualStyleBackColor = true;
            CarsButton.Visible = false;
            CarsButton.Click += CarsButton_Click;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Font = new Font("Segoe UI", 50F);
            EmployeesButton.Location = new Point(1006, 327);
            EmployeesButton.Margin = new Padding(3, 2, 3, 2);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(655, 119);
            EmployeesButton.TabIndex = 2;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseVisualStyleBackColor = true;
            EmployeesButton.Visible = false;
            EmployeesButton.Click += EmployeesButton_Click;
            // 
            // CustomersButton
            // 
            CustomersButton.Font = new Font("Segoe UI", 50F);
            CustomersButton.Location = new Point(21, 327);
            CustomersButton.Margin = new Padding(3, 2, 3, 2);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(655, 119);
            CustomersButton.TabIndex = 3;
            CustomersButton.Text = "Customers";
            CustomersButton.UseVisualStyleBackColor = true;
            CustomersButton.Visible = false;
            CustomersButton.Click += CustomersButton_Click;
            // 
            // StatsButton
            // 
            StatsButton.Font = new Font("Segoe UI", 50F);
            StatsButton.Location = new Point(21, 496);
            StatsButton.Margin = new Padding(3, 2, 3, 2);
            StatsButton.Name = "StatsButton";
            StatsButton.Size = new Size(655, 119);
            StatsButton.TabIndex = 4;
            StatsButton.Text = "Statistics";
            StatsButton.UseVisualStyleBackColor = true;
            StatsButton.Visible = false;
            StatsButton.Click += StatsButton_Click;
            // 
            // RepairsButton
            // 
            RepairsButton.Font = new Font("Segoe UI", 50F);
            RepairsButton.Location = new Point(1006, 18);
            RepairsButton.Margin = new Padding(3, 2, 3, 2);
            RepairsButton.Name = "RepairsButton";
            RepairsButton.Size = new Size(655, 119);
            RepairsButton.TabIndex = 5;
            RepairsButton.Text = "Repairs";
            RepairsButton.UseVisualStyleBackColor = true;
            RepairsButton.Visible = false;
            RepairsButton.Click += RepairsButton_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 790);
            Controls.Add(RepairsButton);
            Controls.Add(StatsButton);
            Controls.Add(CustomersButton);
            Controls.Add(EmployeesButton);
            Controls.Add(CarsButton);
            Controls.Add(ReservationsButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vroom Rental";
            WindowState = FormWindowState.Maximized;
            Load += AdminPanel_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ReservationsButton;
        private Button CarsButton;
        private Button EmployeesButton;
        private Button CustomersButton;
        private Button StatsButton;
        private Button RepairsButton;
    }
}