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
            dataGridCars.Location = new Point(3, 266);
            dataGridCars.MultiSelect = false;
            dataGridCars.Name = "dataGridCars";
            dataGridCars.ReadOnly = true;
            dataGridCars.RowHeadersVisible = false;
            dataGridCars.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridCars.RowTemplate.Height = 60;
            dataGridCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCars.Size = new Size(1720, 1085);
            dataGridCars.TabIndex = 0;
            // 
            // CarDetailsGroupBox
            // 
            CarDetailsGroupBox.Controls.Add(TextBoxesGroupBox);
            CarDetailsGroupBox.Controls.Add(ActionsGroupBox);
            CarDetailsGroupBox.Dock = DockStyle.Fill;
            CarDetailsGroupBox.Font = new Font("Segoe UI", 18F);
            CarDetailsGroupBox.Location = new Point(1729, 3);
            CarDetailsGroupBox.Name = "CarDetailsGroupBox";
            CarsTableLayout.SetRowSpan(CarDetailsGroupBox, 2);
            CarDetailsGroupBox.Size = new Size(463, 1348);
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
            TextBoxesGroupBox.Location = new Point(5, 51);
            TextBoxesGroupBox.Name = "TextBoxesGroupBox";
            TextBoxesGroupBox.Size = new Size(452, 1044);
            TextBoxesGroupBox.TabIndex = 25;
            TextBoxesGroupBox.TabStop = false;
            // 
            // FuelTypeTextBox
            // 
            FuelTypeTextBox.Font = new Font("Segoe UI", 18F);
            FuelTypeTextBox.Location = new Point(233, 237);
            FuelTypeTextBox.Name = "FuelTypeTextBox";
            FuelTypeTextBox.Size = new Size(210, 47);
            FuelTypeTextBox.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(6, 237);
            label7.Name = "label7";
            label7.Size = new Size(144, 41);
            label7.TabIndex = 22;
            label7.Text = "Fuel Type";
            // 
            // LastInspectionLabel
            // 
            LastInspectionLabel.AutoSize = true;
            LastInspectionLabel.Font = new Font("Segoe UI", 18F);
            LastInspectionLabel.Location = new Point(6, 502);
            LastInspectionLabel.Name = "LastInspectionLabel";
            LastInspectionLabel.Size = new Size(215, 41);
            LastInspectionLabel.TabIndex = 8;
            LastInspectionLabel.Text = "Last inspection";
            // 
            // ModelTextBox
            // 
            ModelTextBox.Font = new Font("Segoe UI", 18F);
            ModelTextBox.Location = new Point(233, 131);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(210, 47);
            ModelTextBox.TabIndex = 10;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 18F);
            PriceLabel.Location = new Point(6, 449);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(145, 41);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Price/Day";
            // 
            // BodyTypeTextBox
            // 
            BodyTypeTextBox.Font = new Font("Segoe UI", 18F);
            BodyTypeTextBox.Location = new Point(233, 184);
            BodyTypeTextBox.Name = "BodyTypeTextBox";
            BodyTypeTextBox.Size = new Size(210, 47);
            BodyTypeTextBox.TabIndex = 11;
            // 
            // MileageLabel
            // 
            MileageLabel.AutoSize = true;
            MileageLabel.Font = new Font("Segoe UI", 18F);
            MileageLabel.Location = new Point(6, 396);
            MileageLabel.Name = "MileageLabel";
            MileageLabel.Size = new Size(124, 41);
            MileageLabel.TabIndex = 6;
            MileageLabel.Text = "Mileage";
            // 
            // BrandTextBox
            // 
            BrandTextBox.Font = new Font("Segoe UI", 18F);
            BrandTextBox.Location = new Point(233, 78);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(210, 47);
            BrandTextBox.TabIndex = 9;
            // 
            // ProductionYearLabel
            // 
            ProductionYearLabel.AutoSize = true;
            ProductionYearLabel.Font = new Font("Segoe UI", 18F);
            ProductionYearLabel.Location = new Point(6, 290);
            ProductionYearLabel.Name = "ProductionYearLabel";
            ProductionYearLabel.Size = new Size(73, 41);
            ProductionYearLabel.TabIndex = 5;
            ProductionYearLabel.Text = "Year";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Font = new Font("Segoe UI", 18F);
            ColorTextBox.Location = new Point(233, 343);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(210, 47);
            ColorTextBox.TabIndex = 12;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 18F);
            StatusLabel.Location = new Point(6, 555);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(98, 41);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status";
            // 
            // YearTextBox
            // 
            YearTextBox.Font = new Font("Segoe UI", 18F);
            YearTextBox.Location = new Point(233, 290);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(210, 47);
            YearTextBox.TabIndex = 13;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Font = new Font("Segoe UI", 18F);
            ColorLabel.Location = new Point(6, 343);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(90, 41);
            ColorLabel.TabIndex = 3;
            ColorLabel.Text = "Color";
            // 
            // MileageTextBox
            // 
            MileageTextBox.Font = new Font("Segoe UI", 18F);
            MileageTextBox.Location = new Point(233, 396);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.Size = new Size(210, 47);
            MileageTextBox.TabIndex = 14;
            // 
            // BodyTypeLabel
            // 
            BodyTypeLabel.AutoSize = true;
            BodyTypeLabel.Font = new Font("Segoe UI", 18F);
            BodyTypeLabel.Location = new Point(6, 184);
            BodyTypeLabel.Name = "BodyTypeLabel";
            BodyTypeLabel.Size = new Size(157, 41);
            BodyTypeLabel.TabIndex = 2;
            BodyTypeLabel.Text = "Body Type";
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Font = new Font("Segoe UI", 18F);
            ModelLabel.Location = new Point(6, 131);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(104, 41);
            ModelLabel.TabIndex = 1;
            ModelLabel.Text = "Model";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Font = new Font("Segoe UI", 18F);
            PriceTextBox.Location = new Point(233, 449);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(210, 47);
            PriceTextBox.TabIndex = 15;
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Font = new Font("Segoe UI", 18F);
            BrandLabel.Location = new Point(6, 78);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(95, 41);
            BrandLabel.TabIndex = 0;
            BrandLabel.Text = "Brand";
            // 
            // LastInspectionTextBox
            // 
            LastInspectionTextBox.Font = new Font("Segoe UI", 18F);
            LastInspectionTextBox.Location = new Point(233, 502);
            LastInspectionTextBox.Name = "LastInspectionTextBox";
            LastInspectionTextBox.Size = new Size(210, 47);
            LastInspectionTextBox.TabIndex = 16;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Font = new Font("Segoe UI", 18F);
            StatusTextBox.Location = new Point(233, 555);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(210, 47);
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
            ActionsGroupBox.Location = new Point(5, 1096);
            ActionsGroupBox.Name = "ActionsGroupBox";
            ActionsGroupBox.Size = new Size(449, 246);
            ActionsGroupBox.TabIndex = 24;
            ActionsGroupBox.TabStop = false;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 18F);
            AddButton.Location = new Point(6, 30);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(190, 79);
            AddButton.TabIndex = 18;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ResetCarButton
            // 
            ResetCarButton.Font = new Font("Segoe UI", 18F);
            ResetCarButton.Location = new Point(247, 161);
            ResetCarButton.Name = "ResetCarButton";
            ResetCarButton.Size = new Size(190, 79);
            ResetCarButton.TabIndex = 23;
            ResetCarButton.Text = "Reset";
            ResetCarButton.UseVisualStyleBackColor = true;
            ResetCarButton.Click += ResetCarButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI", 18F);
            RemoveButton.Location = new Point(247, 30);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(190, 79);
            RemoveButton.TabIndex = 19;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 18F);
            EditButton.Location = new Point(6, 161);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(190, 79);
            EditButton.TabIndex = 20;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // SearchGroupBox
            // 
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
            SearchGroupBox.Location = new Point(3, 3);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(1720, 257);
            SearchGroupBox.TabIndex = 2;
            SearchGroupBox.TabStop = false;
            // 
            // SearchFuelTypeComboBox
            // 
            SearchFuelTypeComboBox.Font = new Font("Segoe UI", 18F);
            SearchFuelTypeComboBox.FormattingEnabled = true;
            SearchFuelTypeComboBox.Location = new Point(1165, 187);
            SearchFuelTypeComboBox.Margin = new Padding(3, 4, 3, 4);
            SearchFuelTypeComboBox.Name = "SearchFuelTypeComboBox";
            SearchFuelTypeComboBox.Size = new Size(239, 49);
            SearchFuelTypeComboBox.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(1165, 135);
            label9.Name = "label9";
            label9.Size = new Size(144, 41);
            label9.TabIndex = 20;
            label9.Text = "Fuel Type";
            // 
            // ResetButton
            // 
            ResetButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ResetButton.Font = new Font("Segoe UI", 18F);
            ResetButton.Location = new Point(1434, 60);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(280, 56);
            ResetButton.TabIndex = 19;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // SearchPriceNumericUpDown
            // 
            SearchPriceNumericUpDown.DecimalPlaces = 2;
            SearchPriceNumericUpDown.Font = new Font("Segoe UI", 18F);
            SearchPriceNumericUpDown.Location = new Point(848, 189);
            SearchPriceNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            SearchPriceNumericUpDown.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            SearchPriceNumericUpDown.Name = "SearchPriceNumericUpDown";
            SearchPriceNumericUpDown.Size = new Size(238, 47);
            SearchPriceNumericUpDown.TabIndex = 18;
            SearchPriceNumericUpDown.ThousandsSeparator = true;
            // 
            // SearchYearNumericUpDown
            // 
            SearchYearNumericUpDown.Font = new Font("Segoe UI", 18F);
            SearchYearNumericUpDown.Location = new Point(848, 67);
            SearchYearNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            SearchYearNumericUpDown.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            SearchYearNumericUpDown.Name = "SearchYearNumericUpDown";
            SearchYearNumericUpDown.Size = new Size(238, 47);
            SearchYearNumericUpDown.TabIndex = 17;
            // 
            // SearchStatusComboBox
            // 
            SearchStatusComboBox.Font = new Font("Segoe UI", 18F);
            SearchStatusComboBox.FormattingEnabled = true;
            SearchStatusComboBox.Location = new Point(1165, 65);
            SearchStatusComboBox.Margin = new Padding(3, 4, 3, 4);
            SearchStatusComboBox.Name = "SearchStatusComboBox";
            SearchStatusComboBox.Size = new Size(239, 49);
            SearchStatusComboBox.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(1165, 16);
            label8.Name = "label8";
            label8.Size = new Size(98, 41);
            label8.TabIndex = 15;
            label8.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(848, 144);
            label5.Name = "label5";
            label5.Size = new Size(82, 41);
            label5.TabIndex = 13;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(848, 23);
            label6.Name = "label6";
            label6.Size = new Size(73, 41);
            label6.TabIndex = 11;
            label6.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(470, 147);
            label4.Name = "label4";
            label4.Size = new Size(157, 41);
            label4.TabIndex = 9;
            label4.Text = "Body Type";
            // 
            // SearchBodyTypeTextBox
            // 
            SearchBodyTypeTextBox.Font = new Font("Segoe UI", 18F);
            SearchBodyTypeTextBox.Location = new Point(470, 191);
            SearchBodyTypeTextBox.Name = "SearchBodyTypeTextBox";
            SearchBodyTypeTextBox.Size = new Size(239, 47);
            SearchBodyTypeTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(470, 25);
            label3.Name = "label3";
            label3.Size = new Size(90, 41);
            label3.TabIndex = 7;
            label3.Text = "Color";
            // 
            // SearchColorTextBox
            // 
            SearchColorTextBox.Font = new Font("Segoe UI", 18F);
            SearchColorTextBox.Location = new Point(470, 69);
            SearchColorTextBox.Name = "SearchColorTextBox";
            SearchColorTextBox.Size = new Size(239, 47);
            SearchColorTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(21, 138);
            label2.Name = "label2";
            label2.Size = new Size(104, 41);
            label2.TabIndex = 5;
            label2.Text = "Model";
            // 
            // SearchModelTextBox
            // 
            SearchModelTextBox.Font = new Font("Segoe UI", 18F);
            SearchModelTextBox.Location = new Point(21, 182);
            SearchModelTextBox.Name = "SearchModelTextBox";
            SearchModelTextBox.Size = new Size(239, 47);
            SearchModelTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(95, 41);
            label1.TabIndex = 3;
            label1.Text = "Brand";
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchButton.Font = new Font("Segoe UI", 18F);
            SearchButton.Location = new Point(1434, 182);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(280, 56);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchBrandTextBox
            // 
            SearchBrandTextBox.Font = new Font("Segoe UI", 18F);
            SearchBrandTextBox.Location = new Point(21, 60);
            SearchBrandTextBox.Name = "SearchBrandTextBox";
            SearchBrandTextBox.Size = new Size(239, 47);
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
            CarsTableLayout.Name = "CarsTableLayout";
            CarsTableLayout.RowCount = 2;
            CarsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 19.42393F));
            CarsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 80.57607F));
            CarsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CarsTableLayout.Size = new Size(2195, 1354);
            CarsTableLayout.TabIndex = 3;
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2195, 1354);
            Controls.Add(CarsTableLayout);
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
    }
}