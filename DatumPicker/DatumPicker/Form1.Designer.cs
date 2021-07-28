namespace DatumPicker
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
            this.DatPicker1 = new System.Windows.Forms.DateTimePicker();
            this.DatPicker2 = new System.Windows.Forms.DateTimePicker();
            this.DatPicker3 = new System.Windows.Forms.DateTimePicker();
            this.DatPicker4 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDatum = new System.Windows.Forms.Label();
            this.LblPlusTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DatPicker1
            // 
            this.DatPicker1.Location = new System.Drawing.Point(191, 98);
            this.DatPicker1.Name = "DatPicker1";
            this.DatPicker1.Size = new System.Drawing.Size(200, 31);
            this.DatPicker1.TabIndex = 0;
            this.DatPicker1.ValueChanged += new System.EventHandler(this.DatPicker1_ValueChanged);
            // 
            // DatPicker2
            // 
            this.DatPicker2.Location = new System.Drawing.Point(191, 135);
            this.DatPicker2.Name = "DatPicker2";
            this.DatPicker2.Size = new System.Drawing.Size(200, 31);
            this.DatPicker2.TabIndex = 1;
            this.DatPicker2.ValueChanged += new System.EventHandler(this.DatPicker1_ValueChanged);
            // 
            // DatPicker3
            // 
            this.DatPicker3.Location = new System.Drawing.Point(191, 172);
            this.DatPicker3.Name = "DatPicker3";
            this.DatPicker3.Size = new System.Drawing.Size(200, 31);
            this.DatPicker3.TabIndex = 2;
            this.DatPicker3.ValueChanged += new System.EventHandler(this.DatPicker1_ValueChanged);
            // 
            // DatPicker4
            // 
            this.DatPicker4.Location = new System.Drawing.Point(191, 209);
            this.DatPicker4.Name = "DatPicker4";
            this.DatPicker4.Size = new System.Drawing.Size(200, 31);
            this.DatPicker4.TabIndex = 3;
            this.DatPicker4.ValueChanged += new System.EventHandler(this.DatPicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Standard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eigenes Format";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "UpDown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Uhrzeit";
            // 
            // LblDatum
            // 
            this.LblDatum.AutoSize = true;
            this.LblDatum.Location = new System.Drawing.Point(186, 272);
            this.LblDatum.Name = "LblDatum";
            this.LblDatum.Size = new System.Drawing.Size(70, 25);
            this.LblDatum.TabIndex = 8;
            this.LblDatum.Text = "label5";
            // 
            // LblPlusTag
            // 
            this.LblPlusTag.AutoSize = true;
            this.LblPlusTag.Location = new System.Drawing.Point(186, 311);
            this.LblPlusTag.Name = "LblPlusTag";
            this.LblPlusTag.Size = new System.Drawing.Size(70, 25);
            this.LblPlusTag.TabIndex = 9;
            this.LblPlusTag.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 417);
            this.Controls.Add(this.LblPlusTag);
            this.Controls.Add(this.LblDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatPicker4);
            this.Controls.Add(this.DatPicker3);
            this.Controls.Add(this.DatPicker2);
            this.Controls.Add(this.DatPicker1);
            this.Name = "Form1";
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatPicker1;
        private System.Windows.Forms.DateTimePicker DatPicker2;
        private System.Windows.Forms.DateTimePicker DatPicker3;
        private System.Windows.Forms.DateTimePicker DatPicker4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDatum;
        private System.Windows.Forms.Label LblPlusTag;
    }
}

