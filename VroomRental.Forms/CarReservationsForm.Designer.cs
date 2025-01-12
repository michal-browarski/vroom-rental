namespace VroomRental.Forms
{
    partial class CarReservationsForm
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
            SearchGroupBox = new GroupBox();
            SearchStatusComboBox = new ComboBox();
            SearchEndDateTextBox = new TextBox();
            SearchStartDateTextBox = new TextBox();
            label13 = new Label();
            SearchCarDetailsTextBox = new TextBox();
            SearchCustomerTextBox = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            SearchResetButton = new Button();
            SearchButton = new Button();
            CarReservationDetailsGroupBox = new GroupBox();
            label14 = new Label();
            MileagePackageTextBox = new TextBox();
            StartDateTextBox = new TextBox();
            ResetButton = new Button();
            label8 = new Label();
            AdditionalOptionsCheckedListBox = new CheckedListBox();
            label7 = new Label();
            label6 = new Label();
            PlannedEndDateTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            EditButton = new Button();
            PaymentDetailsTextBox = new TextBox();
            EmployeeNameTextBox = new TextBox();
            CarDetailsTextBox = new TextBox();
            CustomerNameTextBox = new TextBox();
            ActualEndDateTextBox = new TextBox();
            StatusTextBox = new TextBox();
            StatusLabel = new Label();
            dataGridCarReservations = new DataGridView();
            SearchGroupBox.SuspendLayout();
            CarReservationDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCarReservations).BeginInit();
            SuspendLayout();
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Controls.Add(SearchStatusComboBox);
            SearchGroupBox.Controls.Add(SearchEndDateTextBox);
            SearchGroupBox.Controls.Add(SearchStartDateTextBox);
            SearchGroupBox.Controls.Add(label13);
            SearchGroupBox.Controls.Add(SearchCarDetailsTextBox);
            SearchGroupBox.Controls.Add(SearchCustomerTextBox);
            SearchGroupBox.Controls.Add(label12);
            SearchGroupBox.Controls.Add(label11);
            SearchGroupBox.Controls.Add(label10);
            SearchGroupBox.Controls.Add(label9);
            SearchGroupBox.Controls.Add(SearchResetButton);
            SearchGroupBox.Controls.Add(SearchButton);
            SearchGroupBox.Font = new Font("Segoe UI", 25F);
            SearchGroupBox.Location = new Point(25, 12);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(1690, 256);
            SearchGroupBox.TabIndex = 5;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Text = "Search";
            SearchGroupBox.Enter += SearchGroupBox_Enter;
            // 
            // SearchStatusComboBox
            // 
            SearchStatusComboBox.FormattingEnabled = true;
            SearchStatusComboBox.Location = new Point(1218, 171);
            SearchStatusComboBox.Margin = new Padding(3, 4, 3, 4);
            SearchStatusComboBox.Name = "SearchStatusComboBox";
            SearchStatusComboBox.Size = new Size(174, 65);
            SearchStatusComboBox.TabIndex = 10;
            // 
            // SearchEndDateTextBox
            // 
            SearchEndDateTextBox.Location = new Point(964, 171);
            SearchEndDateTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchEndDateTextBox.Name = "SearchEndDateTextBox";
            SearchEndDateTextBox.Size = new Size(174, 63);
            SearchEndDateTextBox.TabIndex = 9;
            // 
            // SearchStartDateTextBox
            // 
            SearchStartDateTextBox.Location = new Point(723, 171);
            SearchStartDateTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchStartDateTextBox.Name = "SearchStartDateTextBox";
            SearchStartDateTextBox.Size = new Size(174, 63);
            SearchStartDateTextBox.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 25F);
            label13.Location = new Point(955, 87);
            label13.Name = "label13";
            label13.Size = new Size(193, 57);
            label13.TabIndex = 7;
            label13.Text = "End Date";
            // 
            // SearchCarDetailsTextBox
            // 
            SearchCarDetailsTextBox.Location = new Point(435, 171);
            SearchCarDetailsTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchCarDetailsTextBox.Name = "SearchCarDetailsTextBox";
            SearchCarDetailsTextBox.Size = new Size(174, 63);
            SearchCarDetailsTextBox.TabIndex = 8;
            // 
            // SearchCustomerTextBox
            // 
            SearchCustomerTextBox.Location = new Point(114, 173);
            SearchCustomerTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchCustomerTextBox.Name = "SearchCustomerTextBox";
            SearchCustomerTextBox.Size = new Size(174, 63);
            SearchCustomerTextBox.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 25F);
            label12.Location = new Point(1239, 87);
            label12.Name = "label12";
            label12.Size = new Size(137, 57);
            label12.TabIndex = 6;
            label12.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 25F);
            label11.Location = new Point(708, 87);
            label11.Name = "label11";
            label11.Size = new Size(208, 57);
            label11.TabIndex = 6;
            label11.Text = "Start Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 25F);
            label10.Location = new Point(413, 87);
            label10.Name = "label10";
            label10.Size = new Size(223, 57);
            label10.TabIndex = 5;
            label10.Text = "Car Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 25F);
            label9.Location = new Point(114, 87);
            label9.Name = "label9";
            label9.Size = new Size(205, 57);
            label9.TabIndex = 4;
            label9.Text = "Customer";
            // 
            // SearchResetButton
            // 
            SearchResetButton.Font = new Font("Segoe UI", 25F);
            SearchResetButton.Location = new Point(1490, 52);
            SearchResetButton.Name = "SearchResetButton";
            SearchResetButton.Size = new Size(174, 63);
            SearchResetButton.TabIndex = 3;
            SearchResetButton.Text = "Reset";
            SearchResetButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 25F);
            SearchButton.Location = new Point(1490, 177);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(174, 63);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // CarReservationDetailsGroupBox
            // 
            CarReservationDetailsGroupBox.Controls.Add(label14);
            CarReservationDetailsGroupBox.Controls.Add(MileagePackageTextBox);
            CarReservationDetailsGroupBox.Controls.Add(StartDateTextBox);
            CarReservationDetailsGroupBox.Controls.Add(ResetButton);
            CarReservationDetailsGroupBox.Controls.Add(label8);
            CarReservationDetailsGroupBox.Controls.Add(AdditionalOptionsCheckedListBox);
            CarReservationDetailsGroupBox.Controls.Add(label7);
            CarReservationDetailsGroupBox.Controls.Add(label6);
            CarReservationDetailsGroupBox.Controls.Add(PlannedEndDateTextBox);
            CarReservationDetailsGroupBox.Controls.Add(label5);
            CarReservationDetailsGroupBox.Controls.Add(label4);
            CarReservationDetailsGroupBox.Controls.Add(label3);
            CarReservationDetailsGroupBox.Controls.Add(label2);
            CarReservationDetailsGroupBox.Controls.Add(label1);
            CarReservationDetailsGroupBox.Controls.Add(EditButton);
            CarReservationDetailsGroupBox.Controls.Add(PaymentDetailsTextBox);
            CarReservationDetailsGroupBox.Controls.Add(EmployeeNameTextBox);
            CarReservationDetailsGroupBox.Controls.Add(CarDetailsTextBox);
            CarReservationDetailsGroupBox.Controls.Add(CustomerNameTextBox);
            CarReservationDetailsGroupBox.Controls.Add(ActualEndDateTextBox);
            CarReservationDetailsGroupBox.Controls.Add(StatusTextBox);
            CarReservationDetailsGroupBox.Controls.Add(StatusLabel);
            CarReservationDetailsGroupBox.Font = new Font("Segoe UI", 25F);
            CarReservationDetailsGroupBox.Location = new Point(1737, 12);
            CarReservationDetailsGroupBox.Name = "CarReservationDetailsGroupBox";
            CarReservationDetailsGroupBox.Size = new Size(781, 1320);
            CarReservationDetailsGroupBox.TabIndex = 4;
            CarReservationDetailsGroupBox.TabStop = false;
            CarReservationDetailsGroupBox.Text = "Car reservation";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 658);
            label14.Name = "label14";
            label14.Size = new Size(337, 57);
            label14.TabIndex = 36;
            label14.Text = "Mileage Package";
            // 
            // MileagePackageTextBox
            // 
            MileagePackageTextBox.Location = new Point(349, 652);
            MileagePackageTextBox.Name = "MileagePackageTextBox";
            MileagePackageTextBox.Size = new Size(405, 63);
            MileagePackageTextBox.TabIndex = 35;
            // 
            // StartDateTextBox
            // 
            StartDateTextBox.Location = new Point(349, 444);
            StartDateTextBox.Name = "StartDateTextBox";
            StartDateTextBox.Size = new Size(405, 63);
            StartDateTextBox.TabIndex = 34;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(585, 1222);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(174, 63);
            ResetButton.TabIndex = 33;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(135, 450);
            label8.Name = "label8";
            label8.Size = new Size(208, 57);
            label8.TabIndex = 32;
            label8.Text = "Start Date";
            // 
            // AdditionalOptionsCheckedListBox
            // 
            AdditionalOptionsCheckedListBox.FormattingEnabled = true;
            AdditionalOptionsCheckedListBox.Location = new Point(44, 1037);
            AdditionalOptionsCheckedListBox.Margin = new Padding(3, 4, 3, 4);
            AdditionalOptionsCheckedListBox.Name = "AdditionalOptionsCheckedListBox";
            AdditionalOptionsCheckedListBox.Size = new Size(710, 178);
            AdditionalOptionsCheckedListBox.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 976);
            label7.Name = "label7";
            label7.Size = new Size(351, 57);
            label7.TabIndex = 29;
            label7.Text = "Additinal Options";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-12, 520);
            label6.Name = "label6";
            label6.Size = new Size(355, 57);
            label6.TabIndex = 27;
            label6.Text = "Planned End Date";
            // 
            // PlannedEndDateTextBox
            // 
            PlannedEndDateTextBox.Location = new Point(349, 514);
            PlannedEndDateTextBox.Name = "PlannedEndDateTextBox";
            PlannedEndDateTextBox.Size = new Size(405, 63);
            PlannedEndDateTextBox.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 381);
            label5.Name = "label5";
            label5.Size = new Size(321, 57);
            label5.TabIndex = 25;
            label5.Text = "Payment Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 174);
            label4.Name = "label4";
            label4.Size = new Size(328, 57);
            label4.TabIndex = 24;
            label4.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 312);
            label3.Name = "label3";
            label3.Size = new Size(223, 57);
            label3.TabIndex = 23;
            label3.Text = "Car Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 243);
            label2.Name = "label2";
            label2.Size = new Size(327, 57);
            label2.TabIndex = 22;
            label2.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 589);
            label1.Name = "label1";
            label1.Size = new Size(320, 57);
            label1.TabIndex = 21;
            label1.Text = "Actual End Date";
            // 
            // EditButton
            // 
            EditButton.Location = new Point(44, 1222);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(174, 63);
            EditButton.TabIndex = 20;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // PaymentDetailsTextBox
            // 
            PaymentDetailsTextBox.Location = new Point(349, 375);
            PaymentDetailsTextBox.Name = "PaymentDetailsTextBox";
            PaymentDetailsTextBox.Size = new Size(405, 63);
            PaymentDetailsTextBox.TabIndex = 15;
            // 
            // EmployeeNameTextBox
            // 
            EmployeeNameTextBox.Location = new Point(349, 168);
            EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            EmployeeNameTextBox.Size = new Size(405, 63);
            EmployeeNameTextBox.TabIndex = 14;
            // 
            // CarDetailsTextBox
            // 
            CarDetailsTextBox.Location = new Point(349, 306);
            CarDetailsTextBox.Name = "CarDetailsTextBox";
            CarDetailsTextBox.Size = new Size(405, 63);
            CarDetailsTextBox.TabIndex = 13;
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(349, 237);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(405, 63);
            CustomerNameTextBox.TabIndex = 12;
            // 
            // ActualEndDateTextBox
            // 
            ActualEndDateTextBox.Location = new Point(349, 583);
            ActualEndDateTextBox.Name = "ActualEndDateTextBox";
            ActualEndDateTextBox.Size = new Size(405, 63);
            ActualEndDateTextBox.TabIndex = 11;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(349, 99);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(405, 63);
            StatusTextBox.TabIndex = 9;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(206, 105);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(137, 57);
            StatusLabel.TabIndex = 0;
            StatusLabel.Text = "Status";
            // 
            // dataGridCarReservations
            // 
            dataGridCarReservations.AllowUserToAddRows = false;
            dataGridCarReservations.AllowUserToDeleteRows = false;
            dataGridCarReservations.AllowUserToResizeRows = false;
            dataGridCarReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCarReservations.Location = new Point(25, 283);
            dataGridCarReservations.MultiSelect = false;
            dataGridCarReservations.Name = "dataGridCarReservations";
            dataGridCarReservations.ReadOnly = true;
            dataGridCarReservations.RowHeadersVisible = false;
            dataGridCarReservations.RowHeadersWidth = 51;
            dataGridCarReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCarReservations.Size = new Size(1690, 1049);
            dataGridCarReservations.TabIndex = 3;
            // 
            // CarReservationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2542, 1360);
            Controls.Add(SearchGroupBox);
            Controls.Add(CarReservationDetailsGroupBox);
            Controls.Add(dataGridCarReservations);
            Name = "CarReservationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += CarReservationsForm_Load;
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
            CarReservationDetailsGroupBox.ResumeLayout(false);
            CarReservationDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCarReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SearchGroupBox;
        private Button SearchButton;
        private GroupBox CarReservationDetailsGroupBox;
        private Button EditButton;
        private TextBox StatusTextBox;

        public Label PaymentLabel { get; private set; }
        public Label EmployeeLabel { get; private set; }
        public Label CarLabel { get; private set; }
        public Label CustomerLabel { get; private set; }
        public Label EndDateLabel { get; private set; }
        public Label StartDateLabel { get; private set; }

        private TextBox LastInspectionTextBox;
        private TextBox PaymentDetailsTextBox;
        private TextBox EmployeeNameTextBox;
        private TextBox CarDetailsTextBox;
        private TextBox CustomerNameTextBox;
        private TextBox ActualEndDateTextBox;

        private TextBox ModelTextBox;
        private TextBox BrandTextBox;
        private Label LastInspectionLabel;
        private Label PriceLabel;
        private Label MileageLabel;
        private Label ProductionYearLabel;
        private Label StatusLabel;
        private Label ColorLabel;
        private Label BodyTypeLabel;
        private Label ModelLabel;
        private DataGridView dataGridCarReservations;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox PlannedEndDateTextBox;
        private Label label7;
        private CheckedListBox AdditionalOptionsCheckedListBox;
        private Label label8;
        private Button ResetButton;
        private TextBox StartDateTextBox;
        private Button SearchResetButton;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label12;
        private TextBox SearchCarDetailsTextBox;
        private TextBox SearchCustomerTextBox;
        private TextBox SearchEndDateTextBox;
        private TextBox SearchStartDateTextBox;
        private Label label13;
        private ComboBox SearchStatusComboBox;
        private Label label14;
        private TextBox MileagePackageTextBox;
    }
}