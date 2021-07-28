namespace WPFInForms
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
            this.WFO_Button = new System.Windows.Forms.Button();
            this.EHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.EHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // WFO_Button
            // 
            this.WFO_Button.Location = new System.Drawing.Point(12, 12);
            this.WFO_Button.Name = "WFO_Button";
            this.WFO_Button.Size = new System.Drawing.Size(160, 30);
            this.WFO_Button.TabIndex = 0;
            this.WFO_Button.Text = "button1";
            this.WFO_Button.UseVisualStyleBackColor = true;
            this.WFO_Button.Click += new System.EventHandler(this.WFO_Button_Click);
            // 
            // EHost1
            // 
            this.EHost1.Location = new System.Drawing.Point(12, 48);
            this.EHost1.Name = "EHost1";
            this.EHost1.Size = new System.Drawing.Size(160, 30);
            this.EHost1.TabIndex = 1;
            this.EHost1.Text = "elementHost1";
            this.EHost1.Child = null;
            // 
            // EHost2
            // 
            this.EHost2.Location = new System.Drawing.Point(12, 84);
            this.EHost2.Name = "EHost2";
            this.EHost2.Size = new System.Drawing.Size(200, 100);
            this.EHost2.TabIndex = 2;
            this.EHost2.Text = "elementHost2";
            this.EHost2.Child = null;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(249, 199);
            this.Controls.Add(this.EHost2);
            this.Controls.Add(this.EHost1);
            this.Controls.Add(this.WFO_Button);
            this.Name = "Form1";
            this.Text = "WPFInForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WFO_Button;
        private System.Windows.Forms.Integration.ElementHost EHost1;
        private System.Windows.Forms.Integration.ElementHost EHost2;
    }
}

