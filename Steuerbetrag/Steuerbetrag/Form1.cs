using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steuerbetrag
{
    public partial class Steuerbetrag : Form
    {
        public Steuerbetrag()
        {
            InitializeComponent();

            LblAnweisung1.Text = "Gehalt in €: ";
            LblAnzeige1.Text = "";
        }

        private void CmdBerechnen_Click(object sender, EventArgs e)
        {
            string Eingabe = textBox1.Text;
            double Gehalt = Convert.ToDouble(Eingabe);
            byte Steuersatz;

            //LblAnzeige1.Text = "Sie haben " + Gehalt + "€ eingegeben.";

            if (Gehalt == 0) Steuersatz = 0;
            else if (Gehalt > 0 && Gehalt <= 12000) Steuersatz = 12;
            else if (Gehalt > 12000 && Gehalt <= 20000) Steuersatz = 15;
            else if (Gehalt > 20000 && Gehalt <= 30000) Steuersatz = 20;
            else Steuersatz = 25;

            double Steuerbetrag;
            /*switch(Steuersatz)
            {
                case 12:
                    Steuerbetrag = (Gehalt * Steuersatz) / 100;
                    LblAnzeige1.Text = "Bei einem Gehalt von " + Gehalt + "€ ist gemäß des Steuersatzes von " + Steuersatz +"% ein Steuerbetrag von " + Steuerbetrag + "€ zu zahlen";
                case 15:
                case 20:
                case 25:
            }*/
            if (Steuersatz == 0) LblAnzeige1.Text = "Ein Gehalt von 0€ muss nicht versteuert werden.";
            else
            {
                Steuerbetrag = (Gehalt * Steuersatz) / 100;
                LblAnzeige1.Text = "Gehalt: " + Gehalt + "€" + "\n" +
                "Steuersatz: " + Steuersatz + "%" + "\n" +
                "Steuerbetrag: " + Steuerbetrag + "€";
            }
        }
    }
}
