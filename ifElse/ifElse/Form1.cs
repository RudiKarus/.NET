using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;
            LblAnzeige.Text = "";

            if(x > 0)
            {
                LblAnzeige.Text = "X ist grösser als 0";
                NumX.BackColor = Color.LightGreen;
            }
        }


        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;
            //LblAnzeige.Text = "";

            if(x > 0)
            {
                LblAnzeige.Text = "X ist grösser als 0";
                NumX.BackColor = Color.LightGreen;
            }
            else
            {
                    LblAnzeige.Text = "X ist kleiner oder gleich 0";
            }   
        }


        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;

            //der ternäre Operator "?" stellt eine alternative, verkürzte Schreibweise für eine if-else Verzweigung dar;S
            LblAnzeige.Text = x > 0 ? "x > 0" : "x <= 0";
            NumX.BackColor = x > 0 ? Color.LightGreen : Color.Gray;
        }


        private void CmdAnzeige4_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;

            if (x > 0)
            {
                LblAnzeige.Text = "X ist grösser als 0";
                NumX.BackColor = Color.LightGreen;
            }
            else
            {
                if (x < 0)
                {
                    LblAnzeige.Text = "X ist kleiner als 0";
                    NumX.BackColor = Color.LightBlue;
                }
                else
                {
                    LblAnzeige.Text = "X ist 0";
                    NumX.BackColor = Color.Gray;
                }
            }
        }


        private void CmdAnzeige5_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;
            int y = (int)NumY.Value;
            NumX.BackColor = Color.White;
            NumY.BackColor = Color.White;

            if (x>0 && y>0)
            {
                LblAnzeige.Text = "X und Y sind größer als 0";
            }
            else
            {
                LblAnzeige.Text = "Mindestens eine der beiden Zahlen" + "\n" + "ist nicht gößer als 0";
            }
        }

        private void CmdAnzeige6_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;
            int y = (int)NumY.Value;
            NumX.BackColor = Color.White;
            NumY.BackColor = Color.White;

            if(x>0 || y>0)
            {
                LblAnzeige.Text = "Eine der beiden Zahlen," + "\n" + "oder beide Zahlen sind größer als 0";
            }
            else
            {
                LblAnzeige.Text = "Keine der beiden Zahlen ist größer als 0";
            }
        }

        private void CmdAnzeige7_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;
            int y = (int)NumY.Value;
            NumX.BackColor = Color.White;
            NumY.BackColor = Color.White;
            LblAnzeige.Text = "";

            if(x>0 ^ y>0)
            {
                LblAnzeige.Text = "Nur X oder nur Y sind größer als 0";
            }
        }
    }
}
