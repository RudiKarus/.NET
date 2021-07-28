using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringTeilzeichenkette
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
            string eingabe;
            string anzeige;

            eingabe = TxtEingabe.Text;
            anzeige = eingabe.Substring((int)NumPosition.Value, (int)NumLaenge.Value);
            LblAnzeige.Text = anzeige;
        }

        private void TxtEingabe_TextChanged(object sender, EventArgs e)
        {
            string eingabe = TxtEingabe.Text;
            NumPosition.Maximum = eingabe.Length - 1;
            NumLaenge.Maximum = eingabe.Length - NumPosition.Value;
        }

        private void NumPosition_ValueChanged(object sender, EventArgs e)
        {
            string eingabe = TxtEingabe.Text;
            NumLaenge.Maximum = eingabe.Length - NumPosition.Value;
        }
    }
}
