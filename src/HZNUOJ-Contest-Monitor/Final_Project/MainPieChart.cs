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
    public partial class MainPieChart : Form
    {
        public MainPieChart()
        {
            InitializeComponent();

            pieChart1.InnerRadius = 8;
            pieChart1.LegendLocation = LegendLocation.Right;

            pieChart2.InnerRadius = 8;
            pieChart2.LegendLocation = LegendLocation.Right;

            //提交分类统计
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "RTE",
                    Values = new ChartValues<double> {DBTool.getTotResult(10)},
                    PushOut = 15,
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "WA",
                    Values = new ChartValues<double> {DBTool.getTotResult(6)},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "AC",
                    Values = new ChartValues<double> {DBTool.getTotResult(4)},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "TLE",
                    Values = new ChartValues<double> {DBTool.getTotResult(7)},
                    DataLabels = true
                }
            };

            //提交语言分类
            pieChart2.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "C",
                    Values = new ChartValues<double> {DBTool.getTotResultBylanguage(0) + DBTool.getTotResultBylanguage(13)},
                    PushOut = 15,
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "C++",
                    Values = new ChartValues<double> {DBTool.getTotResultBylanguage(1) + DBTool.getTotResultBylanguage(14)},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "JAVA",
                    Values = new ChartValues<double> {DBTool.getTotResultBylanguage(3) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Python",
                    Values = new ChartValues<double> {DBTool.getTotResultBylanguage(6) + DBTool.getTotResultBylanguage(18)},
                    DataLabels = true
                }
            };
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void pieChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
