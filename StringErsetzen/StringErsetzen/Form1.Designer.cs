namespace StringErsetzen
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
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.TxtSuchen = new System.Windows.Forms.TextBox();
            this.TxtErsetzen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmdErsetzen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(65, 48);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe.TabIndex = 0;
            // 
            // TxtSuchen
            // 
            this.TxtSuchen.Location = new System.Drawing.Point(65, 206);
            this.TxtSuchen.Name = "TxtSuchen";
            this.TxtSuchen.Size = new System.Drawing.Size(100, 31);
            this.TxtSuchen.TabIndex = 1;
            // 
            // TxtErsetzen
            // 
            this.TxtErsetzen.Location = new System.Drawing.Point(65, 283);
            this.TxtErsetzen.Name = "TxtErsetzen";
            this.TxtErsetzen.Size = new System.Drawing.Size(100, 31);
            this.TxtErsetzen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eingabe:";
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(60, 106);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 4;
            this.LblAnzeige.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ersetze:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "durch:";
            // 
            // CmdErsetzen
            // 
            this.CmdErsetzen.Location = new System.Drawing.Point(65, 332);
            this.CmdErsetzen.Name = "CmdErsetzen";
            this.CmdErsetzen.Size = new System.Drawing.Size(75, 23);
            this.CmdErsetzen.TabIndex = 7;
            this.CmdErsetzen.Text = "Ersetzen";
            this.CmdErsetzen.UseVisualStyleBackColor = true;
            this.CmdErsetzen.Click += new System.EventHandler(this.CmdErsetzen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdErsetzen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtErsetzen);
            this.Controls.Add(this.TxtSuchen);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Strings | Ersetzen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.TextBox TxtSuchen;
        private System.Windows.Forms.TextBox TxtErsetzen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CmdErsetzen;
    }
}

