<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8" />
    <title>WebFormularElemente</title>
    <%@ page Language="C#" %>
    <script runat="server">
        private void Page_Load()
        {
            if(IsPostBack)
            {
                ausgabe.Text="Wir bieten ein Hotel in " + ziel.Value;
                if(allInc.Checked)
                {
                    ausgabe.Text += "<br>All Inclusive";
                }
                if(bett2.Checked)
                {
                    ausgabe.Text += "<br>Mit 2 Betten";
                }
                else
                {
                    ausgabe.Text += "<br>Mit 3 Betten";
                }
            }
        }
    </script>
</head>

<body>
    <p>Ihr Coronaverseuchtes Reisegebiet:</p>
    <form runat="server">
        <p><select id="ziel" runat="server">
                <option value="Barcelona">Spanien</option>
                <option value="Grenoble" selected="selected" >Frankreich</option>
                <option value="Genf" >Schweiz</option>
                <option value="Graz" >Österreich</option>
            </select></p>
        
        <p><input id="allInc" runat="server" type="checkbox" >All inclusive</p>

        <p><input type="radio" name="bett" id="bett2" runat="server" checked="true">2-Bett<br>
            <input type="radio" name="bett" id="bett3" runat="server">3-Bett</p>

        <p><input runat="server" type="submit" value="Senden"></p>

        <p><asp:Label ID="ausgabe" runat="server"/></p>
    </form>
</body>

</html>
