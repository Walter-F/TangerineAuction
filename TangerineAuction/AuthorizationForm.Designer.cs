namespace TangerineAuction
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.PasswordIcon = new System.Windows.Forms.PictureBox();
            this.MailIcon = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.AuthorizationButton = new TangerineAuction.Components.RoundButton();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MinimizedButton = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizedButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordIcon
            // 
            this.PasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.PasswordIcon.BackgroundImage = global::TangerineAuction.Properties.Resources.Lock;
            this.PasswordIcon.Location = new System.Drawing.Point(216, 253);
            this.PasswordIcon.Name = "PasswordIcon";
            this.PasswordIcon.Size = new System.Drawing.Size(64, 64);
            this.PasswordIcon.TabIndex = 17;
            this.PasswordIcon.TabStop = false;
            // 
            // MailIcon
            // 
            this.MailIcon.BackColor = System.Drawing.Color.Transparent;
            this.MailIcon.BackgroundImage = global::TangerineAuction.Properties.Resources.Envelope;
            this.MailIcon.Location = new System.Drawing.Point(216, 183);
            this.MailIcon.Name = "MailIcon";
            this.MailIcon.Size = new System.Drawing.Size(64, 64);
            this.MailIcon.TabIndex = 16;
            this.MailIcon.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 24F);
            this.PasswordTextBox.Location = new System.Drawing.Point(286, 259);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(499, 50);
            this.PasswordTextBox.TabIndex = 15;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Font = new System.Drawing.Font("Yu Gothic UI Light", 24F);
            this.MailTextBox.Location = new System.Drawing.Point(286, 189);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(499, 50);
            this.MailTextBox.TabIndex = 14;
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.BackColor2 = System.Drawing.Color.Empty;
            this.AuthorizationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AuthorizationButton.BackgroundImage")));
            this.AuthorizationButton.ButtonBorderColor = System.Drawing.Color.Black;
            this.AuthorizationButton.ButtonHighlightColor = System.Drawing.Color.Black;
            this.AuthorizationButton.ButtonHighlightColor2 = System.Drawing.Color.Black;
            this.AuthorizationButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.AuthorizationButton.ButtonPressedColor = System.Drawing.Color.Black;
            this.AuthorizationButton.ButtonPressedColor2 = System.Drawing.Color.Black;
            this.AuthorizationButton.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.AuthorizationButton.ButtonRoundRadius = 30;
            this.AuthorizationButton.Location = new System.Drawing.Point(418, 336);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(210, 70);
            this.AuthorizationButton.TabIndex = 18;
            this.AuthorizationButton.Text = "Авторизация";
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::TangerineAuction.Properties.Resources.Close;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(938, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(50, 50);
            this.CloseButton.TabIndex = 20;
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
            this.MinimizedButton.TabIndex = 19;
            this.MinimizedButton.TabStop = false;
            this.MinimizedButton.Click += new System.EventHandler(this.MinimizedButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::TangerineAuction.Properties.Resources.ArrowBack;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(2, 101);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 100);
            this.BackButton.TabIndex = 21;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TangerineAuction.Properties.Resources.Main;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizedButton);
            this.Controls.Add(this.AuthorizationButton);
            this.Controls.Add(this.PasswordIcon);
            this.Controls.Add(this.MailIcon);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.MailTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationForm";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizedButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PasswordIcon;
        private System.Windows.Forms.PictureBox MailIcon;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox MailTextBox;
        private Components.RoundButton AuthorizationButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox MinimizedButton;
        private System.Windows.Forms.PictureBox BackButton;
    }
}