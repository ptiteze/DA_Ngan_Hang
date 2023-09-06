namespace DA_NGANGANG
{
    partial class Frm_goiRut
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
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label lOAIGDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_goiRut));
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
            this.gD_GOIRUTGridControl = new DevExpress.XtraGrid.GridControl();
            this.bds_goiRut = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DA_NGANGANG.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_goiRut = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_loaiGD = new System.Windows.Forms.ComboBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.txt_maNV = new DevExpress.XtraEditors.TextEdit();
            this.de_ngayGD = new DevExpress.XtraEditors.DateEdit();
            this.sp_soTien = new DevExpress.XtraEditors.SpinEdit();
            this.txt_soTK = new DevExpress.XtraEditors.TextEdit();
            this.gD_GOIRUTTableAdapter = new DA_NGANGANG.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new DA_NGANGANG.DSTableAdapters.TableAdapterManager();
            this.txt_kiemTra = new System.Windows.Forms.TextBox();
            this.btn_kiemTra = new System.Windows.Forms.Button();
            sOTKLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            lOAIGDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).BeginInit();
            this.groupControl_chiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_goiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_goiRut)).BeginInit();
            this.groupControl_goiRut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_soTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(105, 68);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(55, 19);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "SOTK:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Location = new System.Drawing.Point(479, 69);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(72, 19);
            sOTIENLabel.TabIndex = 2;
            sOTIENLabel.Text = "SOTIEN:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Location = new System.Drawing.Point(80, 151);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(80, 19);
            nGAYGDLabel.TabIndex = 4;
            nGAYGDLabel.Text = "NGAYGD:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(449, 138);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(59, 19);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // lOAIGDLabel
            // 
            lOAIGDLabel.AutoSize = true;
            lOAIGDLabel.Location = new System.Drawing.Point(821, 67);
            lOAIGDLabel.Name = "lOAIGDLabel";
            lOAIGDLabel.Size = new System.Drawing.Size(74, 19);
            lOAIGDLabel.TabIndex = 10;
            lOAIGDLabel.Text = "LOAIGD:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1154, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 567);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1154, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 531);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1154, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
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
            this.groupControl_chiNhanh.Size = new System.Drawing.Size(1154, 87);
            this.groupControl_chiNhanh.TabIndex = 6;
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
            this.groupControl2.Controls.Add(this.gD_GOIRUTGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1154, 240);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "BẢNG GIAO DỊCH GỌI RÚT";
            // 
            // gD_GOIRUTGridControl
            // 
            this.gD_GOIRUTGridControl.DataSource = this.bds_goiRut;
            this.gD_GOIRUTGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gD_GOIRUTGridControl.Location = new System.Drawing.Point(2, 34);
            this.gD_GOIRUTGridControl.MainView = this.gridView1;
            this.gD_GOIRUTGridControl.MenuManager = this.barManager1;
            this.gD_GOIRUTGridControl.Name = "gD_GOIRUTGridControl";
            this.gD_GOIRUTGridControl.Size = new System.Drawing.Size(1150, 204);
            this.gD_GOIRUTGridControl.TabIndex = 0;
            this.gD_GOIRUTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bds_goiRut
            // 
            this.bds_goiRut.DataMember = "GD_GOIRUT";
            this.bds_goiRut.DataSource = this.dS;
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
            this.colSOTK,
            this.colLOAIGD,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colMANV});
            this.gridView1.GridControl = this.gD_GOIRUTGridControl;
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
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 30;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.OptionsColumn.ReadOnly = true;
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 1;
            this.colSOTK.Width = 112;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 30;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.OptionsColumn.ReadOnly = true;
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 2;
            this.colLOAIGD.Width = 112;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 30;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.OptionsColumn.ReadOnly = true;
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 3;
            this.colNGAYGD.Width = 112;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 30;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.OptionsColumn.ReadOnly = true;
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 4;
            this.colSOTIEN.Width = 112;
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
            // groupControl_goiRut
            // 
            this.groupControl_goiRut.Controls.Add(this.btn_kiemTra);
            this.groupControl_goiRut.Controls.Add(this.txt_kiemTra);
            this.groupControl_goiRut.Controls.Add(this.label1);
            this.groupControl_goiRut.Controls.Add(lOAIGDLabel);
            this.groupControl_goiRut.Controls.Add(this.cmb_loaiGD);
            this.groupControl_goiRut.Controls.Add(this.btn_huy);
            this.groupControl_goiRut.Controls.Add(this.btn_xacNhan);
            this.groupControl_goiRut.Controls.Add(mANVLabel);
            this.groupControl_goiRut.Controls.Add(this.txt_maNV);
            this.groupControl_goiRut.Controls.Add(nGAYGDLabel);
            this.groupControl_goiRut.Controls.Add(this.de_ngayGD);
            this.groupControl_goiRut.Controls.Add(sOTIENLabel);
            this.groupControl_goiRut.Controls.Add(this.sp_soTien);
            this.groupControl_goiRut.Controls.Add(sOTKLabel);
            this.groupControl_goiRut.Controls.Add(this.txt_soTK);
            this.groupControl_goiRut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_goiRut.Location = new System.Drawing.Point(0, 363);
            this.groupControl_goiRut.Name = "groupControl_goiRut";
            this.groupControl_goiRut.Size = new System.Drawing.Size(1154, 204);
            this.groupControl_goiRut.TabIndex = 8;
            this.groupControl_goiRut.Text = "THÔNG TIN GIAO DỊCH";
            this.groupControl_goiRut.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl_goiRut_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "VND";
            // 
            // cmb_loaiGD
            // 
            this.cmb_loaiGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_goiRut, "LOAIGD", true));
            this.cmb_loaiGD.FormattingEnabled = true;
            this.cmb_loaiGD.Location = new System.Drawing.Point(915, 63);
            this.cmb_loaiGD.Name = "cmb_loaiGD";
            this.cmb_loaiGD.Size = new System.Drawing.Size(135, 27);
            this.cmb_loaiGD.TabIndex = 11;
            this.cmb_loaiGD.SelectedIndexChanged += new System.EventHandler(this.cmb_loaiGD_SelectedIndexChanged);
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
            // txt_maNV
            // 
            this.txt_maNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_goiRut, "MANV", true));
            this.txt_maNV.Location = new System.Drawing.Point(514, 135);
            this.txt_maNV.MenuManager = this.barManager1;
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Properties.ReadOnly = true;
            this.txt_maNV.Size = new System.Drawing.Size(150, 26);
            this.txt_maNV.TabIndex = 7;
            // 
            // de_ngayGD
            // 
            this.de_ngayGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_goiRut, "NGAYGD", true));
            this.de_ngayGD.EditValue = null;
            this.de_ngayGD.Location = new System.Drawing.Point(166, 148);
            this.de_ngayGD.MenuManager = this.barManager1;
            this.de_ngayGD.Name = "de_ngayGD";
            this.de_ngayGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayGD.Size = new System.Drawing.Size(150, 26);
            this.de_ngayGD.TabIndex = 5;
            // 
            // sp_soTien
            // 
            this.sp_soTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_goiRut, "SOTIEN", true));
            this.sp_soTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sp_soTien.Location = new System.Drawing.Point(557, 62);
            this.sp_soTien.MenuManager = this.barManager1;
            this.sp_soTien.Name = "sp_soTien";
            this.sp_soTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sp_soTien.Size = new System.Drawing.Size(150, 28);
            this.sp_soTien.TabIndex = 3;
            // 
            // txt_soTK
            // 
            this.txt_soTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_goiRut, "SOTK", true));
            this.txt_soTK.Location = new System.Drawing.Point(166, 65);
            this.txt_soTK.MenuManager = this.barManager1;
            this.txt_soTK.Name = "txt_soTK";
            this.txt_soTK.Size = new System.Drawing.Size(150, 26);
            this.txt_soTK.TabIndex = 1;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DA_NGANGANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_kiemTra
            // 
            this.txt_kiemTra.Location = new System.Drawing.Point(97, 106);
            this.txt_kiemTra.Name = "txt_kiemTra";
            this.txt_kiemTra.ReadOnly = true;
            this.txt_kiemTra.Size = new System.Drawing.Size(219, 27);
            this.txt_kiemTra.TabIndex = 13;
            // 
            // btn_kiemTra
            // 
            this.btn_kiemTra.Location = new System.Drawing.Point(331, 65);
            this.btn_kiemTra.Name = "btn_kiemTra";
            this.btn_kiemTra.Size = new System.Drawing.Size(94, 26);
            this.btn_kiemTra.TabIndex = 14;
            this.btn_kiemTra.Text = "Kiểm Tra";
            this.btn_kiemTra.UseVisualStyleBackColor = true;
            this.btn_kiemTra.Click += new System.EventHandler(this.btn_kiemTra_Click);
            // 
            // Frm_goiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 567);
            this.Controls.Add(this.groupControl_goiRut);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl_chiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_goiRut";
            this.Text = "Giao Dịch Gọi Rút";
            this.Load += new System.EventHandler(this.Frm_goiRut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chiNhanh)).EndInit();
            this.groupControl_chiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_goiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_goiRut)).EndInit();
            this.groupControl_goiRut.ResumeLayout(false);
            this.groupControl_goiRut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_soTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soTK.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bds_goiRut;
        private DS dS;
        private DevExpress.XtraEditors.GroupControl groupControl_goiRut;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gD_GOIRUTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.ComboBox cmb_loaiGD;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_xacNhan;
        private DevExpress.XtraEditors.TextEdit txt_maNV;
        private DevExpress.XtraEditors.DateEdit de_ngayGD;
        private DevExpress.XtraEditors.SpinEdit sp_soTien;
        private DevExpress.XtraEditors.TextEdit txt_soTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kiemTra;
        private System.Windows.Forms.TextBox txt_kiemTra;
    }
}