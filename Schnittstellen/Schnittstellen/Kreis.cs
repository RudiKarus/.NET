using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    class Kreis : IAenderbar, ICloneable
    {
        private string farbe;
        private double radius;

        public Kreis(string f, double r)
        {
            farbe = f;
            radius = r;
        }

        public void Vergroessern(double faktor)
        {
            radius = radius * faktor;
        }

        public void Faerben (string f)
        {
            farbe = f;
        }

        public object Clone()
        {
            Kreis tmp = new Kreis(farbe, radius);
            return tmp;
        }

        public override string ToString()
        {
            return "Farbe: " + farbe + ", Radius: " + radius;
        }
    }
}
