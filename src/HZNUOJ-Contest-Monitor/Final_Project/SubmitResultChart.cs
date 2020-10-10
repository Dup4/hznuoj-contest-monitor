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
    public partial class SubmitResultChart : Form
    {

        public SubmitResultChart()
        {
            InitializeComponent();

            getCartesianChart();

        }

        public void getCartesianChart()
        {
            //cartesianChart2 题目提交分类统计
            cartesianChart1.Series.Clear();
            for (int i = 0; i < 4; ++i)
            {
                StackedColumnSeries stackedColumnSeries = new StackedColumnSeries();
                stackedColumnSeries.StackMode = StackMode.Values;
                stackedColumnSeries.DataLabels = false;
                stackedColumnSeries.Title = OperateForm.resultName[i];
                stackedColumnSeries.Values = new ChartValues<double>();
                for (int j = 0; j < OperateForm.problemCnt; ++j)
                {
                    try
                    {
                        if (OperateForm.result[i] != 4)
                        {
                            stackedColumnSeries.Values.Add(-double.Parse((DBTool.getTotResultByResultAndNum(OperateForm.result[i], j)).ToString()));
                        }
                        else
                        {
                            stackedColumnSeries.Values.Add(double.Parse((DBTool.getTotResultByResultAndNum(OperateForm.result[i], j)).ToString()));
                        }

                    }
                    catch (Exception ex)
                    {
                        print("网络连接中断！");
                        Application.Exit();
                    }
                }
                cartesianChart1.Series.Add(stackedColumnSeries);
            }

            string[] labels2 = new string[OperateForm.problemCnt];
            for (int i = 0; i < OperateForm.problemCnt; ++i)
            {
                labels2[i] = OperateForm.charMp[i];
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

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
