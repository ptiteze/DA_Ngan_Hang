using System;
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
    public partial class Frm_chuyenTien : Form
    {
        public Frm_chuyenTien()
        {
            InitializeComponent();
        }

        private void gD_CHUYENTIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_chuyenTien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Frm_chuyenTien_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
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
            }
            txt_maNV.Text = Program.username;
            de_ngayGD.EditValue = DateTime.Now;
            de_ngayGD.Enabled = false;

            groupControl_chuyenTien.Enabled = false;
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
                txt_maNV.Text = Program.username;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            bds_chuyenTien.RemoveCurrent();
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
            groupControl_chuyenTien.Enabled = false;
            btn_them.Enabled = btn_reload.Enabled = true;
            gD_CHUYENTIENGridControl.Enabled = true;
            if (Program.mGroup.Equals("NGANHANG"))
            {
                groupControl_chiNhanh.Enabled = true;
            }
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_them.Enabled = btn_reload.Enabled = false;
            bds_chuyenTien.AddNew();
            de_ngayGD.EditValue = DateTime.Today;
            txt_maNV.Text = Program.username;
            groupControl_chiNhanh.Enabled = false;
            groupControl_chuyenTien.Enabled = true;
            gD_CHUYENTIENGridControl.Enabled = false;
            txt_soTKChuyen.Focus();
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
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);               
            }
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            if (sp_soTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tiền không được trống!", "Lỗi", MessageBoxButtons.OK);
                sp_soTien.Focus();
                return;
            }
            int sotien = int.Parse(sp_soTien.Text);
            if (sotien < 100000)
            {
                MessageBox.Show("Số tiền giao dịch tối thiểu 100000!", "Lỗi", MessageBoxButtons.OK);
                sp_soTien.Focus();
                return;
            }
            if (txt_soTKChuyen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tài khoản chuyển không được trống!", "Lỗi", MessageBoxButtons.OK);
                txt_soTKChuyen.Focus();
                return;
            }
            if (txt_soTKNhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tài khoản nhận không được trống!", "Lỗi", MessageBoxButtons.OK);
                txt_soTKNhan.Focus();
                return;
            }
            String stkPattern = "\\w";
            if (!Regex.IsMatch(txt_soTKChuyen.Text.Trim(), stkPattern) || txt_soTKChuyen.Text.Trim().Length > 9)
            {
                MessageBox.Show("Nhập sai định dạng số tài khoản chuyển!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soTKChuyen.Focus();
                return;
            }
            if (!Regex.IsMatch(txt_soTKNhan.Text.Trim(), stkPattern) || txt_soTKNhan.Text.Trim().Length > 9)
            {
                MessageBox.Show("Nhập sai định dạng số tài khoản nhận!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soTKNhan.Focus();
                return;
            }
            if (txt_soTKChuyen.Text.Equals(txt_soTKNhan.Text))
            {
                MessageBox.Show("Tài khoản không được trùng nhau !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soTKNhan.Focus();
                return;
            }
            try
            {
                SqlDataReader dataReader = null;
                string strCheckSoDu = "DECLARE	@return_value int " +
                                          "EXEC @return_value = [dbo].[SP_CHECKSODU] " +
                                            "@SOTIEN = " + sp_soTien.Text.Trim() + "," +
                                            "@SOTK = N'" + txt_soTKChuyen.Text.Trim() + "' " +
                                            "SELECT 'Return Value' = @return_value";
                dataReader = Program.ExecSqlDataReader(strCheckSoDu);
                // Đọc và lấy 
                dataReader.Read();
                int resultSodu = dataReader.GetInt32(0);
                dataReader.Close();
                if (resultSodu == 1)
                {
                    MessageBox.Show("Tài khoản chuyển tiền không tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_soTKChuyen.Focus();
                    return;
                }
                else if (resultSodu == 2)
                {
                    MessageBox.Show("Số dư không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sp_soTien.Focus();
                    return;
                }
                dataReader = null;
                string sql = "exec [dbo].[SP_GDCHUYENTIEN] '" + txt_soTKChuyen.Text.Trim() + "' , '" + sp_soTien.Value + "' , '" + txt_soTKNhan.Text.Trim() + "'";
                int result = 5;
                Console.WriteLine(result);
                dataReader = Program.ExecSqlDataReader(sql);
                dataReader.Read();
                result = dataReader.GetInt32(0);
                Console.WriteLine(result);
                if (result == 1)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin tài khoản chuyển và nhận!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bds_chuyenTien.RemoveCurrent();
                    this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
                    groupControl_chuyenTien.Enabled = false;
                    btn_them.Enabled = btn_reload.Enabled = true;
                    gD_CHUYENTIENGridControl.Enabled = true;
                    if (Program.mGroup.Equals("NGANHANG"))
                    {
                        groupControl_chiNhanh.Enabled = true;
                    }
                    return;
                }
                MessageBox.Show("Giao dịch thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bds_chuyenTien.EndEdit();
                //this.gD_CHUYENTIENTableAdapter.Update(this.dS.GD_CHUYENTIEN);
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
                groupControl_chuyenTien.Enabled = false;
                btn_them.Enabled = true;
                gD_CHUYENTIENGridControl.Enabled = true;
                if (Program.mGroup.Equals("NGANHANG"))
                {
                    groupControl_chiNhanh.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giao dịch không thành công!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
}

        private void btn_check1_Click(object sender, EventArgs e)
        {
            if (txt_soTKChuyen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tài khoản không được trống!", "Lỗi", MessageBoxButtons.OK);
                txt_ktTKChuyen.Focus();
                return;
            }
            try
            {
                String ten = "";
                String query = "EXEC [dbo].[SP_ThongTinChuTK] " +
                           "@SOTK = " + txt_soTKChuyen.Text.Trim() + " ";
                SqlDataReader myRender = Program.ExecSqlDataReader(query);
                if (myRender != null)
                {
                    myRender.Read();
                    ten = myRender.GetString(0);
                    txt_ktTKChuyen.Text = ten;
                }
                else
                {
                    txt_ktTKChuyen.Text = "";
                }
            }
            catch
            {
                txt_ktTKChuyen.Text = "";
                MessageBox.Show("Lỗi truy xuất SQL !", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btn_check2_Click(object sender, EventArgs e)
        {
            if (txt_soTKNhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tài khoản không được trống!", "Lỗi", MessageBoxButtons.OK);
                txt_ktTKChuyen.Focus();
                return;
            }
            try
            {
                String ten = "";
                String query = "EXEC [dbo].[SP_ThongTinChuTK] " +
                           "@SOTK = " + txt_soTKNhan.Text.Trim() + " ";
                SqlDataReader myRender = Program.ExecSqlDataReader(query);
                if (myRender != null)
                {
                    myRender.Read();
                    ten = myRender.GetString(0);
                    txt_ktTKNhan.Text = ten;
                }
                else
                {
                    txt_ktTKNhan.Text = "";
                }
            }
            catch
            {
                txt_ktTKNhan.Text = "";
                MessageBox.Show("Lỗi truy xuất SQL !", "Lỗi", MessageBoxButtons.OK);
            }
        }
    }
}
