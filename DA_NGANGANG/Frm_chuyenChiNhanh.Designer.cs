namespace DA_NGANGANG
{
    partial class Frm_chuyenChiNhanh
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
            this.cmb_chuyenChiNhanh = new System.Windows.Forms.ComboBox();
            this.btn_chuyenChiNhanh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_chuyenChiNhanh
            // 
            this.cmb_chuyenChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chuyenChiNhanh.FormattingEnabled = true;
            this.cmb_chuyenChiNhanh.Location = new System.Drawing.Point(96, 79);
            this.cmb_chuyenChiNhanh.Name = "cmb_chuyenChiNhanh";
            this.cmb_chuyenChiNhanh.Size = new System.Drawing.Size(373, 27);
            this.cmb_chuyenChiNhanh.TabIndex = 1;
            this.cmb_chuyenChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_chuyenChiNhanh_SelectedIndexChanged);
            // 
            // btn_chuyenChiNhanh
            // 
            this.btn_chuyenChiNhanh.Location = new System.Drawing.Point(195, 201);
            this.btn_chuyenChiNhanh.Name = "btn_chuyenChiNhanh";
            this.btn_chuyenChiNhanh.Size = new System.Drawing.Size(167, 59);
            this.btn_chuyenChiNhanh.TabIndex = 2;
            this.btn_chuyenChiNhanh.Text = "Chuyển";
            this.btn_chuyenChiNhanh.UseVisualStyleBackColor = true;
            this.btn_chuyenChiNhanh.Click += new System.EventHandler(this.btn_chuyenChiNhanh_Click);
            // 
            // Frm_chuyenChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 374);
            this.Controls.Add(this.btn_chuyenChiNhanh);
            this.Controls.Add(this.cmb_chuyenChiNhanh);
            this.Name = "Frm_chuyenChiNhanh";
            this.Text = "Chuyển Chi Nhánh";
            this.Load += new System.EventHandler(this.Frm_chuyenChiNhanh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_chuyenChiNhanh;
        private System.Windows.Forms.Button btn_chuyenChiNhanh;
    }
}