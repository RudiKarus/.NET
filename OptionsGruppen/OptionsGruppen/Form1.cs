using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionsGruppen
{
    public partial class Form1 : Form
    {
        string AusgabeUrlaubsort;
        string AusgabeUnterkunft;


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OptUrlaubort(object sender, EventArgs e)
        {
            if (OptBerlin.Checked)
                AusgabeUrlaubsort = "Berlin";
            else if (OptParis.Checked)
                AusgabeUrlaubsort = "Paris";
            else
                AusgabeUrlaubsort = "Rom";

            Anzeigen();
        }

        private void OptUnterkunft(object sender, EventArgs e)
        {
            if (OptAppartment.Checked)
                AusgabeUnterkunft = "Appartment";
            else if (OptPension.Checked)
                AusgabeUnterkunft = "Pension";
            else
                AusgabeUnterkunft = "Hotel";

            Anzeigen();
        }

        private void Anzeigen()
        {
            label1.Text = AusgabeUrlaubsort + ", " + AusgabeUnterkunft;
        }
    }
}
