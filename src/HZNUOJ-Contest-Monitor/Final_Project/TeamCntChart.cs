using LiveCharts;
using LiveCharts.Defaults;
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
    public partial class TeamCntChart : Form
    {

        public TeamCntChart()
        {
            InitializeComponent();

            //cartesianChart1 队伍过题数统计
            ColumnSeries columnSeries = new ColumnSeries();
            columnSeries.DataLabels = true;
            columnSeries.LabelPoint = point => point.Y + "";
            columnSeries.Values = new ChartValues<ObservableValue>();

            for (int i = 1; i <= OperateForm.problemCnt; ++i)
            {
                try
                {
                    columnSeries.Values.Add(new ObservableValue(double.Parse(DBTool.getProblemTeamByCnt(i).ToString())));
                }
                catch (Exception ex)
                {
                    print("网络连接中断！");
                    Application.Exit();
                }
            }

            cartesianChart1.Series.Clear();
            columnSeries.Title = "team";
            cartesianChart1.Series.Add(columnSeries);

            string[] labels1 = new string[OperateForm.problemCnt];
            for (int i = 0; i < OperateForm.problemCnt; ++i)
            {
                labels1[i] = (i + 1).ToString();
            }

            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = labels1,
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
                LabelFormatter = value => value + " teams",
                Separator = new Separator()
            });

        }

        public void print(string msg)
        {
            MessageBox.Show(msg);
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
