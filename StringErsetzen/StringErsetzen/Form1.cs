using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringErsetzen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }

        private void CmdErsetzen_Click(object sender, EventArgs e)
        {
            string eingabe, suchen, ersetzen, anzeige;

            eingabe = TxtEingabe.Text;
            suchen = TxtSuchen.Text;
            ersetzen = TxtErsetzen.Text;
            anzeige = eingabe.Replace(suchen, ersetzen);

            LblAnzeige.Text = anzeige;
        }
    }
}
