namespace VremenskaStanica
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.jedanParametarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.jedanParametarChart)).BeginInit();
            this.SuspendLayout();
            // 
            // jedanParametarChart
            // 
            chartArea1.Name = "Linearni";
            chartArea2.AxisY.IsLogarithmic = true;
            chartArea2.Name = "Logaritamski";
            this.jedanParametarChart.ChartAreas.Add(chartArea1);
            this.jedanParametarChart.ChartAreas.Add(chartArea2);
            legend1.DockedToChartArea = "Linearni";
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            legend2.DockedToChartArea = "Logaritamski";
            legend2.IsDockedInsideChartArea = false;
            legend2.Name = "Legend2";
            this.jedanParametarChart.Legends.Add(legend1);
            this.jedanParametarChart.Legends.Add(legend2);
            this.jedanParametarChart.Location = new System.Drawing.Point(0, 0);
            this.jedanParametarChart.Name = "jedanParametarChart";
            series1.ChartArea = "Linearni";
            series1.Legend = "Legend1";
            series1.Name = "LinearSeries";
            series2.ChartArea = "Logaritamski";
            series2.Legend = "Legend2";
            series2.Name = "LogSeries";
            this.jedanParametarChart.Series.Add(series1);
            this.jedanParametarChart.Series.Add(series2);
            this.jedanParametarChart.Size = new System.Drawing.Size(507, 352);
            this.jedanParametarChart.TabIndex = 0;
            this.jedanParametarChart.Text = "chart1";
            title1.DockedToChartArea = "Linearni";
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            title1.Text = "Linearni";
            title2.DockedToChartArea = "Logaritamski";
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title2";
            title2.Text = "Logaritamski";
            this.jedanParametarChart.Titles.Add(title1);
            this.jedanParametarChart.Titles.Add(title2);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 353);
            this.Controls.Add(this.jedanParametarChart);
            this.Name = "FormChart";
            this.Text = "FormChart";
            ((System.ComponentModel.ISupportInitialize)(this.jedanParametarChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart jedanParametarChart;
    }
}