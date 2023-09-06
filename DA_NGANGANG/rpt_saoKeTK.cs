using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA_NGANGANG
{
    public partial class rpt_saoKeTK : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_saoKeTK(string sotk, string ngay1, string ngay2)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = sotk;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngay1;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ngay2;
            this.sqlDataSource1.Queries[1].Parameters[0].Value = sotk;
            this.sqlDataSource1.Fill();
            try
            {
                BindingSource bds = new BindingSource();
                bds.DataSource = this.sqlDataSource1.Queries[0];
                var parsedDate1 = DateTime.Parse(ngay1);
                var parsedDate2 = DateTime.Parse(ngay2);
                Console.WriteLine(parsedDate1.ToString());
                String sql = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_ThongTinChuTK] " +
                               "@SOTK = " + sotk + " " +
                               "SELECT 'Return Value' = @return_value";
                String sql2 = "EXEC [dbo].[SP_SAOKETAIKHOAN] @soTK = '" + sotk +
                                "', @from = N'" + parsedDate1 + "' , @to = N'" + parsedDate2 + " ' ";
                DataTable dt = Program.ExecSqlDataTable(sql2);
                SqlDataReader myRender = Program.ExecSqlDataReader(sql);
                myRender.Read();
                lb_ngaySaoKe.Text = DateTime.Now.ToString();
                lb_tenKH.Text = myRender.GetString(0);
                lb_soTK.Text = myRender.GetString(2);
                lb_diaChi.Text = myRender.GetString(1);
                lb_ngayBD.Text = ngay1;
                lb_ngayKT.Text = ngay2;
                lb_chiNhanh.Text = myRender.GetString(3);
                lb_tienBD.Text = dt.Rows[0][3].ToString();
                lb_tienKT.Text = dt.Rows[dt.Rows.Count - 1][4].ToString();
                //lb_tienKT.Text = ((DataRowView)bds[0])["SODUDAU"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu không thành công vui lòng kiểm tra thông tin nhân viên!\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
