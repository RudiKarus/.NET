namespace OptionsGruppen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptBerlin = new System.Windows.Forms.RadioButton();
            this.OptParis = new System.Windows.Forms.RadioButton();
            this.OptRom = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OptAppartment = new System.Windows.Forms.RadioButton();
            this.OptPension = new System.Windows.Forms.RadioButton();
            this.OptHotel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OptBerlin);
            this.groupBox1.Controls.Add(this.OptParis);
            this.groupBox1.Controls.Add(this.OptRom);
            this.groupBox1.Location = new System.Drawing.Point(46, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Urlaubsort";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // OptBerlin
            // 
            this.OptBerlin.AutoSize = true;
            this.OptBerlin.Location = new System.Drawing.Point(20, 63);
            this.OptBerlin.Name = "OptBerlin";
            this.OptBerlin.Size = new System.Drawing.Size(98, 29);
            this.OptBerlin.TabIndex = 3;
            this.OptBerlin.TabStop = true;
            this.OptBerlin.Text = "Berlin";
            this.OptBerlin.UseVisualStyleBackColor = true;
            this.OptBerlin.CheckedChanged += new System.EventHandler(this.OptUrlaubort);
            // 
            // OptParis
            // 
            this.OptParis.AutoSize = true;
            this.OptParis.Location = new System.Drawing.Point(20, 124);
            this.OptParis.Name = "OptParis";
            this.OptParis.Size = new System.Drawing.Size(92, 29);
            this.OptParis.TabIndex = 4;
            this.OptParis.TabStop = true;
            this.OptParis.Text = "Paris";
            this.OptParis.UseVisualStyleBackColor = true;
            this.OptParis.CheckedChanged += new System.EventHandler(this.OptUrlaubort);
            // 
            // OptRom
            // 
            this.OptRom.AutoSize = true;
            this.OptRom.Location = new System.Drawing.Point(20, 186);
            this.OptRom.Name = "OptRom";
            this.OptRom.Size = new System.Drawing.Size(87, 29);
            this.OptRom.TabIndex = 5;
            this.OptRom.TabStop = true;
            this.OptRom.Text = "Rom";
            this.OptRom.UseVisualStyleBackColor = true;
            this.OptRom.CheckedChanged += new System.EventHandler(this.OptUrlaubort);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OptAppartment);
            this.groupBox2.Controls.Add(this.OptPension);
            this.groupBox2.Controls.Add(this.OptHotel);
            this.groupBox2.Location = new System.Drawing.Point(310, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unterkunft";
            // 
            // OptAppartment
            // 
            this.OptAppartment.AutoSize = true;
            this.OptAppartment.Location = new System.Drawing.Point(20, 63);
            this.OptAppartment.Name = "OptAppartment";
            this.OptAppartment.Size = new System.Drawing.Size(153, 29);
            this.OptAppartment.TabIndex = 6;
            this.OptAppartment.TabStop = true;
            this.OptAppartment.Text = "Appartment";
            this.OptAppartment.UseVisualStyleBackColor = true;
            this.OptAppartment.CheckedChanged += new System.EventHandler(this.OptUnterkunft);
            // 
            // OptPension
            // 
            this.OptPension.AutoSize = true;
            this.OptPension.Location = new System.Drawing.Point(20, 124);
            this.OptPension.Name = "OptPension";
            this.OptPension.Size = new System.Drawing.Size(121, 29);
            this.OptPension.TabIndex = 7;
            this.OptPension.TabStop = true;
            this.OptPension.Text = "Pension";
            this.OptPension.UseVisualStyleBackColor = true;
            this.OptPension.CheckedChanged += new System.EventHandler(this.OptUnterkunft);
            // 
            // OptHotel
            // 
            this.OptHotel.AutoSize = true;
            this.OptHotel.Location = new System.Drawing.Point(20, 186);
            this.OptHotel.Name = "OptHotel";
            this.OptHotel.Size = new System.Drawing.Size(93, 29);
            this.OptHotel.TabIndex = 8;
            this.OptHotel.TabStop = true;
            this.OptHotel.Text = "Hotel";
            this.OptHotel.UseVisualStyleBackColor = true;
            this.OptHotel.CheckedChanged += new System.EventHandler(this.OptUnterkunft);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "OptionsGruppen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OptBerlin;
        private System.Windows.Forms.RadioButton OptParis;
        private System.Windows.Forms.RadioButton OptRom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton OptAppartment;
        private System.Windows.Forms.RadioButton OptPension;
        private System.Windows.Forms.RadioButton OptHotel;
        private System.Windows.Forms.Label label1;
    }
}

