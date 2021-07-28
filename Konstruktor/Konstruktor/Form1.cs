using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konstruktor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug();
            Fahrzeug schwalbe = new Fahrzeug("Moped"); //das Objekt schwalbe erhält bei der erzeugung den Wert "Moped";
            Fahrzeug yamaha = new Fahrzeug(50);
            Fahrzeug honda = new Fahrzeug("Motorrad", 75);

            LblAnzeige.Text = vespa +"\n"+ schwalbe + "\n" + yamaha + "\n" + honda;
        }
    }
}
