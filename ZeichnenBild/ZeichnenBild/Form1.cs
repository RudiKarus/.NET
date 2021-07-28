using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeichnenBild
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAuswahl_Click(object sender, EventArgs e)
        {
            Graphics z = CreateGraphics();
            Font df = new Font("Verdana", 11);
            SolidBrush pinsel = new SolidBrush(Color.Black);

            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = @"C:\Users\info",
                Title = "Bitte eine Bilddatei auswählen",
                Filter = "Bild-Dateien(*.jpg, *.gif)|*.jpg; *.gif"
            };

            Image bild;
            z.Clear(BackColor);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bild = Image.FromFile(ofd.FileName);
                z.DrawImage(bild, 20, 40);
                z.DrawString("Breite: " + bild.Width + ", Höhe: " + bild.Height, df, pinsel, 20, 20);
            }
            else
                MessageBox.Show("Keine Bilddatei ausgewählt");
        }
    }
}

