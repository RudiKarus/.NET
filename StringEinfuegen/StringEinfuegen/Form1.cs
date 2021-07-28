using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEinfuegen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }

        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            string eingabe;
            string einfuegen;
            string anzeige;

            eingabe = TxtEingabe.Text;
            einfuegen = TxtEinfuegen.Text;
            anzeige = eingabe.Insert((int)NumEinfuegen.Value, einfuegen); //das Zahlenauswahlfeld liefert eine Variable vom Typ decimal und muss in eine int Variable umgewandelt werden;
            LblAnzeige.Text = anzeige;
        }

        private void TxtEingabe_TextChanged(object sender, EventArgs e)
        {
            string eingabe;
            eingabe = TxtEingabe.Text;
            NumEinfuegen.Maximum = eingabe.Length;
        }
    }
}
