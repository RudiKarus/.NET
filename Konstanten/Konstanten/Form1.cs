﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konstanten
{
    public partial class KonstantenEnumeration : Form
    { 
        private const int MaxWert = 75;
        private const string Eintrag = "Picture";
        private enum Farbe : int
        {
            Rot=1, Gelb=2, Blau=3
        }

        public KonstantenEnumeration()
        {
            InitializeComponent();
        }

        private void CmdKonstanten_Click(object sender, EventArgs e)
        {
            const int MaxWert = 55;
            const int MinWert = 5;
            LblAnzeige.Text = (MaxWert - MinWert) / 2 + "\n" + Eintrag;
        }

        private void CmdEnumeration1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Farbe: " + (int)Farbe.Gelb + " = " + Farbe.Rot;  
        }

        private void CmdEnumeration2_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = DayOfWeek.Sunday + " = " + (int)DayOfWeek.Sunday + "\n"
                + DayOfWeek.Monday + " = " + (int)DayOfWeek.Monday;
        }
    }
}
