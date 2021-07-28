namespace MethodeUebergabe
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
            this.CmdKopie = new System.Windows.Forms.Button();
            this.CmdReferenz = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdEindimFeld = new System.Windows.Forms.Button();
            this.CmdDreidimFeld = new System.Windows.Forms.Button();
            this.CmdOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdKopie
            // 
            this.CmdKopie.Location = new System.Drawing.Point(12, 12);
            this.CmdKopie.Name = "CmdKopie";
            this.CmdKopie.Size = new System.Drawing.Size(75, 23);
            this.CmdKopie.TabIndex = 0;
            this.CmdKopie.Text = "Kopie";
            this.CmdKopie.UseVisualStyleBackColor = true;
            this.CmdKopie.Click += new System.EventHandler(this.CmdKopie_Click);
            // 
            // CmdReferenz
            // 
            this.CmdReferenz.Location = new System.Drawing.Point(93, 12);
            this.CmdReferenz.Name = "CmdReferenz";
            this.CmdReferenz.Size = new System.Drawing.Size(75, 23);
            this.CmdReferenz.TabIndex = 1;
            this.CmdReferenz.Text = "Referenz";
            this.CmdReferenz.UseVisualStyleBackColor = true;
            this.CmdReferenz.Click += new System.EventHandler(this.CmdReferenz_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 38);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 2;
            this.LblAnzeige.Text = "label1";
            // 
            // CmdEindimFeld
            // 
            this.CmdEindimFeld.Location = new System.Drawing.Point(204, 12);
            this.CmdEindimFeld.Name = "CmdEindimFeld";
            this.CmdEindimFeld.Size = new System.Drawing.Size(75, 23);
            this.CmdEindimFeld.TabIndex = 3;
            this.CmdEindimFeld.Text = "Eindimensionales Feld";
            this.CmdEindimFeld.UseVisualStyleBackColor = true;
            this.CmdEindimFeld.Click += new System.EventHandler(this.CmdEindimFeld_Click);
            // 
            // CmdDreidimFeld
            // 
            this.CmdDreidimFeld.Location = new System.Drawing.Point(285, 12);
            this.CmdDreidimFeld.Name = "CmdDreidimFeld";
            this.CmdDreidimFeld.Size = new System.Drawing.Size(75, 23);
            this.CmdDreidimFeld.TabIndex = 4;
            this.CmdDreidimFeld.Text = "Dreidimensionales Feld";
            this.CmdDreidimFeld.UseVisualStyleBackColor = true;
            this.CmdDreidimFeld.Click += new System.EventHandler(this.CmdDreidimFeld_Click);
            // 
            // CmdOut
            // 
            this.CmdOut.Location = new System.Drawing.Point(378, 12);
            this.CmdOut.Name = "CmdOut";
            this.CmdOut.Size = new System.Drawing.Size(75, 23);
            this.CmdOut.TabIndex = 5;
            this.CmdOut.Text = "Out";
            this.CmdOut.UseVisualStyleBackColor = true;
            this.CmdOut.Click += new System.EventHandler(this.CmdOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(486, 211);
            this.Controls.Add(this.CmdOut);
            this.Controls.Add(this.CmdDreidimFeld);
            this.Controls.Add(this.CmdEindimFeld);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdReferenz);
            this.Controls.Add(this.CmdKopie);
            this.Name = "Form1";
            this.Text = "MethodenUebergabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdKopie;
        private System.Windows.Forms.Button CmdReferenz;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdEindimFeld;
        private System.Windows.Forms.Button CmdDreidimFeld;
        private System.Windows.Forms.Button CmdOut;
    }
}

