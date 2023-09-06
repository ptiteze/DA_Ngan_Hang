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
    public partial class Frm_saoKe : Form
    {
        public Frm_saoKe()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_taiKhoan.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Frm_saoKe_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            if (Program.mGroup.Equals("USER"))
            {
                bds_taiKhoan.Filter = "CMND LIKE '" + Program.username +"'";
                taiKhoanGridControl.DataSource = bds_taiKhoan;
            }
            
            de_ngayBD.Text = DateTime.Now.ToString();
            de_ngayKT.Text = DateTime.Now.ToString();
            txt_soTK.Focus();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            string ngay1, ngay2, soTK;
            ngay1 = de_ngayBD.Text;
            ngay2 = de_ngayKT.Text;

            if (ngay1.Length == 0 || ngay2.Length == 0)
            {
                MessageBox.Show("Không được để trống ngày sao kê\n Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            soTK = txt_soTK.Text.Trim();
            int checkMaNV;
            checkMaNV = bds_taiKhoan.Find("SOTK", soTK);

            if (checkMaNV == -1)
            {
                MessageBox.Show("Không tồn tại tài khoản cần sao kê vui lòng kiểm tra lại thông tin!\n" + checkMaNV, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            rpt_saoKeTK rp = new rpt_saoKeTK(soTK, ngay1, ngay2);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
    }
}
