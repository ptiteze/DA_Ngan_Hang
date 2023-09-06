namespace DA_NGANGANG
{
    partial class Frm_saoKe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sOTKLabel;
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.bds_taiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DA_NGANGANG.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_preview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.de_ngayKT = new DevExpress.XtraEditors.DateEdit();
            this.de_ngayBD = new DevExpress.XtraEditors.DateEdit();
            this.txt_soTK = new DevExpress.XtraEditors.TextEdit();
            this.taiKhoanTableAdapter = new DA_NGANGANG.DSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new DA_NGANGANG.DSTableAdapters.TableAdapterManager();
            sOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_taiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(78, 55);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(55, 19);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "SOTK:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.taiKhoanGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1008, 370);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tài Khoản";
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.bds_taiKhoan;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanGridControl.Location = new System.Drawing.Point(2, 34);
            this.taiKhoanGridControl.MainView = this.gridView1;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(1004, 334);
            this.taiKhoanGridControl.TabIndex = 0;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bds_taiKhoan
            // 
            this.bds_taiKhoan.DataMember = "TaiKhoan";
            this.bds_taiKhoan.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.taiKhoanGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_preview);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.de_ngayKT);
            this.groupControl2.Controls.Add(this.de_ngayBD);
            this.groupControl2.Controls.Add(sOTKLabel);
            this.groupControl2.Controls.Add(this.txt_soTK);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 370);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1008, 148);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Tìm Kiếm";
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.LightGreen;
            this.btn_preview.Location = new System.Drawing.Point(469, 92);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(170, 44);
            this.btn_preview.TabIndex = 6;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày bắt đầu:";
            // 
            // de_ngayKT
            // 
            this.de_ngayKT.EditValue = null;
            this.de_ngayKT.Location = new System.Drawing.Point(796, 55);
            this.de_ngayKT.Name = "de_ngayKT";
            this.de_ngayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayKT.Size = new System.Drawing.Size(150, 26);
            this.de_ngayKT.TabIndex = 3;
            // 
            // de_ngayBD
            // 
            this.de_ngayBD.EditValue = null;
            this.de_ngayBD.Location = new System.Drawing.Point(479, 52);
            this.de_ngayBD.Name = "de_ngayBD";
            this.de_ngayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_ngayBD.Size = new System.Drawing.Size(150, 26);
            this.de_ngayBD.TabIndex = 2;
            // 
            // txt_soTK
            // 
            this.txt_soTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_taiKhoan, "SOTK", true));
            this.txt_soTK.Location = new System.Drawing.Point(139, 52);
            this.txt_soTK.Name = "txt_soTK";
            this.txt_soTK.Size = new System.Drawing.Size(150, 26);
            this.txt_soTK.TabIndex = 1;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = DA_NGANGANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Frm_saoKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 518);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_saoKe";
            this.Text = "Sao kê";
            this.Load += new System.EventHandler(this.Frm_saoKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_taiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_ngayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soTK.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DS dS;
        private System.Windows.Forms.BindingSource bds_taiKhoan;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit de_ngayKT;
        private DevExpress.XtraEditors.DateEdit de_ngayBD;
        private DevExpress.XtraEditors.TextEdit txt_soTK;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}