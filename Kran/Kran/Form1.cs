using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kran
{
    public partial class Form1 : Form
    {
        int xMax = 305;
        int xMin = 230;
        int yMax = 125;
        int yMin = 25;

        //int xEingabe;
        //int yEingabe;


        public Form1()
        {
            InitializeComponent();
            
            Haken.Size = new Size(Haken.Size.Width, yMin); 
            Haken.Location = new Point((xMax - xMin) / 2 + xMin, Haken.Location.Y);
        }


        //MANUELLE STEUERUNG

        private void ManuelleSteuerung(object sender, EventArgs e)
        {
  
        }

        private void CmdLinks_Click(object sender, EventArgs e)
        {
            if (Haken.Location.X > xMin)
            {
                Haken.Location = new Point(Haken.Location.X - 3, Haken.Location.Y);
            }
            else Haken.Location = new Point(xMin, Haken.Location.Y);
        }

        private void CmdRechts_Click(object sender, EventArgs e)
        {
            if (Haken.Location.X < xMax)
            {
                Haken.Location = new Point(Haken.Location.X + 3, Haken.Location.Y);
            }
            else Haken.Location = new Point(xMax, Haken.Location.Y);
        }

        private void CmdHoch_Click(object sender, EventArgs e)
        {
            Haken.Size = new Size(Haken.Size.Width, Haken.Size.Height - 2);
        }

        private void CmdRunter_Click(object sender, EventArgs e)
        {
            Haken.Size = new Size(Haken.Size.Width, Haken.Size.Height + 2);
        }


        //AUTOMATISCHE STEUERUNG

        // Option auswählen
        private void Hochfahren(object sender, EventArgs e)
        {

        }
        
        private void OptHoch_CheckedChanged(object sender, EventArgs e) 
        {
            timer1.Enabled = false;
        }

        private void OptRunter_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void OptLinks_CheckedChanged(object sender, EventArgs e) 
        {
            timer2.Enabled = false;
        }

        private void OptRechts_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        // Vertikale Bewegung
        private void timer1_Tick(object sender, EventArgs e) 
        {
            if (OptHoch.Checked == true)
            {
                if (Haken.Size.Height > yMin)
                {
                    Haken.Size = new Size(Haken.Size.Width, Haken.Size.Height - 1);
                }
                else
                {
                    Haken.Size = new Size(Haken.Size.Width, yMin);
                    timer2.Enabled = false;
                }
            }
            else if (OptRunter.Checked == true)
            {
                if (Haken.Size.Height < yMax)
                {
                    Haken.Size = new Size(Haken.Size.Width, Haken.Size.Height + 1);
                }
                else
                {
                    Haken.Size = new Size(Haken.Size.Width, yMax);
                    timer2.Enabled = false;
                }
            }
        }

        // Horizontale Bewegung
        private void timer2_Tick(object sender, EventArgs e) 
        {
            if (OptLinks.Checked == true)
            {
                if (Haken.Location.X > xMin)
                {
                    Haken.Location = new Point(Haken.Location.X - 3, Haken.Location.Y);
                }
                else
                {
                    Haken.Location = new Point(xMin, Haken.Location.Y);
                    timer1.Enabled = false;
                }
            }
            else if (OptRechts.Checked == true)
            {
                if (Haken.Location.X < xMax)
                {
                    Haken.Location = new Point(Haken.Location.X + 3, Haken.Location.Y);
                }
                else
                {
                    Haken.Location = new Point(xMax, Haken.Location.Y);
                    timer1.Enabled = false;
                }
            }
            
        }

        // Trigger
        private void button1_Click(object sender, EventArgs e) //STOP
        {
            timer1.Enabled = false; //Horizontal
            timer2.Enabled = false; //Vertikal
        }

        private void button2_Click(object sender, EventArgs e) //START
        {
            timer1.Enabled = true; //Horizontal
            timer2.Enabled = true; //Vertikal
        }   
    }
}