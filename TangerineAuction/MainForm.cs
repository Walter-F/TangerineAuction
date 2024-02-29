using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TangerineAuction
{
    public partial class MainForm : Form
    {
        List<Tangerine> Tangerines = new List<Tangerine>();
        Dictionary<int, Bitmap> TangerinesPictures = new Dictionary<int, Bitmap>();
        int currentFirstLotShow = 0;
        int currentLastLotShow = 2;
        public MainForm()
        {
            InitializeComponent();

            if (AuthorizationForm.currentUser != string.Empty) {
                Username.Text = AuthorizationForm.currentUser;  
            }

            TangerinesPictures.Add(1, Properties.Resources.TangerineFirst);
            TangerinesPictures.Add(2, Properties.Resources.TangerineSecond);
            TangerinesPictures.Add(3, Properties.Resources.TangerineThird);
            TangerinesPictures.Add(4, Properties.Resources.TangerineFourth);
            TangerinesPictures.Add(5, Properties.Resources.TangerineFifth);
            TangerinesPictures.Add(6, Properties.Resources.TangerineSixth);

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();

            FirstLabelLot.Hide();
            SecondLabelLot.Hide();
            ThirdLabelLot.Hide();

            FirstValueLot.Hide();
            SecondValueLot.Hide();
            ThirdValueLot.Hide();

            CurrentRateLabelFirst.Hide();
            CurrentRateLabelSecond.Hide();
            CurrentRateLabelThird.Hide();

            CurrentRateValueFirst.Hide();
            CurrentRateValueSecond.Hide();
            CurrentRateValueThird.Hide();

            FromUserLabelFirst.Hide();
            FromUserLabelSecond.Hide();
            FromUserLabelThird.Hide();

            FromUserValueFirst.Hide();
            FromUserValueSecond.Hide();
            FromUserValueThird.Hide();

            BetSumFirst.Hide();
            BetSumSecond.Hide();
            BetSumThird.Hide();

            TangerineFirst.Hide();
            TangerineSecond.Hide();
            TangerineThird.Hide();

            PlaceBetButtonFirst.Hide();
            PlaceBetButtonSecond.Hide();
            PlaceBetButtonThird.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `tangerineslots`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Tangerine tangerine = new Tangerine();
                tangerine.id = Int32.Parse(table.Rows[i][0].ToString());

                tangerine.currrentRate = Int32.Parse(table.Rows[i][1].ToString());
 
                if (table.Rows[i][2].ToString() == String.Empty)
                {
                    tangerine.FromUser = string.Empty;
                }
                else
                {
                    tangerine.FromUser = table.Rows[i][2].ToString();
                }
                tangerine.IconID = Int32.Parse(table.Rows[i][3].ToString());

                if(Tangerines.FirstOrDefault(s => s.id == tangerine.id) == null)
                {
                    Tangerines.Add(tangerine);
                }
            }

            // Инициализация первых трёх лотов
            if(FirstLabelLot.Visible == false && Tangerines.Count >= 1)
            {
                FirstValueLot.Text = "1";
                CurrentRateValueFirst.Text = Tangerines[0].currrentRate.ToString();
                if (Tangerines[0].FromUser == String.Empty)
                {
                    FromUserValueFirst.Text = "-";
                } else
                {
                    FromUserValueFirst.Text = Tangerines[0].FromUser.ToString();
                }
                TangerineFirst.BackgroundImage = TangerinesPictures[Tangerines[0].IconID];


                FirstLabelLot.Show();
                FirstValueLot.Show();
                CurrentRateLabelFirst.Show();
                CurrentRateValueFirst.Show();
                FromUserLabelFirst.Show();
                FromUserValueFirst.Show();
                BetSumFirst.Show();
                TangerineFirst.Show();
                PlaceBetButtonFirst.Show();
            }

            if (SecondLabelLot.Visible == false && Tangerines.Count >= 2)
            {
                SecondValueLot.Text = "2";
                CurrentRateValueSecond.Text = Tangerines[1].currrentRate.ToString();
                if (Tangerines[1].FromUser == String.Empty)
                {
                    FromUserValueSecond.Text = "-";
                }
                else
                {
                    FromUserValueSecond.Text = Tangerines[1].FromUser.ToString();
                }
                TangerineSecond.BackgroundImage = TangerinesPictures[Tangerines[1].IconID];


                SecondLabelLot.Show();
                SecondValueLot.Show();
                CurrentRateLabelSecond.Show();
                CurrentRateValueSecond.Show();
                FromUserLabelSecond.Show();
                FromUserValueSecond.Show();
                BetSumSecond.Show();
                TangerineSecond.Show();
                PlaceBetButtonSecond.Show();
            }

            if (ThirdLabelLot.Visible == false && Tangerines.Count >= 3)
            {
                ThirdValueLot.Text = "3";
                CurrentRateValueThird.Text = Tangerines[2].currrentRate.ToString();
                if (Tangerines[2].FromUser == String.Empty)
                {
                    FromUserValueThird.Text = "-";
                }
                else
                {
                    FromUserValueThird.Text = Tangerines[2].FromUser.ToString();
                }
                TangerineThird.BackgroundImage = TangerinesPictures[Tangerines[2].IconID];


                ThirdLabelLot.Show();
                ThirdValueLot.Show();
                CurrentRateLabelThird.Show();
                CurrentRateValueThird.Show();
                FromUserLabelThird.Show();
                FromUserValueThird.Show();
                BetSumThird.Show();
                TangerineThird.Show();
                PlaceBetButtonThird.Show();
            }

            // Окончание аукциона, отправка уведомлений о выкупе и очистка лотов 
            if(DateTime.Now.Hour == 0 && Tangerines.Count != 0)
            {
                foreach(var tangerine in Tangerines)
                {
                    if(tangerine.currrentRate != 0 && tangerine.FromUser != string.Empty)
                    {
                        try
                        {
                            string from = @"en79s@mail.ru"; // адреса отправителя
                            string pass = "FYRvCxy4RprvrxyQwCKD"; // пароль отправителя
                            MailMessage mess = new MailMessage();
                            mess.To.Add(tangerine.FromUser); // адрес получателя
                            mess.From = new MailAddress(from);
                            mess.Subject = "Tangerine Auction - Успешный выкуп лота"; // тема
                            mess.Body = "Аукцион закончен, вы успешно выкупили лот со ставкой " + tangerine.currrentRate.ToString(); // текст сообщения

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
                            mess.Body = "Пользователю " + tangerine.FromUser + " отправлено сообщение";
                            client.Send(mess); // отправка себе
                            mess.Dispose();
                        }
                        catch (Exception exception)
                        {
                            throw new Exception("Mail.Send: " + exception.Message);
                        }
                    }
                }

                db.openConnection();

                MySqlCommand command2 = new MySqlCommand("DELETE FROM `tangerineslots`", db.getConnection());

                if (command2.ExecuteNonQuery() == 1)
                    MessageBox.Show("Все лоты были успешно удалены после окончания аукциона!");
                else
                    MessageBox.Show("Произошла непредвиденая ошибка при удалении лотов!");

                db.closeConnection();

                Tangerines.Clear();
            }
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

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (AuthorizationForm.currentUser == String.Empty)
            {
                RegistrationForm registrationForm = new RegistrationForm();
                registrationForm.Show();
                this.Hide();
            } else
            {
                MessageBox.Show(
                "Вы уже имеете авторизованный аккаунт!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            if (AuthorizationForm.currentUser == String.Empty)
            {
                AuthorizationForm authorizationForm = new AuthorizationForm();
                authorizationForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                "Вы уже прошли авторизацию!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void PlaceBetButtonFirst_Click(object sender, EventArgs e)
        {
            // Добавить уведомление о перебитии ставки

            if(AuthorizationForm.currentUser == String.Empty)
            {
                MessageBox.Show(
                "Вам необходимо пройти авторизацию для участия в аукционе мандаринок!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else
            {
                if (Int32.Parse(BetSumFirst.Text) > Int32.Parse(CurrentRateValueFirst.Text))
                {
                    if (Int32.Parse(CurrentRateValueFirst.Text) != 0 && FromUserValueFirst.Text != AuthorizationForm.currentUser)
                    {
                        try
                        {
                            string from = @"en79s@mail.ru"; // адреса отправителя
                            string pass = "FYRvCxy4RprvrxyQwCKD"; // пароль отправителя
                            MailMessage mess = new MailMessage();
                            mess.To.Add(FromUserValueFirst.Text); // адрес получателя
                            mess.From = new MailAddress(from);
                            mess.Subject = "Tangerine Auction - Информация о ставке"; // тема
                            mess.Body = "Ваша ставка была перебита пользователем " + AuthorizationForm.currentUser + " новой ставкой: " + BetSumFirst.Text;  // текст сообщения

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
                            mess.Body = "Пользователю " + FromUserValueFirst.Text + " отправлено сообщение";
                            client.Send(mess); // отправка себе
                            mess.Dispose();
                        }
                        catch (Exception exception)
                        {
                            throw new Exception("Mail.Send: " + exception.Message);
                        }
                    }

                    DB db = new DB();

                    db.openConnection();

                    MySqlCommand command = new MySqlCommand("UPDATE `tangerineslots` SET `CurrentRate` = @Rate, `FromUser` = @User WHERE `id` = @ID", db.getConnection());
                    command.Parameters.Add("@Rate", MySqlDbType.Int32).Value = Int32.Parse(BetSumFirst.Text);
                    command.Parameters.Add("@User", MySqlDbType.VarChar).Value = AuthorizationForm.currentUser;
                    command.Parameters.Add("@ID", MySqlDbType.Int32).Value = Tangerines[currentFirstLotShow].id;

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Ставка сделана!");
                    else
                        MessageBox.Show("Неудача!");

                    db.closeConnection();

                    Tangerines[Int32.Parse(FirstValueLot.Text) - 1].currrentRate = Int32.Parse(BetSumFirst.Text);
                    Tangerines[Int32.Parse(FirstValueLot.Text) - 1].FromUser = AuthorizationForm.currentUser;

                    CurrentRateValueFirst.Text = BetSumFirst.Text;
                    FromUserValueFirst.Text = AuthorizationForm.currentUser;
                } else
                {
                    MessageBox.Show(
                    "Сумма ставки должна быть больше текущей!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void PlaceBetButtonSecond_Click(object sender, EventArgs e)
        {
            if (AuthorizationForm.currentUser == String.Empty)
            {
                MessageBox.Show(
                "Вам необходимо пройти авторизацию для участия в аукционе мандаринок!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if (Int32.Parse(BetSumSecond.Text) > Int32.Parse(CurrentRateValueSecond.Text))
                {
                    if (Int32.Parse(CurrentRateValueSecond.Text) != 0 && FromUserValueSecond.Text != AuthorizationForm.currentUser)
                    {
                        try
                        {
                            string from = @"en79s@mail.ru"; // адреса отправителя
                            string pass = "FYRvCxy4RprvrxyQwCKD"; // пароль отправителя
                            MailMessage mess = new MailMessage();
                            mess.To.Add(FromUserValueSecond.Text); // адрес получателя
                            mess.From = new MailAddress(from);
                            mess.Subject = "Tangerine Auction - Информация о ставке"; // тема
                            mess.Body = "Ваша ставка была перебита пользователем " + AuthorizationForm.currentUser + " новой ставкой: " + BetSumSecond.Text;  // текст сообщения

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
                            mess.Body = "Пользователю " + FromUserValueSecond.Text + " отправлено сообщение";
                            client.Send(mess); // отправка себе
                            mess.Dispose();
                        }
                        catch (Exception exception)
                        {
                            throw new Exception("Mail.Send: " + exception.Message);
                        }
                    }
                    DB db = new DB();

                    db.openConnection();

                    MySqlCommand command = new MySqlCommand("UPDATE `tangerineslots` SET `CurrentRate` = @Rate, `FromUser` = @User WHERE `id` = @ID", db.getConnection());
                    command.Parameters.Add("@Rate", MySqlDbType.Int32).Value = Int32.Parse(BetSumSecond.Text);
                    command.Parameters.Add("@User", MySqlDbType.VarChar).Value = AuthorizationForm.currentUser;
                    command.Parameters.Add("@ID", MySqlDbType.Int32).Value = Tangerines[currentFirstLotShow + 1].id;

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Ставка сделана!");
                    else
                        MessageBox.Show("Неудача!");

                    db.closeConnection();

                    Tangerines[Int32.Parse(SecondValueLot.Text) - 1].currrentRate = Int32.Parse(BetSumSecond.Text);
                    Tangerines[Int32.Parse(SecondValueLot.Text) - 1].FromUser = AuthorizationForm.currentUser;

                    CurrentRateValueSecond.Text = BetSumSecond.Text;
                    FromUserValueSecond.Text = AuthorizationForm.currentUser;
                }
            }
        }

        private void PlaceBetButtonThird_Click(object sender, EventArgs e)
        {
            if (AuthorizationForm.currentUser == String.Empty)
            {
                MessageBox.Show(
                "Вам необходимо пройти авторизацию для участия в аукционе мандаринок!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if (Int32.Parse(BetSumThird.Text) > Int32.Parse(CurrentRateValueThird.Text))
                {
                    if (Int32.Parse(CurrentRateValueThird.Text) != 0 && FromUserValueThird.Text != AuthorizationForm.currentUser)
                    {
                        try
                        {
                            string from = @"en79s@mail.ru"; // адреса отправителя
                            string pass = "FYRvCxy4RprvrxyQwCKD"; // пароль отправителя
                            MailMessage mess = new MailMessage();
                            mess.To.Add(FromUserValueThird.Text); // адрес получателя
                            mess.From = new MailAddress(from);
                            mess.Subject = "Tangerine Auction - Информация о ставке"; // тема
                            mess.Body = "Ваша ставка была перебита пользователем " + AuthorizationForm.currentUser + " новой ставкой: " + BetSumThird.Text;  // текст сообщения

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
                            mess.Body = "Пользователю " + FromUserValueThird.Text + " отправлено сообщение";
                            client.Send(mess); // отправка себе
                            mess.Dispose();
                        }
                        catch (Exception exception)
                        {
                            throw new Exception("Mail.Send: " + exception.Message);
                        }
                    }
                    DB db = new DB();

                    db.openConnection();

                    MySqlCommand command = new MySqlCommand("UPDATE `tangerineslots` SET `CurrentRate` = @Rate, `FromUser` = @User WHERE `id` = @ID", db.getConnection());
                    command.Parameters.Add("@Rate", MySqlDbType.Int32).Value = Int32.Parse(BetSumThird.Text);
                    command.Parameters.Add("@User", MySqlDbType.VarChar).Value = AuthorizationForm.currentUser;
                    command.Parameters.Add("@ID", MySqlDbType.Int32).Value = Tangerines[currentFirstLotShow + 2].id;

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Ставка сделана!");
                    else
                        MessageBox.Show("Неудача!");

                    db.closeConnection();

                    Tangerines[Int32.Parse(ThirdValueLot.Text) - 1].currrentRate = Int32.Parse(BetSumThird.Text);
                    Tangerines[Int32.Parse(ThirdValueLot.Text) - 1].FromUser = AuthorizationForm.currentUser;

                    CurrentRateValueThird.Text = BetSumThird.Text;
                    FromUserValueThird.Text = AuthorizationForm.currentUser;
                }
            }
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            if(currentFirstLotShow == 0)
            {
                MessageBox.Show(
                "Вы находитесь в начале списка!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else
            {
                currentFirstLotShow -= 3;
                currentLastLotShow -= 3;

                FirstValueLot.Text = (currentFirstLotShow+1).ToString();
                CurrentRateValueFirst.Text = Tangerines[currentFirstLotShow].currrentRate.ToString();
                if (Tangerines[currentFirstLotShow].FromUser == String.Empty)
                {
                    FromUserValueFirst.Text = "-";
                }
                else
                {
                    FromUserValueFirst.Text = Tangerines[currentFirstLotShow].FromUser.ToString();
                }
                TangerineFirst.BackgroundImage = TangerinesPictures[Tangerines[currentFirstLotShow].IconID];

                SecondValueLot.Text = (currentFirstLotShow + 2).ToString();
                CurrentRateValueSecond.Text = Tangerines[currentFirstLotShow + 1].currrentRate.ToString();
                if (Tangerines[currentFirstLotShow + 1].FromUser == String.Empty)
                {
                    FromUserValueSecond.Text = "-";
                }
                else
                {
                    FromUserValueSecond.Text = Tangerines[currentFirstLotShow + 1].FromUser.ToString();
                }
                TangerineSecond.BackgroundImage = TangerinesPictures[Tangerines[currentFirstLotShow + 1].IconID];

                ThirdValueLot.Text = (currentLastLotShow+1).ToString();
                CurrentRateValueThird.Text = Tangerines[currentLastLotShow].currrentRate.ToString();
                if (Tangerines[currentLastLotShow].FromUser == String.Empty)
                {
                    FromUserValueThird.Text = "-";
                }
                else
                {
                    FromUserValueThird.Text = Tangerines[currentLastLotShow].FromUser.ToString();
                }
                TangerineThird.BackgroundImage = TangerinesPictures[Tangerines[currentLastLotShow].IconID];
            }
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if((currentLastLotShow+3) <= Tangerines.Count && Tangerines.Count % 3 == 0)
            {
                currentFirstLotShow += 3;
                currentLastLotShow += 3;

                FirstValueLot.Text = (currentFirstLotShow+1).ToString();
                CurrentRateValueFirst.Text = Tangerines[currentFirstLotShow].currrentRate.ToString();
                if (Tangerines[currentFirstLotShow].FromUser == String.Empty)
                {
                    FromUserValueFirst.Text = "-";
                }
                else
                {
                    FromUserValueFirst.Text = Tangerines[currentFirstLotShow].FromUser.ToString();
                }
                TangerineFirst.BackgroundImage = TangerinesPictures[Tangerines[currentFirstLotShow].IconID];

                SecondValueLot.Text = (currentFirstLotShow + 2).ToString();
                CurrentRateValueSecond.Text = Tangerines[currentFirstLotShow + 1].currrentRate.ToString();
                if (Tangerines[currentFirstLotShow + 1].FromUser == String.Empty)
                {
                    FromUserValueSecond.Text = "-";
                }
                else
                {
                    FromUserValueSecond.Text = Tangerines[currentFirstLotShow + 1].FromUser.ToString();
                }
                TangerineSecond.BackgroundImage = TangerinesPictures[Tangerines[currentFirstLotShow + 1].IconID];

                ThirdValueLot.Text = (currentLastLotShow+1).ToString();
                CurrentRateValueThird.Text = Tangerines[currentLastLotShow].currrentRate.ToString();
                if (Tangerines[currentLastLotShow].FromUser == String.Empty)
                {
                    FromUserValueThird.Text = "-";
                }
                else
                {
                    FromUserValueThird.Text = Tangerines[currentLastLotShow].FromUser.ToString();
                }
                TangerineThird.BackgroundImage = TangerinesPictures[Tangerines[currentLastLotShow].IconID];
            } else
            {
                MessageBox.Show(
                "Вскоре появятся новые лоты!",
                "Уведомление",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void BetSumFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BetSumSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BetSumThird_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
