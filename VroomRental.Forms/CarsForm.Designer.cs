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
            SearchButton = new Button();
            SearchComboBox = new ComboBox();
            textBox1 = new TextBox();
            AddButton = new Button();
            RemoveButton = new Button();
            EditButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).BeginInit();
            CarDetailsGroupBox.SuspendLayout();
            SearchGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCars
            // 
            dataGridCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCars.Location = new Point(12, 99);
            dataGridCars.Name = "dataGridCars";
            dataGridCars.RowHeadersWidth = 51;
            dataGridCars.Size = new Size(862, 390);
            dataGridCars.TabIndex = 0;
            // 
            // CarDetailsGroupBox
            // 
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
            CarDetailsGroupBox.Location = new Point(906, 22);
            CarDetailsGroupBox.Name = "CarDetailsGroupBox";
            CarDetailsGroupBox.Size = new Size(344, 467);
            CarDetailsGroupBox.TabIndex = 1;
            CarDetailsGroupBox.TabStop = false;
            CarDetailsGroupBox.Text = "Car";
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(170, 299);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(125, 27);
            StatusTextBox.TabIndex = 17;
            // 
            // LastInspectionTextBox
            // 
            LastInspectionTextBox.Location = new Point(170, 266);
            LastInspectionTextBox.Name = "LastInspectionTextBox";
            LastInspectionTextBox.Size = new Size(125, 27);
            LastInspectionTextBox.TabIndex = 16;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(170, 234);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(125, 27);
            PriceTextBox.TabIndex = 15;
            // 
            // MileageTextBox
            // 
            MileageTextBox.Location = new Point(170, 198);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.Size = new Size(125, 27);
            MileageTextBox.TabIndex = 14;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(170, 165);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(125, 27);
            YearTextBox.TabIndex = 13;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(170, 132);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 12;
            // 
            // BodyTypeTextBox
            // 
            BodyTypeTextBox.Location = new Point(170, 99);
            BodyTypeTextBox.Name = "BodyTypeTextBox";
            BodyTypeTextBox.Size = new Size(125, 27);
            BodyTypeTextBox.TabIndex = 11;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(170, 66);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(125, 27);
            ModelTextBox.TabIndex = 10;
            // 
            // BrandTextBox
            // 
            BrandTextBox.Location = new Point(170, 34);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(125, 27);
            BrandTextBox.TabIndex = 9;
            // 
            // LastInspectionLabel
            // 
            LastInspectionLabel.AutoSize = true;
            LastInspectionLabel.Location = new Point(21, 266);
            LastInspectionLabel.Name = "LastInspectionLabel";
            LastInspectionLabel.Size = new Size(107, 20);
            LastInspectionLabel.TabIndex = 8;
            LastInspectionLabel.Text = "Last inspection";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(55, 234);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(73, 20);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Price/Day";
            // 
            // MileageLabel
            // 
            MileageLabel.AutoSize = true;
            MileageLabel.Location = new Point(65, 198);
            MileageLabel.Name = "MileageLabel";
            MileageLabel.Size = new Size(63, 20);
            MileageLabel.TabIndex = 6;
            MileageLabel.Text = "Mileage";
            // 
            // ProductionYearLabel
            // 
            ProductionYearLabel.AutoSize = true;
            ProductionYearLabel.Location = new Point(91, 165);
            ProductionYearLabel.Name = "ProductionYearLabel";
            ProductionYearLabel.Size = new Size(37, 20);
            ProductionYearLabel.TabIndex = 5;
            ProductionYearLabel.Text = "Year";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(79, 299);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(49, 20);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status";
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(83, 132);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(45, 20);
            ColorLabel.TabIndex = 3;
            ColorLabel.Text = "Color";
            // 
            // BodyTypeLabel
            // 
            BodyTypeLabel.AutoSize = true;
            BodyTypeLabel.Location = new Point(50, 99);
            BodyTypeLabel.Name = "BodyTypeLabel";
            BodyTypeLabel.Size = new Size(78, 20);
            BodyTypeLabel.TabIndex = 2;
            BodyTypeLabel.Text = "Body Type";
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Location = new Point(76, 66);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(52, 20);
            ModelLabel.TabIndex = 1;
            ModelLabel.Text = "Model";
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Location = new Point(80, 34);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(48, 20);
            BrandLabel.TabIndex = 0;
            BrandLabel.Text = "Brand";
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Controls.Add(SearchButton);
            SearchGroupBox.Controls.Add(SearchComboBox);
            SearchGroupBox.Controls.Add(textBox1);
            SearchGroupBox.Location = new Point(12, 12);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(862, 68);
            SearchGroupBox.TabIndex = 2;
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
            SearchComboBox.Location = new Point(6, 26);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(151, 28);
            SearchComboBox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(476, 27);
            textBox1.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(21, 355);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(111, 35);
            AddButton.TabIndex = 18;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(170, 355);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(111, 35);
            RemoveButton.TabIndex = 19;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(21, 415);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(111, 35);
            EditButton.TabIndex = 20;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 517);
            Controls.Add(SearchGroupBox);
            Controls.Add(CarDetailsGroupBox);
            Controls.Add(dataGridCars);
            Name = "CarsForm";
            Text = "CarsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridCars).EndInit();
            CarDetailsGroupBox.ResumeLayout(false);
            CarDetailsGroupBox.PerformLayout();
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
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
        private ComboBox SearchComboBox;
        private TextBox textBox1;
        private Button EditButton;
        private Button RemoveButton;
        private Button AddButton;
    }
}