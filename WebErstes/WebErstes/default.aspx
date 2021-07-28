<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>WebErstes</title>
    
    <%@ page language="C#" %>
    <script runat="server">
        private void Page_Load()
        {
            int x, y, z;
            x = 5;
            y = 12;
            z = x + y;
            ergebnis.InnerText="Ergebnis: "+z;
        }
    </script>

</head>
<body>
    <p id="ergebnis" runat="server"></p>
</body>
</html>
