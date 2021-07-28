namespace TastaturMaus
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.PanMouse = new System.Windows.Forms.Panel();
            this.LblEingabe = new System.Windows.Forms.Label();
            this.LblMouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(12, 12);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 0;
            this.TxtEingabe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEingabe_KeyDown);
            // 
            // PanMouse
            // 
            this.PanMouse.Location = new System.Drawing.Point(12, 67);
            this.PanMouse.Name = "PanMouse";
            this.PanMouse.Size = new System.Drawing.Size(200, 100);
            this.PanMouse.TabIndex = 1;
            this.PanMouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanMouse_MouseDown);
            // 
            // LblEingabe
            // 
            this.LblEingabe.AutoSize = true;
            this.LblEingabe.Location = new System.Drawing.Point(9, 35);
            this.LblEingabe.Name = "LblEingabe";
            this.LblEingabe.Size = new System.Drawing.Size(35, 13);
            this.LblEingabe.TabIndex = 0;
            this.LblEingabe.Text = "label1";
            // 
            // LblMouse
            // 
            this.LblMouse.AutoSize = true;
            this.LblMouse.Location = new System.Drawing.Point(9, 180);
            this.LblMouse.Name = "LblMouse";
            this.LblMouse.Size = new System.Drawing.Size(35, 13);
            this.LblMouse.TabIndex = 1;
            this.LblMouse.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 220);
            this.Controls.Add(this.LblEingabe);
            this.Controls.Add(this.LblMouse);
            this.Controls.Add(this.PanMouse);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Tastatur und Maus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Panel PanMouse;
        private System.Windows.Forms.Label LblEingabe;
        private System.Windows.Forms.Label LblMouse;
    }
}

