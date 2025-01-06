namespace VroomRental.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginTextBox = new TextBox();
            PasswordMaskedTextBox = new MaskedTextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            AppNameLabel = new Label();
            LogoPictureBox = new PictureBox();
            LoginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Segoe UI", 18F);
            LoginTextBox.Location = new Point(87, 243);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(308, 47);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordMaskedTextBox
            // 
            PasswordMaskedTextBox.Font = new Font("Segoe UI", 18F);
            PasswordMaskedTextBox.Location = new Point(87, 377);
            PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            PasswordMaskedTextBox.Size = new Size(308, 47);
            PasswordMaskedTextBox.TabIndex = 1;
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 18F);
            LoginLabel.Location = new Point(195, 187);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(92, 41);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 18F);
            PasswordLabel.Location = new Point(194, 322);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(93, 41);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Hasło";
            // 
            // AppNameLabel
            // 
            AppNameLabel.AutoSize = true;
            AppNameLabel.Font = new Font("Segoe UI", 18F);
            AppNameLabel.Location = new Point(140, 9);
            AppNameLabel.Name = "AppNameLabel";
            AppNameLabel.Size = new Size(198, 41);
            AppNameLabel.TabIndex = 4;
            AppNameLabel.Text = "Vroom Rental";
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = (Image)resources.GetObject("LogoPictureBox.Image");
            LogoPictureBox.Location = new Point(140, 53);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(188, 111);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPictureBox.TabIndex = 5;
            LogoPictureBox.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 18F);
            LoginButton.Location = new Point(87, 475);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(315, 61);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Zaloguj";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 548);
            Controls.Add(LoginButton);
            Controls.Add(LogoPictureBox);
            Controls.Add(AppNameLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordMaskedTextBox);
            Controls.Add(LoginTextBox);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private MaskedTextBox PasswordMaskedTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Label AppNameLabel;
        private PictureBox LogoPictureBox;
        private Button LoginButton;
    }
}