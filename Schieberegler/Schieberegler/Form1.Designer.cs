namespace Schieberegler
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
            this.LblRot = new System.Windows.Forms.Label();
            this.LblGruen = new System.Windows.Forms.Label();
            this.LblBlau = new System.Windows.Forms.Label();
            this.PanFarbe = new System.Windows.Forms.Panel();
            this.TrkRot = new System.Windows.Forms.TrackBar();
            this.TrkGruen = new System.Windows.Forms.TrackBar();
            this.TrkBlue = new System.Windows.Forms.TrackBar();
            this.LblRotWert = new System.Windows.Forms.Label();
            this.LblGruenWert = new System.Windows.Forms.Label();
            this.LblBlauWert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrkRot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkGruen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRot
            // 
            this.LblRot.AutoSize = true;
            this.LblRot.Location = new System.Drawing.Point(358, 106);
            this.LblRot.Name = "LblRot";
            this.LblRot.Size = new System.Drawing.Size(45, 25);
            this.LblRot.TabIndex = 0;
            this.LblRot.Text = "Rot";
            // 
            // LblGruen
            // 
            this.LblGruen.AutoSize = true;
            this.LblGruen.Location = new System.Drawing.Point(358, 202);
            this.LblGruen.Name = "LblGruen";
            this.LblGruen.Size = new System.Drawing.Size(59, 25);
            this.LblGruen.TabIndex = 1;
            this.LblGruen.Text = "Grün";
            // 
            // LblBlau
            // 
            this.LblBlau.AutoSize = true;
            this.LblBlau.Location = new System.Drawing.Point(358, 298);
            this.LblBlau.Name = "LblBlau";
            this.LblBlau.Size = new System.Drawing.Size(55, 25);
            this.LblBlau.TabIndex = 2;
            this.LblBlau.Text = "Blau";
            // 
            // PanFarbe
            // 
            this.PanFarbe.Location = new System.Drawing.Point(442, 106);
            this.PanFarbe.Name = "PanFarbe";
            this.PanFarbe.Size = new System.Drawing.Size(298, 282);
            this.PanFarbe.TabIndex = 3;
            // 
            // TrkRot
            // 
            this.TrkRot.LargeChange = 20;
            this.TrkRot.Location = new System.Drawing.Point(97, 106);
            this.TrkRot.Maximum = 255;
            this.TrkRot.Name = "TrkRot";
            this.TrkRot.Size = new System.Drawing.Size(255, 90);
            this.TrkRot.SmallChange = 5;
            this.TrkRot.TabIndex = 0;
            this.TrkRot.TickFrequency = 5;
            this.TrkRot.Scroll += new System.EventHandler(this.TrkRot_Scroll);
            this.TrkRot.ValueChanged += new System.EventHandler(this.Schieberegler);
            // 
            // TrkGruen
            // 
            this.TrkGruen.LargeChange = 20;
            this.TrkGruen.Location = new System.Drawing.Point(97, 202);
            this.TrkGruen.Maximum = 255;
            this.TrkGruen.Name = "TrkGruen";
            this.TrkGruen.Size = new System.Drawing.Size(255, 90);
            this.TrkGruen.SmallChange = 5;
            this.TrkGruen.TabIndex = 1;
            this.TrkGruen.TickFrequency = 5;
            this.TrkGruen.Scroll += new System.EventHandler(this.TrkGruen_Scroll);
            this.TrkGruen.ValueChanged += new System.EventHandler(this.Schieberegler);
            // 
            // TrkBlue
            // 
            this.TrkBlue.LargeChange = 20;
            this.TrkBlue.Location = new System.Drawing.Point(97, 298);
            this.TrkBlue.Maximum = 255;
            this.TrkBlue.Name = "TrkBlue";
            this.TrkBlue.Size = new System.Drawing.Size(255, 90);
            this.TrkBlue.SmallChange = 5;
            this.TrkBlue.TabIndex = 2;
            this.TrkBlue.TickFrequency = 5;
            this.TrkBlue.Scroll += new System.EventHandler(this.TrkBlue_Scroll);
            this.TrkBlue.ValueChanged += new System.EventHandler(this.Schieberegler);
            // 
            // LblRotWert
            // 
            this.LblRotWert.AutoSize = true;
            this.LblRotWert.Location = new System.Drawing.Point(358, 140);
            this.LblRotWert.Name = "LblRotWert";
            this.LblRotWert.Size = new System.Drawing.Size(0, 25);
            this.LblRotWert.TabIndex = 4;
            // 
            // LblGruenWert
            // 
            this.LblGruenWert.AutoSize = true;
            this.LblGruenWert.Location = new System.Drawing.Point(358, 227);
            this.LblGruenWert.Name = "LblGruenWert";
            this.LblGruenWert.Size = new System.Drawing.Size(0, 25);
            this.LblGruenWert.TabIndex = 5;
            // 
            // LblBlauWert
            // 
            this.LblBlauWert.AutoSize = true;
            this.LblBlauWert.Location = new System.Drawing.Point(358, 329);
            this.LblBlauWert.Name = "LblBlauWert";
            this.LblBlauWert.Size = new System.Drawing.Size(0, 25);
            this.LblBlauWert.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblBlauWert);
            this.Controls.Add(this.LblGruenWert);
            this.Controls.Add(this.LblRotWert);
            this.Controls.Add(this.TrkRot);
            this.Controls.Add(this.TrkGruen);
            this.Controls.Add(this.PanFarbe);
            this.Controls.Add(this.LblBlau);
            this.Controls.Add(this.LblGruen);
            this.Controls.Add(this.LblRot);
            this.Controls.Add(this.TrkBlue);
            this.Name = "Form1";
            this.Text = "Schieberegler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrkRot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkGruen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRot;
        private System.Windows.Forms.Label LblGruen;
        private System.Windows.Forms.Label LblBlau;
        private System.Windows.Forms.Panel PanFarbe;
        private System.Windows.Forms.TrackBar TrkRot;
        private System.Windows.Forms.TrackBar TrkGruen;
        private System.Windows.Forms.TrackBar TrkBlue;
        private System.Windows.Forms.Label LblRotWert;
        private System.Windows.Forms.Label LblGruenWert;
        private System.Windows.Forms.Label LblBlauWert;
    }
}

