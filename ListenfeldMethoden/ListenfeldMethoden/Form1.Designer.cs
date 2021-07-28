namespace ListenfeldMethoden
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
            this.CmdEinfuegen = new System.Windows.Forms.Button();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.CmdErsetzen = new System.Windows.Forms.Button();
            this.CmdAllesLoeschen = new System.Windows.Forms.Button();
            this.LblEinfuegen = new System.Windows.Forms.Label();
            this.LblAusgewaehltesElement = new System.Windows.Forms.Label();
            this.LblEinfuegeort = new System.Windows.Forms.Label();
            this.TxtNeu = new System.Windows.Forms.TextBox();
            this.TxtErsetzen = new System.Windows.Forms.TextBox();
            this.LstSpeisen = new System.Windows.Forms.ListBox();
            this.OptAnfang = new System.Windows.Forms.RadioButton();
            this.OptAuswahl = new System.Windows.Forms.RadioButton();
            this.OptEnde = new System.Windows.Forms.RadioButton();
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdEinfuegen
            // 
            this.CmdEinfuegen.Location = new System.Drawing.Point(484, 113);
            this.CmdEinfuegen.Name = "CmdEinfuegen";
            this.CmdEinfuegen.Size = new System.Drawing.Size(75, 23);
            this.CmdEinfuegen.TabIndex = 0;
            this.CmdEinfuegen.Text = "Einfügen";
            this.CmdEinfuegen.UseVisualStyleBackColor = true;
            this.CmdEinfuegen.Click += new System.EventHandler(this.CmdEinfuegen_Click);
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(41, 320);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 1;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // CmdErsetzen
            // 
            this.CmdErsetzen.Location = new System.Drawing.Point(41, 349);
            this.CmdErsetzen.Name = "CmdErsetzen";
            this.CmdErsetzen.Size = new System.Drawing.Size(75, 23);
            this.CmdErsetzen.TabIndex = 2;
            this.CmdErsetzen.Text = "Ersetzen";
            this.CmdErsetzen.UseVisualStyleBackColor = true;
            this.CmdErsetzen.Click += new System.EventHandler(this.CmdErsetzen_Click);
            // 
            // CmdAllesLoeschen
            // 
            this.CmdAllesLoeschen.Location = new System.Drawing.Point(484, 395);
            this.CmdAllesLoeschen.Name = "CmdAllesLoeschen";
            this.CmdAllesLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdAllesLoeschen.TabIndex = 3;
            this.CmdAllesLoeschen.Text = "Alles Löschen";
            this.CmdAllesLoeschen.UseVisualStyleBackColor = true;
            this.CmdAllesLoeschen.Click += new System.EventHandler(this.CmdAllesLoeschen_Click);
            // 
            // LblEinfuegen
            // 
            this.LblEinfuegen.AutoSize = true;
            this.LblEinfuegen.Location = new System.Drawing.Point(479, 45);
            this.LblEinfuegen.Name = "LblEinfuegen";
            this.LblEinfuegen.Size = new System.Drawing.Size(164, 25);
            this.LblEinfuegen.TabIndex = 4;
            this.LblEinfuegen.Text = "Neues Element:";
            // 
            // LblAusgewaehltesElement
            // 
            this.LblAusgewaehltesElement.AutoSize = true;
            this.LblAusgewaehltesElement.Location = new System.Drawing.Point(36, 280);
            this.LblAusgewaehltesElement.Name = "LblAusgewaehltesElement";
            this.LblAusgewaehltesElement.Size = new System.Drawing.Size(236, 25);
            this.LblAusgewaehltesElement.TabIndex = 5;
            this.LblAusgewaehltesElement.Text = "Ausgewähltes Element:";
            // 
            // LblEinfuegeort
            // 
            this.LblEinfuegeort.AutoSize = true;
            this.LblEinfuegeort.Location = new System.Drawing.Point(479, 159);
            this.LblEinfuegeort.Name = "LblEinfuegeort";
            this.LblEinfuegeort.Size = new System.Drawing.Size(116, 25);
            this.LblEinfuegeort.TabIndex = 6;
            this.LblEinfuegeort.Text = "Einfügeort:";
            // 
            // TxtNeu
            // 
            this.TxtNeu.Location = new System.Drawing.Point(484, 76);
            this.TxtNeu.Name = "TxtNeu";
            this.TxtNeu.Size = new System.Drawing.Size(100, 31);
            this.TxtNeu.TabIndex = 7;
            // 
            // TxtErsetzen
            // 
            this.TxtErsetzen.Location = new System.Drawing.Point(41, 386);
            this.TxtErsetzen.Name = "TxtErsetzen";
            this.TxtErsetzen.Size = new System.Drawing.Size(100, 31);
            this.TxtErsetzen.TabIndex = 8;
            // 
            // LstSpeisen
            // 
            this.LstSpeisen.FormattingEnabled = true;
            this.LstSpeisen.ItemHeight = 25;
            this.LstSpeisen.Location = new System.Drawing.Point(41, 45);
            this.LstSpeisen.Name = "LstSpeisen";
            this.LstSpeisen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstSpeisen.Size = new System.Drawing.Size(120, 79);
            this.LstSpeisen.TabIndex = 9;
            // 
            // OptAnfang
            // 
            this.OptAnfang.AutoSize = true;
            this.OptAnfang.Location = new System.Drawing.Point(484, 231);
            this.OptAnfang.Name = "OptAnfang";
            this.OptAnfang.Size = new System.Drawing.Size(237, 29);
            this.OptAnfang.TabIndex = 10;
            this.OptAnfang.TabStop = true;
            this.OptAnfang.Text = "Am Anfang der Liste";
            this.OptAnfang.UseVisualStyleBackColor = true;
            // 
            // OptAuswahl
            // 
            this.OptAuswahl.AutoSize = true;
            this.OptAuswahl.Location = new System.Drawing.Point(484, 266);
            this.OptAuswahl.Name = "OptAuswahl";
            this.OptAuswahl.Size = new System.Drawing.Size(304, 29);
            this.OptAuswahl.TabIndex = 11;
            this.OptAuswahl.TabStop = true;
            this.OptAuswahl.Text = "Vor ausgewähltem Element";
            this.OptAuswahl.UseVisualStyleBackColor = true;
            // 
            // OptEnde
            // 
            this.OptEnde.AutoSize = true;
            this.OptEnde.Location = new System.Drawing.Point(484, 196);
            this.OptEnde.Name = "OptEnde";
            this.OptEnde.Size = new System.Drawing.Size(219, 29);
            this.OptEnde.TabIndex = 12;
            this.OptEnde.TabStop = true;
            this.OptEnde.Text = "Am Ende der Liste";
            this.OptEnde.UseVisualStyleBackColor = true;
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(41, 130);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 13;
            this.CmdAnzeige.Text = "Anzeigen";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(36, 159);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 14;
            this.LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAnzeige);
            this.Controls.Add(this.OptEnde);
            this.Controls.Add(this.OptAuswahl);
            this.Controls.Add(this.OptAnfang);
            this.Controls.Add(this.LstSpeisen);
            this.Controls.Add(this.TxtErsetzen);
            this.Controls.Add(this.TxtNeu);
            this.Controls.Add(this.LblEinfuegeort);
            this.Controls.Add(this.LblAusgewaehltesElement);
            this.Controls.Add(this.LblEinfuegen);
            this.Controls.Add(this.CmdAllesLoeschen);
            this.Controls.Add(this.CmdErsetzen);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.CmdEinfuegen);
            this.Name = "Form1";
            this.Text = "Listenfeld-Methoden";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdEinfuegen;
        private System.Windows.Forms.Button CmdLoeschen;
        private System.Windows.Forms.Button CmdErsetzen;
        private System.Windows.Forms.Button CmdAllesLoeschen;
        private System.Windows.Forms.Label LblEinfuegen;
        private System.Windows.Forms.Label LblAusgewaehltesElement;
        private System.Windows.Forms.Label LblEinfuegeort;
        private System.Windows.Forms.TextBox TxtNeu;
        private System.Windows.Forms.TextBox TxtErsetzen;
        private System.Windows.Forms.ListBox LstSpeisen;
        private System.Windows.Forms.RadioButton OptAnfang;
        private System.Windows.Forms.RadioButton OptAuswahl;
        private System.Windows.Forms.RadioButton OptEnde;
        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

