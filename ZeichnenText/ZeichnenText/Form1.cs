using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeichnenText
{
    public partial class Form1 : Form
    {
        private Graphics z;
        private Font f = new Font("Arial", 16);
        private SolidBrush pinsel = new SolidBrush(Color.Gray);
        private Color[] colorField = { Color.Cyan, Color.Magenta, Color.Yellow, Color.Black };


        public Form1()
        {
            InitializeComponent();

            z = CreateGraphics();
            LstSchriftart.Items.Add("Arial");
            LstSchriftart.Items.Add("Courier New");
            LstSchriftart.Items.Add("Symbol");
            LstSchriftart.SelectedIndex = 0;

            LstFarbe.Items.Add("Cyan");
            LstFarbe.Items.Add("Magenta");
            LstFarbe.Items.Add("Yellow");
            LstFarbe.Items.Add("Black");
            LstFarbe.SelectedIndex = 3;
        }


        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            z.DrawString(TxtEingabe.Text, f, pinsel, 20, 20);
        }


        private void LstSchriftart_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = new Font(LstSchriftart.Text, f.Size);
        }


        private void NumSchriftgroesse_ValueChanged(object sender, EventArgs e)
        {
            f = new Font(f.FontFamily, (float)NumSchriftgroesse.Value);
        }


        private void LstFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            pinsel.Color = colorField[LstFarbe.SelectedIndex];
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            z.Clear(BackColor);
        }
    }
}
