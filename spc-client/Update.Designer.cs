namespace spc_client
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAll = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbErr = new System.Windows.Forms.Label();
            this.lbErrNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Caption = "正在更新相关数据";
            this.progressPanel1.Description = "";
            this.progressPanel1.Location = new System.Drawing.Point(12, 12);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(216, 91);
            this.progressPanel1.TabIndex = 0;
            this.progressPanel1.Text = "progressPanel1asdsadsad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "执行";
            // 
            // lbNow
            // 
            this.lbNow.AutoSize = true;
            this.lbNow.Location = new System.Drawing.Point(88, 62);
            this.lbNow.Name = "lbNow";
            this.lbNow.Size = new System.Drawing.Size(14, 14);
            this.lbNow.TabIndex = 2;
            this.lbNow.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "/";
            // 
            // lbAll
            // 
            this.lbAll.AutoSize = true;
            this.lbAll.Location = new System.Drawing.Point(129, 62);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(14, 14);
            this.lbAll.TabIndex = 4;
            this.lbAll.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "更新...";
            // 
            // lbErr
            // 
            this.lbErr.AutoSize = true;
            this.lbErr.ForeColor = System.Drawing.Color.IndianRed;
            this.lbErr.Location = new System.Drawing.Point(88, 80);
            this.lbErr.Name = "lbErr";
            this.lbErr.Size = new System.Drawing.Size(91, 14);
            this.lbErr.TabIndex = 6;
            this.lbErr.Text = "个更新执行失败";
            this.lbErr.Visible = false;
            // 
            // lbErrNum
            // 
            this.lbErrNum.AutoSize = true;
            this.lbErrNum.ForeColor = System.Drawing.Color.IndianRed;
            this.lbErrNum.Location = new System.Drawing.Point(57, 80);
            this.lbErrNum.Name = "lbErrNum";
            this.lbErrNum.Size = new System.Drawing.Size(14, 14);
            this.lbErrNum.TabIndex = 7;
            this.lbErrNum.Text = "0";
            this.lbErrNum.Visible = false;
            // 
            // Update
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 115);
            this.Controls.Add(this.lbErrNum);
            this.Controls.Add(this.lbErr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressPanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Update.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据更新";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbErr;
        private System.Windows.Forms.Label lbErrNum;
    }
}