using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumUhrzeitRechnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime(2017, 7, 18, 16, 35, 12);
            TimeSpan ts1 = new TimeSpan(2, 10, 5);
            TimeSpan ts2 = new TimeSpan(3, 4, 70, 10);

            LstAnzeige.Items.Add("Start: " + d);
            d = d.AddHours(3);
            LstAnzeige.Items.Add("+3: " + d);
            d = d.AddHours(-2.5);
            LstAnzeige.Items.Add("-2,5 Std: " + d);
            d = d.AddHours(34);
            LstAnzeige.Items.Add("+34 Std: " + d);
            d = d.AddSeconds(90);
            LstAnzeige.Items.Add("+90 sek:" + d);
            d = d.Add(ts1);
            LstAnzeige.Items.Add("+2Std 10Min 5Sek:" + d);
            d = d.Subtract(ts2);
            LstAnzeige.Items.Add("-3Tage 4Std 70Min 10Sek: " + d);
                
        }
    }
}
