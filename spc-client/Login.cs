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
        bool isLogined = false;
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
                    isLogined = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.BeginInvoke((Action)(() =>
                    {
                        labelControl_Status.Text = "用户名或密码错误";
                        labelControl_Status.Visible = true;
                    }));
                }
            }
            catch (Exception err)
            {
                this.BeginInvoke((Action)(() =>
                {
                    labelControl_Status.Text = "连接数据库出错";
                    labelControl_Status.Visible = true;
                }));
                //LogHelper.WriteLog("Login error", err);
            }
            finally
            {
                spcModel.Dispose();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogined)
            {
                Environment.Exit(0);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MysqlSettings mysqlSettings = new MysqlSettings();
            mysqlSettings.ShowDialog();
        }
    }
}