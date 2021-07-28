using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFormatieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            string format;
            string ausgabe;
            string[] stadt = { "München", "Berlin", "Bonn", "Bremerhaven", "Ulm" };

            LstAnzeige.Items.Clear();

            format = "{0,-15}{1,9:0.0000}{2,12:#,##0.0}";

            for(int i=0; i < stadt.Length; i++)
            {
                ausgabe = String.Format(format, stadt[i], i / 7.0, i * 10000 / 7);
                LstAnzeige.Items.Add(ausgabe);

                LblAnzeige.Text += ausgabe + "\n";
            }
        }
    }
}
