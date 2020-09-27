using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTabbedMdi;
using spc_client.Model;
using spc_client.ShowForm;
using spc_client.Tools;
using spc_client.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        void Ini()
        {
            xtraTabbedMdiManager1.SelectedPageChanged += XtraTabbedMdiManager1_SelectedPageChanged;
            xtraTabbedMdiManager1.PageRemoved += XtraTabbedMdiManager1_PageRemoved;
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
            finally { Cursor.Current = currentCursor; splashScreenManager.CloseWaitForm(); }

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

    }
}
