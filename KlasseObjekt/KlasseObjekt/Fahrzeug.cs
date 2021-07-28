using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseObjekt
{
    class Fahrzeug
    {
        private int geschwindigkeit; //die Klasse Fahrzeug hat die Eigenschaft Geschwindigkeit; Eigenschaften werden auch als klassenweit gültige Variablen bezeichnet;
        // private dient der Kapselung, d.h diese Eigenschaft ist ausserhalb der Klasse nicht erreichbar;

        public string Ausgabe() 
        {
            return "Geschwindigkeit: " + geschwindigkeit;
        }

        public void Beschleunigen(int wert)
        {
            geschwindigkeit += wert;
        }
    }
}
