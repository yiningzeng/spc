using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using spc_client.Model;
using spc_client.Tools;
using spc_client.UserControls;
using spc_client.SqlPar;
using DevExpress.XtraGrid;
using System.Threading;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraLayout;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using DevExpress.XtraCharts;

namespace spc_client.ShowForm
{
    public partial class Statistical : XtraFormBase
    {
        Rectangle rectFront,rectBack;
        public Statistical()
        {
            InitializeComponent();
            gridView_Results.FocusedRowChanged += GridView_Results_FocusedRowChanged;
            gridView_Results.CustomDrawEmptyForeground += GridView_CustomDrawEmptyForeground;
            rectFront = rectBack = new Rectangle(-1, -1, 0, 0);
        }

        private void GridView_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (gridView.RowCount == 0)
            {
                string str = "暂未查找到匹配的数据!";
                Font f = new Font("微软雅黑", 16);
                Rectangle r = new Rectangle(gridView.GridControl.Width / 2 - 100, e.Bounds.Top + 45, e.Bounds.Right - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString(str, f, Brushes.Gray, r);

            }
        }

        private void GridView_Results_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView_Results.GetFocusedRow() != null)
                ShowChart(gridView_Results.GetFocusedRow() as RetStatistical);
            //ShowResultInfo(gridView_Results.GetFocusedRow() as RetResults);
        }
        private void ShowChart(RetStatistical retStatistical)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ItemName")); //项目名称
            dt.Columns.Add(new DataColumn("ItemValue", typeof(decimal))); //取值字段

            dt.Rows.Add(new object[] { "不良率", float.Parse(retStatistical.defect_rate.Replace("%","")) / 100 });
            dt.Rows.Add(new object[] { "直通率", float.Parse(retStatistical.pass_rate.Replace("%", "")) / 100 });
            DataTable dt2 = new DataTable();
            dt2.Columns.Add(new DataColumn("ItemName")); //项目名称
            dt2.Columns.Add(new DataColumn("ItemValue", typeof(decimal))); //取值字段

            dt2.Rows.Add(new object[] { "不良板数", retStatistical.count_error_pcb});
            dt2.Rows.Add(new object[] { "误报板数", retStatistical.count_warning_pcb });
            dt2.Rows.Add(new object[] { "GOOD板数", retStatistical.count_good_pcb });
            CreatePieChart(dt, dt2);
            CreateBarChart(retStatistical);
        }
        private void CreateBarChart(RetStatistical retStatistical)
        {
            chartControl1.Series.Clear();
            Series series1 = new Series("直方图", ViewType.Bar);
            series1.Points.Add(new SeriesPoint("不良板数", retStatistical.count_error_pcb));
            series1.Points.Add(new SeriesPoint("误报板数", retStatistical.count_warning_pcb));
            series1.Points.Add(new SeriesPoint("GOOD板数", retStatistical.count_good_pcb));

            // Create the second side-by-side bar series and add points to it.
            //Series series2 = new Series("Side-by-Side Bar Series 2", ViewType.Bar);
            //series2.Points.Add(new SeriesPoint("A", 15));
            //series2.Points.Add(new SeriesPoint("B", 18));
            //series2.Points.Add(new SeriesPoint("C", 25));
            //series2.Points.Add(new SeriesPoint("D", 33));

            // Add the series to the chart.
            chartControl1.Series.Add(series1);
            //chartControl1.Series.Add(series2);
        }
        private void CreatePieChart(DataTable dt, DataTable dt2)
        {
            chartControl2.Series.Clear();
            
            Series series = new Series("饼图", ViewType.Pie3D);
            series.DataSource = dt;
            series.ArgumentScaleType = ScaleType.Qualitative;

            //项目名称
            series.ArgumentDataMember = "ItemName";
            series.ValueScaleType = ScaleType.Numerical;

            //取值字段
            series.ValueDataMembers.AddRange(new string[] { "ItemValue" });
            (series.Label as PieSeriesLabel).Position = PieSeriesLabelPosition.Inside;

            //显示百分比和项目名称(业务员姓名)
            series.PointOptions.PointView = PointView.ArgumentAndValues;
            series.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;

            Series series2 = new Series("饼图2", ViewType.Pie3D);
            series2.DataSource = dt2;
            series2.ArgumentScaleType = ScaleType.Qualitative;

            //项目名称
            series2.ArgumentDataMember = "ItemName";
            series2.ValueScaleType = ScaleType.Numerical;

            //取值字段
            series2.ValueDataMembers.AddRange(new string[] { "ItemValue" });
            (series2.Label as PieSeriesLabel).Position = PieSeriesLabelPosition.Inside;

            //显示百分比和项目名称(业务员姓名)
            series2.PointOptions.PointView = PointView.ArgumentAndValues;
            series2.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;

            chartControl2.Series.Add(series2);
            chartControl2.Series.Add(series);
            //右上角分组视图
            chartControl2.Legend.MarkerSize = new System.Drawing.Size(20, 20);
            chartControl2.Legend.TextOffset = 5;
            chartControl2.Legend.VerticalIndent = 5;
            chartControl2.Legend.Border.Color = Color.Red;//红色边框
        }

        void ReSetInfo()
        {
            chartControl1.DataSource = null;
            chartControl2.DataSource = null;
            gridControl_Results.DataSource = null;
        }

        public override void QueryReset()
        {
            ReSetInfo();
            MySmartThreadPool.Instance().QueueWorkItem(() =>
            {
                if (!splashScreenManager.IsSplashFormVisible) splashScreenManager.ShowWaitForm();
                SpcModel spcModel = DB.Instance();
                try
                {
                    List<RetStatistical> rets = spcModel.Database.SqlQuery<RetStatistical>(QueryPars.GetMainStatisticalStr()).ToList();
                    this.BeginInvoke((Action)(() =>
                    {
                        gridControl_Results.DataSource = rets;
                    }));
                }
                catch (Exception er)
                {

                }
                finally
                {
                    if (splashScreenManager.IsSplashFormVisible) splashScreenManager.CloseWaitForm();
                    spcModel.Dispose();
                }
            });
        }

    }
}