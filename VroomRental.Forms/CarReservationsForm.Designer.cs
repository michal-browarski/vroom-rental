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
            SearchButton = new Button();
            SearchComboBox = new ComboBox();
            CarReservationDetailsGroupBox = new GroupBox();
            EditButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            PaymentTextBox = new TextBox();
            EmployeeTextBox = new TextBox();
            CarTextBox = new TextBox();
            CustomerTextBox = new TextBox();
            EndDateTextBox = new TextBox();
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
            SearchGroupBox.Location = new Point(25, 12);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(862, 68);
            SearchGroupBox.TabIndex = 5;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Text = "Search";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(680, 26);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(165, 28);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchComboBox
            // 
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Location = new Point(6, 27);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(151, 28);
            SearchComboBox.TabIndex = 1;
            // 
            // CarReservationDetailsGroupBox
            // 
            CarReservationDetailsGroupBox.Controls.Add(EditButton);
            CarReservationDetailsGroupBox.Controls.Add(RemoveButton);
            CarReservationDetailsGroupBox.Controls.Add(AddButton);
            CarReservationDetailsGroupBox.Controls.Add(PaymentTextBox);
            CarReservationDetailsGroupBox.Controls.Add(EmployeeTextBox);
            CarReservationDetailsGroupBox.Controls.Add(CarTextBox);
            CarReservationDetailsGroupBox.Controls.Add(CustomerTextBox);
            CarReservationDetailsGroupBox.Controls.Add(EndDateTextBox);
            CarReservationDetailsGroupBox.Controls.Add(StatusTextBox);
            CarReservationDetailsGroupBox.Controls.Add(StatusLabel);
            CarReservationDetailsGroupBox.Location = new Point(919, 22);
            CarReservationDetailsGroupBox.Name = "CarReservationDetailsGroupBox";
            CarReservationDetailsGroupBox.Size = new Size(344, 417);
            CarReservationDetailsGroupBox.TabIndex = 4;
            CarReservationDetailsGroupBox.TabStop = false;
            CarReservationDetailsGroupBox.Text = "Car reservation";
            // 
            // EditButton
            // 
            EditButton.Location = new Point(24, 355);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(111, 35);
            EditButton.TabIndex = 20;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(170, 288);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(111, 35);
            RemoveButton.TabIndex = 19;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(24, 288);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(111, 35);
            AddButton.TabIndex = 18;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // PaymentTextBox
            // 
            PaymentTextBox.Location = new Point(170, 234);
            PaymentTextBox.Name = "PaymentTextBox";
            PaymentTextBox.Size = new Size(125, 27);
            PaymentTextBox.TabIndex = 15;
            // 
            // EmployeeTextBox
            // 
            EmployeeTextBox.Location = new Point(170, 198);
            EmployeeTextBox.Name = "EmployeeTextBox";
            EmployeeTextBox.Size = new Size(125, 27);
            EmployeeTextBox.TabIndex = 14;
            // 
            // CarTextBox
            // 
            CarTextBox.Location = new Point(170, 165);
            CarTextBox.Name = "CarTextBox";
            CarTextBox.Size = new Size(125, 27);
            CarTextBox.TabIndex = 13;
            // 
            // CustomerTextBox
            // 
            CustomerTextBox.Location = new Point(170, 132);
            CustomerTextBox.Name = "CustomerTextBox";
            CustomerTextBox.Size = new Size(125, 27);
            CustomerTextBox.TabIndex = 12;
            // 
            // EndDateTextBox
            // 
            EndDateTextBox.Location = new Point(170, 99);
            EndDateTextBox.Name = "EndDateTextBox";
            EndDateTextBox.Size = new Size(125, 27);
            EndDateTextBox.TabIndex = 11;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(170, 34);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(125, 27);
            StatusTextBox.TabIndex = 9;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(80, 34);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(49, 20);
            StatusLabel.TabIndex = 0;
            StatusLabel.Text = "Status";
            // 
            // dataGridCarReservations
            // 
            dataGridCarReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCarReservations.Location = new Point(25, 99);
            dataGridCarReservations.Name = "dataGridCarReservations";
            dataGridCarReservations.RowHeadersWidth = 51;
            dataGridCarReservations.Size = new Size(862, 340);
            dataGridCarReservations.TabIndex = 3;
            // 
            // CarReservationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 475);
            Controls.Add(SearchGroupBox);
            Controls.Add(CarReservationDetailsGroupBox);
            Controls.Add(dataGridCarReservations);
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
        private Button RemoveButton;
        private Button AddButton;
        private TextBox StatusTextBox;

        public Label PaymentLabel { get; private set; }
        public Label EmployeeLabel { get; private set; }
        public Label CarLabel { get; private set; }
        public Label CustomerLabel { get; private set; }
        public Label EndDateLabel { get; private set; }
        public Label StartDateLabel { get; private set; }

        private TextBox LastInspectionTextBox;
        private TextBox PaymentTextBox;
        private TextBox EmployeeTextBox;
        private TextBox CarTextBox;
        private TextBox CustomerTextBox;
        private TextBox EndDateTextBox;

        public TextBox StartDateTextBox { get; private set; }

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
    }
}