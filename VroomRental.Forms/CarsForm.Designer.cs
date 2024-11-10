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
            dataGridCars = new DataGridView();
            CarDetailsGroupBox = new GroupBox();
            label7 = new Label();
            FuelTypeTextBox = new TextBox();
            EditButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            StatusTextBox = new TextBox();
            LastInspectionTextBox = new TextBox();
            PriceTextBox = new TextBox();
            MileageTextBox = new TextBox();
            YearTextBox = new TextBox();
            ColorTextBox = new TextBox();
            BodyTypeTextBox = new TextBox();
            ModelTextBox = new TextBox();
            BrandTextBox = new TextBox();
            LastInspectionLabel = new Label();
            PriceLabel = new Label();
            MileageLabel = new Label();
            ProductionYearLabel = new Label();
            StatusLabel = new Label();
            ColorLabel = new Label();
            BodyTypeLabel = new Label();
            ModelLabel = new Label();
            BrandLabel = new Label();
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
            ResetCarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).BeginInit();
            CarDetailsGroupBox.SuspendLayout();
            SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchPriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchYearNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // dataGridCars
            // 
            dataGridCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCars.Location = new Point(10, 16);
            dataGridCars.Margin = new Padding(3, 2, 3, 2);
            dataGridCars.Name = "dataGridCars";
            dataGridCars.RowHeadersWidth = 51;
            dataGridCars.Size = new Size(754, 372);
            dataGridCars.TabIndex = 0;
            // 
            // CarDetailsGroupBox
            // 
            CarDetailsGroupBox.Controls.Add(ResetCarButton);
            CarDetailsGroupBox.Controls.Add(label7);
            CarDetailsGroupBox.Controls.Add(FuelTypeTextBox);
            CarDetailsGroupBox.Controls.Add(EditButton);
            CarDetailsGroupBox.Controls.Add(RemoveButton);
            CarDetailsGroupBox.Controls.Add(AddButton);
            CarDetailsGroupBox.Controls.Add(StatusTextBox);
            CarDetailsGroupBox.Controls.Add(LastInspectionTextBox);
            CarDetailsGroupBox.Controls.Add(PriceTextBox);
            CarDetailsGroupBox.Controls.Add(MileageTextBox);
            CarDetailsGroupBox.Controls.Add(YearTextBox);
            CarDetailsGroupBox.Controls.Add(ColorTextBox);
            CarDetailsGroupBox.Controls.Add(BodyTypeTextBox);
            CarDetailsGroupBox.Controls.Add(ModelTextBox);
            CarDetailsGroupBox.Controls.Add(BrandTextBox);
            CarDetailsGroupBox.Controls.Add(LastInspectionLabel);
            CarDetailsGroupBox.Controls.Add(PriceLabel);
            CarDetailsGroupBox.Controls.Add(MileageLabel);
            CarDetailsGroupBox.Controls.Add(ProductionYearLabel);
            CarDetailsGroupBox.Controls.Add(StatusLabel);
            CarDetailsGroupBox.Controls.Add(ColorLabel);
            CarDetailsGroupBox.Controls.Add(BodyTypeLabel);
            CarDetailsGroupBox.Controls.Add(ModelLabel);
            CarDetailsGroupBox.Controls.Add(BrandLabel);
            CarDetailsGroupBox.Location = new Point(793, 16);
            CarDetailsGroupBox.Margin = new Padding(3, 2, 3, 2);
            CarDetailsGroupBox.Name = "CarDetailsGroupBox";
            CarDetailsGroupBox.Padding = new Padding(3, 2, 3, 2);
            CarDetailsGroupBox.Size = new Size(301, 372);
            CarDetailsGroupBox.TabIndex = 1;
            CarDetailsGroupBox.TabStop = false;
            CarDetailsGroupBox.Text = "Car";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 178);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 22;
            label7.Text = "Fuel Type";
            // 
            // FuelTypeTextBox
            // 
            FuelTypeTextBox.Location = new Point(149, 175);
            FuelTypeTextBox.Margin = new Padding(3, 2, 3, 2);
            FuelTypeTextBox.Name = "FuelTypeTextBox";
            FuelTypeTextBox.Size = new Size(110, 23);
            FuelTypeTextBox.TabIndex = 21;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(18, 332);
            EditButton.Margin = new Padding(3, 2, 3, 2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(97, 26);
            EditButton.TabIndex = 20;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(149, 287);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(97, 26);
            RemoveButton.TabIndex = 19;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(18, 287);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(97, 26);
            AddButton.TabIndex = 18;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(149, 250);
            StatusTextBox.Margin = new Padding(3, 2, 3, 2);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(110, 23);
            StatusTextBox.TabIndex = 17;
            // 
            // LastInspectionTextBox
            // 
            LastInspectionTextBox.Location = new Point(149, 226);
            LastInspectionTextBox.Margin = new Padding(3, 2, 3, 2);
            LastInspectionTextBox.Name = "LastInspectionTextBox";
            LastInspectionTextBox.Size = new Size(110, 23);
            LastInspectionTextBox.TabIndex = 16;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(149, 202);
            PriceTextBox.Margin = new Padding(3, 2, 3, 2);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(110, 23);
            PriceTextBox.TabIndex = 15;
            // 
            // MileageTextBox
            // 
            MileageTextBox.Location = new Point(149, 148);
            MileageTextBox.Margin = new Padding(3, 2, 3, 2);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.Size = new Size(110, 23);
            MileageTextBox.TabIndex = 14;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(149, 124);
            YearTextBox.Margin = new Padding(3, 2, 3, 2);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(110, 23);
            YearTextBox.TabIndex = 13;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(149, 99);
            ColorTextBox.Margin = new Padding(3, 2, 3, 2);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(110, 23);
            ColorTextBox.TabIndex = 12;
            // 
            // BodyTypeTextBox
            // 
            BodyTypeTextBox.Location = new Point(149, 74);
            BodyTypeTextBox.Margin = new Padding(3, 2, 3, 2);
            BodyTypeTextBox.Name = "BodyTypeTextBox";
            BodyTypeTextBox.Size = new Size(110, 23);
            BodyTypeTextBox.TabIndex = 11;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(149, 50);
            ModelTextBox.Margin = new Padding(3, 2, 3, 2);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(110, 23);
            ModelTextBox.TabIndex = 10;
            // 
            // BrandTextBox
            // 
            BrandTextBox.Location = new Point(149, 26);
            BrandTextBox.Margin = new Padding(3, 2, 3, 2);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(110, 23);
            BrandTextBox.TabIndex = 9;
            // 
            // LastInspectionLabel
            // 
            LastInspectionLabel.AutoSize = true;
            LastInspectionLabel.Location = new Point(18, 226);
            LastInspectionLabel.Name = "LastInspectionLabel";
            LastInspectionLabel.Size = new Size(86, 15);
            LastInspectionLabel.TabIndex = 8;
            LastInspectionLabel.Text = "Last inspection";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(48, 202);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(58, 15);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Price/Day";
            // 
            // MileageLabel
            // 
            MileageLabel.AutoSize = true;
            MileageLabel.Location = new Point(57, 148);
            MileageLabel.Name = "MileageLabel";
            MileageLabel.Size = new Size(49, 15);
            MileageLabel.TabIndex = 6;
            MileageLabel.Text = "Mileage";
            // 
            // ProductionYearLabel
            // 
            ProductionYearLabel.AutoSize = true;
            ProductionYearLabel.Location = new Point(80, 124);
            ProductionYearLabel.Name = "ProductionYearLabel";
            ProductionYearLabel.Size = new Size(29, 15);
            ProductionYearLabel.TabIndex = 5;
            ProductionYearLabel.Text = "Year";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(69, 250);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(39, 15);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status";
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(73, 99);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(36, 15);
            ColorLabel.TabIndex = 3;
            ColorLabel.Text = "Color";
            // 
            // BodyTypeLabel
            // 
            BodyTypeLabel.AutoSize = true;
            BodyTypeLabel.Location = new Point(44, 74);
            BodyTypeLabel.Name = "BodyTypeLabel";
            BodyTypeLabel.Size = new Size(62, 15);
            BodyTypeLabel.TabIndex = 2;
            BodyTypeLabel.Text = "Body Type";
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Location = new Point(66, 50);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(41, 15);
            ModelLabel.TabIndex = 1;
            ModelLabel.Text = "Model";
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Location = new Point(70, 26);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(38, 15);
            BrandLabel.TabIndex = 0;
            BrandLabel.Text = "Brand";
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
            SearchGroupBox.Location = new Point(10, 403);
            SearchGroupBox.Margin = new Padding(3, 2, 3, 2);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Padding = new Padding(3, 2, 3, 2);
            SearchGroupBox.Size = new Size(1084, 132);
            SearchGroupBox.TabIndex = 2;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Text = "Search";
            // 
            // SearchFuelTypeComboBox
            // 
            SearchFuelTypeComboBox.FormattingEnabled = true;
            SearchFuelTypeComboBox.Location = new Point(705, 89);
            SearchFuelTypeComboBox.Name = "SearchFuelTypeComboBox";
            SearchFuelTypeComboBox.Size = new Size(210, 23);
            SearchFuelTypeComboBox.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(705, 70);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 20;
            label9.Text = "Fuel Type";
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(976, 40);
            ResetButton.Margin = new Padding(3, 2, 3, 2);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(100, 21);
            ResetButton.TabIndex = 19;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // SearchPriceNumericUpDown
            // 
            SearchPriceNumericUpDown.DecimalPlaces = 2;
            SearchPriceNumericUpDown.Location = new Point(471, 91);
            SearchPriceNumericUpDown.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            SearchPriceNumericUpDown.Name = "SearchPriceNumericUpDown";
            SearchPriceNumericUpDown.Size = new Size(208, 23);
            SearchPriceNumericUpDown.TabIndex = 18;
            SearchPriceNumericUpDown.ThousandsSeparator = true;
            // 
            // SearchYearNumericUpDown
            // 
            SearchYearNumericUpDown.Location = new Point(471, 37);
            SearchYearNumericUpDown.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            SearchYearNumericUpDown.Name = "SearchYearNumericUpDown";
            SearchYearNumericUpDown.Size = new Size(208, 23);
            SearchYearNumericUpDown.TabIndex = 17;
            // 
            // SearchStatusComboBox
            // 
            SearchStatusComboBox.FormattingEnabled = true;
            SearchStatusComboBox.Location = new Point(705, 37);
            SearchStatusComboBox.Name = "SearchStatusComboBox";
            SearchStatusComboBox.Size = new Size(210, 23);
            SearchStatusComboBox.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(705, 18);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 15;
            label8.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 70);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 13;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 16);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 11;
            label6.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 72);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Body Type";
            // 
            // SearchBodyTypeTextBox
            // 
            SearchBodyTypeTextBox.Location = new Point(243, 91);
            SearchBodyTypeTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchBodyTypeTextBox.Name = "SearchBodyTypeTextBox";
            SearchBodyTypeTextBox.Size = new Size(210, 23);
            SearchBodyTypeTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 18);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Color";
            // 
            // SearchColorTextBox
            // 
            SearchColorTextBox.Location = new Point(241, 37);
            SearchColorTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchColorTextBox.Name = "SearchColorTextBox";
            SearchColorTextBox.Size = new Size(210, 23);
            SearchColorTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 70);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Model";
            // 
            // SearchModelTextBox
            // 
            SearchModelTextBox.Location = new Point(16, 89);
            SearchModelTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchModelTextBox.Name = "SearchModelTextBox";
            SearchModelTextBox.Size = new Size(210, 23);
            SearchModelTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Brand";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(976, 93);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(100, 21);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchBrandTextBox
            // 
            SearchBrandTextBox.Location = new Point(16, 38);
            SearchBrandTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchBrandTextBox.Name = "SearchBrandTextBox";
            SearchBrandTextBox.Size = new Size(210, 23);
            SearchBrandTextBox.TabIndex = 0;
            // 
            // ResetCarButton
            // 
            ResetCarButton.Location = new Point(149, 332);
            ResetCarButton.Margin = new Padding(3, 2, 3, 2);
            ResetCarButton.Name = "ResetCarButton";
            ResetCarButton.Size = new Size(97, 26);
            ResetCarButton.TabIndex = 23;
            ResetCarButton.Text = "Reset";
            ResetCarButton.UseVisualStyleBackColor = true;
            ResetCarButton.Click += ResetCarButton_Click;
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 550);
            Controls.Add(SearchGroupBox);
            Controls.Add(CarDetailsGroupBox);
            Controls.Add(dataGridCars);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CarsForm";
            Text = "CarsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridCars).EndInit();
            CarDetailsGroupBox.ResumeLayout(false);
            CarDetailsGroupBox.PerformLayout();
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchPriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchYearNumericUpDown).EndInit();
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
    }
}