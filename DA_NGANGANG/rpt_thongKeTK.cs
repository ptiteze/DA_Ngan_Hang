using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DA_NGANGANG
{
    public partial class rpt_thongKeTK : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_thongKeTK(int type, string cn, string ngay1, string ngay2)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = type;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngay1;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ngay2;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = cn;
            this.sqlDataSource1.Fill();
            lb_ngayBD.Text = ngay1;
            lb_ngayKT.Text = ngay2;
            lb_ngaySaoKe.Text = DateTime.Now.ToString();
            if (Program.mCoso == 0)
                lb_chiNhanh.Text = "Bến Thành";
            else if (Program.mCoso == 1)
                lb_chiNhanh.Text = "Tân Định";
        }

    }
}
