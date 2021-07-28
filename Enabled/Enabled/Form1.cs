using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enabled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LstBox1.Items.Add("Liechtenstein");
            LstBox1.Items.Add("Malta");
            LstBox1.Items.Add("Andorra");
            LstBox1.Items.Add("San Marino");
            LstBox1.Items.Add("Monaco");

            CmdLoeschen.Enabled = false;
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            int x = LstBox1.SelectedIndex;
            for(int i = LstBox1.SelectedItems.Count; i>0; i--) //die Variable i nimmt die Anzahl der gezählten (count) Elemente auf und wendet darauf die for-Schleife an;
            LstBox1.Items.RemoveAt(x);

            if (LstBox1.Items.Count == 0)   //Deaktivierung der Schaltfläche bei 0 Elementen in der Liste
                CmdLoeschen.Enabled = false;
        }

        private void LstBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void LstBox1_Click(object sender, EventArgs e)
        {
            CmdLoeschen.Enabled = true;
        }
    }
}
