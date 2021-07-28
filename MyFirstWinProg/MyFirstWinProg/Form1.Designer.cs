namespace MyFirstWinProg
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
            this.CmdHello = new System.Windows.Forms.Button();
            this.CmdEnd = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdHello
            // 
            this.CmdHello.AutoSize = true;
            this.CmdHello.Location = new System.Drawing.Point(150, 350);
            this.CmdHello.Name = "CmdHello";
            this.CmdHello.Size = new System.Drawing.Size(115, 35);
            this.CmdHello.TabIndex = 0;
            this.CmdHello.Text = "Hello";
            this.CmdHello.UseVisualStyleBackColor = true;
            this.CmdHello.Click += new System.EventHandler(this.CmdHello_Click);
            // 
            // CmdEnd
            // 
            this.CmdEnd.AutoSize = true;
            this.CmdEnd.Location = new System.Drawing.Point(300, 350);
            this.CmdEnd.Name = "CmdEnd";
            this.CmdEnd.Size = new System.Drawing.Size(94, 35);
            this.CmdEnd.TabIndex = 1;
            this.CmdEnd.Text = "Ende";
            this.CmdEnd.UseVisualStyleBackColor = true;
            this.CmdEnd.Click += new System.EventHandler(this.CmdEnd_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAnzeige.Location = new System.Drawing.Point(150, 150);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(86, 27);
            this.LblAnzeige.TabIndex = 2;
            this.LblAnzeige.Text = "(empty)";
            this.LblAnzeige.Click += new System.EventHandler(this.LblAnzeige_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(774, 429);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdEnd);
            this.Controls.Add(this.CmdHello);
            this.Name = "Form1";
            this.Text = "RudisWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdHello;
        private System.Windows.Forms.Button CmdEnd;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

