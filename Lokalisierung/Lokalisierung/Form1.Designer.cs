namespace Lokalisierung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CmdEins = new System.Windows.Forms.Button();
            this.CmdZwei = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdEins
            // 
            resources.ApplyResources(this.CmdEins, "CmdEins");
            this.CmdEins.Name = "CmdEins";
            this.CmdEins.UseVisualStyleBackColor = true;
            this.CmdEins.Click += new System.EventHandler(this.CmdEins_Click);
            // 
            // CmdZwei
            // 
            resources.ApplyResources(this.CmdZwei, "CmdZwei");
            this.CmdZwei.Name = "CmdZwei";
            this.CmdZwei.UseVisualStyleBackColor = true;
            this.CmdZwei.Click += new System.EventHandler(this.CmdZwei_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmdZwei);
            this.Controls.Add(this.CmdEins);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdEins;
        private System.Windows.Forms.Button CmdZwei;
    }
}

