using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodenRueckgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 12;
            b = 17;
            c = MaxWert(a, b);
            LblAnzeige.Text = "Maximun: " + c;
        }

        private int MaxWert(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
    }
}
