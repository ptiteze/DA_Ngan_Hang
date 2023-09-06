using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DA_NGANGANG
{
    public partial class Frm_khachHang : Form
    {
        Boolean isSua = false;
        string KH_info = "";
        Stack undolist = new Stack();
        public Frm_khachHang()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_khachHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Frm_khachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            
            try
            {
                dS.EnforceConstraints = false;
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                //this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
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
                    btn_xoa.Enabled = false;
                }
                groupControl_khachHang.Enabled=false;
                btn_ghi.Enabled = btn_huy.Enabled = btn_phucHoi.Enabled = false;
                if (bds_khachHang.Count == 0)
                {
                    btn_xoa.Enabled = false;
                }
            } catch {
                MessageBox.Show("Tải dữ liệu không thành công!\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }         
        }

        private void groupControl_chiNhanh_Paint(object sender, PaintEventArgs e)
        {

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

                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
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
            bds_khachHang.AddNew();
            if (cmb_chiNhanh.SelectedValue.ToString() == "DESKTOP-LL3CDGR\\MSSQLSERVER01")
                txt_maCN.Text = "BENTHANH";
            else txt_maCN.Text = "TANDINH";
            cmb_phai.SelectedIndex = 1;
            cmb_phai.SelectedIndex = 0;
            de_ngayCap.EditValue = DateTime.Now.ToString("MM/dd/yyyy");
            khachHangGridControl.Enabled = false;
            groupControl_khachHang.Enabled = true;
            txt_CMND.Focus();
        }

        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isSua = true;
            txt_CMND.Enabled = false;
            groupControl_khachHang.Enabled = true;
            groupControl_chiNhanh.Enabled = false;
            khachHangGridControl.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = false;
            btn_ghi.Enabled = btn_huy.Enabled = true;
            KH_info = txt_CMND.Text.Trim() + "#" + txt_ho.Text.Trim() + "#" + txt_ten.Text.Trim() + "#" +
                  txt_diaChi.Text.Trim() + "#" + cmb_phai.SelectedItem.ToString() + "#" + de_ngayCap.Text.ToString() +
                  "#" + txt_soDT.Text.Trim() + "#" +txt_maCN.Text;
            Console.WriteLine(KH_info);
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                string cmnd = txt_CMND.Text.ToString().Trim();
                string strLenh = "DECLARE @return_value int " +
                              "EXEC @return_value = [dbo].[SP_CHECKCUSHAVEACCOUNTS] " +
                              "@CMND=" + cmnd + " " +
                              "SELECT 'Return Value' = @return_value";

                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                // Đọc và lấy 
                dataReader.Read();
                int result = dataReader.GetInt32(0);
                dataReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Không thể xóa người dùng!" + result, "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        cmnd = ((DataRowView)bds_khachHang[bds_khachHang.Position])["CMND"].ToString();
                        String info = txt_CMND.Text.Trim() + "#" + txt_ho.Text.Trim() + "#" + txt_ten.Text.Trim() + "#" +
                            txt_diaChi.Text.Trim() + "#" + cmb_phai.SelectedItem.ToString() + "#" + de_ngayCap.Text + "#" + txt_soDT.Text.Trim()
                            + "#" +txt_maCN.Text;

                        bds_khachHang.RemoveCurrent();
                        this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khachHangTableAdapter.Update(this.dS.KhachHang);
                        btn_phucHoi.Enabled = true;
                        undolist.Push(info);
                        undolist.Push("DELETE");
                        this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa khách hàng. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                        bds_khachHang.Position = bds_khachHang.Find("CMND", cmnd);
                        return;
                    }
                }
                if (bds_khachHang.Count == 0)
                    btn_xoa.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi xóa khách hàng. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
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
                    try
                    {
                        this.bds_khachHang.AddNew();
                        String TT = undolist.Pop().ToString();
                        String[] TT_KH = TT.Split('#');
                        txt_CMND.Text = TT_KH[0];
                        txt_ho.Text = TT_KH[1];
                        txt_ten.Text = TT_KH[2];
                        txt_diaChi.Text = TT_KH[3];
                        cmb_phai.Text = TT_KH[4];
                        de_ngayCap.Text = TT_KH[5];
                        txt_soDT.Text = TT_KH[6];
                        txt_maCN.Text = TT_KH[7];

                        this.bds_khachHang.EndEdit();
                        this.khachHangTableAdapter.Update(this.dS.KhachHang);
                        bds_khachHang.Position = bds_khachHang.Find("CMND", TT_KH[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if(statement.Equals("EDIT"))
                {
                    try {
                        String TT = undolist.Pop().ToString();
                        String[] TT_KH = TT.Split('#');
                        string lenh = "update[dbo].[KhachHang] set HO= '" + TT_KH[1] + "',TEN= '" + TT_KH[2] + "',DIACHI= '" + TT_KH[3] + "',PHAI= '"
                                            + TT_KH[4] + "', NGAYCAP= '" + TT_KH[5] + "',SODT= '" + TT_KH[6] + "',MACN= '" + TT_KH[7]
                                            + "' where CMND = '" + TT_KH[0] + "'";

                        Program.ExecSqlNonQuery(lenh);
                        this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                        bds_khachHang.Position = bds_khachHang.Find("CMND", TT_KH[0]);
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                }else if (statement.Equals("INSERT"))
                {
                    String cmnd = undolist.Pop().ToString();
                    int vitri = bds_khachHang.Find("CMND", cmnd);
                    bds_khachHang.Position = vitri;
                    bds_khachHang.RemoveCurrent();
                }
                this.khachHangTableAdapter.Update(this.dS.KhachHang);
            }
            if (undolist.Count == 0) btn_phucHoi.Enabled = false;
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_khachHang.RemoveCurrent();
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            txt_CMND.Enabled = true;
            groupControl_khachHang.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = true;
            btn_ghi.Enabled = btn_huy.Enabled = false;
            khachHangGridControl.Enabled = true;
            isSua = false;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_ghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cmndPattern = "\\d{10}";
            if (txt_CMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("CMND không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_CMND.Focus();
                return;
            }
            if (!Regex.IsMatch(txt_CMND.Text.Trim(), cmndPattern) || txt_CMND.Text.Trim().Length != 10 )
            {
                MessageBox.Show("Nhập sai định dạng CMND!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_CMND.Focus();
                return;
            }
            String hoten = "[a-zA-Z]";
            if (txt_ho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ khách hàng không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ho.Focus();
                return;
            }
            if (!Regex.IsMatch(txt_ho.Text.Trim(), hoten))
            {
                MessageBox.Show("Nhập sai định dạng họ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ho.Focus();
                return;
            }
            if (txt_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên khách hàng không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Địa chỉ không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diaChi.Focus();
                return;
            }
            if (de_ngayCap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ngày cấp không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                de_ngayCap.Focus();
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
            try {
                String cmnd = txt_CMND.Text.Trim();
                if (!isSua)
                {                 
                    string strLenh = "DECLARE @return_value int " +
                                "EXEC @return_value = [dbo].[SP_CHECKKHEXISTS] " +
                                "@CMND=" + cmnd + " " +
                                "SELECT 'Return Value' = @return_value";

                    SqlDataReader dataReader = null;
                    dataReader = Program.ExecSqlDataReader(strLenh);
                    // Đọc và lấy 
                    dataReader.Read();
                    int result = dataReader.GetInt32(0);
                    dataReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Khách hàng này đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_CMND.Focus();
                        return;
                    }

                }
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                {
                    if (!isSua)
                    {
                        String lgname = "KH" + cmnd;
                        btn_phucHoi.Enabled = true;
                        undolist.Push(cmnd);
                        undolist.Push("INSERT");
                        string strLenh = "EXEC [SP_TAOACCOUNT] " +
                                "@LGNAME = " + lgname + " , @PASS = " +
                                cmnd + ", @USERNAME = " + cmnd + " , @ROLE = 'USER' ";
                        Program.ExecSqlNonQuery(strLenh);
                    }
                    else
                    {
                        btn_phucHoi.Enabled = true;
                        undolist.Push(KH_info);
                        undolist.Push("EDIT");
                        txt_CMND.Enabled = true;
                    }
                    bds_khachHang.EndEdit();
                    this.khachHangTableAdapter.Update(this.dS.KhachHang);
                    this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                    groupControl_khachHang.Enabled = false;
                    btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = btn_reload.Enabled = true;
                    btn_ghi.Enabled = btn_huy.Enabled = false;
                    khachHangGridControl.Enabled = true;
                    isSua = false;
                    bds_khachHang.Position = bds_khachHang.Find("CMND", cmnd);
                }
                if (Program.mGroup.Equals("NGANHANG"))
                {
                    groupControl_chiNhanh.Enabled = true;
                }

            }
            catch 
            {
                MessageBox.Show("Lỗi ghi khách hàng\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void khachHangGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
