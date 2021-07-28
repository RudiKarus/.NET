namespace EnabledVisible
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
            this.TxtEingabe1 = new System.Windows.Forms.TextBox();
            this.TxtEingabe2 = new System.Windows.Forms.TextBox();
            this.CmdRechnen1 = new System.Windows.Forms.Button();
            this.CmdRechnen2 = new System.Windows.Forms.Button();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtEingabe1
            // 
            this.TxtEingabe1.Location = new System.Drawing.Point(57, 56);
            this.TxtEingabe1.Name = "TxtEingabe1";
            this.TxtEingabe1.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe1.TabIndex = 0;
            this.TxtEingabe1.TextChanged += new System.EventHandler(this.TxtEingabe_TxtChanged);
            // 
            // TxtEingabe2
            // 
            this.TxtEingabe2.Location = new System.Drawing.Point(186, 56);
            this.TxtEingabe2.Name = "TxtEingabe2";
            this.TxtEingabe2.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe2.TabIndex = 1;
            this.TxtEingabe2.TextChanged += new System.EventHandler(this.TxtEingabe_TxtChanged);
            // 
            // CmdRechnen1
            // 
            this.CmdRechnen1.Location = new System.Drawing.Point(57, 93);
            this.CmdRechnen1.Name = "CmdRechnen1";
            this.CmdRechnen1.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen1.TabIndex = 2;
            this.CmdRechnen1.Text = "Rechnen 1";
            this.CmdRechnen1.UseVisualStyleBackColor = true;
            this.CmdRechnen1.Click += new System.EventHandler(this.CmdRechnen_Click);
            // 
            // CmdRechnen2
            // 
            this.CmdRechnen2.Location = new System.Drawing.Point(186, 93);
            this.CmdRechnen2.Name = "CmdRechnen2";
            this.CmdRechnen2.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen2.TabIndex = 3;
            this.CmdRechnen2.Text = "Rechnen 2";
            this.CmdRechnen2.UseVisualStyleBackColor = true;
            this.CmdRechnen2.Click += new System.EventHandler(this.CmdRechnen_Click);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(62, 128);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(70, 25);
            this.LblAusgabe.TabIndex = 4;
            this.LblAusgabe.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(389, 186);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.CmdRechnen2);
            this.Controls.Add(this.CmdRechnen1);
            this.Controls.Add(this.TxtEingabe2);
            this.Controls.Add(this.TxtEingabe1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe1;
        private System.Windows.Forms.TextBox TxtEingabe2;
        private System.Windows.Forms.Button CmdRechnen1;
        private System.Windows.Forms.Button CmdRechnen2;
        private System.Windows.Forms.Label LblAusgabe;
    }
}

