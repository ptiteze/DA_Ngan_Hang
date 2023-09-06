namespace DA_NGANGANG
{
    partial class Frm_khachHang
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label pHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_khachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_huy = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.groupControl_chiNhanh = new DevExpress.XtraEditors.GroupControl();
            this.cmb_chiNhanh = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
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
            this.groupControl_khachHang = new DevExpress.XtraEditors.GroupControl();
            this.cmb_phai = new System.Windows.Forms.ComboBox();
            this.txt_maCN = new DevExpress.XtraEditors.TextEdit();
            this.de_ngayCap = new DevExpress.XtraEditors.DateEdit();
            this.txt_soDT = new DevExpress.XtraEditors.TextEdit();
            this.txt_diaChi = new DevExpress.XtraEditors.TextEdit();
            this.txt_ten = new DevExpress.XtraEditors.TextEdit();
            this.txt_ho = new DevExpress.XtraEditors.TextEdit();
            this.txt_CMND = new DevExpress.XtraEditors.TextEdit();
            this.khachHangTableAdapter = new DA_NGANGANG.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new DA_NGANGANG.DSTableAdapters.TableAdapterManager();
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).BeginInit();
            this.groupControl_chiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_khachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_khachHang)).BeginInit();
            this.groupControl_khachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(60, 56);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(59, 19);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(336, 56);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(73, 19);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(49, 99);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(70, 19);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(574, 99);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(57, 19);
            sODTLabel.TabIndex = 10;
            sODTLabel.Text = "SODT:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(817, 99);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(88, 19);
            nGAYCAPLabel.TabIndex = 12;
            nGAYCAPLabel.Text = "NGAYCAP:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(58, 137);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(59, 19);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "MACN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(853, 60);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(52, 19);
            pHAILabel.TabIndex = 15;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1134, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 587);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1134, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 551);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1134, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 551);
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
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(1134, 87);
            this.groupControl_chiNhanh.TabIndex = 5;
            this.groupControl_chiNhanh.Text = "CHI NHÁNH";
            this.groupControl_chiNhanh.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl_chiNhanh_Paint);
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
            this.groupControl2.Controls.Add(this.khachHangGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1134, 662);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "BẢNG KHÁCH HÀNG";
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.bds_khachHang;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachHangGridControl.Location = new System.Drawing.Point(2, 34);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.MenuManager = this.barManager1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(1130, 626);
            this.khachHangGridControl.TabIndex = 0;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colNGAYCAP.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.GroupFormat.FormatString = "dd/MM/yyyy";
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
            // groupControl_khachHang
            // 
            this.groupControl_khachHang.Controls.Add(pHAILabel);
            this.groupControl_khachHang.Controls.Add(this.cmb_phai);
            this.groupControl_khachHang.Controls.Add(mACNLabel);
            this.groupControl_khachHang.Controls.Add(this.txt_maCN);
            this.groupControl_khachHang.Controls.Add(nGAYCAPLabel);
            this.groupControl_khachHang.Controls.Add(this.de_ngayCap);
            this.groupControl_khachHang.Controls.Add(sODTLabel);
            this.groupControl_khachHang.Controls.Add(this.txt_soDT);
            this.groupControl_khachHang.Controls.Add(dIACHILabel);
            this.groupControl_khachHang.Controls.Add(this.txt_diaChi);
            this.groupControl_khachHang.Controls.Add(this.txt_ten);
            this.groupControl_khachHang.Controls.Add(hOLabel);
            this.groupControl_khachHang.Controls.Add(this.txt_ho);
            this.groupControl_khachHang.Controls.Add(cMNDLabel);
            this.groupControl_khachHang.Controls.Add(this.txt_CMND);
            this.groupControl_khachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl_khachHang.Location = new System.Drawing.Point(0, 422);
            this.groupControl_khachHang.Name = "groupControl_khachHang";
            this.groupControl_khachHang.Size = new System.Drawing.Size(1134, 165);
            this.groupControl_khachHang.TabIndex = 7;
            this.groupControl_khachHang.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // cmb_phai
            // 
            this.cmb_phai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_khachHang, "PHAI", true));
            this.cmb_phai.FormattingEnabled = true;
            this.cmb_phai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmb_phai.Location = new System.Drawing.Point(911, 57);
            this.cmb_phai.Name = "cmb_phai";
            this.cmb_phai.Size = new System.Drawing.Size(121, 27);
            this.cmb_phai.TabIndex = 16;
            // 
            // txt_maCN
            // 
            this.txt_maCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "MACN", true));
            this.txt_maCN.Location = new System.Drawing.Point(123, 134);
            this.txt_maCN.MenuManager = this.barManager1;
            this.txt_maCN.Name = "txt_maCN";
            this.txt_maCN.Properties.ReadOnly = true;
            this.txt_maCN.Size = new System.Drawing.Size(150, 26);
            this.txt_maCN.TabIndex = 15;
            // 
            // de_ngayCap
            // 
            this.de_ngayCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "NGAYCAP", true));
            this.de_ngayCap.EditValue = null;
            this.de_ngayCap.Location = new System.Drawing.Point(911, 96);
            this.de_ngayCap.MenuManager = this.barManager1;
            this.de_ngayCap.Name = "de_ngayCap";
            this.de_ngayCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayCap.Size = new System.Drawing.Size(150, 26);
            this.de_ngayCap.TabIndex = 13;
            // 
            // txt_soDT
            // 
            this.txt_soDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "SODT", true));
            this.txt_soDT.Location = new System.Drawing.Point(637, 96);
            this.txt_soDT.MenuManager = this.barManager1;
            this.txt_soDT.Name = "txt_soDT";
            this.txt_soDT.Size = new System.Drawing.Size(150, 26);
            this.txt_soDT.TabIndex = 11;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "DIACHI", true));
            this.txt_diaChi.Location = new System.Drawing.Point(123, 96);
            this.txt_diaChi.MenuManager = this.barManager1;
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(380, 26);
            this.txt_diaChi.TabIndex = 7;
            // 
            // txt_ten
            // 
            this.txt_ten.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "TEN", true));
            this.txt_ten.Location = new System.Drawing.Point(670, 53);
            this.txt_ten.MenuManager = this.barManager1;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(117, 26);
            this.txt_ten.TabIndex = 5;
            // 
            // txt_ho
            // 
            this.txt_ho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "HO", true));
            this.txt_ho.Location = new System.Drawing.Point(415, 53);
            this.txt_ho.MenuManager = this.barManager1;
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.Size = new System.Drawing.Size(249, 26);
            this.txt_ho.TabIndex = 3;
            // 
            // txt_CMND
            // 
            this.txt_CMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_khachHang, "CMND", true));
            this.txt_CMND.Location = new System.Drawing.Point(125, 53);
            this.txt_CMND.MenuManager = this.barManager1;
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(150, 26);
            this.txt_CMND.TabIndex = 1;
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
            // Frm_khachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 587);
            this.Controls.Add(this.groupControl_khachHang);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_khachHang";
            this.Text = "Quản lí Khách Hàng";
            this.Load += new System.EventHandler(this.Frm_khachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).EndInit();
            this.groupControl_chiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_khachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_khachHang)).EndInit();
            this.groupControl_khachHang.ResumeLayout(false);
            this.groupControl_khachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_phucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_ghi;
        private DevExpress.XtraBars.BarButtonItem btn_huy;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraEditors.GroupControl groupControl_chiNhanh;
        private System.Windows.Forms.ComboBox cmb_chiNhanh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl_khachHang;
        private System.Windows.Forms.BindingSource bds_khachHang;
        private DS dS;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txt_maCN;
        private DevExpress.XtraEditors.DateEdit de_ngayCap;
        private DevExpress.XtraEditors.TextEdit txt_soDT;
        private DevExpress.XtraEditors.TextEdit txt_diaChi;
        private DevExpress.XtraEditors.TextEdit txt_ten;
        private DevExpress.XtraEditors.TextEdit txt_ho;
        private DevExpress.XtraEditors.TextEdit txt_CMND;
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
        private System.Windows.Forms.ComboBox cmb_phai;
    }
}