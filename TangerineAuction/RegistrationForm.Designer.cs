namespace TangerineAuction
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MinimizedButton = new System.Windows.Forms.PictureBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.MailIcon = new System.Windows.Forms.PictureBox();
            this.PasswordIcon = new System.Windows.Forms.PictureBox();
            this.PasswordIcon2 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.ConfirmRegistration = new TangerineAuction.Components.RoundButton();
            this.CodeFromMessagePanel = new System.Windows.Forms.Panel();
            this.ConfirmCode = new TangerineAuction.Components.RoundButton();
            this.label4 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.Annotation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizedButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.CodeFromMessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::TangerineAuction.Properties.Resources.Close;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(938, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(50, 50);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizedButton
            // 
            this.MinimizedButton.BackgroundImage = global::TangerineAuction.Properties.Resources.ArrowDown;
            this.MinimizedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizedButton.Location = new System.Drawing.Point(882, 12);
            this.MinimizedButton.Name = "MinimizedButton";
            this.MinimizedButton.Size = new System.Drawing.Size(50, 50);
            this.MinimizedButton.TabIndex = 7;
            this.MinimizedButton.TabStop = false;
            this.MinimizedButton.Click += new System.EventHandler(this.MinimizedButton_Click);
            // 
            // MailTextBox
            // 
            this.MailTextBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 24F);
            this.MailTextBox.Location = new System.Drawing.Point(281, 173);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(499, 50);
            this.MailTextBox.TabIndex = 9;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 24F);
            this.PasswordTextBox.Location = new System.Drawing.Point(281, 243);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(499, 50);
            this.PasswordTextBox.TabIndex = 10;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 24F);
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(281, 313);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(499, 50);
            this.ConfirmPasswordTextBox.TabIndex = 11;
            this.ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // MailIcon
            // 
            this.MailIcon.BackColor = System.Drawing.Color.Transparent;
            this.MailIcon.BackgroundImage = global::TangerineAuction.Properties.Resources.Envelope;
            this.MailIcon.Location = new System.Drawing.Point(211, 167);
            this.MailIcon.Name = "MailIcon";
            this.MailIcon.Size = new System.Drawing.Size(64, 64);
            this.MailIcon.TabIndex = 12;
            this.MailIcon.TabStop = false;
            // 
            // PasswordIcon
            // 
            this.PasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.PasswordIcon.BackgroundImage = global::TangerineAuction.Properties.Resources.Lock;
            this.PasswordIcon.Location = new System.Drawing.Point(211, 237);
            this.PasswordIcon.Name = "PasswordIcon";
            this.PasswordIcon.Size = new System.Drawing.Size(64, 64);
            this.PasswordIcon.TabIndex = 13;
            this.PasswordIcon.TabStop = false;
            // 
            // PasswordIcon2
            // 
            this.PasswordIcon2.BackColor = System.Drawing.Color.Transparent;
            this.PasswordIcon2.BackgroundImage = global::TangerineAuction.Properties.Resources.Lock;
            this.PasswordIcon2.Location = new System.Drawing.Point(211, 307);
            this.PasswordIcon2.Name = "PasswordIcon2";
            this.PasswordIcon2.Size = new System.Drawing.Size(64, 64);
            this.PasswordIcon2.TabIndex = 14;
            this.PasswordIcon2.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::TangerineAuction.Properties.Resources.ArrowBack;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(2, 97);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 100);
            this.BackButton.TabIndex = 16;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ConfirmRegistration
            // 
            this.ConfirmRegistration.BackColor2 = System.Drawing.Color.Empty;
            this.ConfirmRegistration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmRegistration.BackgroundImage")));
            this.ConfirmRegistration.ButtonBorderColor = System.Drawing.Color.Black;
            this.ConfirmRegistration.ButtonHighlightColor = System.Drawing.Color.Black;
            this.ConfirmRegistration.ButtonHighlightColor2 = System.Drawing.Color.Black;
            this.ConfirmRegistration.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.ConfirmRegistration.ButtonPressedColor = System.Drawing.Color.Black;
            this.ConfirmRegistration.ButtonPressedColor2 = System.Drawing.Color.Black;
            this.ConfirmRegistration.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.ConfirmRegistration.ButtonRoundRadius = 30;
            this.ConfirmRegistration.Location = new System.Drawing.Point(399, 394);
            this.ConfirmRegistration.Name = "ConfirmRegistration";
            this.ConfirmRegistration.Size = new System.Drawing.Size(210, 70);
            this.ConfirmRegistration.TabIndex = 15;
            this.ConfirmRegistration.Text = "Регистрация";
            this.ConfirmRegistration.Click += new System.EventHandler(this.ConfirmRegistration_Click);
            // 
            // CodeFromMessagePanel
            // 
            this.CodeFromMessagePanel.BackColor = System.Drawing.Color.Transparent;
            this.CodeFromMessagePanel.Controls.Add(this.ConfirmCode);
            this.CodeFromMessagePanel.Controls.Add(this.label4);
            this.CodeFromMessagePanel.Controls.Add(this.codeTextBox);
            this.CodeFromMessagePanel.Location = new System.Drawing.Point(299, 504);
            this.CodeFromMessagePanel.Name = "CodeFromMessagePanel";
            this.CodeFromMessagePanel.Size = new System.Drawing.Size(430, 152);
            this.CodeFromMessagePanel.TabIndex = 17;
            // 
            // ConfirmCode
            // 
            this.ConfirmCode.BackColor2 = System.Drawing.Color.Empty;
            this.ConfirmCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmCode.BackgroundImage")));
            this.ConfirmCode.ButtonBorderColor = System.Drawing.Color.Black;
            this.ConfirmCode.ButtonHighlightColor = System.Drawing.Color.Black;
            this.ConfirmCode.ButtonHighlightColor2 = System.Drawing.Color.Black;
            this.ConfirmCode.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.ConfirmCode.ButtonPressedColor = System.Drawing.Color.Black;
            this.ConfirmCode.ButtonPressedColor2 = System.Drawing.Color.Black;
            this.ConfirmCode.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.ConfirmCode.ButtonRoundRadius = 30;
            this.ConfirmCode.Location = new System.Drawing.Point(127, 94);
            this.ConfirmCode.Name = "ConfirmCode";
            this.ConfirmCode.Size = new System.Drawing.Size(161, 44);
            this.ConfirmCode.TabIndex = 18;
            this.ConfirmCode.Text = "Подтвердить";
            this.ConfirmCode.Click += new System.EventHandler(this.ConfirmCode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Код из отправленного сообщения на почту";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(156, 68);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 7;
            // 
            // Annotation
            // 
            this.Annotation.AutoSize = true;
            this.Annotation.BackColor = System.Drawing.Color.Transparent;
            this.Annotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Annotation.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.Annotation.Location = new System.Drawing.Point(124, 97);
            this.Annotation.Name = "Annotation";
            this.Annotation.Size = new System.Drawing.Size(830, 30);
            this.Annotation.TabIndex = 18;
            this.Annotation.Text = "Введите адрес электронной почты, пароль и его подтверждение повторным вводом.";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TangerineAuction.Properties.Resources.Main;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.Annotation);
            this.Controls.Add(this.CodeFromMessagePanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmRegistration);
            this.Controls.Add(this.PasswordIcon2);
            this.Controls.Add(this.PasswordIcon);
            this.Controls.Add(this.MailIcon);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizedButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizedButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.CodeFromMessagePanel.ResumeLayout(false);
            this.CodeFromMessagePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox MinimizedButton;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.PictureBox MailIcon;
        private System.Windows.Forms.PictureBox PasswordIcon;
        private System.Windows.Forms.PictureBox PasswordIcon2;
        private Components.RoundButton ConfirmRegistration;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Panel CodeFromMessagePanel;
        private Components.RoundButton ConfirmCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label Annotation;
    }
}