using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextfeldEndlos
{
    public partial class Form1 : Form
    {
        int x;

        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }


        private void TxtEingabe1_TextChanged(object sender, EventArgs e)
        {
            TxtEingabe2_TextChanged(sender, e);
        }


        private void TxtEingabe2_TextChanged(object sender, EventArgs e)
        {
            if (x < 1000)
                TxtEingabe2_TextChanged(sender, e);
            else
                LblAnzeige.Text = ":" +x;
        }
    }
}
