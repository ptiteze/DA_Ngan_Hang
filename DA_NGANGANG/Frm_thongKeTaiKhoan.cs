using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraReports.UI;
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
    public partial class Frm_thongKeTaiKhoan : Form
    {
        string cn;
        public Frm_thongKeTaiKhoan()
        {
            InitializeComponent();
        }

        private void Frm_thongKeTaiKhoan_Load(object sender, EventArgs e)
        {
           
            cmb_maCN.DataSource = Program.bds_dspm;
            cmb_maCN.DisplayMember = "TENCN";
            cmb_maCN.ValueMember = "TENSERVER";
            cmb_maCN.SelectedIndex = Program.mCoso;
            if (cmb_maCN.SelectedValue.ToString().Contains("DESKTOP-LL3CDGR\\MSSQLSERVER01"))
            {
                cn = "BENTHANH";
            }
            else
            {
                cn = "TANDINH";
            }
            de_ngayBD.Text = DateTime.Now.ToString();
            de_ngayKT.Text = DateTime.Now.ToString();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string ngay1, ngay2;
            ngay1 = de_ngayBD.Text;
            ngay2 = de_ngayKT.Text;

            if (ngay1.Length == 0 || ngay2.Length == 0)
            {
                MessageBox.Show("Không được để trống ngày chọn liệt kê\n Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parsedDate1 = DateTime.Parse(ngay1);
            var parsedDate2 = DateTime.Parse(ngay2);

            int result = DateTime.Compare(parsedDate1, parsedDate2);

            if (result > 0)
            {
                MessageBox.Show("Ngày không hợp lệ!\n Vui lòng chọn lại ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            rpt_thongKeTK rp = new rpt_thongKeTK(0,cn, ngay1, ngay2);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btn_previewAll_Click(object sender, EventArgs e)
        {
            string ngay1, ngay2;
            ngay1 = de_ngayBD.Text;
            ngay2 = de_ngayKT.Text;

            if (ngay1.Length == 0 || ngay2.Length == 0)
            {
                MessageBox.Show("Không được để trống ngày chọn liệt kê\n Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parsedDate1 = DateTime.Parse(ngay1);
            var parsedDate2 = DateTime.Parse(ngay2);

            int result = DateTime.Compare(parsedDate1, parsedDate2);

            if (result > 0)
            {
                MessageBox.Show("Ngày không hợp lệ!\n Vui lòng chọn lại ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            rpt_thongKeTK rp = new rpt_thongKeTK(1, cn, ngay1, ngay2);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void cmb_maCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_maCN.SelectedValue.ToString().Contains("DESKTOP-LL3CDGR\\MSSQLSERVER01"))
            {
                cn = "BENTHANH";
            }
            else
            {
                cn = "TANDINH";
            }
        }
    }
}
