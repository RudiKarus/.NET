namespace EreignisEnter
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.ChkKunde = new System.Windows.Forms.CheckBox();
            this.LblHilfe = new System.Windows.Forms.Label();
            this.LstPaketdienst = new System.Windows.Forms.ListBox();
            this.ChkLastschrift = new System.Windows.Forms.RadioButton();
            this.ChkKreditkarte = new System.Windows.Forms.RadioButton();
            this.ChkUeberweisung = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(32, 54);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 31);
            this.TxtName.TabIndex = 0;
            this.TxtName.Enter += new System.EventHandler(this.TxtName_Enter);
            // 
            // ChkKunde
            // 
            this.ChkKunde.AutoSize = true;
            this.ChkKunde.Location = new System.Drawing.Point(32, 109);
            this.ChkKunde.Name = "ChkKunde";
            this.ChkKunde.Size = new System.Drawing.Size(189, 29);
            this.ChkKunde.TabIndex = 4;
            this.ChkKunde.Text = "bereits Kunde?";
            this.ChkKunde.UseVisualStyleBackColor = true;
            this.ChkKunde.Enter += new System.EventHandler(this.ChkKunde_Enter);
            // 
            // LblHilfe
            // 
            this.LblHilfe.AutoSize = true;
            this.LblHilfe.Location = new System.Drawing.Point(40, 399);
            this.LblHilfe.Name = "LblHilfe";
            this.LblHilfe.Size = new System.Drawing.Size(70, 25);
            this.LblHilfe.TabIndex = 5;
            this.LblHilfe.Text = "label1";
            // 
            // LstPaketdienst
            // 
            this.LstPaketdienst.FormattingEnabled = true;
            this.LstPaketdienst.ItemHeight = 25;
            this.LstPaketdienst.Location = new System.Drawing.Point(45, 296);
            this.LstPaketdienst.Name = "LstPaketdienst";
            this.LstPaketdienst.Size = new System.Drawing.Size(120, 79);
            this.LstPaketdienst.TabIndex = 6;
            this.LstPaketdienst.Enter += new System.EventHandler(this.LstPaketdienst_Enter);
            // 
            // ChkLastschrift
            // 
            this.ChkLastschrift.AutoSize = true;
            this.ChkLastschrift.Location = new System.Drawing.Point(32, 200);
            this.ChkLastschrift.Name = "ChkLastschrift";
            this.ChkLastschrift.Size = new System.Drawing.Size(142, 29);
            this.ChkLastschrift.TabIndex = 8;
            this.ChkLastschrift.TabStop = true;
            this.ChkLastschrift.Text = "Lastschrift";
            this.ChkLastschrift.UseVisualStyleBackColor = true;
            this.ChkLastschrift.CheckedChanged += new System.EventHandler(this.OptZahlungsform_CheckedChanged);
            // 
            // ChkKreditkarte
            // 
            this.ChkKreditkarte.AutoSize = true;
            this.ChkKreditkarte.Location = new System.Drawing.Point(32, 165);
            this.ChkKreditkarte.Name = "ChkKreditkarte";
            this.ChkKreditkarte.Size = new System.Drawing.Size(147, 29);
            this.ChkKreditkarte.TabIndex = 7;
            this.ChkKreditkarte.TabStop = true;
            this.ChkKreditkarte.Text = "Kreditkarte";
            this.ChkKreditkarte.UseVisualStyleBackColor = true;
            this.ChkKreditkarte.CheckedChanged += new System.EventHandler(this.OptZahlungsform_CheckedChanged);
            // 
            // ChkUeberweisung
            // 
            this.ChkUeberweisung.AutoSize = true;
            this.ChkUeberweisung.Location = new System.Drawing.Point(32, 235);
            this.ChkUeberweisung.Name = "ChkUeberweisung";
            this.ChkUeberweisung.Size = new System.Drawing.Size(168, 29);
            this.ChkUeberweisung.TabIndex = 9;
            this.ChkUeberweisung.TabStop = true;
            this.ChkUeberweisung.Text = "Überweisung";
            this.ChkUeberweisung.UseVisualStyleBackColor = true;
            this.ChkUeberweisung.CheckedChanged += new System.EventHandler(this.OptZahlungsform_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChkUeberweisung);
            this.Controls.Add(this.ChkLastschrift);
            this.Controls.Add(this.ChkKreditkarte);
            this.Controls.Add(this.LstPaketdienst);
            this.Controls.Add(this.LblHilfe);
            this.Controls.Add(this.ChkKunde);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Ereignis Enter";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.CheckBox ChkKunde;
        private System.Windows.Forms.Label LblHilfe;
        private System.Windows.Forms.ListBox LstPaketdienst;
        private System.Windows.Forms.RadioButton ChkLastschrift;
        private System.Windows.Forms.RadioButton ChkKreditkarte;
        private System.Windows.Forms.RadioButton ChkUeberweisung;
    }
}

