namespace ArgumenteBeliebig
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
            this.CmdAnzeigen1 = new System.Windows.Forms.Button();
            this.CmdAnzeigen2 = new System.Windows.Forms.Button();
            this.CmdAnzeigen3 = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            this.CmdAnzeigen1.Location = new System.Drawing.Point(161, 59);
            this.CmdAnzeigen1.Name = "CmdAnzeigen1";
            this.CmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen1.TabIndex = 0;
            this.CmdAnzeigen1.Text = "Anzeigen 1";
            this.CmdAnzeigen1.UseVisualStyleBackColor = true;
            this.CmdAnzeigen1.Click += new System.EventHandler(this.CmdAnzeigen1_Click);
            // 
            // CmdAnzeigen2
            // 
            this.CmdAnzeigen2.Location = new System.Drawing.Point(242, 59);
            this.CmdAnzeigen2.Name = "CmdAnzeigen2";
            this.CmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen2.TabIndex = 1;
            this.CmdAnzeigen2.Text = "Anzeigen 2";
            this.CmdAnzeigen2.UseVisualStyleBackColor = true;
            this.CmdAnzeigen2.Click += new System.EventHandler(this.CmdAnzeigen2_Click);
            // 
            // CmdAnzeigen3
            // 
            this.CmdAnzeigen3.Location = new System.Drawing.Point(323, 59);
            this.CmdAnzeigen3.Name = "CmdAnzeigen3";
            this.CmdAnzeigen3.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen3.TabIndex = 2;
            this.CmdAnzeigen3.Text = "Anzeigen 3";
            this.CmdAnzeigen3.UseVisualStyleBackColor = true;
            this.CmdAnzeigen3.Click += new System.EventHandler(this.CmdAnzeigen3_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(220, 98);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 3;
            this.LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(544, 242);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAnzeigen3);
            this.Controls.Add(this.CmdAnzeigen2);
            this.Controls.Add(this.CmdAnzeigen1);
            this.Name = "Form1";
            this.Text = "Argumente beliebig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAnzeigen1;
        private System.Windows.Forms.Button CmdAnzeigen2;
        private System.Windows.Forms.Button CmdAnzeigen3;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

