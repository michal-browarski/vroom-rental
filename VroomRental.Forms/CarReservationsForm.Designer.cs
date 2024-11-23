﻿namespace VroomRental.Forms
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
            SearchButton = new Button();
            SearchComboBox = new ComboBox();
            CarReservationDetailsGroupBox = new GroupBox();
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
            SearchGroupBox.Controls.Add(SearchButton);
            SearchGroupBox.Controls.Add(SearchComboBox);
            SearchGroupBox.Location = new Point(22, 9);
            SearchGroupBox.Margin = new Padding(3, 2, 3, 2);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Padding = new Padding(3, 2, 3, 2);
            SearchGroupBox.Size = new Size(842, 51);
            SearchGroupBox.TabIndex = 5;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Text = "Search";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(595, 20);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(144, 21);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchComboBox
            // 
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Location = new Point(5, 20);
            SearchComboBox.Margin = new Padding(3, 2, 3, 2);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(133, 23);
            SearchComboBox.TabIndex = 1;
            // 
            // CarReservationDetailsGroupBox
            // 
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
            CarReservationDetailsGroupBox.Location = new Point(870, 11);
            CarReservationDetailsGroupBox.Margin = new Padding(3, 2, 3, 2);
            CarReservationDetailsGroupBox.Name = "CarReservationDetailsGroupBox";
            CarReservationDetailsGroupBox.Padding = new Padding(3, 2, 3, 2);
            CarReservationDetailsGroupBox.Size = new Size(301, 627);
            CarReservationDetailsGroupBox.TabIndex = 4;
            CarReservationDetailsGroupBox.TabStop = false;
            CarReservationDetailsGroupBox.Text = "Car reservation";
            // 
            // StartDateTextBox
            // 
            StartDateTextBox.Location = new Point(148, 160);
            StartDateTextBox.Margin = new Padding(3, 2, 3, 2);
            StartDateTextBox.Name = "StartDateTextBox";
            StartDateTextBox.Size = new Size(110, 23);
            StartDateTextBox.TabIndex = 34;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(161, 586);
            ResetButton.Margin = new Padding(3, 2, 3, 2);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(97, 26);
            ResetButton.TabIndex = 33;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 163);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 32;
            label8.Text = "Start Date";
            // 
            // AdditionalOptionsCheckedListBox
            // 
            AdditionalOptionsCheckedListBox.FormattingEnabled = true;
            AdditionalOptionsCheckedListBox.Location = new Point(24, 272);
            AdditionalOptionsCheckedListBox.Name = "AdditionalOptionsCheckedListBox";
            AdditionalOptionsCheckedListBox.Size = new Size(234, 130);
            AdditionalOptionsCheckedListBox.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 254);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 29;
            label7.Text = "Additinal Options";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 190);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 27;
            label6.Text = "Planned End Date";
            // 
            // PlannedEndDateTextBox
            // 
            PlannedEndDateTextBox.Location = new Point(149, 187);
            PlannedEndDateTextBox.Margin = new Padding(3, 2, 3, 2);
            PlannedEndDateTextBox.Name = "PlannedEndDateTextBox";
            PlannedEndDateTextBox.Size = new Size(110, 23);
            PlannedEndDateTextBox.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 136);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 25;
            label5.Text = "Payment Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 109);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 24;
            label4.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 82);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 23;
            label3.Text = "Car Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 55);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 22;
            label2.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 217);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 21;
            label1.Text = "Actual End Date";
            // 
            // EditButton
            // 
            EditButton.Location = new Point(33, 586);
            EditButton.Margin = new Padding(3, 2, 3, 2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(97, 26);
            EditButton.TabIndex = 20;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // PaymentDetailsTextBox
            // 
            PaymentDetailsTextBox.Location = new Point(149, 133);
            PaymentDetailsTextBox.Margin = new Padding(3, 2, 3, 2);
            PaymentDetailsTextBox.Name = "PaymentDetailsTextBox";
            PaymentDetailsTextBox.Size = new Size(110, 23);
            PaymentDetailsTextBox.TabIndex = 15;
            // 
            // EmployeeNameTextBox
            // 
            EmployeeNameTextBox.Location = new Point(149, 106);
            EmployeeNameTextBox.Margin = new Padding(3, 2, 3, 2);
            EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            EmployeeNameTextBox.Size = new Size(110, 23);
            EmployeeNameTextBox.TabIndex = 14;
            // 
            // CarDetailsTextBox
            // 
            CarDetailsTextBox.Location = new Point(149, 79);
            CarDetailsTextBox.Margin = new Padding(3, 2, 3, 2);
            CarDetailsTextBox.Name = "CarDetailsTextBox";
            CarDetailsTextBox.Size = new Size(110, 23);
            CarDetailsTextBox.TabIndex = 13;
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(149, 52);
            CustomerNameTextBox.Margin = new Padding(3, 2, 3, 2);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(110, 23);
            CustomerNameTextBox.TabIndex = 12;
            // 
            // ActualEndDateTextBox
            // 
            ActualEndDateTextBox.Location = new Point(149, 214);
            ActualEndDateTextBox.Margin = new Padding(3, 2, 3, 2);
            ActualEndDateTextBox.Name = "ActualEndDateTextBox";
            ActualEndDateTextBox.Size = new Size(110, 23);
            ActualEndDateTextBox.TabIndex = 11;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(149, 26);
            StatusTextBox.Margin = new Padding(3, 2, 3, 2);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(110, 23);
            StatusTextBox.TabIndex = 9;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(85, 29);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(39, 15);
            StatusLabel.TabIndex = 0;
            StatusLabel.Text = "Status";
            // 
            // dataGridCarReservations
            // 
            dataGridCarReservations.AllowUserToAddRows = false;
            dataGridCarReservations.AllowUserToDeleteRows = false;
            dataGridCarReservations.AllowUserToResizeRows = false;
            dataGridCarReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCarReservations.Location = new Point(22, 74);
            dataGridCarReservations.Margin = new Padding(3, 2, 3, 2);
            dataGridCarReservations.MultiSelect = false;
            dataGridCarReservations.Name = "dataGridCarReservations";
            dataGridCarReservations.ReadOnly = true;
            dataGridCarReservations.RowHeadersVisible = false;
            dataGridCarReservations.RowHeadersWidth = 51;
            dataGridCarReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCarReservations.Size = new Size(842, 564);
            dataGridCarReservations.TabIndex = 3;
            // 
            // CarReservationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 649);
            Controls.Add(SearchGroupBox);
            Controls.Add(CarReservationDetailsGroupBox);
            Controls.Add(dataGridCarReservations);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CarReservationsForm";
            Text = "CarReservationsForm";
            SearchGroupBox.ResumeLayout(false);
            CarReservationDetailsGroupBox.ResumeLayout(false);
            CarReservationDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCarReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SearchGroupBox;
        private Button SearchButton;
        private ComboBox SearchComboBox;
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
    }
}