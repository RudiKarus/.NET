namespace DBVerwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdAlleSehen = new System.Windows.Forms.Button();
            this.TxtGeburtstag = new System.Windows.Forms.TextBox();
            this.TxtGehalt = new System.Windows.Forms.TextBox();
            this.TxtPersonalnummer = new System.Windows.Forms.TextBox();
            this.TxtVorname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LstAnzeige = new System.Windows.Forms.ListBox();
            this.CmdEinfuegen = new System.Windows.Forms.Button();
            this.CmdAendern = new System.Windows.Forms.Button();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.CmdNameSuchen = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblVorname = new System.Windows.Forms.Label();
            this.LblPnummer = new System.Windows.Forms.Label();
            this.LblGehalt = new System.Windows.Forms.Label();
            this.LblGeburtstag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAlleSehen
            // 
            this.CmdAlleSehen.Location = new System.Drawing.Point(52, 50);
            this.CmdAlleSehen.Name = "CmdAlleSehen";
            this.CmdAlleSehen.Size = new System.Drawing.Size(75, 23);
            this.CmdAlleSehen.TabIndex = 0;
            this.CmdAlleSehen.Text = "Alle sehen";
            this.CmdAlleSehen.UseVisualStyleBackColor = true;
            this.CmdAlleSehen.Click += new System.EventHandler(this.CmdAlleSehen_Click);
            // 
            // TxtGeburtstag
            // 
            this.TxtGeburtstag.Location = new System.Drawing.Point(437, 230);
            this.TxtGeburtstag.Name = "TxtGeburtstag";
            this.TxtGeburtstag.Size = new System.Drawing.Size(100, 31);
            this.TxtGeburtstag.TabIndex = 1;
            // 
            // TxtGehalt
            // 
            this.TxtGehalt.Location = new System.Drawing.Point(437, 193);
            this.TxtGehalt.Name = "TxtGehalt";
            this.TxtGehalt.Size = new System.Drawing.Size(100, 31);
            this.TxtGehalt.TabIndex = 2;
            // 
            // TxtPersonalnummer
            // 
            this.TxtPersonalnummer.Location = new System.Drawing.Point(437, 156);
            this.TxtPersonalnummer.Name = "TxtPersonalnummer";
            this.TxtPersonalnummer.Size = new System.Drawing.Size(100, 31);
            this.TxtPersonalnummer.TabIndex = 3;
            // 
            // TxtVorname
            // 
            this.TxtVorname.Location = new System.Drawing.Point(437, 119);
            this.TxtVorname.Name = "TxtVorname";
            this.TxtVorname.Size = new System.Drawing.Size(100, 31);
            this.TxtVorname.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(437, 82);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 31);
            this.TxtName.TabIndex = 5;
            // 
            // LstAnzeige
            // 
            this.LstAnzeige.FormattingEnabled = true;
            this.LstAnzeige.ItemHeight = 25;
            this.LstAnzeige.Location = new System.Drawing.Point(52, 308);
            this.LstAnzeige.Name = "LstAnzeige";
            this.LstAnzeige.Size = new System.Drawing.Size(485, 79);
            this.LstAnzeige.TabIndex = 6;
            this.LstAnzeige.SelectedIndexChanged += new System.EventHandler(this.LstAnzeige_SelectedIndexChanged);
            // 
            // CmdEinfuegen
            // 
            this.CmdEinfuegen.Location = new System.Drawing.Point(52, 79);
            this.CmdEinfuegen.Name = "CmdEinfuegen";
            this.CmdEinfuegen.Size = new System.Drawing.Size(75, 23);
            this.CmdEinfuegen.TabIndex = 7;
            this.CmdEinfuegen.Text = "Einfügen";
            this.CmdEinfuegen.UseVisualStyleBackColor = true;
            this.CmdEinfuegen.Click += new System.EventHandler(this.CmdEinfuegen_Click);
            // 
            // CmdAendern
            // 
            this.CmdAendern.Location = new System.Drawing.Point(52, 108);
            this.CmdAendern.Name = "CmdAendern";
            this.CmdAendern.Size = new System.Drawing.Size(75, 23);
            this.CmdAendern.TabIndex = 8;
            this.CmdAendern.Text = "Ändern";
            this.CmdAendern.UseVisualStyleBackColor = true;
            this.CmdAendern.Click += new System.EventHandler(this.CmdAendern_Click);
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(52, 137);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 9;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // CmdNameSuchen
            // 
            this.CmdNameSuchen.Location = new System.Drawing.Point(437, 30);
            this.CmdNameSuchen.Name = "CmdNameSuchen";
            this.CmdNameSuchen.Size = new System.Drawing.Size(100, 23);
            this.CmdNameSuchen.TabIndex = 10;
            this.CmdNameSuchen.Text = "Name suchen";
            this.CmdNameSuchen.UseVisualStyleBackColor = true;
            this.CmdNameSuchen.Click += new System.EventHandler(this.CmdNameSuchen_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(363, 85);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(68, 25);
            this.LblName.TabIndex = 11;
            this.LblName.Text = "Name";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblVorname
            // 
            this.LblVorname.AutoSize = true;
            this.LblVorname.Location = new System.Drawing.Point(333, 122);
            this.LblVorname.Name = "LblVorname";
            this.LblVorname.Size = new System.Drawing.Size(98, 25);
            this.LblVorname.TabIndex = 12;
            this.LblVorname.Text = "Vorname";
            this.LblVorname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPnummer
            // 
            this.LblPnummer.AutoSize = true;
            this.LblPnummer.Location = new System.Drawing.Point(257, 159);
            this.LblPnummer.Name = "LblPnummer";
            this.LblPnummer.Size = new System.Drawing.Size(174, 25);
            this.LblPnummer.TabIndex = 13;
            this.LblPnummer.Text = "Personalnummer";
            this.LblPnummer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGehalt
            // 
            this.LblGehalt.AutoSize = true;
            this.LblGehalt.Location = new System.Drawing.Point(356, 196);
            this.LblGehalt.Name = "LblGehalt";
            this.LblGehalt.Size = new System.Drawing.Size(75, 25);
            this.LblGehalt.TabIndex = 14;
            this.LblGehalt.Text = "Gehalt";
            this.LblGehalt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGeburtstag
            // 
            this.LblGeburtstag.AutoSize = true;
            this.LblGeburtstag.Location = new System.Drawing.Point(313, 233);
            this.LblGeburtstag.Name = "LblGeburtstag";
            this.LblGeburtstag.Size = new System.Drawing.Size(118, 25);
            this.LblGeburtstag.TabIndex = 15;
            this.LblGeburtstag.Text = "Geburtstag";
            this.LblGeburtstag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.LblGeburtstag);
            this.Controls.Add(this.LblGehalt);
            this.Controls.Add(this.LblPnummer);
            this.Controls.Add(this.LblVorname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.CmdNameSuchen);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.CmdAendern);
            this.Controls.Add(this.CmdEinfuegen);
            this.Controls.Add(this.LstAnzeige);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtVorname);
            this.Controls.Add(this.TxtPersonalnummer);
            this.Controls.Add(this.TxtGehalt);
            this.Controls.Add(this.TxtGeburtstag);
            this.Controls.Add(this.CmdAlleSehen);
            this.Name = "Form1";
            this.Text = "Datenbank | Verwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAlleSehen;
        private System.Windows.Forms.TextBox TxtGeburtstag;
        private System.Windows.Forms.TextBox TxtGehalt;
        private System.Windows.Forms.TextBox TxtPersonalnummer;
        private System.Windows.Forms.TextBox TxtVorname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ListBox LstAnzeige;
        private System.Windows.Forms.Button CmdEinfuegen;
        private System.Windows.Forms.Button CmdAendern;
        private System.Windows.Forms.Button CmdLoeschen;
        private System.Windows.Forms.Button CmdNameSuchen;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblVorname;
        private System.Windows.Forms.Label LblPnummer;
        private System.Windows.Forms.Label LblGehalt;
        private System.Windows.Forms.Label LblGeburtstag;
    }
}

