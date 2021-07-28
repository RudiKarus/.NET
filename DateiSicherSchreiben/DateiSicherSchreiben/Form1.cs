using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DateiSicherSchreiben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }

        private void CmdAusnahme_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamWriter sw;
            string dateiname = "aus.txt";

            try
            {
                fs = new FileStream(dateiname, FileMode.Create);
                sw = new StreamWriter(fs);

                sw.WriteLine(TxtEingabe.Text);
                LblAnzeige.Text = TxtEingabe.Text; //zur internen Kontrollausgabe;
                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
