using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gueltigkeitsbereich
{
    public partial class Form1 : Form
    {
        float x = 0.0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            float z = 0.0f;

            x += 0.1f;
            z += 0.1f;
            LblAnzeige.Text = "X: " + x + "\n" + "Z: " + z;
        }

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            float y = 0.0f; ;

            x += 0.1f;
            y += 0.1f;
            LblAnzeige.Text = "X: " + x + "\n" + "Y: " + y;
        }
    }
}
