using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DA_NGANGANG
{
    public partial class Frm_goiRut : Form
    {
        public Frm_goiRut()
        {
            InitializeComponent();
        }

        private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_goiRut.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Frm_goiRut_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
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

            cmb_loaiGD.Items.Add("GT");
            cmb_loaiGD.Items.Add("RT");

            txt_maNV.Text = Program.username;
            de_ngayGD.EditValue = DateTime.Now;
            de_ngayGD.Enabled = false;

            groupControl_goiRut.Enabled = false;
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_them.Enabled = btn_reload.Enabled = false;
            bds_goiRut.AddNew();
            cmb_loaiGD.SelectedIndex = 1;
            cmb_loaiGD.SelectedIndex = 0;
            de_ngayGD.EditValue = DateTime.Today;
            groupControl_goiRut.Enabled = true;
            txt_maNV.Text = Program.username;
            groupControl_chiNhanh.Enabled = false;
            gD_GOIRUTGridControl.Enabled = false;
            txt_soTK.Focus();
            
        }

        private void cmb_loaiGD_SelectedIndexChanged(object sender, EventArgs e)
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
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            bds_goiRut.RemoveCurrent();
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            groupControl_goiRut.Enabled = false;
            btn_them.Enabled = btn_reload.Enabled = true;
            gD_GOIRUTGridControl.Enabled = true;
            txt_kiemTra.Text = "";
            if (Program.mGroup.Equals("NGANHANG"))
            {
                groupControl_chiNhanh.Enabled = true;
            }
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            if (txt_soTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tài khoản không được trống!", "Lỗi", MessageBoxButtons.OK);
                txt_soTK.Focus();
                return;
            }
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
            //try
            //{                
                if (cmb_loaiGD.Text.Equals("RT"))
                {
                    SqlDataReader dataReader = null;
                    string strCheckSoDu = "DECLARE	@return_value int " +
                                          "EXEC @return_value = [dbo].[SP_CHECKSODU] " +
                                            "@SOTIEN = " + sp_soTien.Text.Trim() + "," +
                                            "@SOTK = N'" + txt_soTK.Text.Trim() + "' " +
                                            "SELECT 'Return Value' = @return_value";
                    dataReader = Program.ExecSqlDataReader(strCheckSoDu);
                    // Đọc và lấy 
                    dataReader.Read();
                    int resultSodu = dataReader.GetInt32(0);
                    dataReader.Close();
                    if (resultSodu == 1)
                    {
                        MessageBox.Show("Tài khoản không tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_soTK.Focus();
                        return;
                    }
                    else if (resultSodu == 2)
                    {
                        MessageBox.Show("Số dư không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        sp_soTien.Focus();
                        return;
                    }
                }               
                string strLenh = "DECLARE @return_value int " +
                                    "EXEC @return_value = [dbo].[SP_GDGOIRUT] " +
                                    "@SOTIEN = " + sp_soTien.Text.Trim() + "," +
                                     "@TYPE = " + cmb_loaiGD.Text + "," +
                                     "@SOTK = N'" + txt_soTK.Text.Trim() + "' " +
                                    "SELECT 'Return Value' = @return_value";

                int result = Program.ExecSqlNonQuery(strLenh);

                if (result != 0)
                {
                    MessageBox.Show("Số tài khoản không tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (result == 0)
                {                                                           
                        //cmb_loaiGD.Text = loaiGD;
                        bds_goiRut.EndEdit();
                        //this.gD_GOIRUTTableAdapter.Update(this.dS.GD_GOIRUT);
                        this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
                        groupControl_goiRut.Enabled = false;
                        btn_them.Enabled = btn_reload.Enabled = true;
                        gD_GOIRUTGridControl.Enabled = true;
                    txt_kiemTra.Text = "";
                    MessageBox.Show("Giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                              
                }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Lỗi ghi phiên giao dịch\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            //}
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
                txt_maNV.Text = Program.username;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void groupControl_goiRut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_kiemTra_Click(object sender, EventArgs e)
        {
            if (txt_soTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số tài khoản không được trống!", "Lỗi", MessageBoxButtons.OK);
                txt_soTK.Focus();
                return;
            }
            try
            {
                String ten = "";
                String query = "EXEC [dbo].[SP_ThongTinChuTK] " +
                           "@SOTK = " + txt_soTK.Text.Trim() + " ";
                SqlDataReader myRender = Program.ExecSqlDataReader(query);
                if(myRender!=null) {
                    myRender.Read();
                    ten = myRender.GetString(0);
                    txt_kiemTra.Text = ten;
                }
                else
                {
                    txt_kiemTra.Text = "";
                }
                
                //DialogResult dr = MessageBox.Show("Xác nhận chuyển tiền cho \n Khách Hàng: " + ten
                //    + " - " + txt_soTK.Text.Trim(), "Thông báo",
                //  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            catch
            {
                txt_kiemTra.Text = "";
                MessageBox.Show("Không thể truy xuất tài khoản!", "Lỗi", MessageBoxButtons.OK);
            }
        }
    }
}
