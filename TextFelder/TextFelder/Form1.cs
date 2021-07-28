using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFelder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           /* NumEingabe.Value = 2;
            NumEingabe.Maximum = 5;
            NumEingabe.Minimum = -5;
            NumEingabe.Increment = (1/10);
            NumEingabe.DecimalPlaces = 1;
            */
        }

        private void CmdAusgabe_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Sie haben " + TxtEingabe.Text + " eingegeben.";
        }

        private void CmdRechnen_Click(object sender, EventArgs e)
        {
            double Zahl; //eine Zahl mit möglichen Nachkommastellen;
            Zahl = Convert.ToDouble(TxtEingabe.Text);
            Zahl = Zahl * 2;
            LblAnzeige.Text = "Ergebnis: " + Zahl;
        }

        private void NumEingabe_ValueChanged(object sender, EventArgs e)
        {
            LblAusgabe.Text = "Wert: " + NumEingabe.Value;
        }
    }
}
