namespace VroomRental.Forms
{
    partial class EndRentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndRentalForm));
            label1 = new Label();
            FinalMileageNumericUpDown = new NumericUpDown();
            MileageStatusLabel = new Label();
            label3 = new Label();
            RepairCheckBox = new CheckBox();
            label4 = new Label();
            RepairCostNumericUpDown = new NumericUpDown();
            TotalAmountLabel = new Label();
            ConfirmPaymentButton = new Button();
            CashRadioButton = new RadioButton();
            BlikRadioButton = new RadioButton();
            label2 = new Label();
            BlikCodeTextBox = new TextBox();
            RepairDescriptionTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)FinalMileageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RepairCostNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 0;
            label1.Text = "Mileage:";
            // 
            // FinalMileageNumericUpDown
            // 
            FinalMileageNumericUpDown.Font = new Font("Segoe UI", 15.75F);
            FinalMileageNumericUpDown.Location = new Point(14, 56);
            FinalMileageNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            FinalMileageNumericUpDown.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            FinalMileageNumericUpDown.Name = "FinalMileageNumericUpDown";
            FinalMileageNumericUpDown.Size = new Size(257, 42);
            FinalMileageNumericUpDown.TabIndex = 1;
            // 
            // MileageStatusLabel
            // 
            MileageStatusLabel.AutoSize = true;
            MileageStatusLabel.Font = new Font("Segoe UI", 15.75F);
            MileageStatusLabel.Location = new Point(14, 139);
            MileageStatusLabel.Name = "MileageStatusLabel";
            MileageStatusLabel.Size = new Size(248, 37);
            MileageStatusLabel.TabIndex = 2;
            MileageStatusLabel.Text = "MileageStatusLabel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(14, 307);
            label3.Name = "label3";
            label3.Size = new Size(230, 37);
            label3.TabIndex = 3;
            label3.Text = "Is repair required?";
            // 
            // RepairCheckBox
            // 
            RepairCheckBox.AutoSize = true;
            RepairCheckBox.Font = new Font("Segoe UI", 15.75F);
            RepairCheckBox.Location = new Point(14, 351);
            RepairCheckBox.Margin = new Padding(3, 4, 3, 4);
            RepairCheckBox.Name = "RepairCheckBox";
            RepairCheckBox.Size = new Size(77, 41);
            RepairCheckBox.TabIndex = 4;
            RepairCheckBox.Text = "yes";
            RepairCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(14, 460);
            label4.Name = "label4";
            label4.Size = new Size(135, 37);
            label4.TabIndex = 5;
            label4.Text = "Repair fee";
            // 
            // RepairCostNumericUpDown
            // 
            RepairCostNumericUpDown.DecimalPlaces = 2;
            RepairCostNumericUpDown.Font = new Font("Segoe UI", 15.75F);
            RepairCostNumericUpDown.Location = new Point(14, 504);
            RepairCostNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            RepairCostNumericUpDown.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            RepairCostNumericUpDown.Name = "RepairCostNumericUpDown";
            RepairCostNumericUpDown.Size = new Size(257, 42);
            RepairCostNumericUpDown.TabIndex = 6;
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Font = new Font("Segoe UI", 15.75F);
            TotalAmountLabel.Location = new Point(14, 839);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(233, 37);
            TotalAmountLabel.TabIndex = 7;
            TotalAmountLabel.Text = "TotalAmountLabel";
            // 
            // ConfirmPaymentButton
            // 
            ConfirmPaymentButton.Font = new Font("Segoe UI", 15.75F);
            ConfirmPaymentButton.Location = new Point(14, 883);
            ConfirmPaymentButton.Margin = new Padding(3, 4, 3, 4);
            ConfirmPaymentButton.Name = "ConfirmPaymentButton";
            ConfirmPaymentButton.Size = new Size(257, 56);
            ConfirmPaymentButton.TabIndex = 8;
            ConfirmPaymentButton.Text = "Confirm Payment";
            ConfirmPaymentButton.UseVisualStyleBackColor = true;
            // 
            // CashRadioButton
            // 
            CashRadioButton.AutoSize = true;
            CashRadioButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CashRadioButton.Location = new Point(14, 693);
            CashRadioButton.Margin = new Padding(3, 4, 3, 4);
            CashRadioButton.Name = "CashRadioButton";
            CashRadioButton.Size = new Size(95, 41);
            CashRadioButton.TabIndex = 9;
            CashRadioButton.TabStop = true;
            CashRadioButton.Text = "Cash";
            CashRadioButton.UseVisualStyleBackColor = true;
            // 
            // BlikRadioButton
            // 
            BlikRadioButton.AutoSize = true;
            BlikRadioButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BlikRadioButton.Location = new Point(14, 747);
            BlikRadioButton.Margin = new Padding(3, 4, 3, 4);
            BlikRadioButton.Name = "BlikRadioButton";
            BlikRadioButton.Size = new Size(80, 41);
            BlikRadioButton.TabIndex = 10;
            BlikRadioButton.TabStop = true;
            BlikRadioButton.Text = "Blik";
            BlikRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(14, 649);
            label2.Name = "label2";
            label2.Size = new Size(226, 37);
            label2.TabIndex = 11;
            label2.Text = "Payment Method:";
            // 
            // BlikCodeTextBox
            // 
            BlikCodeTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BlikCodeTextBox.Location = new Point(14, 788);
            BlikCodeTextBox.Margin = new Padding(3, 4, 3, 4);
            BlikCodeTextBox.Name = "BlikCodeTextBox";
            BlikCodeTextBox.Size = new Size(114, 42);
            BlikCodeTextBox.TabIndex = 12;
            // 
            // RepairDescriptionTextBox
            // 
            RepairDescriptionTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RepairDescriptionTextBox.Location = new Point(14, 559);
            RepairDescriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            RepairDescriptionTextBox.Name = "RepairDescriptionTextBox";
            RepairDescriptionTextBox.PlaceholderText = "Repair Description";
            RepairDescriptionTextBox.Size = new Size(449, 42);
            RepairDescriptionTextBox.TabIndex = 13;
            // 
            // EndRentalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 957);
            Controls.Add(RepairDescriptionTextBox);
            Controls.Add(BlikCodeTextBox);
            Controls.Add(label2);
            Controls.Add(BlikRadioButton);
            Controls.Add(CashRadioButton);
            Controls.Add(ConfirmPaymentButton);
            Controls.Add(TotalAmountLabel);
            Controls.Add(RepairCostNumericUpDown);
            Controls.Add(label4);
            Controls.Add(RepairCheckBox);
            Controls.Add(label3);
            Controls.Add(MileageStatusLabel);
            Controls.Add(FinalMileageNumericUpDown);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "EndRentalForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)FinalMileageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)RepairCostNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown FinalMileageNumericUpDown;
        private Label MileageStatusLabel;
        private Label label3;
        private CheckBox RepairCheckBox;
        private Label label4;
        private NumericUpDown RepairCostNumericUpDown;
        private Label TotalAmountLabel;
        private Button ConfirmPaymentButton;
        private RadioButton CashRadioButton;
        private RadioButton BlikRadioButton;
        private Label label2;
        private TextBox BlikCodeTextBox;
        private TextBox RepairDescriptionTextBox;
    }
}