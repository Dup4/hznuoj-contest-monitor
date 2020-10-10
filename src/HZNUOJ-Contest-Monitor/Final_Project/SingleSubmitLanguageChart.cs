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
    public partial class SingleSubmitLanguageChart : Form
    {
        
        public SingleSubmitLanguageChart(int num)
        {
            InitializeComponent();

            pieChart1.InnerRadius = 15;
            pieChart1.LegendLocation = LegendLocation.Right;

            //提交语言分类
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "C",
                    Values = new ChartValues<double> {DBTool.getTotResultBylanguageAndNum(0, num) + DBTool.getTotResultBylanguageAndNum(13, num)},
                    PushOut = 15,
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "C++",
                    Values = new ChartValues<double> {DBTool.getTotResultBylanguageAndNum(1, num) + DBTool.getTotResultBylanguageAndNum(14, num)},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "JAVA",
                    Values = new ChartValues<double> {DBTool.getTotResultBylanguageAndNum(3, num) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Python",
                    Values = new ChartValues<double> {DBTool.getTotResultBylanguageAndNum(6, num) + DBTool.getTotResultBylanguageAndNum(18, num)},
                    DataLabels = true
                }
            };


        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
