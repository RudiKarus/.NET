namespace DBZugriffAccess
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
            this.CmdAlleSehen = new System.Windows.Forms.Button();
            this.LstAnzeige = new System.Windows.Forms.ListBox();
            this.CmdSenken = new System.Windows.Forms.Button();
            this.CmdErhoehen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdAlleSehen
            // 
            this.CmdAlleSehen.Location = new System.Drawing.Point(40, 48);
            this.CmdAlleSehen.Name = "CmdAlleSehen";
            this.CmdAlleSehen.Size = new System.Drawing.Size(75, 23);
            this.CmdAlleSehen.TabIndex = 0;
            this.CmdAlleSehen.Text = "Alle Datensätze sehen";
            this.CmdAlleSehen.UseVisualStyleBackColor = true;
            this.CmdAlleSehen.Click += new System.EventHandler(this.CmdAlleSehen_Click);
            // 
            // LstAnzeige
            // 
            this.LstAnzeige.FormattingEnabled = true;
            this.LstAnzeige.ItemHeight = 25;
            this.LstAnzeige.Location = new System.Drawing.Point(40, 252);
            this.LstAnzeige.Name = "LstAnzeige";
            this.LstAnzeige.Size = new System.Drawing.Size(367, 79);
            this.LstAnzeige.TabIndex = 1;
            // 
            // CmdSenken
            // 
            this.CmdSenken.Location = new System.Drawing.Point(40, 136);
            this.CmdSenken.Name = "CmdSenken";
            this.CmdSenken.Size = new System.Drawing.Size(75, 23);
            this.CmdSenken.TabIndex = 2;
            this.CmdSenken.Text = "Senken";
            this.CmdSenken.UseVisualStyleBackColor = true;
            this.CmdSenken.Click += new System.EventHandler(this.CmdAendern_Click);
            // 
            // CmdErhoehen
            // 
            this.CmdErhoehen.Location = new System.Drawing.Point(40, 107);
            this.CmdErhoehen.Name = "CmdErhoehen";
            this.CmdErhoehen.Size = new System.Drawing.Size(75, 23);
            this.CmdErhoehen.TabIndex = 3;
            this.CmdErhoehen.Text = "Erhoehen";
            this.CmdErhoehen.UseVisualStyleBackColor = true;
            this.CmdErhoehen.Click += new System.EventHandler(this.CmdAendern_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.CmdErhoehen);
            this.Controls.Add(this.CmdSenken);
            this.Controls.Add(this.LstAnzeige);
            this.Controls.Add(this.CmdAlleSehen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdAlleSehen;
        private System.Windows.Forms.ListBox LstAnzeige;
        private System.Windows.Forms.Button CmdSenken;
        private System.Windows.Forms.Button CmdErhoehen;
    }
}

