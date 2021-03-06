﻿namespace spc_client.ShowForm
{
    partial class ShowDetailNew
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
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl_Results = new DevExpress.XtraGrid.GridControl();
            this.gridView_Results = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.pictureBox_Front = new System.Windows.Forms.PictureBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.imageBox_Part = new Cyotek.Windows.Forms.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Front)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl_Results);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1350, 633);
            this.splitContainerControl2.SplitterPosition = 1078;
            this.splitContainerControl2.TabIndex = 1;
            // 
            // gridControl_Results
            // 
            this.gridControl_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Results.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Results.MainView = this.gridView_Results;
            this.gridControl_Results.Name = "gridControl_Results";
            this.gridControl_Results.Size = new System.Drawing.Size(1078, 633);
            this.gridControl_Results.TabIndex = 0;
            this.gridControl_Results.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Results});
            // 
            // gridView_Results
            // 
            this.gridView_Results.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn8,
            this.gridColumn10});
            this.gridView_Results.GridControl = this.gridControl_Results;
            this.gridView_Results.Name = "gridView_Results";
            this.gridView_Results.OptionsBehavior.ReadOnly = true;
            this.gridView_Results.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "NG类别";
            this.gridColumn5.FieldName = "ng_str";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 140;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "AI得分";
            this.gridColumn6.FieldName = "score_final";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 60;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "人工复判结果";
            this.gridColumn7.FieldName = "ng_str";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            this.gridColumn7.Width = 143;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "结果";
            this.gridColumn9.FieldName = "NG";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "设备编号";
            this.gridColumn1.FieldName = "pc_name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 133;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "检测时间";
            this.gridColumn2.FieldName = "create_time";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 133;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "程序名";
            this.gridColumn3.FieldName = "software_name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 120;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "条码";
            this.gridColumn4.FieldName = "pcb_number";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 120;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "子板数量";
            this.gridColumn8.FieldName = "pcb_childen_number";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 60;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "NG数量";
            this.gridColumn10.FieldName = "ng_count";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 60;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Collapsed = true;
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Horizontal = false;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.imageBox_Part);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(262, 633);
            this.splitContainerControl3.SplitterPosition = 261;
            this.splitContainerControl3.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(262, 261);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.pictureBox_Front);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(260, 231);
            this.xtraTabPage1.Text = "正面";
            // 
            // pictureBox_Front
            // 
            this.pictureBox_Front.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Front.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Front.Name = "pictureBox_Front";
            this.pictureBox_Front.Size = new System.Drawing.Size(260, 231);
            this.pictureBox_Front.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Front.TabIndex = 0;
            this.pictureBox_Front.TabStop = false;
            this.pictureBox_Front.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Front_Paint);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.pictureBox_Back);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(260, 231);
            this.xtraTabPage2.Text = "反面";
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Back.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(260, 231);
            this.pictureBox_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Back.TabIndex = 0;
            this.pictureBox_Back.TabStop = false;
            this.pictureBox_Back.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Back_Paint);
            // 
            // imageBox_Part
            // 
            this.imageBox_Part.AllowZoom = false;
            this.imageBox_Part.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox_Part.Font = new System.Drawing.Font("Tahoma", 20F);
            this.imageBox_Part.Location = new System.Drawing.Point(0, 0);
            this.imageBox_Part.Name = "imageBox_Part";
            this.imageBox_Part.SelectionColor = System.Drawing.Color.Transparent;
            this.imageBox_Part.Size = new System.Drawing.Size(262, 362);
            this.imageBox_Part.TabIndex = 0;
            this.imageBox_Part.Text = "图片缺失";
            this.imageBox_Part.TextBackColor = System.Drawing.Color.Gray;
            this.imageBox_Part.TextDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.None;
            // 
            // ShowDetailNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 633);
            this.Controls.Add(this.splitContainerControl2);
            this.Name = "ShowDetailNew";
            this.Text = "整板结果";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Front)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl_Results;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Results;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private Cyotek.Windows.Forms.ImageBox imageBox_Part;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.PictureBox pictureBox_Front;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}