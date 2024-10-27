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
            ((System.ComponentModel.ISupportInitialize)dataGridViewTest).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTest
            // 
            dataGridViewTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTest.Location = new Point(12, 21);
            dataGridViewTest.Name = "dataGridViewTest";
            dataGridViewTest.RowHeadersWidth = 51;
            dataGridViewTest.Size = new Size(1334, 417);
            dataGridViewTest.TabIndex = 0;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 450);
            Controls.Add(dataGridViewTest);
            Name = "TestForm";
            Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTest;
    }
}
