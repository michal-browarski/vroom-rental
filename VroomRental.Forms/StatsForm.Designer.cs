namespace VroomRental.Forms
{
    partial class StatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsForm));
            panel1 = new Panel();
            DateRangeComboBox = new ComboBox();
            label1 = new Label();
            EndDatePicker = new DateTimePicker();
            StartDatePicker = new DateTimePicker();
            DateResetButton = new Button();
            DateLimitLabel = new Label();
            PeriodPanel = new Panel();
            PaymentTypePlotButton = new Button();
            PopularCarsPlotButton = new Button();
            PopularBrandsPlotButton = new Button();
            CarTypePlotButton = new Button();
            FuelTypePlotButton = new Button();
            OptionsPlotButton = new Button();
            PeriodPopularBrand = new Label();
            PeriodPlotView = new OxyPlot.WindowsForms.PlotView();
            NewCustomersLabel = new Label();
            MeanRentalTimeLabel = new Label();
            PeriodRentalLabel = new Label();
            TotalPaymentLabel = new Label();
            MeanLabel = new Label();
            ReportPanel = new Panel();
            ReportLabel = new Label();
            PeriodReportButton = new Button();
            DailyReportButton = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            DailyPanel = new Panel();
            TodayPopularBrand = new Label();
            TodayPaymentsLabel = new Label();
            TodayRentalsLabel = new Label();
            DailyPlotView = new OxyPlot.WindowsForms.PlotView();
            LateReturnLabel = new Label();
            RepairCarsProgressBar = new ProgressBar();
            RepairCarLabel = new Label();
            AvailableCarsLabel = new Label();
            CarsAvaiableProgressBar = new ProgressBar();
            panel1.SuspendLayout();
            PeriodPanel.SuspendLayout();
            ReportPanel.SuspendLayout();
            DailyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(DateRangeComboBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EndDatePicker);
            panel1.Controls.Add(StartDatePicker);
            panel1.Controls.Add(DateResetButton);
            panel1.Controls.Add(DateLimitLabel);
            panel1.Location = new Point(26, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1677, 102);
            panel1.TabIndex = 2;
            // 
            // DateRangeComboBox
            // 
            DateRangeComboBox.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DateRangeComboBox.FormattingEnabled = true;
            DateRangeComboBox.Location = new Point(1011, 25);
            DateRangeComboBox.Margin = new Padding(3, 4, 3, 4);
            DateRangeComboBox.Name = "DateRangeComboBox";
            DateRangeComboBox.Size = new Size(449, 56);
            DateRangeComboBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(649, -5);
            label1.Name = "label1";
            label1.Size = new Size(77, 106);
            label1.TabIndex = 6;
            label1.Text = "-";
            // 
            // EndDatePicker
            // 
            EndDatePicker.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EndDatePicker.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EndDatePicker.Format = DateTimePickerFormat.Short;
            EndDatePicker.Location = new Point(721, 25);
            EndDatePicker.Margin = new Padding(3, 4, 3, 4);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(240, 62);
            EndDatePicker.TabIndex = 5;
            // 
            // StartDatePicker
            // 
            StartDatePicker.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            StartDatePicker.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            StartDatePicker.Format = DateTimePickerFormat.Short;
            StartDatePicker.Location = new Point(403, 25);
            StartDatePicker.Margin = new Padding(3, 4, 3, 4);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(240, 62);
            StartDatePicker.TabIndex = 4;
            // 
            // DateResetButton
            // 
            DateResetButton.Font = new Font("Segoe UI", 25F);
            DateResetButton.Location = new Point(1479, 17);
            DateResetButton.Name = "DateResetButton";
            DateResetButton.Size = new Size(174, 63);
            DateResetButton.TabIndex = 3;
            DateResetButton.Text = "Reset";
            DateResetButton.UseVisualStyleBackColor = true;
            DateResetButton.Click += DateResetButton_Click;
            // 
            // DateLimitLabel
            // 
            DateLimitLabel.AutoSize = true;
            DateLimitLabel.Font = new Font("Segoe UI", 25F);
            DateLimitLabel.Location = new Point(27, 21);
            DateLimitLabel.Name = "DateLimitLabel";
            DateLimitLabel.Size = new Size(343, 57);
            DateLimitLabel.TabIndex = 2;
            DateLimitLabel.Text = "Określ zakres dat";
            // 
            // PeriodPanel
            // 
            PeriodPanel.BorderStyle = BorderStyle.FixedSingle;
            PeriodPanel.Controls.Add(PaymentTypePlotButton);
            PeriodPanel.Controls.Add(PopularCarsPlotButton);
            PeriodPanel.Controls.Add(PopularBrandsPlotButton);
            PeriodPanel.Controls.Add(CarTypePlotButton);
            PeriodPanel.Controls.Add(FuelTypePlotButton);
            PeriodPanel.Controls.Add(OptionsPlotButton);
            PeriodPanel.Controls.Add(PeriodPopularBrand);
            PeriodPanel.Controls.Add(PeriodPlotView);
            PeriodPanel.Controls.Add(NewCustomersLabel);
            PeriodPanel.Controls.Add(MeanRentalTimeLabel);
            PeriodPanel.Controls.Add(PeriodRentalLabel);
            PeriodPanel.Controls.Add(TotalPaymentLabel);
            PeriodPanel.Controls.Add(MeanLabel);
            PeriodPanel.Location = new Point(26, 155);
            PeriodPanel.Name = "PeriodPanel";
            PeriodPanel.Size = new Size(1339, 1186);
            PeriodPanel.TabIndex = 3;
            // 
            // PaymentTypePlotButton
            // 
            PaymentTypePlotButton.Font = new Font("Segoe UI", 25F);
            PaymentTypePlotButton.Location = new Point(872, 388);
            PaymentTypePlotButton.Name = "PaymentTypePlotButton";
            PaymentTypePlotButton.Size = new Size(393, 63);
            PaymentTypePlotButton.TabIndex = 17;
            PaymentTypePlotButton.Text = "Rodzaj płatności";
            PaymentTypePlotButton.UseVisualStyleBackColor = true;
            PaymentTypePlotButton.Click += PaymentTypePlotButton_Click;
            // 
            // PopularCarsPlotButton
            // 
            PopularCarsPlotButton.Font = new Font("Segoe UI", 25F);
            PopularCarsPlotButton.Location = new Point(452, 388);
            PopularCarsPlotButton.Name = "PopularCarsPlotButton";
            PopularCarsPlotButton.Size = new Size(393, 63);
            PopularCarsPlotButton.TabIndex = 16;
            PopularCarsPlotButton.Text = "Popularne auta";
            PopularCarsPlotButton.UseVisualStyleBackColor = true;
            PopularCarsPlotButton.Click += PopularCarsPlotButton_Click;
            // 
            // PopularBrandsPlotButton
            // 
            PopularBrandsPlotButton.Font = new Font("Segoe UI", 25F);
            PopularBrandsPlotButton.Location = new Point(37, 388);
            PopularBrandsPlotButton.Name = "PopularBrandsPlotButton";
            PopularBrandsPlotButton.Size = new Size(393, 63);
            PopularBrandsPlotButton.TabIndex = 15;
            PopularBrandsPlotButton.Text = "Popularne marki";
            PopularBrandsPlotButton.UseVisualStyleBackColor = true;
            PopularBrandsPlotButton.Click += PopularBrandsPlotButton_Click;
            // 
            // CarTypePlotButton
            // 
            CarTypePlotButton.Font = new Font("Segoe UI", 25F);
            CarTypePlotButton.Location = new Point(872, 300);
            CarTypePlotButton.Name = "CarTypePlotButton";
            CarTypePlotButton.Size = new Size(393, 63);
            CarTypePlotButton.TabIndex = 14;
            CarTypePlotButton.Text = "Rodzaj auta";
            CarTypePlotButton.UseVisualStyleBackColor = true;
            CarTypePlotButton.Click += CarTypePlotButton_Click;
            // 
            // FuelTypePlotButton
            // 
            FuelTypePlotButton.Font = new Font("Segoe UI", 25F);
            FuelTypePlotButton.Location = new Point(452, 300);
            FuelTypePlotButton.Name = "FuelTypePlotButton";
            FuelTypePlotButton.Size = new Size(393, 63);
            FuelTypePlotButton.TabIndex = 13;
            FuelTypePlotButton.Text = "Rodzaj paliwa";
            FuelTypePlotButton.UseVisualStyleBackColor = true;
            FuelTypePlotButton.Click += FuelTypePlotButton_Click;
            // 
            // OptionsPlotButton
            // 
            OptionsPlotButton.Font = new Font("Segoe UI", 25F);
            OptionsPlotButton.Location = new Point(37, 300);
            OptionsPlotButton.Name = "OptionsPlotButton";
            OptionsPlotButton.Size = new Size(393, 63);
            OptionsPlotButton.TabIndex = 12;
            OptionsPlotButton.Text = "Opcje dodatkowe";
            OptionsPlotButton.UseVisualStyleBackColor = true;
            OptionsPlotButton.Click += OptionsPlotButton_Click;
            // 
            // PeriodPopularBrand
            // 
            PeriodPopularBrand.AutoSize = true;
            PeriodPopularBrand.Font = new Font("Segoe UI", 25F);
            PeriodPopularBrand.Location = new Point(906, 213);
            PeriodPopularBrand.Name = "PeriodPopularBrand";
            PeriodPopularBrand.Size = new Size(384, 57);
            PeriodPopularBrand.TabIndex = 9;
            PeriodPopularBrand.Text = "Top brand: Testowa";
            PeriodPopularBrand.TextAlign = ContentAlignment.TopRight;
            // 
            // PeriodPlotView
            // 
            PeriodPlotView.Location = new Point(37, 477);
            PeriodPlotView.Name = "PeriodPlotView";
            PeriodPlotView.PanCursor = Cursors.Hand;
            PeriodPlotView.Size = new Size(1265, 677);
            PeriodPlotView.TabIndex = 6;
            PeriodPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            PeriodPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            PeriodPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // NewCustomersLabel
            // 
            NewCustomersLabel.AutoSize = true;
            NewCustomersLabel.Font = new Font("Segoe UI", 25F);
            NewCustomersLabel.Location = new Point(951, 123);
            NewCustomersLabel.Name = "NewCustomersLabel";
            NewCustomersLabel.Size = new Size(339, 57);
            NewCustomersLabel.TabIndex = 4;
            NewCustomersLabel.Text = "Nowi klienci: 000";
            // 
            // MeanRentalTimeLabel
            // 
            MeanRentalTimeLabel.AutoSize = true;
            MeanRentalTimeLabel.Font = new Font("Segoe UI", 25F);
            MeanRentalTimeLabel.Location = new Point(666, 33);
            MeanRentalTimeLabel.Name = "MeanRentalTimeLabel";
            MeanRentalTimeLabel.Size = new Size(636, 57);
            MeanRentalTimeLabel.TabIndex = 3;
            MeanRentalTimeLabel.Text = "Średni czas wypożyczenia: 00 dni";
            // 
            // PeriodRentalLabel
            // 
            PeriodRentalLabel.AutoSize = true;
            PeriodRentalLabel.Font = new Font("Segoe UI", 25F);
            PeriodRentalLabel.Location = new Point(37, 201);
            PeriodRentalLabel.Name = "PeriodRentalLabel";
            PeriodRentalLabel.Size = new Size(447, 57);
            PeriodRentalLabel.TabIndex = 2;
            PeriodRentalLabel.Text = "Wypożyczenia: 000000";
            // 
            // TotalPaymentLabel
            // 
            TotalPaymentLabel.AutoSize = true;
            TotalPaymentLabel.Font = new Font("Segoe UI", 25F);
            TotalPaymentLabel.Location = new Point(37, 33);
            TotalPaymentLabel.Name = "TotalPaymentLabel";
            TotalPaymentLabel.Size = new Size(397, 57);
            TotalPaymentLabel.TabIndex = 0;
            TotalPaymentLabel.Text = "Zyski: 1000000,00 zł";
            // 
            // MeanLabel
            // 
            MeanLabel.AutoSize = true;
            MeanLabel.Font = new Font("Segoe UI", 25F);
            MeanLabel.Location = new Point(37, 123);
            MeanLabel.Name = "MeanLabel";
            MeanLabel.Size = new Size(444, 57);
            MeanLabel.TabIndex = 1;
            MeanLabel.Text = "Średnia: 1000000,00 zł";
            // 
            // ReportPanel
            // 
            ReportPanel.BorderStyle = BorderStyle.FixedSingle;
            ReportPanel.Controls.Add(ReportLabel);
            ReportPanel.Controls.Add(PeriodReportButton);
            ReportPanel.Controls.Add(DailyReportButton);
            ReportPanel.Location = new Point(1729, 27);
            ReportPanel.Name = "ReportPanel";
            ReportPanel.Size = new Size(789, 103);
            ReportPanel.TabIndex = 4;
            // 
            // ReportLabel
            // 
            ReportLabel.AutoSize = true;
            ReportLabel.Font = new Font("Segoe UI", 25F);
            ReportLabel.Location = new Point(21, 21);
            ReportLabel.Name = "ReportLabel";
            ReportLabel.Size = new Size(353, 57);
            ReportLabel.TabIndex = 7;
            ReportLabel.Text = "Wygeneruj raport";
            // 
            // PeriodReportButton
            // 
            PeriodReportButton.Font = new Font("Segoe UI", 25F);
            PeriodReportButton.Location = new Point(595, 19);
            PeriodReportButton.Name = "PeriodReportButton";
            PeriodReportButton.Size = new Size(174, 63);
            PeriodReportButton.TabIndex = 6;
            PeriodReportButton.Text = "Okres";
            PeriodReportButton.UseVisualStyleBackColor = true;
            PeriodReportButton.Click += PeriodReportButton_Click;
            // 
            // DailyReportButton
            // 
            DailyReportButton.Font = new Font("Segoe UI", 25F);
            DailyReportButton.Location = new Point(400, 19);
            DailyReportButton.Name = "DailyReportButton";
            DailyReportButton.Size = new Size(174, 63);
            DailyReportButton.TabIndex = 5;
            DailyReportButton.Text = "Dzień";
            DailyReportButton.UseVisualStyleBackColor = true;
            DailyReportButton.Click += DailyReportButton_Click;
            // 
            // DailyPanel
            // 
            DailyPanel.BorderStyle = BorderStyle.FixedSingle;
            DailyPanel.Controls.Add(TodayPopularBrand);
            DailyPanel.Controls.Add(TodayPaymentsLabel);
            DailyPanel.Controls.Add(TodayRentalsLabel);
            DailyPanel.Controls.Add(DailyPlotView);
            DailyPanel.Controls.Add(LateReturnLabel);
            DailyPanel.Controls.Add(RepairCarsProgressBar);
            DailyPanel.Controls.Add(RepairCarLabel);
            DailyPanel.Controls.Add(AvailableCarsLabel);
            DailyPanel.Controls.Add(CarsAvaiableProgressBar);
            DailyPanel.Location = new Point(1397, 155);
            DailyPanel.Name = "DailyPanel";
            DailyPanel.Size = new Size(1121, 1186);
            DailyPanel.TabIndex = 5;
            // 
            // TodayPopularBrand
            // 
            TodayPopularBrand.AutoSize = true;
            TodayPopularBrand.Font = new Font("Segoe UI", 25F);
            TodayPopularBrand.Location = new Point(15, 277);
            TodayPopularBrand.Name = "TodayPopularBrand";
            TodayPopularBrand.Size = new Size(384, 57);
            TodayPopularBrand.TabIndex = 8;
            TodayPopularBrand.Text = "Top brand: Testowa";
            TodayPopularBrand.TextAlign = ContentAlignment.TopRight;
            // 
            // TodayPaymentsLabel
            // 
            TodayPaymentsLabel.AutoSize = true;
            TodayPaymentsLabel.Font = new Font("Segoe UI", 25F);
            TodayPaymentsLabel.Location = new Point(15, 388);
            TodayPaymentsLabel.Name = "TodayPaymentsLabel";
            TodayPaymentsLabel.Size = new Size(436, 57);
            TodayPaymentsLabel.TabIndex = 7;
            TodayPaymentsLabel.Text = "Zapłacono dzisiaj 0,00";
            TodayPaymentsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // TodayRentalsLabel
            // 
            TodayRentalsLabel.AutoSize = true;
            TodayRentalsLabel.Font = new Font("Segoe UI", 25F);
            TodayRentalsLabel.Location = new Point(594, 277);
            TodayRentalsLabel.Name = "TodayRentalsLabel";
            TodayRentalsLabel.Size = new Size(503, 57);
            TodayRentalsLabel.TabIndex = 6;
            TodayRentalsLabel.Text = "Dzisiejsze wypożyczenia 0";
            TodayRentalsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // DailyPlotView
            // 
            DailyPlotView.Location = new Point(46, 487);
            DailyPlotView.Name = "DailyPlotView";
            DailyPlotView.PanCursor = Cursors.Hand;
            DailyPlotView.Size = new Size(1051, 677);
            DailyPlotView.TabIndex = 5;
            DailyPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            DailyPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            DailyPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // LateReturnLabel
            // 
            LateReturnLabel.AutoSize = true;
            LateReturnLabel.Font = new Font("Segoe UI", 25F);
            LateReturnLabel.Location = new Point(707, 388);
            LateReturnLabel.Name = "LateReturnLabel";
            LateReturnLabel.Size = new Size(390, 57);
            LateReturnLabel.TabIndex = 4;
            LateReturnLabel.Text = "Zalegające zwroty 0";
            LateReturnLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // RepairCarsProgressBar
            // 
            RepairCarsProgressBar.Location = new Point(690, 155);
            RepairCarsProgressBar.MarqueeAnimationSpeed = 0;
            RepairCarsProgressBar.Name = "RepairCarsProgressBar";
            RepairCarsProgressBar.Size = new Size(407, 63);
            RepairCarsProgressBar.Step = 1;
            RepairCarsProgressBar.TabIndex = 3;
            // 
            // RepairCarLabel
            // 
            RepairCarLabel.AutoSize = true;
            RepairCarLabel.Font = new Font("Segoe UI", 25F);
            RepairCarLabel.Location = new Point(15, 155);
            RepairCarLabel.Name = "RepairCarLabel";
            RepairCarLabel.Size = new Size(538, 57);
            RepairCarLabel.TabIndex = 2;
            RepairCarLabel.Text = "Samochody w naprawie 0/0";
            RepairCarLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // AvailableCarsLabel
            // 
            AvailableCarsLabel.AutoSize = true;
            AvailableCarsLabel.Font = new Font("Segoe UI", 25F);
            AvailableCarsLabel.Location = new Point(15, 48);
            AvailableCarsLabel.Name = "AvailableCarsLabel";
            AvailableCarsLabel.Size = new Size(503, 57);
            AvailableCarsLabel.TabIndex = 1;
            AvailableCarsLabel.Text = "Dostępne samochody 0/0";
            AvailableCarsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CarsAvaiableProgressBar
            // 
            CarsAvaiableProgressBar.Location = new Point(690, 48);
            CarsAvaiableProgressBar.MarqueeAnimationSpeed = 0;
            CarsAvaiableProgressBar.Name = "CarsAvaiableProgressBar";
            CarsAvaiableProgressBar.Size = new Size(407, 63);
            CarsAvaiableProgressBar.Step = 1;
            CarsAvaiableProgressBar.TabIndex = 0;
            // 
            // StatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2542, 1061);
            Controls.Add(DailyPanel);
            Controls.Add(ReportPanel);
            Controls.Add(PeriodPanel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StatsForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += StatsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PeriodPanel.ResumeLayout(false);
            PeriodPanel.PerformLayout();
            ReportPanel.ResumeLayout(false);
            ReportPanel.PerformLayout();
            DailyPanel.ResumeLayout(false);
            DailyPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label DateLimitLabel;
        private Button DateResetButton;
        private Panel PeriodPanel;
        private Panel ReportPanel;
        private Label ReportLabel;
        private Button PeriodReportButton;
        private Button DailyReportButton;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Panel DailyPanel;
        private ProgressBar CarsAvaiableProgressBar;
        private Label AvailableCarsLabel;
        private Label RepairCarLabel;
        private ProgressBar RepairCarsProgressBar;
        private Label LateReturnLabel;
        private OxyPlot.WindowsForms.PlotView DailyPlotView;
        private Label TodayRentalsLabel;
        private Label TodayPaymentsLabel;
        private Label TodayPopularBrand;
        private Label MeanLabel;
        private Label TotalPaymentLabel;
        private Label NewCustomersLabel;
        private Label MeanRentalTimeLabel;
        private Label PeriodRentalLabel;
        private Button OptionsPlotButton;
        private Label PeriodPopularBrand;
        private OxyPlot.WindowsForms.PlotView PeriodPlotView;
        private Label label1;
        private DateTimePicker EndDatePicker;
        private DateTimePicker StartDatePicker;
        private ComboBox DateRangeComboBox;
        private Button CarTypePlotButton;
        private Button FuelTypePlotButton;
        private Button PaymentTypePlotButton;
        private Button PopularCarsPlotButton;
        private Button PopularBrandsPlotButton;
    }
}