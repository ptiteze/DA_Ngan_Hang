using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DA_NGANGANG
{
    public partial class rpt_thongKeKH : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_thongKeKH(int type)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = type;
            this.sqlDataSource1.Fill();
            lb_ngaySaoKe.Text = DateTime.Now.ToString();
            if (Program.mCoso == 0)
                lb_chiNhanh.Text = "Bến Thành";
            else if (Program.mCoso == 1)
                lb_chiNhanh.Text = "Tân Định";
        }

    }
}
