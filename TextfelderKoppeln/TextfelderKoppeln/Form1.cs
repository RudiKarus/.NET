using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextfelderKoppeln
{
    public partial class Form1 : Form
    {
        bool Kopplung;


        public Form1()
        {
            InitializeComponent();

            LblAnzeige1.Text = "";
            LblAnzeige2.Text = "";
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Focus(); //Cursor in der ersten Textbox;
            textBox1.SelectAll(); //gesamter Text selektiert;
            Kopplung = true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Kopplung)
                textBox2.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Kopplung = false;
        }
    }
}
