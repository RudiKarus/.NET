using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelÜbung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255,100,0);
            panel2.BackColor = Color.FromArgb(100,255,0);
            panel3.BackColor = Color.FromArgb(0,255,200);
            panel4.BackColor = Color.FromArgb(0,100,255);
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X - 5, panel1.Location.Y - 5);
            panel2.Location = new Point(panel2.Location.X + 5, panel2.Location.Y - 5);
            panel3.Location = new Point(panel3.Location.X - 5, panel3.Location.Y + 5);
            panel4.Location = new Point(panel4.Location.X + 5, panel4.Location.Y + 5);
        }
    }
}
