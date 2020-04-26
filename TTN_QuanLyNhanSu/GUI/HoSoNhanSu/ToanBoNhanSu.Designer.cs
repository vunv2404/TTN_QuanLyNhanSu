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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.tTNQLNhanSuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoSoNhanSuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoSoNhanSuTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.HoSoNhanSuTableAdapter();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boPhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhongBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaoCoQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhDaiDienDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocHamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chungChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTNQLNhanSuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoSoNhanSuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 489);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenNVDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.boPhanDataGridViewTextBoxColumn,
            this.maPhongBanDataGridViewTextBoxColumn,
            this.ngayVaoCoQuanDataGridViewTextBoxColumn,
            this.anhDaiDienDataGridViewImageColumn,
            this.queQuanDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.hocViDataGridViewTextBoxColumn,
            this.hocHamDataGridViewTextBoxColumn,
            this.chungChiDataGridViewTextBoxColumn,
            this.chuyenMonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hoSoNhanSuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1142, 319);
            this.dataGridView1.TabIndex = 0;
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
            // hoSoNhanSuBindingSource
            // 
            this.hoSoNhanSuBindingSource.DataMember = "HoSoNhanSu";
            this.hoSoNhanSuBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // hoSoNhanSuTableAdapter
            // 
            this.hoSoNhanSuTableAdapter.ClearBeforeFill = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // hoTenNVDataGridViewTextBoxColumn
            // 
            this.hoTenNVDataGridViewTextBoxColumn.DataPropertyName = "HoTenNV";
            this.hoTenNVDataGridViewTextBoxColumn.HeaderText = "HoTenNV";
            this.hoTenNVDataGridViewTextBoxColumn.Name = "hoTenNVDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            // 
            // boPhanDataGridViewTextBoxColumn
            // 
            this.boPhanDataGridViewTextBoxColumn.DataPropertyName = "BoPhan";
            this.boPhanDataGridViewTextBoxColumn.HeaderText = "BoPhan";
            this.boPhanDataGridViewTextBoxColumn.Name = "boPhanDataGridViewTextBoxColumn";
            // 
            // maPhongBanDataGridViewTextBoxColumn
            // 
            this.maPhongBanDataGridViewTextBoxColumn.DataPropertyName = "MaPhongBan";
            this.maPhongBanDataGridViewTextBoxColumn.HeaderText = "MaPhongBan";
            this.maPhongBanDataGridViewTextBoxColumn.Name = "maPhongBanDataGridViewTextBoxColumn";
            // 
            // ngayVaoCoQuanDataGridViewTextBoxColumn
            // 
            this.ngayVaoCoQuanDataGridViewTextBoxColumn.DataPropertyName = "NgayVaoCoQuan";
            this.ngayVaoCoQuanDataGridViewTextBoxColumn.HeaderText = "NgayVaoCoQuan";
            this.ngayVaoCoQuanDataGridViewTextBoxColumn.Name = "ngayVaoCoQuanDataGridViewTextBoxColumn";
            // 
            // anhDaiDienDataGridViewImageColumn
            // 
            this.anhDaiDienDataGridViewImageColumn.DataPropertyName = "AnhDaiDien";
            this.anhDaiDienDataGridViewImageColumn.HeaderText = "AnhDaiDien";
            this.anhDaiDienDataGridViewImageColumn.Name = "anhDaiDienDataGridViewImageColumn";
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.HeaderText = "QueQuan";
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
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            // 
            // hocViDataGridViewTextBoxColumn
            // 
            this.hocViDataGridViewTextBoxColumn.DataPropertyName = "HocVi";
            this.hocViDataGridViewTextBoxColumn.HeaderText = "HocVi";
            this.hocViDataGridViewTextBoxColumn.Name = "hocViDataGridViewTextBoxColumn";
            // 
            // hocHamDataGridViewTextBoxColumn
            // 
            this.hocHamDataGridViewTextBoxColumn.DataPropertyName = "HocHam";
            this.hocHamDataGridViewTextBoxColumn.HeaderText = "HocHam";
            this.hocHamDataGridViewTextBoxColumn.Name = "hocHamDataGridViewTextBoxColumn";
            // 
            // chungChiDataGridViewTextBoxColumn
            // 
            this.chungChiDataGridViewTextBoxColumn.DataPropertyName = "ChungChi";
            this.chungChiDataGridViewTextBoxColumn.HeaderText = "ChungChi";
            this.chungChiDataGridViewTextBoxColumn.Name = "chungChiDataGridViewTextBoxColumn";
            // 
            // chuyenMonDataGridViewTextBoxColumn
            // 
            this.chuyenMonDataGridViewTextBoxColumn.DataPropertyName = "chuyenMon";
            this.chuyenMonDataGridViewTextBoxColumn.HeaderText = "chuyenMon";
            this.chuyenMonDataGridViewTextBoxColumn.Name = "chuyenMonDataGridViewTextBoxColumn";
            // 
            // ToanBoNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 490);
            this.Controls.Add(this.panel1);
            this.Name = "ToanBoNhanSu";
            this.Text = "ToanBoNhanSu";
            this.Load += new System.EventHandler(this.ToanBoNhanSu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTNQLNhanSuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoSoNhanSuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tTNQLNhanSuDataSetBindingSource;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource hoSoNhanSuBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.HoSoNhanSuTableAdapter hoSoNhanSuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boPhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaoCoQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn anhDaiDienDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocHamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chungChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyenMonDataGridViewTextBoxColumn;
    }
}