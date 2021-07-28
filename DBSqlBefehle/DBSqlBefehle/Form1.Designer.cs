namespace DBSqlBefehle
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdFehlerEindeutigkeit = new System.Windows.Forms.Button();
            this.CmdFehlerDatum = new System.Windows.Forms.Button();
            this.CmdFehlerZeichen = new System.Windows.Forms.Button();
            this.CmdEingabeSuchzeichen = new System.Windows.Forms.Button();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.CmdOriginalwerte = new System.Windows.Forms.Button();
            this.CmdEinfuegen = new System.Windows.Forms.Button();
            this.CmdLoeschenEinzeln = new System.Windows.Forms.Button();
            this.CmdAendernEinzeln = new System.Windows.Forms.Button();
            this.CmdAendernAlle = new System.Windows.Forms.Button();
            this.CmdEingabeSuchbegriff = new System.Windows.Forms.Button();
            this.CmdSortierungNachZweiFeldern = new System.Windows.Forms.Button();
            this.CmdSortierungFallend = new System.Windows.Forms.Button();
            this.CmdEinzelnerPlatzhalter = new System.Windows.Forms.Button();
            this.CmdZeichenKommtVor = new System.Windows.Forms.Button();
            this.CmdBeginntMitZeichen = new System.Windows.Forms.Button();
            this.CmdBedingungLogisch = new System.Windows.Forms.Button();
            this.CmdBedingungZeichen = new System.Windows.Forms.Button();
            this.CmdBedingungZahl = new System.Windows.Forms.Button();
            this.LstAnzeige = new System.Windows.Forms.ListBox();
            this.CmdEinzelneFelder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdFehlerEindeutigkeit
            // 
            this.CmdFehlerEindeutigkeit.Location = new System.Drawing.Point(324, 70);
            this.CmdFehlerEindeutigkeit.Name = "CmdFehlerEindeutigkeit";
            this.CmdFehlerEindeutigkeit.Size = new System.Drawing.Size(150, 23);
            this.CmdFehlerEindeutigkeit.TabIndex = 94;
            this.CmdFehlerEindeutigkeit.Text = "Fehler Eindeutigkeit";
            this.CmdFehlerEindeutigkeit.UseVisualStyleBackColor = true;
            this.CmdFehlerEindeutigkeit.Click += new System.EventHandler(this.CmdFehlerEindeutigkeit_Click);
            // 
            // CmdFehlerDatum
            // 
            this.CmdFehlerDatum.Location = new System.Drawing.Point(324, 41);
            this.CmdFehlerDatum.Name = "CmdFehlerDatum";
            this.CmdFehlerDatum.Size = new System.Drawing.Size(150, 23);
            this.CmdFehlerDatum.TabIndex = 93;
            this.CmdFehlerDatum.Text = "Fehler Datum";
            this.CmdFehlerDatum.UseVisualStyleBackColor = true;
            this.CmdFehlerDatum.Click += new System.EventHandler(this.CmdFehlerDatum_Click);
            // 
            // CmdFehlerZeichen
            // 
            this.CmdFehlerZeichen.Location = new System.Drawing.Point(324, 14);
            this.CmdFehlerZeichen.Name = "CmdFehlerZeichen";
            this.CmdFehlerZeichen.Size = new System.Drawing.Size(150, 23);
            this.CmdFehlerZeichen.TabIndex = 92;
            this.CmdFehlerZeichen.Text = "Fehler Zeichen";
            this.CmdFehlerZeichen.UseVisualStyleBackColor = true;
            this.CmdFehlerZeichen.Click += new System.EventHandler(this.CmdFehlerZeichen_Click);
            // 
            // CmdEingabeSuchzeichen
            // 
            this.CmdEingabeSuchzeichen.Location = new System.Drawing.Point(168, 70);
            this.CmdEingabeSuchzeichen.Name = "CmdEingabeSuchzeichen";
            this.CmdEingabeSuchzeichen.Size = new System.Drawing.Size(150, 23);
            this.CmdEingabeSuchzeichen.TabIndex = 91;
            this.CmdEingabeSuchzeichen.Text = "Eingabe Suchzeichen";
            this.CmdEingabeSuchzeichen.UseVisualStyleBackColor = true;
            this.CmdEingabeSuchzeichen.Click += new System.EventHandler(this.CmdEingabeSuchzeichen_Click);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(168, 14);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(150, 20);
            this.TxtEingabe.TabIndex = 90;
            // 
            // CmdOriginalwerte
            // 
            this.CmdOriginalwerte.Location = new System.Drawing.Point(324, 244);
            this.CmdOriginalwerte.Name = "CmdOriginalwerte";
            this.CmdOriginalwerte.Size = new System.Drawing.Size(150, 23);
            this.CmdOriginalwerte.TabIndex = 89;
            this.CmdOriginalwerte.Text = "Originalwerte";
            this.CmdOriginalwerte.UseVisualStyleBackColor = true;
            this.CmdOriginalwerte.Click += new System.EventHandler(this.CmdOriginalwerte_Click);
            // 
            // CmdEinfuegen
            // 
            this.CmdEinfuegen.Location = new System.Drawing.Point(168, 215);
            this.CmdEinfuegen.Name = "CmdEinfuegen";
            this.CmdEinfuegen.Size = new System.Drawing.Size(150, 23);
            this.CmdEinfuegen.TabIndex = 88;
            this.CmdEinfuegen.Text = "Einfügen";
            this.CmdEinfuegen.UseVisualStyleBackColor = true;
            this.CmdEinfuegen.Click += new System.EventHandler(this.CmdEinfuegen_Click);
            // 
            // CmdLoeschenEinzeln
            // 
            this.CmdLoeschenEinzeln.Location = new System.Drawing.Point(168, 186);
            this.CmdLoeschenEinzeln.Name = "CmdLoeschenEinzeln";
            this.CmdLoeschenEinzeln.Size = new System.Drawing.Size(150, 23);
            this.CmdLoeschenEinzeln.TabIndex = 87;
            this.CmdLoeschenEinzeln.Text = "Löschen einzeln";
            this.CmdLoeschenEinzeln.UseVisualStyleBackColor = true;
            this.CmdLoeschenEinzeln.Click += new System.EventHandler(this.CmdLoeschenEinzeln_Click);
            // 
            // CmdAendernEinzeln
            // 
            this.CmdAendernEinzeln.Location = new System.Drawing.Point(168, 157);
            this.CmdAendernEinzeln.Name = "CmdAendernEinzeln";
            this.CmdAendernEinzeln.Size = new System.Drawing.Size(150, 23);
            this.CmdAendernEinzeln.TabIndex = 86;
            this.CmdAendernEinzeln.Text = "Ändern einzeln";
            this.CmdAendernEinzeln.UseVisualStyleBackColor = true;
            this.CmdAendernEinzeln.Click += new System.EventHandler(this.CmdAendernEinzeln_Click);
            // 
            // CmdAendernAlle
            // 
            this.CmdAendernAlle.Location = new System.Drawing.Point(168, 128);
            this.CmdAendernAlle.Name = "CmdAendernAlle";
            this.CmdAendernAlle.Size = new System.Drawing.Size(150, 23);
            this.CmdAendernAlle.TabIndex = 85;
            this.CmdAendernAlle.Text = "Ändern alle";
            this.CmdAendernAlle.UseVisualStyleBackColor = true;
            this.CmdAendernAlle.Click += new System.EventHandler(this.CmdAendernAlle_Click);
            // 
            // CmdEingabeSuchbegriff
            // 
            this.CmdEingabeSuchbegriff.Location = new System.Drawing.Point(168, 41);
            this.CmdEingabeSuchbegriff.Name = "CmdEingabeSuchbegriff";
            this.CmdEingabeSuchbegriff.Size = new System.Drawing.Size(150, 23);
            this.CmdEingabeSuchbegriff.TabIndex = 84;
            this.CmdEingabeSuchbegriff.Text = "Eingabe Suchbegriff";
            this.CmdEingabeSuchbegriff.UseVisualStyleBackColor = true;
            this.CmdEingabeSuchbegriff.Click += new System.EventHandler(this.CmdEingabeSuchbegriff_Click);
            // 
            // CmdSortierungNachZweiFeldern
            // 
            this.CmdSortierungNachZweiFeldern.Location = new System.Drawing.Point(12, 244);
            this.CmdSortierungNachZweiFeldern.Name = "CmdSortierungNachZweiFeldern";
            this.CmdSortierungNachZweiFeldern.Size = new System.Drawing.Size(150, 23);
            this.CmdSortierungNachZweiFeldern.TabIndex = 83;
            this.CmdSortierungNachZweiFeldern.Text = "Sortierung nach 2 Feldern";
            this.CmdSortierungNachZweiFeldern.UseVisualStyleBackColor = true;
            this.CmdSortierungNachZweiFeldern.Click += new System.EventHandler(this.CmdSortierungNachZweiFeldern_Click);
            // 
            // CmdSortierungFallend
            // 
            this.CmdSortierungFallend.Location = new System.Drawing.Point(12, 215);
            this.CmdSortierungFallend.Name = "CmdSortierungFallend";
            this.CmdSortierungFallend.Size = new System.Drawing.Size(150, 23);
            this.CmdSortierungFallend.TabIndex = 82;
            this.CmdSortierungFallend.Text = "Sortierung fallend";
            this.CmdSortierungFallend.UseVisualStyleBackColor = true;
            this.CmdSortierungFallend.Click += new System.EventHandler(this.CmdSortierungFallend_Click);
            // 
            // CmdEinzelnerPlatzhalter
            // 
            this.CmdEinzelnerPlatzhalter.Location = new System.Drawing.Point(12, 186);
            this.CmdEinzelnerPlatzhalter.Name = "CmdEinzelnerPlatzhalter";
            this.CmdEinzelnerPlatzhalter.Size = new System.Drawing.Size(150, 23);
            this.CmdEinzelnerPlatzhalter.TabIndex = 81;
            this.CmdEinzelnerPlatzhalter.Text = "Einzelner Platzhalter";
            this.CmdEinzelnerPlatzhalter.UseVisualStyleBackColor = true;
            this.CmdEinzelnerPlatzhalter.Click += new System.EventHandler(this.CmdEinzelnerPlatzhalter_Click);
            // 
            // CmdZeichenKommtVor
            // 
            this.CmdZeichenKommtVor.Location = new System.Drawing.Point(12, 157);
            this.CmdZeichenKommtVor.Name = "CmdZeichenKommtVor";
            this.CmdZeichenKommtVor.Size = new System.Drawing.Size(150, 23);
            this.CmdZeichenKommtVor.TabIndex = 80;
            this.CmdZeichenKommtVor.Text = "Zeichen kommt vor";
            this.CmdZeichenKommtVor.UseVisualStyleBackColor = true;
            this.CmdZeichenKommtVor.Click += new System.EventHandler(this.CmdZeichenKommtVor_Click);
            // 
            // CmdBeginntMitZeichen
            // 
            this.CmdBeginntMitZeichen.Location = new System.Drawing.Point(12, 128);
            this.CmdBeginntMitZeichen.Name = "CmdBeginntMitZeichen";
            this.CmdBeginntMitZeichen.Size = new System.Drawing.Size(150, 23);
            this.CmdBeginntMitZeichen.TabIndex = 79;
            this.CmdBeginntMitZeichen.Text = "Beginnt mit Zeichen";
            this.CmdBeginntMitZeichen.UseVisualStyleBackColor = true;
            this.CmdBeginntMitZeichen.Click += new System.EventHandler(this.CmdBeginntMitZeichen_Click);
            // 
            // CmdBedingungLogisch
            // 
            this.CmdBedingungLogisch.Location = new System.Drawing.Point(12, 99);
            this.CmdBedingungLogisch.Name = "CmdBedingungLogisch";
            this.CmdBedingungLogisch.Size = new System.Drawing.Size(150, 23);
            this.CmdBedingungLogisch.TabIndex = 78;
            this.CmdBedingungLogisch.Text = "Bedingung mit log. Operator";
            this.CmdBedingungLogisch.UseVisualStyleBackColor = true;
            this.CmdBedingungLogisch.Click += new System.EventHandler(this.CmdBedingungLogisch_Click);
            // 
            // CmdBedingungZeichen
            // 
            this.CmdBedingungZeichen.Location = new System.Drawing.Point(12, 70);
            this.CmdBedingungZeichen.Name = "CmdBedingungZeichen";
            this.CmdBedingungZeichen.Size = new System.Drawing.Size(150, 23);
            this.CmdBedingungZeichen.TabIndex = 77;
            this.CmdBedingungZeichen.Text = "Bedingung mit Zeichen";
            this.CmdBedingungZeichen.UseVisualStyleBackColor = true;
            this.CmdBedingungZeichen.Click += new System.EventHandler(this.CmdBedingungZeichen_Click);
            // 
            // CmdBedingungZahl
            // 
            this.CmdBedingungZahl.Location = new System.Drawing.Point(12, 41);
            this.CmdBedingungZahl.Name = "CmdBedingungZahl";
            this.CmdBedingungZahl.Size = new System.Drawing.Size(150, 23);
            this.CmdBedingungZahl.TabIndex = 76;
            this.CmdBedingungZahl.Text = "Bedingung mit Zahl";
            this.CmdBedingungZahl.UseVisualStyleBackColor = true;
            this.CmdBedingungZahl.Click += new System.EventHandler(this.CmdBedingungZahl_Click);
            // 
            // LstAnzeige
            // 
            this.LstAnzeige.FormattingEnabled = true;
            this.LstAnzeige.Location = new System.Drawing.Point(12, 302);
            this.LstAnzeige.Name = "LstAnzeige";
            this.LstAnzeige.Size = new System.Drawing.Size(306, 95);
            this.LstAnzeige.TabIndex = 75;
            // 
            // CmdEinzelneFelder
            // 
            this.CmdEinzelneFelder.Location = new System.Drawing.Point(12, 12);
            this.CmdEinzelneFelder.Name = "CmdEinzelneFelder";
            this.CmdEinzelneFelder.Size = new System.Drawing.Size(150, 23);
            this.CmdEinzelneFelder.TabIndex = 74;
            this.CmdEinzelneFelder.Text = "Einzelne Felder";
            this.CmdEinzelneFelder.UseVisualStyleBackColor = true;
            this.CmdEinzelneFelder.Click += new System.EventHandler(this.CmdEinzelneFelder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.CmdFehlerEindeutigkeit);
            this.Controls.Add(this.CmdFehlerDatum);
            this.Controls.Add(this.CmdFehlerZeichen);
            this.Controls.Add(this.CmdEingabeSuchzeichen);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.CmdOriginalwerte);
            this.Controls.Add(this.CmdEinfuegen);
            this.Controls.Add(this.CmdLoeschenEinzeln);
            this.Controls.Add(this.CmdAendernEinzeln);
            this.Controls.Add(this.CmdAendernAlle);
            this.Controls.Add(this.CmdEingabeSuchbegriff);
            this.Controls.Add(this.CmdSortierungNachZweiFeldern);
            this.Controls.Add(this.CmdSortierungFallend);
            this.Controls.Add(this.CmdEinzelnerPlatzhalter);
            this.Controls.Add(this.CmdZeichenKommtVor);
            this.Controls.Add(this.CmdBeginntMitZeichen);
            this.Controls.Add(this.CmdBedingungLogisch);
            this.Controls.Add(this.CmdBedingungZeichen);
            this.Controls.Add(this.CmdBedingungZahl);
            this.Controls.Add(this.LstAnzeige);
            this.Controls.Add(this.CmdEinzelneFelder);
            this.Name = "Form1";
            this.Text = "Datenbanken, SQL-Befehle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdFehlerEindeutigkeit;
        internal System.Windows.Forms.Button CmdFehlerDatum;
        internal System.Windows.Forms.Button CmdFehlerZeichen;
        internal System.Windows.Forms.Button CmdEingabeSuchzeichen;
        internal System.Windows.Forms.TextBox TxtEingabe;
        internal System.Windows.Forms.Button CmdOriginalwerte;
        internal System.Windows.Forms.Button CmdEinfuegen;
        internal System.Windows.Forms.Button CmdLoeschenEinzeln;
        internal System.Windows.Forms.Button CmdAendernEinzeln;
        internal System.Windows.Forms.Button CmdAendernAlle;
        internal System.Windows.Forms.Button CmdEingabeSuchbegriff;
        internal System.Windows.Forms.Button CmdSortierungNachZweiFeldern;
        internal System.Windows.Forms.Button CmdSortierungFallend;
        internal System.Windows.Forms.Button CmdEinzelnerPlatzhalter;
        internal System.Windows.Forms.Button CmdZeichenKommtVor;
        internal System.Windows.Forms.Button CmdBeginntMitZeichen;
        internal System.Windows.Forms.Button CmdBedingungLogisch;
        internal System.Windows.Forms.Button CmdBedingungZeichen;
        internal System.Windows.Forms.Button CmdBedingungZahl;
        internal System.Windows.Forms.ListBox LstAnzeige;
        internal System.Windows.Forms.Button CmdEinzelneFelder;
    }
}

