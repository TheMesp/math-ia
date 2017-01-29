namespace Math_Random_IA
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0.1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.chrData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEnter.Location = new System.Drawing.Point(12, 12);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Generate";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.Control;
            this.lblOutput.Location = new System.Drawing.Point(12, 38);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(156, 558);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = ":^)";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chrData
            // 
            chartArea1.Name = "ChartArea1";
            this.chrData.ChartAreas.Add(chartArea1);
            this.chrData.Location = new System.Drawing.Point(176, 38);
            this.chrData.Name = "chrData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsXValueIndexed = true;
            series1.Name = "Series";
            dataPoint1.IsValueShownAsLabel = false;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chrData.Series.Add(series1);
            this.chrData.Size = new System.Drawing.Size(1262, 555);
            this.chrData.TabIndex = 2;
            this.chrData.Text = "Data Chart";
            title1.Name = "Title1";
            title1.Text = "Result obtained (truncated)";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Name = "Title2";
            title2.Text = "Times obtained";
            this.chrData.Titles.Add(title1);
            this.chrData.Titles.Add(title2);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReset.Location = new System.Drawing.Point(93, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Data";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(176, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 605);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.chrData);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnEnter);
            this.Name = "frmMain";
            this.Text = "Math IA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrData;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtInput;
    }
}

