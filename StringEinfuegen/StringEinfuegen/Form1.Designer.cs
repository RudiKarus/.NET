namespace StringEinfuegen
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
            this.CmdEinfuegen = new System.Windows.Forms.Button();
            this.TxtEinfuegen = new System.Windows.Forms.TextBox();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.NumEinfuegen = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumEinfuegen)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(146, 68);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe.TabIndex = 0;
            this.TxtEingabe.TextChanged += new System.EventHandler(this.TxtEingabe_TextChanged);
            // 
            // CmdEinfuegen
            // 
            this.CmdEinfuegen.Location = new System.Drawing.Point(146, 246);
            this.CmdEinfuegen.Name = "CmdEinfuegen";
            this.CmdEinfuegen.Size = new System.Drawing.Size(75, 23);
            this.CmdEinfuegen.TabIndex = 1;
            this.CmdEinfuegen.Text = "Einfügen";
            this.CmdEinfuegen.UseVisualStyleBackColor = true;
            this.CmdEinfuegen.Click += new System.EventHandler(this.CmdEinfuegen_Click);
            // 
            // TxtEinfuegen
            // 
            this.TxtEinfuegen.Location = new System.Drawing.Point(146, 172);
            this.TxtEinfuegen.Name = "TxtEinfuegen";
            this.TxtEinfuegen.Size = new System.Drawing.Size(100, 31);
            this.TxtEinfuegen.TabIndex = 2;
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(146, 102);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 4;
            this.LblAnzeige.Text = "label1";
            // 
            // NumEinfuegen
            // 
            this.NumEinfuegen.Location = new System.Drawing.Point(146, 209);
            this.NumEinfuegen.Name = "NumEinfuegen";
            this.NumEinfuegen.Size = new System.Drawing.Size(120, 31);
            this.NumEinfuegen.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 355);
            this.Controls.Add(this.NumEinfuegen);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.TxtEinfuegen);
            this.Controls.Add(this.CmdEinfuegen);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Strings | Einfügen";
            ((System.ComponentModel.ISupportInitialize)(this.NumEinfuegen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Button CmdEinfuegen;
        private System.Windows.Forms.TextBox TxtEinfuegen;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.NumericUpDown NumEinfuegen;
    }
}

