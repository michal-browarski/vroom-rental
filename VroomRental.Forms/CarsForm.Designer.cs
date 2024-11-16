namespace VroomRental.Forms
{
    partial class CarsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridCars = new DataGridView();
            CarDetailsGroupBox = new GroupBox();
            TextBoxesGroupBox = new GroupBox();
            FuelTypeTextBox = new TextBox();
            label7 = new Label();
            LastInspectionLabel = new Label();
            ModelTextBox = new TextBox();
            PriceLabel = new Label();
            BodyTypeTextBox = new TextBox();
            MileageLabel = new Label();
            BrandTextBox = new TextBox();
            ProductionYearLabel = new Label();
            ColorTextBox = new TextBox();
            StatusLabel = new Label();
            YearTextBox = new TextBox();
            ColorLabel = new Label();
            MileageTextBox = new TextBox();
            BodyTypeLabel = new Label();
            ModelLabel = new Label();
            PriceTextBox = new TextBox();
            BrandLabel = new Label();
            LastInspectionTextBox = new TextBox();
            StatusTextBox = new TextBox();
            ActionsGroupBox = new GroupBox();
            AddButton = new Button();
            ResetCarButton = new Button();
            RemoveButton = new Button();
            EditButton = new Button();
            SearchGroupBox = new GroupBox();
            SearchYearNumericUpDown2 = new NumericUpDown();
            SearchPriceNumericUpDown2 = new NumericUpDown();
            SearchFuelTypeComboBox = new ComboBox();
            label9 = new Label();
            ResetButton = new Button();
            SearchPriceNumericUpDown = new NumericUpDown();
            SearchYearNumericUpDown = new NumericUpDown();
            SearchStatusComboBox = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            SearchBodyTypeTextBox = new TextBox();
            label3 = new Label();
            SearchColorTextBox = new TextBox();
            label2 = new Label();
            SearchModelTextBox = new TextBox();
            label1 = new Label();
            SearchButton = new Button();
            SearchBrandTextBox = new TextBox();
            CarsTableLayout = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).BeginInit();
            CarDetailsGroupBox.SuspendLayout();
            TextBoxesGroupBox.SuspendLayout();
            ActionsGroupBox.SuspendLayout();
            SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchYearNumericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchPriceNumericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchPriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchYearNumericUpDown).BeginInit();
            CarsTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCars
            // 
            dataGridCars.AllowUserToAddRows = false;
            dataGridCars.AllowUserToDeleteRows = false;
            dataGridCars.AllowUserToResizeColumns = false;
            dataGridCars.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 18F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridCars.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridCars.Dock = DockStyle.Fill;
            dataGridCars.GridColor = SystemColors.Window;
            dataGridCars.Location = new Point(3, 208);
            dataGridCars.Margin = new Padding(3, 2, 3, 2);
            dataGridCars.MultiSelect = false;
            dataGridCars.Name = "dataGridCars";
            dataGridCars.ReadOnly = true;
            dataGridCars.RowHeadersVisible = false;
            dataGridCars.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridCars.RowTemplate.Height = 60;
            dataGridCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCars.Size = new Size(1504, 851);
            dataGridCars.TabIndex = 0;
            // 
            // CarDetailsGroupBox
            // 
            CarDetailsGroupBox.Controls.Add(TextBoxesGroupBox);
            CarDetailsGroupBox.Controls.Add(ActionsGroupBox);
            CarDetailsGroupBox.Dock = DockStyle.Fill;
            CarDetailsGroupBox.Font = new Font("Segoe UI", 18F);
            CarDetailsGroupBox.Location = new Point(1513, 2);
            CarDetailsGroupBox.Margin = new Padding(3, 2, 3, 2);
            CarDetailsGroupBox.Name = "CarDetailsGroupBox";
            CarDetailsGroupBox.Padding = new Padding(3, 2, 3, 2);
            CarsTableLayout.SetRowSpan(CarDetailsGroupBox, 2);
            CarDetailsGroupBox.Size = new Size(405, 1057);
            CarDetailsGroupBox.TabIndex = 1;
            CarDetailsGroupBox.TabStop = false;
            CarDetailsGroupBox.Text = "Car";
            // 
            // TextBoxesGroupBox
            // 
            TextBoxesGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TextBoxesGroupBox.Controls.Add(FuelTypeTextBox);
            TextBoxesGroupBox.Controls.Add(label7);
            TextBoxesGroupBox.Controls.Add(LastInspectionLabel);
            TextBoxesGroupBox.Controls.Add(ModelTextBox);
            TextBoxesGroupBox.Controls.Add(PriceLabel);
            TextBoxesGroupBox.Controls.Add(BodyTypeTextBox);
            TextBoxesGroupBox.Controls.Add(MileageLabel);
            TextBoxesGroupBox.Controls.Add(BrandTextBox);
            TextBoxesGroupBox.Controls.Add(ProductionYearLabel);
            TextBoxesGroupBox.Controls.Add(ColorTextBox);
            TextBoxesGroupBox.Controls.Add(StatusLabel);
            TextBoxesGroupBox.Controls.Add(YearTextBox);
            TextBoxesGroupBox.Controls.Add(ColorLabel);
            TextBoxesGroupBox.Controls.Add(MileageTextBox);
            TextBoxesGroupBox.Controls.Add(BodyTypeLabel);
            TextBoxesGroupBox.Controls.Add(ModelLabel);
            TextBoxesGroupBox.Controls.Add(PriceTextBox);
            TextBoxesGroupBox.Controls.Add(BrandLabel);
            TextBoxesGroupBox.Controls.Add(LastInspectionTextBox);
            TextBoxesGroupBox.Controls.Add(StatusTextBox);
            TextBoxesGroupBox.FlatStyle = FlatStyle.Flat;
            TextBoxesGroupBox.Location = new Point(4, 38);
            TextBoxesGroupBox.Margin = new Padding(3, 2, 3, 2);
            TextBoxesGroupBox.Name = "TextBoxesGroupBox";
            TextBoxesGroupBox.Padding = new Padding(3, 2, 3, 2);
            TextBoxesGroupBox.Size = new Size(396, 783);
            TextBoxesGroupBox.TabIndex = 25;
            TextBoxesGroupBox.TabStop = false;
            // 
            // FuelTypeTextBox
            // 
            FuelTypeTextBox.Font = new Font("Segoe UI", 18F);
            FuelTypeTextBox.Location = new Point(204, 178);
            FuelTypeTextBox.Margin = new Padding(3, 2, 3, 2);
            FuelTypeTextBox.Name = "FuelTypeTextBox";
            FuelTypeTextBox.Size = new Size(184, 39);
            FuelTypeTextBox.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(5, 178);
            label7.Name = "label7";
            label7.Size = new Size(117, 32);
            label7.TabIndex = 22;
            label7.Text = "Fuel Type";
            // 
            // LastInspectionLabel
            // 
            LastInspectionLabel.AutoSize = true;
            LastInspectionLabel.Font = new Font("Segoe UI", 18F);
            LastInspectionLabel.Location = new Point(5, 376);
            LastInspectionLabel.Name = "LastInspectionLabel";
            LastInspectionLabel.Size = new Size(172, 32);
            LastInspectionLabel.TabIndex = 8;
            LastInspectionLabel.Text = "Last inspection";
            // 
            // ModelTextBox
            // 
            ModelTextBox.Font = new Font("Segoe UI", 18F);
            ModelTextBox.Location = new Point(204, 98);
            ModelTextBox.Margin = new Padding(3, 2, 3, 2);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(184, 39);
            ModelTextBox.TabIndex = 10;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 18F);
            PriceLabel.Location = new Point(5, 337);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(115, 32);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Price/Day";
            // 
            // BodyTypeTextBox
            // 
            BodyTypeTextBox.Font = new Font("Segoe UI", 18F);
            BodyTypeTextBox.Location = new Point(204, 138);
            BodyTypeTextBox.Margin = new Padding(3, 2, 3, 2);
            BodyTypeTextBox.Name = "BodyTypeTextBox";
            BodyTypeTextBox.Size = new Size(184, 39);
            BodyTypeTextBox.TabIndex = 11;
            // 
            // MileageLabel
            // 
            MileageLabel.AutoSize = true;
            MileageLabel.Font = new Font("Segoe UI", 18F);
            MileageLabel.Location = new Point(5, 297);
            MileageLabel.Name = "MileageLabel";
            MileageLabel.Size = new Size(100, 32);
            MileageLabel.TabIndex = 6;
            MileageLabel.Text = "Mileage";
            // 
            // BrandTextBox
            // 
            BrandTextBox.Font = new Font("Segoe UI", 18F);
            BrandTextBox.Location = new Point(204, 58);
            BrandTextBox.Margin = new Padding(3, 2, 3, 2);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(184, 39);
            BrandTextBox.TabIndex = 9;
            // 
            // ProductionYearLabel
            // 
            ProductionYearLabel.AutoSize = true;
            ProductionYearLabel.Font = new Font("Segoe UI", 18F);
            ProductionYearLabel.Location = new Point(5, 218);
            ProductionYearLabel.Name = "ProductionYearLabel";
            ProductionYearLabel.Size = new Size(58, 32);
            ProductionYearLabel.TabIndex = 5;
            ProductionYearLabel.Text = "Year";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Font = new Font("Segoe UI", 18F);
            ColorTextBox.Location = new Point(204, 257);
            ColorTextBox.Margin = new Padding(3, 2, 3, 2);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(184, 39);
            ColorTextBox.TabIndex = 12;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 18F);
            StatusLabel.Location = new Point(5, 416);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(78, 32);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status";
            // 
            // YearTextBox
            // 
            YearTextBox.Font = new Font("Segoe UI", 18F);
            YearTextBox.Location = new Point(204, 218);
            YearTextBox.Margin = new Padding(3, 2, 3, 2);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(184, 39);
            YearTextBox.TabIndex = 13;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Font = new Font("Segoe UI", 18F);
            ColorLabel.Location = new Point(5, 257);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(71, 32);
            ColorLabel.TabIndex = 3;
            ColorLabel.Text = "Color";
            // 
            // MileageTextBox
            // 
            MileageTextBox.Font = new Font("Segoe UI", 18F);
            MileageTextBox.Location = new Point(204, 297);
            MileageTextBox.Margin = new Padding(3, 2, 3, 2);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.Size = new Size(184, 39);
            MileageTextBox.TabIndex = 14;
            // 
            // BodyTypeLabel
            // 
            BodyTypeLabel.AutoSize = true;
            BodyTypeLabel.Font = new Font("Segoe UI", 18F);
            BodyTypeLabel.Location = new Point(5, 138);
            BodyTypeLabel.Name = "BodyTypeLabel";
            BodyTypeLabel.Size = new Size(126, 32);
            BodyTypeLabel.TabIndex = 2;
            BodyTypeLabel.Text = "Body Type";
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Font = new Font("Segoe UI", 18F);
            ModelLabel.Location = new Point(5, 98);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(83, 32);
            ModelLabel.TabIndex = 1;
            ModelLabel.Text = "Model";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Font = new Font("Segoe UI", 18F);
            PriceTextBox.Location = new Point(204, 337);
            PriceTextBox.Margin = new Padding(3, 2, 3, 2);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(184, 39);
            PriceTextBox.TabIndex = 15;
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Font = new Font("Segoe UI", 18F);
            BrandLabel.Location = new Point(5, 58);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(76, 32);
            BrandLabel.TabIndex = 0;
            BrandLabel.Text = "Brand";
            // 
            // LastInspectionTextBox
            // 
            LastInspectionTextBox.Font = new Font("Segoe UI", 18F);
            LastInspectionTextBox.Location = new Point(204, 376);
            LastInspectionTextBox.Margin = new Padding(3, 2, 3, 2);
            LastInspectionTextBox.Name = "LastInspectionTextBox";
            LastInspectionTextBox.Size = new Size(184, 39);
            LastInspectionTextBox.TabIndex = 16;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Font = new Font("Segoe UI", 18F);
            StatusTextBox.Location = new Point(204, 416);
            StatusTextBox.Margin = new Padding(3, 2, 3, 2);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(184, 39);
            StatusTextBox.TabIndex = 17;
            // 
            // ActionsGroupBox
            // 
            ActionsGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ActionsGroupBox.Controls.Add(AddButton);
            ActionsGroupBox.Controls.Add(ResetCarButton);
            ActionsGroupBox.Controls.Add(RemoveButton);
            ActionsGroupBox.Controls.Add(EditButton);
            ActionsGroupBox.FlatStyle = FlatStyle.Flat;
            ActionsGroupBox.Location = new Point(4, 868);
            ActionsGroupBox.Margin = new Padding(3, 2, 3, 2);
            ActionsGroupBox.Name = "ActionsGroupBox";
            ActionsGroupBox.Padding = new Padding(3, 2, 3, 2);
            ActionsGroupBox.Size = new Size(393, 184);
            ActionsGroupBox.TabIndex = 24;
            ActionsGroupBox.TabStop = false;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 18F);
            AddButton.Location = new Point(5, 22);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(166, 59);
            AddButton.TabIndex = 18;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ResetCarButton
            // 
            ResetCarButton.Font = new Font("Segoe UI", 18F);
            ResetCarButton.Location = new Point(216, 121);
            ResetCarButton.Margin = new Padding(3, 2, 3, 2);
            ResetCarButton.Name = "ResetCarButton";
            ResetCarButton.Size = new Size(166, 59);
            ResetCarButton.TabIndex = 23;
            ResetCarButton.Text = "Reset";
            ResetCarButton.UseVisualStyleBackColor = true;
            ResetCarButton.Click += ResetCarButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI", 18F);
            RemoveButton.Location = new Point(216, 22);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(166, 59);
            RemoveButton.TabIndex = 19;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 18F);
            EditButton.Location = new Point(5, 121);
            EditButton.Margin = new Padding(3, 2, 3, 2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(166, 59);
            EditButton.TabIndex = 20;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Controls.Add(SearchYearNumericUpDown2);
            SearchGroupBox.Controls.Add(SearchPriceNumericUpDown2);
            SearchGroupBox.Controls.Add(SearchFuelTypeComboBox);
            SearchGroupBox.Controls.Add(label9);
            SearchGroupBox.Controls.Add(ResetButton);
            SearchGroupBox.Controls.Add(SearchPriceNumericUpDown);
            SearchGroupBox.Controls.Add(SearchYearNumericUpDown);
            SearchGroupBox.Controls.Add(SearchStatusComboBox);
            SearchGroupBox.Controls.Add(label8);
            SearchGroupBox.Controls.Add(label5);
            SearchGroupBox.Controls.Add(label6);
            SearchGroupBox.Controls.Add(label4);
            SearchGroupBox.Controls.Add(SearchBodyTypeTextBox);
            SearchGroupBox.Controls.Add(label3);
            SearchGroupBox.Controls.Add(SearchColorTextBox);
            SearchGroupBox.Controls.Add(label2);
            SearchGroupBox.Controls.Add(SearchModelTextBox);
            SearchGroupBox.Controls.Add(label1);
            SearchGroupBox.Controls.Add(SearchButton);
            SearchGroupBox.Controls.Add(SearchBrandTextBox);
            SearchGroupBox.Dock = DockStyle.Fill;
            SearchGroupBox.Location = new Point(3, 2);
            SearchGroupBox.Margin = new Padding(3, 2, 3, 2);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Padding = new Padding(3, 2, 3, 2);
            SearchGroupBox.Size = new Size(1504, 202);
            SearchGroupBox.TabIndex = 2;
            SearchGroupBox.TabStop = false;
            // 
            // SearchYearNumericUpDown2
            // 
            SearchYearNumericUpDown2.Font = new Font("Segoe UI", 18F);
            SearchYearNumericUpDown2.Location = new Point(997, 142);
            SearchYearNumericUpDown2.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            SearchYearNumericUpDown2.Name = "SearchYearNumericUpDown2";
            SearchYearNumericUpDown2.Size = new Size(208, 39);
            SearchYearNumericUpDown2.TabIndex = 23;
            // 
            // SearchPriceNumericUpDown2
            // 
            SearchPriceNumericUpDown2.DecimalPlaces = 2;
            SearchPriceNumericUpDown2.Font = new Font("Segoe UI", 18F);
            SearchPriceNumericUpDown2.Location = new Point(997, 50);
            SearchPriceNumericUpDown2.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            SearchPriceNumericUpDown2.Name = "SearchPriceNumericUpDown2";
            SearchPriceNumericUpDown2.Size = new Size(208, 39);
            SearchPriceNumericUpDown2.TabIndex = 22;
            SearchPriceNumericUpDown2.ThousandsSeparator = true;
            // 
            // SearchFuelTypeComboBox
            // 
            SearchFuelTypeComboBox.Font = new Font("Segoe UI", 18F);
            SearchFuelTypeComboBox.FormattingEnabled = true;
            SearchFuelTypeComboBox.Location = new Point(508, 143);
            SearchFuelTypeComboBox.Name = "SearchFuelTypeComboBox";
            SearchFuelTypeComboBox.Size = new Size(210, 40);
            SearchFuelTypeComboBox.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(508, 110);
            label9.Name = "label9";
            label9.Size = new Size(117, 32);
            label9.TabIndex = 20;
            label9.Text = "Fuel Type";
            // 
            // ResetButton
            // 
            ResetButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ResetButton.Font = new Font("Segoe UI", 18F);
            ResetButton.Location = new Point(1254, 45);
            ResetButton.Margin = new Padding(3, 2, 3, 2);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(245, 42);
            ResetButton.TabIndex = 19;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // SearchPriceNumericUpDown
            // 
            SearchPriceNumericUpDown.DecimalPlaces = 2;
            SearchPriceNumericUpDown.Font = new Font("Segoe UI", 18F);
            SearchPriceNumericUpDown.Location = new Point(754, 51);
            SearchPriceNumericUpDown.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            SearchPriceNumericUpDown.Name = "SearchPriceNumericUpDown";
            SearchPriceNumericUpDown.Size = new Size(208, 39);
            SearchPriceNumericUpDown.TabIndex = 18;
            SearchPriceNumericUpDown.ThousandsSeparator = true;
            // 
            // SearchYearNumericUpDown
            // 
            SearchYearNumericUpDown.Font = new Font("Segoe UI", 18F);
            SearchYearNumericUpDown.Location = new Point(754, 143);
            SearchYearNumericUpDown.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            SearchYearNumericUpDown.Name = "SearchYearNumericUpDown";
            SearchYearNumericUpDown.Size = new Size(208, 39);
            SearchYearNumericUpDown.TabIndex = 17;
            // 
            // SearchStatusComboBox
            // 
            SearchStatusComboBox.Font = new Font("Segoe UI", 18F);
            SearchStatusComboBox.FormattingEnabled = true;
            SearchStatusComboBox.Location = new Point(508, 52);
            SearchStatusComboBox.Name = "SearchStatusComboBox";
            SearchStatusComboBox.Size = new Size(210, 40);
            SearchStatusComboBox.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(508, 17);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 15;
            label8.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(948, 17);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 13;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(948, 110);
            label6.Name = "label6";
            label6.Size = new Size(58, 32);
            label6.TabIndex = 11;
            label6.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(265, 108);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 9;
            label4.Text = "Body Type";
            // 
            // SearchBodyTypeTextBox
            // 
            SearchBodyTypeTextBox.Font = new Font("Segoe UI", 18F);
            SearchBodyTypeTextBox.Location = new Point(265, 143);
            SearchBodyTypeTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchBodyTypeTextBox.Name = "SearchBodyTypeTextBox";
            SearchBodyTypeTextBox.Size = new Size(210, 39);
            SearchBodyTypeTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(265, 17);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 7;
            label3.Text = "Color";
            // 
            // SearchColorTextBox
            // 
            SearchColorTextBox.Font = new Font("Segoe UI", 18F);
            SearchColorTextBox.Location = new Point(265, 52);
            SearchColorTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchColorTextBox.Name = "SearchColorTextBox";
            SearchColorTextBox.Size = new Size(210, 39);
            SearchColorTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(18, 104);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 5;
            label2.Text = "Model";
            // 
            // SearchModelTextBox
            // 
            SearchModelTextBox.Font = new Font("Segoe UI", 18F);
            SearchModelTextBox.Location = new Point(18, 142);
            SearchModelTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchModelTextBox.Name = "SearchModelTextBox";
            SearchModelTextBox.Size = new Size(210, 39);
            SearchModelTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(76, 32);
            label1.TabIndex = 3;
            label1.Text = "Brand";
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchButton.Font = new Font("Segoe UI", 18F);
            SearchButton.Location = new Point(1254, 136);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(245, 42);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchBrandTextBox
            // 
            SearchBrandTextBox.Font = new Font("Segoe UI", 18F);
            SearchBrandTextBox.Location = new Point(18, 53);
            SearchBrandTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchBrandTextBox.Name = "SearchBrandTextBox";
            SearchBrandTextBox.Size = new Size(210, 39);
            SearchBrandTextBox.TabIndex = 0;
            // 
            // CarsTableLayout
            // 
            CarsTableLayout.ColumnCount = 2;
            CarsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.633255F));
            CarsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3667431F));
            CarsTableLayout.Controls.Add(dataGridCars, 0, 1);
            CarsTableLayout.Controls.Add(SearchGroupBox, 0, 0);
            CarsTableLayout.Controls.Add(CarDetailsGroupBox, 1, 0);
            CarsTableLayout.Dock = DockStyle.Fill;
            CarsTableLayout.Location = new Point(0, 0);
            CarsTableLayout.Margin = new Padding(3, 2, 3, 2);
            CarsTableLayout.Name = "CarsTableLayout";
            CarsTableLayout.RowCount = 2;
            CarsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 19.42393F));
            CarsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 80.57607F));
            CarsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            CarsTableLayout.Size = new Size(1921, 1061);
            CarsTableLayout.TabIndex = 3;
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1921, 1061);
            Controls.Add(CarsTableLayout);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CarsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cars";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridCars).EndInit();
            CarDetailsGroupBox.ResumeLayout(false);
            TextBoxesGroupBox.ResumeLayout(false);
            TextBoxesGroupBox.PerformLayout();
            ActionsGroupBox.ResumeLayout(false);
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchYearNumericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchPriceNumericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchPriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchYearNumericUpDown).EndInit();
            CarsTableLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridCars;
        private GroupBox CarDetailsGroupBox;
        private Label StatusLabel;
        private Label ColorLabel;
        private Label BodyTypeLabel;
        private Label ModelLabel;
        private Label BrandLabel;
        private Label ProductionYearLabel;
        private Label MileageLabel;
        private Label PriceLabel;
        private Label LastInspectionLabel;
        private TextBox StatusTextBox;
        private TextBox LastInspectionTextBox;
        private TextBox PriceTextBox;
        private TextBox MileageTextBox;
        private TextBox YearTextBox;
        private TextBox ColorTextBox;
        private TextBox BodyTypeTextBox;
        private TextBox ModelTextBox;
        private TextBox BrandTextBox;
        private GroupBox SearchGroupBox;
        private Button SearchButton;
        private TextBox SearchBrandTextBox;
        private Button EditButton;
        private Button RemoveButton;
        private Button AddButton;
        private Label label2;
        private TextBox SearchModelTextBox;
        private Label label1;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private TextBox SearchBodyTypeTextBox;
        private Label label3;
        private TextBox SearchColorTextBox;
        private ComboBox SearchStatusComboBox;
        private NumericUpDown SearchPriceNumericUpDown;
        private NumericUpDown SearchYearNumericUpDown;
        private Button ResetButton;
        private Label label7;
        private TextBox FuelTypeTextBox;
        private ComboBox SearchFuelTypeComboBox;
        private Label label9;
        private Button ResetCarButton;
        private TableLayoutPanel CarsTableLayout;
        private GroupBox ActionsGroupBox;
        private GroupBox TextBoxesGroupBox;
        private NumericUpDown SearchPriceNumericUpDown2;
        private NumericUpDown SearchYearNumericUpDown2;
    }
}