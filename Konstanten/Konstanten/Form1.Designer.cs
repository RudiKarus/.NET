namespace Konstanten
{
    partial class KonstantenEnumeration
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
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdKonstanten = new System.Windows.Forms.Button();
            this.CmdEnumeration1 = new System.Windows.Forms.Button();
            this.CmdEnumeration2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 12);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(2, 27);
            this.LblAnzeige.TabIndex = 0;
            // 
            // CmdKonstanten
            // 
            this.CmdKonstanten.Location = new System.Drawing.Point(588, 12);
            this.CmdKonstanten.Name = "CmdKonstanten";
            this.CmdKonstanten.Size = new System.Drawing.Size(200, 50);
            this.CmdKonstanten.TabIndex = 1;
            this.CmdKonstanten.Text = "Konstanten";
            this.CmdKonstanten.UseVisualStyleBackColor = true;
            this.CmdKonstanten.Click += new System.EventHandler(this.CmdKonstanten_Click);
            // 
            // CmdEnumeration1
            // 
            this.CmdEnumeration1.Location = new System.Drawing.Point(588, 124);
            this.CmdEnumeration1.Name = "CmdEnumeration1";
            this.CmdEnumeration1.Size = new System.Drawing.Size(200, 50);
            this.CmdEnumeration1.TabIndex = 2;
            this.CmdEnumeration1.Text = "Enumeration 1";
            this.CmdEnumeration1.UseVisualStyleBackColor = true;
            this.CmdEnumeration1.Click += new System.EventHandler(this.CmdEnumeration1_Click);
            // 
            // CmdEnumeration2
            // 
            this.CmdEnumeration2.Location = new System.Drawing.Point(588, 68);
            this.CmdEnumeration2.Name = "CmdEnumeration2";
            this.CmdEnumeration2.Size = new System.Drawing.Size(200, 50);
            this.CmdEnumeration2.TabIndex = 3;
            this.CmdEnumeration2.Text = "Enumeration 2";
            this.CmdEnumeration2.UseVisualStyleBackColor = true;
            this.CmdEnumeration2.Click += new System.EventHandler(this.CmdEnumeration2_Click);
            // 
            // KonstantenEnumeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdEnumeration2);
            this.Controls.Add(this.CmdEnumeration1);
            this.Controls.Add(this.CmdKonstanten);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "KonstantenEnumeration";
            this.Text = "Konstanten & Enumeration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdKonstanten;
        private System.Windows.Forms.Button CmdEnumeration1;
        private System.Windows.Forms.Button CmdEnumeration2;
    }
}

