namespace StringGrundlagen
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
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.CmdLaenge = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdZeichen = new System.Windows.Forms.Button();
            this.CmdTrimmen = new System.Windows.Forms.Button();
            this.CmdSplitten = new System.Windows.Forms.Button();
            this.CmdSucheEins = new System.Windows.Forms.Button();
            this.TxtSuche = new System.Windows.Forms.TextBox();
            this.CmdSucheAlle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(38, 44);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe.TabIndex = 0;
            // 
            // CmdLaenge
            // 
            this.CmdLaenge.Location = new System.Drawing.Point(187, 44);
            this.CmdLaenge.Name = "CmdLaenge";
            this.CmdLaenge.Size = new System.Drawing.Size(75, 23);
            this.CmdLaenge.TabIndex = 1;
            this.CmdLaenge.Text = "Länge";
            this.CmdLaenge.UseVisualStyleBackColor = true;
            this.CmdLaenge.Click += new System.EventHandler(this.CmdLaenge_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(38, 78);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 2;
            this.LblAnzeige.Text = "label1";
            // 
            // CmdZeichen
            // 
            this.CmdZeichen.Location = new System.Drawing.Point(187, 73);
            this.CmdZeichen.Name = "CmdZeichen";
            this.CmdZeichen.Size = new System.Drawing.Size(75, 23);
            this.CmdZeichen.TabIndex = 3;
            this.CmdZeichen.Text = "Zeichen";
            this.CmdZeichen.UseVisualStyleBackColor = true;
            this.CmdZeichen.Click += new System.EventHandler(this.CmdZeichen_Click);
            // 
            // CmdTrimmen
            // 
            this.CmdTrimmen.Location = new System.Drawing.Point(187, 102);
            this.CmdTrimmen.Name = "CmdTrimmen";
            this.CmdTrimmen.Size = new System.Drawing.Size(75, 23);
            this.CmdTrimmen.TabIndex = 4;
            this.CmdTrimmen.Text = "Trimmen";
            this.CmdTrimmen.UseVisualStyleBackColor = true;
            this.CmdTrimmen.Click += new System.EventHandler(this.CmdTrimmen_Click);
            // 
            // CmdSplitten
            // 
            this.CmdSplitten.Location = new System.Drawing.Point(187, 131);
            this.CmdSplitten.Name = "CmdSplitten";
            this.CmdSplitten.Size = new System.Drawing.Size(75, 23);
            this.CmdSplitten.TabIndex = 5;
            this.CmdSplitten.Text = "Splitten";
            this.CmdSplitten.UseVisualStyleBackColor = true;
            this.CmdSplitten.Click += new System.EventHandler(this.CmdSplitten_Click);
            // 
            // CmdSucheEins
            // 
            this.CmdSucheEins.Location = new System.Drawing.Point(187, 197);
            this.CmdSucheEins.Name = "CmdSucheEins";
            this.CmdSucheEins.Size = new System.Drawing.Size(75, 23);
            this.CmdSucheEins.TabIndex = 6;
            this.CmdSucheEins.Text = "Suche Eins";
            this.CmdSucheEins.UseVisualStyleBackColor = true;
            this.CmdSucheEins.Click += new System.EventHandler(this.CmdSucheEins_Click);
            // 
            // TxtSuche
            // 
            this.TxtSuche.Location = new System.Drawing.Point(162, 160);
            this.TxtSuche.Name = "TxtSuche";
            this.TxtSuche.Size = new System.Drawing.Size(100, 31);
            this.TxtSuche.TabIndex = 7;
            // 
            // CmdSucheAlle
            // 
            this.CmdSucheAlle.Location = new System.Drawing.Point(187, 226);
            this.CmdSucheAlle.Name = "CmdSucheAlle";
            this.CmdSucheAlle.Size = new System.Drawing.Size(75, 23);
            this.CmdSucheAlle.TabIndex = 8;
            this.CmdSucheAlle.Text = "Suche Alle";
            this.CmdSucheAlle.UseVisualStyleBackColor = true;
            this.CmdSucheAlle.Click += new System.EventHandler(this.CmdSucheAlle_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(511, 310);
            this.Controls.Add(this.CmdSucheAlle);
            this.Controls.Add(this.TxtSuche);
            this.Controls.Add(this.CmdSucheEins);
            this.Controls.Add(this.CmdSplitten);
            this.Controls.Add(this.CmdTrimmen);
            this.Controls.Add(this.CmdZeichen);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdLaenge);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Strings | Grundlagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Button CmdLaenge;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdZeichen;
        private System.Windows.Forms.Button CmdTrimmen;
        private System.Windows.Forms.Button CmdSplitten;
        private System.Windows.Forms.Button CmdSucheEins;
        private System.Windows.Forms.TextBox TxtSuche;
        private System.Windows.Forms.Button CmdSucheAlle;
    }
}

