using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgumenteBeliebig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }


        double MittelWert(params double[]x) //"params double []" ermöglicht die Übergabe beliebig vieler Parameter vom gleichen Typ (hier: vom Typ double);
        {
            double summe = 0;

            foreach (int z in x)
                summe += z;
                return summe / x.Length;
        }


        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double a = 4.5, b = 7.2, c = 10.3, d = 9.2;
            LblAnzeige.Text = "Ergebnis: " + MittelWert(a,b,c,d);
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double a = 4.5, b = 7.2;
            LblAnzeige.Text = "Ergebnis: " + MittelWert(a, b);
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Ergebnis: " + MittelWert();
        }
    }
}
