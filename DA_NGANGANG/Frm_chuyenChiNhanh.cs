using Microsoft.Data.SqlClient;
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
    public partial class Frm_chuyenChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public Frm_chuyenChiNhanh()
        {
            InitializeComponent();
        }

        private void Frm_chuyenChiNhanh_Load(object sender, EventArgs e)
        {
            cmb_chuyenChiNhanh.DataSource = Program.bds_dspm;
            cmb_chuyenChiNhanh.DisplayMember = "TENCN";
            cmb_chuyenChiNhanh.ValueMember = "TENSERVER";
            cmb_chuyenChiNhanh.SelectedIndex = Program.mCoso;
        }

        private void cmb_chuyenChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_chuyenChiNhanh_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_chuyenChiNhanh.Text.Trim().Equals("TRA CUU"))
                {
                    cmb_chuyenChiNhanh.Focus();
                    MessageBox.Show("Không thể chọn Chi Nhánh Này \n Bạn xem lại", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    String macn = "";
                    if (cmb_chuyenChiNhanh.Text.Trim().Equals("BEN THANH"))
                    {
                        macn = "BENTHANH";
                    }
                    else macn = "TANDINH";
                    Console.WriteLine(macn);  
                    Console.WriteLine(Program.username);
                    MessageBox.Show("Quá trình chuyển nhanh viên đang diễn ra vui lòng chờ trông giây lát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String sql = 
                               "EXEC [dbo].[SP_ChuyenCN] " +
                               "@manv = '" + Program.username + "' , @macngo = '"+ macn +
                               "' ";
                    int x = Program.ExecSqlNonQuery(sql);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "" + "", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
