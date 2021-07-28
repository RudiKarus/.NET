using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//

namespace DBZugriffAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAlleSehen_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"DataSource = C:\Users\info\source\repos\Datenbank\firma1.accdb"; 

            cmd.Connection = con; //es wir festgelegt auf welcher Verbindung der SQL Befehl gesendet wird;
            cmd.CommandText = "SELECT * FROM personen"; //* bedeutet "Alle Felder" => select alle felder von tabelle;

            try //da es bei einem Zugriff auf eine Datenbank zahlreiche Fehlerquellen gibt, sollte er in einem try-catch block ablaufen;
            {
                con.Open();
                reader = cmd.ExecuteReader(); //ExecuteReader() sendet das Kommando; Es kommt ein Abfrageergebnis von der Klasse OleDbReader zurück und wird über den Verweis "reader";
                LstAnzeige.Items.Clear();
                while(reader.Read())
                {
                    LstAnzeige.Items.Add(reader["name"] + " # "
                        + reader["vorname"] + " # "
                        + reader["personalnummer"] + " # "
                        + reader["gehalt"] + " # " + reader["geburtstag"]);
                }
                reader.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdAendern_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            int anzahl;
            string op;

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source = C:\Users\info\source\repos\Datenbank\firma1.accdb";

            cmd.Connection = con;

            if (sender == CmdErhoehen)
                op = "*";
            else
                op = "/";
            cmd.CommandText = "UPDATE personen SET gehalt = gehalt" + op + "1.05";

            try
            {
                con.Open();

                anzahl = cmd.ExecuteNonQuery(); //anzahl der betroffenen Zeilen(Datensätze) wird zurückgeliefert;
                MessageBox.Show("Datensätze geändert: " + anzahl);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
