using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fehlerbehandlung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeigen.Text = "";
            LblAusgabe.Text = "";
            LblErgebnis1.Text = "";
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {/*
            int i;
            if (TxtEingabe1.Text = "")
                return;

            i = Convert.ToInt32(TxtEingabe1.Text);

            if (i > 0)
                LblAnzeigen.Text = "Positiv";
            else if (i < 0)
                LblAnzeigen.Text = "Negativ";
            else
                LblAnzeigen.Text = "gleich 0";
        */}

        private void CmdRechnen_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = "";
            try
            {
                int x = Convert.ToInt32(TxtEingabe1.Text);
                int y = Convert.ToInt32(TxtEingabe2.Text);
                int z = x / y;
                LblErgebnis1.Text = "Ergebnis: " + z;
            }
            catch(FormatException ex)
            {
                LblAusgabe.Text = "Fehler: Falsches Eingabeformat/ " + "\n" + ex;
            }
            catch(DivideByZeroException ex)
            {
                LblAusgabe.Text = "Fehler: Division durch 0/ " + "\n" + ex;
            }
            catch (Exception ex)
            {
                //LblAusgabe.Text = "Fehler: " + ex.Message;
                LblAusgabe.Text = "Fehler: allgemein/ " + "\n" + ex;
            }
        }
    }
}
