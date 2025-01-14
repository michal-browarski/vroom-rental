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
            UserInfoGroupBox = new GroupBox();
            LogoPictureBox = new PictureBox();
            LogoutButton = new Button();
            IdLabel = new Label();
            RoleLabel = new Label();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            LoginLabel = new Label();
            UserInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ReservationsButton
            // 
            ReservationsButton.Font = new Font("Segoe UI", 50F);
            ReservationsButton.Location = new Point(130, 1026);
            ReservationsButton.Name = "ReservationsButton";
            ReservationsButton.Size = new Size(1177, 159);
            ReservationsButton.TabIndex = 0;
            ReservationsButton.Text = "Reservations";
            ReservationsButton.UseVisualStyleBackColor = true;
            ReservationsButton.Visible = false;
            ReservationsButton.Click += ReservationsButton_Click;
            // 
            // CarsButton
            // 
            CarsButton.Font = new Font("Segoe UI", 50F);
            CarsButton.Location = new Point(130, 632);
            CarsButton.Name = "CarsButton";
            CarsButton.Size = new Size(1177, 159);
            CarsButton.TabIndex = 1;
            CarsButton.Text = "Cars";
            CarsButton.UseVisualStyleBackColor = true;
            CarsButton.Visible = false;
            CarsButton.Click += CarsButton_Click;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Font = new Font("Segoe UI", 50F);
            EmployeesButton.Location = new Point(130, 421);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(1177, 159);
            EmployeesButton.TabIndex = 2;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseVisualStyleBackColor = true;
            EmployeesButton.Visible = false;
            EmployeesButton.Click += EmployeesButton_Click;
            // 
            // CustomersButton
            // 
            CustomersButton.Font = new Font("Segoe UI", 50F);
            CustomersButton.Location = new Point(130, 235);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(1177, 159);
            CustomersButton.TabIndex = 3;
            CustomersButton.Text = "Customers";
            CustomersButton.UseVisualStyleBackColor = true;
            CustomersButton.Visible = false;
            CustomersButton.Click += CustomersButton_Click;
            // 
            // StatsButton
            // 
            StatsButton.Font = new Font("Segoe UI", 50F);
            StatsButton.Location = new Point(130, 42);
            StatsButton.Name = "StatsButton";
            StatsButton.Size = new Size(1177, 159);
            StatsButton.TabIndex = 4;
            StatsButton.Text = "Statistics";
            StatsButton.UseVisualStyleBackColor = true;
            StatsButton.Visible = false;
            StatsButton.Click += StatsButton_Click;
            // 
            // RepairsButton
            // 
            RepairsButton.Font = new Font("Segoe UI", 50F);
            RepairsButton.Location = new Point(130, 840);
            RepairsButton.Name = "RepairsButton";
            RepairsButton.Size = new Size(1177, 159);
            RepairsButton.TabIndex = 5;
            RepairsButton.Text = "Repairs";
            RepairsButton.UseVisualStyleBackColor = true;
            RepairsButton.Visible = false;
            RepairsButton.Click += RepairsButton_Click;
            // 
            // UserInfoGroupBox
            // 
            UserInfoGroupBox.Controls.Add(LogoPictureBox);
            UserInfoGroupBox.Controls.Add(LogoutButton);
            UserInfoGroupBox.Controls.Add(IdLabel);
            UserInfoGroupBox.Controls.Add(RoleLabel);
            UserInfoGroupBox.Controls.Add(LastNameLabel);
            UserInfoGroupBox.Controls.Add(FirstNameLabel);
            UserInfoGroupBox.Controls.Add(LoginLabel);
            UserInfoGroupBox.Font = new Font("Segoe UI", 25F);
            UserInfoGroupBox.Location = new Point(1374, 30);
            UserInfoGroupBox.Name = "UserInfoGroupBox";
            UserInfoGroupBox.Size = new Size(1138, 1338);
            UserInfoGroupBox.TabIndex = 6;
            UserInfoGroupBox.TabStop = false;
            UserInfoGroupBox.Text = "USER:";
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = (Image)resources.GetObject("LogoPictureBox.Image");
            LogoPictureBox.Location = new Point(682, 103);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(400, 400);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPictureBox.TabIndex = 6;
            LogoPictureBox.TabStop = false;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(299, 1038);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(587, 106);
            LogoutButton.TabIndex = 5;
            LogoutButton.Text = "Wyloguj";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(39, 512);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(61, 57);
            IdLabel.TabIndex = 4;
            IdLabel.Text = "Id";
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Location = new Point(39, 418);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(106, 57);
            RoleLabel.TabIndex = 3;
            RoleLabel.Text = "Role";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(39, 324);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(225, 57);
            LastNameLabel.TabIndex = 2;
            LastNameLabel.Text = "Last-Name";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(39, 223);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(230, 57);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First-Name";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(39, 129);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(119, 57);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "login";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2542, 1415);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(RepairsButton);
            Controls.Add(StatsButton);
            Controls.Add(CustomersButton);
            Controls.Add(EmployeesButton);
            Controls.Add(CarsButton);
            Controls.Add(ReservationsButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vroom Rental";
            WindowState = FormWindowState.Maximized;
            Load += AdminPanel_Load;
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ReservationsButton;
        private Button CarsButton;
        private Button EmployeesButton;
        private Button CustomersButton;
        private Button StatsButton;
        private Button RepairsButton;
        private GroupBox UserInfoGroupBox;
        private Button LogoutButton;
        private Label IdLabel;
        private Label RoleLabel;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private Label LoginLabel;
        private PictureBox LogoPictureBox;
    }
}