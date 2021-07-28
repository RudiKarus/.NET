using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekursiverAufruf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }


        private void CmdSchleife_Click(object sender, EventArgs e)
        {
            double x = 22;
            LblAnzeige.Text = "x: " + x + "\n";

            while (x > 0.1)
            {
                x = x / 2;
                LblAnzeige.Text += "x: " + x + "\n";
            }
        }


        private void CmdRekursion_Click(object sender, EventArgs e)
        {
            double x = 22;
            LblAnzeige.Text= "x: " + x + "\n";
            Halbieren(ref x);
            LblAnzeige.Text += "x: " + x + "\n";
        }


        void Halbieren(ref double z)
        {
            z = z / 2;
            if (z>0.1) //ohne diese Verzweigung würde sich die Methode "Halbieren()" endlos selbst aufrufen;
            {
                LblAnzeige.Text += "z: " + z + "\n";
                Halbieren(ref z);
            }
        }
    }
}
