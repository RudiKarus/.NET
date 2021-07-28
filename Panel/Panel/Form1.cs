using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.YellowGreen;
            //panel1.BackColor = Color.FromArgb(255, 200, 0);
        }

        private void CmdNachOben_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 10);
        }

        private void CmdNachLinks_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X - 10, panel1.Location.Y);
        }

        private void CmdNachRechts_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X + 10, panel1.Location.Y);
        }

        private void CmdNachUnten_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X, panel1.Location.Y +10);
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void CmdStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblAnzeige.Text += "x";
        }
    }
}
