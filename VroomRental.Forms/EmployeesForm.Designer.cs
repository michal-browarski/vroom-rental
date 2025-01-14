namespace VroomRental.Forms
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            groupBox1 = new GroupBox();
            SearchButton = new Button();
            SearchResetButton = new Button();
            SearchLoginTextBox = new TextBox();
            label12 = new Label();
            SearchRoleTextBox = new TextBox();
            label11 = new Label();
            SearchLastNameTextBox = new TextBox();
            label10 = new Label();
            SearchFirstNameTextBox = new TextBox();
            label9 = new Label();
            dataGridEmployees = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            AddButton = new Button();
            ResetButton = new Button();
            RemoveButton = new Button();
            EditButton = new Button();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            PasswordTextBox = new TextBox();
            label4 = new Label();
            LoginTextBox = new TextBox();
            label3 = new Label();
            RoleTextBox = new TextBox();
            label2 = new Label();
            LastNameTextBox = new TextBox();
            label1 = new Label();
            FirstNameTextBox = new TextBox();
            BrandLabel = new Label();
            ActionsGroupBox = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployees).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SearchButton);
            groupBox1.Controls.Add(SearchResetButton);
            groupBox1.Controls.Add(SearchLoginTextBox);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(SearchRoleTextBox);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(SearchLastNameTextBox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(SearchFirstNameTextBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Segoe UI", 25F);
            groupBox1.Location = new Point(32, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1564, 363);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search customer";
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 25F);
            SearchButton.Location = new Point(1340, 261);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(200, 95);
            SearchButton.TabIndex = 40;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchResetButton
            // 
            SearchResetButton.Font = new Font("Segoe UI", 25F);
            SearchResetButton.Location = new Point(1340, 63);
            SearchResetButton.Name = "SearchResetButton";
            SearchResetButton.Size = new Size(200, 95);
            SearchResetButton.TabIndex = 39;
            SearchResetButton.Text = "Reset";
            SearchResetButton.UseVisualStyleBackColor = true;
            // 
            // SearchLoginTextBox
            // 
            SearchLoginTextBox.Font = new Font("Segoe UI", 25F);
            SearchLoginTextBox.Location = new Point(603, 277);
            SearchLoginTextBox.Name = "SearchLoginTextBox";
            SearchLoginTextBox.Size = new Size(336, 63);
            SearchLoginTextBox.TabIndex = 36;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 25F);
            label12.Location = new Point(603, 213);
            label12.Name = "label12";
            label12.Size = new Size(129, 57);
            label12.TabIndex = 35;
            label12.Text = "Login";
            // 
            // SearchRoleTextBox
            // 
            SearchRoleTextBox.Font = new Font("Segoe UI", 25F);
            SearchRoleTextBox.Location = new Point(143, 277);
            SearchRoleTextBox.Name = "SearchRoleTextBox";
            SearchRoleTextBox.Size = new Size(336, 63);
            SearchRoleTextBox.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 25F);
            label11.Location = new Point(143, 213);
            label11.Name = "label11";
            label11.Size = new Size(106, 57);
            label11.TabIndex = 33;
            label11.Text = "Role";
            // 
            // SearchLastNameTextBox
            // 
            SearchLastNameTextBox.Font = new Font("Segoe UI", 25F);
            SearchLastNameTextBox.Location = new Point(143, 131);
            SearchLastNameTextBox.Name = "SearchLastNameTextBox";
            SearchLastNameTextBox.Size = new Size(336, 63);
            SearchLastNameTextBox.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 25F);
            label10.Location = new Point(603, 63);
            label10.Name = "label10";
            label10.Size = new Size(220, 57);
            label10.TabIndex = 31;
            label10.Text = "Last Name";
            // 
            // SearchFirstNameTextBox
            // 
            SearchFirstNameTextBox.Font = new Font("Segoe UI", 25F);
            SearchFirstNameTextBox.Location = new Point(603, 131);
            SearchFirstNameTextBox.Name = "SearchFirstNameTextBox";
            SearchFirstNameTextBox.Size = new Size(336, 63);
            SearchFirstNameTextBox.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 25F);
            label9.Location = new Point(138, 63);
            label9.Name = "label9";
            label9.Size = new Size(225, 57);
            label9.TabIndex = 29;
            label9.Text = "First Name";
            // 
            // dataGridEmployees
            // 
            dataGridEmployees.AllowUserToAddRows = false;
            dataGridEmployees.AllowUserToDeleteRows = false;
            dataGridEmployees.AllowUserToResizeColumns = false;
            dataGridEmployees.AllowUserToResizeRows = false;
            dataGridEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmployees.Location = new Point(32, 387);
            dataGridEmployees.Margin = new Padding(3, 4, 3, 4);
            dataGridEmployees.MultiSelect = false;
            dataGridEmployees.Name = "dataGridEmployees";
            dataGridEmployees.ReadOnly = true;
            dataGridEmployees.RowHeadersVisible = false;
            dataGridEmployees.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEmployees.Size = new Size(1564, 884);
            dataGridEmployees.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(PasswordTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(LoginTextBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(RoleTextBox);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(LastNameTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(FirstNameTextBox);
            groupBox2.Controls.Add(BrandLabel);
            groupBox2.Controls.Add(ActionsGroupBox);
            groupBox2.Font = new Font("Segoe UI", 25F);
            groupBox2.Location = new Point(1615, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(915, 1262);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customer Details";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox4.Controls.Add(AddButton);
            groupBox4.Controls.Add(ResetButton);
            groupBox4.Controls.Add(RemoveButton);
            groupBox4.Controls.Add(EditButton);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Location = new Point(39, 857);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(870, 398);
            groupBox4.TabIndex = 45;
            groupBox4.TabStop = false;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 25F);
            AddButton.Location = new Point(41, 88);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(342, 101);
            AddButton.TabIndex = 18;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            ResetButton.Font = new Font("Segoe UI", 25F);
            ResetButton.Location = new Point(491, 257);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(342, 101);
            ResetButton.TabIndex = 23;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI", 25F);
            RemoveButton.Location = new Point(491, 88);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(342, 101);
            RemoveButton.TabIndex = 19;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 25F);
            EditButton.Location = new Point(47, 257);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(342, 101);
            EditButton.TabIndex = 20;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button4);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(693, 1675);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(414, 257);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(7, 43);
            button1.Name = "button1";
            button1.Size = new Size(154, 73);
            button1.TabIndex = 18;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F);
            button2.Location = new Point(251, 175);
            button2.Name = "button2";
            button2.Size = new Size(154, 73);
            button2.TabIndex = 23;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F);
            button3.Location = new Point(251, 43);
            button3.Name = "button3";
            button3.Size = new Size(154, 73);
            button3.TabIndex = 19;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F);
            button4.Location = new Point(7, 175);
            button4.Name = "button4";
            button4.Size = new Size(154, 73);
            button4.TabIndex = 20;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 25F);
            PasswordTextBox.Location = new Point(382, 465);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(507, 63);
            PasswordTextBox.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F);
            label4.Location = new Point(161, 468);
            label4.Name = "label4";
            label4.Size = new Size(200, 57);
            label4.TabIndex = 35;
            label4.Text = "Password";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Segoe UI", 25F);
            LoginTextBox.Location = new Point(382, 386);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(507, 63);
            LoginTextBox.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F);
            label3.Location = new Point(219, 389);
            label3.Name = "label3";
            label3.Size = new Size(129, 57);
            label3.TabIndex = 33;
            label3.Text = "Login";
            // 
            // RoleTextBox
            // 
            RoleTextBox.Font = new Font("Segoe UI", 25F);
            RoleTextBox.Location = new Point(382, 300);
            RoleTextBox.Name = "RoleTextBox";
            RoleTextBox.Size = new Size(507, 63);
            RoleTextBox.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(229, 306);
            label2.Name = "label2";
            label2.Size = new Size(106, 57);
            label2.TabIndex = 31;
            label2.Text = "Role";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Font = new Font("Segoe UI", 25F);
            LastNameTextBox.Location = new Point(382, 220);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(507, 63);
            LastNameTextBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(128, 223);
            label1.Name = "label1";
            label1.Size = new Size(220, 57);
            label1.TabIndex = 29;
            label1.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Font = new Font("Segoe UI", 25F);
            FirstNameTextBox.Location = new Point(382, 140);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(507, 63);
            FirstNameTextBox.TabIndex = 28;
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Font = new Font("Segoe UI", 25F);
            BrandLabel.Location = new Point(110, 140);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(225, 57);
            BrandLabel.TabIndex = 27;
            BrandLabel.Text = "First Name";
            // 
            // ActionsGroupBox
            // 
            ActionsGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ActionsGroupBox.FlatStyle = FlatStyle.Flat;
            ActionsGroupBox.Location = new Point(898, 2352);
            ActionsGroupBox.Name = "ActionsGroupBox";
            ActionsGroupBox.Size = new Size(414, 257);
            ActionsGroupBox.TabIndex = 25;
            ActionsGroupBox.TabStop = false;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2542, 1291);
            Controls.Add(groupBox2);
            Controls.Add(dataGridEmployees);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeesForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployees).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button SearchButton;
        private Button SearchResetButton;
        private TextBox SearchLoginTextBox;
        private Label label12;
        private TextBox SearchRoleTextBox;
        private Label label11;
        private TextBox SearchLastNameTextBox;
        private Label label10;
        private TextBox SearchFirstNameTextBox;
        private Label label9;
        private DataGridView dataGridEmployees;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox PasswordTextBox;
        private Label label4;
        private TextBox LoginTextBox;
        private Label label3;
        private TextBox RoleTextBox;
        private Label label2;
        private TextBox LastNameTextBox;
        private Label label1;
        private TextBox FirstNameTextBox;
        private Label BrandLabel;
        private GroupBox ActionsGroupBox;
        private GroupBox groupBox4;
        private Button AddButton;
        private Button ResetButton;
        private Button RemoveButton;
        private Button EditButton;
    }
}