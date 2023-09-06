using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_NGANGANG
{
    public partial class Frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Frm_login f_dangNhap;
        Frm_taoTK f_taoTK;
        Frm_nhanVien f_nhanVien;
        Frm_khachHang f_khachHang;
        Frm_taiKhoan f_taiKhoan;
        Frm_goiRut f_goiRut;
        Frm_chuyenTien f_chuyenTien;
        Frm_saoKe f_saoKe;
        Frm_thongKeTaiKhoan frm_thongKeTaiKhoan;
        Frm_KHTK frm_KHTK;
        Frm_thongKeKhachHang frm_ThongKeKhachHang;
        public Frm_main()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public void hienThongTinStatus()
        {
            status_ma.Text = "MaNV: " + Program.username;
            status_hoTen.Text = "TenNV: " + Program.mHoten;
            status_nhom.Text = "Nhom: " + Program.mGroup;

            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
        }
        private void barButton_saoKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_KHTK = this.CheckExists(typeof(Frm_KHTK));
            if (frm_KHTK != null)
                frm_KHTK.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_thongKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_thongKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();            
            Form frm_taoTK = this.CheckExists(typeof(Frm_taoTK));
            if (frm_taoTK != null)
                frm_taoTK.Close();
            Form frm = this.CheckExists(typeof(Frm_saoKe));
            if (frm != null) frm.Activate();
            else
            {
                f_saoKe = new Frm_saoKe();
                f_saoKe.MdiParent = this;
                f_saoKe.Show();
            }
        }

        private void barButton_dangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup != "")
            {
                MessageBox.Show("Bạn chưa đăng xuất!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_taoTaiKhoan = this.CheckExists(typeof(Frm_taoTK));
            if (frm_taoTaiKhoan != null)
                frm_taoTaiKhoan.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_KHTK = this.CheckExists(typeof(Frm_KHTK));
            if (frm_KHTK != null)
                frm_KHTK.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_thongKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_thongKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();
            Form frm = this.CheckExists(typeof(Frm_login));
            if (frm != null) frm.Activate();
            else
            {
                f_dangNhap = new Frm_login();
                f_dangNhap.MdiParent = this;
                //f_dangNhap.f_main = this;
                f_dangNhap.Show();
            }
        }

        private void barButton_themTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup.Equals("USER"))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn không đủ thẩm quyền", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_KHTK = this.CheckExists(typeof(Frm_KHTK));
            if (frm_KHTK != null)
                frm_KHTK.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_thongKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_thongKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();
            Form frm = this.CheckExists(typeof(Frm_taoTK));
            if (frm != null) frm.Activate();
            else
            {
                f_taoTK = new Frm_taoTK();
                f_taoTK.MdiParent = this;
                //f_dangNhap.f_main = this;
                f_taoTK.Show();
            }
        }

        private void barButton_dangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoten.Trim().Length == 0 || Program.mGroup.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa đăng nhập!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_taoTaiKhoan = this.CheckExists(typeof(Frm_taoTK));
            if (frm_taoTaiKhoan != null)
                frm_taoTaiKhoan.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_KHTK = this.CheckExists(typeof(Frm_KHTK));
            if (frm_KHTK != null)
                frm_KHTK.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_thongKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_thongKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();
            Program.myReader = null;
            Program.username = "";
            Program.mlogin = "";
            Program.password = "";
            Program.mloginDN = "";
            Program.passwordDN = "";
            Program.mGroup = "";
            Program.mHoten = "";
            Program.mCoso = 0;
            Frm_main f1 = new Frm_main();
            f1.hienThongTinStatus();
            status_ma.Text = "MaNV: ";
            status_hoTen.Text = "TenNV: ";
            status_nhom.Text = "Nhom: ";
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK);
            return;
        }

        private void barButton_nhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup.Equals("USER"))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn không đủ thẩm quyền", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_taoTK = this.CheckExists(typeof(Frm_taoTK));
            if (frm_taoTK != null)
                frm_taoTK.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_KHTK = this.CheckExists(typeof(Frm_KHTK));
            if (frm_KHTK != null)
                frm_KHTK.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_thongKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_thongKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();
            Form frm = this.CheckExists(typeof(Frm_nhanVien));
            if (frm != null) frm.Activate();
            else
            {
                f_nhanVien = new Frm_nhanVien();
                f_nhanVien.MdiParent = this;
                //f_dangNhap.f_main = this;
                f_nhanVien.Show();
            }
        }

        private void barButton_khachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup.Equals("USER"))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn không đủ thẩm quyền", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_taoTK = this.CheckExists(typeof(Frm_taoTK));
            if (frm_taoTK != null)
                frm_taoTK.Close();
            //Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            //if (frm_taiKhoan != null)
            //    frm_taiKhoan.Close();
            Form frm_KHTK = this.CheckExists(typeof(Frm_KHTK));
            if (frm_KHTK != null)
                frm_KHTK.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_thongKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_thongKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();
            Form frm = this.CheckExists(typeof(Frm_khachHang));
            Form frm2 = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                f_khachHang = new Frm_khachHang();
                f_khachHang.MdiParent = this;
                //f_dangNhap.f_main = this;
                f_khachHang.Show();
            }
            //if (frm2 != null) frm.Activate();
            //else
            //{
            //    f_taiKhoan = new Frm_taiKhoan();
            //    //f_khachHang.MdiParent = this;
            //    //f_dangNhap.f_main = this;
            //    f_taiKhoan.Show();
            //}
        }

        private void barButton_guiRut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup.Equals("USER"))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn không đủ thẩm quyền", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_KHTK = this.CheckExists(typeof(Frm_KHTK));
            if (frm_KHTK != null)
                frm_KHTK.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_taoTK = this.CheckExists(typeof(Frm_taoTK));
            if (frm_taoTK != null)
                frm_taoTK.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_thongKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_thongKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();
            Form frm = this.CheckExists(typeof(Frm_goiRut));
            if (frm != null) frm.Activate();
            else
            {
                f_goiRut = new Frm_goiRut();
                f_goiRut.MdiParent = this;
                //f_dangNhap.f_main = this;
                f_goiRut.Show();
            }
        }

        private void barButton_chuyenTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup.Equals("USER"))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn không đủ thẩm quyền", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_KHTK = this.CheckExists(typeof(Frm_KHTK));
            if (frm_KHTK != null)
                frm_KHTK.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_taoTK));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_thongKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_thongKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();
            Form frm = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm != null) frm.Activate();
            else
            {
                f_chuyenTien = new Frm_chuyenTien();
                f_chuyenTien.MdiParent = this;
                //f_dangNhap.f_main = this;
                f_chuyenTien.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup.Equals("USER"))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn không đủ thẩm quyền", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_KHTK = this.CheckExists(typeof(Frm_KHTK));
            if (frm_KHTK != null)
                frm_KHTK.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_thongKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();
            Form frm_taoTK = this.CheckExists(typeof(Frm_taoTK));
            if (frm_taoTK != null)
                frm_taoTK.Close();
            Form frm = this.CheckExists(typeof(Frm_thongKeTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frm_thongKeTaiKhoan = new Frm_thongKeTaiKhoan();
                frm_thongKeTaiKhoan.MdiParent = this;
                //f_dangNhap.f_main = this;
                frm_thongKeTaiKhoan.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup.Equals("USER"))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn không đủ thẩm quyền", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_thongKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_lietkekhachhang = this.CheckExists(typeof(Frm_thongKeKhachHang));
            if (frm_lietkekhachhang != null)
                frm_lietkekhachhang.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();
            Form frm_taoTK = this.CheckExists(typeof(Frm_taoTK));
            if (frm_taoTK != null)
                frm_taoTK.Close();
            Form frm = this.CheckExists(typeof(Frm_KHTK));
            if (frm != null) frm.Activate();
            else
            {
                frm_KHTK = new Frm_KHTK();
                frm_KHTK.MdiParent = this;
                //f_dangNhap.f_main = this;
                frm_KHTK.Show();
            }
        }

        private void barButton_thongKeKH_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButton_thongKeKH_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup.Equals("USER"))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn không đủ thẩm quyền", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm_nhanVien = this.CheckExists(typeof(Frm_nhanVien));
            if (frm_nhanVien != null)
                frm_nhanVien.Close();
            Form frm_khachHang = this.CheckExists(typeof(Frm_khachHang));
            if (frm_khachHang != null)
                frm_khachHang.Close();
            Form frm_taiKhoan = this.CheckExists(typeof(Frm_taiKhoan));
            if (frm_taiKhoan != null)
                frm_taiKhoan.Close();
            Form frm_KHTK = this.CheckExists(typeof(Frm_KHTK));
            if (frm_KHTK != null)
                frm_KHTK.Close();
            Form frm_goirut = this.CheckExists(typeof(Frm_goiRut));
            if (frm_goirut != null)
                frm_goirut.Close();
            Form frm_chuyentien = this.CheckExists(typeof(Frm_chuyenTien));
            if (frm_chuyentien != null)
                frm_chuyentien.Close();
            Form frm_lietketaiKhoan = this.CheckExists(typeof(Frm_thongKeTaiKhoan));
            if (frm_lietketaiKhoan != null)
                frm_lietketaiKhoan.Close();
            Form frm_saoke = this.CheckExists(typeof(Frm_saoKe));
            if (frm_saoke != null)
                frm_saoke.Close();
            Form frm_taoTK = this.CheckExists(typeof(Frm_taoTK));
            if (frm_taoTK != null)
                frm_taoTK.Close();
            Form frm = this.CheckExists(typeof(Frm_thongKeKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                frm_ThongKeKhachHang = new Frm_thongKeKhachHang();
                frm_ThongKeKhachHang.MdiParent = this;
                frm_ThongKeKhachHang.Show();
            }
        }
    }
}