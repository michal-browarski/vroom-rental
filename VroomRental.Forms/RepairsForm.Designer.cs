namespace VroomRental.Forms
{
    partial class RepairsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepairsForm));
            groupBox1 = new GroupBox();
            SearchButton = new Button();
            ResetSearchButton = new Button();
            ReportDateToPicker = new DateTimePicker();
            label10 = new Label();
            ReportDateFromPicker = new DateTimePicker();
            SearchStatusComboBox = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            SearchCarTextBox = new TextBox();
            label9 = new Label();
            dataGridRepairs = new DataGridView();
            groupBox2 = new GroupBox();
            CarTextBox = new TextBox();
            label6 = new Label();
            CostTextBox = new TextBox();
            EndDatePicker = new DateTimePicker();
            RepairStatusComboBox = new ComboBox();
            DescriptionTextBox = new TextBox();
            ReportDatePicker = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            ResetButton = new Button();
            EditButton = new Button();
            RemoveButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRepairs).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SearchButton);
            groupBox1.Controls.Add(ResetSearchButton);
            groupBox1.Controls.Add(ReportDateToPicker);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(ReportDateFromPicker);
            groupBox1.Controls.Add(SearchStatusComboBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(SearchCarTextBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Segoe UI", 25F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1385, 274);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search repair";
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 25F);
            SearchButton.Location = new Point(1080, 186);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(299, 76);
            SearchButton.TabIndex = 42;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // ResetSearchButton
            // 
            ResetSearchButton.Font = new Font("Segoe UI", 25F);
            ResetSearchButton.Location = new Point(1080, 32);
            ResetSearchButton.Margin = new Padding(3, 2, 3, 2);
            ResetSearchButton.Name = "ResetSearchButton";
            ResetSearchButton.Size = new Size(299, 76);
            ResetSearchButton.TabIndex = 41;
            ResetSearchButton.Text = "Reset";
            ResetSearchButton.UseVisualStyleBackColor = true;
            // 
            // ReportDateToPicker
            // 
            ReportDateToPicker.Format = DateTimePickerFormat.Short;
            ReportDateToPicker.Location = new Point(710, 96);
            ReportDateToPicker.Name = "ReportDateToPicker";
            ReportDateToPicker.Size = new Size(262, 52);
            ReportDateToPicker.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 25F);
            label10.Location = new Point(763, 48);
            label10.Name = "label10";
            label10.Size = new Size(156, 46);
            label10.TabIndex = 39;
            label10.Text = "End Date";
            // 
            // ReportDateFromPicker
            // 
            ReportDateFromPicker.Format = DateTimePickerFormat.Short;
            ReportDateFromPicker.Location = new Point(363, 96);
            ReportDateFromPicker.Name = "ReportDateFromPicker";
            ReportDateFromPicker.Size = new Size(262, 52);
            ReportDateFromPicker.TabIndex = 38;
            // 
            // SearchStatusComboBox
            // 
            SearchStatusComboBox.FormattingEnabled = true;
            SearchStatusComboBox.Location = new Point(23, 209);
            SearchStatusComboBox.Name = "SearchStatusComboBox";
            SearchStatusComboBox.Size = new Size(262, 53);
            SearchStatusComboBox.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 25F);
            label8.Location = new Point(402, 48);
            label8.Name = "label8";
            label8.Size = new Size(170, 46);
            label8.TabIndex = 35;
            label8.Text = "Start Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 25F);
            label7.Location = new Point(83, 160);
            label7.Name = "label7";
            label7.Size = new Size(111, 46);
            label7.TabIndex = 33;
            label7.Text = "Status";
            // 
            // SearchCarTextBox
            // 
            SearchCarTextBox.Font = new Font("Segoe UI", 25F);
            SearchCarTextBox.Location = new Point(23, 96);
            SearchCarTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchCarTextBox.Name = "SearchCarTextBox";
            SearchCarTextBox.Size = new Size(262, 52);
            SearchCarTextBox.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 25F);
            label9.Location = new Point(110, 48);
            label9.Name = "label9";
            label9.Size = new Size(70, 46);
            label9.TabIndex = 31;
            label9.Text = "Car";
            // 
            // dataGridRepairs
            // 
            dataGridRepairs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRepairs.Location = new Point(12, 292);
            dataGridRepairs.MultiSelect = false;
            dataGridRepairs.Name = "dataGridRepairs";
            dataGridRepairs.ReadOnly = true;
            dataGridRepairs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRepairs.Size = new Size(1385, 664);
            dataGridRepairs.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CarTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(CostTextBox);
            groupBox2.Controls.Add(EndDatePicker);
            groupBox2.Controls.Add(RepairStatusComboBox);
            groupBox2.Controls.Add(DescriptionTextBox);
            groupBox2.Controls.Add(ReportDatePicker);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Segoe UI", 25F);
            groupBox2.Location = new Point(1403, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(809, 944);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Repair Details";
            // 
            // CarTextBox
            // 
            CarTextBox.Location = new Point(294, 86);
            CarTextBox.Name = "CarTextBox";
            CarTextBox.Size = new Size(486, 52);
            CarTextBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(168, 89);
            label6.Name = "label6";
            label6.Size = new Size(70, 46);
            label6.TabIndex = 11;
            label6.Text = "Car";
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(294, 504);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(486, 52);
            CostTextBox.TabIndex = 10;
            // 
            // EndDatePicker
            // 
            EndDatePicker.Format = DateTimePickerFormat.Short;
            EndDatePicker.Location = new Point(294, 415);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(486, 52);
            EndDatePicker.TabIndex = 9;
            // 
            // RepairStatusComboBox
            // 
            RepairStatusComboBox.FormattingEnabled = true;
            RepairStatusComboBox.Location = new Point(294, 325);
            RepairStatusComboBox.Name = "RepairStatusComboBox";
            RepairStatusComboBox.Size = new Size(486, 53);
            RepairStatusComboBox.TabIndex = 8;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(294, 242);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(486, 52);
            DescriptionTextBox.TabIndex = 7;
            // 
            // ReportDatePicker
            // 
            ReportDatePicker.Format = DateTimePickerFormat.Short;
            ReportDatePicker.Location = new Point(294, 171);
            ReportDatePicker.Name = "ReportDatePicker";
            ReportDatePicker.Size = new Size(486, 52);
            ReportDatePicker.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 507);
            label5.Name = "label5";
            label5.Size = new Size(87, 46);
            label5.TabIndex = 5;
            label5.Text = "Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 421);
            label4.Name = "label4";
            label4.Size = new Size(156, 46);
            label4.TabIndex = 4;
            label4.Text = "End Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 332);
            label3.Name = "label3";
            label3.Size = new Size(111, 46);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 245);
            label2.Name = "label2";
            label2.Size = new Size(191, 46);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 171);
            label1.Name = "label1";
            label1.Size = new Size(201, 46);
            label1.TabIndex = 1;
            label1.Text = "Report Date";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ResetButton);
            groupBox3.Controls.Add(EditButton);
            groupBox3.Controls.Add(RemoveButton);
            groupBox3.Location = new Point(6, 652);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(797, 286);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // ResetButton
            // 
            ResetButton.Font = new Font("Segoe UI", 25F);
            ResetButton.Location = new Point(475, 196);
            ResetButton.Margin = new Padding(3, 2, 3, 2);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(299, 76);
            ResetButton.TabIndex = 21;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 25F);
            EditButton.Location = new Point(24, 196);
            EditButton.Margin = new Padding(3, 2, 3, 2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(299, 76);
            EditButton.TabIndex = 19;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI", 25F);
            RemoveButton.Location = new Point(24, 50);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(299, 76);
            RemoveButton.TabIndex = 20;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // RepairsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2224, 968);
            Controls.Add(groupBox2);
            Controls.Add(dataGridRepairs);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RepairsForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRepairs).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridRepairs;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button ResetButton;
        private Button EditButton;
        private Button RemoveButton;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker ReportDatePicker;
        private TextBox DescriptionTextBox;
        private ComboBox RepairStatusComboBox;
        private DateTimePicker EndDatePicker;
        private TextBox CostTextBox;
        private Label label6;
        private TextBox CarTextBox;
        private Label label7;
        private TextBox SearchCarTextBox;
        private Label label9;
        private Label label8;
        private ComboBox SearchStatusComboBox;
        private DateTimePicker ReportDateToPicker;
        private Label label10;
        private DateTimePicker ReportDateFromPicker;
        private Button SearchButton;
        private Button ResetSearchButton;
    }
}