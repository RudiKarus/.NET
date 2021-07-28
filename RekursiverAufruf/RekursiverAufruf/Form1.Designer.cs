namespace RekursiverAufruf
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
            this.CmdSchleife = new System.Windows.Forms.Button();
            this.CmdRekursion = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdSchleife
            // 
            this.CmdSchleife.Location = new System.Drawing.Point(335, 50);
            this.CmdSchleife.Name = "CmdSchleife";
            this.CmdSchleife.Size = new System.Drawing.Size(75, 23);
            this.CmdSchleife.TabIndex = 0;
            this.CmdSchleife.Text = "Schleife";
            this.CmdSchleife.UseVisualStyleBackColor = true;
            this.CmdSchleife.Click += new System.EventHandler(this.CmdSchleife_Click);
            // 
            // CmdRekursion
            // 
            this.CmdRekursion.Location = new System.Drawing.Point(335, 79);
            this.CmdRekursion.Name = "CmdRekursion";
            this.CmdRekursion.Size = new System.Drawing.Size(75, 23);
            this.CmdRekursion.TabIndex = 1;
            this.CmdRekursion.Text = "Rekursion";
            this.CmdRekursion.UseVisualStyleBackColor = true;
            this.CmdRekursion.Click += new System.EventHandler(this.CmdRekursion_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(51, 48);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 2;
            this.LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(472, 422);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdRekursion);
            this.Controls.Add(this.CmdSchleife);
            this.Name = "Form1";
            this.Text = "Rekursiver Aufruf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSchleife;
        private System.Windows.Forms.Button CmdRekursion;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

