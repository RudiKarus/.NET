using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgumenteBenannt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }
        
        void Rechteck(string farbe, int laenge=1, int breite=1, string rand="Linie") //die 3 letzten Parameter sind optional und werden mit Standardwerten initialisiert;
        {
            LblAnzeige.Text = "Farbe: " + farbe + ", Länge: " + laenge + ", Breite: " + breite + ", Rand: " + rand;
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            Rechteck("rot", 4, 6, "Punkte");
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            Rechteck("rot", rand:"Striche", breite:2, laenge:5);
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            Rechteck("gelb", 7);
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            Rechteck("blau", rand:"Haarlinie");
        }
    }
}
