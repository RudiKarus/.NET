using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfeldVerzweigt
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
            double[][] a = new double[5][]; //dem Hauptfeld mit Unterfeldern werden 5 Unterfelder im ersten Hauptfeld zugewiesen
            int anz = 0;
            //es folgt die Zuweisung der Elemente im Unterfeld
            a[0] = new double[2];
            a[1] = new double[4];
            a[2] = new double[2];
            a[3] = new double[3];
            a[4] = new double[1];

            for (int i = 0; i < a.Length; i++) //die "Length" der Elemente des Hauptfeldes a;
            {
                for (int k = 0; k < a[i].Length; k++) // die "Length" der Elemente der Unterfelder des Hauptfeldes a;
                {
                    a[i][k] = Math.Round(r.NextDouble(), 3);
                    LblAnzeige.Text += a[i][k] + " ";
                }
                anz += a[i].Length;
                LblAnzeige.Text += "\n";
            }
            LblAnzeige.Text += "Anzahl: " + anz;
        }
    }
}
