namespace ReferenzenVergleicheTypen
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
            this.CmdReferenzZuweisen = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdReferenzVergleichen = new System.Windows.Forms.Button();
            this.CmdObjekteVergleichen = new System.Windows.Forms.Button();
            this.CmdKlasseVergleichen = new System.Windows.Forms.Button();
            this.CmdKlasseErmitteln = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdReferenzZuweisen
            // 
            this.CmdReferenzZuweisen.Location = new System.Drawing.Point(12, 12);
            this.CmdReferenzZuweisen.Name = "CmdReferenzZuweisen";
            this.CmdReferenzZuweisen.Size = new System.Drawing.Size(110, 23);
            this.CmdReferenzZuweisen.TabIndex = 0;
            this.CmdReferenzZuweisen.Text = "Ref. zuweisen";
            this.CmdReferenzZuweisen.UseVisualStyleBackColor = true;
            this.CmdReferenzZuweisen.Click += new System.EventHandler(this.CmdReferenzZuweisen_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(167, 11);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 1;
            this.LblAnzeige.Text = "label1";
            // 
            // CmdReferenzVergleichen
            // 
            this.CmdReferenzVergleichen.Location = new System.Drawing.Point(12, 41);
            this.CmdReferenzVergleichen.Name = "CmdReferenzVergleichen";
            this.CmdReferenzVergleichen.Size = new System.Drawing.Size(110, 23);
            this.CmdReferenzVergleichen.TabIndex = 2;
            this.CmdReferenzVergleichen.Text = "Ref. vergleichen";
            this.CmdReferenzVergleichen.UseVisualStyleBackColor = true;
            this.CmdReferenzVergleichen.Click += new System.EventHandler(this.CmdReferenzVergleichen_Click);
            // 
            // CmdObjekteVergleichen
            // 
            this.CmdObjekteVergleichen.Location = new System.Drawing.Point(12, 82);
            this.CmdObjekteVergleichen.Name = "CmdObjekteVergleichen";
            this.CmdObjekteVergleichen.Size = new System.Drawing.Size(110, 23);
            this.CmdObjekteVergleichen.TabIndex = 3;
            this.CmdObjekteVergleichen.Text = "Obj. vergleichen";
            this.CmdObjekteVergleichen.UseVisualStyleBackColor = true;
            this.CmdObjekteVergleichen.Click += new System.EventHandler(this.CmdObjekteVergleichen_Click);
            // 
            // CmdKlasseVergleichen
            // 
            this.CmdKlasseVergleichen.Location = new System.Drawing.Point(12, 140);
            this.CmdKlasseVergleichen.Name = "CmdKlasseVergleichen";
            this.CmdKlasseVergleichen.Size = new System.Drawing.Size(110, 23);
            this.CmdKlasseVergleichen.TabIndex = 4;
            this.CmdKlasseVergleichen.Text = "Klasse vergleichen";
            this.CmdKlasseVergleichen.UseVisualStyleBackColor = true;
            this.CmdKlasseVergleichen.Click += new System.EventHandler(this.CmdKlasseVergleichen_Click);
            // 
            // CmdKlasseErmitteln
            // 
            this.CmdKlasseErmitteln.Location = new System.Drawing.Point(12, 111);
            this.CmdKlasseErmitteln.Name = "CmdKlasseErmitteln";
            this.CmdKlasseErmitteln.Size = new System.Drawing.Size(110, 23);
            this.CmdKlasseErmitteln.TabIndex = 5;
            this.CmdKlasseErmitteln.Text = "Klasse ermitteln";
            this.CmdKlasseErmitteln.UseVisualStyleBackColor = true;
            this.CmdKlasseErmitteln.Click += new System.EventHandler(this.CmdKlasseErmitteln_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(387, 168);
            this.Controls.Add(this.CmdKlasseErmitteln);
            this.Controls.Add(this.CmdKlasseVergleichen);
            this.Controls.Add(this.CmdObjekteVergleichen);
            this.Controls.Add(this.CmdReferenzVergleichen);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdReferenzZuweisen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdReferenzZuweisen;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdReferenzVergleichen;
        private System.Windows.Forms.Button CmdObjekteVergleichen;
        private System.Windows.Forms.Button CmdKlasseVergleichen;
        private System.Windows.Forms.Button CmdKlasseErmitteln;
    }
}

