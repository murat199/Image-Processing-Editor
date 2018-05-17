namespace Yazlab1_GoruntuIslemeEditoru
{
    partial class FormHistogram
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartHistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartHistogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartHistogram.Legends.Add(legend1);
            this.ChartHistogram.Location = new System.Drawing.Point(23, 81);
            this.ChartHistogram.Name = "ChartHistogram";
            series1.BorderColor = System.Drawing.Color.Green;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.Name = "SeriesGreen";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BorderColor = System.Drawing.Color.Blue;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "SeriesBlue";
            series3.BorderColor = System.Drawing.Color.Gray;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Gray;
            series3.Legend = "Legend1";
            series3.Name = "SeriesGray";
            series4.BorderColor = System.Drawing.Color.Red;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "SeriesRed";
            this.ChartHistogram.Series.Add(series1);
            this.ChartHistogram.Series.Add(series2);
            this.ChartHistogram.Series.Add(series3);
            this.ChartHistogram.Series.Add(series4);
            this.ChartHistogram.Size = new System.Drawing.Size(1197, 503);
            this.ChartHistogram.TabIndex = 0;
            this.ChartHistogram.Text = "chart1";
            this.ChartHistogram.Click += new System.EventHandler(this.ChartHistogram_Click);
            // 
            // FormHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 623);
            this.Controls.Add(this.ChartHistogram);
            this.Name = "FormHistogram";
            this.Text = "FormHistogram";
            this.Load += new System.EventHandler(this.FormHistogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartHistogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartHistogram;
    }
}