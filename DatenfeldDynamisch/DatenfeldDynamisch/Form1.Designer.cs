namespace DatenfeldDynamisch
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
            this.CmdOriginal = new System.Windows.Forms.Button();
            this.CmdNeu1 = new System.Windows.Forms.Button();
            this.LstFeld = new System.Windows.Forms.ListBox();
            this.CmdNeu2 = new System.Windows.Forms.Button();
            this.NumGroesse = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumGroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdOriginal
            // 
            this.CmdOriginal.Location = new System.Drawing.Point(202, 103);
            this.CmdOriginal.Name = "CmdOriginal";
            this.CmdOriginal.Size = new System.Drawing.Size(75, 23);
            this.CmdOriginal.TabIndex = 0;
            this.CmdOriginal.Text = "Feld original";
            this.CmdOriginal.UseVisualStyleBackColor = true;
            this.CmdOriginal.Click += new System.EventHandler(this.CmdOriginal_Click);
            // 
            // CmdNeu1
            // 
            this.CmdNeu1.Location = new System.Drawing.Point(202, 132);
            this.CmdNeu1.Name = "CmdNeu1";
            this.CmdNeu1.Size = new System.Drawing.Size(75, 23);
            this.CmdNeu1.TabIndex = 1;
            this.CmdNeu1.Text = "Feld neu 1";
            this.CmdNeu1.UseVisualStyleBackColor = true;
            this.CmdNeu1.Click += new System.EventHandler(this.CmdNeu1_Click);
            // 
            // LstFeld
            // 
            this.LstFeld.FormattingEnabled = true;
            this.LstFeld.ItemHeight = 25;
            this.LstFeld.Location = new System.Drawing.Point(46, 103);
            this.LstFeld.Name = "LstFeld";
            this.LstFeld.Size = new System.Drawing.Size(120, 179);
            this.LstFeld.TabIndex = 2;
            // 
            // CmdNeu2
            // 
            this.CmdNeu2.Location = new System.Drawing.Point(283, 132);
            this.CmdNeu2.Name = "CmdNeu2";
            this.CmdNeu2.Size = new System.Drawing.Size(75, 23);
            this.CmdNeu2.TabIndex = 3;
            this.CmdNeu2.Text = "Feld neu 2";
            this.CmdNeu2.UseVisualStyleBackColor = true;
            this.CmdNeu2.Click += new System.EventHandler(this.CmdNeu2_Click);
            // 
            // NumGroesse
            // 
            this.NumGroesse.Location = new System.Drawing.Point(283, 161);
            this.NumGroesse.Name = "NumGroesse";
            this.NumGroesse.Size = new System.Drawing.Size(120, 31);
            this.NumGroesse.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(536, 441);
            this.Controls.Add(this.NumGroesse);
            this.Controls.Add(this.CmdNeu2);
            this.Controls.Add(this.LstFeld);
            this.Controls.Add(this.CmdNeu1);
            this.Controls.Add(this.CmdOriginal);
            this.Name = "Form1";
            this.Text = "Datenfeld dynamisch";
            ((System.ComponentModel.ISupportInitialize)(this.NumGroesse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdOriginal;
        private System.Windows.Forms.Button CmdNeu1;
        private System.Windows.Forms.ListBox LstFeld;
        private System.Windows.Forms.Button CmdNeu2;
        private System.Windows.Forms.NumericUpDown NumGroesse;
    }
}

