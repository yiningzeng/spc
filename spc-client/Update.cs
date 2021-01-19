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
using System.IO;

namespace spc_client
{
    public partial class Update : DevExpress.XtraEditors.XtraForm
    {
        public FileInfo[] fileInfos;
        public Update(FileInfo[] fs)
        {
            InitializeComponent();
            fileInfos = fs;
            this.Load += Update_Load;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            DoUpdate(fileInfos);
        }

        public void DoUpdate(FileInfo[] fileInfos)
        {
            lbAll.Text = fileInfos.Length + "";
            foreach (FileInfo fileInfo in fileInfos)
            {
                if (fileInfo.Extension == ".sql")
                {
                    MySmartThreadPool.Instance().QueueWorkItem((f) =>
                    {
                        try
                        {
                            SpcModel spcModel = DB.Instance();
                            object[] parameters = new object[] { "a", "b" };
                            int res = spcModel.Database.ExecuteSqlCommand(File.ReadAllText(f.FullName));
                            if (res == 0)
                            {
                                this.BeginInvoke((Action)(() =>
                                {
                                    lbNow.Text = (int.Parse(lbNow.Text) + 1).ToString();
                                }));
                            }
                            else
                            {
                                this.BeginInvoke((Action)(() =>
                                {
                                    lbErr.Visible = true;
                                    lbErrNum.Visible = true;
                                    lbErrNum.Text = (int.Parse(lbErrNum.Text) + 1).ToString();
                                }));
                            }
                        }
                        catch (Exception er) {
                            this.BeginInvoke((Action)(() =>
                            {
                                lbErr.Visible = true;
                                lbErrNum.Visible = true;
                                lbErrNum.Text = (int.Parse(lbErrNum.Text) + 1).ToString();
                            }));
                        }
                        finally
                        {
                            f.Delete();
                            this.BeginInvoke((Action)(() =>
                            {
                                if (int.Parse(lbErrNum.Text) + int.Parse(lbNow.Text) >= fileInfos.Length)
                                {
                                    if (MessageBox.Show(lbNow.Text + "个更新完成", "提醒", MessageBoxButtons.OK) == DialogResult.OK)
                                    {
                                        this.Close();
                                    }
                                }
                            }));
                        }
                    }, fileInfo);
                }
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //INIHelper.Write("db", "host", teHost.Text.Trim(), Application.StartupPath + "/config.ini");
            //INIHelper.Write("db", "port", tePort.Text.Trim(), Application.StartupPath + "/config.ini");
            //INIHelper.Write("db", "user", teUser.Text.Trim(), Application.StartupPath + "/config.ini");
            //INIHelper.Write("db", "password", tePass.Text.Trim(), Application.StartupPath + "/config.ini");
            //INIHelper.Write("db", "database", teDatabse.Text.Trim(), Application.StartupPath + "/config.ini");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}