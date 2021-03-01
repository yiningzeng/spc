namespace spc_client
{
    partial class MysqlSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MysqlSettings));
            this.teHost = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tePort = new DevExpress.XtraEditors.TextEdit();
            this.teUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tePass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.teDatabse = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teHost
            // 
            this.teHost.EditValue = "";
            this.teHost.Location = new System.Drawing.Point(69, 17);
            this.teHost.Name = "teHost";
            this.teHost.Size = new System.Drawing.Size(225, 20);
            this.teHost.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "IP";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "端口";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(69, 171);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(110, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "保存设置";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // tePort
            // 
            this.tePort.EditValue = "";
            this.tePort.Location = new System.Drawing.Point(69, 43);
            this.tePort.Name = "tePort";
            this.tePort.Size = new System.Drawing.Size(225, 20);
            this.tePort.TabIndex = 7;
            // 
            // teUser
            // 
            this.teUser.EditValue = "";
            this.teUser.Location = new System.Drawing.Point(69, 69);
            this.teUser.Name = "teUser";
            this.teUser.Size = new System.Drawing.Size(225, 20);
            this.teUser.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "用户";
            // 
            // tePass
            // 
            this.tePass.EditValue = "";
            this.tePass.Location = new System.Drawing.Point(69, 95);
            this.tePass.Name = "tePass";
            this.tePass.Size = new System.Drawing.Size(225, 20);
            this.tePass.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "密码";
            // 
            // teDatabse
            // 
            this.teDatabse.EditValue = "";
            this.teDatabse.Location = new System.Drawing.Point(69, 121);
            this.teDatabse.Name = "teDatabse";
            this.teDatabse.Size = new System.Drawing.Size(225, 20);
            this.teDatabse.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 124);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "数据库名";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(185, 171);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 23);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "关   闭";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // MysqlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 208);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.teDatabse);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.tePass);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.teUser);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tePort);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teHost);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MysqlSettings.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MysqlSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "连接设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.teHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDatabse.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teHost;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit tePort;
        private DevExpress.XtraEditors.TextEdit teUser;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tePass;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit teDatabse;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}