using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TangerineAuction
{
    public partial class RegistrationForm : Form
    {
        public Random random = new Random(DateTime.Now.Millisecond);
        public int generatedCode = 0;
        public int currentCode;

        public static void SendMessage(string userName, string adressTo, string messageSubject, string messageText)
        {
            try
            {
                string from = @"en79s@mail.ru"; // адреса отправителя
                string pass = "FYRvCxy4RprvrxyQwCKD"; // пароль отправителя
                MailMessage mess = new MailMessage();
                mess.To.Add(adressTo); // адрес получателя
                mess.From = new MailAddress(from);
                mess.Subject = messageSubject; // тема
                mess.Body = messageText; // текст сообщения

                // Настройка клиента и отправка сообщения
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.mail.ru"; // smtp-сервер отправителя
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], pass);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mess); // отправка пользователю

                mess.To.Remove(mess.To[0]);
                mess.To.Add(from); //для сообщения на свой адрес
                mess.Subject = "Отправлено сообщение";
                mess.Body = "Пользователю " + userName + " отправлено сообщение";
                client.Send(mess); // отправка себе
                mess.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }

        public int generateCode()
        {
            int temp = generatedCode;
            if (generatedCode != 0)
            {
                do
                {
                    generatedCode = random.Next(1000, 9999);
                } while (generatedCode == temp);
                return generatedCode;
            }
            else
            {
                generatedCode = random.Next(1000, 9999);
                return generatedCode;
            }
        }

        public RegistrationForm()
        {
            InitializeComponent();
            CodeFromMessagePanel.Hide();
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

        static bool alreadyExist(string mail)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][1].ToString() == mail)
                {
                    return true;
                }
            }

            return false;
        }

        private void ConfirmRegistration_Click(object sender, EventArgs e)
        {
            if (new EmailAddressAttribute().IsValid(MailTextBox.Text) && alreadyExist(MailTextBox.Text) == false)
            {
                if (PasswordTextBox.Text == ConfirmPasswordTextBox.Text)
                {
                    currentCode = generateCode();
                    SendMessage(MailTextBox.Text, MailTextBox.Text, "Tangerine Auction - Подтверждение регистрации", "Ваш персональный код для подтверждения регистрации: " + currentCode.ToString());
                    CodeFromMessagePanel.Show();
                }
            }
            else
            {
                MessageBox.Show(
                    "Вы ввели некорректный адрес электронной почты или на этот адрес уже заведён аккаунт!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfirmCode_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text == currentCode.ToString())
            {
                DB db = new DB();

                db.openConnection();

                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`id`, `mail`, `password`) VALUES (NULL, @mail, @password)", db.getConnection());
                command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = MailTextBox.Text;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTextBox.Text;


                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(
                    "Регистрация прошла успешно",
                    "Успех!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    AuthorizationForm.currentUser = MailTextBox.Text;

                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                   MessageBox.Show(
                   "Регистрация не пройдена",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }

                db.closeConnection();
            }
        }
    }
}
