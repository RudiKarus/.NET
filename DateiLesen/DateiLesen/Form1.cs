﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DateiLesen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }

        private void CmdLesen_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ein.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string zeile;

            while(sr.Peek() != -1)
            {
                zeile = sr.ReadLine();
                LblAnzeige.Text += zeile + "\n";
            }
            sr.Close();
        }
    }
}
