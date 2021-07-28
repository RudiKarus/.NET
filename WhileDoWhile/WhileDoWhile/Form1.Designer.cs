namespace WhileDoWhile
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
            this.CmdWhile = new System.Windows.Forms.Button();
            this.CmdDoWhile = new System.Windows.Forms.Button();
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdWhile
            // 
            this.CmdWhile.Location = new System.Drawing.Point(301, 30);
            this.CmdWhile.Name = "CmdWhile";
            this.CmdWhile.Size = new System.Drawing.Size(150, 35);
            this.CmdWhile.TabIndex = 0;
            this.CmdWhile.Text = "While";
            this.CmdWhile.UseVisualStyleBackColor = true;
            this.CmdWhile.Click += new System.EventHandler(this.CmdWhile_Click);
            // 
            // CmdDoWhile
            // 
            this.CmdDoWhile.Location = new System.Drawing.Point(301, 73);
            this.CmdDoWhile.Name = "CmdDoWhile";
            this.CmdDoWhile.Size = new System.Drawing.Size(150, 35);
            this.CmdDoWhile.TabIndex = 1;
            this.CmdDoWhile.Text = "Do-While";
            this.CmdDoWhile.UseVisualStyleBackColor = true;
            this.CmdDoWhile.Click += new System.EventHandler(this.CmdDoWhile_Click);
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(28, 30);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(0, 25);
            this.LblAnzeige1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(483, 274);
            this.Controls.Add(this.LblAnzeige1);
            this.Controls.Add(this.CmdDoWhile);
            this.Controls.Add(this.CmdWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdWhile;
        private System.Windows.Forms.Button CmdDoWhile;
        private System.Windows.Forms.Label LblAnzeige1;
    }
}

