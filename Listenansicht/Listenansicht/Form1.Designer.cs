namespace Listenansicht
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
            this.LView = new System.Windows.Forms.ListView();
            this.OptDetails = new System.Windows.Forms.RadioButton();
            this.OptLargeIcon = new System.Windows.Forms.RadioButton();
            this.OptList = new System.Windows.Forms.RadioButton();
            this.OptSmallIcon = new System.Windows.Forms.RadioButton();
            this.OptTile = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LView
            // 
            this.LView.Location = new System.Drawing.Point(62, 63);
            this.LView.Name = "LView";
            this.LView.Size = new System.Drawing.Size(311, 160);
            this.LView.TabIndex = 0;
            this.LView.UseCompatibleStateImageBehavior = false;
            // 
            // OptDetails
            // 
            this.OptDetails.AutoSize = true;
            this.OptDetails.Location = new System.Drawing.Point(420, 63);
            this.OptDetails.Name = "OptDetails";
            this.OptDetails.Size = new System.Drawing.Size(109, 29);
            this.OptDetails.TabIndex = 1;
            this.OptDetails.TabStop = true;
            this.OptDetails.Text = "Details";
            this.OptDetails.UseVisualStyleBackColor = true;
            this.OptDetails.CheckedChanged += new System.EventHandler(this.OptView_CheckedChanged);
            // 
            // OptLargeIcon
            // 
            this.OptLargeIcon.AutoSize = true;
            this.OptLargeIcon.Location = new System.Drawing.Point(420, 98);
            this.OptLargeIcon.Name = "OptLargeIcon";
            this.OptLargeIcon.Size = new System.Drawing.Size(138, 29);
            this.OptLargeIcon.TabIndex = 2;
            this.OptLargeIcon.TabStop = true;
            this.OptLargeIcon.Text = "LargeIcon";
            this.OptLargeIcon.UseVisualStyleBackColor = true;
            this.OptLargeIcon.CheckedChanged += new System.EventHandler(this.OptView_CheckedChanged);
            // 
            // OptList
            // 
            this.OptList.AutoSize = true;
            this.OptList.Location = new System.Drawing.Point(420, 133);
            this.OptList.Name = "OptList";
            this.OptList.Size = new System.Drawing.Size(77, 29);
            this.OptList.TabIndex = 3;
            this.OptList.TabStop = true;
            this.OptList.Text = "List";
            this.OptList.UseVisualStyleBackColor = true;
            this.OptList.CheckedChanged += new System.EventHandler(this.OptView_CheckedChanged);
            // 
            // OptSmallIcon
            // 
            this.OptSmallIcon.AutoSize = true;
            this.OptSmallIcon.Location = new System.Drawing.Point(420, 168);
            this.OptSmallIcon.Name = "OptSmallIcon";
            this.OptSmallIcon.Size = new System.Drawing.Size(136, 29);
            this.OptSmallIcon.TabIndex = 4;
            this.OptSmallIcon.TabStop = true;
            this.OptSmallIcon.Text = "SmallIcon";
            this.OptSmallIcon.UseVisualStyleBackColor = true;
            this.OptSmallIcon.CheckedChanged += new System.EventHandler(this.OptView_CheckedChanged);
            // 
            // OptTile
            // 
            this.OptTile.AutoSize = true;
            this.OptTile.Location = new System.Drawing.Point(420, 203);
            this.OptTile.Name = "OptTile";
            this.OptTile.Size = new System.Drawing.Size(78, 29);
            this.OptTile.TabIndex = 5;
            this.OptTile.TabStop = true;
            this.OptTile.Text = "Tile";
            this.OptTile.UseVisualStyleBackColor = true;
            this.OptTile.CheckedChanged += new System.EventHandler(this.OptView_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(617, 295);
            this.Controls.Add(this.OptTile);
            this.Controls.Add(this.OptSmallIcon);
            this.Controls.Add(this.OptList);
            this.Controls.Add(this.OptLargeIcon);
            this.Controls.Add(this.OptDetails);
            this.Controls.Add(this.LView);
            this.Name = "Form1";
            this.Text = "Listenansicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LView;
        private System.Windows.Forms.RadioButton OptDetails;
        private System.Windows.Forms.RadioButton OptLargeIcon;
        private System.Windows.Forms.RadioButton OptList;
        private System.Windows.Forms.RadioButton OptSmallIcon;
        private System.Windows.Forms.RadioButton OptTile;
    }
}

