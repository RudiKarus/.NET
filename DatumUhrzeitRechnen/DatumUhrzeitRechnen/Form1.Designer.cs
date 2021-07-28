namespace DatumUhrzeitRechnen
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
            this.LstAnzeige = new System.Windows.Forms.ListBox();
            this.CmdAnzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstAnzeige
            // 
            this.LstAnzeige.FormattingEnabled = true;
            this.LstAnzeige.ItemHeight = 25;
            this.LstAnzeige.Location = new System.Drawing.Point(41, 74);
            this.LstAnzeige.Name = "LstAnzeige";
            this.LstAnzeige.Size = new System.Drawing.Size(306, 179);
            this.LstAnzeige.TabIndex = 0;
            // 
            // CmdAnzeigen
            // 
            this.CmdAnzeigen.Location = new System.Drawing.Point(41, 45);
            this.CmdAnzeigen.Name = "CmdAnzeigen";
            this.CmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen.TabIndex = 1;
            this.CmdAnzeigen.Text = "Anzeigen";
            this.CmdAnzeigen.UseVisualStyleBackColor = true;
            this.CmdAnzeigen.Click += new System.EventHandler(this.CmdAnzeigen_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdAnzeigen);
            this.Controls.Add(this.LstAnzeige);
            this.Name = "Form1";
            this.Text = "Datum-Uhrzeit | Rechnen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstAnzeige;
        private System.Windows.Forms.Button CmdAnzeigen;
    }
}

