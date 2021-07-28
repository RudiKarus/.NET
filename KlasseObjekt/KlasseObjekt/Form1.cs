using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasseObjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa; //vespa ist ein Objekt der Klasse Fahrzeug;
            vespa = new Fahrzeug(); //erzeugt ein neues Objekt der Klasse Fahrzeug dass über "vespa" erreicht werden kann; oder, instanziieren einer Klasse

            LblAnzeige.Text = vespa.Ausgabe();
            vespa.Beschleunigen(20);
            LblAnzeige.Text += "\n" + vespa.Ausgabe();
        }
    }
}
