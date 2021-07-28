namespace DateiVerzeichnisListe
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
            this.CmdDateiListe = new System.Windows.Forms.Button();
            this.LblAktuellesVerzeichnis = new System.Windows.Forms.Label();
            this.LstAnzeige = new System.Windows.Forms.ListBox();
            this.CmdSystemeintraege = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdNachOben = new System.Windows.Forms.Button();
            this.CmdInVerzeichnis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdDateiListe
            // 
            this.CmdDateiListe.Location = new System.Drawing.Point(44, 55);
            this.CmdDateiListe.Name = "CmdDateiListe";
            this.CmdDateiListe.Size = new System.Drawing.Size(100, 23);
            this.CmdDateiListe.TabIndex = 0;
            this.CmdDateiListe.Text = "Dateiliste";
            this.CmdDateiListe.UseVisualStyleBackColor = true;
            this.CmdDateiListe.Click += new System.EventHandler(this.CmdDateiListe_Click);
            // 
            // LblAktuellesVerzeichnis
            // 
            this.LblAktuellesVerzeichnis.AutoSize = true;
            this.LblAktuellesVerzeichnis.Location = new System.Drawing.Point(39, 128);
            this.LblAktuellesVerzeichnis.Name = "LblAktuellesVerzeichnis";
            this.LblAktuellesVerzeichnis.Size = new System.Drawing.Size(70, 25);
            this.LblAktuellesVerzeichnis.TabIndex = 1;
            this.LblAktuellesVerzeichnis.Text = "label1";
            // 
            // LstAnzeige
            // 
            this.LstAnzeige.FormattingEnabled = true;
            this.LstAnzeige.ItemHeight = 25;
            this.LstAnzeige.Location = new System.Drawing.Point(44, 187);
            this.LstAnzeige.Name = "LstAnzeige";
            this.LstAnzeige.Size = new System.Drawing.Size(541, 229);
            this.LstAnzeige.TabIndex = 2;
            this.LstAnzeige.SelectedIndexChanged += new System.EventHandler(this.LstAnzeige_SelectedIndexChanged);
            // 
            // CmdSystemeintraege
            // 
            this.CmdSystemeintraege.Location = new System.Drawing.Point(160, 55);
            this.CmdSystemeintraege.Name = "CmdSystemeintraege";
            this.CmdSystemeintraege.Size = new System.Drawing.Size(100, 23);
            this.CmdSystemeintraege.TabIndex = 3;
            this.CmdSystemeintraege.Text = "Systemeinträge";
            this.CmdSystemeintraege.UseVisualStyleBackColor = true;
            this.CmdSystemeintraege.Click += new System.EventHandler(this.CmdSystemeintraege_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(39, 419);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 4;
            this.LblAnzeige.Text = "label1";
            // 
            // CmdNachOben
            // 
            this.CmdNachOben.Location = new System.Drawing.Point(485, 55);
            this.CmdNachOben.Name = "CmdNachOben";
            this.CmdNachOben.Size = new System.Drawing.Size(100, 23);
            this.CmdNachOben.TabIndex = 5;
            this.CmdNachOben.Text = "nach oben";
            this.CmdNachOben.UseVisualStyleBackColor = true;
            this.CmdNachOben.Click += new System.EventHandler(this.CmdNachOben_Click);
            // 
            // CmdInVerzeichnis
            // 
            this.CmdInVerzeichnis.Location = new System.Drawing.Point(363, 55);
            this.CmdInVerzeichnis.Name = "CmdInVerzeichnis";
            this.CmdInVerzeichnis.Size = new System.Drawing.Size(100, 23);
            this.CmdInVerzeichnis.TabIndex = 6;
            this.CmdInVerzeichnis.Text = "in Verzeichnis";
            this.CmdInVerzeichnis.UseVisualStyleBackColor = true;
            this.CmdInVerzeichnis.Click += new System.EventHandler(this.CmdInVerzeichnis_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(646, 509);
            this.Controls.Add(this.CmdInVerzeichnis);
            this.Controls.Add(this.CmdNachOben);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdSystemeintraege);
            this.Controls.Add(this.LstAnzeige);
            this.Controls.Add(this.LblAktuellesVerzeichnis);
            this.Controls.Add(this.CmdDateiListe);
            this.Name = "Form1";
            this.Text = "Datei- und Verzeichnisliste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdDateiListe;
        private System.Windows.Forms.Label LblAktuellesVerzeichnis;
        private System.Windows.Forms.ListBox LstAnzeige;
        private System.Windows.Forms.Button CmdSystemeintraege;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdNachOben;
        private System.Windows.Forms.Button CmdInVerzeichnis;
    }
}

