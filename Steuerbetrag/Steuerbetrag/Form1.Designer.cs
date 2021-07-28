namespace Steuerbetrag
{
    partial class Steuerbetrag
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
            this.CmdBerechnen = new System.Windows.Forms.Button();
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblAnweisung1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdBerechnen
            // 
            this.CmdBerechnen.Location = new System.Drawing.Point(189, 81);
            this.CmdBerechnen.Name = "CmdBerechnen";
            this.CmdBerechnen.Size = new System.Drawing.Size(150, 40);
            this.CmdBerechnen.TabIndex = 0;
            this.CmdBerechnen.Text = "Berechnen";
            this.CmdBerechnen.UseVisualStyleBackColor = true;
            this.CmdBerechnen.Click += new System.EventHandler(this.CmdBerechnen_Click);
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(20, 138);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(102, 25);
            this.LblAnzeige1.TabIndex = 1;
            this.LblAnzeige1.Text = "[Anzeige]";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 2;
            // 
            // LblAnweisung1
            // 
            this.LblAnweisung1.AutoSize = true;
            this.LblAnweisung1.Location = new System.Drawing.Point(20, 30);
            this.LblAnweisung1.Name = "LblAnweisung1";
            this.LblAnweisung1.Size = new System.Drawing.Size(129, 25);
            this.LblAnweisung1.TabIndex = 3;
            this.LblAnweisung1.Text = "[Anweisung]";
            // 
            // Steuerbetrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 249);
            this.Controls.Add(this.LblAnweisung1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblAnzeige1);
            this.Controls.Add(this.CmdBerechnen);
            this.Name = "Steuerbetrag";
            this.Text = "Steuerbetrag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdBerechnen;
        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblAnweisung1;
    }
}

