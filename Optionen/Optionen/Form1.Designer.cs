namespace Optionen
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
            this.CmdPruefen = new System.Windows.Forms.Button();
            this.CmdSchalter = new System.Windows.Forms.Button();
            this.OptFarbeRot = new System.Windows.Forms.RadioButton();
            this.OptFarbeGruen = new System.Windows.Forms.RadioButton();
            this.OptFarbeBlau = new System.Windows.Forms.RadioButton();
            this.LblTest1 = new System.Windows.Forms.Label();
            this.LblTest2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdPruefen
            // 
            this.CmdPruefen.Location = new System.Drawing.Point(311, 90);
            this.CmdPruefen.Name = "CmdPruefen";
            this.CmdPruefen.Size = new System.Drawing.Size(200, 35);
            this.CmdPruefen.TabIndex = 0;
            this.CmdPruefen.Text = "Prüfen";
            this.CmdPruefen.UseVisualStyleBackColor = true;
            this.CmdPruefen.Click += new System.EventHandler(this.CmdPruefen_Click);
            // 
            // CmdSchalter
            // 
            this.CmdSchalter.Location = new System.Drawing.Point(311, 275);
            this.CmdSchalter.Name = "CmdSchalter";
            this.CmdSchalter.Size = new System.Drawing.Size(200, 35);
            this.CmdSchalter.TabIndex = 1;
            this.CmdSchalter.Text = "Rot schalten";
            this.CmdSchalter.UseVisualStyleBackColor = true;
            this.CmdSchalter.Click += new System.EventHandler(this.CmdSchalter_Click);
            // 
            // OptFarbeRot
            // 
            this.OptFarbeRot.AutoSize = true;
            this.OptFarbeRot.Location = new System.Drawing.Point(311, 150);
            this.OptFarbeRot.Name = "OptFarbeRot";
            this.OptFarbeRot.Size = new System.Drawing.Size(76, 29);
            this.OptFarbeRot.TabIndex = 2;
            this.OptFarbeRot.TabStop = true;
            this.OptFarbeRot.Text = "Rot";
            this.OptFarbeRot.UseVisualStyleBackColor = true;
            this.OptFarbeRot.CheckedChanged += new System.EventHandler(this.OptFarbe_CheckedChanged);
            // 
            // OptFarbeGruen
            // 
            this.OptFarbeGruen.AutoSize = true;
            this.OptFarbeGruen.Location = new System.Drawing.Point(311, 185);
            this.OptFarbeGruen.Name = "OptFarbeGruen";
            this.OptFarbeGruen.Size = new System.Drawing.Size(90, 29);
            this.OptFarbeGruen.TabIndex = 3;
            this.OptFarbeGruen.TabStop = true;
            this.OptFarbeGruen.Text = "Grün";
            this.OptFarbeGruen.UseVisualStyleBackColor = true;
            this.OptFarbeGruen.CheckedChanged += new System.EventHandler(this.OptFarbe_CheckedChanged);
            // 
            // OptFarbeBlau
            // 
            this.OptFarbeBlau.AutoSize = true;
            this.OptFarbeBlau.Location = new System.Drawing.Point(311, 220);
            this.OptFarbeBlau.Name = "OptFarbeBlau";
            this.OptFarbeBlau.Size = new System.Drawing.Size(86, 29);
            this.OptFarbeBlau.TabIndex = 4;
            this.OptFarbeBlau.TabStop = true;
            this.OptFarbeBlau.Text = "Blau";
            this.OptFarbeBlau.UseVisualStyleBackColor = true;
            this.OptFarbeBlau.CheckedChanged += new System.EventHandler(this.OptFarbe_CheckedChanged);
            // 
            // LblTest1
            // 
            this.LblTest1.AutoSize = true;
            this.LblTest1.Location = new System.Drawing.Point(174, 90);
            this.LblTest1.Name = "LblTest1";
            this.LblTest1.Size = new System.Drawing.Size(55, 25);
            this.LblTest1.TabIndex = 5;
            this.LblTest1.Text = "Blau";
            // 
            // LblTest2
            // 
            this.LblTest2.AutoSize = true;
            this.LblTest2.Location = new System.Drawing.Point(174, 275);
            this.LblTest2.Name = "LblTest2";
            this.LblTest2.Size = new System.Drawing.Size(59, 25);
            this.LblTest2.TabIndex = 6;
            this.LblTest2.Text = "Grün";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTest2);
            this.Controls.Add(this.LblTest1);
            this.Controls.Add(this.OptFarbeBlau);
            this.Controls.Add(this.OptFarbeGruen);
            this.Controls.Add(this.OptFarbeRot);
            this.Controls.Add(this.CmdSchalter);
            this.Controls.Add(this.CmdPruefen);
            this.Name = "Form1";
            this.Text = "Optionen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdPruefen;
        private System.Windows.Forms.Button CmdSchalter;
        private System.Windows.Forms.RadioButton OptFarbeRot;
        private System.Windows.Forms.RadioButton OptFarbeGruen;
        private System.Windows.Forms.RadioButton OptFarbeBlau;
        private System.Windows.Forms.Label LblTest1;
        private System.Windows.Forms.Label LblTest2;
    }
}

