using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfeldMehrdimensional
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";   
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            int[,] a;
            a = new int[7, 3];

            LstSpalte0.Items.Clear();
            LstSpalte1.Items.Clear();
            LstSpalte2.Items.Clear();

            for (int i=0; i<=a.GetUpperBound(0); i++)
            {
                for(int k=0; k<=a.GetUpperBound(1); k++)
                {
                    a[i, k] = r.Next(20, 31);
                }
                LstSpalte0.Items.Add(a[i, 0]);
                LstSpalte1.Items.Add(a[i, 1]);
                LstSpalte2.Items.Add(a[i, 2]);
            }

        }

        private void LstSpalte_Click(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox; //der Verweis auf das sendende Objekt wird in einen Verweis auf eine ListBox umgewandelt, dadurch erhält man Zugriff auf die Eigenschaft "SelectedIndex";

            int x;
            if (lst == LstSpalte0)
                x = 0;
            else if (lst == LstSpalte1)
                x = 1;
            else
                x = 2;

            LblAnzeige.Text = "Indizes: " + lst.SelectedIndex + ", " + x;
        }
    }
}
