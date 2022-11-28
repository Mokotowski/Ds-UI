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
using MySqlX.XDevAPI.Relational;

namespace UI_DSC
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        void laczenie_do_serwera(MySqlConnection con)
        {
            string server = "116.202.211.83";
            string database = "db_79640";
            string username = "db_79640";
            string password = "DHmGq37Az12O";
            string cs = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(cs);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                chkcon.Text = "Połączono";
                chkcon.Show();
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void btnlogin_Click(object sender, EventArgs e, MySqlConnection con)
        {
           string login = logintxt.Text; 
           string haslo = passwordtxt.Text; 
           Logowanie(login, haslo, con);
        }
        void Logowanie(string login, string haslo, MySqlConnection con)
        {
            string query = "select count(*) from users WHERE login ='" + login + "' AND haslo ='" + haslo + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            int Count = int.Parse(cmd.ExecuteScalar() + "");
            if (Count == 1)
            {
                MessageBox.Show("Konto istnieje");
                this.Hide();
                UserInterface userInterface = new UserInterface();
                userInterface.Show();
            }
            else
            {
                wrongdata.Visible = true;
                logintxt.Clear();
                passwordtxt.Clear();
            }
        }
        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            passwordtxt.UseSystemPasswordChar = true;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void hidepassword_Click(object sender, EventArgs e)
        {
            if (hidepassword.Checked)
            {
                passwordtxt.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtxt.UseSystemPasswordChar = true;
            }
        }
    }
}
