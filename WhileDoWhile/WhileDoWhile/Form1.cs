using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDoWhile
{
    public partial class Form1 : Form
    {
        Random r = new Random();


        public Form1()
        {
            InitializeComponent();
        }


        private void CmdWhile_Click(object sender, EventArgs e)
        {
            int summe = 0;
            int z;
            LblAnzeige1.Text = "";

            while(summe<20)
            {
                z = r.Next(1, 7);
                summe = summe + z;
                LblAnzeige1.Text += summe + "\n";
            }
        }


        private void CmdDoWhile_Click(object sender, EventArgs e)
        {
            int summe = 0;
            int z;
            LblAnzeige1.Text = "";

            do
            {
                z = r.Next(1, 7);
                summe = summe + z;
                LblAnzeige1.Text += summe + "\n";
            }
            while (summe < 20);
        }
    }
}
