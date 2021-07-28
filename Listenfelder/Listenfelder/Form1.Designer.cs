namespace Listenfelder
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
            this.CmdToRight = new System.Windows.Forms.Button();
            this.CmdToLeft = new System.Windows.Forms.Button();
            this.LstBox2 = new System.Windows.Forms.ListBox();
            this.LstBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CmdToRight
            // 
            this.CmdToRight.Location = new System.Drawing.Point(315, 176);
            this.CmdToRight.Name = "CmdToRight";
            this.CmdToRight.Size = new System.Drawing.Size(75, 23);
            this.CmdToRight.TabIndex = 0;
            this.CmdToRight.Text = ">>";
            this.CmdToRight.UseVisualStyleBackColor = true;
            this.CmdToRight.Click += new System.EventHandler(this.CmdToRight_Click);
            // 
            // CmdToLeft
            // 
            this.CmdToLeft.Location = new System.Drawing.Point(315, 232);
            this.CmdToLeft.Name = "CmdToLeft";
            this.CmdToLeft.Size = new System.Drawing.Size(75, 23);
            this.CmdToLeft.TabIndex = 1;
            this.CmdToLeft.Text = "<<";
            this.CmdToLeft.UseVisualStyleBackColor = true;
            this.CmdToLeft.Click += new System.EventHandler(this.CmdToLeft_Click);
            // 
            // LstBox2
            // 
            this.LstBox2.FormattingEnabled = true;
            this.LstBox2.ItemHeight = 25;
            this.LstBox2.Location = new System.Drawing.Point(520, 176);
            this.LstBox2.Name = "LstBox2";
            this.LstBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstBox2.Size = new System.Drawing.Size(120, 79);
            this.LstBox2.TabIndex = 2;
            // 
            // LstBox1
            // 
            this.LstBox1.FormattingEnabled = true;
            this.LstBox1.ItemHeight = 25;
            this.LstBox1.Location = new System.Drawing.Point(75, 176);
            this.LstBox1.Name = "LstBox1";
            this.LstBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstBox1.Size = new System.Drawing.Size(120, 79);
            this.LstBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstBox1);
            this.Controls.Add(this.LstBox2);
            this.Controls.Add(this.CmdToLeft);
            this.Controls.Add(this.CmdToRight);
            this.Name = "Form1";
            this.Text = "Listenfelder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdToRight;
        private System.Windows.Forms.Button CmdToLeft;
        private System.Windows.Forms.ListBox LstBox2;
        private System.Windows.Forms.ListBox LstBox1;
    }
}

