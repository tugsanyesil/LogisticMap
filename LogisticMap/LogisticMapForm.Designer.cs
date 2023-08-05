namespace LogisticMap
{
    partial class LogisticMapForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LogisticMapChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.X0TrackBar = new System.Windows.Forms.TrackBar();
            this.RTrackBar = new System.Windows.Forms.TrackBar();
            this.X0Label = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogisticMapChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X0TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // LogisticMapChart
            // 
            chartArea2.Name = "ChartArea1";
            this.LogisticMapChart.ChartAreas.Add(chartArea2);
            this.LogisticMapChart.Location = new System.Drawing.Point(12, 12);
            this.LogisticMapChart.Name = "LogisticMapChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Name = "Series1";
            this.LogisticMapChart.Series.Add(series2);
            this.LogisticMapChart.Size = new System.Drawing.Size(420, 300);
            this.LogisticMapChart.TabIndex = 0;
            // 
            // LogRichTextBox
            // 
            this.LogRichTextBox.Location = new System.Drawing.Point(15, 420);
            this.LogRichTextBox.Name = "LogRichTextBox";
            this.LogRichTextBox.Size = new System.Drawing.Size(417, 162);
            this.LogRichTextBox.TabIndex = 1;
            this.LogRichTextBox.Text = "";
            // 
            // X0TrackBar
            // 
            this.X0TrackBar.Location = new System.Drawing.Point(37, 318);
            this.X0TrackBar.Name = "X0TrackBar";
            this.X0TrackBar.Size = new System.Drawing.Size(395, 45);
            this.X0TrackBar.TabIndex = 3;
            this.X0TrackBar.Scroll += new System.EventHandler(this.X0TrackBar_Scroll);
            // 
            // RTrackBar
            // 
            this.RTrackBar.Location = new System.Drawing.Point(37, 369);
            this.RTrackBar.Name = "RTrackBar";
            this.RTrackBar.Size = new System.Drawing.Size(395, 45);
            this.RTrackBar.TabIndex = 4;
            this.RTrackBar.Scroll += new System.EventHandler(this.RTrackBar_Scroll);
            // 
            // X0Label
            // 
            this.X0Label.AutoSize = true;
            this.X0Label.Location = new System.Drawing.Point(12, 321);
            this.X0Label.Name = "X0Label";
            this.X0Label.Size = new System.Drawing.Size(26, 13);
            this.X0Label.TabIndex = 5;
            this.X0Label.Text = "X0 :";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(12, 369);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(21, 13);
            this.RLabel.TabIndex = 6;
            this.RLabel.Text = "R :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 589);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.X0Label);
            this.Controls.Add(this.RTrackBar);
            this.Controls.Add(this.X0TrackBar);
            this.Controls.Add(this.LogRichTextBox);
            this.Controls.Add(this.LogisticMapChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogisticMapChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X0TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart LogisticMapChart;
        private System.Windows.Forms.RichTextBox LogRichTextBox;
        private System.Windows.Forms.TrackBar X0TrackBar;
        private System.Windows.Forms.TrackBar RTrackBar;
        private System.Windows.Forms.Label X0Label;
        private System.Windows.Forms.Label RLabel;
    }
}

