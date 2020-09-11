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
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.XtraEditors.ButtonsPanelControl;
using spc_client.Tools;
using spc_client.SqlPar;
using spc_client.UserControls;
using spc_client.Model;

namespace spc_client
{
    public partial class SearchForm : DevExpress.XtraEditors.XtraForm
    {
        XtraFormBase xtraFormBase;
        void IniDefaultValue()
        {
            dateEdit_Start.EditValue = DateTime.Now.AddHours(-1).ToString("yyyy/M/d H:mm:ss");
            dateEdit_End.EditValue = DateTime.Now.ToString("yyyy/M/d H:mm:ss");
        }

        void IniButton(GroupControl groupControl)
        {
            groupControl.Images = imageCollection1;
            groupControl.CustomHeaderButtons[0].Properties.ImageIndex = 0;
            groupControl.CustomButtonClick += GroupControl_CustomButtonClick;
        }

        private void GroupControl_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            GroupControl groupControl = sender as GroupControl;
            GroupBoxButton baseButton = groupControl.CustomHeaderButtons[0] as GroupBoxButton;
            int res = baseButton.ImageOptions.ImageIndex = baseButton.ImageOptions.ImageIndex == 1 ? 0 : 1;

            switch (baseButton.Caption)
            {
                case "按条码查询":
                    QueryPars.enablePcbNumber = Convert.ToBoolean(res);
                    break;
                case "按程序查询":
                    groupControl_Result.Enabled = Convert.ToBoolean(res);
                    QueryPars.enableSoftware = Convert.ToBoolean(res);
                    break;
                case "按检查结果查询":
                    QueryPars.enableResult = Convert.ToBoolean(res);
                    break;
            }
        }

        public SearchForm()
        {
            InitializeComponent();
            this.Load += SearchForm_Load;
            IniDefaultValue();
            IniButton(groupControl_Code);
            IniButton(groupControl_AppName);
            IniButton(groupControl_Result);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            MySmartThreadPool.Instance().QueueWorkItem(() =>
            {
                SpcModel spcModel = DB.Instance();
                try
                {
                    List<AoiSoftwares> aoiSoftwares = spcModel.softwares.ToList();
                    this.BeginInvoke((Action<List<AoiSoftwares>>)((res) =>
                    {
                        gridLookUpEdit_Software.Properties.DataSource = res;
                        gridLookUpEdit_Software.Properties.DisplayMember = "software_name";
                        gridLookUpEdit_Software.Properties.ValueMember = "id";
                    }), aoiSoftwares);
                }
                catch (Exception er)
                {
                    int a = 0;
                }
                finally
                {
                    spcModel.Dispose();
                }
            });
        }

        public void XtraFormReset(XtraFormBase formBase)
        {
            xtraFormBase = formBase;
        }

        private void sbStartSearch_Click(object sender, EventArgs e)
        {
            QueryPars.startTime = dateEdit_Start.DateTime;
            QueryPars.endTime = dateEdit_End.DateTime;
            QueryPars.pcbNumber = textEdit_Number.Text;
            QueryPars.softwareId = gridLookUpEdit_Software.EditValue + "";
            QueryPars.resultId = gridLookUpEdit_NgTypeList.EditValue + "";
            QueryPars.ng_type = gridLookUpEdit_NgTypeList.Text;
            if (radioGroup_NgTye.SelectedIndex == 0)
            {
                QueryPars.resultId = "-1";
            }
            this.Hide();
            if(xtraFormBase!=null) xtraFormBase.QueryReset(); // 触发窗体事件查询
 
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #region 设置时间
        private void sbtn1Hour_Click(object sender, EventArgs e)
        {
            dateEdit_Start.EditValue = DateTime.Now.AddHours(-1).ToString("yyyy/M/d H:mm:ss");
            dateEdit_End.EditValue = DateTime.Now.ToString("yyyy/M/d H:mm:ss");
        }

        private void sbtn8Hour_Click(object sender, EventArgs e)
        {
            dateEdit_Start.EditValue = DateTime.Now.AddHours(-8).ToString("yyyy/M/d H:mm:ss");
            dateEdit_End.EditValue = DateTime.Now.ToString("yyyy/M/d H:mm:ss");
        }

        private void sbtnToday_Click(object sender, EventArgs e)
        {
            dateEdit_Start.EditValue = DateTime.Now.ToString("yyyy/M/d 0:00:00");
            dateEdit_End.EditValue = DateTime.Now.ToString("yyyy/M/d 23:59:59");
        }

        private void sbtn2Day_Click(object sender, EventArgs e)
        {
            dateEdit_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy/M/d 0:00:00");
            dateEdit_End.EditValue = DateTime.Now.ToString("yyyy/M/d 23:59:59");
        }

        private void sbtnThisWeek_Click(object sender, EventArgs e)
        {
            dateEdit_Start.EditValue = MyDateTimeHelper.GetWeekFirstDayMon(DateTime.Now).ToString("yyyy/M/d 0:00:00");
            dateEdit_End.EditValue = MyDateTimeHelper.GetWeekLastDaySun(DateTime.Now).ToString("yyyy/M/d 23:59:59");
        }

        private void sbtnThisMonth_Click(object sender, EventArgs e)
        {
            dateEdit_Start.EditValue = MyDateTimeHelper.GetFirstDayOfMonth(DateTime.Now).ToString("yyyy/M/d 0:00:00");
            dateEdit_End.EditValue = MyDateTimeHelper.GetLastDayOfMonth(DateTime.Now).ToString("yyyy/M/d 23:59:59");
        }

        private void sbtnTwoMonth_Click(object sender, EventArgs e)
        {
            dateEdit_Start.EditValue = MyDateTimeHelper.GetFirstDayOfMonth(DateTime.Now.AddMonths(-1)).ToString("yyyy/M/d 0:00:00");
            dateEdit_End.EditValue = MyDateTimeHelper.GetLastDayOfMonth(DateTime.Now).ToString("yyyy/M/d 23:59:59");
        }
        #endregion

        private void radioGroup_NgTye_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridLookUpEdit_NgTypeList.Enabled = Convert.ToBoolean(radioGroup_NgTye.SelectedIndex);
      
        }

        private void gridLookUpEdit_Software_EditValueChanged(object sender, EventArgs e)
        {
            MySmartThreadPool.Instance().QueueWorkItem((val) =>
            {
                SpcModel spcModel = DB.Instance();
                try
                {
                    List<AoiNgTypes> ngTypes = spcModel.ngTypes.Where(p => p.software_id == val.ToString()).ToList();
                    this.BeginInvoke((Action)(() =>
                    {
                        gridLookUpEdit_NgTypeList.Properties.DataSource = ngTypes;
                        gridLookUpEdit_NgTypeList.Properties.DisplayMember = "ng_str";
                        gridLookUpEdit_NgTypeList.Properties.ValueMember = "id";
                    }));
                }
                catch (Exception er)
                {

                }
                finally
                {
                    spcModel.Dispose();
                }
            }, gridLookUpEdit_Software.EditValue);
        }
    }
}