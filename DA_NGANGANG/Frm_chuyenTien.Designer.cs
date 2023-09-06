namespace DA_NGANGANG
{
    partial class Frm_chuyenTien
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
            System.Windows.Forms.Label sOTK_CHUYENLabel;
            System.Windows.Forms.Label sOTK_NHANLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_chuyenTien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.groupControl_chiNhanh = new DevExpress.XtraEditors.GroupControl();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gD_CHUYENTIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.bds_chuyenTien = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DA_NGANGANG.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_NHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_chuyenTien = new DevExpress.XtraEditors.GroupControl();
            this.txt_maNV = new DevExpress.XtraEditors.TextEdit();
            this.de_ngayGD = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.sp_soTien = new DevExpress.XtraEditors.SpinEdit();
            this.txt_soTKNhan = new DevExpress.XtraEditors.TextEdit();
            this.txt_soTKChuyen = new DevExpress.XtraEditors.TextEdit();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.gD_CHUYENTIENTableAdapter = new DA_NGANGANG.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.tableAdapterManager = new DA_NGANGANG.DSTableAdapters.TableAdapterManager();
            this.txt_ktTKChuyen = new System.Windows.Forms.TextBox();
            this.txt_ktTKNhan = new System.Windows.Forms.TextBox();
            this.btn_check2 = new System.Windows.Forms.Button();
            this.btn_check1 = new System.Windows.Forms.Button();
            sOTK_CHUYENLabel = new System.Windows.Forms.Label();
            sOTK_NHANLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).BeginInit();
            this.groupControl_chiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_chuyenTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chuyenTien)).BeginInit();
            this.groupControl_chuyenTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_soTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soTKNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soTKChuyen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTK_CHUYENLabel
            // 
            sOTK_CHUYENLabel.AutoSize = true;
            sOTK_CHUYENLabel.Location = new System.Drawing.Point(43, 64);
            sOTK_CHUYENLabel.Name = "sOTK_CHUYENLabel";
            sOTK_CHUYENLabel.Size = new System.Drawing.Size(122, 19);
            sOTK_CHUYENLabel.TabIndex = 9;
            sOTK_CHUYENLabel.Text = "SOTK CHUYEN:";
            // 
            // sOTK_NHANLabel
            // 
            sOTK_NHANLabel.AutoSize = true;
            sOTK_NHANLabel.Location = new System.Drawing.Point(43, 138);
            sOTK_NHANLabel.Name = "sOTK_NHANLabel";
            sOTK_NHANLabel.Size = new System.Drawing.Size(104, 19);
            sOTK_NHANLabel.TabIndex = 10;
            sOTK_NHANLabel.Text = "SOTK NHAN:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Location = new System.Drawing.Point(379, 62);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(72, 19);
            sOTIENLabel.TabIndex = 11;
            sOTIENLabel.Text = "SOTIEN:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Location = new System.Drawing.Point(371, 121);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(80, 19);
            nGAYGDLabel.TabIndex = 13;
            nGAYGDLabel.Text = "NGAYGD:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(731, 62);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(59, 19);
            mANVLabel.TabIndex = 14;
            mANVLabel.Text = "MANV:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barToggleSwitchItem1,
            this.btn_them,
            this.btn_reload});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_them
            // 
            this.btn_them.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_them.Caption = "Thêm";
            this.btn_them.Id = 1;
            this.btn_them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_them.ImageOptions.SvgImage")));
            this.btn_them.Name = "btn_them";
            this.btn_them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_them_ItemClick);
            // 
            // btn_reload
            // 
            this.btn_reload.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_reload.Caption = "Reload";
            this.btn_reload.Id = 8;
            this.btn_reload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_reload.ImageOptions.SvgImage")));
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_reload_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1128, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 593);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1128, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 557);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1128, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 557);
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 0;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // groupControl_chiNhanh
            // 
            this.groupControl_chiNhanh.Controls.Add(this.cmb_chiNhanh);
            this.groupControl_chiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_chiNhanh.Location = new System.Drawing.Point(0, 36);
            this.groupControl_chiNhanh.Name = "groupControl_chiNhanh";
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(1128, 87);
            this.groupControl_chiNhanh.TabIndex = 7;
            this.groupControl_chiNhanh.Text = "CHI NHÁNH";
            // 
            // cmb_chiNhanh
            // 
            this.cmb_chiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chiNhanh.FormattingEnabled = true;
            this.cmb_chiNhanh.Location = new System.Drawing.Point(135, 47);
            this.cmb_chiNhanh.Name = "cmb_chiNhanh";
            this.cmb_chiNhanh.Size = new System.Drawing.Size(373, 27);
            this.cmb_chiNhanh.TabIndex = 0;
            this.cmb_chiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_chiNhanh_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gD_CHUYENTIENGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1128, 268);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "BẢNG GIAO DỊCH GỌI RÚT";
            // 
            // gD_CHUYENTIENGridControl
            // 
            this.gD_CHUYENTIENGridControl.DataSource = this.bds_chuyenTien;
            this.gD_CHUYENTIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gD_CHUYENTIENGridControl.Location = new System.Drawing.Point(2, 34);
            this.gD_CHUYENTIENGridControl.MainView = this.gridView1;
            this.gD_CHUYENTIENGridControl.MenuManager = this.barManager1;
            this.gD_CHUYENTIENGridControl.Name = "gD_CHUYENTIENGridControl";
            this.gD_CHUYENTIENGridControl.Size = new System.Drawing.Size(1124, 232);
            this.gD_CHUYENTIENGridControl.TabIndex = 0;
            this.gD_CHUYENTIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bds_chuyenTien
            // 
            this.bds_chuyenTien.DataMember = "GD_CHUYENTIEN";
            this.bds_chuyenTien.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK_CHUYEN,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colSOTK_NHAN,
            this.colMANV});
            this.gridView1.GridControl = this.gD_CHUYENTIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 30;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.OptionsColumn.ReadOnly = true;
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 112;
            // 
            // colSOTK_CHUYEN
            // 
            this.colSOTK_CHUYEN.FieldName = "SOTK_CHUYEN";
            this.colSOTK_CHUYEN.MinWidth = 30;
            this.colSOTK_CHUYEN.Name = "colSOTK_CHUYEN";
            this.colSOTK_CHUYEN.OptionsColumn.ReadOnly = true;
            this.colSOTK_CHUYEN.Visible = true;
            this.colSOTK_CHUYEN.VisibleIndex = 1;
            this.colSOTK_CHUYEN.Width = 112;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 30;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.OptionsColumn.ReadOnly = true;
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 2;
            this.colNGAYGD.Width = 112;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 30;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.OptionsColumn.ReadOnly = true;
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            this.colSOTIEN.Width = 112;
            // 
            // colSOTK_NHAN
            // 
            this.colSOTK_NHAN.FieldName = "SOTK_NHAN";
            this.colSOTK_NHAN.MinWidth = 30;
            this.colSOTK_NHAN.Name = "colSOTK_NHAN";
            this.colSOTK_NHAN.OptionsColumn.ReadOnly = true;
            this.colSOTK_NHAN.Visible = true;
            this.colSOTK_NHAN.VisibleIndex = 4;
            this.colSOTK_NHAN.Width = 112;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 30;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.ReadOnly = true;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            this.colMANV.Width = 112;
            // 
            // groupControl_chuyenTien
            // 
            this.groupControl_chuyenTien.Controls.Add(this.btn_check2);
            this.groupControl_chuyenTien.Controls.Add(this.btn_check1);
            this.groupControl_chuyenTien.Controls.Add(this.txt_ktTKNhan);
            this.groupControl_chuyenTien.Controls.Add(this.txt_ktTKChuyen);
            this.groupControl_chuyenTien.Controls.Add(mANVLabel);
            this.groupControl_chuyenTien.Controls.Add(this.txt_maNV);
            this.groupControl_chuyenTien.Controls.Add(nGAYGDLabel);
            this.groupControl_chuyenTien.Controls.Add(this.de_ngayGD);
            this.groupControl_chuyenTien.Controls.Add(this.label1);
            this.groupControl_chuyenTien.Controls.Add(sOTIENLabel);
            this.groupControl_chuyenTien.Controls.Add(this.sp_soTien);
            this.groupControl_chuyenTien.Controls.Add(sOTK_NHANLabel);
            this.groupControl_chuyenTien.Controls.Add(this.txt_soTKNhan);
            this.groupControl_chuyenTien.Controls.Add(sOTK_CHUYENLabel);
            this.groupControl_chuyenTien.Controls.Add(this.txt_soTKChuyen);
            this.groupControl_chuyenTien.Controls.Add(this.btn_huy);
            this.groupControl_chuyenTien.Controls.Add(this.btn_xacNhan);
            this.groupControl_chuyenTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_chuyenTien.Location = new System.Drawing.Point(0, 391);
            this.groupControl_chuyenTien.Name = "groupControl_chuyenTien";
            this.groupControl_chuyenTien.Size = new System.Drawing.Size(1128, 202);
            this.groupControl_chuyenTien.TabIndex = 9;
            this.groupControl_chuyenTien.Text = "THÔNG TIN GIAO DỊCH";
            // 
            // txt_maNV
            // 
            this.txt_maNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_chuyenTien, "MANV", true));
            this.txt_maNV.Location = new System.Drawing.Point(796, 59);
            this.txt_maNV.MenuManager = this.barManager1;
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(150, 26);
            this.txt_maNV.TabIndex = 15;
            // 
            // de_ngayGD
            // 
            this.de_ngayGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_chuyenTien, "NGAYGD", true));
            this.de_ngayGD.EditValue = null;
            this.de_ngayGD.Location = new System.Drawing.Point(457, 118);
            this.de_ngayGD.MenuManager = this.barManager1;
            this.de_ngayGD.Name = "de_ngayGD";
            this.de_ngayGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayGD.Size = new System.Drawing.Size(150, 26);
            this.de_ngayGD.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "VND";
            // 
            // sp_soTien
            // 
            this.sp_soTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_chuyenTien, "SOTIEN", true));
            this.sp_soTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sp_soTien.Location = new System.Drawing.Point(457, 59);
            this.sp_soTien.MenuManager = this.barManager1;
            this.sp_soTien.Name = "sp_soTien";
            this.sp_soTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sp_soTien.Size = new System.Drawing.Size(150, 28);
            this.sp_soTien.TabIndex = 12;
            // 
            // txt_soTKNhan
            // 
            this.txt_soTKNhan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_chuyenTien, "SOTK_NHAN", true));
            this.txt_soTKNhan.Location = new System.Drawing.Point(171, 131);
            this.txt_soTKNhan.MenuManager = this.barManager1;
            this.txt_soTKNhan.Name = "txt_soTKNhan";
            this.txt_soTKNhan.Size = new System.Drawing.Size(150, 26);
            this.txt_soTKNhan.TabIndex = 11;
            // 
            // txt_soTKChuyen
            // 
            this.txt_soTKChuyen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_chuyenTien, "SOTK_CHUYEN", true));
            this.txt_soTKChuyen.Location = new System.Drawing.Point(171, 61);
            this.txt_soTKChuyen.MenuManager = this.barManager1;
            this.txt_soTKChuyen.Name = "txt_soTKChuyen";
            this.txt_soTKChuyen.Size = new System.Drawing.Size(150, 26);
            this.txt_soTKChuyen.TabIndex = 10;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.Red;
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(945, 138);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(141, 44);
            this.btn_huy.TabIndex = 9;
            this.btn_huy.Text = "Hủy Bỏ";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_xacNhan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacNhan.Location = new System.Drawing.Point(735, 138);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(139, 44);
            this.btn_xacNhan.TabIndex = 8;
            this.btn_xacNhan.Text = "Xác Nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = false;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.gD_CHUYENTIENTableAdapter;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DA_NGANGANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_ktTKChuyen
            // 
            this.txt_ktTKChuyen.Location = new System.Drawing.Point(47, 99);
            this.txt_ktTKChuyen.Name = "txt_ktTKChuyen";
            this.txt_ktTKChuyen.ReadOnly = true;
            this.txt_ktTKChuyen.Size = new System.Drawing.Size(210, 27);
            this.txt_ktTKChuyen.TabIndex = 16;
            // 
            // txt_ktTKNhan
            // 
            this.txt_ktTKNhan.Location = new System.Drawing.Point(47, 170);
            this.txt_ktTKNhan.Name = "txt_ktTKNhan";
            this.txt_ktTKNhan.ReadOnly = true;
            this.txt_ktTKNhan.Size = new System.Drawing.Size(210, 27);
            this.txt_ktTKNhan.TabIndex = 17;
            // 
            // btn_check2
            // 
            this.btn_check2.Location = new System.Drawing.Point(287, 170);
            this.btn_check2.Name = "btn_check2";
            this.btn_check2.Size = new System.Drawing.Size(75, 27);
            this.btn_check2.TabIndex = 19;
            this.btn_check2.Text = "Check";
            this.btn_check2.UseVisualStyleBackColor = true;
            this.btn_check2.Click += new System.EventHandler(this.btn_check2_Click);
            // 
            // btn_check1
            // 
            this.btn_check1.Location = new System.Drawing.Point(287, 93);
            this.btn_check1.Name = "btn_check1";
            this.btn_check1.Size = new System.Drawing.Size(75, 27);
            this.btn_check1.TabIndex = 18;
            this.btn_check1.Text = "Check";
            this.btn_check1.UseVisualStyleBackColor = true;
            this.btn_check1.Click += new System.EventHandler(this.btn_check1_Click);
            // 
            // Frm_chuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 593);
            this.Controls.Add(this.groupControl_chuyenTien);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_chuyenTien";
            this.Text = "Chuyển Tiền";
            this.Load += new System.EventHandler(this.Frm_chuyenTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).EndInit();
            this.groupControl_chiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_chuyenTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chuyenTien)).EndInit();
            this.groupControl_chuyenTien.ResumeLayout(false);
            this.groupControl_chuyenTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_soTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soTKNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soTKChuyen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraEditors.GroupControl groupControl_chiNhanh;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource bds_chuyenTien;
        private DS dS;
        private DevExpress.XtraEditors.GroupControl groupControl_chuyenTien;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_xacNhan;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gD_CHUYENTIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txt_soTKChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_NHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraEditors.TextEdit txt_maNV;
        private DevExpress.XtraEditors.DateEdit de_ngayGD;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit sp_soTien;
        private DevExpress.XtraEditors.TextEdit txt_soTKNhan;
        private System.Windows.Forms.TextBox txt_ktTKNhan;
        private System.Windows.Forms.TextBox txt_ktTKChuyen;
        private System.Windows.Forms.Button btn_check2;
        private System.Windows.Forms.Button btn_check1;
    }
}