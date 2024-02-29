using MySql.Data.MySqlClient;
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
    public partial class AuthorizationForm : Form
    {
        public static string currentUser = string.Empty;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void MinimizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите завершить работу с программой?", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][1].ToString() == MailTextBox.Text && table.Rows[i][2].ToString() == PasswordTextBox.Text)
                {
                    currentUser = MailTextBox.Text;
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                }
            }

            if (this.Visible)
            {
                MessageBox.Show(
                       "Вы ввели некорректный адрес электронной почты или пароль!",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }
    }
}
