namespace Kran
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
            this.components = new System.ComponentModel.Container();
            this.Fundement = new System.Windows.Forms.Panel();
            this.Senkrechte = new System.Windows.Forms.Panel();
            this.Ausleger = new System.Windows.Forms.Panel();
            this.Haken = new System.Windows.Forms.Panel();
            this.CmdLinks = new System.Windows.Forms.Button();
            this.CmdRechts = new System.Windows.Forms.Button();
            this.CmdHoch = new System.Windows.Forms.Button();
            this.CmdRunter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OptManuell = new System.Windows.Forms.GroupBox();
            this.OptAutomatisch = new System.Windows.Forms.GroupBox();
            this.OptHoch = new System.Windows.Forms.RadioButton();
            this.OptRunter = new System.Windows.Forms.RadioButton();
            this.OptLinks = new System.Windows.Forms.RadioButton();
            this.OptRechts = new System.Windows.Forms.RadioButton();
            this.OptAutomatisch.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fundement
            // 
            this.Fundement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Fundement.Location = new System.Drawing.Point(607, 388);
            this.Fundement.Name = "Fundement";
            this.Fundement.Size = new System.Drawing.Size(100, 50);
            this.Fundement.TabIndex = 0;
            // 
            // Senkrechte
            // 
            this.Senkrechte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Senkrechte.Location = new System.Drawing.Point(631, 140);
            this.Senkrechte.Name = "Senkrechte";
            this.Senkrechte.Size = new System.Drawing.Size(50, 255);
            this.Senkrechte.TabIndex = 1;
            // 
            // Ausleger
            // 
            this.Ausleger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Ausleger.Location = new System.Drawing.Point(442, 140);
            this.Ausleger.Name = "Ausleger";
            this.Ausleger.Size = new System.Drawing.Size(255, 25);
            this.Ausleger.TabIndex = 1;
            // 
            // Haken
            // 
            this.Haken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Haken.Location = new System.Drawing.Point(475, 155);
            this.Haken.Name = "Haken";
            this.Haken.Size = new System.Drawing.Size(15, 50);
            this.Haken.TabIndex = 1;
            // 
            // CmdLinks
            // 
            this.CmdLinks.Location = new System.Drawing.Point(12, 126);
            this.CmdLinks.Name = "CmdLinks";
            this.CmdLinks.Size = new System.Drawing.Size(100, 50);
            this.CmdLinks.TabIndex = 2;
            this.CmdLinks.Text = "Links";
            this.CmdLinks.UseVisualStyleBackColor = true;
            this.CmdLinks.Click += new System.EventHandler(this.CmdLinks_Click);
            // 
            // CmdRechts
            // 
            this.CmdRechts.Location = new System.Drawing.Point(224, 126);
            this.CmdRechts.Name = "CmdRechts";
            this.CmdRechts.Size = new System.Drawing.Size(100, 50);
            this.CmdRechts.TabIndex = 3;
            this.CmdRechts.Text = "Rechts";
            this.CmdRechts.UseVisualStyleBackColor = true;
            this.CmdRechts.Click += new System.EventHandler(this.CmdRechts_Click);
            // 
            // CmdHoch
            // 
            this.CmdHoch.Location = new System.Drawing.Point(118, 70);
            this.CmdHoch.Name = "CmdHoch";
            this.CmdHoch.Size = new System.Drawing.Size(100, 50);
            this.CmdHoch.TabIndex = 4;
            this.CmdHoch.Text = "Hoch";
            this.CmdHoch.UseVisualStyleBackColor = true;
            this.CmdHoch.Click += new System.EventHandler(this.CmdHoch_Click);
            // 
            // CmdRunter
            // 
            this.CmdRunter.Location = new System.Drawing.Point(118, 182);
            this.CmdRunter.Name = "CmdRunter";
            this.CmdRunter.Size = new System.Drawing.Size(100, 50);
            this.CmdRunter.TabIndex = 5;
            this.CmdRunter.Text = "Runter";
            this.CmdRunter.UseVisualStyleBackColor = true;
            this.CmdRunter.Click += new System.EventHandler(this.CmdRunter_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OptManuell
            // 
            this.OptManuell.Location = new System.Drawing.Point(12, 22);
            this.OptManuell.Name = "OptManuell";
            this.OptManuell.Size = new System.Drawing.Size(321, 231);
            this.OptManuell.TabIndex = 10;
            this.OptManuell.TabStop = false;
            this.OptManuell.Text = "Manuelle Steuerung";
            // 
            // OptAutomatisch
            // 
            this.OptAutomatisch.Controls.Add(this.OptHoch);
            this.OptAutomatisch.Controls.Add(this.OptRunter);
            this.OptAutomatisch.Controls.Add(this.OptLinks);
            this.OptAutomatisch.Controls.Add(this.OptRechts);
            this.OptAutomatisch.Controls.Add(this.button1);
            this.OptAutomatisch.Controls.Add(this.button2);
            this.OptAutomatisch.Location = new System.Drawing.Point(12, 283);
            this.OptAutomatisch.Name = "OptAutomatisch";
            this.OptAutomatisch.Size = new System.Drawing.Size(321, 231);
            this.OptAutomatisch.TabIndex = 11;
            this.OptAutomatisch.TabStop = false;
            this.OptAutomatisch.Text = "Automatische Steuerung";
            // 
            // OptHoch
            // 
            this.OptHoch.AutoSize = true;
            this.OptHoch.Location = new System.Drawing.Point(54, 45);
            this.OptHoch.Name = "OptHoch";
            this.OptHoch.Size = new System.Drawing.Size(93, 29);
            this.OptHoch.TabIndex = 12;
            this.OptHoch.TabStop = true;
            this.OptHoch.Text = "Hoch";
            this.OptHoch.UseVisualStyleBackColor = true;
            this.OptHoch.CheckedChanged += new System.EventHandler(this.OptHoch_CheckedChanged);
            // 
            // OptRunter
            // 
            this.OptRunter.AutoSize = true;
            this.OptRunter.Location = new System.Drawing.Point(54, 80);
            this.OptRunter.Name = "OptRunter";
            this.OptRunter.Size = new System.Drawing.Size(107, 29);
            this.OptRunter.TabIndex = 13;
            this.OptRunter.TabStop = true;
            this.OptRunter.Text = "Runter";
            this.OptRunter.UseVisualStyleBackColor = true;
            this.OptRunter.CheckedChanged += new System.EventHandler(this.OptRunter_CheckedChanged);
            // 
            // OptLinks
            // 
            this.OptLinks.AutoSize = true;
            this.OptLinks.Location = new System.Drawing.Point(166, 45);
            this.OptLinks.Name = "OptLinks";
            this.OptLinks.Size = new System.Drawing.Size(94, 29);
            this.OptLinks.TabIndex = 14;
            this.OptLinks.TabStop = true;
            this.OptLinks.Text = "Links";
            this.OptLinks.UseVisualStyleBackColor = true;
            this.OptLinks.CheckedChanged += new System.EventHandler(this.OptLinks_CheckedChanged);
            // 
            // OptRechts
            // 
            this.OptRechts.AutoSize = true;
            this.OptRechts.Location = new System.Drawing.Point(166, 80);
            this.OptRechts.Name = "OptRechts";
            this.OptRechts.Size = new System.Drawing.Size(110, 29);
            this.OptRechts.TabIndex = 15;
            this.OptRechts.TabStop = true;
            this.OptRechts.Text = "Rechts";
            this.OptRechts.UseVisualStyleBackColor = true;
            this.OptRechts.CheckedChanged += new System.EventHandler(this.OptRechts_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.CmdRunter);
            this.Controls.Add(this.CmdHoch);
            this.Controls.Add(this.CmdRechts);
            this.Controls.Add(this.CmdLinks);
            this.Controls.Add(this.Ausleger);
            this.Controls.Add(this.Haken);
            this.Controls.Add(this.Senkrechte);
            this.Controls.Add(this.Fundement);
            this.Controls.Add(this.OptManuell);
            this.Controls.Add(this.OptAutomatisch);
            this.Name = "Form1";
            this.Text = "KranVerzweigung";
            this.OptAutomatisch.ResumeLayout(false);
            this.OptAutomatisch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Fundement;
        private System.Windows.Forms.Panel Senkrechte;
        private System.Windows.Forms.Panel Ausleger;
        private System.Windows.Forms.Panel Haken;
        private System.Windows.Forms.Button CmdLinks;
        private System.Windows.Forms.Button CmdRechts;
        private System.Windows.Forms.Button CmdHoch;
        private System.Windows.Forms.Button CmdRunter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox OptManuell;
        private System.Windows.Forms.GroupBox OptAutomatisch;
        private System.Windows.Forms.RadioButton OptHoch;
        private System.Windows.Forms.RadioButton OptRunter;
        private System.Windows.Forms.RadioButton OptLinks;
        private System.Windows.Forms.RadioButton OptRechts;
    }
}

