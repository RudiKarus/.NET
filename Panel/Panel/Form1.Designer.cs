namespace Panel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmdNachOben = new System.Windows.Forms.Button();
            this.CmdNachLinks = new System.Windows.Forms.Button();
            this.CmdNachRechts = new System.Windows.Forms.Button();
            this.CmdNachUnten = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CmdStart = new System.Windows.Forms.Button();
            this.CmdStop = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(295, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // CmdNachOben
            // 
            this.CmdNachOben.Location = new System.Drawing.Point(295, 12);
            this.CmdNachOben.Name = "CmdNachOben";
            this.CmdNachOben.Size = new System.Drawing.Size(200, 50);
            this.CmdNachOben.TabIndex = 0;
            this.CmdNachOben.Text = "nach oben";
            this.CmdNachOben.UseVisualStyleBackColor = true;
            this.CmdNachOben.Click += new System.EventHandler(this.CmdNachOben_Click);
            // 
            // CmdNachLinks
            // 
            this.CmdNachLinks.Location = new System.Drawing.Point(12, 183);
            this.CmdNachLinks.Name = "CmdNachLinks";
            this.CmdNachLinks.Size = new System.Drawing.Size(200, 50);
            this.CmdNachLinks.TabIndex = 1;
            this.CmdNachLinks.Text = "nach links";
            this.CmdNachLinks.UseVisualStyleBackColor = true;
            this.CmdNachLinks.Click += new System.EventHandler(this.CmdNachLinks_Click);
            // 
            // CmdNachRechts
            // 
            this.CmdNachRechts.Location = new System.Drawing.Point(588, 183);
            this.CmdNachRechts.Name = "CmdNachRechts";
            this.CmdNachRechts.Size = new System.Drawing.Size(200, 50);
            this.CmdNachRechts.TabIndex = 2;
            this.CmdNachRechts.Text = "nach rechts";
            this.CmdNachRechts.UseVisualStyleBackColor = true;
            this.CmdNachRechts.Click += new System.EventHandler(this.CmdNachRechts_Click);
            // 
            // CmdNachUnten
            // 
            this.CmdNachUnten.Location = new System.Drawing.Point(295, 388);
            this.CmdNachUnten.Name = "CmdNachUnten";
            this.CmdNachUnten.Size = new System.Drawing.Size(200, 50);
            this.CmdNachUnten.TabIndex = 3;
            this.CmdNachUnten.Text = "nach unten";
            this.CmdNachUnten.UseVisualStyleBackColor = true;
            this.CmdNachUnten.Click += new System.EventHandler(this.CmdNachUnten_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(12, 12);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(100, 50);
            this.CmdStart.TabIndex = 4;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // CmdStop
            // 
            this.CmdStop.Location = new System.Drawing.Point(688, 12);
            this.CmdStop.Name = "CmdStop";
            this.CmdStop.Size = new System.Drawing.Size(100, 50);
            this.CmdStop.TabIndex = 5;
            this.CmdStop.Text = "Stop";
            this.CmdStop.UseVisualStyleBackColor = true;
            this.CmdStop.Click += new System.EventHandler(this.CmdStop_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(118, 25);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 25);
            this.LblAnzeige.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdStop);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.CmdNachOben);
            this.Controls.Add(this.CmdNachLinks);
            this.Controls.Add(this.CmdNachRechts);
            this.Controls.Add(this.CmdNachUnten);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdNachOben;
        private System.Windows.Forms.Button CmdNachLinks;
        private System.Windows.Forms.Button CmdNachRechts;
        private System.Windows.Forms.Button CmdNachUnten;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Button CmdStop;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

