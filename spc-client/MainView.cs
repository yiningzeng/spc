using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTabbedMdi;
using Newtonsoft.Json;
using spc_client.Model;
using spc_client.ShowForm;
using spc_client.Tools;
using spc_client.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace spc_client
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Dictionary<string, XtraFormBase> xForms = new Dictionary<string, XtraFormBase>();
        SearchForm searchForm;
        public MainView()
        {
            SplashScreenManager.ShowForm(typeof(MySplashScreen));  //ShowForm方法显示LoadIng窗口
            Thread.Sleep(3000);    //为展示效果，将线程延迟设置为5秒
            SplashScreenManager.CloseForm();   //关闭加载窗口
            Thread.Sleep(500);
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();
            searchForm = new SearchForm();
            searchForm.StartPosition = FormStartPosition.CenterScreen;
            searchForm.BringToFront();
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
            Ini();
        }

        #region 更新
        public void CheckUpdate()
        {
            string path = Application.StartupPath + "/Update";
            if (Directory.Exists(path))
            {
                DirectoryInfo root = new DirectoryInfo(path);
                FileInfo[] fileInfos = root.GetFiles();
                if (fileInfos.Length > 0)
                {
                    Update update = new Update(fileInfos);
                    update.Show();
                }
                else
                {
                    MessageBox.Show("无可用更新");
                }
            }
            else
            {
                Directory.CreateDirectory(path);
            }
        }
        #endregion

        void Ini()
        {
            xtraTabbedMdiManager1.SelectedPageChanged += XtraTabbedMdiManager1_SelectedPageChanged;
            xtraTabbedMdiManager1.PageRemoved += XtraTabbedMdiManager1_PageRemoved;
            this.Text = "SPC v" + Application.ProductVersion.ToString();

            #region 初始化所有的Itme按钮事件
            foreach (RibbonPage p in ribbonControl_Main.Pages)
            {
                foreach (RibbonPageGroup g in p.Groups)
                {
                    for (int i = 0; i < g.ItemLinks.Count; i++)
                    {
                        g.ItemLinks[i].Item.ItemClick += Item_ItemClick;
                    }
                }
            }
            #endregion
            ShowForm("整板结果");
            searchForm.Show();
        }

        private void XtraTabbedMdiManager1_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            //受控件事件影响只能是遍历XtraTabbedMdiManager1来删除了
            Dictionary<string, XtraFormBase> temp = new Dictionary<string, XtraFormBase>();
            foreach (var i in xForms)
            {
                for(int n = 0; n < xtraTabbedMdiManager1.Pages.Count; n++)
                {
                    if(xtraTabbedMdiManager1.Pages[n].Text == i.Key)
                    {
                        temp.Add(i.Key, i.Value);
                    }
                }
            }
            xForms.Clear();
            xForms = temp;
        }

        private void XtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            if(xtraTabbedMdiManager1.SelectedPage != null)
            searchForm.XtraFormReset(xForms[xtraTabbedMdiManager1.SelectedPage.Text]);
        }

        /// <summary>
        /// Ribbon 所有item点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Item_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(e.Item.Caption);
        }

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="title"></param>
        /// <param name="xtraForm"></param>
        private void ShowForm(string title)
        {
            splashScreenManager.ShowWaitForm();
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            XtraFormBase xtraForm = null;
            switch (title)
            {
                case "搜索":
                    Cursor.Current = currentCursor;
                    splashScreenManager.CloseWaitForm();
                    searchForm.StartPosition = FormStartPosition.CenterParent;
                    searchForm.ShowDialog();
                    return;
                case "整板结果":
                    xtraForm = new ShowDetail();
                    break;
                case "整板统计":
                    xtraForm = new Statistical();
                    break;
                case "导出报表":
                    if (splashScreenManager.IsSplashFormVisible) splashScreenManager.CloseWaitForm();
                    try { xForms[xtraTabbedMdiManager1.SelectedPage.Text].Export(); } catch { }
                    break;
                    //case "我是测试2":
                    //    xtraForm = new ShowDetail2();
                    //    break;
            }
            try
            {
                XtraMdiTabPage tabPage = GetTabPage(title);
                if (tabPage != null)
                {
                    xtraTabbedMdiManager1.SelectedPage = tabPage;
                }
                else if(xtraForm != null)
                {
                    xForms.Add(title, xtraForm);
                    xtraForm.Text = title;
                    xtraForm.MdiParent = this;
                    xtraForm.Show();
                }
            }
            finally {
                Cursor.Current = currentCursor;
                if(splashScreenManager.IsSplashFormVisible)
                splashScreenManager.CloseWaitForm(); 
            }

        }

        /// <summary>
        /// 判断时候已经有相同的窗体
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private XtraMdiTabPage GetTabPage(string name)
        {
            foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            {
                if (string.Compare(page.MdiChild.Text, name) == 0)
                    return page;
            }
            return null;
        }


        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
            //// Data binding for the Title property (via MVVMContext API)
            //mvvmContext1.SetBinding(barButtonItem1, c => c.Caption, "Title");
            //// UI binding for the Report command
            //MainViewModel viewModel = mvvmContext1.GetViewModel<MainViewModel>();
            //button1.Click += (s, ee) =>
            //{
            //    XtraMessageBox.Show(viewModel.GetTitleAsHumanReadableString());
            //};
        }

        private void barButtonItemUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            CheckUpdate();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "C# Corner Open File Dialog";
            openFileDialog1.InitialDirectory = @"D:\Power-Ftp";
            openFileDialog1.Filter = "All files（*.*）|*.*|All files (*.*)|*.* ";
            /*
             * FilterIndex 属性用于选择了何种文件类型,缺省设置为0,系统取Filter属性设置第一项
             * ,相当于FilterIndex 属性设置为1.如果你编了3个文件类型，当FilterIndex ＝2时是指第2个.
             */
            openFileDialog1.FilterIndex = 0;
            /*
             *如果值为false，那么下一次选择文件的初始目录是上一次你选择的那个目录，
             *不固定；如果值为true，每次打开这个对话框初始目录不随你的选择而改变，是固定的  
             */
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                ////System.IO.Path.GetFullPath(openFileDialog1.FileName); //绝对路径
                ////System.IO.Path.GetExtension(openFileDialog1.FileName); //文件扩展名
                ////System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName); //文件名没有扩展名
                ////System.IO.Path.GetFileName(openFileDialog1.FileName); //得到文件
                                                                         
                JsonData<AoiPcbs> aoi = JsonConvert.DeserializeObject<JsonData<AoiPcbs>>(File.ReadAllText(openFileDialog1.FileName));
                aoi.data.software_id = "26185648716497920";
                aoi.data.pc_ip = "192.168.31.134";
                SpcModel spcModel = DB.Instance();
                //List<AoiResult2D> ngTypes = spcModel.results2d.Where(p => p.PcbId == "26628831906055168").ToList();


                foreach (var i in aoi.data.results_2d)
                {
                    Aoi2DResults a = new Aoi2DResults()
                    {
                        Id = i.Id,
                    };
                    a.IsBack = i.IsBack;
                    a.IsMisjudge = i.IsMisjudge;
                    a.LotName = i.LotName;
                    a.NgType = i.NgType;
                    a.PartImagePath = i.PartImagePath;
                    a.PartName = i.PartName;
                    a.PcbId = i.PcbId;
                    a.ResultString = i.ResultString;
                    a.SubBoard = i.SubBoard;
                    a.Angle = i.Angle;
                    a.Area = i.Area;
                    a.CreateTime = i.CreateTime;

                    spcModel._2dResultsDetail.AddRange(i.ngDetails);
                    spcModel._2dResults.Add(a);
                }
                spcModel.SaveChanges();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            SpcModel spcModel = DB.Instance();
            List<Aoi2DResults> ngTypes = spcModel._2dResults.Where(p => p.PcbId == "26628831906055168").ToList();
        }
    }
}
