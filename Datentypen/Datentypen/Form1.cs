using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datentypen
{
    public partial class Form1 : Form
    {
        string name = "Rudi Kraus";
        byte alter = 34;
        float groesse = 1.83f;
        byte gewicht = 77;
        string rang = "Grüngurt (6.Kup)";

        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = name + "\n"
                + rang + "\n"
                + alter + " Jahre " + "\n"
                + groesse + " m " + "\n"
                + gewicht + " Kg " + "\n";             
        }
    }
}
