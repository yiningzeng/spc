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
using DevExpress.XtraGrid.Columns;

namespace spc_client.ShowForm
{
    public partial class Statistical : XtraFormBase
    {
        List<RetNgTypesPai> finalDB = new List<RetNgTypesPai>();
        int allQueryNum = 0; //指的是一共查询的月份个数
        int currentNum = 0; // 标识当前运行了几个
        public Statistical()
        {
            InitializeComponent();
            gridView_Results.FocusedRowChanged += GridView_Results_FocusedRowChanged;
            gridView_Results.CustomDrawEmptyForeground += GridView_CustomDrawEmptyForeground;
            SetReadOnly(gridView_Results);
        }
        void SetReadOnly(GridView gv)
        {
            foreach (GridColumn item in gv.Columns)
            {
                item.OptionsColumn.ReadOnly = true;
                item.OptionsColumn.AllowEdit = false;
                //禁止单元格获取焦点
                item.OptionsColumn.AllowFocus = false;
            }
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
            CreatePieChart(retStatistical.software_id, dt, dt2);
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
        private void CreatePieChart(string software_id, DataTable dt, DataTable dt2)
        {
            chartControl3.Series.Clear();
            Series series = new Series("饼图2", ViewType.Pie);
            series.DataSource = dt;
            //series.ArgumentScaleType = ScaleType.Qualitative;
            //项目名称
            series.ArgumentDataMember = "ItemName";
            series.ValueScaleType = ScaleType.Numerical;
            //取值字段
            series.ValueDataMembers.AddRange(new string[] { "ItemValue" });
            //(series.Label as PieSeriesLabel).Position = PieSeriesLabelPosition.Inside;
            ////显示百分比和项目名称(业务员姓名)
            series.PointOptions.PointView = PointView.ArgumentAndValues;
            series.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;
            chartControl3.Series.Add(series);

            series = new Series("饼图3", ViewType.Pie);
            series.DataSource = dt2;
            //series.ArgumentScaleType = ScaleType.Qualitative;
            //项目名称
            series.ArgumentDataMember = "ItemName";
            series.ValueScaleType = ScaleType.Numerical;
            //取值字段
            series.ValueDataMembers.AddRange(new string[] { "ItemValue" });
            //(series.Label as PieSeriesLabel).Position = PieSeriesLabelPosition.Inside;
            ////显示百分比和项目名称(业务员姓名)
            series.PointOptions.PointView = PointView.ArgumentAndValues;
            series.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;
            chartControl3.Series.Add(series);

          
            //MySmartThreadPool.Instance().QueueWorkItem(() =>
            //{
            //    if (!splashScreenManager.IsSplashFormVisible) splashScreenManager.ShowWaitForm();
            //    SpcModel spcModel = DB.Instance();
            //    try
            //    {
            //        List<RetNgTypesPai> rets = spcModel.Database.SqlQuery<RetNgTypesPai>(string.Format("SELECT ng_str, COUNT(*) as num FROM softwares_ngtype WHERE software_id = '{0}' and create_time BETWEEN '{1}' AND '{2}'  GROUP BY ng_str", software_id, QueryPars.startTime, QueryPars.endTime)).ToList();
            //        this.BeginInvoke((Action)(() =>
            //        {
            //            chartControl_NG.Series.Clear();
            //            Series series2 = new Series("饼图1", ViewType.Pie);
            //            series2.DataSource = rets;
            //            //series.ArgumentScaleType = ScaleType.Qualitative;
            //            //项目名称
            //            series2.ArgumentDataMember = "ng_str";
            //            series2.ValueScaleType = ScaleType.Numerical;
            //            //取值字段
            //            series2.ValueDataMembers.AddRange(new string[] { "num" });
            //            //(series2.Label as PieSeriesLabel).Position = PieSeriesLabelPosition.Inside;
            //            ////显示百分比和项目名称(业务员姓名)
            //            series2.PointOptions.PointView = PointView.ArgumentAndValues;
            //            series2.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;
            //            chartControl_NG.Series.Add(series2);

            //        }));
            //    }
            //    catch (Exception er)
            //    {

            //    }
            //    finally
            //    {
            //        try
            //        {
            //            if (splashScreenManager.IsSplashFormVisible) splashScreenManager.CloseWaitForm();
            //        }
            //        catch { }
    
            //        spcModel.Dispose();
            //    }
            //});
        }

        void ReSetInfo()
        {
            finalDB = null;
            finalDB = new List<RetNgTypesPai>();
            allQueryNum = 0; //指的是一共查询的月份个数
            currentNum = 0; // 标识当前运行了几个

            chartControl1.DataSource = null;
            chartControl_NG.DataSource = null;
            gridControl_Results.DataSource = null;
            chartControl1.Series.Clear();
            chartControl_NG.Series.Clear();
            chartControl3.Series.Clear();
        }
        public override void Export()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出Excel";
            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            DialogResult dialogResult = saveFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                gridControl_Results.ExportToXls(saveFileDialog.FileName);
                XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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