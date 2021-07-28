using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigenschaftsmethode
{
    class Fahrzeug
    {
        private int geschwindigkeit; //geschützte Eigenschaft

        public int Geschwindigkeit //die Eigenschaftsmethode zur Eigenschaft, gemäß Konventionen so benannt wie die eigenschaft nur mit Großbuchstaben;
        {
            get //get-Accessor (lesen der Eigenschaft "geschwindigkeit")
            {
                return geschwindigkeit;
            }
            private set //set-Accessor (schreiben in die Eigenschaft "geschwindigkeit"), mit private gekapselt
            {
                if (value > 100) geschwindigkeit = 100;
                else if (value < 0) geschwindigkeit = 0;
                else geschwindigkeit = value;
            }
        }

        public void Beschleunigen(int wert)
        {
            Geschwindigkeit += wert; //Geschwindigkeit erhält einen "wert", der "wert" liefert den wert an das Schlüsselwort "value" im set-accessor
        }
    }
}
