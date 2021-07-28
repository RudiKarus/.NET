namespace Listenfeld
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
            this.LstSpeisen = new System.Windows.Forms.ListBox();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnEreignis = new System.Windows.Forms.Button();
            this.LblAuswahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstSpeisen
            // 
            this.LstSpeisen.FormattingEnabled = true;
            this.LstSpeisen.ItemHeight = 25;
            this.LstSpeisen.Location = new System.Drawing.Point(85, 65);
            this.LstSpeisen.Name = "LstSpeisen";
            this.LstSpeisen.Size = new System.Drawing.Size(229, 54);
            this.LstSpeisen.TabIndex = 0;
            this.LstSpeisen.SelectedIndexChanged += new System.EventHandler(this.LstSpeisen_SelectedIndexChanged);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(80, 148);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 1;
            this.LblAnzeige.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "forEach";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnEreignis
            // 
            this.BtnEreignis.Location = new System.Drawing.Point(594, 210);
            this.BtnEreignis.Name = "BtnEreignis";
            this.BtnEreignis.Size = new System.Drawing.Size(100, 35);
            this.BtnEreignis.TabIndex = 4;
            this.BtnEreignis.Text = "Ereignis";
            this.BtnEreignis.UseVisualStyleBackColor = true;
            this.BtnEreignis.Click += new System.EventHandler(this.BtnEreignis_Click);
            // 
            // LblAuswahl
            // 
            this.LblAuswahl.AutoSize = true;
            this.LblAuswahl.Location = new System.Drawing.Point(589, 265);
            this.LblAuswahl.Name = "LblAuswahl";
            this.LblAuswahl.Size = new System.Drawing.Size(70, 25);
            this.LblAuswahl.TabIndex = 5;
            this.LblAuswahl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAuswahl);
            this.Controls.Add(this.BtnEreignis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.LstSpeisen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSpeisen;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnEreignis;
        private System.Windows.Forms.Label LblAuswahl;
    }
}

