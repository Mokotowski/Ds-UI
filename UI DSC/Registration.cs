using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UI_DSC
{
    public partial class Registration : Form
    {
        public static MySqlConnection con { get; private set; }

        public Registration()
        {
            InitializeComponent();
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            string login = logintxtbox.Text;
            string password = passtxt1.Text;
            string nick = nicktxtbox.Text;
            Rejestracja(login, password, nick);
            this.Hide();
            UserInterface userInterface = new UserInterface();
            userInterface.Show();
        }
        void Rejestracja(string login, string password, string nick)
        {
            string query = "select count(*) from users WHERE login ='" + login + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            int Count = int.Parse(cmd.ExecuteScalar() + "");
            if (Count == 0)
            {
                string cmdText = "insert into users(login,haslo) values('" + login + "','" + password + "');";
                MySqlCommand cmdd = new MySqlCommand(cmdText, con);
                cmdd.ExecuteNonQuery();
                setnick(login, password, nick);
                settag(login, password, losujtag());
            }
            else
            {
                wrongdata.Visible = true;
                logintxtbox.Clear();
            }
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            string server = "116.202.211.83";
            string database = "db_79640";
            string username = "db_79640";
            string password = "DHmGq37Az12O";
            string cs = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            var con = new MySqlConnection(cs);
            con.Open();
        }

        void setnick(string login, string password, string nick)
        {
            string que = "UPDATE `users` SET `nick`= '" + nick + "' WHERE `login`= '" + login + "'AND`haslo`= '" + password + "'; ";
            MySqlCommand ggg = new MySqlCommand();
            ggg.CommandText = que;
            ggg.Connection = con;
            ggg.ExecuteNonQuery();
        }

        private static void settag(string login, string password, string tag)
        {
            string que = "UPDATE `users` SET `tag`= '" + tag + "' WHERE `login`= '" + login + "'AND`haslo`= '" + password + "'; ";
            MySqlCommand ggg = new MySqlCommand();
            ggg.CommandText = que;
            ggg.Connection = con;
            ggg.ExecuteNonQuery();
        }

        string losujtag()
        {
            Random generator = new Random();
            string tag = $"#{Convert.ToString((generator.Next(10000, 99999)))}";
            return tag;
        }

        private void passtxt1_TextChanged(object sender, EventArgs e)
        {
            passtxt1.UseSystemPasswordChar = true;
        }

        private void passtxt2_TextChanged(object sender, EventArgs e)
        {
            passtxt2.UseSystemPasswordChar=true;
        }

        private void hidepassword_Click(object sender, EventArgs e)
        {
            if (hidepassword.Checked)
            {
                passtxt1.UseSystemPasswordChar = false;
                passtxt2.UseSystemPasswordChar = false;
            }
            else
            {
                passtxt1.UseSystemPasswordChar = true;
                passtxt2.UseSystemPasswordChar = true;
            }
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
