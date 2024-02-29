using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TangerineAuction
{
    public partial class WelcomeForm : Form
    {
        int dR, dG, dB, sign;
        public WelcomeForm()
        {
            InitializeComponent();

            dR = WelcomeLabel.BackColor.R - WelcomeLabel.ForeColor.R;
            dG = WelcomeLabel.BackColor.G - WelcomeLabel.ForeColor.G;
            dB = WelcomeLabel.BackColor.B - WelcomeLabel.ForeColor.B;
            sign = 1;
            Timer timer = new Timer();
            timer.Interval = 150;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        // Плавное появление нового текста.
        private void timer_Tick(object sender, EventArgs e)
        {
            if (Math.Abs(WelcomeLabel.ForeColor.R - WelcomeLabel.BackColor.R) < Math.Abs(dR / 10))
            {
                sign *= -1;
                WelcomeLabel.Text = "Добро пожаловать!";
            }
            WelcomeLabel.ForeColor = Color.FromArgb(255, WelcomeLabel.ForeColor.R + sign * dR / 10, WelcomeLabel.ForeColor.G + sign * dG / 10, WelcomeLabel.ForeColor.B + sign * dB / 10);
            if (WelcomeLabel.BackColor.R == WelcomeLabel.ForeColor.R + dR)
            {
                ((Timer)sender).Stop();
            }
        }
    }
}
