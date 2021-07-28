using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schieberegler
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


        private void TrkRot_Scroll(object sender, EventArgs e)
        {

        }

        private void TrkGruen_Scroll(object sender, EventArgs e)
        {

        }

        private void TrkBlue_Scroll(object sender, EventArgs e)
        {

        }

        private void Schieberegler(object sender, EventArgs e)
        {
            PanFarbe.BackColor = Color.FromArgb(TrkRot.Value, TrkGruen.Value, TrkBlue.Value);
            LblRotWert.Text = "" + TrkRot.Value;
            LblGruenWert.Text = "" + TrkGruen.Value;
            LblBlauWert.Text = "" + TrkBlue.Value;
        }
    }
}
