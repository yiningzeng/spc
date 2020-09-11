namespace spc_client
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.teUser = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Status = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teUser
            // 
            this.teUser.EditValue = "admin";
            this.teUser.Location = new System.Drawing.Point(92, 65);
            this.teUser.Name = "teUser";
            this.teUser.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("teUser.Properties.ContextImageOptions.Image")));
            this.teUser.Size = new System.Drawing.Size(128, 20);
            this.teUser.TabIndex = 0;
            // 
            // tePassword
            // 
            this.tePassword.EditValue = "admin";
            this.tePassword.Location = new System.Drawing.Point(92, 109);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tePassword.Properties.ContextImageOptions.Image")));
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(128, 20);
            this.tePassword.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(92, 162);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(128, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "登  录";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "账 号";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "密 码";
            // 
            // labelControl_Status
            // 
            this.labelControl_Status.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.labelControl_Status.Appearance.Options.UseForeColor = true;
            this.labelControl_Status.Location = new System.Drawing.Point(92, 136);
            this.labelControl_Status.Name = "labelControl_Status";
            this.labelControl_Status.Size = new System.Drawing.Size(0, 14);
            this.labelControl_Status.TabIndex = 5;
            this.labelControl_Status.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 270);
            this.Controls.Add(this.labelControl_Status);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUser);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.Image")));
            this.Name = "Login";
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.teUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teUser;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl_Status;
    }
}