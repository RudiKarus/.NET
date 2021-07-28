using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgumenteOptional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double a = 4.5, c = 10.3;
            int b = 7, d = 9;
            LblAnzeige.Text = "Ergebnis: " + Addiere(a, b, c, d);
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double a = 4.5, c = 10.3;
            int b = 7;
            LblAnzeige.Text = "Ergebnis: " + Addiere(a, b, c);
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            double a = 4.5;
            int b = 7;
            LblAnzeige.Text = "Ergebnis: " + Addiere(a, b);
        }


        double Addiere(double x, int y, double z=0, int q=0 ) //z und q sind optional(wenn kein Wert angegeben dann 0)
        {
            return x + y + z + q;
        }
    }
}
