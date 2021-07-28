using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathematik
{
    public partial class Form1 : Form
    {

        private double x;


        public Form1()
        {
            InitializeComponent();
        }


        private void T_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(T.Text);
            }
            catch
            {
                T.Text= "";
                x = 0;
            }
        }


        private void CmdBackSpace_Click(object sender, EventArgs e)
        {
            T.Text = T.Text.Substring(0, T.Text.Length - 1);
        }


        private void CmdClear_Click(object sender, EventArgs e)
        {
            T.Text = "";
        }


        private void CmdSinus_Click(object sender, EventArgs e)
        {
            if(ChkInv.Checked)
            {
                T.Text = "" + Math.Asin(x) * 180 / Math.PI;
                ChkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Sin (x/ 180.0 * Math.PI);
        }


        private void CmdCosinus_Click(object sender, EventArgs e)
        {
            if (ChkInv.Checked)
            {
                T.Text = "" + Math.Acos(x) * 180 / Math.PI;
            }
            else
                T.Text = "" + Math.Cos(x / 180.0 * Math.PI);
        }


        private void CmdTangens_Click(object sender, EventArgs e)
        {
            if (ChkInv.Checked)
            {
                T.Text = "" + Math.Atan(x) * 180 / Math.PI;
                ChkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Tan(x / 180.0 * Math.PI);
        }


        private void CmdLn_Click(object sender, EventArgs e)
        {
            if (ChkInv.Checked)
            {
                T.Text = "" + Math.Exp(x);
                ChkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Log(x);
        }

        private void CmdLog_Click(object sender, EventArgs e)
        {
            if (ChkInv.Checked)
            {
                T.Text = "" + Math.Pow(10.0, x);
                ChkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Log(10.0, x);
        }


        private void CmdPi_Click(object sender, EventArgs e)
        {
            T.Text = "" + Math.PI;
        }


        private void CmdE_Click(object sender, EventArgs e)
        {
            T.Text = "" + Math.E;
        }


        private void CmdCeiling_Click(object sender, EventArgs e)
        {
            T.Text = "" + Math.Ceiling(x);
        }


        private void CmdFloor_Click(object sender, EventArgs e)
        {
            T.Text = "" + Math.Floor(x);
        }


        private void CmdRound_Click(object sender, EventArgs e)
        {
            T.Text = "" + Math.Floor(x);
        }


        private void CmdTruncate_Click(object sender, EventArgs e)
        {
            T.Text = "" + Math.Truncate(x);
        }


        private void CmdWurzel_Click(object sender, EventArgs e)
        {
            if (ChkInv.Checked)
            {
                T.Text = "" + Math.Pow(x, 2.0);
                ChkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Sqrt(x);
        }


        private void CmdPlusMinus_Click(object sender, EventArgs e)
        {
            T.Text = "" + x * -1.0;
        }


        private void CmdKehrwert_Click(object sender, EventArgs e)
        {
            T.Text = "" + 1 / x;
        }


        private void CmdZiffer_Click(object sender, EventArgs e)
        {
            Button b = sender as Button; //"sender" ist ein Objekt vom Typ "object" und muss in einen "button" umgewandelt werden;
            T.Text += b.Text;
        }


        private void CmdKomma_Click(object sender, EventArgs e)
        {
            if (T.Text.IndexOf(",") < 0) //ein Komma wird nur eingefügt wenn es noch keins gibt;
                T.Text += ",";
        }
    }
}
