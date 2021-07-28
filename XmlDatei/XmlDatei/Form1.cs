using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; // for UniCode encoding;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //for access to the filesystem;
using System.Xml; //for access to xml files;

namespace XmlDatei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LblAnzeige.Text = "";
        }

        private void CmdSchreiben_Click(object sender, EventArgs e)
        {
            XmlTextWriter xw = new XmlTextWriter(@"C:\Users\info\source\repos\XmlDatei\XmlDatei\bin\Debug\firma.xml", new UnicodeEncoding());
            xw.WriteStartDocument(); //schreibt die Kopfzeile der XML-Datei; 
            xw.WriteStartElement("firma");

            xw.WriteStartElement("person");
            xw.WriteAttributeString("name", "Maier");
            xw.WriteAttributeString("vorname", "Hans");
            xw.WriteAttributeString("personalnummer", "6714");
            xw.WriteAttributeString("gehalt", "3500.0");
            xw.WriteAttributeString("geburtstag", "15.03.1962");
            xw.WriteEndElement();

            xw.WriteStartElement("person");
            xw.WriteAttributeString("name","Schmitz");
            xw.WriteAttributeString("vorname", "Peter");
            xw.WriteAttributeString("personalnummer", "81343");
            xw.WriteAttributeString("gehalt", "3750.0");
            xw.WriteAttributeString("geburtstag", "12.04.1958");
            xw.WriteEndElement();

            xw.WriteStartElement("person");
            xw.WriteAttributeString("name", "Mertens");
            xw.WriteAttributeString("vorname", "Julia");
            xw.WriteAttributeString("personalnummer", "2297");
            xw.WriteAttributeString("gehalt", "3621.5");
            xw.WriteAttributeString("geburtstag", "30.12.1959");
            xw.WriteEndElement();

            xw.WriteEndElement();
            xw.Close(); //beendet das Schreiben und schliesst die Datei;
        }


        private void CmdLesen_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\Users\info\source\repos\XmlDatei\XmlDatei\bin\Debug\firma.xml"))
            {
                LblAnzeige.Text = "Die Datei firma.xml existiert nicht";
                return;
            }

            XmlReader xr = new XmlTextReader(@"C:\Users\info\source\repos\XmlDatei\XmlDatei\bin\Debug\firma.xml");

            while(xr.Read()) //liest die Knoten und springt weiter zum nächsten, wenn kein Knoten mehr gefunden wird, wird "false" zurückgeliefert;
            {
                if(xr.NodeType == XmlNodeType.Element) //"wenn der Knotentyp == ein "Element" wie in der Enumeration XmlNodeType ist...";//Kopfzeile wird ignoriert; 
                {
                    if(xr.AttributeCount > 0) //"...und wenn die Anzahl der Attribute > 0 ist...";
                    {
                        while (xr.MoveToNextAttribute()) //"...werden die einzelnen Attribute mit "MoveToNextAttribute" ermittelt...";
                            LblAnzeige.Text += xr.Name + " -> " + xr.Value + "\n"; //"...und ausgegeben.";
                        LblAnzeige.Text += "\n";
                    }
                }
            }
            xr.Close();
        }


        private void CmdObjekteIn_Click(object sender, EventArgs e)
        {
            Person[] personFeld = new Person[3];
            personFeld[0] = new Person("Maier", "Hans", 6714, 3500.0, new DateTime(1962, 3, 5));
            personFeld[1] = new Person("Schmitz", "Peter", 81343, 3750.0, new DateTime(1958, 4, 12));
            personFeld[2] = new Person("Mertens", "Julia", 2297, 3621.5, new DateTime(1959, 12, 30));

            XmlTextWriter xw = new XmlTextWriter(@"C:\Users\info\source\repos\XmlDatei\XmlDatei\bin\Debug\firma.xml", new UnicodeEncoding());
            xw.WriteStartDocument();
            xw.WriteStartElement("firma");

            foreach(Person p in personFeld)
            {
                p.AlsXmlElementSchreiben(xw);
            }

            xw.WriteEndElement();
            xw.Close();
        }


        private void CmdObjekteAus_Click(object sender, EventArgs e)
        {
            if(!File.Exists(@"C:\Users\info\source\repos\XmlDatei\XmlDatei\bin\Debug\firma.xml"))
            {
                LblAnzeige.Text = "Datei firma.xml existiert nicht";
                return;
            }

            Person[] personFeld = new Person[3];
            string na = "";
            string vn = "";
            int pn = 0;
            double gh = 0.0;
            DateTime gt = new DateTime();
            int i;

            XmlReader xr = new XmlTextReader(@"C:\Users\info\source\repos\XmlDatei\XmlDatei\bin\Debug\firma.xml");

            i = 0;
            while(xr.Read())
            {
                if(xr.NodeType==XmlNodeType.Element)
                {
                    if(xr.AttributeCount > 0)
                    {
                        while(xr.MoveToNextAttribute())
                        {
                            switch(xr.Name)
                            {
                                case "name": na = xr.Value;
                                    break;
                                case "vorname": vn = xr.Value;
                                    break;
                                case "personalnummer": pn = Convert.ToInt32(xr.Value);
                                    break;
                                case "gehalt": gh = Convert.ToSingle(xr.Value);
                                    break;
                                case "geburtstag":
                                    int Jahr = Convert.ToInt32(xr.Value.Substring(6, 4));
                                    int monat = Convert.ToInt32(xr.Value.Substring(3, 2));
                                    int tag = Convert.ToInt32(xr.Value.Substring(0, 2));
                                    gt = new DateTime(Jahr, monat, tag);
                                    break;
                            }
                        }
                    }
                }
            }
            xr.Close();

            LblAnzeige.Text = "";
            foreach(Person p in personFeld)
            {
                LblAnzeige.Text += p + "\n";
            }
        }
    }
}
