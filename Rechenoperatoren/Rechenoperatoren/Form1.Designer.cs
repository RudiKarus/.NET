namespace Rechenoperatoren
{
    partial class Rechenoperatoren
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
            this.CmdAusdruck1 = new System.Windows.Forms.Button();
            this.CmdAusdruck2 = new System.Windows.Forms.Button();
            this.CmdAusdruck3 = new System.Windows.Forms.Button();
            this.CmdAusduck4 = new System.Windows.Forms.Button();
            this.CmdAudruck5 = new System.Windows.Forms.Button();
            this.CmdAusdruck6 = new System.Windows.Forms.Button();
            this.CmdVerkettungsoperator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAnzeige.Location = new System.Drawing.Point(27, 27);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(2, 27);
            this.LblAnzeige.TabIndex = 0;
            // 
            // CmdAusdruck1
            // 
            this.CmdAusdruck1.Location = new System.Drawing.Point(580, 4);
            this.CmdAusdruck1.Name = "CmdAusdruck1";
            this.CmdAusdruck1.Size = new System.Drawing.Size(200, 50);
            this.CmdAusdruck1.TabIndex = 1;
            this.CmdAusdruck1.Text = "Ausdruck 1";
            this.CmdAusdruck1.UseVisualStyleBackColor = true;
            this.CmdAusdruck1.Click += new System.EventHandler(this.CmdAusdruck1_Click);
            // 
            // CmdAusdruck2
            // 
            this.CmdAusdruck2.Location = new System.Drawing.Point(580, 60);
            this.CmdAusdruck2.Name = "CmdAusdruck2";
            this.CmdAusdruck2.Size = new System.Drawing.Size(200, 50);
            this.CmdAusdruck2.TabIndex = 2;
            this.CmdAusdruck2.Text = "Ausdruck 2";
            this.CmdAusdruck2.UseVisualStyleBackColor = true;
            this.CmdAusdruck2.Click += new System.EventHandler(this.CmdAusdruck2_Click);
            // 
            // CmdAusdruck3
            // 
            this.CmdAusdruck3.Location = new System.Drawing.Point(580, 116);
            this.CmdAusdruck3.Name = "CmdAusdruck3";
            this.CmdAusdruck3.Size = new System.Drawing.Size(200, 50);
            this.CmdAusdruck3.TabIndex = 3;
            this.CmdAusdruck3.Text = "Ausdruck 3";
            this.CmdAusdruck3.UseVisualStyleBackColor = true;
            this.CmdAusdruck3.Click += new System.EventHandler(this.CmdAusdruck3_Click);
            // 
            // CmdAusduck4
            // 
            this.CmdAusduck4.Location = new System.Drawing.Point(580, 172);
            this.CmdAusduck4.Name = "CmdAusduck4";
            this.CmdAusduck4.Size = new System.Drawing.Size(200, 50);
            this.CmdAusduck4.TabIndex = 4;
            this.CmdAusduck4.Text = "Ausdruck 4";
            this.CmdAusduck4.UseVisualStyleBackColor = true;
            this.CmdAusduck4.Click += new System.EventHandler(this.CmdAusduck4_Click);
            // 
            // CmdAudruck5
            // 
            this.CmdAudruck5.Location = new System.Drawing.Point(580, 228);
            this.CmdAudruck5.Name = "CmdAudruck5";
            this.CmdAudruck5.Size = new System.Drawing.Size(200, 50);
            this.CmdAudruck5.TabIndex = 5;
            this.CmdAudruck5.Text = "Ausdruck 5";
            this.CmdAudruck5.UseVisualStyleBackColor = true;
            this.CmdAudruck5.Click += new System.EventHandler(this.CmdAudruck5_Click);
            // 
            // CmdAusdruck6
            // 
            this.CmdAusdruck6.Location = new System.Drawing.Point(580, 284);
            this.CmdAusdruck6.Name = "CmdAusdruck6";
            this.CmdAusdruck6.Size = new System.Drawing.Size(200, 50);
            this.CmdAusdruck6.TabIndex = 6;
            this.CmdAusdruck6.Text = "Ausdruck 6";
            this.CmdAusdruck6.UseVisualStyleBackColor = true;
            this.CmdAusdruck6.Click += new System.EventHandler(this.CmdAusdruck6_Click);
            // 
            // CmdVerkettungsoperator
            // 
            this.CmdVerkettungsoperator.Location = new System.Drawing.Point(530, 340);
            this.CmdVerkettungsoperator.Name = "CmdVerkettungsoperator";
            this.CmdVerkettungsoperator.Size = new System.Drawing.Size(250, 50);
            this.CmdVerkettungsoperator.TabIndex = 7;
            this.CmdVerkettungsoperator.Text = "Verkettungsoperatoren";
            this.CmdVerkettungsoperator.UseVisualStyleBackColor = true;
            this.CmdVerkettungsoperator.Click += new System.EventHandler(this.CmdVerkettungsoperator_Click);
            // 
            // Rechenoperatoren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdVerkettungsoperator);
            this.Controls.Add(this.CmdAusdruck6);
            this.Controls.Add(this.CmdAudruck5);
            this.Controls.Add(this.CmdAusduck4);
            this.Controls.Add(this.CmdAusdruck3);
            this.Controls.Add(this.CmdAusdruck2);
            this.Controls.Add(this.CmdAusdruck1);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Rechenoperatoren";
            this.Text = "Rechenoperatoren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdAusdruck1;
        private System.Windows.Forms.Button CmdAusdruck2;
        private System.Windows.Forms.Button CmdAusdruck3;
        private System.Windows.Forms.Button CmdAusduck4;
        private System.Windows.Forms.Button CmdAudruck5;
        private System.Windows.Forms.Button CmdAusdruck6;
        private System.Windows.Forms.Button CmdVerkettungsoperator;
    }
}

