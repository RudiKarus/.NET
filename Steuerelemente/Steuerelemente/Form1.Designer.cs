namespace Steuerelemente
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
            this.CmdPositionRel = new System.Windows.Forms.Button();
            this.CmdPostionAbs = new System.Windows.Forms.Button();
            this.CmdGroesseRel = new System.Windows.Forms.Button();
            this.CmdGroesseAbs = new System.Windows.Forms.Button();
            this.CmdTest = new System.Windows.Forms.Button();
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdFarbe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdPositionRel
            // 
            this.CmdPositionRel.Location = new System.Drawing.Point(232, 60);
            this.CmdPositionRel.Name = "CmdPositionRel";
            this.CmdPositionRel.Size = new System.Drawing.Size(200, 50);
            this.CmdPositionRel.TabIndex = 0;
            this.CmdPositionRel.Text = "Position Rel.";
            this.CmdPositionRel.UseVisualStyleBackColor = true;
            this.CmdPositionRel.Click += new System.EventHandler(this.CmdPositionRel_Click);
            // 
            // CmdPostionAbs
            // 
            this.CmdPostionAbs.Location = new System.Drawing.Point(232, 12);
            this.CmdPostionAbs.Name = "CmdPostionAbs";
            this.CmdPostionAbs.Size = new System.Drawing.Size(200, 50);
            this.CmdPostionAbs.TabIndex = 1;
            this.CmdPostionAbs.Text = "Position Abs.";
            this.CmdPostionAbs.UseVisualStyleBackColor = true;
            this.CmdPostionAbs.Click += new System.EventHandler(this.CmdPostionAbs_Click);
            // 
            // CmdGroesseRel
            // 
            this.CmdGroesseRel.Location = new System.Drawing.Point(12, 60);
            this.CmdGroesseRel.Name = "CmdGroesseRel";
            this.CmdGroesseRel.Size = new System.Drawing.Size(200, 50);
            this.CmdGroesseRel.TabIndex = 2;
            this.CmdGroesseRel.Text = "Größe Rel.";
            this.CmdGroesseRel.UseVisualStyleBackColor = true;
            this.CmdGroesseRel.Click += new System.EventHandler(this.CmdGroesseRel_Click);
            // 
            // CmdGroesseAbs
            // 
            this.CmdGroesseAbs.Location = new System.Drawing.Point(12, 12);
            this.CmdGroesseAbs.Name = "CmdGroesseAbs";
            this.CmdGroesseAbs.Size = new System.Drawing.Size(200, 50);
            this.CmdGroesseAbs.TabIndex = 3;
            this.CmdGroesseAbs.Text = "Größe Abs.";
            this.CmdGroesseAbs.UseVisualStyleBackColor = true;
            this.CmdGroesseAbs.Click += new System.EventHandler(this.CmdGroesseAbs_Click);
            // 
            // CmdTest
            // 
            this.CmdTest.Location = new System.Drawing.Point(347, 289);
            this.CmdTest.Name = "CmdTest";
            this.CmdTest.Size = new System.Drawing.Size(100, 30);
            this.CmdTest.TabIndex = 4;
            this.CmdTest.Text = "Test";
            this.CmdTest.UseVisualStyleBackColor = true;
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(593, 12);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(100, 50);
            this.CmdAnzeige.TabIndex = 5;
            this.CmdAnzeige.Text = "Anzeige";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAnzeige.Location = new System.Drawing.Point(588, 73);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(2, 27);
            this.LblAnzeige.TabIndex = 6;
            // 
            // CmdFarbe
            // 
            this.CmdFarbe.Location = new System.Drawing.Point(699, 12);
            this.CmdFarbe.Name = "CmdFarbe";
            this.CmdFarbe.Size = new System.Drawing.Size(100, 50);
            this.CmdFarbe.TabIndex = 7;
            this.CmdFarbe.Text = "Farbe";
            this.CmdFarbe.UseVisualStyleBackColor = true;
            this.CmdFarbe.Click += new System.EventHandler(this.CmdFarbe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdFarbe);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAnzeige);
            this.Controls.Add(this.CmdTest);
            this.Controls.Add(this.CmdGroesseAbs);
            this.Controls.Add(this.CmdGroesseRel);
            this.Controls.Add(this.CmdPostionAbs);
            this.Controls.Add(this.CmdPositionRel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdPositionRel;
        private System.Windows.Forms.Button CmdPostionAbs;
        private System.Windows.Forms.Button CmdGroesseRel;
        private System.Windows.Forms.Button CmdGroesseAbs;
        private System.Windows.Forms.Button CmdTest;
        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdFarbe;
    }
}

