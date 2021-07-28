using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;//
using System.Threading;//
using System.Resources;//

namespace Lokalisierung
{
    public partial class Form1 : Form
    {
        private ResourceManager rm = new ResourceManager("Lokalisierung.MeineTexte", typeof(Form1).Assembly);

        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");

            InitializeComponent();
        }


        private void CmdEins_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rm.GetString("meldungEins"));
        }


        private void CmdZwei_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rm.GetString("meldungZwei"));
        }
    }
}
