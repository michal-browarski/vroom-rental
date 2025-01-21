﻿namespace VroomRental.Forms
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployees).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
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
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1368, 272);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search employee";
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 25F);
            SearchButton.Location = new Point(1172, 196);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(175, 71);
            SearchButton.TabIndex = 40;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchResetButton
            // 
            SearchResetButton.Font = new Font("Segoe UI", 25F);
            SearchResetButton.Location = new Point(1172, 47);
            SearchResetButton.Margin = new Padding(3, 2, 3, 2);
            SearchResetButton.Name = "SearchResetButton";
            SearchResetButton.Size = new Size(175, 71);
            SearchResetButton.TabIndex = 39;
            SearchResetButton.Text = "Reset";
            SearchResetButton.UseVisualStyleBackColor = true;
            // 
            // SearchLoginTextBox
            // 
            SearchLoginTextBox.Font = new Font("Segoe UI", 25F);
            SearchLoginTextBox.Location = new Point(528, 208);
            SearchLoginTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchLoginTextBox.Name = "SearchLoginTextBox";
            SearchLoginTextBox.Size = new Size(294, 52);
            SearchLoginTextBox.TabIndex = 36;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 25F);
            label12.Location = new Point(528, 160);
            label12.Name = "label12";
            label12.Size = new Size(103, 46);
            label12.TabIndex = 35;
            label12.Text = "Login";
            // 
            // SearchRoleTextBox
            // 
            SearchRoleTextBox.Font = new Font("Segoe UI", 25F);
            SearchRoleTextBox.Location = new Point(125, 208);
            SearchRoleTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchRoleTextBox.Name = "SearchRoleTextBox";
            SearchRoleTextBox.Size = new Size(294, 52);
            SearchRoleTextBox.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 25F);
            label11.Location = new Point(125, 160);
            label11.Name = "label11";
            label11.Size = new Size(85, 46);
            label11.TabIndex = 33;
            label11.Text = "Role";
            // 
            // SearchLastNameTextBox
            // 
            SearchLastNameTextBox.Font = new Font("Segoe UI", 25F);
            SearchLastNameTextBox.Location = new Point(125, 98);
            SearchLastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchLastNameTextBox.Name = "SearchLastNameTextBox";
            SearchLastNameTextBox.Size = new Size(294, 52);
            SearchLastNameTextBox.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 25F);
            label10.Location = new Point(528, 47);
            label10.Name = "label10";
            label10.Size = new Size(177, 46);
            label10.TabIndex = 31;
            label10.Text = "Last Name";
            // 
            // SearchFirstNameTextBox
            // 
            SearchFirstNameTextBox.Font = new Font("Segoe UI", 25F);
            SearchFirstNameTextBox.Location = new Point(528, 98);
            SearchFirstNameTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchFirstNameTextBox.Name = "SearchFirstNameTextBox";
            SearchFirstNameTextBox.Size = new Size(294, 52);
            SearchFirstNameTextBox.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 25F);
            label9.Location = new Point(121, 47);
            label9.Name = "label9";
            label9.Size = new Size(181, 46);
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
            dataGridEmployees.Location = new Point(28, 290);
            dataGridEmployees.MultiSelect = false;
            dataGridEmployees.Name = "dataGridEmployees";
            dataGridEmployees.ReadOnly = true;
            dataGridEmployees.RowHeadersVisible = false;
            dataGridEmployees.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEmployees.Size = new Size(1368, 663);
            dataGridEmployees.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
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
            groupBox2.Font = new Font("Segoe UI", 25F);
            groupBox2.Location = new Point(1413, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(801, 946);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Employee Details";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox4.Controls.Add(AddButton);
            groupBox4.Controls.Add(ResetButton);
            groupBox4.Controls.Add(RemoveButton);
            groupBox4.Controls.Add(EditButton);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Location = new Point(34, 643);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(761, 298);
            groupBox4.TabIndex = 45;
            groupBox4.TabStop = false;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 25F);
            AddButton.Location = new Point(36, 66);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(299, 76);
            AddButton.TabIndex = 18;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            ResetButton.Font = new Font("Segoe UI", 25F);
            ResetButton.Location = new Point(430, 193);
            ResetButton.Margin = new Padding(3, 2, 3, 2);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(299, 76);
            ResetButton.TabIndex = 23;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI", 25F);
            RemoveButton.Location = new Point(430, 66);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(299, 76);
            RemoveButton.TabIndex = 19;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 25F);
            EditButton.Location = new Point(41, 193);
            EditButton.Margin = new Padding(3, 2, 3, 2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(299, 76);
            EditButton.TabIndex = 20;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 25F);
            PasswordTextBox.Location = new Point(334, 349);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(444, 52);
            PasswordTextBox.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F);
            label4.Location = new Point(141, 351);
            label4.Name = "label4";
            label4.Size = new Size(160, 46);
            label4.TabIndex = 35;
            label4.Text = "Password";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Segoe UI", 25F);
            LoginTextBox.Location = new Point(334, 290);
            LoginTextBox.Margin = new Padding(3, 2, 3, 2);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(444, 52);
            LoginTextBox.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F);
            label3.Location = new Point(192, 292);
            label3.Name = "label3";
            label3.Size = new Size(103, 46);
            label3.TabIndex = 33;
            label3.Text = "Login";
            // 
            // RoleTextBox
            // 
            RoleTextBox.Font = new Font("Segoe UI", 25F);
            RoleTextBox.Location = new Point(334, 225);
            RoleTextBox.Margin = new Padding(3, 2, 3, 2);
            RoleTextBox.Name = "RoleTextBox";
            RoleTextBox.Size = new Size(444, 52);
            RoleTextBox.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(200, 230);
            label2.Name = "label2";
            label2.Size = new Size(85, 46);
            label2.TabIndex = 31;
            label2.Text = "Role";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Font = new Font("Segoe UI", 25F);
            LastNameTextBox.Location = new Point(334, 165);
            LastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(444, 52);
            LastNameTextBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(112, 167);
            label1.Name = "label1";
            label1.Size = new Size(177, 46);
            label1.TabIndex = 29;
            label1.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Font = new Font("Segoe UI", 25F);
            FirstNameTextBox.Location = new Point(334, 105);
            FirstNameTextBox.Margin = new Padding(3, 2, 3, 2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(444, 52);
            FirstNameTextBox.TabIndex = 28;
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Font = new Font("Segoe UI", 25F);
            BrandLabel.Location = new Point(96, 105);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(181, 46);
            BrandLabel.TabIndex = 27;
            BrandLabel.Text = "First Name";
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2224, 968);
            Controls.Add(groupBox2);
            Controls.Add(dataGridEmployees);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeesForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployees).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
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
        private GroupBox groupBox4;
        private Button AddButton;
        private Button ResetButton;
        private Button RemoveButton;
        private Button EditButton;
    }
}