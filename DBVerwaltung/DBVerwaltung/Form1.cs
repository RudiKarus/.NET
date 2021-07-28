using System;
using System.Collections.Generic;//
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//Zugriff auf AccessDatenbanken;

namespace DBVerwaltung
{
    public partial class Form1 : Form
    {

        private OleDbCommand cmd = new OleDbCommand();
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader reader;
        private List<int> pnummer = new List<int>();


        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" + 
                @"Data Source=C:\Users\info\source\repos\DBVerwaltung\DBVerwaltung\bin\Debug\firma.accdb"; //Provider + Datenquelle;
            cmd.Connection = con;
        }


        public Form1()
        {
            InitializeComponent();
        }


        private void CmdAlleSehen_Click(object sender, EventArgs e)
        {
            AlleSehen(); //Verbindung wird geöffnet;
        }


        private void AlleSehen()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM personen"; //SQL Befehl wird formuliert und gesendet;
                Ausgabe();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            //Startzustand der Textboxen;
            TxtName.Text = "";
            TxtVorname.Text = "";
            TxtPersonalnummer.Text = "";
            TxtGehalt.Text = "";
            TxtGeburtstag.Text = "";
        }


        private void Ausgabe()
        {
            DateTime geburtstag;

            reader = cmd.ExecuteReader(); //SQL Befehl wird ausgeführt und im Reader gespeichert;
            LstAnzeige.Items.Clear();
            pnummer.Clear();

            while(reader.Read())
            {
                geburtstag = Convert.ToDateTime(reader["geburtstag"]);

                LstAnzeige.Items.Add(reader["name"] + " # " + //die einzelnen Datensätze werden in einem Listenfeld ausgegeben;
                    reader["vorname"] + " # " +
                    reader["personalnummer"] + " # " +
                    reader["gehalt"] + " # " +
                    geburtstag.ToShortDateString()); //der Inhalt des Listenfelds Geburtstag wird in ein Objekt der Struktur DateTime konvertiert (Datum ohne Uhrzeit);
                pnummer.Add((int)reader["personalnummer"]); //generische Liste pnummer wird mit werten gefüllt; Der Index bleibt der selbe (1:1);
            }
            reader.Close();
        }


        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            int anzahl;

            try
            {
                con.Open();

                cmd.CommandText = "INSERT INTO personen (name, vorname, personalnummer, gehalt, geburtstag) VALUES ('"
                    + TxtName.Text + "', '"
                    + TxtVorname.Text + "', "
                    + TxtPersonalnummer.Text + ", "
                    + TxtGehalt.Text.Replace(',', '.') + ", '" //Replace dient hier der Umwandlung von Komma in Punkt;
                    + TxtGeburtstag.Text + "')";
                MessageBox.Show(cmd.CommandText); //zur Kontrollansicht;

                anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Ein Datensatz eingefügt");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte mindestens einen Namen, " + "eine eindeutige Personalnummer und ein gültiges " + "Geburtsdatum eingeben.");

            }
            con.Close();
            AlleSehen();
        }


        private void LstAnzeige_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime geburtstag;

            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM personen WHERE "+"personalnummer =" + pnummer[LstAnzeige.SelectedIndex]; //Zusammensetzung des SQL Befehls;
                reader = cmd.ExecuteReader(); //Kommando wird mit ExecuteReader() gesendet;
                reader.Read();

                TxtName.Text = "" + reader["name"];
                TxtVorname.Text = "" + reader["vorname"];
                TxtPersonalnummer.Text = "" + reader["personalnummer"];
                TxtGehalt.Text = "" + reader["gehalt"];
                geburtstag = Convert.ToDateTime(reader["geburtstag"]); //Konvertierung des Strings in das DateTime Format;
                TxtGeburtstag.Text = geburtstag.ToShortDateString();

                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void CmdAendern_Click(object sender, EventArgs e)
        {
            if (TxtPersonalnummer.Text == "")
            {
                MessageBox.Show("Bitte einen Datensatz auswählen");
                return;
            }

            try
            {
                con.Open();
                cmd.CommandText = "UPDATE personen SET name = " + "'" + TxtName.Text
                    + "', vorname = '" + TxtVorname.Text
                    + "', personalnummer = " + TxtPersonalnummer.Text
                    + ", gehalt = " + TxtGehalt.Text.Replace(',', '.')
                    + ", geburtstag = '" + TxtGeburtstag.Text
                    + "' WHERE "
                    + "personalnummer = " + pnummer[LstAnzeige.SelectedIndex];
                MessageBox.Show(cmd.CommandText);

                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz geändert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }


        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            if(TxtPersonalnummer.Text=="")
            {
                MessageBox.Show("Bitte einen Datensatz auswählen");
                return;
            }

            if (MessageBox.Show("Möchten Sie den ausgewählten Datensatz wirklich löschen?", "Löschen", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM personen WHERE" + " personalnummer = " + pnummer[LstAnzeige.SelectedIndex];
                MessageBox.Show(cmd.CommandText);

                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz gelöscht");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
            AlleSehen();
        }


        private void CmdNameSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM personen WHERE name LIKE '%" + TxtName.Text + "%'";
                MessageBox.Show(cmd.CommandText);
                Ausgabe();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }
    }
}
