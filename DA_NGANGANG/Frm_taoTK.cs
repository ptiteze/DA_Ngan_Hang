using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_NGANGANG
{
    public partial class Frm_taoTK : Form
    {
        public Frm_taoTK()
        {
            InitializeComponent();
        }

        private void cmb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_nhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txt_login.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_login.Focus();
                return;
            }
            if (txt_pass.Text.Trim() == "")
            {
                MessageBox.Show("Password không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_pass.Focus();
                return;
            }
            if ((string)cmb_nhanVien.SelectedValue == "")
            {
                MessageBox.Show("Hiện không có nhân viên nào cần tạo tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_pass.Focus();
                return;
            }
            if (txt_pass.Text.Trim() != txt_confirm.Text.Trim())
            {
                MessageBox.Show("Confirm Password sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_confirm.Focus();
                return;
            }
            String login = txt_login.Text.Trim();
            String password = txt_pass.Text.Trim();
            String username = (string)cmb_nhanVien.SelectedValue;
            String role = "";

            if (Program.mGroup == "CHINHANH") role = "CHINHANH";
            else
            {
                role = "NGANHANG";
            }
            try
            {
                string strLenh = "DECLARE @return_value int " +
                            "EXEC @return_value = [dbo].[SP_TAOACCOUNT] " +
                            "@LGNAME= " + login + ", " +
                            "@PASS = " + password + ", " +
                            "@USERNAME = " + username + ", " +
                            "@ROLE = " + role + " " +
                            "SELECT 'Return Value' = @return_value";

                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                // Đọc và lấy 
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                if (result == 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo",
                    MessageBoxButtons.OK);
                    DataTable dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_NHANVIEN");
                    cmb_nhanVien.DataSource = dt;
                    cmb_nhanVien.DisplayMember = "HOTEN";
                    cmb_nhanVien.ValueMember = "MANV";
                    cmb_nhanVien.Refresh();
                    txt_login.Text = "";
                    txt_pass.Text = "";
                    txt_confirm.Text = "";
                    return;
                }
                else if (result == 1)
                {
                    MessageBox.Show("Login name này đã có người sử dụng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_login.Focus();
                    return;
                }
                else if (result == 2)
                {
                    MessageBox.Show("Người này đã có tài khoản!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmb_nhanVien.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi tài khoản\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Frm_taoTK_Load(object sender, EventArgs e)
        {           
            txt_nhom.Text = Program.mGroup;
            DataTable dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_NHANVIEN");
            cmb_chiNhanh.DataSource = Program.bds_dspm.DataSource;
            cmb_chiNhanh.DisplayMember = "TENCN";
            cmb_chiNhanh.ValueMember = "TENSERVER";
            cmb_nhanVien.DataSource = dt;
            cmb_nhanVien.DisplayMember = "HOTEN";
            cmb_nhanVien.ValueMember = "MANV";
            if (Program.mGroup.Equals("CHINHANH"))
            {
                cmb_chiNhanh.Enabled = false;
            }
            else
            {
                cmb_chiNhanh.Enabled = true;
            }
        }
    }
}
