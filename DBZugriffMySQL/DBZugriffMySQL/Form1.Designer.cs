﻿namespace DBZugriffMySQL
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
            this.CmdAlleSehen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdAlleSehen
            // 
            this.CmdAlleSehen.Location = new System.Drawing.Point(28, 29);
            this.CmdAlleSehen.Name = "CmdAlleSehen";
            this.CmdAlleSehen.Size = new System.Drawing.Size(75, 23);
            this.CmdAlleSehen.TabIndex = 0;
            this.CmdAlleSehen.Text = "Alle sehen";
            this.CmdAlleSehen.UseVisualStyleBackColor = true;
            this.CmdAlleSehen.Click += new System.EventHandler(this.CmdAlleSehen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdAlleSehen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdAlleSehen;
    }
}

