using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DA_NGANGANG
{
    public partial class Frm_nhanVien : Form
    {
        private Boolean isSua = false;
        string NV_info = "";
        Stack undolist = new Stack();
        String CN = "";
        private void xoa_nhan_vien(string maNV)
        {
            try
            {
                string lenh = "update[dbo].[NhanVien] set TrangThaiXoa = 1 where MANV = '" + maNV + "'";
                Program.ExecSqlNonQuery(lenh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa nhân viên thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public Frm_nhanVien()
        {
            InitializeComponent();
        }

       

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_nhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Frm_nhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                dS.EnforceConstraints = false;
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                cmb_chiNhanh.DataSource = Program.bds_dspm;
                cmb_chiNhanh.DisplayMember = "TENCN";
                cmb_chiNhanh.ValueMember = "TENSERVER";
                cmb_chiNhanh.SelectedIndex = Program.mCoso;
                CN = cmb_chiNhanh.Text;
                Console.WriteLine(CN);
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
                    btn_xoa.Enabled = false;
                    btn_chuyenChiNhanh.Enabled = false;
                }
                groupControl_nhanVien.Enabled = false;
                btn_ghi.Enabled = btn_huy.Enabled = btn_phucHoi.Enabled = false;
                if (bds_nhanVien.Count == 0)
                {
                    btn_xoa.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Tải dữ liệu không thành công!\n" , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void cmb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
                    MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            btn_chuyenChiNhanh.Enabled = false;
            bds_nhanVien.AddNew();
            if(cmb_chiNhanh.SelectedValue.ToString()== "DESKTOP-LL3CDGR\\MSSQLSERVER01")
            lb_maCN.Text  = "BENTHANH";
            else lb_maCN.Text  = "TANDINH";
            cmb_phai.SelectedIndex = 1;
            cmb_phai.SelectedIndex = 0;
            groupControl_nhanVien.Enabled = true;
            nhanVienGridControl.Enabled = false;
            cb_trangThaiXoa.Checked = false;
            txt_maNV.Focus();
            
        }

        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String trangThaiXoa;
            trangThaiXoa = ((DataRowView)bds_nhanVien[bds_nhanVien.Position])["TrangThaiXoa"].ToString();

            if (trangThaiXoa == "1")
            {
                MessageBox.Show("Nhân viên đã bị xoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            isSua = true;           
            txt_maNV.Enabled = false;
            groupControl_nhanVien.Enabled = true;
            groupControl_chiNhanh.Enabled = false;
            nhanVienGridControl.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = btn_chuyenChiNhanh.Enabled = false;
            btn_ghi.Enabled = btn_huy.Enabled = true;
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maNV = "";
            String trangThaiXoa;
            trangThaiXoa = ((DataRowView)bds_nhanVien[bds_nhanVien.Position])["TrangThaiXoa"].ToString();

            if (trangThaiXoa == "1")
            {
                MessageBox.Show("Nhân viên đã bị xoá!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (bds_nhanVien.Count == 0)
            {
                MessageBox.Show("Không có nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK);
                btn_xoa.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        maNV = ((DataRowView)bds_nhanVien[bds_nhanVien.Position])["MANV"].ToString();
                        if(maNV.Equals(Program.username)) {
                            MessageBox.Show("Không thể xóa chính mình!", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                        String NV_info = txt_maNV.Text.Trim() + "#" + txt_ho.Text.Trim() + "#" + txt_ten.Text.Trim() +
                            "#" + txt_CMND.Text.Trim() +"#"+ txt_diaChi.Text.Trim() + "#" + cmb_phai.SelectedItem.ToString() + "#" + txt_soDT.Text.Trim();
                        Console.WriteLine(NV_info);
                        bds_nhanVien.RemoveCurrent();
                        xoa_nhan_vien(maNV);
                        btn_phucHoi.Enabled = true;
                        undolist.Push(NV_info);
                        undolist.Push("DELETE");
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa nhân viên. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                        bds_nhanVien.Position = bds_nhanVien.Find("MANV", maNV);
                        return;
                    }
                }
            }
        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int result,resultSDT,resultCMND;
            if (txt_maNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã nhân viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txt_maNV.Focus();
                return;
            }
            String mnvPattern = "\\w";
            if (!Regex.IsMatch(txt_maNV.Text.Trim(), mnvPattern) || txt_maNV.Text.Trim().Length > 10)
            {
                MessageBox.Show("Nhập sai định dạng Mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_maNV.Focus();
                return;
            }
            String hoten = "[a-zA-Z]";
            if (txt_ho.Text.Trim().Length == 0 || txt_ho.Text.Trim().Length >40)
            {
                MessageBox.Show("Họ nhân viên không được trống, hoặc dài quá 40 kí tự!", "Lỗi", MessageBoxButtons.OK);
                txt_ho.Focus();
                return;
            }
            if (!Regex.IsMatch(txt_ho.Text.Trim(), hoten))
            {
                MessageBox.Show("Nhập sai định dạng họ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ho.Focus();
                return;
            }
            if (txt_ten.Text.Trim().Length == 0|| txt_ten.Text.Trim().Length > 40)
            {
                MessageBox.Show("Tên nhân viên không được trống, hoặc dài quá 40 kí tự!", "Lỗi", MessageBoxButtons.OK);
                txt_ten.Focus();
                return;
            }
            if (!Regex.IsMatch(txt_ten.Text.Trim(), hoten))
            {
                MessageBox.Show("Nhập sai định dạng tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ten.Focus();
                return;
            }
            if (txt_diaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được trống!", "Lỗi", MessageBoxButtons.OK);
                txt_diaChi.Focus();
                return;
            }
            String PhoneNumber = "0\\d{9,10}";
            if (txt_soDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số điện thoại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soDT.Focus();
                return;
            }
            if (!Regex.IsMatch(txt_soDT.Text.Trim(), PhoneNumber))
            {
                MessageBox.Show("Nhập sai định dạng SĐT!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soDT.Focus();
                return;
            }
            if (txt_CMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("CMND không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soDT.Focus();
                return;
            }
            if (!Regex.IsMatch(txt_CMND.Text.Trim(), PhoneNumber))
            {
                MessageBox.Show("Nhập sai định dạng CMND!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soDT.Focus();
                return;
            }
            try
            {
                if (!isSua)
                {
                    strLenh = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKNVEXISTS] " +
                               "@MANV = " + txt_maNV.Text.Trim() + " " +
                               "SELECT 'Return Value' = @return_value";

                    dataReader = null;
                    dataReader = Program.ExecSqlDataReader(strLenh);
                    // Đọc và lấy 
                    dataReader.Read();
                    result = dataReader.GetInt32(0);
                    dataReader.Close();

                    if (result == 1)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_maNV.Focus();
                        return;
                    }
                }
                // Check CMND
                String strLenhCMND = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKCMNDNV] " +
                               "@MANV = '" + txt_maNV.Text.Trim() + "' , @CM = '" +
                               txt_CMND.Text.Trim() + "' " +
                               "SELECT 'Return Value' = @return_value";
                dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenhCMND);
                dataReader.Read();
                resultCMND = dataReader.GetInt32(0);
                dataReader.Close();
                if (resultCMND == 1)
                {
                    MessageBox.Show("Số Chứng Minh Nhân Dân đã bị trùng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_CMND.Focus();
                    return;
                }
                /// Check SDT
                String strLenhSDT = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKSDTNV] " +
                               "@MANV = '" + txt_maNV.Text.Trim() + "' , @SDT = '" +
                               txt_soDT.Text.Trim() + "' " +
                               "SELECT 'Return Value' = @return_value";
                dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenhSDT);
                dataReader.Read();
                resultSDT = dataReader.GetInt32(0);
                dataReader.Close();
                if (resultSDT == 1)
                {
                    MessageBox.Show("Số Điện thoại đã bị trùng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_soDT.Focus();
                    return;
                }
                ////////////////
                String maNV = ((DataRowView)bds_nhanVien[bds_nhanVien.Position])["MANV"].ToString();
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK) {
                    if (!isSua)
                    {
                        btn_phucHoi.Enabled = true;
                        undolist.Push(maNV);
                        undolist.Push("INSERT");
                    }
                    else
                    {

                        btn_phucHoi.Enabled = true;
                        String NV_info = txt_maNV.Text.Trim() + "#" + txt_ho.Text.Trim() + "#" + txt_ten.Text.Trim() +
                            "#" + txt_CMND.Text.Trim() + "#" + txt_diaChi.Text.Trim() + "#" + cmb_phai.SelectedItem.ToString() + "#" + txt_soDT.Text.Trim();
                        Console.WriteLine(NV_info);
                        undolist.Push(NV_info);
                        undolist.Push("EDIT");
                    }
                    //cmb_phai.Text = phai;
                    bds_nhanVien.EndEdit();
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    groupControl_nhanVien.Enabled = false;
                    btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = btn_chuyenChiNhanh.Enabled = true;
                    btn_ghi.Enabled = btn_huy.Enabled = false;
                    nhanVienGridControl.Enabled = true;
                    txt_maNV.Enabled = true;
                    isSua = false;
                    MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bds_nhanVien.Position = bds_nhanVien.Find("MANV", maNV);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu không thành công vui lòng kiểm tra thông tin nhân viên!\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_phucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(undolist.Count > 0)
            {
                String statement = undolist.Pop().ToString();
                if (statement.Equals("DELETE"))
                {
                    String TT = undolist.Pop().ToString();
                    String[] TT_NV = TT.Split('#');

                    try
                    {
                        string lenh = "update[dbo].[NhanVien] set TrangThaiXoa = 0 where MANV = '" + TT_NV[0] + "'";
                        Program.ExecSqlNonQuery(lenh);
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                        bds_nhanVien.Position = bds_nhanVien.Find("MANV", TT_NV[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (statement.Equals("EDIT"))
                {
                    try
                    {
                        String TT = undolist.Pop().ToString();
                        String[] TT_NV = TT.Split('#');

                        string lenh = "update[dbo].[NhanVien] set HO= '" + TT_NV[1] + "',TEN= '" + TT_NV[2] +"',CMND= '" + TT_NV[3] + "',DIACHI= '" + TT_NV[4] + "',PHAI= '"
                                        + TT_NV[5] + "',SODT= '" + TT_NV[6] + "',MACN= '" + lb_maCN.Text.Trim() + "',TrangThaiXoa = 0 where MANV = '" + TT_NV[0] + "'";

                        Program.ExecSqlNonQuery(lenh);
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                        bds_nhanVien.Position = bds_nhanVien.Find("MANV", TT_NV[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (statement.Equals("INSERT"))
                {
                    String maNV = undolist.Pop().ToString();
                    int vitri = bds_nhanVien.Find("MANV", maNV);
                    bds_nhanVien.Position = vitri;
                    bds_nhanVien.RemoveCurrent();
                }
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);
            }
            if(undolist.Count == 0)
            {
                btn_phucHoi.Enabled = false;
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_nhanVien.RemoveCurrent();
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            groupControl_nhanVien.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = btn_chuyenChiNhanh.Enabled = true;
            btn_ghi.Enabled = btn_huy.Enabled = false;
            nhanVienGridControl.Enabled = true;
            txt_maNV.Enabled = true;
            if (Program.mGroup == "NGANHANG")
            {
                groupControl_chiNhanh.Enabled = true;
            }
        }

        private void btn_chuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                String macn;
                int trangThaiXoa = int.Parse(((DataRowView)bds_nhanVien[bds_nhanVien.Position])["TrangThaiXoa"].ToString());
                String manv = ((DataRowView)bds_nhanVien[bds_nhanVien.Position])["MANV"].ToString().Trim();
                if (manv.Equals(Program.username))
                {
                    MessageBox.Show("Không thể tự chuyển chi nhánh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (trangThaiXoa == 0)
                {
                    if (CN.Equals("BEN THANH"))
                    {
                        macn = "TANDINH";
                    }
                    else macn = "BENTHANH";
                    Console.WriteLine("macn   "+macn);
                    Console.WriteLine(manv);
                    //MessageBox.Show("Quá trình chuyển nhanh viên đang diễn ra vui lòng chờ trông giây lát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sql =
                               "EXEC [dbo].[SP_chuyenCN] " +
                               "@manv = N'" + manv + "' , @macngo = N'" + macn +
                               "' ";
                    Console.WriteLine(sql);
                    //String sql =
                    //           "EXEC [dbo].[SP_ChuyenCNSS] " +
                    //           "@manv = " + manv + " , @macngo = " + macn +
                    //           " ";
                    int x = Program.ExecSqlNonQuery(sql);
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);                  
                }
                else
                {
                    MessageBox.Show("Nhân viên hiện không có ở chi nhánh này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chuyển nhân viên thất bại!\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
