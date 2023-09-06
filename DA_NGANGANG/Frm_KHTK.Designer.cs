namespace DA_NGANGANG
{
    partial class Frm_KHTK
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
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KHTK));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_huy = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl_khachHang = new DevExpress.XtraEditors.GroupControl();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.bds_khachHang = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DA_NGANGANG.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl_chiNhanh = new DevExpress.XtraEditors.GroupControl();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl_taiKhoan = new DevExpress.XtraEditors.GroupControl();
            this.btn_traCuu = new System.Windows.Forms.Button();
            this.de_ngayMoTK = new DevExpress.XtraEditors.DateEdit();
            this.bds_taiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.txt_maCN = new DevExpress.XtraEditors.TextEdit();
            this.sp_soDu = new DevExpress.XtraEditors.SpinEdit();
            this.txt_CMND = new DevExpress.XtraEditors.TextEdit();
            this.txt_soTK = new DevExpress.XtraEditors.TextEdit();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.taiKhoanGridControl = new System.Windows.Forms.DataGridView();
            this.sOTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sODUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYMOTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangTableAdapter = new DA_NGANGANG.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new DA_NGANGANG.DSTableAdapters.TableAdapterManager();
            this.taiKhoanTableAdapter = new DA_NGANGANG.DSTableAdapters.TaiKhoanTableAdapter();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_khachHang)).BeginInit();
            this.groupControl_khachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_khachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).BeginInit();
            this.groupControl_chiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_taiKhoan)).BeginInit();
            this.groupControl_taiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayMoTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayMoTK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_taiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_soDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(17, 58);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(55, 19);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "SOTK:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(244, 54);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(59, 19);
            cMNDLabel.TabIndex = 2;
            cMNDLabel.Text = "CMND:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(17, 103);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(58, 19);
            sODULabel.TabIndex = 4;
            sODULabel.Text = "SODU:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(244, 104);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(59, 19);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "MACN:";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Location = new System.Drawing.Point(98, 163);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(101, 19);
            nGAYMOTKLabel.TabIndex = 8;
            nGAYMOTKLabel.Text = "NGAYMOTK:";
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
            this.btn_sua,
            this.btn_xoa,
            this.btn_phucHoi,
            this.btn_ghi,
            this.btn_huy,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_ghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_huy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btn_phucHoi
            // 
            this.btn_phucHoi.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_phucHoi.Caption = "Phục Hồi";
            this.btn_phucHoi.Id = 4;
            this.btn_phucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_phucHoi.ImageOptions.SvgImage")));
            this.btn_phucHoi.Name = "btn_phucHoi";
            this.btn_phucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_phucHoi_ItemClick);
            // 
            // btn_ghi
            // 
            this.btn_ghi.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_ghi.Caption = "Ghi";
            this.btn_ghi.Id = 5;
            this.btn_ghi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ghi.ImageOptions.SvgImage")));
            this.btn_ghi.Name = "btn_ghi";
            this.btn_ghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ghi_ItemClick);
            // 
            // btn_huy
            // 
            this.btn_huy.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_huy.Caption = "Hủy";
            this.btn_huy.Id = 6;
            this.btn_huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_huy.ImageOptions.SvgImage")));
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_huy_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1201, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 651);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1201, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 615);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1201, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 615);
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 0;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // btn_sua
            // 
            this.btn_sua.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_sua.Caption = "Sửa";
            this.btn_sua.Id = 2;
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.LargeImage")));
            this.btn_sua.Name = "btn_sua";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_xoa.Caption = "Xóa";
            this.btn_xoa.Id = 3;
            this.btn_xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_xoa.ImageOptions.SvgImage")));
            this.btn_xoa.Name = "btn_xoa";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl_khachHang);
            this.groupControl1.Controls.Add(this.groupControl_chiNhanh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 36);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(536, 615);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Khách Hàng";
            // 
            // groupControl_khachHang
            // 
            this.groupControl_khachHang.Controls.Add(this.khachHangGridControl);
            this.groupControl_khachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_khachHang.Location = new System.Drawing.Point(2, 121);
            this.groupControl_khachHang.Name = "groupControl_khachHang";
            this.groupControl_khachHang.Size = new System.Drawing.Size(532, 492);
            this.groupControl_khachHang.TabIndex = 8;
            this.groupControl_khachHang.Text = "Bảng Khách Hàng";
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.bds_khachHang;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachHangGridControl.Location = new System.Drawing.Point(2, 34);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.MenuManager = this.barManager1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(528, 456);
            this.khachHangGridControl.TabIndex = 0;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3});
            this.khachHangGridControl.Click += new System.EventHandler(this.khachHangGridControl_Click);
            // 
            // bds_khachHang
            // 
            this.bds_khachHang.DataMember = "KhachHang";
            this.bds_khachHang.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 30;
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.ReadOnly = true;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 112;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.ReadOnly = true;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.ReadOnly = true;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.ReadOnly = true;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 112;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 30;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.ReadOnly = true;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 112;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 30;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.OptionsColumn.ReadOnly = true;
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 112;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 30;
            this.colSODT.Name = "colSODT";
            this.colSODT.OptionsColumn.ReadOnly = true;
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 112;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 30;
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.ReadOnly = true;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 112;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.khachHangGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // groupControl_chiNhanh
            // 
            this.groupControl_chiNhanh.Controls.Add(this.cmb_chiNhanh);
            this.groupControl_chiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_chiNhanh.Location = new System.Drawing.Point(2, 34);
            this.groupControl_chiNhanh.Name = "groupControl_chiNhanh";
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(532, 87);
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
            this.groupControl2.Controls.Add(this.groupControl_taiKhoan);
            this.groupControl2.Controls.Add(this.groupControl5);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(536, 36);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(665, 615);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Tài Khoản";
            // 
            // groupControl_taiKhoan
            // 
            this.groupControl_taiKhoan.Controls.Add(this.btn_traCuu);
            this.groupControl_taiKhoan.Controls.Add(nGAYMOTKLabel);
            this.groupControl_taiKhoan.Controls.Add(this.de_ngayMoTK);
            this.groupControl_taiKhoan.Controls.Add(mACNLabel);
            this.groupControl_taiKhoan.Controls.Add(this.txt_maCN);
            this.groupControl_taiKhoan.Controls.Add(sODULabel);
            this.groupControl_taiKhoan.Controls.Add(this.sp_soDu);
            this.groupControl_taiKhoan.Controls.Add(cMNDLabel);
            this.groupControl_taiKhoan.Controls.Add(this.txt_CMND);
            this.groupControl_taiKhoan.Controls.Add(sOTKLabel);
            this.groupControl_taiKhoan.Controls.Add(this.txt_soTK);
            this.groupControl_taiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_taiKhoan.Location = new System.Drawing.Point(2, 400);
            this.groupControl_taiKhoan.Name = "groupControl_taiKhoan";
            this.groupControl_taiKhoan.Size = new System.Drawing.Size(661, 213);
            this.groupControl_taiKhoan.TabIndex = 2;
            this.groupControl_taiKhoan.Text = "Thông Tin Tài Khoản";
            // 
            // btn_traCuu
            // 
            this.btn_traCuu.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_traCuu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traCuu.Location = new System.Drawing.Point(477, 150);
            this.btn_traCuu.Name = "btn_traCuu";
            this.btn_traCuu.Size = new System.Drawing.Size(139, 44);
            this.btn_traCuu.TabIndex = 11;
            this.btn_traCuu.Text = "Tra Cứu";
            this.btn_traCuu.UseVisualStyleBackColor = false;
            this.btn_traCuu.Click += new System.EventHandler(this.btn_traCuu_Click);
            // 
            // de_ngayMoTK
            // 
            this.de_ngayMoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_taiKhoan, "NGAYMOTK", true));
            this.de_ngayMoTK.EditValue = null;
            this.de_ngayMoTK.Location = new System.Drawing.Point(205, 160);
            this.de_ngayMoTK.MenuManager = this.barManager1;
            this.de_ngayMoTK.Name = "de_ngayMoTK";
            this.de_ngayMoTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayMoTK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayMoTK.Size = new System.Drawing.Size(150, 26);
            this.de_ngayMoTK.TabIndex = 9;
            // 
            // bds_taiKhoan
            // 
            this.bds_taiKhoan.DataMember = "FK_TaiKhoan_KhachHang";
            this.bds_taiKhoan.DataSource = this.bds_khachHang;
            // 
            // txt_maCN
            // 
            this.txt_maCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_taiKhoan, "MACN", true));
            this.txt_maCN.Location = new System.Drawing.Point(319, 101);
            this.txt_maCN.MenuManager = this.barManager1;
            this.txt_maCN.Name = "txt_maCN";
            this.txt_maCN.Size = new System.Drawing.Size(150, 26);
            this.txt_maCN.TabIndex = 7;
            // 
            // sp_soDu
            // 
            this.sp_soDu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_taiKhoan, "SODU", true));
            this.sp_soDu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sp_soDu.Location = new System.Drawing.Point(78, 99);
            this.sp_soDu.MenuManager = this.barManager1;
            this.sp_soDu.Name = "sp_soDu";
            this.sp_soDu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sp_soDu.Size = new System.Drawing.Size(150, 28);
            this.sp_soDu.TabIndex = 5;
            // 
            // txt_CMND
            // 
            this.txt_CMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_taiKhoan, "CMND", true));
            this.txt_CMND.Location = new System.Drawing.Point(319, 51);
            this.txt_CMND.MenuManager = this.barManager1;
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(150, 26);
            this.txt_CMND.TabIndex = 3;
            // 
            // txt_soTK
            // 
            this.txt_soTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_taiKhoan, "SOTK", true));
            this.txt_soTK.Location = new System.Drawing.Point(78, 55);
            this.txt_soTK.MenuManager = this.barManager1;
            this.txt_soTK.Name = "txt_soTK";
            this.txt_soTK.Size = new System.Drawing.Size(150, 26);
            this.txt_soTK.TabIndex = 1;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.taiKhoanGridControl);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl5.Location = new System.Drawing.Point(2, 34);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(661, 366);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "Bảng Tài Khoản";
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.AutoGenerateColumns = false;
            this.taiKhoanGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taiKhoanGridControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sOTKDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.sODUDataGridViewTextBoxColumn,
            this.mACNDataGridViewTextBoxColumn,
            this.nGAYMOTKDataGridViewTextBoxColumn});
            this.taiKhoanGridControl.DataSource = this.bds_taiKhoan;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanGridControl.Location = new System.Drawing.Point(2, 34);
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.ReadOnly = true;
            this.taiKhoanGridControl.RowHeadersWidth = 62;
            this.taiKhoanGridControl.RowTemplate.Height = 28;
            this.taiKhoanGridControl.Size = new System.Drawing.Size(657, 330);
            this.taiKhoanGridControl.TabIndex = 0;
            // 
            // sOTKDataGridViewTextBoxColumn
            // 
            this.sOTKDataGridViewTextBoxColumn.DataPropertyName = "SOTK";
            this.sOTKDataGridViewTextBoxColumn.HeaderText = "SOTK";
            this.sOTKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sOTKDataGridViewTextBoxColumn.Name = "sOTKDataGridViewTextBoxColumn";
            this.sOTKDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOTKDataGridViewTextBoxColumn.Width = 150;
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cMNDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            this.cMNDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMNDDataGridViewTextBoxColumn.Width = 150;
            // 
            // sODUDataGridViewTextBoxColumn
            // 
            this.sODUDataGridViewTextBoxColumn.DataPropertyName = "SODU";
            this.sODUDataGridViewTextBoxColumn.HeaderText = "SODU";
            this.sODUDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sODUDataGridViewTextBoxColumn.Name = "sODUDataGridViewTextBoxColumn";
            this.sODUDataGridViewTextBoxColumn.ReadOnly = true;
            this.sODUDataGridViewTextBoxColumn.Width = 150;
            // 
            // mACNDataGridViewTextBoxColumn
            // 
            this.mACNDataGridViewTextBoxColumn.DataPropertyName = "MACN";
            this.mACNDataGridViewTextBoxColumn.HeaderText = "MACN";
            this.mACNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mACNDataGridViewTextBoxColumn.Name = "mACNDataGridViewTextBoxColumn";
            this.mACNDataGridViewTextBoxColumn.ReadOnly = true;
            this.mACNDataGridViewTextBoxColumn.Width = 150;
            // 
            // nGAYMOTKDataGridViewTextBoxColumn
            // 
            this.nGAYMOTKDataGridViewTextBoxColumn.DataPropertyName = "NGAYMOTK";
            this.nGAYMOTKDataGridViewTextBoxColumn.HeaderText = "NGAYMOTK";
            this.nGAYMOTKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nGAYMOTKDataGridViewTextBoxColumn.Name = "nGAYMOTKDataGridViewTextBoxColumn";
            this.nGAYMOTKDataGridViewTextBoxColumn.ReadOnly = true;
            this.nGAYMOTKDataGridViewTextBoxColumn.Width = 150;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DA_NGANGANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_KHTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 651);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_KHTK";
            this.Text = "Frm_KHTK";
            this.Load += new System.EventHandler(this.Frm_KHTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_khachHang)).EndInit();
            this.groupControl_khachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_khachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).EndInit();
            this.groupControl_chiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_taiKhoan)).EndInit();
            this.groupControl_taiKhoan.ResumeLayout(false);
            this.groupControl_taiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayMoTK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayMoTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_taiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_soDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_phucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_ghi;
        private DevExpress.XtraBars.BarButtonItem btn_huy;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl_chiNhanh;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl_khachHang;
        private System.Windows.Forms.BindingSource bds_khachHang;
        private DS dS;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.BindingSource bds_taiKhoan;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.DataGridView taiKhoanGridControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sODUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYMOTKDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.GroupControl groupControl_taiKhoan;
        private DevExpress.XtraEditors.DateEdit de_ngayMoTK;
        private DevExpress.XtraEditors.TextEdit txt_maCN;
        private DevExpress.XtraEditors.SpinEdit sp_soDu;
        private DevExpress.XtraEditors.TextEdit txt_CMND;
        private DevExpress.XtraEditors.TextEdit txt_soTK;
        private System.Windows.Forms.Button btn_traCuu;
    }
}