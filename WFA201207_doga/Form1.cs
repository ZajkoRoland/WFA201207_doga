using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA201207_doga
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            conn = new SqlConnection(
               @"Server=(localdb)\MSSQLLocalDB;" +
               @"AttachDbFileName=|DataDirectory|\Resources\music.mdf;");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"pendulum.txt");
            string s = sr.ReadLine();
            string[] darabol = s.Split(';');
        }
    }
}
