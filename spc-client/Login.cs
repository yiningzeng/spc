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
using spc_client.Tools;
using spc_client.Model;

namespace spc_client
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SpcModel spcModel = DB.Instance();
            try
            {
                string md5Pass = Utils.GenerateMD5(tePassword.Text);
                AoiUsers user = spcModel.users.Where(u => u.username == teUser.Text && u.password == md5Pass).FirstOrDefault();
                if (user != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    //this.BeginInvoke((Action)(() =>
                    //{
                    //    lbResult.Text = "用户名或密码错误";
                    //    lbResult.Visible = true;
                    //}));

                }
            }
            catch (Exception err)
            {
                //this.BeginInvoke((Action)(() =>
                //{
                //    lbResult.Text = "连接数据库出错";
                //    lbResult.Visible = true;
                //}));
                //LogHelper.WriteLog("Login error", err);
            }
            finally
            {
                spcModel.Dispose();
            }
        }
    }
}