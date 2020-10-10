using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class SubmitAndACChart : Form
    {
        public SubmitAndACChart()
        {
            InitializeComponent();
            getcartesianChart();
        }

        public void getcartesianChart()
        {
            ChartValues<double> AC_Values = new ChartValues<double>();
            ChartValues<double> Submit_Values = new ChartValues<double>();
            DateTime NOW = DateTime.Now;
            DateTime last_time;
            if (DateTime.Compare(NOW, OperateForm.end_time) > 0)
            {
                NOW = OperateForm.end_time;
            }
            if (DateTime.Compare(NOW, OperateForm.start_time) < 0)
            {
                NOW = OperateForm.start_time;
            }
            last_time = NOW; 

            TimeSpan timeSpan = NOW - OperateForm.start_time;
            DateTime st = OperateForm.start_time;
            DateTime nx = new DateTime();
            int len = (int)double.Parse(timeSpan.TotalMinutes.ToString());
            len = Math.Min(300, len);
            len = Math.Max(0, len);
            AC_Values.Add(0);
            Submit_Values.Add(0);
            for (int i = 0; i < len; i += 1)
            {
                nx = st.AddMinutes(1);
                try
                {
                    AC_Values.Add(double.Parse(DBTool.getTotSubmitByStEdAndResult(st.ToString(), nx.ToString(), 4).ToString()));
                    Submit_Values.Add(double.Parse(DBTool.getTotSubmitByStEd(st.ToString(), nx.ToString()).ToString()));
                }
                catch (Exception ex)
                {
                    print("网络连接中断！");
                    Application.Exit();
                }
                st = nx;
            }

            cartesianChart1.Series.Clear();
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = AC_Values,
                StrokeThickness = 2,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 2 }),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 69)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 0,
                PointGeometrySize = 1,
                Title = "AC",
            });
            
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = Submit_Values,
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(28, 142, 196)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 1,
                PointGeometrySize = 1,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49)),
                Title = "Submit"
            });

            cartesianChart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49));

            cartesianChart1.AxisX.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    Step = 20,
                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 2 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1.5,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 4 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
        }

        public void print(string msg)
        {
            MessageBox.Show(msg);
        }

        private void elementHost3_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
