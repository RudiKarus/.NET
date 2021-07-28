using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TastaturMaus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblEingabe.Text = "";
            LblMouse.Text = "";
        }

        private void TxtEingabe_KeyDown(object sender, KeyEventArgs e)
        {
            LblEingabe.Text = "KeyDown, Code:" + e.KeyCode + ", Value" + e.KeyValue + ", Alt: " + e.Alt + ", Control:" + e.Control + ", Shift" + e.Shift;

            if(e.KeyCode == Keys.Return)
            {
                LblEingabe.Text = "Return /EingabeTaste";
            }
            else if(e.KeyCode == Keys.Delete)
            {
                LblEingabe.Text = "Delete";
            }
        }

        private void PanMouse_MouseDown(object sender, MouseEventArgs e)
        {
            LblMouse.Text = "MouseDown, X:" + e.X + ", Y:" + e.Y + ", Button" + e.Button + ", Clicks:" + e.Clicks; //Click 1= einfachKlick, Click 2= doppelKlick
        }
    }
}
