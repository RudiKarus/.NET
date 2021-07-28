namespace Tetris
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
            this.CmdLinks = new System.Windows.Forms.Button();
            this.CmdRechts = new System.Windows.Forms.Button();
            this.CmdUnten = new System.Windows.Forms.Button();
            this.TimTetris = new System.Windows.Forms.Timer(this.components);
            this.CmdPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdLinks
            // 
            this.CmdLinks.Location = new System.Drawing.Point(72, 12);
            this.CmdLinks.Name = "CmdLinks";
            this.CmdLinks.Size = new System.Drawing.Size(75, 30);
            this.CmdLinks.TabIndex = 0;
            this.CmdLinks.Text = "Li";
            this.CmdLinks.UseVisualStyleBackColor = true;
            this.CmdLinks.Click += new System.EventHandler(this.CmdLinks_Click);
            // 
            // CmdRechts
            // 
            this.CmdRechts.Location = new System.Drawing.Point(185, 12);
            this.CmdRechts.Name = "CmdRechts";
            this.CmdRechts.Size = new System.Drawing.Size(75, 30);
            this.CmdRechts.TabIndex = 1;
            this.CmdRechts.Text = "Re";
            this.CmdRechts.UseVisualStyleBackColor = true;
            this.CmdRechts.Click += new System.EventHandler(this.CmdRechts_Click);
            // 
            // CmdUnten
            // 
            this.CmdUnten.Location = new System.Drawing.Point(116, 48);
            this.CmdUnten.Name = "CmdUnten";
            this.CmdUnten.Size = new System.Drawing.Size(92, 30);
            this.CmdUnten.TabIndex = 2;
            this.CmdUnten.Text = "Down";
            this.CmdUnten.UseVisualStyleBackColor = true;
            this.CmdUnten.Click += new System.EventHandler(this.CmdUnten_Click);
            // 
            // TimTetris
            // 
            this.TimTetris.Enabled = true;
            this.TimTetris.Interval = 500;
            this.TimTetris.Tick += new System.EventHandler(this.TimTetris_Tick);
            // 
            // CmdPause
            // 
            this.CmdPause.Location = new System.Drawing.Point(116, 432);
            this.CmdPause.Name = "CmdPause";
            this.CmdPause.Size = new System.Drawing.Size(92, 37);
            this.CmdPause.TabIndex = 3;
            this.CmdPause.Text = "Pause";
            this.CmdPause.UseVisualStyleBackColor = true;
            this.CmdPause.Click += new System.EventHandler(this.CmdPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(342, 481);
            this.Controls.Add(this.CmdPause);
            this.Controls.Add(this.CmdUnten);
            this.Controls.Add(this.CmdRechts);
            this.Controls.Add(this.CmdLinks);
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdLinks;
        private System.Windows.Forms.Button CmdRechts;
        private System.Windows.Forms.Button CmdUnten;
        private System.Windows.Forms.Timer TimTetris;
        private System.Windows.Forms.Button CmdPause;
    }
}

