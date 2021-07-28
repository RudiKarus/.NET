using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenzenVergleicheTypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }


        private void CmdReferenzZuweisen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug();
            Fahrzeug schwalbe;

            schwalbe = vespa;

            MessageBox.Show(vespa + " / " + schwalbe);
            vespa.Beschleunigen(35);
            MessageBox.Show(vespa + " / " + schwalbe);
        }


        private void CmdReferenzVergleichen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);
            Fahrzeug schwalbe = new Fahrzeug("Roller", 35);

            if(vespa==schwalbe)
            {
                MessageBox.Show("Die beiden Objektverweise " + "zeigen auf das selbe Objekt");
            }
            else
            {
                MessageBox.Show("Die beiden Objektverweise " + "zeigen nicht auf das selbe Objekt");
            }
        }


        private void CmdObjekteVergleichen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);
            Fahrzeug schwalbe = new Fahrzeug("Roller", 35);

            if (vespa.Equals(schwalbe))
                MessageBox.Show("Die beiden Objekte sind gleich");
            else
                MessageBox.Show("Die beiden Objekte sind nicht gleich");
        }


        private void CmdKlasseErmitteln_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);

            MessageBox.Show("Die Klasse ist vom Typ " + vespa.GetType().ToString()); //die Methode "GetType()" der Basisklasse "object" wird mit hilfe der Methode "ToString()" ausgegeben;
            MessageBox.Show("Die Klasse heißt " + typeof(Fahrzeug));

            vespa = null;
            if (vespa == null)
                MessageBox.Show("Verweis vespa zeigt auf kein Objekt");

            MessageBox.Show("Der Button ist vom Typ " + CmdKlasseErmitteln.GetType().ToString());
            MessageBox.Show("Die Klasse heißt " + typeof(Button));
        }
        

        private void CmdKlasseVergleichen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);

            if (vespa is Fahrzeug)
                MessageBox.Show("Objekt vespa ist vom Typ Fahrzeug");
            if (CmdKlasseErmitteln is Button)
                MessageBox.Show("Objekt CmdKlasseErmitteln ist vom Typ Button");
        }
    }
}
