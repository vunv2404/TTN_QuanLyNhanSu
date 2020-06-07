namespace TTN_QuanLyNhanSu.GUI.KhenThuong
{
    partial class QuyetDinhKhenThuong
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
            this.label10 = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.textBoxTong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDSNVDuocKhenThuong = new System.Windows.Forms.Button();
            this.buttonKhenThuongNhanSu = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewQuyetDinhKhenThuong = new System.Windows.Forms.DataGridView();
            this.soQuyetDinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHieuLucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khenThuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.khenThuongTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.KhenThuongTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyetDinhKhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.textBoxTong);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridViewQuyetDinhKhenThuong);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 663);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label10.Location = new System.Drawing.Point(7, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 21);
            this.label10.TabIndex = 50;
            this.label10.Text = "Tổng";
            // 
            // buttonThoat
            // 
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(1044, 87);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(133, 31);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // textBoxTong
            // 
            this.textBoxTong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTong.Location = new System.Drawing.Point(67, 89);
            this.textBoxTong.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTong.Name = "textBoxTong";
            this.textBoxTong.Size = new System.Drawing.Size(99, 29);
            this.textBoxTong.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.buttonDSNVDuocKhenThuong);
            this.groupBox1.Controls.Add(this.buttonKhenThuongNhanSu);
            this.groupBox1.Controls.Add(this.textBoxTimKiem);
            this.groupBox1.Controls.Add(this.buttonTimKiem);
            this.groupBox1.Controls.Add(this.buttonChiTiet);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Location = new System.Drawing.Point(31, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1179, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // buttonDSNVDuocKhenThuong
            // 
            this.buttonDSNVDuocKhenThuong.Enabled = false;
            this.buttonDSNVDuocKhenThuong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDSNVDuocKhenThuong.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDSNVDuocKhenThuong.Location = new System.Drawing.Point(475, 22);
            this.buttonDSNVDuocKhenThuong.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDSNVDuocKhenThuong.Name = "buttonDSNVDuocKhenThuong";
            this.buttonDSNVDuocKhenThuong.Size = new System.Drawing.Size(177, 31);
            this.buttonDSNVDuocKhenThuong.TabIndex = 7;
            this.buttonDSNVDuocKhenThuong.Text = "D/S N/V Được KT";
            this.buttonDSNVDuocKhenThuong.UseVisualStyleBackColor = true;
            this.buttonDSNVDuocKhenThuong.Click += new System.EventHandler(this.buttonDSNVBiKyLuat_Click);
            // 
            // buttonKhenThuongNhanSu
            // 
            this.buttonKhenThuongNhanSu.Enabled = false;
            this.buttonKhenThuongNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKhenThuongNhanSu.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKhenThuongNhanSu.Location = new System.Drawing.Point(288, 22);
            this.buttonKhenThuongNhanSu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKhenThuongNhanSu.Name = "buttonKhenThuongNhanSu";
            this.buttonKhenThuongNhanSu.Size = new System.Drawing.Size(179, 31);
            this.buttonKhenThuongNhanSu.TabIndex = 5;
            this.buttonKhenThuongNhanSu.Text = "Khen Thưởng N/S";
            this.buttonKhenThuongNhanSu.UseVisualStyleBackColor = true;
            this.buttonKhenThuongNhanSu.Click += new System.EventHandler(this.buttonKhenThuongNhanSu_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimKiem.Location = new System.Drawing.Point(715, 25);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(289, 29);
            this.textBoxTimKiem.TabIndex = 4;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(1013, 23);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(133, 31);
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
            this.buttonChiTiet.Location = new System.Drawing.Point(147, 22);
            this.buttonChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChiTiet.Name = "buttonChiTiet";
            this.buttonChiTiet.Size = new System.Drawing.Size(133, 31);
            this.buttonChiTiet.TabIndex = 2;
            this.buttonChiTiet.Text = "Chi Tiết";
            this.buttonChiTiet.UseVisualStyleBackColor = true;
            this.buttonChiTiet.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(8, 22);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(133, 31);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = " + Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridViewQuyetDinhKhenThuong
            // 
            this.dataGridViewQuyetDinhKhenThuong.AutoGenerateColumns = false;
            this.dataGridViewQuyetDinhKhenThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuyetDinhKhenThuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soQuyetDinhDataGridViewTextBoxColumn,
            this.ngayHieuLucDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.noiDungDataGridViewTextBoxColumn,
            this.hinhThucDataGridViewTextBoxColumn,
            this.soTienDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dataGridViewQuyetDinhKhenThuong.DataSource = this.khenThuongBindingSource;
            this.dataGridViewQuyetDinhKhenThuong.Location = new System.Drawing.Point(4, 126);
            this.dataGridViewQuyetDinhKhenThuong.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewQuyetDinhKhenThuong.Name = "dataGridViewQuyetDinhKhenThuong";
            this.dataGridViewQuyetDinhKhenThuong.RowHeadersWidth = 51;
            this.dataGridViewQuyetDinhKhenThuong.Size = new System.Drawing.Size(1247, 534);
            this.dataGridViewQuyetDinhKhenThuong.TabIndex = 0;
            this.dataGridViewQuyetDinhKhenThuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuyetDinhKhenThuong_CellClick);
            // 
            // soQuyetDinhDataGridViewTextBoxColumn
            // 
            this.soQuyetDinhDataGridViewTextBoxColumn.DataPropertyName = "SoQuyetDinh";
            this.soQuyetDinhDataGridViewTextBoxColumn.HeaderText = "Số Quyết Định";
            this.soQuyetDinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soQuyetDinhDataGridViewTextBoxColumn.Name = "soQuyetDinhDataGridViewTextBoxColumn";
            this.soQuyetDinhDataGridViewTextBoxColumn.Width = 110;
            // 
            // ngayHieuLucDataGridViewTextBoxColumn
            // 
            this.ngayHieuLucDataGridViewTextBoxColumn.DataPropertyName = "NgayHieuLuc";
            this.ngayHieuLucDataGridViewTextBoxColumn.HeaderText = "Ngày Hiệu Lực";
            this.ngayHieuLucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHieuLucDataGridViewTextBoxColumn.Name = "ngayHieuLucDataGridViewTextBoxColumn";
            this.ngayHieuLucDataGridViewTextBoxColumn.Width = 110;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "Ngày Hết Hạn";
            this.ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.Width = 110;
            // 
            // noiDungDataGridViewTextBoxColumn
            // 
            this.noiDungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noiDungDataGridViewTextBoxColumn.DataPropertyName = "NoiDung";
            this.noiDungDataGridViewTextBoxColumn.HeaderText = "Nội Dung";
            this.noiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noiDungDataGridViewTextBoxColumn.Name = "noiDungDataGridViewTextBoxColumn";
            // 
            // hinhThucDataGridViewTextBoxColumn
            // 
            this.hinhThucDataGridViewTextBoxColumn.DataPropertyName = "HinhThuc";
            this.hinhThucDataGridViewTextBoxColumn.HeaderText = "Hình Thức";
            this.hinhThucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hinhThucDataGridViewTextBoxColumn.Name = "hinhThucDataGridViewTextBoxColumn";
            this.hinhThucDataGridViewTextBoxColumn.Width = 125;
            // 
            // soTienDataGridViewTextBoxColumn
            // 
            this.soTienDataGridViewTextBoxColumn.DataPropertyName = "SoTien";
            this.soTienDataGridViewTextBoxColumn.HeaderText = "Số Tiền";
            this.soTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTienDataGridViewTextBoxColumn.Name = "soTienDataGridViewTextBoxColumn";
            this.soTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // khenThuongBindingSource
            // 
            this.khenThuongBindingSource.DataMember = "KhenThuong";
            this.khenThuongBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khenThuongTableAdapter
            // 
            this.khenThuongTableAdapter.ClearBeforeFill = true;
            // 
            // QuyetDinhKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 663);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuyetDinhKhenThuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuyetDinhKhenThuong";
            this.Load += new System.EventHandler(this.QuyetDinhKhenThuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyetDinhKhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridView dataGridViewQuyetDinhKhenThuong;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource khenThuongBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.KhenThuongTableAdapter khenThuongTableAdapter;
        private System.Windows.Forms.Button buttonKhenThuongNhanSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soQuyetDinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHieuLucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTong;
        private System.Windows.Forms.Button buttonDSNVDuocKhenThuong;
    }
}