using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeinErstes_Exercise
{
    public partial class MeinErstes : Form
    {
        public MeinErstes()
        {
            InitializeComponent();
        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            LblText.Text = "Rudi";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnName2_Click(object sender, EventArgs e)
        {
            LblText2.Text = "Kraus";
        }

    }
}
