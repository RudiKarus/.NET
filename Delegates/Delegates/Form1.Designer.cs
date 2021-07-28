namespace Delegates
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
            this.CmdErzeugen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdErzeugen
            // 
            this.CmdErzeugen.Location = new System.Drawing.Point(12, 12);
            this.CmdErzeugen.Name = "CmdErzeugen";
            this.CmdErzeugen.Size = new System.Drawing.Size(75, 23);
            this.CmdErzeugen.TabIndex = 0;
            this.CmdErzeugen.Text = "button1";
            this.CmdErzeugen.UseVisualStyleBackColor = true;
            this.CmdErzeugen.Click += new System.EventHandler(this.CmdErzeugen_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(371, 376);
            this.Controls.Add(this.CmdErzeugen);
            this.Name = "Form1";
            this.Text = "Delegates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdErzeugen;
    }
}

