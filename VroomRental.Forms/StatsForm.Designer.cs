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
            StartDateMaskedTextBox = new MaskedTextBox();
            EndDateMaskedTextBox = new MaskedTextBox();
            panel1 = new Panel();
            DateResetButton = new Button();
            DateLimitLabel = new Label();
            PeriodPanel = new Panel();
            ReportPanel = new Panel();
            ReportLabel = new Label();
            PeriodReportButton = new Button();
            DailyReportButton = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            DailyPanel = new Panel();
            ProgressLabel = new Label();
            CarsAvaiableProgressBar = new ProgressBar();
            panel1.SuspendLayout();
            ReportPanel.SuspendLayout();
            DailyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // StartDateMaskedTextBox
            // 
            StartDateMaskedTextBox.Font = new Font("Segoe UI", 25F);
            StartDateMaskedTextBox.Location = new Point(952, 14);
            StartDateMaskedTextBox.Mask = "00/00/0000";
            StartDateMaskedTextBox.Name = "StartDateMaskedTextBox";
            StartDateMaskedTextBox.Size = new Size(223, 63);
            StartDateMaskedTextBox.TabIndex = 0;
            StartDateMaskedTextBox.ValidatingType = typeof(DateTime);
            // 
            // EndDateMaskedTextBox
            // 
            EndDateMaskedTextBox.Font = new Font("Segoe UI", 25F);
            EndDateMaskedTextBox.Location = new Point(1221, 17);
            EndDateMaskedTextBox.Mask = "00/00/0000";
            EndDateMaskedTextBox.Name = "EndDateMaskedTextBox";
            EndDateMaskedTextBox.Size = new Size(223, 63);
            EndDateMaskedTextBox.TabIndex = 1;
            EndDateMaskedTextBox.ValidatingType = typeof(DateTime);
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(DateResetButton);
            panel1.Controls.Add(DateLimitLabel);
            panel1.Controls.Add(StartDateMaskedTextBox);
            panel1.Controls.Add(EndDateMaskedTextBox);
            panel1.Location = new Point(26, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1677, 102);
            panel1.TabIndex = 2;
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
            DateLimitLabel.Location = new Point(37, 17);
            DateLimitLabel.Name = "DateLimitLabel";
            DateLimitLabel.Size = new Size(851, 57);
            DateLimitLabel.TabIndex = 2;
            DateLimitLabel.Text = "Określ zakres dat dla wyświetlanych danych :";
            // 
            // PeriodPanel
            // 
            PeriodPanel.BorderStyle = BorderStyle.FixedSingle;
            PeriodPanel.Location = new Point(26, 155);
            PeriodPanel.Name = "PeriodPanel";
            PeriodPanel.Size = new Size(1472, 1176);
            PeriodPanel.TabIndex = 3;
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
            PeriodReportButton.Location = new Point(595, 18);
            PeriodReportButton.Name = "PeriodReportButton";
            PeriodReportButton.Size = new Size(174, 63);
            PeriodReportButton.TabIndex = 6;
            PeriodReportButton.Text = "Okres";
            PeriodReportButton.UseVisualStyleBackColor = true;
            // 
            // DailyReportButton
            // 
            DailyReportButton.Font = new Font("Segoe UI", 25F);
            DailyReportButton.Location = new Point(400, 18);
            DailyReportButton.Name = "DailyReportButton";
            DailyReportButton.Size = new Size(174, 63);
            DailyReportButton.TabIndex = 5;
            DailyReportButton.Text = "Dzień";
            DailyReportButton.UseVisualStyleBackColor = true;
            // 
            // DailyPanel
            // 
            DailyPanel.BorderStyle = BorderStyle.FixedSingle;
            DailyPanel.Controls.Add(ProgressLabel);
            DailyPanel.Controls.Add(CarsAvaiableProgressBar);
            DailyPanel.Location = new Point(1528, 155);
            DailyPanel.Name = "DailyPanel";
            DailyPanel.Size = new Size(990, 1176);
            DailyPanel.TabIndex = 5;
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.Font = new Font("Segoe UI", 25F);
            ProgressLabel.Location = new Point(13, 31);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(503, 57);
            ProgressLabel.TabIndex = 1;
            ProgressLabel.Text = "Dostępne samochody 0/0";
            // 
            // CarsAvaiableProgressBar
            // 
            CarsAvaiableProgressBar.Location = new Point(571, 31);
            CarsAvaiableProgressBar.MarqueeAnimationSpeed = 0;
            CarsAvaiableProgressBar.Name = "CarsAvaiableProgressBar";
            CarsAvaiableProgressBar.Size = new Size(399, 63);
            CarsAvaiableProgressBar.Step = 1;
            CarsAvaiableProgressBar.TabIndex = 0;
            // 
            // StatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2542, 1343);
            Controls.Add(DailyPanel);
            Controls.Add(ReportPanel);
            Controls.Add(PeriodPanel);
            Controls.Add(panel1);
            Name = "StatsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistics";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ReportPanel.ResumeLayout(false);
            ReportPanel.PerformLayout();
            DailyPanel.ResumeLayout(false);
            DailyPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaskedTextBox StartDateMaskedTextBox;
        private MaskedTextBox EndDateMaskedTextBox;
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
        private Label ProgressLabel;
    }
}