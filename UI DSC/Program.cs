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
        }
    }
}
