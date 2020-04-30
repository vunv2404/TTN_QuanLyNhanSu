namespace TTN_QuanLyNhanSu.GUI.DaoTao
{
    partial class KhoaHocDaoTao
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
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDaoTaoNhanSu = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewKhoaHocDaoTao = new System.Windows.Forms.DataGridView();
            this.daoTaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.daoTaoTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.DaoTaoTableAdapter();
            this.maDaoTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucDichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiPhuTrachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiPhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoaHocDaoTao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daoTaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridViewKhoaHocDaoTao);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 539);
            this.panel1.TabIndex = 0;
            // 
            // buttonThoat
            // 
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(723, 71);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(100, 25);
            this.buttonThoat.TabIndex = 6;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.buttonDaoTaoNhanSu);
            this.groupBox1.Controls.Add(this.textBoxTimKiem);
            this.groupBox1.Controls.Add(this.buttonTimKiem);
            this.groupBox1.Controls.Add(this.buttonChiTiet);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Location = new System.Drawing.Point(23, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // buttonDaoTaoNhanSu
            // 
            this.buttonDaoTaoNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDaoTaoNhanSu.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDaoTaoNhanSu.Location = new System.Drawing.Point(273, 18);
            this.buttonDaoTaoNhanSu.Name = "buttonDaoTaoNhanSu";
            this.buttonDaoTaoNhanSu.Size = new System.Drawing.Size(100, 25);
            this.buttonDaoTaoNhanSu.TabIndex = 5;
            this.buttonDaoTaoNhanSu.Text = "Đào Tạo N/S";
            this.buttonDaoTaoNhanSu.UseVisualStyleBackColor = true;
            this.buttonDaoTaoNhanSu.Click += new System.EventHandler(this.buttonDaoTaoNhanSu_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimKiem.Location = new System.Drawing.Point(441, 20);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(300, 25);
            this.textBoxTimKiem.TabIndex = 4;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(760, 19);
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
            this.buttonChiTiet.Location = new System.Drawing.Point(130, 19);
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
            this.buttonThem.Location = new System.Drawing.Point(6, 18);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(100, 25);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = " + Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridViewKhoaHocDaoTao
            // 
            this.dataGridViewKhoaHocDaoTao.AutoGenerateColumns = false;
            this.dataGridViewKhoaHocDaoTao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoaHocDaoTao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDaoTaoDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.mucDichDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.nguoiPhuTrachDataGridViewTextBoxColumn,
            this.chiPhiDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dataGridViewKhoaHocDaoTao.DataSource = this.daoTaoBindingSource;
            this.dataGridViewKhoaHocDaoTao.Location = new System.Drawing.Point(3, 102);
            this.dataGridViewKhoaHocDaoTao.Name = "dataGridViewKhoaHocDaoTao";
            this.dataGridViewKhoaHocDaoTao.Size = new System.Drawing.Size(935, 434);
            this.dataGridViewKhoaHocDaoTao.TabIndex = 0;
            // 
            // daoTaoBindingSource
            // 
            this.daoTaoBindingSource.DataMember = "DaoTao";
            this.daoTaoBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daoTaoTableAdapter
            // 
            this.daoTaoTableAdapter.ClearBeforeFill = true;
            // 
            // maDaoTaoDataGridViewTextBoxColumn
            // 
            this.maDaoTaoDataGridViewTextBoxColumn.DataPropertyName = "MaDaoTao";
            this.maDaoTaoDataGridViewTextBoxColumn.HeaderText = "Mã Đào Tạo";
            this.maDaoTaoDataGridViewTextBoxColumn.Name = "maDaoTaoDataGridViewTextBoxColumn";
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày Lập";
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            // 
            // mucDichDataGridViewTextBoxColumn
            // 
            this.mucDichDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mucDichDataGridViewTextBoxColumn.DataPropertyName = "MucDich";
            this.mucDichDataGridViewTextBoxColumn.HeaderText = "Mục Đích";
            this.mucDichDataGridViewTextBoxColumn.Name = "mucDichDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // nguoiPhuTrachDataGridViewTextBoxColumn
            // 
            this.nguoiPhuTrachDataGridViewTextBoxColumn.DataPropertyName = "NguoiPhuTrach";
            this.nguoiPhuTrachDataGridViewTextBoxColumn.HeaderText = "Người Phụ Trách";
            this.nguoiPhuTrachDataGridViewTextBoxColumn.Name = "nguoiPhuTrachDataGridViewTextBoxColumn";
            this.nguoiPhuTrachDataGridViewTextBoxColumn.Width = 160;
            // 
            // chiPhiDataGridViewTextBoxColumn
            // 
            this.chiPhiDataGridViewTextBoxColumn.DataPropertyName = "ChiPhi";
            this.chiPhiDataGridViewTextBoxColumn.HeaderText = "Chi Phí";
            this.chiPhiDataGridViewTextBoxColumn.Name = "chiPhiDataGridViewTextBoxColumn";
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình Trạng";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            // 
            // KhoaHocDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 540);
            this.Controls.Add(this.panel1);
            this.Name = "KhoaHocDaoTao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhoaHocDaoTao";
            this.Load += new System.EventHandler(this.KhoaHocDaoTao_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoaHocDaoTao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daoTaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridView dataGridViewKhoaHocDaoTao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.Button buttonDaoTaoNhanSu;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource daoTaoBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.DaoTaoTableAdapter daoTaoTableAdapter;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDaoTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucDichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiPhuTrachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiPhiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
    }
}