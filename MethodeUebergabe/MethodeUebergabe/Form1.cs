using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodeUebergabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }


        private void CmdKopie_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            x = 5;
            y = 12;

            LblAnzeige.Text = "Vorher: x: " + x + ", y: " + y;
            TauschKopie(x, y);
            LblAnzeige.Text += "\nNachher: x: " + x + ", y:" + y;
        }


        private void CmdReferenz_Click(object sender, EventArgs e)
        {
            int x, y;
            x = 5;
            y = 12;

            LblAnzeige.Text = "Vorher: x: " + x + ", y: " + y;
            TauscheReferenz(ref x, ref y);
            LblAnzeige.Text += "\nNachher: x: " + x + ", y: " + y;
        }


        void TauschKopie(int a, int b) //hier werden die Werte mit dem "Ringtausch" vertauscht, bleiben aber in dieser Methode "hängen";
        {
            int c;
            c = a;
            a = b;
            b = c;
        }


        void TauscheReferenz(ref int a, ref int b) //hier werden die Werte ebenfalls mit dem "Ringtausch" vertauscht und hat Auswirkung auf die Originalvariable;
        {
            int c;
            c = a;
            a = b;
            b = c;
        }


        private void CmdEindimFeld_Click(object sender, EventArgs e)
        {
            int[] p = { 6, 7, 2 };

            Verdoppeln(p);
            LblAnzeige.Text = "";
            foreach (int z in p)
                LblAnzeige.Text += z + ", ";
        }


        void Verdoppeln(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
                x[i] = x[i] * 2;
        }


        private void CmdDreidimFeld_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double[,,] x = new double[2, 5, 3];

            for (int i = 0; i <= x.GetUpperBound(0); i++)   //GetUpperBound liefert die Anzahl der Elemente aus einer (Index)Dimension. Length liefert die Anzahl der Elemente aus ALLEN Dimensionen
                for (int j = 0; j <= x.GetUpperBound(1); j++)
                    for (int k = 0; k <= x.GetUpperBound(2); k++)
                        x[i, j, k] = r.NextDouble();

            MittelWert(x);
        }


        void MittelWert(double[,,] z)
        {
            double summe = 0;
            for (int i = 0; i < z.GetUpperBound(0); i++)
                for (int j = 0; j < z.GetUpperBound(1); j++)
                    for (int k = 0; k < z.GetUpperBound(2); k++)
                        summe += z[i, j, k];
            LblAnzeige.Text = "Mittelwert: " + summe / z.Length; //geteilt durch die Anzahl ALLER Elemente aus dem ...Feld z;
        }


        private void CmdOut_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 12;
            b = 3;

            Addieren(a, b, out c);
            LblAnzeige.Text = "Ergebnis: " + c;
        }


        void Addieren(int x, int y, out int z)
        {
            z = x + y;
        }
    }
}
