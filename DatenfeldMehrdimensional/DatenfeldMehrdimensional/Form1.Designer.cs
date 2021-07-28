namespace DatenfeldMehrdimensional
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
            this.CmdInitialisieren = new System.Windows.Forms.Button();
            this.LstSpalte0 = new System.Windows.Forms.ListBox();
            this.LstSpalte1 = new System.Windows.Forms.ListBox();
            this.LstSpalte2 = new System.Windows.Forms.ListBox();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(415, 60);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 0;
            this.CmdAnzeige.Text = "Anzeigen";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // CmdInitialisieren
            // 
            this.CmdInitialisieren.Location = new System.Drawing.Point(415, 89);
            this.CmdInitialisieren.Name = "CmdInitialisieren";
            this.CmdInitialisieren.Size = new System.Drawing.Size(75, 23);
            this.CmdInitialisieren.TabIndex = 1;
            this.CmdInitialisieren.Text = "Initialisieren";
            this.CmdInitialisieren.UseVisualStyleBackColor = true;
            // 
            // LstSpalte0
            // 
            this.LstSpalte0.FormattingEnabled = true;
            this.LstSpalte0.ItemHeight = 25;
            this.LstSpalte0.Location = new System.Drawing.Point(37, 60);
            this.LstSpalte0.Name = "LstSpalte0";
            this.LstSpalte0.Size = new System.Drawing.Size(120, 79);
            this.LstSpalte0.TabIndex = 2;
            this.LstSpalte0.Click += new System.EventHandler(this.LstSpalte_Click);
            // 
            // LstSpalte1
            // 
            this.LstSpalte1.FormattingEnabled = true;
            this.LstSpalte1.ItemHeight = 25;
            this.LstSpalte1.Location = new System.Drawing.Point(163, 60);
            this.LstSpalte1.Name = "LstSpalte1";
            this.LstSpalte1.Size = new System.Drawing.Size(120, 79);
            this.LstSpalte1.TabIndex = 3;
            this.LstSpalte1.Click += new System.EventHandler(this.LstSpalte_Click);
            // 
            // LstSpalte2
            // 
            this.LstSpalte2.FormattingEnabled = true;
            this.LstSpalte2.ItemHeight = 25;
            this.LstSpalte2.Location = new System.Drawing.Point(289, 60);
            this.LstSpalte2.Name = "LstSpalte2";
            this.LstSpalte2.Size = new System.Drawing.Size(120, 79);
            this.LstSpalte2.TabIndex = 4;
            this.LstSpalte2.Click += new System.EventHandler(this.LstSpalte_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(410, 190);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 5;
            this.LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(539, 303);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.LstSpalte2);
            this.Controls.Add(this.LstSpalte1);
            this.Controls.Add(this.LstSpalte0);
            this.Controls.Add(this.CmdInitialisieren);
            this.Controls.Add(this.CmdAnzeige);
            this.Name = "Form1";
            this.Text = "Datenfeld Mehrdimensional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.Button CmdInitialisieren;
        private System.Windows.Forms.ListBox LstSpalte0;
        private System.Windows.Forms.ListBox LstSpalte1;
        private System.Windows.Forms.ListBox LstSpalte2;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

