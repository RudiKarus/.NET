namespace ZeichnenFunktion
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
            this.CmdZeichnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdZeichnen
            // 
            this.CmdZeichnen.Location = new System.Drawing.Point(687, 395);
            this.CmdZeichnen.Name = "CmdZeichnen";
            this.CmdZeichnen.Size = new System.Drawing.Size(75, 23);
            this.CmdZeichnen.TabIndex = 0;
            this.CmdZeichnen.Text = "Zeichnen";
            this.CmdZeichnen.UseVisualStyleBackColor = true;
            this.CmdZeichnen.Click += new System.EventHandler(this.CmdZeichnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdZeichnen);
            this.Name = "Form1";
            this.Text = "Zeichnen | Funktion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdZeichnen;
    }
}

