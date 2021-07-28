using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//

namespace ZeichnenDauerhaft
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics z;
            Pen stift = new Pen(Color.Black, 2);
            Font f = new Font("Arial", 16);
            SolidBrush pinsel = new SolidBrush(Color.Gray);
            Image bild;
            string filename;

            //Holt Grafik zum zeichnen
            z = e.Graphics; //das Objekt "e" der Klasse "PaintEventArgs" liefert Daten für das "Paint" Ereignis;
                            //eine Eigenschaftsmethode von "e" ist "Graphics";

            //Rechteck, Text
            z.DrawRectangle(stift, 20, 20, 30, 60);
            z.DrawString("Hallo", f, pinsel, 70, 20);

            //Bild
            filename = "Test.gif";
            if (File.Exists(filename))
            {
                bild = Image.FromFile(filename);
            }
            else
                MessageBox.Show("Datei nicht vorhanden");
        }
    }
}
