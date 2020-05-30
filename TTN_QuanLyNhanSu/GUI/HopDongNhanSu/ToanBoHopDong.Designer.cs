namespace TTN_QuanLyNhanSu.GUI.HopDongNhanSu
{
    partial class ToanBoHopDong
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
            this.dataGridViewToanBoHopDong = new System.Windows.Forms.DataGridView();
            this.soHopDongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiHopDongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHieuLucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hopDongNhanSuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.textBoxTong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTimKiem = new System.Windows.Forms.ComboBox();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.hopDongNhanSuTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.HopDongNhanSuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToanBoHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongNhanSuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewToanBoHopDong
            // 
            this.dataGridViewToanBoHopDong.AllowUserToAddRows = false;
            this.dataGridViewToanBoHopDong.AutoGenerateColumns = false;
            this.dataGridViewToanBoHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToanBoHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soHopDongDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenNVDataGridViewTextBoxColumn,
            this.loaiHopDongDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn,
            this.ngayHieuLucDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.noiDungDataGridViewTextBoxColumn});
            this.dataGridViewToanBoHopDong.DataSource = this.hopDongNhanSuBindingSource;
            this.dataGridViewToanBoHopDong.Location = new System.Drawing.Point(0, 106);
            this.dataGridViewToanBoHopDong.Name = "dataGridViewToanBoHopDong";
            this.dataGridViewToanBoHopDong.Size = new System.Drawing.Size(1030, 391);
            this.dataGridViewToanBoHopDong.TabIndex = 0;
            this.dataGridViewToanBoHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewToanBoHopDong_CellClick);
            // 
            // soHopDongDataGridViewTextBoxColumn
            // 
            this.soHopDongDataGridViewTextBoxColumn.DataPropertyName = "SoHopDong";
            this.soHopDongDataGridViewTextBoxColumn.HeaderText = "Số Hợp Đồng";
            this.soHopDongDataGridViewTextBoxColumn.Name = "soHopDongDataGridViewTextBoxColumn";
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
            // loaiHopDongDataGridViewTextBoxColumn
            // 
            this.loaiHopDongDataGridViewTextBoxColumn.DataPropertyName = "LoaiHopDong";
            this.loaiHopDongDataGridViewTextBoxColumn.HeaderText = "Loại Hợp Đồng";
            this.loaiHopDongDataGridViewTextBoxColumn.Name = "loaiHopDongDataGridViewTextBoxColumn";
            this.loaiHopDongDataGridViewTextBoxColumn.Width = 110;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            // 
            // ngayHieuLucDataGridViewTextBoxColumn
            // 
            this.ngayHieuLucDataGridViewTextBoxColumn.DataPropertyName = "NgayHieuLuc";
            this.ngayHieuLucDataGridViewTextBoxColumn.HeaderText = "Ngày Hiệu Lực";
            this.ngayHieuLucDataGridViewTextBoxColumn.Name = "ngayHieuLucDataGridViewTextBoxColumn";
            this.ngayHieuLucDataGridViewTextBoxColumn.Width = 110;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "Ngày Hết Hạn";
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.Width = 110;
            // 
            // noiDungDataGridViewTextBoxColumn
            // 
            this.noiDungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noiDungDataGridViewTextBoxColumn.DataPropertyName = "NoiDung";
            this.noiDungDataGridViewTextBoxColumn.HeaderText = "Nội Dung";
            this.noiDungDataGridViewTextBoxColumn.Name = "noiDungDataGridViewTextBoxColumn";
            // 
            // hopDongNhanSuBindingSource
            // 
            this.hopDongNhanSuBindingSource.DataMember = "HopDongNhanSu";
            this.hopDongNhanSuBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.buttonQuayLai);
            this.panel1.Controls.Add(this.textBoxTong);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridViewToanBoHopDong);
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 498);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label10.Location = new System.Drawing.Point(5, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Tổng";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuayLai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(891, 74);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(100, 25);
            this.buttonQuayLai.TabIndex = 5;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // textBoxTong
            // 
            this.textBoxTong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTong.Location = new System.Drawing.Point(50, 73);
            this.textBoxTong.Name = "textBoxTong";
            this.textBoxTong.ReadOnly = true;
            this.textBoxTong.Size = new System.Drawing.Size(75, 25);
            this.textBoxTong.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.comboBoxTimKiem);
            this.groupBox1.Controls.Add(this.textBoxTimKiem);
            this.groupBox1.Controls.Add(this.buttonTimKiem);
            this.groupBox1.Controls.Add(this.buttonChiTiet);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Location = new System.Drawing.Point(38, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxTimKiem
            // 
            this.comboBoxTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.comboBoxTimKiem.FormattingEnabled = true;
            this.comboBoxTimKiem.Items.AddRange(new object[] {
            "None",
            "Số Hợp Đồng",
            "Tên Nhân Viên",
            "Loại Hợp Đồng"});
            this.comboBoxTimKiem.Location = new System.Drawing.Point(443, 18);
            this.comboBoxTimKiem.Name = "comboBoxTimKiem";
            this.comboBoxTimKiem.Size = new System.Drawing.Size(157, 25);
            this.comboBoxTimKiem.TabIndex = 5;
            this.comboBoxTimKiem.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimKiem_SelectedIndexChanged);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Enabled = false;
            this.textBoxTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimKiem.Location = new System.Drawing.Point(615, 18);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(226, 25);
            this.textBoxTimKiem.TabIndex = 4;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(853, 18);
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
            this.buttonChiTiet.Location = new System.Drawing.Point(140, 17);
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
            this.buttonThem.Location = new System.Drawing.Point(22, 17);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(100, 25);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = " + Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // hopDongNhanSuTableAdapter
            // 
            this.hopDongNhanSuTableAdapter.ClearBeforeFill = true;
            // 
            // ToanBoHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 497);
            this.Controls.Add(this.panel1);
            this.Name = "ToanBoHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToanBoHopDong";
            this.Load += new System.EventHandler(this.ToanBoHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToanBoHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongNhanSuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewToanBoHopDong;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource hopDongNhanSuBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.HopDongNhanSuTableAdapter hopDongNhanSuTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHopDongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiHopDongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHieuLucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.ComboBox comboBoxTimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTong;
    }
}