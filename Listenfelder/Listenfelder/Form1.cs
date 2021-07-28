using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listenfelder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstBox1.Items.Add("Malta");
            LstBox1.Items.Add("Zypern");
            LstBox1.Items.Add("Slowenien");
            LstBox1.Items.Add("Estland");
            LstBox1.Items.Add("Rumänien");

            LstBox2.Items.Add("Malta");
            LstBox2.Items.Add("Zypern");
            LstBox2.Items.Add("Slowenien");
            LstBox2.Items.Add("Estland");
            LstBox2.Items.Add("Rumänien");
        }

        private void CmdToRight_Click(object sender, EventArgs e)
        {

            foreach(string s in LstBox1.SelectedItems)
            {
                LstBox2.Items.Add(s);
            }
            for (int x = LstBox1.SelectedItems.Count-1; x >= 0; x--)
            {
                LstBox1.Items.RemoveAt(LstBox1.SelectedIndices[x]);
            }

        }

        private void CmdToLeft_Click(object sender, EventArgs e)
        {
            foreach(string s in LstBox2.SelectedItems)
            {
                LstBox1.Items.Add(s);
            }
            for (int x = LstBox2.SelectedItems.Count-1; x >= 0; x--)
            {
                LstBox2.Items.RemoveAt(LstBox2.SelectedIndices[x]);
            }

        }
    }
}
