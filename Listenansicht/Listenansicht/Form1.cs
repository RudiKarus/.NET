using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listenansicht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LView.View = View.Details;
            LView.FullRowSelect = true; //die ganze Zeile kann markiert werden; 

            ListViewItem eintrag1 = new ListViewItem("Berlin.txt", 0); //ListViewItem steht für einen Eintrag innerhalb der Liste, die Zahl steht für die dazugehörige Bilddatei innerhalb der Bildlisten;
            eintrag1.SubItems.Add("120KB"); //hinzufügen von Untereinträgen zum Eintrag; 
            eintrag1.SubItems.Add("13.07.2017");
            LView.Items.Add(eintrag1);

            ListViewItem eintrag2 = new ListViewItem("Paris.txt", 1);
            eintrag2.SubItems.Add("130KB");
            eintrag2.SubItems.Add("05.07.2017");
            LView.Items.Add(eintrag2); //die erzeugten Elemente werden dem Objekt LView hinzugefügt;

            ListViewItem eintrag3 = new ListViewItem("Rom.txt", 2);
            eintrag3.SubItems.Add("100KB");
            eintrag3.SubItems.Add("24.07.2017");
            LView.Items.Add(eintrag3);

            LView.Columns.Add("Name", 100);
            LView.Columns.Add("Größe", 100);
            LView.Columns.Add("Datum", 100);

            ImageList bildKlein = new ImageList();
            bildKlein.Images.Add(Image.FromFile("bild0.bmp"));
            bildKlein.Images.Add(Image.FromFile("bild1.bmp"));
            bildKlein.Images.Add(Image.FromFile("bild2.bmp"));
            LView.SmallImageList = bildKlein;
            LView.LargeImageList = bildKlein;
        }

        private void OptView_CheckedChanged(object sender, EventArgs e)
        {
            if (OptDetails.Checked)
                LView.View = View.Details;
            else if (OptLargeIcon.Checked)
                LView.View = View.LargeIcon;
            else if (OptList.Checked)
                LView.View = View.List;
            else if (OptSmallIcon.Checked)
                LView.View = View.List;
            else if (OptTile.Checked)
                LView.View = View.Tile;
        }
    }
}
