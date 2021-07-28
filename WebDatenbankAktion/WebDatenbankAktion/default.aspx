<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>WebDatenbankAktion</title>
    <%@ page Language="C#" %>
    <%@ import Namespace="System.Data.OleDb"%>
    <script runat="server">
        private void Page_Load()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;
            int anzahl;

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=C:\Users\info\source\repos\WebDatenbankAktion\Firma.accdb";
            cmd.Connection = con;
            
            if(IsPostBack)
            {
                try
                {
                    con.Open();
                    cmd.CommandText = " INSERT INTO personen(name, vorname, personalnummer, gehalt, geburtstag) VALUES('" + TxtName.Value + "', '" + TxtVorname.Value +"', " + TxtPersonalnummer.Value + ", " + TxtGehalt.Value.Replace(",",".")  + ", '" + TxtGeburtstag.Value + "') ";
                    ausgabe.Text = cmd.CommandText;
                    anzahl = cmd.ExecuteNonQuery();
                    if(anzahl > 0)
                    ausgabe.Text = "Es wurde ein Datensatz eingefügt";
                }
                catch(Exception ex)
                {
                    ausgabe.Text = ex.Message;
                }
                con.Close();
            }

            cmd.CommandText = " SELECT * FROM personen ";
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                grid.DataSource = reader;
                DataBind();
                reader.Close();
            }
            catch(Exception ex)
            {
                ausgabe.Text = ex.Message;
            }
            con.Close();
        }
    </script>
</head>
<body>
    <p>Datenbank-Tabelle</p>
    <asp:DataGrid id="grid" runat="server"/>
    <form runat="server">
        <p><input type="text" runat="server" id="TxtName"> Name </p>
        <p><input type="text" runat="server" id="TxtVorname"> Vorname </p>
        <p><input type="text" runat="server" id="TxtPersonalnummer">Personalnummer </p>
        <p><input type="text" runat="server" id="TxtGehalt"> Gehalt </p>
        <p><input type="text" runat="server" id="TxtGeburtstag"> Geburtstag </p>
        <p><input type="submit" runat="server" value="Senden" />
    </form>
    <p><asp:Label ID="ausgabe" runat="server" /></p>
</body>
</html>
