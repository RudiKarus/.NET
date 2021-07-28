using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfelderEindimensional
{
    public partial class Form1 : Form
    {
        Random r = new Random();


        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }


        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int[] a = new int[7];
            LstFeld.Items.Clear();

            for (int i = 0; i < 7; i++)
            {
                a[i] = r.Next(20, 31);
                LstFeld.Items.Add(a[i]);
            }
        }


        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int[] a = new int[7];
            LstFeld.Items.Clear();
            int MinWert, MaxWert, MinWertIndex, MaxWertIndex;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                LstFeld.Items.Add(a[i]);
            }

            //Min- und MaxWert initialisieren
            MinWert = a[0];
            MaxWert = a[0];
            MinWertIndex = 0;
            MaxWertIndex = 0;

            //Min- und MaxWert suchen
            for(int i = 1; i < a.Length; i++)
            {
                if (a[i] > MaxWert)
                {
                    MaxWert = a[i];
                    MaxWertIndex = i;
                }

                if(a[i] < MinWert)
                {
                    MinWert = a[i];
                    MinWertIndex = i;
                }
            }

            LblAnzeige.Text = "Max.Wert: " + MaxWert + " bei Index " + MaxWertIndex + "\n" +
                " Min.Wert: " + MinWert + " bei Index " + MinWertIndex;
        }


        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int[] a = new int[7], b = new int[7];
            int SuchIndex;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
            }

            b = (int[])a.Clone(); //der Cast "(int[])" verwandelt den ursprünglichen Verweis auf ein "Object" in einen Verweis auf das eindimensionale Datenfeld-Object;
            Array.Sort(b); //die Methode "Sort()" der Klasse "Array" wird zur aufsteigenden Sortierung des Felds b genutzt;

            LstFeld.Items.Clear();
            for(int i=0; i<a.Length; i++)
            {
                LstFeld.Items.Add(b[i]);
            }

            SuchIndex = Array.IndexOf(b, 25); //gesucht wird der Index des Wertes "25" im eindimensionalen Feld b;
            LblAnzeige.Text = "Gesuchter Wert 25 bei Index: " + SuchIndex;
        }

    }
}
