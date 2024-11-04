namespace VroomRental.Forms
{
    partial class TestForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewTest = new DataGridView();
            btnShowCustomers = new Button();
            btnShowEmployees = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTest).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTest
            // 
            dataGridViewTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTest.Location = new Point(10, 16);
            dataGridViewTest.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTest.Name = "dataGridViewTest";
            dataGridViewTest.ReadOnly = true;
            dataGridViewTest.RowHeadersWidth = 51;
            dataGridViewTest.Size = new Size(1167, 313);
            dataGridViewTest.TabIndex = 0;
            dataGridViewTest.CellDoubleClick += dataGridViewTest_CellDoubleClick;
            // 
            // btnShowCustomers
            // 
            btnShowCustomers.Location = new Point(12, 359);
            btnShowCustomers.Name = "btnShowCustomers";
            btnShowCustomers.Size = new Size(108, 23);
            btnShowCustomers.TabIndex = 1;
            btnShowCustomers.Text = "Klienci";
            btnShowCustomers.UseVisualStyleBackColor = true;
            btnShowCustomers.Click += btnShowCustomers_Click;
            // 
            // btnShowEmployees
            // 
            btnShowEmployees.Location = new Point(12, 397);
            btnShowEmployees.Name = "btnShowEmployees";
            btnShowEmployees.Size = new Size(108, 23);
            btnShowEmployees.TabIndex = 2;
            btnShowEmployees.Text = "Pracownicy";
            btnShowEmployees.UseVisualStyleBackColor = true;
            btnShowEmployees.Click += btnShowEmployees_Click;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 462);
            Controls.Add(btnShowEmployees);
            Controls.Add(btnShowCustomers);
            Controls.Add(dataGridViewTest);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TestForm";
            Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTest;
        private Button btnShowCustomers;
        private Button btnShowEmployees;
    }
}
