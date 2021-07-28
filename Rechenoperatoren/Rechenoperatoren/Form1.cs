using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechenoperatoren
{
    public partial class Rechenoperatoren : Form
    {
        public Rechenoperatoren()
        {
            InitializeComponent();
        }

        private void CmdAusdruck1_Click(object sender, EventArgs e)
        {
            float Ausdruck1 = 3 *-2.5f + 4 * 2;
            LblAnzeige.Text = "Ergebnis 1 = " + Ausdruck1;
                
        }

        private void CmdAusdruck2_Click(object sender, EventArgs e)
        {
            float Ausdruck2 = 3 * (-2.5f + 4) * 2;
            LblAnzeige.Text = "Ergebnis 2 = " + Ausdruck2;
        }

        private void CmdAusdruck3_Click(object sender, EventArgs e)
        {
            bool Ausdruck3 = 12 - 3 >= 4 * 2.5f;
            LblAnzeige.Text = "Ergebnis 3 = " + Ausdruck3;
        }

        private void CmdAusduck4_Click(object sender, EventArgs e)
        {
            bool Ausdruck4 = "Maier" != "Mayer";
            LblAnzeige.Text = "Ergebnis 4 = " + Ausdruck4;
        }

        private void CmdAudruck5_Click(object sender, EventArgs e)
        {
            bool Ausdruck5 = 4 > 3 && -4 > -3;
            LblAnzeige.Text = "Ergebnis 5 = " + Ausdruck5;
        }

        private void CmdAusdruck6_Click(object sender, EventArgs e)
        {
            bool Ausdruck6 = 4 > 3 || -4 > -3;
            LblAnzeige.Text = "Ergebnis 6 = " + Ausdruck6;
        }

        private void CmdVerkettungsoperator_Click(object sender, EventArgs e)
        {
            string a, b;
            double d;
            int x;

            b = "Hallo";
            d = 4.6;
            x = -5;
            a = b + " Welt " + d + " " + x + " " + 12;
            LblAnzeige.Text = a;
            //string xNeu = ""+x; //x wird in eine string-variable umgewandelt und in der Eigenschaft LblAnzeige.Text ausgegeben;
            //LblAnzeige.Text = xNeu;
        }
    }
}
