using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listenfeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
            LblAuswahl.Text = "Auswahl: " + "\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstSpeisen.Items.Add("Spaghetti");
            LstSpeisen.Items.Add("Grüne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Anzahl: " + LstSpeisen.Items.Count + "\n" +
                "Ausgewählter Eintrag: " + LstSpeisen.SelectedItem + "\n" +
                "IndexNummer des ausgewähltrn Eintrags: " + LstSpeisen.SelectedIndex + "\n" +
                "Liste aller Einträge: ";
            for (int i = 0; i < LstSpeisen.Items.Count; i++)
                LblAnzeige.Text += LstSpeisen.Items[i] + "\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Liste aller Einträge: " + "\n";
            foreach (string s in LstSpeisen.Items)
                LblAnzeige.Text += s + "\n";
        }

        private void BtnEreignis_Click(object sender, EventArgs e)
        {
            LstSpeisen.SelectedIndex = 3;
        }

        private void LstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblAuswahl.Text = "Auswahl: " + LstSpeisen.SelectedItem;
        }
    }
}
