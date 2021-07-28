namespace EingabeAusgabe
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
            this.CmdInput = new System.Windows.Forms.Button();
            this.CmdLotto = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdMsgBoxOnly = new System.Windows.Forms.Button();
            this.CmdMsgBoxInformation = new System.Windows.Forms.Button();
            this.CmdMsgBoxYesNo = new System.Windows.Forms.Button();
            this.CmdMsgBoxYesNoCancel = new System.Windows.Forms.Button();
            this.CmdMsgBoxRetryCancel = new System.Windows.Forms.Button();
            this.CmdMsgAbortRetryIgnore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdInput
            // 
            this.CmdInput.Location = new System.Drawing.Point(51, 80);
            this.CmdInput.Name = "CmdInput";
            this.CmdInput.Size = new System.Drawing.Size(75, 23);
            this.CmdInput.TabIndex = 0;
            this.CmdInput.Text = "Input";
            this.CmdInput.UseVisualStyleBackColor = true;
            this.CmdInput.Click += new System.EventHandler(this.CmdInput_Click);
            // 
            // CmdLotto
            // 
            this.CmdLotto.Location = new System.Drawing.Point(132, 80);
            this.CmdLotto.Name = "CmdLotto";
            this.CmdLotto.Size = new System.Drawing.Size(75, 23);
            this.CmdLotto.TabIndex = 1;
            this.CmdLotto.Text = "Lotto";
            this.CmdLotto.UseVisualStyleBackColor = true;
            this.CmdLotto.Click += new System.EventHandler(this.CmdLotto_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 20);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(70, 25);
            this.LblAnzeige.TabIndex = 2;
            this.LblAnzeige.Text = "label1";
            // 
            // CmdMsgBoxOnly
            // 
            this.CmdMsgBoxOnly.Location = new System.Drawing.Point(51, 109);
            this.CmdMsgBoxOnly.Name = "CmdMsgBoxOnly";
            this.CmdMsgBoxOnly.Size = new System.Drawing.Size(75, 23);
            this.CmdMsgBoxOnly.TabIndex = 3;
            this.CmdMsgBoxOnly.Text = "Ok";
            this.CmdMsgBoxOnly.UseVisualStyleBackColor = true;
            this.CmdMsgBoxOnly.Click += new System.EventHandler(this.CmdMsgBoxOnly_Click);
            // 
            // CmdMsgBoxInformation
            // 
            this.CmdMsgBoxInformation.Location = new System.Drawing.Point(132, 109);
            this.CmdMsgBoxInformation.Name = "CmdMsgBoxInformation";
            this.CmdMsgBoxInformation.Size = new System.Drawing.Size(75, 23);
            this.CmdMsgBoxInformation.TabIndex = 4;
            this.CmdMsgBoxInformation.Text = "Information";
            this.CmdMsgBoxInformation.UseVisualStyleBackColor = true;
            this.CmdMsgBoxInformation.Click += new System.EventHandler(this.CmdMsgBoxInformation_Click);
            // 
            // CmdMsgBoxYesNo
            // 
            this.CmdMsgBoxYesNo.Location = new System.Drawing.Point(51, 138);
            this.CmdMsgBoxYesNo.Name = "CmdMsgBoxYesNo";
            this.CmdMsgBoxYesNo.Size = new System.Drawing.Size(75, 23);
            this.CmdMsgBoxYesNo.TabIndex = 5;
            this.CmdMsgBoxYesNo.Text = "YesNo";
            this.CmdMsgBoxYesNo.UseVisualStyleBackColor = true;
            this.CmdMsgBoxYesNo.Click += new System.EventHandler(this.CmdMsgBoxYesNo_Click);
            // 
            // CmdMsgBoxYesNoCancel
            // 
            this.CmdMsgBoxYesNoCancel.Location = new System.Drawing.Point(132, 138);
            this.CmdMsgBoxYesNoCancel.Name = "CmdMsgBoxYesNoCancel";
            this.CmdMsgBoxYesNoCancel.Size = new System.Drawing.Size(75, 23);
            this.CmdMsgBoxYesNoCancel.TabIndex = 6;
            this.CmdMsgBoxYesNoCancel.Text = "YesNoCancel";
            this.CmdMsgBoxYesNoCancel.UseVisualStyleBackColor = true;
            this.CmdMsgBoxYesNoCancel.Click += new System.EventHandler(this.CmdMsgBoxYesNoCancel_Click);
            // 
            // CmdMsgBoxRetryCancel
            // 
            this.CmdMsgBoxRetryCancel.Location = new System.Drawing.Point(51, 167);
            this.CmdMsgBoxRetryCancel.Name = "CmdMsgBoxRetryCancel";
            this.CmdMsgBoxRetryCancel.Size = new System.Drawing.Size(75, 23);
            this.CmdMsgBoxRetryCancel.TabIndex = 7;
            this.CmdMsgBoxRetryCancel.Text = "Retry Cancel";
            this.CmdMsgBoxRetryCancel.UseVisualStyleBackColor = true;
            this.CmdMsgBoxRetryCancel.Click += new System.EventHandler(this.CmdMsgBoxRetryCancel_Click);
            // 
            // CmdMsgAbortRetryIgnore
            // 
            this.CmdMsgAbortRetryIgnore.Location = new System.Drawing.Point(132, 167);
            this.CmdMsgAbortRetryIgnore.Name = "CmdMsgAbortRetryIgnore";
            this.CmdMsgAbortRetryIgnore.Size = new System.Drawing.Size(75, 23);
            this.CmdMsgAbortRetryIgnore.TabIndex = 8;
            this.CmdMsgAbortRetryIgnore.Text = "Abort Retry Ignore";
            this.CmdMsgAbortRetryIgnore.UseVisualStyleBackColor = true;
            this.CmdMsgAbortRetryIgnore.Click += new System.EventHandler(this.CmdMsgAbortRetryIgnore_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(295, 228);
            this.Controls.Add(this.CmdMsgAbortRetryIgnore);
            this.Controls.Add(this.CmdMsgBoxRetryCancel);
            this.Controls.Add(this.CmdMsgBoxYesNoCancel);
            this.Controls.Add(this.CmdMsgBoxYesNo);
            this.Controls.Add(this.CmdMsgBoxInformation);
            this.Controls.Add(this.CmdMsgBoxOnly);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdLotto);
            this.Controls.Add(this.CmdInput);
            this.Name = "Form1";
            this.Text = "Eingabe und Ausgabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdInput;
        private System.Windows.Forms.Button CmdLotto;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdMsgBoxOnly;
        private System.Windows.Forms.Button CmdMsgBoxInformation;
        private System.Windows.Forms.Button CmdMsgBoxYesNo;
        private System.Windows.Forms.Button CmdMsgBoxYesNoCancel;
        private System.Windows.Forms.Button CmdMsgBoxRetryCancel;
        private System.Windows.Forms.Button CmdMsgAbortRetryIgnore;
    }
}

