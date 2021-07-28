using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSteuerelemente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPositionRel_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(
                CmdTest.Location.X + 20, CmdTest.Location.Y);
        }

        private void CmdPositionAbs_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(100, 100);
        }

        private void CmdSizeRel_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(
                CmdTest.Size.Width +20, CmdTest.Size.Height);
        }

        private void CmdSizeAbs_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(100, 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CmdColor_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            LblAnzeige.BackColor = Color.Violet;
        }

        private void CmdAnzeige_Click_1(object sender, EventArgs e)
        {
            LblAnzeige.Text =
               "Position X: " + CmdTest.Location.X + "\n"
               + "Position Y: " + CmdTest.Location.Y + "\n"
               + "Size X: " + CmdTest.Size.Width + "\n"
               + "Size Y: " + CmdTest.Size.Height + "\n";
        }
    }
}
