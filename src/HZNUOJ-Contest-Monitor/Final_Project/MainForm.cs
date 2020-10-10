using HZH_Controls.Controls;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class MainForm : Form 
    {
        public string sql;
        public DataSet ds;

        public MainForm()
        {
            InitializeComponent();

            contestId.Value = DBTool.contest_id.ToString();
            //剩余时间
            getRemindTime();

            //参与人数
            getPopulation();

            //判题机状态
            getLabelData();

            //首A时间
            getFirstSolveTime();

            //雷达图的点
            getRadarChartPositions(); 

            //雷达图数据
            getRadarChartLines();
            
            //饼状图
            pieChart1.InnerRadius = 8;
            pieChart1.LegendLocation = LegendLocation.Right;

            pieChart2.InnerRadius = 8;
            pieChart2.LegendLocation = LegendLocation.Right;
            getPieChart(); 
            
            //过题队伍数统计和各题提交分类统计
            getCartesianChart();

            //十分钟提交数和AC数统计
            getcartesianChart3();
        }

        public void getcartesianChart3()
        {
            DateTime NOW = DateTime.Now;
            if (DateTime.Compare(NOW, OperateForm.end_time) > 0) NOW = OperateForm.end_time;
            if (DateTime.Compare(NOW, OperateForm.start_time) < 0) NOW = OperateForm.start_time;

            TimeSpan timeSpan = NOW - OperateForm.start_time;
            int len = (int)double.Parse(timeSpan.TotalMinutes.ToString());
            len = Math.Min(300, len);
            len = Math.Max(0, len);
            len /= 10;

            cartesianChart3.Series.Clear();
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
                            stackedColumnSeries.Values.Add(-double.Parse(DBTool.getTotSubmitByStEdAndResult(st.ToString(), nx.ToString(), OperateForm.result[i]).ToString()));
                        }
                        else
                        {
                            stackedColumnSeries.Values.Add(double.Parse(DBTool.getTotSubmitByStEdAndResult(st.ToString(), nx.ToString(), OperateForm.result[i]).ToString()));
                        }
                    }
                    catch (Exception ex)
                    {
                        print("网络连接中断！");
                        Application.Exit();
                    }
                    st = nx;
                }
                cartesianChart3.Series.Add(stackedColumnSeries);
            }

            string[] labels2 = new string[len];
            for (int i = 0; i < len; ++i)
            {
                labels2[i] = ((i + 1) * 10).ToString();
            }
            cartesianChart3.AxisX.Clear();
            cartesianChart3.AxisX.Add(new Axis
            {
                Labels = labels2,
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    Step = 1,
                    IsEnabled = false //disable it to make it invisible.
                },
                LabelsRotation = 0
            });

            cartesianChart3.AxisY.Clear();
            cartesianChart3.AxisY.Add(new Axis
            {
                LabelFormatter = value => value + ""
            });
        }

        public void getCartesianChart()
        {
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


            //cartesianChart2 题目提交分类统计
            cartesianChart2.Series.Clear();
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
                cartesianChart2.Series.Add(stackedColumnSeries);
            }

            string[] labels2 = new string[OperateForm.problemCnt]; 
            for (int i = 0; i < OperateForm.problemCnt; ++i) 
            {
                labels2[i] = OperateForm.charMp[i];
            }
            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisX.Add(new Axis 
            {
                Labels = labels2,
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    Step = 1,
                    IsEnabled = false //disable it to make it invisible.
                },
                LabelsRotation = 0
            });

            cartesianChart2.AxisY.Clear();
            cartesianChart2.AxisY.Add(new Axis
            {
                LabelFormatter = value => value + ""
            });

        }
        
        public void getFirstSolveTime()
        {
            string Text = "";
            for (int i = 0; i < OperateForm.problemCnt; ++i)
            {
                Text += OperateForm.charMp[i] + ": ";
                try
                {
                    string sAC_time = DBTool.getFirstSolveTime(i);
                    if (sAC_time == null)
                    {
                        Text += "N/A";
                    } 
                    else
                    {
                        DateTime AC_Time = Convert.ToDateTime(sAC_time, OperateForm.dtFormat);
                        TimeSpan timeSpan = AC_Time - OperateForm.start_time;
                        Text += "" + string.Format("{0:00}", timeSpan.Hours) + ":" + string.Format("{0:00}", timeSpan.Minutes) + ":" + string.Format("{0:00}", timeSpan.Seconds);
                    }
                }
                catch
                {
                    print("网络连接中断！");
                    Application.Exit();
                }
                Text += "\n";
            }
            FirstSolveTime.Text = Text;
        }

        public void getLabelData()
        {
            try
            {
                tot_submit.Text = DBTool.getTotSubmit().ToString();
                tot_AC.Text = DBTool.getTotAC().ToString();
                tot_judging.Text = (DBTool.getTotResult(2) + DBTool.getTotResult(3)).ToString();
                tot_pending.Text = (DBTool.getTotResult(0) + DBTool.getTotResult(1)).ToString();
            }
            catch (Exception ex)
            {
                print("网络连接中断！");
                Application.Exit();
            }
        }

        public void getRadarChartLines()
        {
            //AC
            RadarLine[] radarLines_AC = new RadarLine[1];
            radarLines_AC[0] = new RadarLine();
            radarLines_AC[0].ShowValueText = false;
            radarLines_AC[0].Name = "AC";
            radarLines_AC[0].FillColor = Color.FromArgb(50, 243, 67, 54);
            radarLines_AC[0].LineColor = Color.FromArgb(243, 67, 54);
            radarLines_AC[0].Values = getRadarChartLineValues("AC");
            ucRadarChart_AC.Lines = radarLines_AC;

            //Submit
            RadarLine[] radarLines_Tot = new RadarLine[1];
            radarLines_Tot[0] = new RadarLine();
            radarLines_Tot[0].ShowValueText = false;
            radarLines_Tot[0].Name = "Submit";
            radarLines_Tot[0].FillColor = Color.FromArgb(50, 156, 39, 176);
            radarLines_Tot[0].LineColor = Color.FromArgb(156, 39, 176);
            radarLines_Tot[0].Values = getRadarChartLineValues("Tot");
            ucRadarChart_Tot.Lines = radarLines_Tot;
        }

        public double[] getRadarChartLineValues(string f) 
        {
            double[] res = new double[OperateForm.problemCnt];
            try
            {
                for (int i = 0; i < OperateForm.problemCnt; ++i) 
                {
                    if (f == "AC")
                    {
                        res[i] = double.Parse(DBTool.getDISTINCTACByNum(i).ToString());
                    }
                    else
                    {
                        res[i] = double.Parse(DBTool.getTotSubmitByNum(i).ToString());
                    }
                }
            }
            catch (Exception e)
            {
                print("网络连接中断！");
                Application.Exit();
            }
            double Max = 1;
            foreach (double it in res)
            {
                Max = Math.Max(Max, it * 1.2);
            }
            for (int i = 0; i < OperateForm.problemCnt; ++i)
            {
                res[i] = res[i] / Max * 100;
            }
            return res;
        }

        public void getRadarChartPositions()
        {
            RadarPosition[] radarPosition = new RadarPosition[OperateForm.problemCnt]; 
            for (int i = 0; i < OperateForm.problemCnt; ++i)
            {
                radarPosition[i] = new RadarPosition();
                radarPosition[i].MaxValue = 100;
                radarPosition[i].Text = OperateForm.charMp[i];
            }
            ucRadarChart_AC.RadarPositions = radarPosition;
            ucRadarChart_Tot.RadarPositions = radarPosition;
        }
       
        public void getPopulation()
        {
            try
            {
                population.Value = DBTool.getPopulation().ToString();
            }
            catch (Exception ex)
            {
                print("网络连接中断！");
                Application.Exit();
            }
        }
        
        public void getRemindTime() 
        {
            TimeSpan timeSpan;
            if (DateTime.Compare(DateTime.Now, OperateForm.start_time) <= 0) 
            {
                timeSpan = OperateForm.end_time - OperateForm.start_time;
            }
            else
            {
                timeSpan = OperateForm.end_time - DateTime.Now;
            }
            int Hour = Math.Max(0, timeSpan.Hours);
            int Minutes = Math.Max(0, timeSpan.Minutes);
            int Seconds = Math.Max(0, timeSpan.Seconds);
            remindTime.Value = new DateTime(2019, 1, 1, Hour, Minutes, Seconds, 0);
        }

        public void changeWaveChart()
        {
            int Now_Hit = 0;
            try
            {
                Now_Hit = DBTool.getHitByTime(OperateForm.launch_time);
            }
            catch (Exception ex)
            {
                print("网络连接中断！");
                Application.Exit();
            }
            int Gap = Now_Hit - OperateForm.Tot_Hit;
            this.ucWaveChartSubmit.AddSource(Gap.ToString(), Gap);
            OperateForm.Tot_Hit = Now_Hit;
        }

        public void getPieChart()
        {
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
        
        public void print(string msg)
        {
            MessageBox.Show(msg); 
        }

        //1s
        private void timer1_Tick(object sender, EventArgs e)
        {
            changeWaveChart();
            getRemindTime();
            getLabelData();
        }

        //5s
        private void timer2_Tick(object sender, EventArgs e)
        {
            getRadarChartLines();
            getPopulation();
            getFirstSolveTime();
        }

        //600s
        private void timer3_Tick(object sender, EventArgs e)
        {
            getcartesianChart3();
        }

        //60s
        private void timer4_Tick(object sender, EventArgs e)
        {
            getCartesianChart();
            getPieChart();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    
        private void contestId_Load(object sender, EventArgs e)
        {

        }

        private void population_Load(object sender, EventArgs e)
        {

        }

        private void ucRadarChart1_Load(object sender, EventArgs e)
        {

        }

        private void ucRadarChart2_Load(object sender, EventArgs e)
        {

        }

        private void ucWaveChartSubmit_Load(object sender, EventArgs e)
        {

        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
        }

        private void elementHost3_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void elementHost3_ChildChanged_1(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void ucWaveChart1_Load(object sender, EventArgs e)
        {

        }

        private void remindTime_Load(object sender, EventArgs e)
        {

        }
    }
}
