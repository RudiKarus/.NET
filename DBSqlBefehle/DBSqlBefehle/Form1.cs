using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DBSqlBefehle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Auswahl(string sqlbefehl, params string[] felder)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;
            int i;
            string zeile;

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Temp\\firma.accdb";

            cmd.Connection = con;
            cmd.CommandText = sqlbefehl;

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                while (reader.Read())
                {
                    zeile = "";
                    for (i = 0; i < felder.Length; i++)
                        zeile += reader[felder[i]] + " # ";
                    LstAnzeige.Items.Add(zeile);
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Aktion(string sqlbefehl)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            int anzahl;

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Temp\\firma.accdb";
            cmd.Connection = con;

            cmd.CommandText = sqlbefehl;

            try
            {
                con.Open();
                anzahl = cmd.ExecuteNonQuery();
                MessageBox.Show(
                    "Datensätze geändert: " + anzahl);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdEinzelneFelder_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT name, vorname FROM personen", "name", "vorname");
        }

        private void CmdBedingungZahl_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT * FROM personen WHERE gehalt > 3600", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void CmdBedingungZeichen_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT * FROM personen WHERE name = 'Schmitz'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void CmdBedingungLogisch_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT * FROM personen WHERE gehalt >= 3600 AND gehalt <= 3650", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void CmdBeginntMitZeichen_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT * FROM personen WHERE name LIKE 'M%'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void CmdZeichenKommtVor_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT * FROM personen WHERE name LIKE '%i%'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void CmdEinzelnerPlatzhalter_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT * FROM personen WHERE name LIKE 'M__er'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void CmdSortierungFallend_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT name, gehalt FROM personen ORDER BY gehalt DESC", "name", "gehalt");
        }

        private void CmdSortierungNachZweiFeldern_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT * FROM personen ORDER BY name, vorname", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void CmdEingabeSuchbegriff_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT * FROM personen WHERE name LIKE '" + TxtEingabe.Text + "'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void CmdEingabeSuchzeichen_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT * FROM personen WHERE name LIKE '%" + TxtEingabe.Text + "%'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void CmdAendernAlle_Click(object sender, EventArgs e)
        {
            Aktion("UPDATE personen SET gehalt = 3800");
        }

        private void CmdAendernEinzeln_Click(object sender, EventArgs e)
        {
            Aktion("UPDATE personen SET gehalt = 3800 WHERE personalnummer = 2297");
        }

        private void CmdLoeschenEinzeln_Click(object sender, EventArgs e)
        {
            Aktion("DELETE FROM personen WHERE personalnummer = 2297");
        }

        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            Aktion("INSERT INTO personen (name, vorname, personalnummer, gehalt, geburtstag) VALUES('Müller', 'Gerd', 4711, 2900, '12.08.1976')");
        }

        private void CmdFehlerZeichen_Click(object sender, EventArgs e)
        {
            Aktion("UPDATE personen SET name = Mohr WHERE personalnummer = 6714");
        }

        private void CmdFehlerDatum_Click(object sender, EventArgs e)
        {
            Aktion("UPDATE personen SET geburtstag = '18.07.' WHERE personalnummer = 6714");
        }

        private void CmdFehlerEindeutigkeit_Click(object sender, EventArgs e)
        {
            Aktion("INSERT INTO personen (name, vorname, personalnummer, gehalt, geburtstag) VALUES('Müller', 'Gerd', 6714, 2900, '12.08.1976')");
        }

        private void CmdOriginalwerte_Click(object sender, EventArgs e)
        {
            Aktion("DELETE FROM personen");
            Aktion("INSERT INTO personen (name, vorname, personalnummer, gehalt, geburtstag) VALUES('Maier', 'Hans', 6714, 3500, '15.03.1962')");
            Aktion("INSERT INTO personen (name, vorname, personalnummer, gehalt, geburtstag) VALUES('Schmitz', 'Peter', 81343, 3750, '12.04.1958')");
            Aktion("INSERT INTO personen (name, vorname, personalnummer, gehalt, geburtstag) VALUES('Mertens', 'Julia', 2297, 3621.5, '30.12.1959')");
        }
    }
}
