namespace DA_NGANGANG
{
    partial class Frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButton_dangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barButton_themTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButton_dangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButton_khachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButton_nhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButton_guiRut = new DevExpress.XtraBars.BarButtonItem();
            this.barButton_chuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.barButton_saoKe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButton_thongKeKH = new DevExpress.XtraBars.BarButtonItem();
            this.barButton_taiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_ma = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_hoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_nhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButton_dangNhap,
            this.barButton_themTK,
            this.barButton_dangXuat,
            this.barButton_khachHang,
            this.barButton_nhanVien,
            this.barButton_guiRut,
            this.barButton_chuyenTien,
            this.barButton_saoKe,
            this.barButtonItem2,
            this.barButton_thongKeKH,
            this.barButton_taiKhoan});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(1188, 231);
            // 
            // barButton_dangNhap
            // 
            this.barButton_dangNhap.Caption = "Đăng Nhập";
            this.barButton_dangNhap.Id = 1;
            this.barButton_dangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButton_dangNhap.ImageOptions.SvgImage")));
            this.barButton_dangNhap.Name = "barButton_dangNhap";
            this.barButton_dangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_dangNhap_ItemClick);
            // 
            // barButton_themTK
            // 
            this.barButton_themTK.Caption = "Thêm TK";
            this.barButton_themTK.Id = 2;
            this.barButton_themTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButton_themTK.ImageOptions.SvgImage")));
            this.barButton_themTK.Name = "barButton_themTK";
            this.barButton_themTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_themTK_ItemClick);
            // 
            // barButton_dangXuat
            // 
            this.barButton_dangXuat.Caption = "Đăng Xuất";
            this.barButton_dangXuat.Id = 3;
            this.barButton_dangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButton_dangXuat.ImageOptions.Image")));
            this.barButton_dangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButton_dangXuat.ImageOptions.LargeImage")));
            this.barButton_dangXuat.Name = "barButton_dangXuat";
            this.barButton_dangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_dangXuat_ItemClick);
            // 
            // barButton_khachHang
            // 
            this.barButton_khachHang.Caption = "Khách Hàng";
            this.barButton_khachHang.Id = 4;
            this.barButton_khachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButton_khachHang.ImageOptions.Image")));
            this.barButton_khachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButton_khachHang.ImageOptions.LargeImage")));
            this.barButton_khachHang.Name = "barButton_khachHang";
            this.barButton_khachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_khachHang_ItemClick);
            // 
            // barButton_nhanVien
            // 
            this.barButton_nhanVien.Caption = "Nhân Viên";
            this.barButton_nhanVien.Id = 5;
            this.barButton_nhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButton_nhanVien.ImageOptions.Image")));
            this.barButton_nhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButton_nhanVien.ImageOptions.LargeImage")));
            this.barButton_nhanVien.Name = "barButton_nhanVien";
            this.barButton_nhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_nhanVien_ItemClick);
            // 
            // barButton_guiRut
            // 
            this.barButton_guiRut.Caption = "GD Gửi Rút";
            this.barButton_guiRut.Id = 6;
            this.barButton_guiRut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButton_guiRut.ImageOptions.SvgImage")));
            this.barButton_guiRut.Name = "barButton_guiRut";
            this.barButton_guiRut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_guiRut_ItemClick);
            // 
            // barButton_chuyenTien
            // 
            this.barButton_chuyenTien.Caption = "GD Chuyển Tiền";
            this.barButton_chuyenTien.Id = 7;
            this.barButton_chuyenTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButton_chuyenTien.ImageOptions.Image")));
            this.barButton_chuyenTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButton_chuyenTien.ImageOptions.LargeImage")));
            this.barButton_chuyenTien.Name = "barButton_chuyenTien";
            this.barButton_chuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_chuyenTien_ItemClick);
            // 
            // barButton_saoKe
            // 
            this.barButton_saoKe.Caption = "Sao Kê TK";
            this.barButton_saoKe.Id = 8;
            this.barButton_saoKe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButton_saoKe.ImageOptions.SvgImage")));
            this.barButton_saoKe.Name = "barButton_saoKe";
            this.barButton_saoKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_saoKe_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thống Kê TK";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButton_thongKeKH
            // 
            this.barButton_thongKeKH.Caption = "Thống Kê KH";
            this.barButton_thongKeKH.Id = 10;
            this.barButton_thongKeKH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButton_thongKeKH.ImageOptions.SvgImage")));
            this.barButton_thongKeKH.Name = "barButton_thongKeKH";
            this.barButton_thongKeKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButton_thongKeKH_ItemClick_1);
            // 
            // barButton_taiKhoan
            // 
            this.barButton_taiKhoan.Caption = "Tài Khoản";
            this.barButton_taiKhoan.Id = 11;
            this.barButton_taiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButton_taiKhoan.ImageOptions.Image")));
            this.barButton_taiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButton_taiKhoan.ImageOptions.LargeImage")));
            this.barButton_taiKhoan.Name = "barButton_taiKhoan";
            this.barButton_taiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Login";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButton_dangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButton_themTK);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButton_dangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Chức Năng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButton_khachHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButton_nhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButton_guiRut);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButton_chuyenTien);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButton_taiKhoan);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Thống Kê";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButton_saoKe);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButton_thongKeKH);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_ma,
            this.status_hoTen,
            this.status_nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 861);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1188, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_ma
            // 
            this.status_ma.Name = "status_ma";
            this.status_ma.Size = new System.Drawing.Size(61, 25);
            this.status_ma.Text = "MaNV";
            // 
            // status_hoTen
            // 
            this.status_hoTen.Name = "status_hoTen";
            this.status_hoTen.Size = new System.Drawing.Size(62, 25);
            this.status_hoTen.Text = "HoTen";
            // 
            // status_nhom
            // 
            this.status_nhom.Name = "status_nhom";
            this.status_nhom.Size = new System.Drawing.Size(62, 25);
            this.status_nhom.Text = "Nhóm";
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 893);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "Frm_main";
            this.Ribbon = this.ribbon;
            this.Text = "Quản Lý Ngân Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButton_dangNhap;
        private DevExpress.XtraBars.BarButtonItem barButton_themTK;
        private DevExpress.XtraBars.BarButtonItem barButton_dangXuat;
        private DevExpress.XtraBars.BarButtonItem barButton_khachHang;
        private DevExpress.XtraBars.BarButtonItem barButton_nhanVien;
        private DevExpress.XtraBars.BarButtonItem barButton_guiRut;
        private DevExpress.XtraBars.BarButtonItem barButton_chuyenTien;
        private DevExpress.XtraBars.BarButtonItem barButton_saoKe;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButton_thongKeKH;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel status_ma;
        public System.Windows.Forms.ToolStripStatusLabel status_hoTen;
        public System.Windows.Forms.ToolStripStatusLabel status_nhom;
        private DevExpress.XtraBars.BarButtonItem barButton_taiKhoan;
    }
}