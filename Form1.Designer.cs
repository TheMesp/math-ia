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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 2D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.chrData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.chkCu = new System.Windows.Forms.CheckBox();
            this.chkPdf = new System.Windows.Forms.CheckBox();
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
            this.lblOutput.Size = new System.Drawing.Size(156, 600);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = ":^)";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chrData
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorGrid.LineWidth = 2;
            chartArea1.AxisX.MajorTickMark.Interval = 0.1D;
            chartArea1.AxisX.Maximum = 4D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 0.1D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX2.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.chrData.ChartAreas.Add(chartArea1);
            this.chrData.Location = new System.Drawing.Point(372, 12);
            this.chrData.Name = "chrData";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Data";
            series1.Points.Add(dataPoint1);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Name = "Cumulative";
            series2.Points.Add(dataPoint2);
            this.chrData.Series.Add(series1);
            this.chrData.Series.Add(series2);
            this.chrData.Size = new System.Drawing.Size(921, 584);
            this.chrData.TabIndex = 2;
            this.chrData.Text = "Data Chart";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Name = "xAxis";
            title1.Text = "f(x)";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Name = "yAxis";
            title2.Text = "Frequency";
            title3.Name = "title";
            title3.Text = "Probability Density Function for f(x)";
            this.chrData.Titles.Add(title1);
            this.chrData.Titles.Add(title2);
            this.chrData.Titles.Add(title3);
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
            // chkCu
            // 
            this.chkCu.AutoSize = true;
            this.chkCu.Location = new System.Drawing.Point(282, 16);
            this.chkCu.Name = "chkCu";
            this.chkCu.Size = new System.Drawing.Size(84, 17);
            this.chkCu.TabIndex = 5;
            this.chkCu.Text = "Cumulative?";
            this.chkCu.UseVisualStyleBackColor = true;
            this.chkCu.CheckedChanged += new System.EventHandler(this.chkCu_CheckedChanged);
            // 
            // chkPdf
            // 
            this.chkPdf.AutoSize = true;
            this.chkPdf.Location = new System.Drawing.Point(282, 37);
            this.chkPdf.Name = "chkPdf";
            this.chkPdf.Size = new System.Drawing.Size(53, 17);
            this.chkPdf.TabIndex = 6;
            this.chkPdf.Text = "PDF?";
            this.chkPdf.UseVisualStyleBackColor = true;
            this.chkPdf.CheckedChanged += new System.EventHandler(this.chkPdf_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 664);
            this.Controls.Add(this.chkPdf);
            this.Controls.Add(this.chkCu);
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
        private System.Windows.Forms.CheckBox chkCu;
        private System.Windows.Forms.CheckBox chkPdf;
    }
}

