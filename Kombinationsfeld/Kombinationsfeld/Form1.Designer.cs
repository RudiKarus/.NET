namespace Kombinationsfeld
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
            this.CmdAnzeige1 = new System.Windows.Forms.Button();
            this.CmdAnzeige2 = new System.Windows.Forms.Button();
            this.CmdAnzeige3 = new System.Windows.Forms.Button();
            this.CmbWerkzeug1 = new System.Windows.Forms.ComboBox();
            this.CmbWerkzeug2 = new System.Windows.Forms.ComboBox();
            this.CmbWerkzeug3 = new System.Windows.Forms.ComboBox();
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.LblAnzeige3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeige1
            // 
            this.CmdAnzeige1.Location = new System.Drawing.Point(338, 67);
            this.CmdAnzeige1.Name = "CmdAnzeige1";
            this.CmdAnzeige1.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige1.TabIndex = 0;
            this.CmdAnzeige1.Text = "Anzeigen 1";
            this.CmdAnzeige1.UseVisualStyleBackColor = true;
            this.CmdAnzeige1.Click += new System.EventHandler(this.CmdAnzeige1_Click);
            // 
            // CmdAnzeige2
            // 
            this.CmdAnzeige2.Location = new System.Drawing.Point(338, 197);
            this.CmdAnzeige2.Name = "CmdAnzeige2";
            this.CmdAnzeige2.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige2.TabIndex = 1;
            this.CmdAnzeige2.Text = "Anzeigen 2";
            this.CmdAnzeige2.UseVisualStyleBackColor = true;
            this.CmdAnzeige2.Click += new System.EventHandler(this.CmdAnzeige2_Click);
            // 
            // CmdAnzeige3
            // 
            this.CmdAnzeige3.Location = new System.Drawing.Point(338, 331);
            this.CmdAnzeige3.Name = "CmdAnzeige3";
            this.CmdAnzeige3.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige3.TabIndex = 2;
            this.CmdAnzeige3.Text = "Anzeigen 3";
            this.CmdAnzeige3.UseVisualStyleBackColor = true;
            this.CmdAnzeige3.Click += new System.EventHandler(this.CmdAnzeige3_Click);
            // 
            // CmbWerkzeug1
            // 
            this.CmbWerkzeug1.FormattingEnabled = true;
            this.CmbWerkzeug1.Location = new System.Drawing.Point(57, 63);
            this.CmbWerkzeug1.Name = "CmbWerkzeug1";
            this.CmbWerkzeug1.Size = new System.Drawing.Size(121, 33);
            this.CmbWerkzeug1.TabIndex = 3;
            // 
            // CmbWerkzeug2
            // 
            this.CmbWerkzeug2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbWerkzeug2.FormattingEnabled = true;
            this.CmbWerkzeug2.Location = new System.Drawing.Point(57, 187);
            this.CmbWerkzeug2.Name = "CmbWerkzeug2";
            this.CmbWerkzeug2.Size = new System.Drawing.Size(121, 33);
            this.CmbWerkzeug2.TabIndex = 4;
            // 
            // CmbWerkzeug3
            // 
            this.CmbWerkzeug3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CmbWerkzeug3.FormattingEnabled = true;
            this.CmbWerkzeug3.Location = new System.Drawing.Point(57, 321);
            this.CmbWerkzeug3.Name = "CmbWerkzeug3";
            this.CmbWerkzeug3.Size = new System.Drawing.Size(121, 150);
            this.CmbWerkzeug3.TabIndex = 5;
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(639, 66);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige1.TabIndex = 6;
            this.LblAnzeige1.Text = "label1";
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(639, 195);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige2.TabIndex = 7;
            this.LblAnzeige2.Text = "label2";
            // 
            // LblAnzeige3
            // 
            this.LblAnzeige3.AutoSize = true;
            this.LblAnzeige3.Location = new System.Drawing.Point(639, 329);
            this.LblAnzeige3.Name = "LblAnzeige3";
            this.LblAnzeige3.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige3.TabIndex = 8;
            this.LblAnzeige3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnzeige3);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.LblAnzeige1);
            this.Controls.Add(this.CmbWerkzeug3);
            this.Controls.Add(this.CmbWerkzeug2);
            this.Controls.Add(this.CmbWerkzeug1);
            this.Controls.Add(this.CmdAnzeige3);
            this.Controls.Add(this.CmdAnzeige2);
            this.Controls.Add(this.CmdAnzeige1);
            this.Name = "Form1";
            this.Text = "Kombinationsfeld";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAnzeige1;
        private System.Windows.Forms.Button CmdAnzeige2;
        private System.Windows.Forms.Button CmdAnzeige3;
        private System.Windows.Forms.ComboBox CmbWerkzeug1;
        private System.Windows.Forms.ComboBox CmbWerkzeug2;
        private System.Windows.Forms.ComboBox CmbWerkzeug3;
        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.Label LblAnzeige2;
        private System.Windows.Forms.Label LblAnzeige3;
    }
}

