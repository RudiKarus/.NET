namespace Enabled
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
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.LstBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(161, 12);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 0;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // LstBox1
            // 
            this.LstBox1.FormattingEnabled = true;
            this.LstBox1.ItemHeight = 25;
            this.LstBox1.Location = new System.Drawing.Point(12, 12);
            this.LstBox1.Name = "LstBox1";
            this.LstBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstBox1.Size = new System.Drawing.Size(120, 79);
            this.LstBox1.TabIndex = 1;
            this.LstBox1.Click += new System.EventHandler(this.LstBox1_Click);
            this.LstBox1.Enter += new System.EventHandler(this.LstBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(393, 198);
            this.Controls.Add(this.LstBox1);
            this.Controls.Add(this.CmdLoeschen);
            this.Name = "Form1";
            this.Text = "Enabled";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdLoeschen;
        private System.Windows.Forms.ListBox LstBox1;
    }
}

