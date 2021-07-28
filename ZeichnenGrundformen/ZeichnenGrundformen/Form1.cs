using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeichnenGrundformen
{
    public partial class Form1 : Form
    {
        private Graphics z;
        private Pen stift = new Pen(Color.Black, 2);
        private SolidBrush pinsel = new SolidBrush(Color.DimGray);
        private Color[] colorFeld = { Color.Cyan, Color.Magenta, Color.Yellow };


        public Form1()
        {
            InitializeComponent();

            z = CreateGraphics();
            LstColor.Items.Add("Cyan");
            LstColor.Items.Add("Magenta");
            LstColor.Items.Add("Yellow");
            LstColor.SelectedIndex = 0;
        }


        private void CmdLinie_Click(object sender, EventArgs e)
        {
            z.DrawLine(stift, 100, 40, 100, 60);

            ChkFuellen.Checked = false;
        }


        private void CmdRechteck_Click(object sender, EventArgs e)
        {
            if(ChkFuellen.Checked)
            {
                z.FillRectangle(pinsel, 10, 10, 180, 180);
                ChkFuellen.Checked = false;
            }
            else
            z.DrawRectangle(stift, 10, 10, 180, 180);
        }


        private void CmdPolygon_Click(object sender, EventArgs e)
        {
            Point[] pointFeld = { new Point(90, 80), new Point(110, 80), new Point(100, 120) };

            if(ChkFuellen.Checked)
            {
                z.FillPolygon(pinsel, pointFeld);
                ChkFuellen.Checked = false;
            }
            else
            z.DrawPolygon(stift, pointFeld);
        }


        private void CmdEllipse_Click(object sender, EventArgs e)
        {
            if(ChkFuellen.Checked)
            {
                z.FillEllipse(pinsel, 10, 10, 180, 180);
                ChkFuellen.Checked = false;
            }
            else
            z.DrawEllipse(stift, 10, 10, 180, 180);
        }


        private void NumPenWidth_ValueChanged(object sender, EventArgs e)
        {
            stift.Width = (float)NumPenWidth.Value;
        }


        private void LstColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            stift.Color = colorFeld[LstColor.SelectedIndex];
            pinsel.Color = colorFeld[LstColor.SelectedIndex];
        }


        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            z.Clear(BackColor);
        }
    }       
}
