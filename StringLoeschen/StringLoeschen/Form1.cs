using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringLoeschen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }


        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            string eingabe;
            string anzeige;

            eingabe = TxtEingabe.Text;
            anzeige = eingabe.Remove((int)NumPosition.Value, (int)NumAnzahl.Value);
            LblAnzeige.Text = anzeige;
        }


        private void TxtEingabe_TextChanged(object sender, EventArgs e)
        {
            string eingabe = TxtEingabe.Text;
            NumAnzahl.Maximum = eingabe.Length - NumPosition.Value;
            NumPosition.Maximum = eingabe.Length - 1;
        }


        private void NumPosition_ValueChanged(object sender, EventArgs e)
        {
            string eingabe = TxtEingabe.Text;
            NumAnzahl.Maximum = eingabe.Length - NumPosition.Value;
        }
    }
}
