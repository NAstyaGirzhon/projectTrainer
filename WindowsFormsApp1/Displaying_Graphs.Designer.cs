namespace WindowsFormsApp1
{
    partial class Displaying_Graphs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pulseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.electroСhart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button = new System.Windows.Forms.Button();
            this.wetСhart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pressureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electroСhart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetСhart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pulseChart
            // 
            this.pulseChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.pulseChart.ChartAreas.Add(chartArea1);
            this.pulseChart.Location = new System.Drawing.Point(13, 12);
            this.pulseChart.Name = "pulseChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "PulseS";
            this.pulseChart.Series.Add(series1);
            this.pulseChart.Size = new System.Drawing.Size(617, 237);
            this.pulseChart.TabIndex = 1;
            this.pulseChart.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Измерения частоты пульса сердечного ритма";
            this.pulseChart.Titles.Add(title1);
            // 
            // temperatureChart
            // 
            this.temperatureChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea2);
            this.temperatureChart.Location = new System.Drawing.Point(13, 307);
            this.temperatureChart.Name = "temperatureChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "TemperatureS";
            this.temperatureChart.Series.Add(series2);
            this.temperatureChart.Size = new System.Drawing.Size(418, 254);
            this.temperatureChart.TabIndex = 2;
            this.temperatureChart.Text = "chart3";
            title2.Name = "Title1";
            title2.Text = "Измерения температуры кожи";
            this.temperatureChart.Titles.Add(title2);
            // 
            // electroСhart
            // 
            this.electroСhart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.electroСhart.ChartAreas.Add(chartArea3);
            this.electroСhart.Location = new System.Drawing.Point(847, 307);
            this.electroСhart.Name = "electroСhart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "ElectoS";
            this.electroСhart.Series.Add(series3);
            this.electroСhart.Size = new System.Drawing.Size(420, 254);
            this.electroСhart.TabIndex = 3;
            this.electroСhart.Text = " ";
            title3.Name = "Title1";
            title3.Text = "Измерения электрической проводимости кожи";
            this.electroСhart.Titles.Add(title3);
            // 
            // Button
            // 
            this.Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button.Location = new System.Drawing.Point(593, 255);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(85, 33);
            this.Button.TabIndex = 6;
            this.Button.Text = "Вывод";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click_1);
            // 
            // wetСhart
            // 
            this.wetСhart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea4.Name = "ChartArea1";
            this.wetСhart.ChartAreas.Add(chartArea4);
            this.wetСhart.Location = new System.Drawing.Point(437, 307);
            this.wetСhart.Name = "wetСhart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "WetS";
            this.wetСhart.Series.Add(series4);
            this.wetСhart.Size = new System.Drawing.Size(404, 254);
            this.wetСhart.TabIndex = 7;
            this.wetСhart.Text = "chart3";
            title4.Name = "Title1";
            title4.Text = "Измерения влажности кожи";
            this.wetСhart.Titles.Add(title4);
            // 
            // pressureChart
            // 
            this.pressureChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.pressureChart.ChartAreas.Add(chartArea5);
            this.pressureChart.Location = new System.Drawing.Point(636, 12);
            this.pressureChart.Name = "pressureChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Name = "PressureS";
            this.pressureChart.Series.Add(series5);
            this.pressureChart.Size = new System.Drawing.Size(632, 237);
            this.pressureChart.TabIndex = 8;
            this.pressureChart.Text = "chart2";
            title5.Name = "Title1";
            title5.Text = "Измерения кровяного давления";
            this.pressureChart.Titles.Add(title5);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // Displaying_Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1279, 573);
            this.Controls.Add(this.pressureChart);
            this.Controls.Add(this.wetСhart);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.electroСhart);
            this.Controls.Add(this.temperatureChart);
            this.Controls.Add(this.pulseChart);
            this.Name = "Displaying_Graphs";
            this.Text = "Displaying_Graphs";
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electroСhart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetСhart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart pulseChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart electroСhart;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart wetСhart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressureChart;
        private System.Windows.Forms.Timer timer1;
    }
}