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
            BrandLabel = new Label();
            ModelLabel = new Label();
            BodyTypeLabel = new Label();
            ColorLabel = new Label();
            StatusLabel = new Label();
            ProductionYearLabel = new Label();
            MileageLabel = new Label();
            PriceLabel = new Label();
            LastInspectionLabel = new Label();
            BrandTextBox = new TextBox();
            ModelTextBox = new TextBox();
            BodyTypeTextBox = new TextBox();
            ColorTextBox = new TextBox();
            YearTextBox = new TextBox();
            MileageTextBox = new TextBox();
            PriceTextBox = new TextBox();
            LastInspectionTextBox = new TextBox();
            StatusTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).BeginInit();
            CarDetailsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCars
            // 
            dataGridCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCars.Location = new Point(12, 99);
            dataGridCars.Name = "dataGridCars";
            dataGridCars.RowHeadersWidth = 51;
            dataGridCars.Size = new Size(862, 599);
            dataGridCars.TabIndex = 0;
            // 
            // CarDetailsGroupBox
            // 
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
            CarDetailsGroupBox.Location = new Point(911, 89);
            CarDetailsGroupBox.Name = "CarDetailsGroupBox";
            CarDetailsGroupBox.Size = new Size(334, 609);
            CarDetailsGroupBox.TabIndex = 1;
            CarDetailsGroupBox.TabStop = false;
            CarDetailsGroupBox.Text = "Car";
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
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Location = new Point(76, 66);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(52, 20);
            ModelLabel.TabIndex = 1;
            ModelLabel.Text = "Model";
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
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(83, 132);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(45, 20);
            ColorLabel.TabIndex = 3;
            ColorLabel.Text = "Color";
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
            // ProductionYearLabel
            // 
            ProductionYearLabel.AutoSize = true;
            ProductionYearLabel.Location = new Point(91, 165);
            ProductionYearLabel.Name = "ProductionYearLabel";
            ProductionYearLabel.Size = new Size(37, 20);
            ProductionYearLabel.TabIndex = 5;
            ProductionYearLabel.Text = "Year";
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
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(55, 234);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(73, 20);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Price/Day";
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
            // BrandTextBox
            // 
            BrandTextBox.Location = new Point(170, 34);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(125, 27);
            BrandTextBox.TabIndex = 9;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(170, 66);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(125, 27);
            ModelTextBox.TabIndex = 10;
            // 
            // BodyTypeTextBox
            // 
            BodyTypeTextBox.Location = new Point(170, 99);
            BodyTypeTextBox.Name = "BodyTypeTextBox";
            BodyTypeTextBox.Size = new Size(125, 27);
            BodyTypeTextBox.TabIndex = 11;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(170, 132);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 12;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(170, 165);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(125, 27);
            YearTextBox.TabIndex = 13;
            // 
            // MileageTextBox
            // 
            MileageTextBox.Location = new Point(170, 198);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.Size = new Size(125, 27);
            MileageTextBox.TabIndex = 14;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(170, 234);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(125, 27);
            PriceTextBox.TabIndex = 15;
            // 
            // LastInspectionTextBox
            // 
            LastInspectionTextBox.Location = new Point(170, 266);
            LastInspectionTextBox.Name = "LastInspectionTextBox";
            LastInspectionTextBox.Size = new Size(125, 27);
            LastInspectionTextBox.TabIndex = 16;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(170, 299);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new Size(125, 27);
            StatusTextBox.TabIndex = 17;
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 715);
            Controls.Add(CarDetailsGroupBox);
            Controls.Add(dataGridCars);
            Name = "CarsForm";
            Text = "CarsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridCars).EndInit();
            CarDetailsGroupBox.ResumeLayout(false);
            CarDetailsGroupBox.PerformLayout();
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
    }
}