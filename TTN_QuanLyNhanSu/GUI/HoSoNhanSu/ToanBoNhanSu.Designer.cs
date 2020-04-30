namespace TTN_QuanLyNhanSu.GUI.HoSoNhanSu
{
    partial class ToanBoNhanSu
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
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewHoSoNhanSu = new System.Windows.Forms.DataGridView();
            this.hoSoNhanSuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.tTNQLNhanSuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoSoNhanSuTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.HoSoNhanSuTableAdapter();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boPhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhongBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaoCoQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocHamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chungChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoSoNhanSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoSoNhanSuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTNQLNhanSuDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.buttonQuayLai);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridViewHoSoNhanSu);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 489);
            this.panel1.TabIndex = 0;
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuayLai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(971, 86);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(100, 25);
            this.buttonQuayLai.TabIndex = 5;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.textBoxTimKiem);
            this.groupBox1.Controls.Add(this.buttonTimKiem);
            this.groupBox1.Controls.Add(this.buttonChiTiet);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Location = new System.Drawing.Point(54, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimKiem.Location = new System.Drawing.Point(508, 18);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(378, 25);
            this.textBoxTimKiem.TabIndex = 4;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(917, 18);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(100, 25);
            this.buttonTimKiem.TabIndex = 3;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // buttonChiTiet
            // 
            this.buttonChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChiTiet.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiTiet.Location = new System.Drawing.Point(212, 17);
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
            this.buttonThem.Location = new System.Drawing.Point(87, 17);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(100, 25);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = " + Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridViewHoSoNhanSu
            // 
            this.dataGridViewHoSoNhanSu.AutoGenerateColumns = false;
            this.dataGridViewHoSoNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoSoNhanSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenNVDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.boPhanDataGridViewTextBoxColumn,
            this.maPhongBanDataGridViewTextBoxColumn,
            this.ngayVaoCoQuanDataGridViewTextBoxColumn,
            this.queQuanDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.hocViDataGridViewTextBoxColumn,
            this.hocHamDataGridViewTextBoxColumn,
            this.chungChiDataGridViewTextBoxColumn,
            this.chuyenMonDataGridViewTextBoxColumn});
            this.dataGridViewHoSoNhanSu.DataSource = this.hoSoNhanSuBindingSource;
            this.dataGridViewHoSoNhanSu.Location = new System.Drawing.Point(3, 117);
            this.dataGridViewHoSoNhanSu.Name = "dataGridViewHoSoNhanSu";
            this.dataGridViewHoSoNhanSu.Size = new System.Drawing.Size(1142, 369);
            this.dataGridViewHoSoNhanSu.TabIndex = 0;
            // 
            // hoSoNhanSuBindingSource
            // 
            this.hoSoNhanSuBindingSource.DataMember = "HoSoNhanSu";
            this.hoSoNhanSuBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTNQLNhanSuDataSetBindingSource
            // 
            this.tTNQLNhanSuDataSetBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            this.tTNQLNhanSuDataSetBindingSource.Position = 0;
            // 
            // hoSoNhanSuTableAdapter
            // 
            this.hoSoNhanSuTableAdapter.ClearBeforeFill = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 70;
            // 
            // hoTenNVDataGridViewTextBoxColumn
            // 
            this.hoTenNVDataGridViewTextBoxColumn.DataPropertyName = "HoTenNV";
            this.hoTenNVDataGridViewTextBoxColumn.HeaderText = "Họ Tên NV";
            this.hoTenNVDataGridViewTextBoxColumn.Name = "hoTenNVDataGridViewTextBoxColumn";
            this.hoTenNVDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 90;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "Chức Vụ";
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            // 
            // boPhanDataGridViewTextBoxColumn
            // 
            this.boPhanDataGridViewTextBoxColumn.DataPropertyName = "BoPhan";
            this.boPhanDataGridViewTextBoxColumn.HeaderText = "Bộ Phận";
            this.boPhanDataGridViewTextBoxColumn.Name = "boPhanDataGridViewTextBoxColumn";
            // 
            // maPhongBanDataGridViewTextBoxColumn
            // 
            this.maPhongBanDataGridViewTextBoxColumn.DataPropertyName = "MaPhongBan";
            this.maPhongBanDataGridViewTextBoxColumn.HeaderText = "Mã P/B";
            this.maPhongBanDataGridViewTextBoxColumn.Name = "maPhongBanDataGridViewTextBoxColumn";
            // 
            // ngayVaoCoQuanDataGridViewTextBoxColumn
            // 
            this.ngayVaoCoQuanDataGridViewTextBoxColumn.DataPropertyName = "NgayVaoCoQuan";
            this.ngayVaoCoQuanDataGridViewTextBoxColumn.HeaderText = "Ngày Vào Cơ Quan";
            this.ngayVaoCoQuanDataGridViewTextBoxColumn.Name = "ngayVaoCoQuanDataGridViewTextBoxColumn";
            this.ngayVaoCoQuanDataGridViewTextBoxColumn.Width = 140;
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.HeaderText = "Quê Quán";
            this.queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 90;
            // 
            // hocViDataGridViewTextBoxColumn
            // 
            this.hocViDataGridViewTextBoxColumn.DataPropertyName = "HocVi";
            this.hocViDataGridViewTextBoxColumn.HeaderText = "Học Vị";
            this.hocViDataGridViewTextBoxColumn.Name = "hocViDataGridViewTextBoxColumn";
            // 
            // hocHamDataGridViewTextBoxColumn
            // 
            this.hocHamDataGridViewTextBoxColumn.DataPropertyName = "HocHam";
            this.hocHamDataGridViewTextBoxColumn.HeaderText = "Học Hàm";
            this.hocHamDataGridViewTextBoxColumn.Name = "hocHamDataGridViewTextBoxColumn";
            // 
            // chungChiDataGridViewTextBoxColumn
            // 
            this.chungChiDataGridViewTextBoxColumn.DataPropertyName = "ChungChi";
            this.chungChiDataGridViewTextBoxColumn.HeaderText = "Chứng Chỉ";
            this.chungChiDataGridViewTextBoxColumn.Name = "chungChiDataGridViewTextBoxColumn";
            // 
            // chuyenMonDataGridViewTextBoxColumn
            // 
            this.chuyenMonDataGridViewTextBoxColumn.DataPropertyName = "chuyenMon";
            this.chuyenMonDataGridViewTextBoxColumn.HeaderText = "chuyên Môn";
            this.chuyenMonDataGridViewTextBoxColumn.Name = "chuyenMonDataGridViewTextBoxColumn";
            // 
            // ToanBoNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 490);
            this.Controls.Add(this.panel1);
            this.Name = "ToanBoNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToanBoNhanSu";
            this.Load += new System.EventHandler(this.ToanBoNhanSu_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoSoNhanSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoSoNhanSuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTNQLNhanSuDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewHoSoNhanSu;
        private System.Windows.Forms.BindingSource tTNQLNhanSuDataSetBindingSource;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource hoSoNhanSuBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.HoSoNhanSuTableAdapter hoSoNhanSuTableAdapter;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boPhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaoCoQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocHamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chungChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyenMonDataGridViewTextBoxColumn;
    }
}