namespace StringLoeschen
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
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.NumAnzahl = new System.Windows.Forms.NumericUpDown();
            this.NumPosition = new System.Windows.Forms.NumericUpDown();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumAnzahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(117, 51);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe.TabIndex = 0;
            this.TxtEingabe.TextChanged += new System.EventHandler(this.TxtEingabe_TextChanged);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(122, 98);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 1;
            this.LblAnzeige.Text = "label1";
            // 
            // NumAnzahl
            // 
            this.NumAnzahl.Location = new System.Drawing.Point(117, 178);
            this.NumAnzahl.Name = "NumAnzahl";
            this.NumAnzahl.Size = new System.Drawing.Size(120, 31);
            this.NumAnzahl.TabIndex = 2;
            // 
            // NumPosition
            // 
            this.NumPosition.Location = new System.Drawing.Point(117, 249);
            this.NumPosition.Name = "NumPosition";
            this.NumPosition.Size = new System.Drawing.Size(120, 31);
            this.NumPosition.TabIndex = 3;
            this.NumPosition.ValueChanged += new System.EventHandler(this.NumPosition_ValueChanged);
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(117, 299);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 4;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lösche";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ab Position";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.NumPosition);
            this.Controls.Add(this.NumAnzahl);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Strings | Löschen";
            ((System.ComponentModel.ISupportInitialize)(this.NumAnzahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.NumericUpDown NumAnzahl;
        private System.Windows.Forms.NumericUpDown NumPosition;
        private System.Windows.Forms.Button CmdLoeschen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

