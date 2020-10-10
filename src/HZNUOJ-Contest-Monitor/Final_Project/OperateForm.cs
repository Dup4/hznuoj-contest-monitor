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
    public partial class OperateForm : Form
    {
        public string sql;
        public DataSet ds;
        public static DateTime start_time, end_time;
        public static string launch_time;
        public static DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
        public static int problemCnt;
        public static int Tot_Hit;
        public static string[] charMp = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M" };
        public static int[] result = new int[4] { 10, 6, 4, 7 };
        public static string[] resultName = new string[4] { "RTE", "WA", "AC", "TLE" };

        public OperateForm()
        {
            InitializeComponent();
            dtFormat.ShortDatePattern = "yyyy-MM-dd HH:mm:ss";

            try
            {
                launch_time = DBTool.getNow();
                Tot_Hit = DBTool.getHitByTime(launch_time);
                start_time = Convert.ToDateTime(DBTool.getStartTime(), dtFormat);
                end_time = Convert.ToDateTime(DBTool.getEndTime(), dtFormat);
                problemCnt = Math.Min(13, 1 + DBTool.getProblemCnt());
            }
            catch (Exception ex)
            {
                print("网络连接中断！");
                Application.Exit();
            }

            for (int i = 0; i < problemCnt; ++i)
            {
                comboBox1.Items.Add(charMp[i]);
            }
            
        }

        public void print(string msg)
        {
            MessageBox.Show(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SubmitAndACChart().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = comboBox1.SelectedIndex;
            if (num == -1)
            {
                print("请先选择题目序号！");
            }
            else
            {
                new SingleSubmitLanguageChart(num).Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = comboBox1.SelectedIndex;
            if (num == -1)
            {
                print("请先选择题目序号！");
            }
            else
            {
                new SingleSubmitResultChart(num).Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = comboBox1.SelectedIndex;
            if (num == -1)
            {
                print("请先选择题目序号！");
            }
            else
            {
                new SingleSubmitAndACChart(num).Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new TeamCntChart().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new SubmitResultChart().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new MainPieChart().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new SubmitResultTenChart().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int num = comboBox1.SelectedIndex;
            if (num == -1)
            {
                print("请先选择题目序号！");
            }
            else
            {
                new SingleSubmitResultTenChart(num).Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //print(comboBox1.SelectedIndex.ToString());
        }

        private void OperateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
