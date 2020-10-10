namespace Final_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            HZH_Controls.Controls.RadarLine radarLine5 = new HZH_Controls.Controls.RadarLine();
            HZH_Controls.Controls.RadarLine radarLine6 = new HZH_Controls.Controls.RadarLine();
            HZH_Controls.Controls.RadarPosition radarPosition13 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition14 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition15 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition16 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition17 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition18 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarLine radarLine7 = new HZH_Controls.Controls.RadarLine();
            HZH_Controls.Controls.RadarLine radarLine8 = new HZH_Controls.Controls.RadarLine();
            HZH_Controls.Controls.RadarPosition radarPosition19 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition20 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition21 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition22 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition23 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition24 = new HZH_Controls.Controls.RadarPosition();
            this.remindTime = new HZH_Controls.Controls.UCLEDTime();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contestId = new HZH_Controls.Controls.UCLEDNums();
            this.population = new HZH_Controls.Controls.UCLEDNums();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ucRadarChart_AC = new HZH_Controls.Controls.UCRadarChart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tot_submit = new System.Windows.Forms.Label();
            this.tot_judging = new System.Windows.Forms.Label();
            this.tot_pending = new System.Windows.Forms.Label();
            this.tot_AC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ucRadarChart_Tot = new HZH_Controls.Controls.UCRadarChart();
            this.ucWaveChartSubmit = new HZH_Controls.Controls.UCWaveChart();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.FirstSolveTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart2 = new LiveCharts.Wpf.CartesianChart();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart3 = new LiveCharts.Wpf.CartesianChart();
            this.SuspendLayout();
            // 
            // remindTime
            // 
            this.remindTime.BackColor = System.Drawing.Color.Transparent;
            this.remindTime.ForeColor = System.Drawing.Color.Red;
            this.remindTime.LineWidth = 8;
            this.remindTime.Location = new System.Drawing.Point(819, 12);
            this.remindTime.Name = "remindTime";
            this.remindTime.Size = new System.Drawing.Size(290, 58);
            this.remindTime.TabIndex = 0;
            this.remindTime.Value = new System.DateTime(2019, 12, 20, 12, 26, 52, 43);
            this.remindTime.Load += new System.EventHandler(this.remindTime_Load);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contestId
            // 
            this.contestId.BackColor = System.Drawing.Color.Transparent;
            this.contestId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.contestId.LineWidth = 8;
            this.contestId.Location = new System.Drawing.Point(16, 12);
            this.contestId.Name = "contestId";
            this.contestId.Size = new System.Drawing.Size(165, 58);
            this.contestId.TabIndex = 1;
            this.contestId.Value = "9349";
            this.contestId.Load += new System.EventHandler(this.contestId_Load);
            // 
            // population
            // 
            this.population.BackColor = System.Drawing.Color.Transparent;
            this.population.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.population.LineWidth = 8;
            this.population.Location = new System.Drawing.Point(1719, 12);
            this.population.Name = "population";
            this.population.Size = new System.Drawing.Size(156, 58);
            this.population.TabIndex = 2;
            this.population.Value = "499";
            this.population.Load += new System.EventHandler(this.population_Load);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ucRadarChart_AC
            // 
            this.ucRadarChart_AC.BackColor = System.Drawing.Color.Transparent;
            this.ucRadarChart_AC.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            radarLine5.FillColor = null;
            radarLine5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            radarLine5.Name = "line0";
            radarLine5.ShowValueText = false;
            radarLine5.Values = new double[] {
        36D,
        21D,
        57D,
        54D,
        57D,
        62D};
            radarLine6.FillColor = null;
            radarLine6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            radarLine6.Name = "line1";
            radarLine6.ShowValueText = false;
            radarLine6.Values = new double[] {
        79D,
        88D,
        97D,
        56D,
        78D,
        42D};
            this.ucRadarChart_AC.Lines = new HZH_Controls.Controls.RadarLine[] {
        radarLine5,
        radarLine6};
            this.ucRadarChart_AC.Location = new System.Drawing.Point(0, 291);
            this.ucRadarChart_AC.Name = "ucRadarChart_AC";
            radarPosition13.MaxValue = 100D;
            radarPosition13.Text = "Item1";
            radarPosition14.MaxValue = 100D;
            radarPosition14.Text = "Item2";
            radarPosition15.MaxValue = 100D;
            radarPosition15.Text = "Item3";
            radarPosition16.MaxValue = 100D;
            radarPosition16.Text = "Item4";
            radarPosition17.MaxValue = 100D;
            radarPosition17.Text = "Item5";
            radarPosition18.MaxValue = 100D;
            radarPosition18.Text = "Item6";
            this.ucRadarChart_AC.RadarPositions = new HZH_Controls.Controls.RadarPosition[] {
        radarPosition13,
        radarPosition14,
        radarPosition15,
        radarPosition16,
        radarPosition17,
        radarPosition18};
            this.ucRadarChart_AC.Size = new System.Drawing.Size(205, 242);
            this.ucRadarChart_AC.SplitCount = 5;
            this.ucRadarChart_AC.SplitEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucRadarChart_AC.SplitOddColor = System.Drawing.Color.White;
            this.ucRadarChart_AC.TabIndex = 3;
            this.ucRadarChart_AC.Title = null;
            this.ucRadarChart_AC.TitleColor = System.Drawing.Color.Black;
            this.ucRadarChart_AC.TitleFont = new System.Drawing.Font("微软雅黑", 12F);
            this.ucRadarChart_AC.UseRoundSplit = false;
            this.ucRadarChart_AC.Load += new System.EventHandler(this.ucRadarChart1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("黑体", 14F);
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "提交总量：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 14F);
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "正在判题：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("黑体", 14F);
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "等待判题：";
            // 
            // tot_submit
            // 
            this.tot_submit.AutoSize = true;
            this.tot_submit.BackColor = System.Drawing.Color.Transparent;
            this.tot_submit.Font = new System.Drawing.Font("黑体", 14F);
            this.tot_submit.Location = new System.Drawing.Point(111, 126);
            this.tot_submit.Name = "tot_submit";
            this.tot_submit.Size = new System.Drawing.Size(49, 19);
            this.tot_submit.TabIndex = 9;
            this.tot_submit.Text = "7814";
            // 
            // tot_judging
            // 
            this.tot_judging.AutoSize = true;
            this.tot_judging.BackColor = System.Drawing.Color.Transparent;
            this.tot_judging.Font = new System.Drawing.Font("黑体", 14F);
            this.tot_judging.Location = new System.Drawing.Point(111, 201);
            this.tot_judging.Name = "tot_judging";
            this.tot_judging.Size = new System.Drawing.Size(29, 19);
            this.tot_judging.TabIndex = 10;
            this.tot_judging.Text = "12";
            // 
            // tot_pending
            // 
            this.tot_pending.AutoSize = true;
            this.tot_pending.BackColor = System.Drawing.Color.Transparent;
            this.tot_pending.Font = new System.Drawing.Font("黑体", 14F);
            this.tot_pending.Location = new System.Drawing.Point(111, 240);
            this.tot_pending.Name = "tot_pending";
            this.tot_pending.Size = new System.Drawing.Size(49, 19);
            this.tot_pending.TabIndex = 11;
            this.tot_pending.Text = "1204";
            // 
            // tot_AC
            // 
            this.tot_AC.AutoSize = true;
            this.tot_AC.BackColor = System.Drawing.Color.Transparent;
            this.tot_AC.Font = new System.Drawing.Font("黑体", 14F);
            this.tot_AC.Location = new System.Drawing.Point(111, 163);
            this.tot_AC.Name = "tot_AC";
            this.tot_AC.Size = new System.Drawing.Size(49, 19);
            this.tot_AC.TabIndex = 13;
            this.tot_AC.Text = "1204";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("黑体", 14F);
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "通过总量：";
            // 
            // ucRadarChart_Tot
            // 
            this.ucRadarChart_Tot.BackColor = System.Drawing.Color.Transparent;
            this.ucRadarChart_Tot.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            radarLine7.FillColor = null;
            radarLine7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            radarLine7.Name = "line0";
            radarLine7.ShowValueText = false;
            radarLine7.Values = new double[] {
        36D,
        21D,
        57D,
        54D,
        57D,
        62D};
            radarLine8.FillColor = null;
            radarLine8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            radarLine8.Name = "line1";
            radarLine8.ShowValueText = false;
            radarLine8.Values = new double[] {
        79D,
        88D,
        97D,
        56D,
        78D,
        42D};
            this.ucRadarChart_Tot.Lines = new HZH_Controls.Controls.RadarLine[] {
        radarLine7,
        radarLine8};
            this.ucRadarChart_Tot.Location = new System.Drawing.Point(0, 538);
            this.ucRadarChart_Tot.Name = "ucRadarChart_Tot";
            radarPosition19.MaxValue = 100D;
            radarPosition19.Text = "Item1";
            radarPosition20.MaxValue = 100D;
            radarPosition20.Text = "Item2";
            radarPosition21.MaxValue = 100D;
            radarPosition21.Text = "Item3";
            radarPosition22.MaxValue = 100D;
            radarPosition22.Text = "Item4";
            radarPosition23.MaxValue = 100D;
            radarPosition23.Text = "Item5";
            radarPosition24.MaxValue = 100D;
            radarPosition24.Text = "Item6";
            this.ucRadarChart_Tot.RadarPositions = new HZH_Controls.Controls.RadarPosition[] {
        radarPosition19,
        radarPosition20,
        radarPosition21,
        radarPosition22,
        radarPosition23,
        radarPosition24};
            this.ucRadarChart_Tot.Size = new System.Drawing.Size(205, 242);
            this.ucRadarChart_Tot.SplitCount = 5;
            this.ucRadarChart_Tot.SplitEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucRadarChart_Tot.SplitOddColor = System.Drawing.Color.White;
            this.ucRadarChart_Tot.TabIndex = 14;
            this.ucRadarChart_Tot.Title = null;
            this.ucRadarChart_Tot.TitleColor = System.Drawing.Color.Black;
            this.ucRadarChart_Tot.TitleFont = new System.Drawing.Font("微软雅黑", 12F);
            this.ucRadarChart_Tot.UseRoundSplit = false;
            this.ucRadarChart_Tot.Load += new System.EventHandler(this.ucRadarChart2_Load);
            // 
            // ucWaveChartSubmit
            // 
            this.ucWaveChartSubmit.ConerRadius = 10;
            this.ucWaveChartSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ucWaveChartSubmit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucWaveChartSubmit.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ucWaveChartSubmit.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ucWaveChartSubmit.IsRadius = true;
            this.ucWaveChartSubmit.IsShowRect = true;
            this.ucWaveChartSubmit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ucWaveChartSubmit.LineTension = 0.5F;
            this.ucWaveChartSubmit.Location = new System.Drawing.Point(167, 96);
            this.ucWaveChartSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucWaveChartSubmit.Name = "ucWaveChartSubmit";
            this.ucWaveChartSubmit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucWaveChartSubmit.RectWidth = 1;
            this.ucWaveChartSubmit.Size = new System.Drawing.Size(1541, 200);
            this.ucWaveChartSubmit.SleepTime = 1000;
            this.ucWaveChartSubmit.TabIndex = 16;
            this.ucWaveChartSubmit.WaveWidth = 50;
            this.ucWaveChartSubmit.Load += new System.EventHandler(this.ucWaveChartSubmit_Load);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 600000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(1698, 358);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(217, 187);
            this.pieChart1.TabIndex = 19;
            this.pieChart1.Text = "pieChart1";
            this.pieChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.pieChart1_ChildChanged);
            // 
            // FirstSolveTime
            // 
            this.FirstSolveTime.AutoSize = true;
            this.FirstSolveTime.BackColor = System.Drawing.Color.Transparent;
            this.FirstSolveTime.Font = new System.Drawing.Font("黑体", 14F);
            this.FirstSolveTime.Location = new System.Drawing.Point(1739, 117);
            this.FirstSolveTime.Name = "FirstSolveTime";
            this.FirstSolveTime.Size = new System.Drawing.Size(109, 19);
            this.FirstSolveTime.TabIndex = 20;
            this.FirstSolveTime.Text = "提交总量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("黑体", 14F);
            this.label8.Location = new System.Drawing.Point(1728, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "首A时间：";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(211, 317);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(658, 437);
            this.elementHost1.TabIndex = 22;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHost1.Child = this.cartesianChart1;
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(1698, 562);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(217, 187);
            this.pieChart2.TabIndex = 23;
            this.pieChart2.Text = "pieChart2";
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(898, 317);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(774, 437);
            this.elementHost2.TabIndex = 24;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost2_ChildChanged);
            this.elementHost2.Child = this.cartesianChart2;
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 60000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // elementHost3
            // 
            this.elementHost3.Location = new System.Drawing.Point(0, 760);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(1904, 284);
            this.elementHost3.TabIndex = 25;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost3_ChildChanged_1);
            this.elementHost3.Child = this.cartesianChart3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.elementHost3);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.pieChart2);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FirstSolveTime);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.ucWaveChartSubmit);
            this.Controls.Add(this.ucRadarChart_Tot);
            this.Controls.Add(this.tot_AC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tot_pending);
            this.Controls.Add(this.tot_judging);
            this.Controls.Add(this.tot_submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucRadarChart_AC);
            this.Controls.Add(this.population);
            this.Controls.Add(this.contestId);
            this.Controls.Add(this.remindTime);
            this.Name = "MainForm";
            this.Text = "主面板";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCLEDTime remindTime;
        private System.Windows.Forms.Timer timer1;
        private HZH_Controls.Controls.UCLEDNums contestId;
        private HZH_Controls.Controls.UCLEDNums population;
        private System.Windows.Forms.Timer timer2;
        private HZH_Controls.Controls.UCRadarChart ucRadarChart_AC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tot_submit;
        private System.Windows.Forms.Label tot_judging;
        private System.Windows.Forms.Label tot_pending;
        private System.Windows.Forms.Label tot_AC;
        private System.Windows.Forms.Label label6;
        private HZH_Controls.Controls.UCRadarChart ucRadarChart_Tot;
        private HZH_Controls.Controls.UCWaveChart ucWaveChartSubmit;
        private System.Windows.Forms.Timer timer3;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label FirstSolveTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart2;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LiveCharts.Wpf.CartesianChart cartesianChart2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private LiveCharts.Wpf.CartesianChart cartesianChart3;
    }
}