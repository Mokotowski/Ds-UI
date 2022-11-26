using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace UI_DSC
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public string haslo { get; private set; }
        public string login { get; private set; }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string server = "116.202.211.83";
            string database = "db_79640";
            string username = "db_79640";
            string password = "DHmGq37Az12O";
            string cs = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            var con = new MySqlConnection(cs);
            con.Open();

            login = logintxt.Text; // Przypisanie wartości z pola tekstowego. Działa dobrze więc jak narazie zostawiam.
            haslo = passwordtxt.Text; // Tutaj tak samo jak powyżej

            void Logowanie(string login, string haslo)
            {
                string query = "select count(*) from users WHERE login ='" + login + "' AND haslo ='" + haslo + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                int Count = int.Parse(cmd.ExecuteScalar() + "");
                if (Count == 1)
                {
                    MessageBox.Show($"Zalogowano pomyślnie");
                }
                else
                {
                    wrongdata.Visible = true;
                    logintxt.Clear();
                    passwordtxt.Clear();
                }
            }
            Logowanie(login, haslo);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            passwordtxt.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
