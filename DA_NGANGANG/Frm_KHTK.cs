using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_NGANGANG
{
    public partial class Frm_KHTK : Form
    {
        Stack undo = new Stack();
        public Boolean checkKH = false;
        private SqlDataReader dataReader;

        public Frm_KHTK()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_khachHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Frm_KHTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            //this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);

            try
            {
                dS.EnforceConstraints = false;
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;

                // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
                cmb_chiNhanh.DataSource = Program.bds_dspm;
                cmb_chiNhanh.DisplayMember = "TENCN";
                cmb_chiNhanh.ValueMember = "TENSERVER";
                cmb_chiNhanh.SelectedIndex = Program.mCoso;
                if (Program.mGroup.Equals("CHINHANH"))
                {
                    groupControl_chiNhanh.Enabled = false;
                }
                else
                {
                    groupControl_chiNhanh.Enabled = true;
                    btn_them.Enabled = false;
                    btn_sua.Enabled = false;
                    btn_ghi.Enabled = false;
                    btn_huy.Enabled = false;
                }
                groupControl_taiKhoan.Enabled = false;
                btn_ghi.Enabled = btn_huy.Enabled = btn_phucHoi.Enabled = false;
                if (bds_taiKhoan.Count == 0)
                {
                    btn_xoa.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Tải dữ liệu không thành công!\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void taiKhoanGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl_chiNhanh.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_ghi.Enabled = true;
            btn_huy.Enabled = true;
            btn_xoa.Enabled = false;
            btn_reload.Enabled = false;
            txt_maCN.Enabled = false;
            bds_taiKhoan.AddNew();

            if (cmb_chiNhanh.SelectedValue.ToString().Contains("DESKTOP-LL3CDGR\\MSSQLSERVER01"))
            {
                txt_maCN.Text = "BENTHANH";
            }
            else
            {
                txt_maCN.Text = "TANDINH";
            }
            de_ngayMoTK.EditValue = DateTime.Today;
            String cmnd = ((DataRowView)bds_khachHang[bds_khachHang.Position])["CMND"].ToString();
            txt_CMND.Text = cmnd;
            groupControl_taiKhoan.Enabled = true;
            taiKhoanGridControl.Enabled = false;
           khachHangGridControl.Enabled = false;
            txt_soTK.Focus();
        }

        private void btn_phucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (undo.Count>0)
            //{
            //    String soTK = undo.Pop().ToString();
            //    String sql = "DELETE FROM [dbo].[TaiKhoan] as TK WHERE TK.SOTK = " + soTK;
            //    Program.ExecSqlNonQuery(sql);
            //    this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            //    this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            //    if (undo.Count == 0) btn_phucHoi.Enabled = false;
            //}
            //if (undo.Count == 0)
            //{
            //    btn_phucHoi.Enabled = false;
            //}
        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_soTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tài khoản không được trống!", "Lỗi", MessageBoxButtons.OK);
                txt_soTK.Focus();
                return;
            }
            String stkPattern = "\\d";
            if (!Regex.IsMatch(txt_soTK.Text.Trim(), stkPattern) || txt_soTK.Text.Trim().Length > 9)
            {
                MessageBox.Show("Nhập sai định dạng số tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soTK.Focus();
                return;
            }
            String cmndPattern = "\\d{9}";
            if (txt_CMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("CMND không được trống!", "Lỗi", MessageBoxButtons.OK);
                txt_CMND.Focus();
                return;
            }
            if (!Regex.IsMatch(txt_CMND.Text.Trim(), cmndPattern))
            {
                MessageBox.Show("Nhập sai định dạng CMND!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_CMND.Focus();
                return;
            }
            if (sp_soDu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số dư không được trống!", "Lỗi", MessageBoxButtons.OK);
                sp_soDu.Focus();
                return;
            }
            if (de_ngayMoTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ngày mở tài khoản không được trống!", "Lỗi", MessageBoxButtons.OK);
                de_ngayMoTK.Focus();
                return;
            }
            if (sp_soDu.Value < 0)
            {
                MessageBox.Show("Số dư không hợp lệ!", "Lỗi", MessageBoxButtons.OK);
                sp_soDu.Focus();
                return;
            }
            if (!checkKH)
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin khách hàng!", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                String soTK = txt_soTK.Text.Trim();
                string strLenh = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CheckStkExists] " +
                               "@SOTK = " + txt_soTK.Text.Trim() + " " +
                               "SELECT 'Return Value' = @return_value";

                //SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                // Đọc và lấy 
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_soTK.Focus();
                    return;
                }
                undo.Push(soTK);
                bds_taiKhoan.EndEdit();
                this.taiKhoanTableAdapter.Update(this.dS.TaiKhoan);
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //bds_taiKhoan.Position = bds_taiKhoan.Find("SOTK", soTK);
                groupControl_taiKhoan.Enabled = false;
                btn_them.Enabled = btn_phucHoi.Enabled = btn_reload.Enabled = true;
                btn_ghi.Enabled = btn_huy.Enabled = false;
                taiKhoanGridControl.Enabled = true;
                khachHangGridControl.Enabled = true;
                checkKH = false;
                if (Program.mGroup.Equals("NGANHANG"))
                {
                    groupControl_chiNhanh.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi tài khoản!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_taiKhoan.RemoveCurrent();
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            groupControl_taiKhoan.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_reload.Enabled = true;
            btn_ghi.Enabled = btn_huy.Enabled = false;
            checkKH = false;
            taiKhoanGridControl.Enabled = true;
            khachHangGridControl.Enabled =true;
            if (Program.mGroup == "NGANHANG")
            {
                groupControl_chiNhanh.Enabled = true;
            }
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_chiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmb_chiNhanh.SelectedValue.ToString();
            if (cmb_chiNhanh.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK);
            else
            {

                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            }
        }

        private void khachHangGridControl_Click(object sender, EventArgs e)
        {
            String cmnd = ((DataRowView)bds_khachHang[bds_khachHang.Position])["CMND"].ToString();
            txt_CMND.Text = cmnd;
        }

        private void btn_traCuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_CMND.Text.Trim().Length == 0)
                {
                    MessageBox.Show("CMND không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_CMND.Focus();
                    return;
                }
                String cmndPattern = "\\d{10}";
                if (!Regex.IsMatch(txt_CMND.Text.Trim(), cmndPattern) || txt_CMND.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Nhập sai định dạng CMND!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_CMND.Focus();
                    return;
                }
                string strLenh = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_TRACUUKH] " +
                               "@CMND = N'" + txt_CMND.Text.Trim() + "' " +
                               "SELECT 'Return Value' = @return_value";
                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                // Đọc và lấy 
                dataReader.Read();
                int result = dataReader.GetInt32(0);
                if (result == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng " + txt_CMND.Text.Trim(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Thông tin khách hàng hợp lệ!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkKH = true;
                }
                dataReader.Close();
                return;
            }
            catch
            {
                MessageBox.Show("Tra cứu không thành công!\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
