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
            label1 = new Label();
            FinalMileageNumericUpDown = new NumericUpDown();
            MileageStatusLabel = new Label();
            label3 = new Label();
            RepairCheckBox = new CheckBox();
            label4 = new Label();
            RepairCostNumericUpDown = new NumericUpDown();
            TotalAmountLabel = new Label();
            ConfirmPaymentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)FinalMileageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RepairCostNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 0;
            label1.Text = "Stan licznika:";
            // 
            // FinalMileageNumericUpDown
            // 
            FinalMileageNumericUpDown.DecimalPlaces = 1;
            FinalMileageNumericUpDown.Font = new Font("Segoe UI", 15.75F);
            FinalMileageNumericUpDown.Location = new Point(12, 42);
            FinalMileageNumericUpDown.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            FinalMileageNumericUpDown.Name = "FinalMileageNumericUpDown";
            FinalMileageNumericUpDown.Size = new Size(225, 35);
            FinalMileageNumericUpDown.TabIndex = 1;
            // 
            // MileageStatusLabel
            // 
            MileageStatusLabel.AutoSize = true;
            MileageStatusLabel.Font = new Font("Segoe UI", 15.75F);
            MileageStatusLabel.Location = new Point(12, 104);
            MileageStatusLabel.Name = "MileageStatusLabel";
            MileageStatusLabel.Size = new Size(192, 30);
            MileageStatusLabel.TabIndex = 2;
            MileageStatusLabel.Text = "MileageStatusLabel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(12, 230);
            label3.Name = "label3";
            label3.Size = new Size(324, 30);
            label3.TabIndex = 3;
            label3.Text = "Czy samochód wymaga naprawy?";
            // 
            // RepairCheckBox
            // 
            RepairCheckBox.AutoSize = true;
            RepairCheckBox.Font = new Font("Segoe UI", 15.75F);
            RepairCheckBox.Location = new Point(12, 263);
            RepairCheckBox.Name = "RepairCheckBox";
            RepairCheckBox.Size = new Size(111, 34);
            RepairCheckBox.TabIndex = 4;
            RepairCheckBox.Text = "naprawa";
            RepairCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(12, 345);
            label4.Name = "label4";
            label4.Size = new Size(173, 30);
            label4.TabIndex = 5;
            label4.Text = "Kara za stan auta";
            // 
            // RepairCostNumericUpDown
            // 
            RepairCostNumericUpDown.DecimalPlaces = 2;
            RepairCostNumericUpDown.Font = new Font("Segoe UI", 15.75F);
            RepairCostNumericUpDown.Location = new Point(12, 378);
            RepairCostNumericUpDown.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            RepairCostNumericUpDown.Name = "RepairCostNumericUpDown";
            RepairCostNumericUpDown.Size = new Size(225, 35);
            RepairCostNumericUpDown.TabIndex = 6;
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Font = new Font("Segoe UI", 15.75F);
            TotalAmountLabel.Location = new Point(12, 463);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(181, 30);
            TotalAmountLabel.TabIndex = 7;
            TotalAmountLabel.Text = "TotalAmountLabel";
            // 
            // ConfirmPaymentButton
            // 
            ConfirmPaymentButton.Font = new Font("Segoe UI", 15.75F);
            ConfirmPaymentButton.Location = new Point(12, 502);
            ConfirmPaymentButton.Name = "ConfirmPaymentButton";
            ConfirmPaymentButton.Size = new Size(225, 42);
            ConfirmPaymentButton.TabIndex = 8;
            ConfirmPaymentButton.Text = "Confirm Payment";
            ConfirmPaymentButton.UseVisualStyleBackColor = true;
            // 
            // EndRentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 556);
            Controls.Add(ConfirmPaymentButton);
            Controls.Add(TotalAmountLabel);
            Controls.Add(RepairCostNumericUpDown);
            Controls.Add(label4);
            Controls.Add(RepairCheckBox);
            Controls.Add(label3);
            Controls.Add(MileageStatusLabel);
            Controls.Add(FinalMileageNumericUpDown);
            Controls.Add(label1);
            Name = "EndRentalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EndRentalForm";
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
    }
}