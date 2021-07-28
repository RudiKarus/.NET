using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//

namespace DBZugriffMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAlleSehen_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;
            DateTime geburtstag;

            con.ConnectionString = "Data Source=localhost;" +   //www.connectionstrings.com
                "Initial Catalog=firma; UID=root";
        }
    }
}