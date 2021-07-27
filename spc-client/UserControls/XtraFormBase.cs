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

namespace spc_client.UserControls
{
    public partial class XtraFormBase : DevExpress.XtraEditors.XtraForm
    {
        public DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;

        public XtraFormBase()
        {
            InitializeComponent();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::spc_client.MyWaitForm), true, true);
            this.splashScreenManager.ClosingDelay = 500;
        }

        public virtual void QueryReset(){ }
        public virtual void Export(){ }
    }
}