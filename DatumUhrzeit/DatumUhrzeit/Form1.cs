using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumUhrzeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(2017, 7, 18, 16, 35, 12);
            DateTime d2 = new DateTime(2017, 8, 23);
            DateTime d3, d4 = new DateTime();

            listBox1.Items.Add("d1: " + d1);
            listBox1.Items.Add("d2: " + d2.ToShortDateString()); //"ToShortDsteString" kürzt die Zeitangabe aufs Datum, ohne Uhrzeit;
            d3 = DateTime.Now;
            d4 = DateTime.Today;

            listBox1.Items.Add("d3: " + d3);
            listBox1.Items.Add("d4: " + d4.ToShortDateString());
            listBox1.Items.Add("Tag der Woche: " + d1.DayOfWeek);

            if (d1.DayOfWeek == DayOfWeek.Sunday) listBox1.Items.Add("Sonntag");
            else listBox1.Items.Add("Kein Sonntag");

            listBox1.Items.Add("Tag des Jahres: " + d1.DayOfYear);
            listBox1.Items.Add("Datum: "+d1.Date);
            listBox1.Items.Add("Uhrzeit: "+d1.TimeOfDay);
        }
    }
}
