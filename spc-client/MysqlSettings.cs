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
    public partial class MysqlSettings : DevExpress.XtraEditors.XtraForm
    {
        public MysqlSettings()
        {
            InitializeComponent();

            string host = INIHelper.Read("db", "host", Application.StartupPath + "/config.ini");
            string port = INIHelper.Read("db", "port", Application.StartupPath + "/config.ini");
            string user = INIHelper.Read("db", "user", Application.StartupPath + "/config.ini");
            string pass = INIHelper.Read("db", "password", Application.StartupPath + "/config.ini");
            string database = INIHelper.Read("db", "database", Application.StartupPath + "/config.ini");

            teHost.Text = host;
            tePort.Text = port;
            teUser.Text = user;
            tePass.Text = pass;
            teDatabse.Text = database;

        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            INIHelper.Write("db", "host", teHost.Text.Trim(), Application.StartupPath + "/config.ini");
            INIHelper.Write("db", "port", tePort.Text.Trim(), Application.StartupPath + "/config.ini");
            INIHelper.Write("db", "user", teUser.Text.Trim(), Application.StartupPath + "/config.ini");
            INIHelper.Write("db", "password", tePass.Text.Trim(), Application.StartupPath + "/config.ini");
            INIHelper.Write("db", "database", teDatabse.Text.Trim(), Application.StartupPath + "/config.ini");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}