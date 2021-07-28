namespace StringTeilzeichenkette
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
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.NumPosition = new System.Windows.Forms.NumericUpDown();
            this.NumLaenge = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLaenge)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAnzeigen
            // 
            this.CmdAnzeigen.Location = new System.Drawing.Point(55, 332);
            this.CmdAnzeigen.Name = "CmdAnzeigen";
            this.CmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen.TabIndex = 0;
            this.CmdAnzeigen.Text = "Anzeigen";
            this.CmdAnzeigen.UseVisualStyleBackColor = true;
            this.CmdAnzeigen.Click += new System.EventHandler(this.CmdAnzeigen_Click);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(55, 71);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe.TabIndex = 1;
            this.TxtEingabe.TextChanged += new System.EventHandler(this.TxtEingabe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eingabe:";
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(50, 119);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 3;
            this.LblAnzeige.Text = "label2";
            // 
            // NumPosition
            // 
            this.NumPosition.Location = new System.Drawing.Point(55, 230);
            this.NumPosition.Name = "NumPosition";
            this.NumPosition.Size = new System.Drawing.Size(120, 31);
            this.NumPosition.TabIndex = 4;
            this.NumPosition.ValueChanged += new System.EventHandler(this.NumPosition_ValueChanged);
            // 
            // NumLaenge
            // 
            this.NumLaenge.Location = new System.Drawing.Point(55, 295);
            this.NumLaenge.Name = "NumLaenge";
            this.NumLaenge.Size = new System.Drawing.Size(120, 31);
            this.NumLaenge.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teilstring ab Position: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Länge:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(598, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumLaenge);
            this.Controls.Add(this.NumPosition);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.CmdAnzeigen);
            this.Name = "Form1";
            this.Text = "Strings | Teilzeichenkette";
            ((System.ComponentModel.ISupportInitialize)(this.NumPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLaenge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAnzeigen;
        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.NumericUpDown NumPosition;
        private System.Windows.Forms.NumericUpDown NumLaenge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

