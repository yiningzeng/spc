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
        public XtraFormBase()
        {
            InitializeComponent();
        }

        public virtual void QueryReset()
        {
        }
        public virtual void Export()
        {
        }
    }
}