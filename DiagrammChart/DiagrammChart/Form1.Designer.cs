namespace DiagrammChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CmdSpeichern = new System.Windows.Forms.Button();
            this.CmdDrucken = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dChart
            // 
            chartArea3.Name = "ChartArea1";
            this.dChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.dChart.Legends.Add(legend3);
            this.dChart.Location = new System.Drawing.Point(49, 49);
            this.dChart.Name = "dChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.dChart.Series.Add(series3);
            this.dChart.Size = new System.Drawing.Size(450, 300);
            this.dChart.TabIndex = 0;
            this.dChart.Text = "chart1";
            // 
            // CmdSpeichern
            // 
            this.CmdSpeichern.Location = new System.Drawing.Point(541, 78);
            this.CmdSpeichern.Name = "CmdSpeichern";
            this.CmdSpeichern.Size = new System.Drawing.Size(75, 23);
            this.CmdSpeichern.TabIndex = 1;
            this.CmdSpeichern.Text = "Speichern";
            this.CmdSpeichern.UseVisualStyleBackColor = true;
            this.CmdSpeichern.Click += new System.EventHandler(this.CmdSpeichern_Click);
            // 
            // CmdDrucken
            // 
            this.CmdDrucken.Location = new System.Drawing.Point(541, 49);
            this.CmdDrucken.Name = "CmdDrucken";
            this.CmdDrucken.Size = new System.Drawing.Size(75, 23);
            this.CmdDrucken.TabIndex = 2;
            this.CmdDrucken.Text = "Drucken";
            this.CmdDrucken.UseVisualStyleBackColor = true;
            this.CmdDrucken.Click += new System.EventHandler(this.CmdDrucken_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(666, 406);
            this.Controls.Add(this.CmdDrucken);
            this.Controls.Add(this.CmdSpeichern);
            this.Controls.Add(this.dChart);
            this.Name = "Form1";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.dChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart dChart;
        private System.Windows.Forms.Button CmdSpeichern;
        private System.Windows.Forms.Button CmdDrucken;
    }
}

