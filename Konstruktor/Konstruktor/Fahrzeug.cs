using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    class Fahrzeug
    {
        private string bezeichnung;
        private int geschwindigkeit;

        public Fahrzeug(string b, int g)
        {
            bezeichnung = b;
            geschwindigkeit = g;
        }

        public Fahrzeug(string b)
        {
            bezeichnung = b;
            geschwindigkeit = 0;
        }

        public Fahrzeug(int g)
        {
            bezeichnung = "(leer)";
            geschwindigkeit = g;
        }

        public Fahrzeug():this("(leer)", 0)
        {
        }

        public override string ToString() //jede vordefinierte oder eigene Klasse erbt die Methode ToString() von der Basisklasse object; Dient zur Ausgabe der Daten als Zeichenkette;
        {
            return "Bezeichnung: " + bezeichnung + "\n" + "Geschwindigkeit: " + geschwindigkeit + "\n";
        }
       

        public void beschleunigen(int wert)
        {
            geschwindigkeit += wert;
        }
    }
}
