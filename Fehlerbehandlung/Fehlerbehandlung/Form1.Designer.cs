namespace Fehlerbehandlung
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
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.LblAnzeigen = new System.Windows.Forms.Label();
            this.TxtEingabe1 = new System.Windows.Forms.TextBox();
            this.TxtEingabe2 = new System.Windows.Forms.TextBox();
            this.CmdRechnen = new System.Windows.Forms.Button();
            this.LblErgebnis1 = new System.Windows.Forms.Label();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(200, 56);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 0;
            this.CmdAnzeige.Text = "Anzeige";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // LblAnzeigen
            // 
            this.LblAnzeigen.AutoSize = true;
            this.LblAnzeigen.Location = new System.Drawing.Point(302, 58);
            this.LblAnzeigen.Name = "LblAnzeigen";
            this.LblAnzeigen.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeigen.TabIndex = 1;
            this.LblAnzeigen.Text = "label1";
            // 
            // TxtEingabe1
            // 
            this.TxtEingabe1.Location = new System.Drawing.Point(77, 56);
            this.TxtEingabe1.Name = "TxtEingabe1";
            this.TxtEingabe1.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe1.TabIndex = 2;
            // 
            // TxtEingabe2
            // 
            this.TxtEingabe2.Location = new System.Drawing.Point(77, 93);
            this.TxtEingabe2.Name = "TxtEingabe2";
            this.TxtEingabe2.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe2.TabIndex = 3;
            // 
            // CmdRechnen
            // 
            this.CmdRechnen.Location = new System.Drawing.Point(200, 93);
            this.CmdRechnen.Name = "CmdRechnen";
            this.CmdRechnen.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen.TabIndex = 4;
            this.CmdRechnen.Text = "Rechnen";
            this.CmdRechnen.UseVisualStyleBackColor = true;
            this.CmdRechnen.Click += new System.EventHandler(this.CmdRechnen_Click);
            // 
            // LblErgebnis1
            // 
            this.LblErgebnis1.AutoSize = true;
            this.LblErgebnis1.Location = new System.Drawing.Point(72, 141);
            this.LblErgebnis1.Name = "LblErgebnis1";
            this.LblErgebnis1.Size = new System.Drawing.Size(70, 25);
            this.LblErgebnis1.TabIndex = 5;
            this.LblErgebnis1.Text = "label1";
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(72, 178);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(70, 25);
            this.LblAusgabe.TabIndex = 6;
            this.LblAusgabe.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.LblErgebnis1);
            this.Controls.Add(this.CmdRechnen);
            this.Controls.Add(this.TxtEingabe2);
            this.Controls.Add(this.TxtEingabe1);
            this.Controls.Add(this.LblAnzeigen);
            this.Controls.Add(this.CmdAnzeige);
            this.Name = "Form1";
            this.Text = "Laufzeitfehler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.Label LblAnzeigen;
        private System.Windows.Forms.TextBox TxtEingabe1;
        private System.Windows.Forms.TextBox TxtEingabe2;
        private System.Windows.Forms.Button CmdRechnen;
        private System.Windows.Forms.Label LblErgebnis1;
        private System.Windows.Forms.Label LblAusgabe;
    }
}

