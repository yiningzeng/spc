namespace spc_client
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.groupControl_Time = new DevExpress.XtraEditors.GroupControl();
            this.dateEdit_End = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit_Start = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnTwoMonth = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnThisMonth = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnThisWeek = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn2Day = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnToday = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn8Hour = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn1Hour = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.groupControl_Code = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_Number = new DevExpress.XtraEditors.TextEdit();
            this.groupControl_AppName = new DevExpress.XtraEditors.GroupControl();
            this.gridLookUpEdit_Software = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl_Result = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.gridLookUpEdit_NgTypeList = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.radioGroup_NgTye = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbStartSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_Time)).BeginInit();
            this.groupControl_Time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_Code)).BeginInit();
            this.groupControl_Code.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_AppName)).BeginInit();
            this.groupControl_AppName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Software.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_Result)).BeginInit();
            this.groupControl_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_NgTypeList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_NgTye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl_Time
            // 
            this.groupControl_Time.Controls.Add(this.dateEdit_End);
            this.groupControl_Time.Controls.Add(this.dateEdit_Start);
            this.groupControl_Time.Controls.Add(this.simpleButton3);
            this.groupControl_Time.Controls.Add(this.simpleButton2);
            this.groupControl_Time.Controls.Add(this.sbtnTwoMonth);
            this.groupControl_Time.Controls.Add(this.sbtnThisMonth);
            this.groupControl_Time.Controls.Add(this.sbtnThisWeek);
            this.groupControl_Time.Controls.Add(this.sbtn2Day);
            this.groupControl_Time.Controls.Add(this.sbtnToday);
            this.groupControl_Time.Controls.Add(this.sbtn8Hour);
            this.groupControl_Time.Controls.Add(this.sbtn1Hour);
            buttonImageOptions1.ImageIndex = 1;
            this.groupControl_Time.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("按时间查询", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, false, null, true, true, true, null, -1)});
            this.groupControl_Time.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_Time.Images = this.imageCollection1;
            this.groupControl_Time.Location = new System.Drawing.Point(0, 0);
            this.groupControl_Time.Name = "groupControl_Time";
            this.groupControl_Time.Size = new System.Drawing.Size(365, 113);
            this.groupControl_Time.TabIndex = 17;
            // 
            // dateEdit_End
            // 
            this.dateEdit_End.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit_End.EditValue = null;
            this.dateEdit_End.Location = new System.Drawing.Point(71, 56);
            this.dateEdit_End.Name = "dateEdit_End";
            this.dateEdit_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_End.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_End.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dateEdit_End.Properties.DisplayFormat.FormatString = "G";
            this.dateEdit_End.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_End.Properties.EditFormat.FormatString = "G";
            this.dateEdit_End.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_End.Properties.Mask.EditMask = "G";
            this.dateEdit_End.Properties.Name = "dateEdit1";
            this.dateEdit_End.Properties.ShowWeekNumbers = true;
            this.dateEdit_End.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_End.Size = new System.Drawing.Size(288, 20);
            this.dateEdit_End.TabIndex = 30;
            // 
            // dateEdit_Start
            // 
            this.dateEdit_Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit_Start.EditValue = null;
            this.dateEdit_Start.Location = new System.Drawing.Point(71, 30);
            this.dateEdit_Start.Name = "dateEdit_Start";
            this.dateEdit_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Start.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit_Start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_Start.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dateEdit_Start.Properties.DisplayFormat.FormatString = "G";
            this.dateEdit_Start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_Start.Properties.EditFormat.FormatString = "G";
            this.dateEdit_Start.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_Start.Properties.Mask.EditMask = "G";
            this.dateEdit_Start.Properties.Name = "dateEdit1";
            this.dateEdit_Start.Properties.ShowWeekNumbers = true;
            this.dateEdit_Start.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_Start.Size = new System.Drawing.Size(288, 20);
            this.dateEdit_Start.TabIndex = 29;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(5, 56);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(60, 20);
            this.simpleButton3.TabIndex = 28;
            this.simpleButton3.Text = "结 束";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(5, 30);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(60, 20);
            this.simpleButton2.TabIndex = 27;
            this.simpleButton2.Text = "开 始";
            // 
            // sbtnTwoMonth
            // 
            this.sbtnTwoMonth.Location = new System.Drawing.Point(323, 82);
            this.sbtnTwoMonth.Name = "sbtnTwoMonth";
            this.sbtnTwoMonth.Size = new System.Drawing.Size(36, 23);
            this.sbtnTwoMonth.TabIndex = 26;
            this.sbtnTwoMonth.Text = "近2月";
            this.sbtnTwoMonth.Click += new System.EventHandler(this.sbtnTwoMonth_Click);
            // 
            // sbtnThisMonth
            // 
            this.sbtnThisMonth.Location = new System.Drawing.Point(281, 82);
            this.sbtnThisMonth.Name = "sbtnThisMonth";
            this.sbtnThisMonth.Size = new System.Drawing.Size(36, 23);
            this.sbtnThisMonth.TabIndex = 25;
            this.sbtnThisMonth.Text = "本月";
            this.sbtnThisMonth.Click += new System.EventHandler(this.sbtnThisMonth_Click);
            // 
            // sbtnThisWeek
            // 
            this.sbtnThisWeek.Location = new System.Drawing.Point(239, 82);
            this.sbtnThisWeek.Name = "sbtnThisWeek";
            this.sbtnThisWeek.Size = new System.Drawing.Size(36, 23);
            this.sbtnThisWeek.TabIndex = 24;
            this.sbtnThisWeek.Text = "本周";
            this.sbtnThisWeek.Click += new System.EventHandler(this.sbtnThisWeek_Click);
            // 
            // sbtn2Day
            // 
            this.sbtn2Day.Location = new System.Drawing.Point(197, 82);
            this.sbtn2Day.Name = "sbtn2Day";
            this.sbtn2Day.Size = new System.Drawing.Size(36, 23);
            this.sbtn2Day.TabIndex = 23;
            this.sbtn2Day.Text = "近2天";
            this.sbtn2Day.Click += new System.EventHandler(this.sbtn2Day_Click);
            // 
            // sbtnToday
            // 
            this.sbtnToday.Location = new System.Drawing.Point(155, 82);
            this.sbtnToday.Name = "sbtnToday";
            this.sbtnToday.Size = new System.Drawing.Size(36, 23);
            this.sbtnToday.TabIndex = 22;
            this.sbtnToday.Text = "当日";
            this.sbtnToday.Click += new System.EventHandler(this.sbtnToday_Click);
            // 
            // sbtn8Hour
            // 
            this.sbtn8Hour.Location = new System.Drawing.Point(113, 82);
            this.sbtn8Hour.Name = "sbtn8Hour";
            this.sbtn8Hour.Size = new System.Drawing.Size(36, 23);
            this.sbtn8Hour.TabIndex = 21;
            this.sbtn8Hour.Text = "8小时";
            this.sbtn8Hour.Click += new System.EventHandler(this.sbtn8Hour_Click);
            // 
            // sbtn1Hour
            // 
            this.sbtn1Hour.Location = new System.Drawing.Point(71, 82);
            this.sbtn1Hour.Name = "sbtn1Hour";
            this.sbtn1Hour.Size = new System.Drawing.Size(36, 23);
            this.sbtn1Hour.TabIndex = 20;
            this.sbtn1Hour.Text = "1小时";
            this.sbtn1Hour.Click += new System.EventHandler(this.sbtn1Hour_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "remove_16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "iconsetsymbolscircled3_16x16.png");
            // 
            // groupControl_Code
            // 
            this.groupControl_Code.Controls.Add(this.simpleButton4);
            this.groupControl_Code.Controls.Add(this.textEdit_Number);
            this.groupControl_Code.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("按条码查询", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.groupControl_Code.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_Code.Location = new System.Drawing.Point(0, 113);
            this.groupControl_Code.Name = "groupControl_Code";
            this.groupControl_Code.Size = new System.Drawing.Size(365, 57);
            this.groupControl_Code.TabIndex = 18;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(5, 31);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(60, 20);
            this.simpleButton4.TabIndex = 29;
            this.simpleButton4.Text = "条 码";
            // 
            // textEdit_Number
            // 
            this.textEdit_Number.Location = new System.Drawing.Point(71, 31);
            this.textEdit_Number.Name = "textEdit_Number";
            this.textEdit_Number.Size = new System.Drawing.Size(288, 20);
            this.textEdit_Number.TabIndex = 16;
            // 
            // groupControl_AppName
            // 
            this.groupControl_AppName.Controls.Add(this.gridLookUpEdit_Software);
            this.groupControl_AppName.Controls.Add(this.simpleButton1);
            this.groupControl_AppName.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("按程序查询", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.groupControl_AppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_AppName.Location = new System.Drawing.Point(0, 170);
            this.groupControl_AppName.Name = "groupControl_AppName";
            this.groupControl_AppName.Size = new System.Drawing.Size(365, 58);
            this.groupControl_AppName.TabIndex = 19;
            // 
            // gridLookUpEdit_Software
            // 
            this.gridLookUpEdit_Software.EditValue = "";
            this.gridLookUpEdit_Software.Location = new System.Drawing.Point(71, 31);
            this.gridLookUpEdit_Software.Name = "gridLookUpEdit_Software";
            this.gridLookUpEdit_Software.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_Software.Properties.NullText = "";
            this.gridLookUpEdit_Software.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit_Software.Size = new System.Drawing.Size(288, 20);
            this.gridLookUpEdit_Software.TabIndex = 22;
            this.gridLookUpEdit_Software.EditValueChanged += new System.EventHandler(this.gridLookUpEdit_Software_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "编号";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 65;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "程序名";
            this.gridColumn2.FieldName = "software_name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 310;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 30);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(60, 20);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "程序名";
            // 
            // groupControl_Result
            // 
            this.groupControl_Result.Controls.Add(this.simpleButton5);
            this.groupControl_Result.Controls.Add(this.gridLookUpEdit_NgTypeList);
            this.groupControl_Result.Controls.Add(this.radioGroup_NgTye);
            this.groupControl_Result.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("按检查结果查询", true, buttonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.groupControl_Result.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_Result.Enabled = false;
            this.groupControl_Result.Location = new System.Drawing.Point(0, 228);
            this.groupControl_Result.Name = "groupControl_Result";
            this.groupControl_Result.Size = new System.Drawing.Size(365, 60);
            this.groupControl_Result.TabIndex = 30;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(5, 32);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton5.Size = new System.Drawing.Size(60, 20);
            this.simpleButton5.TabIndex = 25;
            this.simpleButton5.Text = "缺 陷";
            // 
            // gridLookUpEdit_NgTypeList
            // 
            this.gridLookUpEdit_NgTypeList.Enabled = false;
            this.gridLookUpEdit_NgTypeList.Location = new System.Drawing.Point(237, 32);
            this.gridLookUpEdit_NgTypeList.Name = "gridLookUpEdit_NgTypeList";
            this.gridLookUpEdit_NgTypeList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit_NgTypeList.Properties.NullText = "";
            this.gridLookUpEdit_NgTypeList.Properties.PopupView = this.gridView2;
            this.gridLookUpEdit_NgTypeList.Size = new System.Drawing.Size(122, 20);
            this.gridLookUpEdit_NgTypeList.TabIndex = 24;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "编号";
            this.gridColumn3.FieldName = "id";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 65;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "名称";
            this.gridColumn4.FieldName = "ng_str";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 310;
            // 
            // radioGroup_NgTye
            // 
            this.radioGroup_NgTye.Location = new System.Drawing.Point(71, 30);
            this.radioGroup_NgTye.Name = "radioGroup_NgTye";
            this.radioGroup_NgTye.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "所有缺陷"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "具体缺陷")});
            this.radioGroup_NgTye.Size = new System.Drawing.Size(162, 24);
            this.radioGroup_NgTye.TabIndex = 23;
            this.radioGroup_NgTye.SelectedIndexChanged += new System.EventHandler(this.radioGroup_NgTye_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbStartSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 407);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(365, 34);
            this.panelControl1.TabIndex = 31;
            // 
            // sbStartSearch
            // 
            this.sbStartSearch.Location = new System.Drawing.Point(5, 5);
            this.sbStartSearch.Name = "sbStartSearch";
            this.sbStartSearch.Size = new System.Drawing.Size(354, 23);
            this.sbStartSearch.TabIndex = 0;
            this.sbStartSearch.Text = "点击搜索";
            this.sbStartSearch.Click += new System.EventHandler(this.sbStartSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 441);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl_Result);
            this.Controls.Add(this.groupControl_AppName);
            this.Controls.Add(this.groupControl_Code);
            this.Controls.Add(this.groupControl_Time);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 471);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(365, 471);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "搜索";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_Time)).EndInit();
            this.groupControl_Time.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_Code)).EndInit();
            this.groupControl_Code.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_AppName)).EndInit();
            this.groupControl_AppName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_Software.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_Result)).EndInit();
            this.groupControl_Result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit_NgTypeList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_NgTye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_Time;
        private DevExpress.XtraEditors.SimpleButton sbtnTwoMonth;
        private DevExpress.XtraEditors.SimpleButton sbtnThisMonth;
        private DevExpress.XtraEditors.SimpleButton sbtnThisWeek;
        private DevExpress.XtraEditors.SimpleButton sbtn2Day;
        private DevExpress.XtraEditors.SimpleButton sbtnToday;
        private DevExpress.XtraEditors.SimpleButton sbtn8Hour;
        private DevExpress.XtraEditors.SimpleButton sbtn1Hour;
        private DevExpress.XtraEditors.GroupControl groupControl_Code;
        private DevExpress.XtraEditors.TextEdit textEdit_Number;
        private DevExpress.XtraEditors.GroupControl groupControl_AppName;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_Software;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GroupControl groupControl_Result;
        private DevExpress.XtraEditors.RadioGroup radioGroup_NgTye;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit_NgTypeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbStartSearch;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.DateEdit dateEdit_Start;
        private DevExpress.XtraEditors.DateEdit dateEdit_End;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}