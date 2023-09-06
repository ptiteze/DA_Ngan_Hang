namespace DA_NGANGANG
{
    partial class Frm_nhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label lb_hoTen;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label pHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_nhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_huy = new DevExpress.XtraBars.BarButtonItem();
            this.btn_chuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.groupControl_chiNhanh = new DevExpress.XtraEditors.GroupControl();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.bds_nhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DA_NGANGANG.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_nhanVien = new DevExpress.XtraEditors.GroupControl();
            this.cmb_phai = new System.Windows.Forms.ComboBox();
            this.cb_trangThaiXoa = new System.Windows.Forms.CheckBox();
            this.lb_maCN = new System.Windows.Forms.Label();
            this.txt_soDT = new DevExpress.XtraEditors.TextEdit();
            this.txt_diaChi = new DevExpress.XtraEditors.TextEdit();
            this.txt_CMND = new DevExpress.XtraEditors.TextEdit();
            this.txt_ten = new DevExpress.XtraEditors.TextEdit();
            this.txt_ho = new DevExpress.XtraEditors.TextEdit();
            this.txt_maNV = new DevExpress.XtraEditors.TextEdit();
            this.nhanVienTableAdapter = new DA_NGANGANG.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new DA_NGANGANG.DSTableAdapters.TableAdapterManager();
            mANVLabel = new System.Windows.Forms.Label();
            lb_hoTen = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).BeginInit();
            this.groupControl_chiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_nhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_nhanVien)).BeginInit();
            this.groupControl_nhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(38, 52);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(59, 19);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MANV:";
            // 
            // lb_hoTen
            // 
            lb_hoTen.AutoSize = true;
            lb_hoTen.Location = new System.Drawing.Point(239, 52);
            lb_hoTen.Name = "lb_hoTen";
            lb_hoTen.Size = new System.Drawing.Size(67, 19);
            lb_hoTen.TabIndex = 2;
            lb_hoTen.Text = "Họ Tên:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(747, 52);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(59, 19);
            cMNDLabel.TabIndex = 6;
            cMNDLabel.Text = "CMND:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(27, 103);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(70, 19);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(478, 103);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(57, 19);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "SODT:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(38, 149);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(59, 19);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "MACN:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(478, 149);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(124, 19);
            trangThaiXoaLabel.TabIndex = 16;
            trangThaiXoaLabel.Text = "Trang Thai Xoa:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(754, 107);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(52, 19);
            pHAILabel.TabIndex = 17;
            pHAILabel.Text = "PHAI:";
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
            this.btn_chuyenChiNhanh,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_sua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_phucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_ghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_huy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_chuyenChiNhanh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btn_sua
            // 
            this.btn_sua.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_sua.Caption = "Sửa";
            this.btn_sua.Id = 2;
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.LargeImage")));
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sua_ItemClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_xoa.Caption = "Xóa";
            this.btn_xoa.Id = 3;
            this.btn_xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_xoa.ImageOptions.SvgImage")));
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_xoa_ItemClick);
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
            // btn_chuyenChiNhanh
            // 
            this.btn_chuyenChiNhanh.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_chuyenChiNhanh.Caption = "Chuyển Chi Nhánh";
            this.btn_chuyenChiNhanh.Id = 7;
            this.btn_chuyenChiNhanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_chuyenChiNhanh.ImageOptions.SvgImage")));
            this.btn_chuyenChiNhanh.Name = "btn_chuyenChiNhanh";
            this.btn_chuyenChiNhanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_chuyenChiNhanh_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1058, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 628);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1058, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 592);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1058, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 592);
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
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(1058, 87);
            this.groupControl_chiNhanh.TabIndex = 4;
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
            this.groupControl2.Controls.Add(this.nhanVienGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1058, 273);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "BẢNG NHÂN VIÊN";
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.bds_nhanVien;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienGridControl.Location = new System.Drawing.Point(2, 34);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1054, 239);
            this.nhanVienGridControl.TabIndex = 0;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bds_nhanVien
            // 
            this.bds_nhanVien.DataMember = "NhanVien";
            this.bds_nhanVien.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colCMND,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 30;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 112;
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
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 30;
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.ReadOnly = true;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 3;
            this.colCMND.Width = 112;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.ReadOnly = true;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 112;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 30;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.ReadOnly = true;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 5;
            this.colPHAI.Width = 112;
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
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 30;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.OptionsColumn.ReadOnly = true;
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 8;
            this.colTrangThaiXoa.Width = 112;
            // 
            // groupControl_nhanVien
            // 
            this.groupControl_nhanVien.Controls.Add(pHAILabel);
            this.groupControl_nhanVien.Controls.Add(this.cmb_phai);
            this.groupControl_nhanVien.Controls.Add(trangThaiXoaLabel);
            this.groupControl_nhanVien.Controls.Add(this.cb_trangThaiXoa);
            this.groupControl_nhanVien.Controls.Add(mACNLabel);
            this.groupControl_nhanVien.Controls.Add(this.lb_maCN);
            this.groupControl_nhanVien.Controls.Add(sODTLabel);
            this.groupControl_nhanVien.Controls.Add(this.txt_soDT);
            this.groupControl_nhanVien.Controls.Add(dIACHILabel);
            this.groupControl_nhanVien.Controls.Add(this.txt_diaChi);
            this.groupControl_nhanVien.Controls.Add(cMNDLabel);
            this.groupControl_nhanVien.Controls.Add(this.txt_CMND);
            this.groupControl_nhanVien.Controls.Add(this.txt_ten);
            this.groupControl_nhanVien.Controls.Add(lb_hoTen);
            this.groupControl_nhanVien.Controls.Add(this.txt_ho);
            this.groupControl_nhanVien.Controls.Add(mANVLabel);
            this.groupControl_nhanVien.Controls.Add(this.txt_maNV);
            this.groupControl_nhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_nhanVien.Location = new System.Drawing.Point(0, 396);
            this.groupControl_nhanVien.Name = "groupControl_nhanVien";
            this.groupControl_nhanVien.Size = new System.Drawing.Size(1058, 232);
            this.groupControl_nhanVien.TabIndex = 6;
            this.groupControl_nhanVien.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // cmb_phai
            // 
            this.cmb_phai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_nhanVien, "PHAI", true));
            this.cmb_phai.FormattingEnabled = true;
            this.cmb_phai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmb_phai.Location = new System.Drawing.Point(812, 104);
            this.cmb_phai.Name = "cmb_phai";
            this.cmb_phai.Size = new System.Drawing.Size(121, 27);
            this.cmb_phai.TabIndex = 18;
            // 
            // cb_trangThaiXoa
            // 
            this.cb_trangThaiXoa.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bds_nhanVien, "TrangThaiXoa", true));
            this.cb_trangThaiXoa.Enabled = false;
            this.cb_trangThaiXoa.Location = new System.Drawing.Point(608, 149);
            this.cb_trangThaiXoa.Name = "cb_trangThaiXoa";
            this.cb_trangThaiXoa.Size = new System.Drawing.Size(104, 24);
            this.cb_trangThaiXoa.TabIndex = 17;
            this.cb_trangThaiXoa.Text = "Xóa";
            this.cb_trangThaiXoa.UseVisualStyleBackColor = true;
            // 
            // lb_maCN
            // 
            this.lb_maCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_nhanVien, "MACN", true));
            this.lb_maCN.Location = new System.Drawing.Point(103, 149);
            this.lb_maCN.Name = "lb_maCN";
            this.lb_maCN.Size = new System.Drawing.Size(100, 23);
            this.lb_maCN.TabIndex = 15;
            // 
            // txt_soDT
            // 
            this.txt_soDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "SODT", true));
            this.txt_soDT.Location = new System.Drawing.Point(541, 100);
            this.txt_soDT.MenuManager = this.barManager1;
            this.txt_soDT.Name = "txt_soDT";
            this.txt_soDT.Size = new System.Drawing.Size(150, 26);
            this.txt_soDT.TabIndex = 13;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "DIACHI", true));
            this.txt_diaChi.Location = new System.Drawing.Point(103, 100);
            this.txt_diaChi.MenuManager = this.barManager1;
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Properties.MaxLength = 100;
            this.txt_diaChi.Size = new System.Drawing.Size(354, 26);
            this.txt_diaChi.TabIndex = 9;
            // 
            // txt_CMND
            // 
            this.txt_CMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "CMND", true));
            this.txt_CMND.Location = new System.Drawing.Point(812, 49);
            this.txt_CMND.MenuManager = this.barManager1;
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(150, 26);
            this.txt_CMND.TabIndex = 7;
            // 
            // txt_ten
            // 
            this.txt_ten.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "TEN", true));
            this.txt_ten.Location = new System.Drawing.Point(541, 49);
            this.txt_ten.MenuManager = this.barManager1;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(150, 26);
            this.txt_ten.TabIndex = 5;
            // 
            // txt_ho
            // 
            this.txt_ho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "HO", true));
            this.txt_ho.Location = new System.Drawing.Point(312, 49);
            this.txt_ho.MenuManager = this.barManager1;
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.Size = new System.Drawing.Size(223, 26);
            this.txt_ho.TabIndex = 3;
            // 
            // txt_maNV
            // 
            this.txt_maNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanVien, "MANV", true));
            this.txt_maNV.Location = new System.Drawing.Point(103, 49);
            this.txt_maNV.MenuManager = this.barManager1;
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(100, 26);
            this.txt_maNV.TabIndex = 1;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DA_NGANGANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Frm_nhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 628);
            this.Controls.Add(this.groupControl_nhanVien);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_nhanVien";
            this.Text = "Quản Lí Nhân Viên";
            this.Load += new System.EventHandler(this.Frm_nhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).EndInit();
            this.groupControl_chiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_nhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_nhanVien)).EndInit();
            this.groupControl_nhanVien.ResumeLayout(false);
            this.groupControl_nhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_phucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_ghi;
        private DevExpress.XtraBars.BarButtonItem btn_huy;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarButtonItem btn_chuyenChiNhanh;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private DevExpress.XtraEditors.GroupControl groupControl_nhanVien;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl_chiNhanh;
        private System.Windows.Forms.BindingSource bds_nhanVien;
        private DS dS;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraEditors.TextEdit txt_soDT;
        private DevExpress.XtraEditors.TextEdit txt_diaChi;
        private DevExpress.XtraEditors.TextEdit txt_CMND;
        private DevExpress.XtraEditors.TextEdit txt_ten;
        private DevExpress.XtraEditors.TextEdit txt_ho;
        private DevExpress.XtraEditors.TextEdit txt_maNV;
        private System.Windows.Forms.CheckBox cb_trangThaiXoa;
        private System.Windows.Forms.ComboBox cmb_phai;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private System.Windows.Forms.Label lb_maCN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
    }
}