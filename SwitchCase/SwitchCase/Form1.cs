using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class SwitchCase : Form
    {
        public SwitchCase()
        {
            InitializeComponent();

            LblAnweisung1.Text = "Geben Sie eine Zahl ein...";
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            if (x == 0)
            { 
                    LblAnzeige1.Text = "Bitte eine andere Zahl als 0 eingeben...";
            }
            else
            {
                int y = x % 2;
                if (y == 0)
                {
                    y = 2;
                }
                else
                {
                    y = 1;
                }

                switch (y)
                {
                    case 1:
                        LblAnzeige1.Text = "Die eingegebene Zahl ist ungerade.";
                        break;
                    case 2:
                        LblAnzeige1.Text = "Die eingegebene Zahl ist gerade.";
                        break; //anstelle von "break" kann hier auch die Anweisung "goto case ... :" verwendet werden;
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
