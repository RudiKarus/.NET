using System;
using System.Collections.Generic;//
using System.ComponentModel;
using System.Data;
using System.Drawing;//
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        private int PX; //index des aktuellen Panels;
        private int[,] F = new int[15, 10]; //Spielfeld inkl.Randfelder;
        private int PZ, PS; //Zeile und Spalte des aktuellen Panels;
        private int Stufe; //Schwierigkeitsstufe;

        //eine (leere) Liste von Spiel-Panels;
        private List<Panel> PL = new List<Panel>(); //generische Listen können beliebeige Objekttypen enthalten;

        //ein Feld von Farben für die Panels;
        private Color[] FarbenFeld = { Color.Red, Color.Green, Color.Blue, Color.Cyan, Color.Magenta, Color.Yellow, Color.Black, Color.White };

        //Konstante für den Status eines Feldpunktes;
        private int Leer = -1;
        private int Rand = -2;

        //Zufallsgenerator erzeugen und initialisieren;
        private Random r = new Random();


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Feld besetzen;
            for (int Z = 1; Z < 14; Z++)
            {
                F[Z, 0] = Rand;
                for (int S = 1; S < 9; S++)
                    F[Z, S] = Leer;
                F[Z, 9] = Rand;
            }

            for (int S = 0; S < 10; S++)
                F[14, S] = Rand;

            //Intialisierung;
            Stufe = 1;
            NaechstesPanel();
        }


        private void TimTetris_Tick(object sender, EventArgs e)
        {
            //falls es nicht mehr weiter geht;
            if (F[PZ + 1, PS] != Leer)
            {
                //oberste Zeile erreicht;
                if (PZ == 1)
                {
                    TimTetris.Enabled = false;
                    MessageBox.Show("Game Over");
                    return;
                }

                F[PZ, PS] = PX; //Panel ablegen; Kennzeichnung eines belegten Feldelements;
                AllePruefen();
                NaechstesPanel();
            }
            else
            {   //falls es noch weiter geht;
                PL[PX].Top = PL[PX].Top + 20; //befindet sich unterhalb(.Top +20) des Panels noch ein freies Feld...
                PZ = PZ + 1; //...kann das Panel +1 weiter fallen;
            }
        }


        void AllePruefen()
        {
            bool Neben = false;
            bool Ueber = false;

            //drei gleiche Panels nebeneinander;
            for(int Z=13; Z>0; Z--)
            {
                for(int S=1; S<7; S++)
                {
                    Neben = NebenPruefen(Z, S);
                    if (Neben) break;
                }

                if (Neben) break;
            }

            //Drei gleiche Panels übereinander;
            for(int Z=13; Z>2; Z--)
            {
                for(int S=1; S<9; S++)
                {
                    Ueber = UeberPruefen(Z, S);
                    if (Ueber) break;
                }

                if (Ueber) break;
            }

            if(Neben || Ueber)
            {
                //schneller;
                Stufe= Stufe + 1;
                TimTetris.Interval = 500+(Stufe +9);

                //evtl. kann jetzt noch eine Reihe entfernt werden;
                AllePruefen();
            }
        }


        //falls drei Felder nebeneinander besetzt;
        private bool NebenPruefen(int Z, int S)
        {
            bool ergebnis = false;

            if(F[Z, S] != Leer && F[Z, S+1] != Leer && F[Z, S+2] != Leer)
            {
                //falls drei Farben gleich sind;
                if(PL[F[Z, S]].BackColor == PL[F[Z, S+1]].BackColor && PL[F[Z,S]].BackColor == PL[F[Z, S+2]].BackColor)
                {
                    for(int SX=S; SX < S+3; SX++)
                    {
                        //Panel aus dem Formular löschen
                        Controls.Remove(PL[F[Z, SX]]);

                        //Feld leeren
                        F[Z, SX] = Leer;

                        //Panels oberhalb des entladenen Panels absenken;
                        int ZX = Z - 1;
                        while(F[ZX, SX] != Leer)
                        {
                            PL[F[ZX, SX]].Top = PL[F[ZX, SX]].Top + 20;

                            //Feld neu besetzen;
                            F[ZX + 1, SX] = F[ZX, SX];
                            F[ZX, SX] = Leer;
                            ZX = ZX - 1;
                        }
                    }
                    ergebnis = true;
                }
            }
            return ergebnis;
        }


        //falls drei Felder übereinander besetzt;
        private bool UeberPruefen(int Z, int S)
        {
            bool ergebnis = false;

            if (F[Z,S] !=Leer && F[Z-1, S] != Leer && F[Z-2, S] !=Leer)
            {
                //Falls drei Farben glech sind;
                if(PL[F[Z, S]].BackColor == PL[F[Z-1, S]].BackColor && PL[F[Z, S]].BackColor == PL[F[Z-2, S]].BackColor)
                {
                    //3 Panels entladen;
                    for(int ZX=Z; ZX > Z-3; ZX--)
                    {
                        //PL aus dem Formular löschen;
                        Controls.Remove(PL[F[ZX, S]]);

                        //Feld leeren;
                        F[ZX, S] = Leer;
                    }
                }
                ergebnis = true;
            }

            return ergebnis;
        }


        void NaechstesPanel()
        {
            int Farbe;
            Panel p = new Panel(); //erzeugt das neue Panel;

            //fügt den Verweis über ein neues Panel zur generischen Liste hinzu;
            PL.Add(p);

            //neues Panel platzieren;
            p.Location = new Point(100, 80);
            p.Size = new Size(20, 20);

            //Farbauswahl für neues Panel;
            Farbe = r.Next(0, 8);
            p.BackColor = FarbenFeld[Farbe];

            //Neues Panel zum Formular hinzufügen;
            Controls.Add(p); //dadurch wird das Panel sichtbar

            //Index für späteren Zugriff ermitteln;
            PX = PL.Count-1; //diese Nummer wird für den späteren Zugriff benötigt;

            //Aktuelle Zeile, Spalte;
            PZ = 1;
            PS = 5;
        }


        private void CmdLinks_Click(object sender, EventArgs e)
        {
            if(F[PZ, PS-1] == Leer)
            {
                PL[PX].Left = PL[PX].Left - 20;
                PS = PS - 1;
            }
        }


        private void CmdRechts_Click(object sender, EventArgs e)
        {
            if (F[PZ, PS + 1] == Leer)
            {
                PL[PX].Left = PL[PX].Left + 20;
                PS = PS + 1;
            }
        }


        private void CmdUnten_Click(object sender, EventArgs e)
        {
            while(F[PZ +1, PS] == Leer)
            {
                PL[PX].Top = PL[PX].Top + 20;
                PZ = PZ + 1;
            }
            F[PZ, PS] = PX; //Belegen;

            AllePruefen();
            NaechstesPanel();
        }


        private void CmdPause_Click(object sender, EventArgs e)
        {
            TimTetris.Enabled = !TimTetris.Enabled;
        }
    }
}
