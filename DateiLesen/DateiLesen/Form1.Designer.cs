namespace DateiLesen
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
            this.CmdLesen = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdLesen
            // 
            this.CmdLesen.Location = new System.Drawing.Point(44, 41);
            this.CmdLesen.Name = "CmdLesen";
            this.CmdLesen.Size = new System.Drawing.Size(103, 38);
            this.CmdLesen.TabIndex = 0;
            this.CmdLesen.Text = "Lesen";
            this.CmdLesen.UseVisualStyleBackColor = true;
            this.CmdLesen.Click += new System.EventHandler(this.CmdLesen_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(39, 95);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 1;
            this.LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 351);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdLesen);
            this.Name = "Form1";
            this.Text = "Datei lesen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdLesen;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

