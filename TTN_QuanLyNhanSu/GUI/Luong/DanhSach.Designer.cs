namespace TTN_QuanLyNhanSu.GUI.Luong
{
    partial class DanhSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.luongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luongTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.LuongTableAdapter();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soQuyetDinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHieuLucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongNgayCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congLamThemGioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thueThuNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongLuongNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 526);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.soQuyetDinhDataGridViewTextBoxColumn,
            this.ngayKiDataGridViewTextBoxColumn,
            this.ngayHieuLucDataGridViewTextBoxColumn,
            this.mucLuongDataGridViewTextBoxColumn,
            this.heSoDataGridViewTextBoxColumn,
            this.tongNgayCongDataGridViewTextBoxColumn,
            this.congLamThemGioDataGridViewTextBoxColumn,
            this.phuCapDataGridViewTextBoxColumn,
            this.thueThuNhapDataGridViewTextBoxColumn,
            this.tongLuongNhanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.luongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1059, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // luongBindingSource
            // 
            this.luongBindingSource.DataMember = "Luong";
            this.luongBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // luongTableAdapter
            // 
            this.luongTableAdapter.ClearBeforeFill = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 70;
            // 
            // soQuyetDinhDataGridViewTextBoxColumn
            // 
            this.soQuyetDinhDataGridViewTextBoxColumn.DataPropertyName = "SoQuyetDinh";
            this.soQuyetDinhDataGridViewTextBoxColumn.HeaderText = "Số Quyết Định";
            this.soQuyetDinhDataGridViewTextBoxColumn.Name = "soQuyetDinhDataGridViewTextBoxColumn";
            this.soQuyetDinhDataGridViewTextBoxColumn.Width = 110;
            // 
            // ngayKiDataGridViewTextBoxColumn
            // 
            this.ngayKiDataGridViewTextBoxColumn.DataPropertyName = "NgayKi";
            this.ngayKiDataGridViewTextBoxColumn.HeaderText = "Ngày Kí";
            this.ngayKiDataGridViewTextBoxColumn.Name = "ngayKiDataGridViewTextBoxColumn";
            this.ngayKiDataGridViewTextBoxColumn.Width = 80;
            // 
            // ngayHieuLucDataGridViewTextBoxColumn
            // 
            this.ngayHieuLucDataGridViewTextBoxColumn.DataPropertyName = "NgayHieuLuc";
            this.ngayHieuLucDataGridViewTextBoxColumn.HeaderText = "Ngày Hiệu Lực";
            this.ngayHieuLucDataGridViewTextBoxColumn.Name = "ngayHieuLucDataGridViewTextBoxColumn";
            this.ngayHieuLucDataGridViewTextBoxColumn.Width = 110;
            // 
            // mucLuongDataGridViewTextBoxColumn
            // 
            this.mucLuongDataGridViewTextBoxColumn.DataPropertyName = "MucLuong";
            this.mucLuongDataGridViewTextBoxColumn.HeaderText = "Mức Lương";
            this.mucLuongDataGridViewTextBoxColumn.Name = "mucLuongDataGridViewTextBoxColumn";
            // 
            // heSoDataGridViewTextBoxColumn
            // 
            this.heSoDataGridViewTextBoxColumn.DataPropertyName = "HeSo";
            this.heSoDataGridViewTextBoxColumn.HeaderText = "Hệ Số";
            this.heSoDataGridViewTextBoxColumn.Name = "heSoDataGridViewTextBoxColumn";
            this.heSoDataGridViewTextBoxColumn.Width = 60;
            // 
            // tongNgayCongDataGridViewTextBoxColumn
            // 
            this.tongNgayCongDataGridViewTextBoxColumn.DataPropertyName = "TongNgayCong";
            this.tongNgayCongDataGridViewTextBoxColumn.HeaderText = "Ngày Công";
            this.tongNgayCongDataGridViewTextBoxColumn.Name = "tongNgayCongDataGridViewTextBoxColumn";
            this.tongNgayCongDataGridViewTextBoxColumn.Width = 85;
            // 
            // congLamThemGioDataGridViewTextBoxColumn
            // 
            this.congLamThemGioDataGridViewTextBoxColumn.DataPropertyName = "CongLamThemGio";
            this.congLamThemGioDataGridViewTextBoxColumn.HeaderText = "Công Làm Thêm";
            this.congLamThemGioDataGridViewTextBoxColumn.Name = "congLamThemGioDataGridViewTextBoxColumn";
            this.congLamThemGioDataGridViewTextBoxColumn.Width = 110;
            // 
            // phuCapDataGridViewTextBoxColumn
            // 
            this.phuCapDataGridViewTextBoxColumn.DataPropertyName = "PhuCap";
            this.phuCapDataGridViewTextBoxColumn.HeaderText = "Phụ Cấp";
            this.phuCapDataGridViewTextBoxColumn.Name = "phuCapDataGridViewTextBoxColumn";
            this.phuCapDataGridViewTextBoxColumn.Width = 80;
            // 
            // thueThuNhapDataGridViewTextBoxColumn
            // 
            this.thueThuNhapDataGridViewTextBoxColumn.DataPropertyName = "ThueThuNhap";
            this.thueThuNhapDataGridViewTextBoxColumn.HeaderText = "Thuế Thu Nhập";
            this.thueThuNhapDataGridViewTextBoxColumn.Name = "thueThuNhapDataGridViewTextBoxColumn";
            this.thueThuNhapDataGridViewTextBoxColumn.Width = 110;
            // 
            // tongLuongNhanDataGridViewTextBoxColumn
            // 
            this.tongLuongNhanDataGridViewTextBoxColumn.DataPropertyName = "TongLuongNhan";
            this.tongLuongNhanDataGridViewTextBoxColumn.HeaderText = "Tổng Lương";
            this.tongLuongNhanDataGridViewTextBoxColumn.Name = "tongLuongNhanDataGridViewTextBoxColumn";
            // 
            // DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 530);
            this.Controls.Add(this.panel1);
            this.Name = "DanhSach";
            this.Text = "DanhSach";
            this.Load += new System.EventHandler(this.DanhSach_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource luongBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.LuongTableAdapter luongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soQuyetDinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHieuLucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongNgayCongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn congLamThemGioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thueThuNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongLuongNhanDataGridViewTextBoxColumn;
    }
}