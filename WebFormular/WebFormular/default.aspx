<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8" />
    <title>WebFormular</title>
    <%@ page language="C#" %>

    <script runat="server">
        private void Page_Load()
        {
            double z1, z2, z;
            if(IsPostBack)      //die Methode "IsPostBack" der Klasse "Page" entscheided ob die Seite zum ersten mal aufgerufen wurde, oder ob sie sich selbst, nach Benutzereingabe, aufruft;
            {
                try { z1 = Convert.ToDouble(zahl1.Value); }
                catch { z1 = 0; }
                
                try { z2 = Convert.ToDouble(zahl2.Value); }
                catch { z2 = 0; }
                
                z = z1+z2;
                ergebnis.Text = "Ergebnis: "+z;
            }
        }
    </script>

</head>

<body>
    <p>Addieren</p>
    <form runat="server">
        <p><input runat="server" id="zahl1"> Zahl 1</p>
        <p><input runat="server" id="zahl2"> Zahl 2</p>
        <p><input runat="server" type="submit" value="senden"></p>
    </form>
    <p><asp:Label id="ergebnis" runat="server"/></p>
</body>
</html>
