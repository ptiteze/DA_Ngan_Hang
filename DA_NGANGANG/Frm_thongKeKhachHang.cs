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
    public partial class Frm_thongKeKhachHang : Form
    {
        int type=0;
        public Frm_thongKeKhachHang()
        {
            InitializeComponent();
        }

        private void Frm_thongKeKhachHang_Load(object sender, EventArgs e)
        {
            cmb_chiNhanh.DataSource = Program.bds_dspm;
            cmb_chiNhanh.DisplayMember = "TENCN";
            cmb_chiNhanh.ValueMember = "TENSERVER";
            cmb_chiNhanh.SelectedIndex = Program.mCoso;
            if (Program.mGroup.Equals("CHINHANH"))
            {
                cmb_chiNhanh.Enabled = false;
                btn_PreviewAll.Enabled = false;
            }
            else
            {
                cmb_chiNhanh.Enabled = true;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            rpt_thongKeKH rp = new rpt_thongKeKH(type);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void cmb_maCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_chiNhanh.SelectedIndex==Program.mCoso)
            {
                type = 0;
            }
            else
            {
                type = 1;
            }
        }

        private void btn_PreviewAll_Click(object sender, EventArgs e)
        {
            rpt_thongKeKH rp = new rpt_thongKeKH(2);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
    }
}
