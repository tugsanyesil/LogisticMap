using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogisticMap
{
    public partial class LogisticMapForm : Form
    {
        float x0 = 0.5f;
        public float X0
        {
            get => x0;
            set
            {
                x0 = value;
                RTrackBar.Maximum = (x0 == 0.0) ? (int)(RTrackBarRatio * 100) : (int)(RTrackBarRatio * (1.0 / (x0 * (1.0 - x0))));
                ChartLogisticMap();
            }
        }

        public float R => RTrackBar.Value / RTrackBarRatio;
        public float RTrackBarRatio = 100.0f;
        public int XCount = 30;

        public LogisticMapForm()
        {
            InitializeComponent();

            X0TrackBar.Minimum = 0;
            X0TrackBar.Maximum = 1000;

            RTrackBar.Minimum = 0;
            X0TrackBar.Value = (int)(X0TrackBar.Maximum * x0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            X0 = x0;
        }

        private List<float> LogisticMap(float R, float X0)
        {
            List<float> Xs = new List<float>() { X0 };
            for (int i = 0; i < XCount; i++)
            {
                X0 = R * X0 * (1 - X0);
                if (X0 > 1 || X0 == 0) { break; }
                Xs.Add(X0);
            }
            return Xs;
        }

        private void ChartLogisticMap()
        {
            var Xs = LogisticMap(R, X0);
            LogisticMapChart.Series[0].Points.Clear();
            LogRichTextBox.Text = $"X0 : {X0} R: {R} R_max : {RTrackBar.Maximum / RTrackBarRatio}\n";
            for (int i = 0; i < Xs.Count; i++)
            {
                LogisticMapChart.Series[0].Points.AddXY(i, Xs[i]);
                LogRichTextBox.Text += $" i : {i}  Xs[{i}] : {Xs[i]}\n";
            }
        }

        private void X0TrackBar_Scroll(object sender, EventArgs e)
        {
            X0 = (float)X0TrackBar.Value / X0TrackBar.Maximum;
        }

        private void RTrackBar_Scroll(object sender, EventArgs e)
        {
            ChartLogisticMap();
        }
    }
}
