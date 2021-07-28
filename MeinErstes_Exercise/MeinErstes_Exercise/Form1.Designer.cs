namespace MeinErstes_Exercise
{
    partial class MeinErstes
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
            this.BtnName = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblText = new System.Windows.Forms.Label();
            this.BtnName2 = new System.Windows.Forms.Button();
            this.LblText2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnName
            // 
            this.BtnName.Location = new System.Drawing.Point(338, 209);
            this.BtnName.Name = "BtnName";
            this.BtnName.Size = new System.Drawing.Size(80, 27);
            this.BtnName.TabIndex = 0;
            this.BtnName.Text = "Vorname";
            this.BtnName.UseVisualStyleBackColor = true;
            this.BtnName.Click += new System.EventHandler(this.BtnName_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(385, 285);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(80, 27);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblText.Location = new System.Drawing.Point(338, 147);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(64, 27);
            this.LblText.TabIndex = 2;
            this.LblText.Text = "(leer)";
            // 
            // BtnName2
            // 
            this.BtnName2.Location = new System.Drawing.Point(434, 209);
            this.BtnName2.Name = "BtnName2";
            this.BtnName2.Size = new System.Drawing.Size(80, 27);
            this.BtnName2.TabIndex = 3;
            this.BtnName2.Text = "Nachname";
            this.BtnName2.UseVisualStyleBackColor = true;
            this.BtnName2.Click += new System.EventHandler(this.BtnName2_Click);
            // 
            // LblText2
            // 
            this.LblText2.AutoSize = true;
            this.LblText2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblText2.Location = new System.Drawing.Point(434, 147);
            this.LblText2.Name = "LblText2";
            this.LblText2.Size = new System.Drawing.Size(64, 27);
            this.LblText2.TabIndex = 5;
            this.LblText2.Text = "(leer)";
            // 
            // MeinErstes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblText2);
            this.Controls.Add(this.BtnName2);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnName);
            this.Name = "MeinErstes";
            this.Text = "MeinErstes_Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnName;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Button BtnName2;
        private System.Windows.Forms.Label LblText2;
    }
}

