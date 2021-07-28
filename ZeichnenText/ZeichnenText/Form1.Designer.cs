namespace ZeichnenText
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
            this.CmdAnzeigen = new System.Windows.Forms.Button();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.LstSchriftart = new System.Windows.Forms.ListBox();
            this.LstFarbe = new System.Windows.Forms.ListBox();
            this.NumSchriftgroesse = new System.Windows.Forms.NumericUpDown();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumSchriftgroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAnzeigen
            // 
            this.CmdAnzeigen.Location = new System.Drawing.Point(690, 39);
            this.CmdAnzeigen.Name = "CmdAnzeigen";
            this.CmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen.TabIndex = 0;
            this.CmdAnzeigen.Text = "Anzeigen";
            this.CmdAnzeigen.UseVisualStyleBackColor = true;
            this.CmdAnzeigen.Click += new System.EventHandler(this.CmdAnzeigen_Click);
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(690, 391);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 1;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // LstSchriftart
            // 
            this.LstSchriftart.FormattingEnabled = true;
            this.LstSchriftart.ItemHeight = 25;
            this.LstSchriftart.Location = new System.Drawing.Point(645, 88);
            this.LstSchriftart.Name = "LstSchriftart";
            this.LstSchriftart.Size = new System.Drawing.Size(120, 79);
            this.LstSchriftart.TabIndex = 2;
            this.LstSchriftart.SelectedIndexChanged += new System.EventHandler(this.LstSchriftart_SelectedIndexChanged);
            // 
            // LstFarbe
            // 
            this.LstFarbe.FormattingEnabled = true;
            this.LstFarbe.ItemHeight = 25;
            this.LstFarbe.Location = new System.Drawing.Point(645, 290);
            this.LstFarbe.Name = "LstFarbe";
            this.LstFarbe.Size = new System.Drawing.Size(120, 79);
            this.LstFarbe.TabIndex = 3;
            this.LstFarbe.SelectedIndexChanged += new System.EventHandler(this.LstFarbe_SelectedIndexChanged);
            // 
            // NumSchriftgroesse
            // 
            this.NumSchriftgroesse.Location = new System.Drawing.Point(645, 216);
            this.NumSchriftgroesse.Name = "NumSchriftgroesse";
            this.NumSchriftgroesse.Size = new System.Drawing.Size(120, 31);
            this.NumSchriftgroesse.TabIndex = 4;
            this.NumSchriftgroesse.ValueChanged += new System.EventHandler(this.NumSchriftgroesse_ValueChanged);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(40, 383);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.NumSchriftgroesse);
            this.Controls.Add(this.LstFarbe);
            this.Controls.Add(this.LstSchriftart);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.CmdAnzeigen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumSchriftgroesse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAnzeigen;
        private System.Windows.Forms.Button CmdLoeschen;
        private System.Windows.Forms.ListBox LstSchriftart;
        private System.Windows.Forms.ListBox LstFarbe;
        private System.Windows.Forms.NumericUpDown NumSchriftgroesse;
        private System.Windows.Forms.TextBox TxtEingabe;
    }
}

