using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TangerineAuctionHost
{
    public class Program
    {
        private static Timer _timer = null;
        static void Main(string[] args)
        {
            _timer = new Timer(TimerCallback, null, 0, 10000);
            Console.ReadLine();
        }

        private static void TimerCallback(Object o)
        {
            if (DateTime.Now.Hour != 0)
            {
                Random random = new Random(DateTime.Now.Millisecond);
                DB db = new DB();

                db.openConnection();

                MySqlCommand command = new MySqlCommand("INSERT INTO `tangerineslots` (`id`, `CurrentRate`, `FromUser`, `IconID`) VALUES (NULL, 0, NULL, @IconID)", db.getConnection());
                command.Parameters.Add("@IconID", MySqlDbType.VarChar).Value = random.Next(1, 6);


                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Мандаринка была успешно добавлена на аукцион: " + DateTime.Now);
                }
                else
                {
                    Console.WriteLine("Произошла ошибка при добавлении мандаринки на аукцион: " + DateTime.Now);
                }

                db.closeConnection();
            }
        }
    }
}
