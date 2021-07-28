namespace DateiSicherLesen
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
            this.CmdExistenz = new System.Windows.Forms.Button();
            this.CmdAusnahme = new System.Windows.Forms.Button();
            this.CmdPfad = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdExistenz
            // 
            this.CmdExistenz.Location = new System.Drawing.Point(31, 30);
            this.CmdExistenz.Name = "CmdExistenz";
            this.CmdExistenz.Size = new System.Drawing.Size(140, 37);
            this.CmdExistenz.TabIndex = 0;
            this.CmdExistenz.Text = "Existenz";
            this.CmdExistenz.UseVisualStyleBackColor = true;
            this.CmdExistenz.Click += new System.EventHandler(this.CmdExistenz_Click);
            // 
            // CmdAusnahme
            // 
            this.CmdAusnahme.Location = new System.Drawing.Point(31, 73);
            this.CmdAusnahme.Name = "CmdAusnahme";
            this.CmdAusnahme.Size = new System.Drawing.Size(140, 37);
            this.CmdAusnahme.TabIndex = 1;
            this.CmdAusnahme.Text = "Ausnahme";
            this.CmdAusnahme.UseVisualStyleBackColor = true;
            this.CmdAusnahme.Click += new System.EventHandler(this.CmdAusnahme_Click);
            // 
            // CmdPfad
            // 
            this.CmdPfad.Location = new System.Drawing.Point(31, 116);
            this.CmdPfad.Name = "CmdPfad";
            this.CmdPfad.Size = new System.Drawing.Size(140, 37);
            this.CmdPfad.TabIndex = 2;
            this.CmdPfad.Text = "Pfad";
            this.CmdPfad.UseVisualStyleBackColor = true;
            this.CmdPfad.Click += new System.EventHandler(this.CmdPfad_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(44, 179);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 3;
            this.LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 410);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdPfad);
            this.Controls.Add(this.CmdAusnahme);
            this.Controls.Add(this.CmdExistenz);
            this.Name = "Form1";
            this.Text = "Datei sicher lesen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdExistenz;
        private System.Windows.Forms.Button CmdAusnahme;
        private System.Windows.Forms.Button CmdPfad;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

