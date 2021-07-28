using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schnittstellen
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
            Kreis k1 = new Kreis("rot", 20);
            Kreis k2 = (Kreis)k1.Clone(); //"Clone" liefert einen Verweis auf die Klasse "object" und muss in einen Verweis der Klasse "Kreis" umgewandelt werden;

            k1.Faerben("gelb");
            k1.Vergroessern(1.5);

            LblAnzeige.Text = k1 + "\n" + k2;
        }
    }
}
