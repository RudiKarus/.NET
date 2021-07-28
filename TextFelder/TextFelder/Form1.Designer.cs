namespace TextFelder
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
            this.CmdAusgabe = new System.Windows.Forms.Button();
            this.CmdRechnen = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.NumEingabe = new System.Windows.Forms.NumericUpDown();
            this.LblAusgabe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumEingabe)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(110, 119);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe.TabIndex = 0;
            // 
            // CmdAusgabe
            // 
            this.CmdAusgabe.Location = new System.Drawing.Point(547, 119);
            this.CmdAusgabe.Name = "CmdAusgabe";
            this.CmdAusgabe.Size = new System.Drawing.Size(200, 50);
            this.CmdAusgabe.TabIndex = 1;
            this.CmdAusgabe.Text = "Ausgabe";
            this.CmdAusgabe.UseVisualStyleBackColor = true;
            this.CmdAusgabe.Click += new System.EventHandler(this.CmdAusgabe_Click);
            // 
            // CmdRechnen
            // 
            this.CmdRechnen.Location = new System.Drawing.Point(547, 177);
            this.CmdRechnen.Name = "CmdRechnen";
            this.CmdRechnen.Size = new System.Drawing.Size(200, 50);
            this.CmdRechnen.TabIndex = 2;
            this.CmdRechnen.Text = "Rechnen";
            this.CmdRechnen.UseVisualStyleBackColor = true;
            this.CmdRechnen.Click += new System.EventHandler(this.CmdRechnen_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(210, 378);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 25);
            this.LblAnzeige.TabIndex = 3;
            // 
            // NumEingabe
            // 
            this.NumEingabe.DecimalPlaces = 1;
            this.NumEingabe.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumEingabe.Location = new System.Drawing.Point(110, 156);
            this.NumEingabe.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumEingabe.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.NumEingabe.Name = "NumEingabe";
            this.NumEingabe.Size = new System.Drawing.Size(120, 31);
            this.NumEingabe.TabIndex = 4;
            this.NumEingabe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumEingabe.ValueChanged += new System.EventHandler(this.NumEingabe_ValueChanged);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(105, 190);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(0, 25);
            this.LblAusgabe.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.NumEingabe);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdRechnen);
            this.Controls.Add(this.CmdAusgabe);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumEingabe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Button CmdAusgabe;
        private System.Windows.Forms.Button CmdRechnen;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.NumericUpDown NumEingabe;
        private System.Windows.Forms.Label LblAusgabe;
    }
}

