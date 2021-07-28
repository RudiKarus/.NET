using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLerstellen
{
    public partial class Fahrzeug : Component
    {
        public Fahrzeug()
        {
            InitializeComponent();
        }

        public Fahrzeug(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

 
        private int geschwindigkeit;

        public void Beschleunigen(int wert)
        {
            geschwindigkeit += wert;
        }

        public override string ToString()
        {
            return "Geschwindigkeit: " + geschwindigkeit; 
        }
    }
}
