namespace Kontrollkaestchen
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
            this.ChkSchalter = new System.Windows.Forms.CheckBox();
            this.CmdPruefen = new System.Windows.Forms.Button();
            this.CmdUmschalten = new System.Windows.Forms.Button();
            this.LblTest2 = new System.Windows.Forms.Label();
            this.LblTest1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChkSchalter
            // 
            this.ChkSchalter.AutoSize = true;
            this.ChkSchalter.Location = new System.Drawing.Point(210, 61);
            this.ChkSchalter.Name = "ChkSchalter";
            this.ChkSchalter.Size = new System.Drawing.Size(123, 29);
            this.ChkSchalter.TabIndex = 0;
            this.ChkSchalter.Text = "Schalter";
            this.ChkSchalter.UseVisualStyleBackColor = true;
            this.ChkSchalter.CheckedChanged += new System.EventHandler(this.ChkSchalter_CheckedChanged);
            // 
            // CmdPruefen
            // 
            this.CmdPruefen.Location = new System.Drawing.Point(210, 156);
            this.CmdPruefen.Name = "CmdPruefen";
            this.CmdPruefen.Size = new System.Drawing.Size(220, 35);
            this.CmdPruefen.TabIndex = 1;
            this.CmdPruefen.Text = "Schalter prüfen";
            this.CmdPruefen.UseVisualStyleBackColor = true;
            this.CmdPruefen.Click += new System.EventHandler(this.CmdPruefen_Click);
            // 
            // CmdUmschalten
            // 
            this.CmdUmschalten.Location = new System.Drawing.Point(210, 96);
            this.CmdUmschalten.Name = "CmdUmschalten";
            this.CmdUmschalten.Size = new System.Drawing.Size(220, 35);
            this.CmdUmschalten.TabIndex = 2;
            this.CmdUmschalten.Text = "Schalter umschalten";
            this.CmdUmschalten.UseVisualStyleBackColor = true;
            this.CmdUmschalten.Click += new System.EventHandler(this.CmdUmschalten_Click);
            // 
            // LblTest2
            // 
            this.LblTest2.AutoSize = true;
            this.LblTest2.Location = new System.Drawing.Point(137, 62);
            this.LblTest2.Name = "LblTest2";
            this.LblTest2.Size = new System.Drawing.Size(38, 25);
            this.LblTest2.TabIndex = 3;
            this.LblTest2.Text = "An";
            // 
            // LblTest1
            // 
            this.LblTest1.AutoSize = true;
            this.LblTest1.Location = new System.Drawing.Point(137, 161);
            this.LblTest1.Name = "LblTest1";
            this.LblTest1.Size = new System.Drawing.Size(49, 25);
            this.LblTest1.TabIndex = 4;
            this.LblTest1.Text = "Aus";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(610, 264);
            this.Controls.Add(this.LblTest1);
            this.Controls.Add(this.LblTest2);
            this.Controls.Add(this.CmdUmschalten);
            this.Controls.Add(this.CmdPruefen);
            this.Controls.Add(this.ChkSchalter);
            this.Name = "Form1";
            this.Text = "Kontrollkaestchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkSchalter;
        private System.Windows.Forms.Button CmdPruefen;
        private System.Windows.Forms.Button CmdUmschalten;
        private System.Windows.Forms.Label LblTest2;
        private System.Windows.Forms.Label LblTest1;
    }
}

