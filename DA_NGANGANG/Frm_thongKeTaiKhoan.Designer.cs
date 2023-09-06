namespace DA_NGANGANG
{
    partial class Frm_thongKeTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.de_ngayKT = new DevExpress.XtraEditors.DateEdit();
            this.de_ngayBD = new DevExpress.XtraEditors.DateEdit();
            this.cmb_maCN = new System.Windows.Forms.ComboBox();
            this.btn_previewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.btn_previewAll);
            this.groupControl1.Controls.Add(this.btn_Preview);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.de_ngayKT);
            this.groupControl1.Controls.Add(this.de_ngayBD);
            this.groupControl1.Controls.Add(this.cmb_maCN);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(835, 498);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thống kế Tài khoản mở trong khoảng thời gian thuộc cơ sở";
            // 
            // btn_Preview
            // 
            this.btn_Preview.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Preview.Location = new System.Drawing.Point(293, 322);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(195, 39);
            this.btn_Preview.TabIndex = 13;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = false;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(440, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Kết Thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(440, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày Bắt Đầu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(43, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHI NHÁNH";
            // 
            // de_ngayKT
            // 
            this.de_ngayKT.EditValue = null;
            this.de_ngayKT.Location = new System.Drawing.Point(564, 193);
            this.de_ngayKT.Name = "de_ngayKT";
            this.de_ngayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayKT.Size = new System.Drawing.Size(150, 26);
            this.de_ngayKT.TabIndex = 2;
            // 
            // de_ngayBD
            // 
            this.de_ngayBD.EditValue = null;
            this.de_ngayBD.Location = new System.Drawing.Point(564, 83);
            this.de_ngayBD.Name = "de_ngayBD";
            this.de_ngayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayBD.Size = new System.Drawing.Size(150, 26);
            this.de_ngayBD.TabIndex = 1;
            // 
            // cmb_maCN
            // 
            this.cmb_maCN.FormattingEnabled = true;
            this.cmb_maCN.Location = new System.Drawing.Point(185, 127);
            this.cmb_maCN.Name = "cmb_maCN";
            this.cmb_maCN.Size = new System.Drawing.Size(190, 27);
            this.cmb_maCN.TabIndex = 0;
            this.cmb_maCN.SelectedIndexChanged += new System.EventHandler(this.cmb_maCN_SelectedIndexChanged);
            // 
            // btn_previewAll
            // 
            this.btn_previewAll.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_previewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previewAll.Location = new System.Drawing.Point(293, 398);
            this.btn_previewAll.Name = "btn_previewAll";
            this.btn_previewAll.Size = new System.Drawing.Size(195, 39);
            this.btn_previewAll.TabIndex = 14;
            this.btn_previewAll.Text = "Preview All";
            this.btn_previewAll.UseVisualStyleBackColor = false;
            this.btn_previewAll.Click += new System.EventHandler(this.btn_previewAll_Click);
            // 
            // Frm_thongKeTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 498);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_thongKeTaiKhoan";
            this.Text = "Thống Kê Tài Khoản";
            this.Load += new System.EventHandler(this.Frm_thongKeTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit de_ngayKT;
        private DevExpress.XtraEditors.DateEdit de_ngayBD;
        private System.Windows.Forms.ComboBox cmb_maCN;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_previewAll;
    }
}