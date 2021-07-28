namespace Polymorphie
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
            this.CmdAnzeigen = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeigen
            // 
            this.CmdAnzeigen.Location = new System.Drawing.Point(12, 12);
            this.CmdAnzeigen.Name = "CmdAnzeigen";
            this.CmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen.TabIndex = 0;
            this.CmdAnzeigen.Text = "Anzeigen";
            this.CmdAnzeigen.UseVisualStyleBackColor = true;
            this.CmdAnzeigen.Click += new System.EventHandler(this.CmdAnzeigen_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 49);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 1;
            this.LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(474, 250);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAnzeigen);
            this.Name = "Form1";
            this.Text = "Polymorphie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAnzeigen;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

