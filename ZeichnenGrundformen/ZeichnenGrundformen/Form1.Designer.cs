namespace ZeichnenGrundformen
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
            this.LstColor = new System.Windows.Forms.ListBox();
            this.CmdLinie = new System.Windows.Forms.Button();
            this.CmdRechteck = new System.Windows.Forms.Button();
            this.CmdPolygon = new System.Windows.Forms.Button();
            this.CmdEllipse = new System.Windows.Forms.Button();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.NumPenWidth = new System.Windows.Forms.NumericUpDown();
            this.ChkFuellen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // LstColor
            // 
            this.LstColor.FormattingEnabled = true;
            this.LstColor.ItemHeight = 25;
            this.LstColor.Location = new System.Drawing.Point(443, 303);
            this.LstColor.Name = "LstColor";
            this.LstColor.Size = new System.Drawing.Size(120, 79);
            this.LstColor.TabIndex = 0;
            this.LstColor.SelectedIndexChanged += new System.EventHandler(this.LstColor_SelectedIndexChanged);
            // 
            // CmdLinie
            // 
            this.CmdLinie.Location = new System.Drawing.Point(488, 47);
            this.CmdLinie.Name = "CmdLinie";
            this.CmdLinie.Size = new System.Drawing.Size(75, 23);
            this.CmdLinie.TabIndex = 1;
            this.CmdLinie.Text = "Linie";
            this.CmdLinie.UseVisualStyleBackColor = true;
            this.CmdLinie.Click += new System.EventHandler(this.CmdLinie_Click);
            // 
            // CmdRechteck
            // 
            this.CmdRechteck.Location = new System.Drawing.Point(488, 76);
            this.CmdRechteck.Name = "CmdRechteck";
            this.CmdRechteck.Size = new System.Drawing.Size(75, 23);
            this.CmdRechteck.TabIndex = 2;
            this.CmdRechteck.Text = "Rechteck";
            this.CmdRechteck.UseVisualStyleBackColor = true;
            this.CmdRechteck.Click += new System.EventHandler(this.CmdRechteck_Click);
            // 
            // CmdPolygon
            // 
            this.CmdPolygon.Location = new System.Drawing.Point(488, 105);
            this.CmdPolygon.Name = "CmdPolygon";
            this.CmdPolygon.Size = new System.Drawing.Size(75, 23);
            this.CmdPolygon.TabIndex = 3;
            this.CmdPolygon.Text = "Polygon";
            this.CmdPolygon.UseVisualStyleBackColor = true;
            this.CmdPolygon.Click += new System.EventHandler(this.CmdPolygon_Click);
            // 
            // CmdEllipse
            // 
            this.CmdEllipse.Location = new System.Drawing.Point(488, 134);
            this.CmdEllipse.Name = "CmdEllipse";
            this.CmdEllipse.Size = new System.Drawing.Size(75, 23);
            this.CmdEllipse.TabIndex = 4;
            this.CmdEllipse.Text = "Ellipse";
            this.CmdEllipse.UseVisualStyleBackColor = true;
            this.CmdEllipse.Click += new System.EventHandler(this.CmdEllipse_Click);
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(488, 397);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 5;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // NumPenWidth
            // 
            this.NumPenWidth.Location = new System.Drawing.Point(443, 229);
            this.NumPenWidth.Name = "NumPenWidth";
            this.NumPenWidth.Size = new System.Drawing.Size(120, 31);
            this.NumPenWidth.TabIndex = 6;
            this.NumPenWidth.ValueChanged += new System.EventHandler(this.NumPenWidth_ValueChanged);
            // 
            // ChkFuellen
            // 
            this.ChkFuellen.AutoSize = true;
            this.ChkFuellen.Location = new System.Drawing.Point(26, 395);
            this.ChkFuellen.Name = "ChkFuellen";
            this.ChkFuellen.Size = new System.Drawing.Size(103, 29);
            this.ChkFuellen.TabIndex = 7;
            this.ChkFuellen.Text = "Füllen";
            this.ChkFuellen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.ChkFuellen);
            this.Controls.Add(this.NumPenWidth);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.CmdEllipse);
            this.Controls.Add(this.CmdPolygon);
            this.Controls.Add(this.CmdRechteck);
            this.Controls.Add(this.CmdLinie);
            this.Controls.Add(this.LstColor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumPenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstColor;
        private System.Windows.Forms.Button CmdLinie;
        private System.Windows.Forms.Button CmdRechteck;
        private System.Windows.Forms.Button CmdPolygon;
        private System.Windows.Forms.Button CmdEllipse;
        private System.Windows.Forms.Button CmdLoeschen;
        private System.Windows.Forms.NumericUpDown NumPenWidth;
        private System.Windows.Forms.CheckBox ChkFuellen;
    }
}

