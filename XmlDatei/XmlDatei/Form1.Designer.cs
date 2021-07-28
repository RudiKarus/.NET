namespace XmlDatei
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
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdSchreiben = new System.Windows.Forms.Button();
            this.CmdLesen = new System.Windows.Forms.Button();
            this.CmdObjekteIn = new System.Windows.Forms.Button();
            this.CmdObjekteAus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(25, 26);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 0;
            this.LblAnzeige.Text = "label1";
            // 
            // CmdSchreiben
            // 
            this.CmdSchreiben.Location = new System.Drawing.Point(228, 26);
            this.CmdSchreiben.Name = "CmdSchreiben";
            this.CmdSchreiben.Size = new System.Drawing.Size(150, 25);
            this.CmdSchreiben.TabIndex = 1;
            this.CmdSchreiben.Text = "XML-Datei schreiben";
            this.CmdSchreiben.UseVisualStyleBackColor = true;
            this.CmdSchreiben.Click += new System.EventHandler(this.CmdSchreiben_Click);
            // 
            // CmdLesen
            // 
            this.CmdLesen.Location = new System.Drawing.Point(228, 57);
            this.CmdLesen.Name = "CmdLesen";
            this.CmdLesen.Size = new System.Drawing.Size(150, 25);
            this.CmdLesen.TabIndex = 2;
            this.CmdLesen.Text = "XML-Datei lesen";
            this.CmdLesen.UseVisualStyleBackColor = true;
            this.CmdLesen.Click += new System.EventHandler(this.CmdLesen_Click);
            // 
            // CmdObjekteIn
            // 
            this.CmdObjekteIn.Location = new System.Drawing.Point(228, 121);
            this.CmdObjekteIn.Name = "CmdObjekteIn";
            this.CmdObjekteIn.Size = new System.Drawing.Size(150, 25);
            this.CmdObjekteIn.TabIndex = 3;
            this.CmdObjekteIn.Text = "Objekte in XML-Datei";
            this.CmdObjekteIn.UseVisualStyleBackColor = true;
            this.CmdObjekteIn.Click += new System.EventHandler(this.CmdObjekteIn_Click);
            // 
            // CmdObjekteAus
            // 
            this.CmdObjekteAus.Location = new System.Drawing.Point(228, 152);
            this.CmdObjekteAus.Name = "CmdObjekteAus";
            this.CmdObjekteAus.Size = new System.Drawing.Size(150, 25);
            this.CmdObjekteAus.TabIndex = 4;
            this.CmdObjekteAus.Text = "Objekte aus XML-Datei";
            this.CmdObjekteAus.UseVisualStyleBackColor = true;
            this.CmdObjekteAus.Click += new System.EventHandler(this.CmdObjekteAus_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(403, 276);
            this.Controls.Add(this.CmdObjekteAus);
            this.Controls.Add(this.CmdObjekteIn);
            this.Controls.Add(this.CmdLesen);
            this.Controls.Add(this.CmdSchreiben);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Form1";
            this.Text = "XML-Dateien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdSchreiben;
        private System.Windows.Forms.Button CmdLesen;
        private System.Windows.Forms.Button CmdObjekteIn;
        private System.Windows.Forms.Button CmdObjekteAus;
    }
}

