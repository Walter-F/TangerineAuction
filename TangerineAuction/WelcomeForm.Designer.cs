namespace TangerineAuction
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.BeginButton = new System.Windows.Forms.PictureBox();
            this.BeginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BeginButton)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 64F);
            this.WelcomeLabel.Location = new System.Drawing.Point(0, 84);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(1000, 115);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Tangerine Auction";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BeginButton
            // 
            this.BeginButton.BackColor = System.Drawing.Color.Transparent;
            this.BeginButton.BackgroundImage = global::TangerineAuction.Properties.Resources.Auction;
            this.BeginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BeginButton.Location = new System.Drawing.Point(447, 505);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(100, 100);
            this.BeginButton.TabIndex = 1;
            this.BeginButton.TabStop = false;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // BeginLabel
            // 
            this.BeginLabel.BackColor = System.Drawing.Color.Transparent;
            this.BeginLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 24F);
            this.BeginLabel.Location = new System.Drawing.Point(439, 608);
            this.BeginLabel.Name = "BeginLabel";
            this.BeginLabel.Size = new System.Drawing.Size(129, 51);
            this.BeginLabel.TabIndex = 2;
            this.BeginLabel.Text = "Начать!";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TangerineAuction.Properties.Resources.Welcome;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.BeginLabel);
            this.Controls.Add(this.BeginButton);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tangerine Auction";
            ((System.ComponentModel.ISupportInitialize)(this.BeginButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox BeginButton;
        private System.Windows.Forms.Label BeginLabel;
    }
}

