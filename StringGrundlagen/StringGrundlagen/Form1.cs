using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringGrundlagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }


        private void CmdLaenge_Click(object sender, EventArgs e)
        {
            string eingabe;
            string anzeige;

            eingabe = TxtEingabe.Text;

            anzeige = "Länge: " + eingabe.Length;
            LblAnzeige.Text = anzeige;

            //LblAnzeige.Text = "Länge:" + LblAnzeige.Text.Length; //alternative schreibweise;
        }


        private void CmdZeichen_Click(object sender, EventArgs e)
        {
            string eingabe;
            string anzeige;
            char zeichen;
            eingabe = TxtEingabe.Text;

            anzeige = "Zeichen: " + "\n";
            for(int i=0; i<eingabe.Length;i++)
            {
                zeichen = eingabe[i];
                anzeige += i + ": " + zeichen +"\n";
            }
            LblAnzeige.Text = anzeige;
        }


        private void CmdTrimmen_Click(object sender, EventArgs e)
        {
            string eingabe;
            string anzeige;
            string getrimmt;

            eingabe = TxtEingabe.Text;
            getrimmt = eingabe.Trim(' ', ';', '#');

            anzeige = "Getrimmt: |" + getrimmt + "|";
            LblAnzeige.Text = anzeige;
        }


        private void CmdSplitten_Click(object sender, EventArgs e)
        {
            string eingabe = TxtEingabe.Text;
            string[] teil;

            teil = eingabe.Split(';');
            LblAnzeige.Text = "Worte:" + "\n";
            for(int i=0; i < teil.Length; i++)
            {
                LblAnzeige.Text += "Wort " + i + ":" + teil[i] + "\n";
            }
        }


        private void CmdSucheEins_Click(object sender, EventArgs e)
        {
            string eingabe;
            string such;
            string anzeige;
            int position;

            eingabe = TxtEingabe.Text;
            such = TxtSuche.Text;
            position = eingabe.IndexOf(such);

            anzeige = "Suchtext bei Zeichen: " + position;
            if (position == -1) anzeige = "Gibt's nich!";
            LblAnzeige.Text = anzeige;

            //alternative Schreibweise; 
            /*LblAnzeige.Text = "Suchtext bei Zeichen: " + TxtEingabe.Text.IndexOf(TxtSuche.Text);*/
        }


        private void CmdSucheAlle_Click(object sender, EventArgs e)
        {
            string eingabe;
            string such;
            string anzeige;
            int position;
            int suchstart = 0;
            int anzahl = 0;

            eingabe = TxtEingabe.Text;
            such = TxtSuche.Text;
            if (eingabe == "" || such == "") return;

            anzeige = "Suchtext bei Zeichen:" + "\n";
            do
            {
                position = eingabe.IndexOf(such, suchstart);
                suchstart = position + 1;

                if(position !=-1)
                {
                    anzeige += position + "\n";
                    anzahl++;
                }

            } while (position != -1);

            anzeige += "Anzahl: " + anzahl;
            LblAnzeige.Text = anzeige;
        }
    }
}
