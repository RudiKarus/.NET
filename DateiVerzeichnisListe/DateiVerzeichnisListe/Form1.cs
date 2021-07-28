using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DateiVerzeichnisListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Users\"))
                Directory.SetCurrentDirectory(@"C: \Users\");
            else
                MessageBox.Show(@"Verzeichnis C: \Users\ existiert nicht");

            LblAktuellesVerzeichnis.Text = Directory.GetCurrentDirectory();
        }

        //die Dateien im aktuellen Verzeichnis anzeigen:
        private void CmdDateiListe_Click(object sender, EventArgs e)
        {
            string verzeichnis;
            string[] dateiliste;

            verzeichnis = Directory.GetCurrentDirectory();
            dateiliste = Directory.GetFiles(verzeichnis);

            LstAnzeige.Items.Clear();

            foreach (string s in dateiliste)
                LstAnzeige.Items.Add(s);
        }


        private void CmdSystemeintraege_Click(object sender, EventArgs e)
        {
            Systemeintraege();
        }

        //die Dateisystemeinträge des aktuellen Verzeichnisses anzeigen:
        private void Systemeintraege()
        {
            string verzeichnis;
            string[] dateiliste;

            verzeichnis = Directory.GetCurrentDirectory();
            dateiliste = Directory.GetFileSystemEntries(verzeichnis); //GetFilesystemEntries liefert auch die Namen der Verzeichnisse;

            LstAnzeige.Items.Clear();

            foreach (string s in dateiliste)
                LstAnzeige.Items.Add(s);
        }


        //Infos über die selektierten Verzeichnisses anzeigen:
        private void LstAnzeige_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name;

            if (LstAnzeige.SelectedIndex != -1)
            {
                name = LstAnzeige.Text;
                LblAnzeige.Text = name + 
                    "\nErzeugt: " + File.GetCreationTime(name) + 
                    "\nLetzter Zugriff: " + File.GetLastAccessTime(name) + 
                    "\nLetzter Schreibzugriff: " + File.GetLastWriteTime(name);
            }
            else
                MessageBox.Show("Kein Eintrag ausgewählt");
        }


        //in ein selektiertes Verzeichnis wechseln:
        private void CmdInVerzeichnis_Click(object sender, EventArgs e)
        {
            if (LstAnzeige.SelectedIndex != -1)
            {
                try
                {
                    Directory.SetCurrentDirectory(LstAnzeige.Text);
                }
                catch
                {
                    MessageBox.Show(LstAnzeige.Text + "ist kein Verzeichnis");
                }
            }
            else
                MessageBox.Show("Kein Eintrag ausgewählt");

            LblAktuellesVerzeichnis.Text = Directory.GetCurrentDirectory();
            Systemeintraege();
        }


        //im aktuellen Pfad um ein Verzeichnis zurück gehen:
        private void CmdNachOben_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("..");
            LblAktuellesVerzeichnis.Text = Directory.GetCurrentDirectory();
            Systemeintraege();
        }
    }
}
