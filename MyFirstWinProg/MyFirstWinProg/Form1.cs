using System;
using System.Windows.Forms;

namespace MyFirstWinProg
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

        private void LblAnzeige_Click(object sender, EventArgs e)
        {

        }

        private void CmdHello_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Hello";
        }

        private void CmdEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
