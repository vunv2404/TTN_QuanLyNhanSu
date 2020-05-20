namespace TTN_QuanLyNhanSu.GUI.Luong
{
    partial class DanhSachLuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTong = new System.Windows.Forms.TextBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewDanhSachLuong = new System.Windows.Forms.DataGridView();
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
            this.luongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.luongTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.LuongTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxTong);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridViewDanhSachLuong);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 529);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tổng :";
            // 
            // textBoxTong
            // 
            this.textBoxTong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTong.Location = new System.Drawing.Point(57, 82);
            this.textBoxTong.Name = "textBoxTong";
            this.textBoxTong.Size = new System.Drawing.Size(57, 25);
            this.textBoxTong.TabIndex = 5;
            // 
            // buttonThoat
            // 
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(867, 79);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(100, 25);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.textBoxTimKiem);
            this.groupBox1.Controls.Add(this.buttonTimKiem);
            this.groupBox1.Controls.Add(this.buttonChiTiet);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Location = new System.Drawing.Point(88, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimKiem.Location = new System.Drawing.Point(456, 19);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(300, 25);
            this.textBoxTimKiem.TabIndex = 4;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(779, 19);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(100, 25);
            this.buttonTimKiem.TabIndex = 3;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // buttonChiTiet
            // 
            this.buttonChiTiet.Enabled = false;
            this.buttonChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChiTiet.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiTiet.Location = new System.Drawing.Point(150, 19);
            this.buttonChiTiet.Name = "buttonChiTiet";
            this.buttonChiTiet.Size = new System.Drawing.Size(100, 25);
            this.buttonChiTiet.TabIndex = 2;
            this.buttonChiTiet.Text = "Chi Tiết";
            this.buttonChiTiet.UseVisualStyleBackColor = true;
            this.buttonChiTiet.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(34, 19);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(100, 25);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = " + Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridViewDanhSachLuong
            // 
            this.dataGridViewDanhSachLuong.AutoGenerateColumns = false;
            this.dataGridViewDanhSachLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewDanhSachLuong.DataSource = this.luongBindingSource;
            this.dataGridViewDanhSachLuong.Location = new System.Drawing.Point(4, 110);
            this.dataGridViewDanhSachLuong.Name = "dataGridViewDanhSachLuong";
            this.dataGridViewDanhSachLuong.Size = new System.Drawing.Size(1059, 416);
            this.dataGridViewDanhSachLuong.TabIndex = 0;
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
            // luongBindingSource
            // 
            this.luongBindingSource.DataMember = "Luong";
            this.luongBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // luongTableAdapter
            // 
            this.luongTableAdapter.ClearBeforeFill = true;
            // 
            // DanhSachLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 530);
            this.Controls.Add(this.panel1);
            this.Name = "DanhSachLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachLuong";
            this.Load += new System.EventHandler(this.DanhSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachLuong;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTong;
    }
}