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
    public partial class SingleSubmitResultChart : Form
    {
        public SingleSubmitResultChart(int num)
        {
            InitializeComponent();

            pieChart1.InnerRadius = 15;
            pieChart1.LegendLocation = LegendLocation.Right;

            //提交分类统计
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "RTE",
                    Values = new ChartValues<double> {DBTool.getTotResultByResultAndNum(10, num)},
                    PushOut = 15,
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "WA",
                    Values = new ChartValues<double> {DBTool.getTotResultByResultAndNum(6, num)},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "AC",
                    Values = new ChartValues<double> {DBTool.getTotResultByResultAndNum(4, num)},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "TLE",
                    Values = new ChartValues<double> {DBTool.getTotResultByResultAndNum(7, num)},
                    DataLabels = true
                }
            };
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
