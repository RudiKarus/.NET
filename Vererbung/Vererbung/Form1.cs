using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vererbung
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
            Fahrzeug vespa = new Fahrzeug();
            PKW fiat = new PKW();

            vespa.Beschleunigen(35);
            LblAnzeige.Text = vespa + "";
            LblAnzeige.Text += "\n" + fiat;

            fiat.Einsteigen(3);
            fiat.Beschleunigen(30);
            LblAnzeige.Text += "\n" + fiat;
        }
    }
}
