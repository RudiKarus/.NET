namespace ProjektSteuerelemente
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
            this.CmdPositionAbs = new System.Windows.Forms.Button();
            this.CmdSizeRel = new System.Windows.Forms.Button();
            this.CmdSizeAbs = new System.Windows.Forms.Button();
            this.CmdTest = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdColor = new System.Windows.Forms.Button();
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdPositionRel
            // 
            this.CmdPositionRel.AutoSize = true;
            this.CmdPositionRel.Location = new System.Drawing.Point(253, 51);
            this.CmdPositionRel.Name = "CmdPositionRel";
            this.CmdPositionRel.Size = new System.Drawing.Size(137, 35);
            this.CmdPositionRel.TabIndex = 0;
            this.CmdPositionRel.Text = "Position Rel";
            this.CmdPositionRel.UseVisualStyleBackColor = true;
            this.CmdPositionRel.Click += new System.EventHandler(this.CmdPositionRel_Click);
            // 
            // CmdPositionAbs
            // 
            this.CmdPositionAbs.AutoSize = true;
            this.CmdPositionAbs.Location = new System.Drawing.Point(248, 92);
            this.CmdPositionAbs.Name = "CmdPositionAbs";
            this.CmdPositionAbs.Size = new System.Drawing.Size(142, 35);
            this.CmdPositionAbs.TabIndex = 1;
            this.CmdPositionAbs.Text = "Position Abs";
            this.CmdPositionAbs.UseVisualStyleBackColor = true;
            this.CmdPositionAbs.Click += new System.EventHandler(this.CmdPositionAbs_Click);
            // 
            // CmdSizeRel
            // 
            this.CmdSizeRel.AutoSize = true;
            this.CmdSizeRel.Location = new System.Drawing.Point(414, 51);
            this.CmdSizeRel.Name = "CmdSizeRel";
            this.CmdSizeRel.Size = new System.Drawing.Size(102, 35);
            this.CmdSizeRel.TabIndex = 2;
            this.CmdSizeRel.Text = "Size Rel";
            this.CmdSizeRel.UseVisualStyleBackColor = true;
            this.CmdSizeRel.Click += new System.EventHandler(this.CmdSizeRel_Click);
            // 
            // CmdSizeAbs
            // 
            this.CmdSizeAbs.AutoSize = true;
            this.CmdSizeAbs.Location = new System.Drawing.Point(414, 92);
            this.CmdSizeAbs.Name = "CmdSizeAbs";
            this.CmdSizeAbs.Size = new System.Drawing.Size(107, 35);
            this.CmdSizeAbs.TabIndex = 3;
            this.CmdSizeAbs.Text = "Size Abs";
            this.CmdSizeAbs.UseVisualStyleBackColor = true;
            this.CmdSizeAbs.Click += new System.EventHandler(this.CmdSizeAbs_Click);
            // 
            // CmdTest
            // 
            this.CmdTest.AutoSize = true;
            this.CmdTest.Location = new System.Drawing.Point(350, 207);
            this.CmdTest.Name = "CmdTest";
            this.CmdTest.Size = new System.Drawing.Size(94, 35);
            this.CmdTest.TabIndex = 4;
            this.CmdTest.Text = "Test";
            this.CmdTest.UseVisualStyleBackColor = true;
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(34, 102);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 25);
            this.LblAnzeige.TabIndex = 6;
            // 
            // CmdColor
            // 
            this.CmdColor.AutoSize = true;
            this.CmdColor.Location = new System.Drawing.Point(673, 51);
            this.CmdColor.Name = "CmdColor";
            this.CmdColor.Size = new System.Drawing.Size(94, 35);
            this.CmdColor.TabIndex = 7;
            this.CmdColor.Text = "Color";
            this.CmdColor.UseVisualStyleBackColor = true;
            this.CmdColor.Click += new System.EventHandler(this.CmdColor_Click);
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.AutoSize = true;
            this.CmdAnzeige.Location = new System.Drawing.Point(39, 51);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(100, 35);
            this.CmdAnzeige.TabIndex = 9;
            this.CmdAnzeige.Text = "Anzeige";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdAnzeige);
            this.Controls.Add(this.CmdColor);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdTest);
            this.Controls.Add(this.CmdSizeAbs);
            this.Controls.Add(this.CmdSizeRel);
            this.Controls.Add(this.CmdPositionAbs);
            this.Controls.Add(this.CmdPositionRel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdPositionRel;
        private System.Windows.Forms.Button CmdPositionAbs;
        private System.Windows.Forms.Button CmdSizeRel;
        private System.Windows.Forms.Button CmdSizeAbs;
        private System.Windows.Forms.Button CmdTest;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdColor;
        private System.Windows.Forms.Button CmdAnzeige;
    }
}

