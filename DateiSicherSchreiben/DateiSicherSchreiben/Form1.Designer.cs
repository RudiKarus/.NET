namespace DateiSicherSchreiben
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
            this.CmdAusnahme = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdAusnahme
            // 
            this.CmdAusnahme.Location = new System.Drawing.Point(259, 39);
            this.CmdAusnahme.Name = "CmdAusnahme";
            this.CmdAusnahme.Size = new System.Drawing.Size(142, 36);
            this.CmdAusnahme.TabIndex = 0;
            this.CmdAusnahme.Text = "Ausnahme";
            this.CmdAusnahme.UseVisualStyleBackColor = true;
            this.CmdAusnahme.Click += new System.EventHandler(this.CmdAusnahme_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(186, 103);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 1;
            this.LblAnzeige.Text = "label1";
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(38, 42);
            this.TxtEingabe.Multiline = true;
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(140, 31);
            this.TxtEingabe.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 270);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAusnahme);
            this.Name = "Form1";
            this.Text = "Datei sicher schreiben";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAusnahme;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.TextBox TxtEingabe;
    }
}

