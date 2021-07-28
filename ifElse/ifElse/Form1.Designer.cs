namespace ifElse
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
            this.CmdAnzeige1 = new System.Windows.Forms.Button();
            this.CmdAnzeige2 = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.NumX = new System.Windows.Forms.NumericUpDown();
            this.NumY = new System.Windows.Forms.NumericUpDown();
            this.CmdAnzeige3 = new System.Windows.Forms.Button();
            this.CmdAnzeige4 = new System.Windows.Forms.Button();
            this.CmdAnzeige5 = new System.Windows.Forms.Button();
            this.CmdAnzeige6 = new System.Windows.Forms.Button();
            this.CmdAnzeige7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumY)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAnzeige1
            // 
            this.CmdAnzeige1.Location = new System.Drawing.Point(57, 49);
            this.CmdAnzeige1.Name = "CmdAnzeige1";
            this.CmdAnzeige1.Size = new System.Drawing.Size(120, 60);
            this.CmdAnzeige1.TabIndex = 2;
            this.CmdAnzeige1.Text = "if";
            this.CmdAnzeige1.UseVisualStyleBackColor = true;
            this.CmdAnzeige1.Click += new System.EventHandler(this.CmdAnzeige1_Click);
            // 
            // CmdAnzeige2
            // 
            this.CmdAnzeige2.Location = new System.Drawing.Point(57, 126);
            this.CmdAnzeige2.Name = "CmdAnzeige2";
            this.CmdAnzeige2.Size = new System.Drawing.Size(120, 60);
            this.CmdAnzeige2.TabIndex = 3;
            this.CmdAnzeige2.Text = "if else";
            this.CmdAnzeige2.UseVisualStyleBackColor = true;
            this.CmdAnzeige2.Click += new System.EventHandler(this.CmdAnzeige2_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(276, 192);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 25);
            this.LblAnzeige.TabIndex = 4;
            // 
            // NumX
            // 
            this.NumX.Location = new System.Drawing.Point(281, 65);
            this.NumX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumX.Name = "NumX";
            this.NumX.Size = new System.Drawing.Size(120, 31);
            this.NumX.TabIndex = 5;
            this.NumX.Tag = "";
            // 
            // NumY
            // 
            this.NumY.Location = new System.Drawing.Point(281, 126);
            this.NumY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumY.Name = "NumY";
            this.NumY.Size = new System.Drawing.Size(120, 31);
            this.NumY.TabIndex = 6;
            // 
            // CmdAnzeige3
            // 
            this.CmdAnzeige3.Location = new System.Drawing.Point(57, 202);
            this.CmdAnzeige3.Name = "CmdAnzeige3";
            this.CmdAnzeige3.Size = new System.Drawing.Size(120, 65);
            this.CmdAnzeige3.TabIndex = 7;
            this.CmdAnzeige3.Text = "ternärer Operator";
            this.CmdAnzeige3.UseVisualStyleBackColor = true;
            this.CmdAnzeige3.Click += new System.EventHandler(this.CmdAnzeige3_Click);
            // 
            // CmdAnzeige4
            // 
            this.CmdAnzeige4.Location = new System.Drawing.Point(57, 284);
            this.CmdAnzeige4.Name = "CmdAnzeige4";
            this.CmdAnzeige4.Size = new System.Drawing.Size(120, 60);
            this.CmdAnzeige4.TabIndex = 8;
            this.CmdAnzeige4.Text = "if else if";
            this.CmdAnzeige4.UseVisualStyleBackColor = true;
            this.CmdAnzeige4.Click += new System.EventHandler(this.CmdAnzeige4_Click);
            // 
            // CmdAnzeige5
            // 
            this.CmdAnzeige5.Location = new System.Drawing.Point(57, 362);
            this.CmdAnzeige5.Name = "CmdAnzeige5";
            this.CmdAnzeige5.Size = new System.Drawing.Size(120, 60);
            this.CmdAnzeige5.TabIndex = 9;
            this.CmdAnzeige5.Text = "log. Und";
            this.CmdAnzeige5.UseVisualStyleBackColor = true;
            this.CmdAnzeige5.Click += new System.EventHandler(this.CmdAnzeige5_Click);
            // 
            // CmdAnzeige6
            // 
            this.CmdAnzeige6.Location = new System.Drawing.Point(57, 437);
            this.CmdAnzeige6.Name = "CmdAnzeige6";
            this.CmdAnzeige6.Size = new System.Drawing.Size(120, 60);
            this.CmdAnzeige6.TabIndex = 10;
            this.CmdAnzeige6.Text = "log. Oder";
            this.CmdAnzeige6.UseVisualStyleBackColor = true;
            this.CmdAnzeige6.Click += new System.EventHandler(this.CmdAnzeige6_Click);
            // 
            // CmdAnzeige7
            // 
            this.CmdAnzeige7.Location = new System.Drawing.Point(57, 518);
            this.CmdAnzeige7.Name = "CmdAnzeige7";
            this.CmdAnzeige7.Size = new System.Drawing.Size(120, 60);
            this.CmdAnzeige7.TabIndex = 11;
            this.CmdAnzeige7.Text = "log. exkl. Oder";
            this.CmdAnzeige7.UseVisualStyleBackColor = true;
            this.CmdAnzeige7.Click += new System.EventHandler(this.CmdAnzeige7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 608);
            this.Controls.Add(this.CmdAnzeige7);
            this.Controls.Add(this.CmdAnzeige6);
            this.Controls.Add(this.CmdAnzeige5);
            this.Controls.Add(this.CmdAnzeige4);
            this.Controls.Add(this.CmdAnzeige3);
            this.Controls.Add(this.NumY);
            this.Controls.Add(this.NumX);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAnzeige2);
            this.Controls.Add(this.CmdAnzeige1);
            this.Name = "Form1";
            this.Text = "ifElse";
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdAnzeige1;
        private System.Windows.Forms.Button CmdAnzeige2;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.NumericUpDown NumX;
        private System.Windows.Forms.NumericUpDown NumY;
        private System.Windows.Forms.Button CmdAnzeige3;
        private System.Windows.Forms.Button CmdAnzeige4;
        private System.Windows.Forms.Button CmdAnzeige5;
        private System.Windows.Forms.Button CmdAnzeige6;
        private System.Windows.Forms.Button CmdAnzeige7;
    }
}

