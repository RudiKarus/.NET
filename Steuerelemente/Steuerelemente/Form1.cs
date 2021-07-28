using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steuerelemente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CmdGroesseAbs_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(50, 100);
        }

        private void CmdGroesseRel_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(CmdTest.Size.Width + 20, CmdTest.Size.Height);
        }

        private void CmdPostionAbs_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(100, 200);
        }

        private void CmdPositionRel_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(CmdTest.Location.X + 20, CmdTest.Location.Y);
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Größe: Breite = " + CmdTest.Size.Width + ";" + " Höhe = " + CmdTest.Size.Height + ";" + "\n"
                + "Position: X = " + CmdTest.Location.X + ";" + " Y = " + CmdTest.Location.Y + ";" + "\n";
        }

        private void CmdFarbe_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black; //ändert die BackColor des ganzen Fensters;
            LblAnzeige.BackColor = Color.FromArgb(0,220,255); //ändert die BackColor des Anzeigebereichs;
        }
    }
}
