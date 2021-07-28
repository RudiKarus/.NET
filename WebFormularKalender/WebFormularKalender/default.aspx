<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>WebFormularKalender</title>
    <%@ page language="C#" %>
    <script runat="server">
        private void Auswahl(object sender, EventArgs e)
        {
            ausgabe.Text = kalender.SelectedDate.ToShortDateString();
        }
    </script>
</head>
<body>
    Kalender:
    <form id="Form1" runat="server">
        <asp:Calendar id="kalender" runat="server" OnSelectionChanged="Auswahl">
            <TodayDayStyle Backcolor="Red" ForeColor="Yellow"></TodayDayStyle>
            <WeekendDayStyle BackColor="Yellow" ForeColor="Red"></WeekendDayStyle>
        </asp:Calendar>
    </form>
    <p><asp:Label id="ausgabe" runat="server"/></p>
</body>
</html>
