using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class SingleSubmitResultTenChart : Form
    {
        public SingleSubmitResultTenChart(int num)
        {
            InitializeComponent();
            getcartesianChart(num);
        }

        public void getcartesianChart(int num)
        {
            DateTime NOW = DateTime.Now;
            if (DateTime.Compare(NOW, OperateForm.end_time) > 0) NOW = OperateForm.end_time;
            if (DateTime.Compare(NOW, OperateForm.start_time) < 0) NOW = OperateForm.start_time;

            TimeSpan timeSpan = NOW - OperateForm.start_time;
            int len = (int)double.Parse(timeSpan.TotalMinutes.ToString());
            len = Math.Min(300, len);
            len = Math.Max(0, len);
            len /= 10;

            cartesianChart1.Series.Clear();
            for (int i = 0; i < 4; ++i)
            {
                StackedColumnSeries stackedColumnSeries = new StackedColumnSeries();
                stackedColumnSeries.StackMode = StackMode.Values;
                stackedColumnSeries.DataLabels = false;
                stackedColumnSeries.Title = OperateForm.resultName[i];
                stackedColumnSeries.Values = new ChartValues<double>();
                DateTime st = OperateForm.start_time;
                DateTime nx = new DateTime();
                for (int j = 0; j < len; ++j)
                {
                    nx = st.AddMinutes(10);
                    try
                    {
                        if (OperateForm.result[i] != 4)
                        {
                            stackedColumnSeries.Values.Add(-double.Parse(DBTool.getTotSubmitByStEdAndResultAndNum(st.ToString(), nx.ToString(), OperateForm.result[i], num).ToString()));
                        }
                        else
                        {
                            stackedColumnSeries.Values.Add(double.Parse(DBTool.getTotSubmitByStEdAndResultAndNum(st.ToString(), nx.ToString(), OperateForm.result[i], num).ToString()));
                        }
                    }
                    catch (Exception ex)
                    {
                        print("网络连接中断！");
                        Application.Exit();
                    }
                    st = nx;
                }
                cartesianChart1.Series.Add(stackedColumnSeries);
            }

            string[] labels2 = new string[len];
            for (int i = 0; i < len; ++i)
            {
                labels2[i] = ((i + 1) * 10).ToString();
            }
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = labels2,
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    Step = 1,
                    IsEnabled = false //disable it to make it invisible. 
                },
                LabelsRotation = 0
            });

            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisY.Add(new Axis
            {
                LabelFormatter = value => value + ""
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
