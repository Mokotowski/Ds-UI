using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Utilities.Collections;
using System.Security.Policy;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using System.Windows.Forms;


namespace UI_DSC
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mainmenu());
            string server = "116.202.211.83";
            string database = "db_79640";
            string username = "db_79640";
            string password = "DHmGq37Az12O";
            string cs = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            var con = new MySqlConnection(cs);
            con.Open();

            void Logowanie(string login, string haslo)
            {
                string query = "select count(*) from users WHERE login ='" + login + "' AND haslo ='" + haslo + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                int Count = int.Parse(cmd.ExecuteScalar() + "");
                if (Count == 1)
                {
                    Console.WriteLine($"Zalogowano pomyślnie");
                }
                else
                {
                    string querry = "select haslo from users WHERE login ='" + login + "'";
                    string querrry = "select login from users WHERE haslo ='" + haslo + "'";

                    MySqlCommand cmdd = new MySqlCommand(querry, con);
                    MySqlCommand cmddd = new MySqlCommand(querrry, con);
                    string loginem = (string)cmdd.ExecuteScalar();
                    string haslem = (string)cmddd.ExecuteScalar();
                    if (haslem == haslo)
                    {
                        Console.WriteLine("Nie poprawny login");
                    }
                    else if (loginem == login)
                    {
                        Console.WriteLine("Nie poprawne hasło");
                    }
                    else
                    {
                        Console.WriteLine("Takie konto nie istnieje");
                    }


                }
            }
        }
    }
}
