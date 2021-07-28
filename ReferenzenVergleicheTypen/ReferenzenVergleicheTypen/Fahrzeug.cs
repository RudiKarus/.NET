using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenzenVergleicheTypen
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
            bezeichnung = "Moped";
            geschwindigkeit = g;
        }

        public Fahrzeug():this("(leer)", 0)
        {
        }

        public override string ToString()
        {
            return "Bezeichnung: " + bezeichnung + "\n" + "Geschwindigkeit: " + geschwindigkeit + "\n";
        }

        public void Beschleunigen (int wert)
        {
            geschwindigkeit += wert;
        }


        public bool Equals(Fahrzeug x)
        {
            if (bezeichnung == x.bezeichnung && geschwindigkeit == x.geschwindigkeit)
                return true;
            else
                return false;
        }
    }
}
