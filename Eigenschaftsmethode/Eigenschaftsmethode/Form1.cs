using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eigenschaftsmethode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug();
            LblAnzeige.Text = "Geschwindigkeit 0: " + vespa.Geschwindigkeit;

            vespa.Beschleunigen(120);
            LblAnzeige.Text += "\nGeschwindigkeit 1: " + vespa.Geschwindigkeit;
        }
    }
}
