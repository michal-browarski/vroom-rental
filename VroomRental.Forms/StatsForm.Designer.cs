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
            panel1 = new Panel();
            DateRangeComboBox = new ComboBox();
            label1 = new Label();
            EndDatePicker = new DateTimePicker();
            StartDatePicker = new DateTimePicker();
            DateResetButton = new Button();
            DateLimitLabel = new Label();
            PeriodPanel = new Panel();
            OptionsPlotButton = new Button();
            PaymentMethodPlotButton = new Button();
            BrandsPlotButton = new Button();
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
            panel1.Location = new Point(23, 21);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1468, 77);
            panel1.TabIndex = 2;
            // 
            // DateRangeComboBox
            // 
            DateRangeComboBox.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DateRangeComboBox.FormattingEnabled = true;
            DateRangeComboBox.Location = new Point(1145, 14);
            DateRangeComboBox.Name = "DateRangeComboBox";
            DateRangeComboBox.Size = new Size(143, 48);
            DateRangeComboBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(881, -10);
            label1.Name = "label1";
            label1.Size = new Size(63, 86);
            label1.TabIndex = 6;
            label1.Text = "-";
            // 
            // EndDatePicker
            // 
            EndDatePicker.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EndDatePicker.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EndDatePicker.Format = DateTimePickerFormat.Short;
            EndDatePicker.Location = new Point(944, 14);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(195, 51);
            EndDatePicker.TabIndex = 5;
            // 
            // StartDatePicker
            // 
            StartDatePicker.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            StartDatePicker.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            StartDatePicker.Format = DateTimePickerFormat.Short;
            StartDatePicker.Location = new Point(682, 14);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(195, 51);
            StartDatePicker.TabIndex = 4;
            // 
            // DateResetButton
            // 
            DateResetButton.Font = new Font("Segoe UI", 25F);
            DateResetButton.Location = new Point(1294, 13);
            DateResetButton.Margin = new Padding(3, 2, 3, 2);
            DateResetButton.Name = "DateResetButton";
            DateResetButton.Size = new Size(152, 47);
            DateResetButton.TabIndex = 3;
            DateResetButton.Text = "Reset";
            DateResetButton.UseVisualStyleBackColor = true;
            DateResetButton.Click += DateResetButton_Click;
            // 
            // DateLimitLabel
            // 
            DateLimitLabel.AutoSize = true;
            DateLimitLabel.Font = new Font("Segoe UI", 25F);
            DateLimitLabel.Location = new Point(3, 14);
            DateLimitLabel.Name = "DateLimitLabel";
            DateLimitLabel.Size = new Size(683, 46);
            DateLimitLabel.TabIndex = 2;
            DateLimitLabel.Text = "Określ zakres dat dla wyświetlanych danych :";
            // 
            // PeriodPanel
            // 
            PeriodPanel.BorderStyle = BorderStyle.FixedSingle;
            PeriodPanel.Controls.Add(OptionsPlotButton);
            PeriodPanel.Controls.Add(PaymentMethodPlotButton);
            PeriodPanel.Controls.Add(BrandsPlotButton);
            PeriodPanel.Controls.Add(PeriodPopularBrand);
            PeriodPanel.Controls.Add(PeriodPlotView);
            PeriodPanel.Controls.Add(NewCustomersLabel);
            PeriodPanel.Controls.Add(MeanRentalTimeLabel);
            PeriodPanel.Controls.Add(PeriodRentalLabel);
            PeriodPanel.Controls.Add(TotalPaymentLabel);
            PeriodPanel.Controls.Add(MeanLabel);
            PeriodPanel.Location = new Point(23, 116);
            PeriodPanel.Margin = new Padding(3, 2, 3, 2);
            PeriodPanel.Name = "PeriodPanel";
            PeriodPanel.Size = new Size(1172, 890);
            PeriodPanel.TabIndex = 3;
            // 
            // OptionsPlotButton
            // 
            OptionsPlotButton.Font = new Font("Segoe UI", 25F);
            OptionsPlotButton.Location = new Point(785, 291);
            OptionsPlotButton.Margin = new Padding(3, 2, 3, 2);
            OptionsPlotButton.Name = "OptionsPlotButton";
            OptionsPlotButton.Size = new Size(344, 47);
            OptionsPlotButton.TabIndex = 12;
            OptionsPlotButton.Text = "Opcje dodatkowe";
            OptionsPlotButton.UseVisualStyleBackColor = true;
            OptionsPlotButton.Click += OptionsPlotButton_Click;
            // 
            // PaymentMethodPlotButton
            // 
            PaymentMethodPlotButton.Font = new Font("Segoe UI", 25F);
            PaymentMethodPlotButton.Location = new Point(424, 291);
            PaymentMethodPlotButton.Margin = new Padding(3, 2, 3, 2);
            PaymentMethodPlotButton.Name = "PaymentMethodPlotButton";
            PaymentMethodPlotButton.Size = new Size(344, 47);
            PaymentMethodPlotButton.TabIndex = 11;
            PaymentMethodPlotButton.Text = "Payment Method";
            PaymentMethodPlotButton.UseVisualStyleBackColor = true;
            PaymentMethodPlotButton.Click += PaymentMethodPlotButton_Click;
            // 
            // BrandsPlotButton
            // 
            BrandsPlotButton.Font = new Font("Segoe UI", 25F);
            BrandsPlotButton.Location = new Point(64, 291);
            BrandsPlotButton.Margin = new Padding(3, 2, 3, 2);
            BrandsPlotButton.Name = "BrandsPlotButton";
            BrandsPlotButton.Size = new Size(344, 47);
            BrandsPlotButton.TabIndex = 10;
            BrandsPlotButton.Text = "Popularne marki";
            BrandsPlotButton.UseVisualStyleBackColor = true;
            BrandsPlotButton.Click += BrandsPlotButton_Click;
            // 
            // PeriodPopularBrand
            // 
            PeriodPopularBrand.AutoSize = true;
            PeriodPopularBrand.Font = new Font("Segoe UI", 25F);
            PeriodPopularBrand.Location = new Point(793, 160);
            PeriodPopularBrand.Name = "PeriodPopularBrand";
            PeriodPopularBrand.Size = new Size(309, 46);
            PeriodPopularBrand.TabIndex = 9;
            PeriodPopularBrand.Text = "Top brand: Testowa";
            PeriodPopularBrand.TextAlign = ContentAlignment.TopRight;
            // 
            // PeriodPlotView
            // 
            PeriodPlotView.Location = new Point(32, 358);
            PeriodPlotView.Margin = new Padding(3, 2, 3, 2);
            PeriodPlotView.Name = "PeriodPlotView";
            PeriodPlotView.PanCursor = Cursors.Hand;
            PeriodPlotView.Size = new Size(1107, 508);
            PeriodPlotView.TabIndex = 6;
            PeriodPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            PeriodPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            PeriodPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // NewCustomersLabel
            // 
            NewCustomersLabel.AutoSize = true;
            NewCustomersLabel.Font = new Font("Segoe UI", 25F);
            NewCustomersLabel.Location = new Point(832, 92);
            NewCustomersLabel.Name = "NewCustomersLabel";
            NewCustomersLabel.Size = new Size(271, 46);
            NewCustomersLabel.TabIndex = 4;
            NewCustomersLabel.Text = "Nowi klienci: 000";
            // 
            // MeanRentalTimeLabel
            // 
            MeanRentalTimeLabel.AutoSize = true;
            MeanRentalTimeLabel.Font = new Font("Segoe UI", 25F);
            MeanRentalTimeLabel.Location = new Point(583, 25);
            MeanRentalTimeLabel.Name = "MeanRentalTimeLabel";
            MeanRentalTimeLabel.Size = new Size(508, 46);
            MeanRentalTimeLabel.TabIndex = 3;
            MeanRentalTimeLabel.Text = "Średni czas wypożyczenia: 00 dni";
            // 
            // PeriodRentalLabel
            // 
            PeriodRentalLabel.AutoSize = true;
            PeriodRentalLabel.Font = new Font("Segoe UI", 25F);
            PeriodRentalLabel.Location = new Point(32, 151);
            PeriodRentalLabel.Name = "PeriodRentalLabel";
            PeriodRentalLabel.Size = new Size(356, 46);
            PeriodRentalLabel.TabIndex = 2;
            PeriodRentalLabel.Text = "Wypożyczenia: 000000";
            // 
            // TotalPaymentLabel
            // 
            TotalPaymentLabel.AutoSize = true;
            TotalPaymentLabel.Font = new Font("Segoe UI", 25F);
            TotalPaymentLabel.Location = new Point(32, 25);
            TotalPaymentLabel.Name = "TotalPaymentLabel";
            TotalPaymentLabel.Size = new Size(311, 46);
            TotalPaymentLabel.TabIndex = 0;
            TotalPaymentLabel.Text = "Zyski: 1000000,00 zł";
            // 
            // MeanLabel
            // 
            MeanLabel.AutoSize = true;
            MeanLabel.Font = new Font("Segoe UI", 25F);
            MeanLabel.Location = new Point(32, 92);
            MeanLabel.Name = "MeanLabel";
            MeanLabel.Size = new Size(350, 46);
            MeanLabel.TabIndex = 1;
            MeanLabel.Text = "Średnia: 1000000,00 zł";
            // 
            // ReportPanel
            // 
            ReportPanel.BorderStyle = BorderStyle.FixedSingle;
            ReportPanel.Controls.Add(ReportLabel);
            ReportPanel.Controls.Add(PeriodReportButton);
            ReportPanel.Controls.Add(DailyReportButton);
            ReportPanel.Location = new Point(1513, 20);
            ReportPanel.Margin = new Padding(3, 2, 3, 2);
            ReportPanel.Name = "ReportPanel";
            ReportPanel.Size = new Size(691, 78);
            ReportPanel.TabIndex = 4;
            // 
            // ReportLabel
            // 
            ReportLabel.AutoSize = true;
            ReportLabel.Font = new Font("Segoe UI", 25F);
            ReportLabel.Location = new Point(18, 16);
            ReportLabel.Name = "ReportLabel";
            ReportLabel.Size = new Size(284, 46);
            ReportLabel.TabIndex = 7;
            ReportLabel.Text = "Wygeneruj raport";
            // 
            // PeriodReportButton
            // 
            PeriodReportButton.Font = new Font("Segoe UI", 25F);
            PeriodReportButton.Location = new Point(521, 14);
            PeriodReportButton.Margin = new Padding(3, 2, 3, 2);
            PeriodReportButton.Name = "PeriodReportButton";
            PeriodReportButton.Size = new Size(152, 47);
            PeriodReportButton.TabIndex = 6;
            PeriodReportButton.Text = "Okres";
            PeriodReportButton.UseVisualStyleBackColor = true;
            // 
            // DailyReportButton
            // 
            DailyReportButton.Font = new Font("Segoe UI", 25F);
            DailyReportButton.Location = new Point(350, 14);
            DailyReportButton.Margin = new Padding(3, 2, 3, 2);
            DailyReportButton.Name = "DailyReportButton";
            DailyReportButton.Size = new Size(152, 47);
            DailyReportButton.TabIndex = 5;
            DailyReportButton.Text = "Dzień";
            DailyReportButton.UseVisualStyleBackColor = true;
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
            DailyPanel.Location = new Point(1222, 116);
            DailyPanel.Margin = new Padding(3, 2, 3, 2);
            DailyPanel.Name = "DailyPanel";
            DailyPanel.Size = new Size(981, 890);
            DailyPanel.TabIndex = 5;
            // 
            // TodayPopularBrand
            // 
            TodayPopularBrand.AutoSize = true;
            TodayPopularBrand.Font = new Font("Segoe UI", 25F);
            TodayPopularBrand.Location = new Point(13, 208);
            TodayPopularBrand.Name = "TodayPopularBrand";
            TodayPopularBrand.Size = new Size(309, 46);
            TodayPopularBrand.TabIndex = 8;
            TodayPopularBrand.Text = "Top brand: Testowa";
            TodayPopularBrand.TextAlign = ContentAlignment.TopRight;
            // 
            // TodayPaymentsLabel
            // 
            TodayPaymentsLabel.AutoSize = true;
            TodayPaymentsLabel.Font = new Font("Segoe UI", 25F);
            TodayPaymentsLabel.Location = new Point(13, 291);
            TodayPaymentsLabel.Name = "TodayPaymentsLabel";
            TodayPaymentsLabel.Size = new Size(346, 46);
            TodayPaymentsLabel.TabIndex = 7;
            TodayPaymentsLabel.Text = "Zapłacono dzisiaj 0,00";
            TodayPaymentsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // TodayRentalsLabel
            // 
            TodayRentalsLabel.AutoSize = true;
            TodayRentalsLabel.Font = new Font("Segoe UI", 25F);
            TodayRentalsLabel.Location = new Point(520, 208);
            TodayRentalsLabel.Name = "TodayRentalsLabel";
            TodayRentalsLabel.Size = new Size(403, 46);
            TodayRentalsLabel.TabIndex = 6;
            TodayRentalsLabel.Text = "Dzisiejsze wypożyczenia 0";
            TodayRentalsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // DailyPlotView
            // 
            DailyPlotView.Location = new Point(40, 365);
            DailyPlotView.Margin = new Padding(3, 2, 3, 2);
            DailyPlotView.Name = "DailyPlotView";
            DailyPlotView.PanCursor = Cursors.Hand;
            DailyPlotView.Size = new Size(920, 508);
            DailyPlotView.TabIndex = 5;
            DailyPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            DailyPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            DailyPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // LateReturnLabel
            // 
            LateReturnLabel.AutoSize = true;
            LateReturnLabel.Font = new Font("Segoe UI", 25F);
            LateReturnLabel.Location = new Point(619, 291);
            LateReturnLabel.Name = "LateReturnLabel";
            LateReturnLabel.Size = new Size(314, 46);
            LateReturnLabel.TabIndex = 4;
            LateReturnLabel.Text = "Zalegające zwroty 0";
            LateReturnLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // RepairCarsProgressBar
            // 
            RepairCarsProgressBar.Location = new Point(604, 116);
            RepairCarsProgressBar.Margin = new Padding(3, 2, 3, 2);
            RepairCarsProgressBar.MarqueeAnimationSpeed = 0;
            RepairCarsProgressBar.Name = "RepairCarsProgressBar";
            RepairCarsProgressBar.Size = new Size(356, 47);
            RepairCarsProgressBar.Step = 1;
            RepairCarsProgressBar.TabIndex = 3;
            // 
            // RepairCarLabel
            // 
            RepairCarLabel.AutoSize = true;
            RepairCarLabel.Font = new Font("Segoe UI", 25F);
            RepairCarLabel.Location = new Point(13, 116);
            RepairCarLabel.Name = "RepairCarLabel";
            RepairCarLabel.Size = new Size(432, 46);
            RepairCarLabel.TabIndex = 2;
            RepairCarLabel.Text = "Samochody w naprawie 0/0";
            RepairCarLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // AvailableCarsLabel
            // 
            AvailableCarsLabel.AutoSize = true;
            AvailableCarsLabel.Font = new Font("Segoe UI", 25F);
            AvailableCarsLabel.Location = new Point(13, 36);
            AvailableCarsLabel.Name = "AvailableCarsLabel";
            AvailableCarsLabel.Size = new Size(403, 46);
            AvailableCarsLabel.TabIndex = 1;
            AvailableCarsLabel.Text = "Dostępne samochody 0/0";
            AvailableCarsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CarsAvaiableProgressBar
            // 
            CarsAvaiableProgressBar.Location = new Point(604, 36);
            CarsAvaiableProgressBar.Margin = new Padding(3, 2, 3, 2);
            CarsAvaiableProgressBar.MarqueeAnimationSpeed = 0;
            CarsAvaiableProgressBar.Name = "CarsAvaiableProgressBar";
            CarsAvaiableProgressBar.Size = new Size(356, 47);
            CarsAvaiableProgressBar.Step = 1;
            CarsAvaiableProgressBar.TabIndex = 0;
            // 
            // StatsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2224, 796);
            Controls.Add(DailyPanel);
            Controls.Add(ReportPanel);
            Controls.Add(PeriodPanel);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StatsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistics";
            WindowState = FormWindowState.Maximized;
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
        private Button PaymentMethodPlotButton;
        private Button BrandsPlotButton;
        private Label PeriodPopularBrand;
        private OxyPlot.WindowsForms.PlotView PeriodPlotView;
        private Label label1;
        private DateTimePicker EndDatePicker;
        private DateTimePicker StartDatePicker;
        private ComboBox DateRangeComboBox;
    }
}