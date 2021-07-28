namespace DateiSchreiben
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
            this.CmdSchreiben = new System.Windows.Forms.Button();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdSchreiben
            // 
            this.CmdSchreiben.Location = new System.Drawing.Point(159, 71);
            this.CmdSchreiben.Name = "CmdSchreiben";
            this.CmdSchreiben.Size = new System.Drawing.Size(122, 37);
            this.CmdSchreiben.TabIndex = 0;
            this.CmdSchreiben.Text = "Schreiben";
            this.CmdSchreiben.UseVisualStyleBackColor = true;
            this.CmdSchreiben.Click += new System.EventHandler(this.CmdSchreiben_Click);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(159, 131);
            this.TxtEingabe.Multiline = true;
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(122, 146);
            this.TxtEingabe.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 372);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.CmdSchreiben);
            this.Name = "Form1";
            this.Text = "Datei schreiben";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSchreiben;
        private System.Windows.Forms.TextBox TxtEingabe;
    }
}

