namespace TTN_QuanLyNhanSu.GUI.KyLuat
{
    partial class QuyetDinhKyLuat
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
            this.buttonDSNVBiKyLuat = new System.Windows.Forms.Button();
            this.buttonKyLuatNhanSu = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewQuyetDinhKyLuat = new System.Windows.Forms.DataGridView();
            this.soQuyetDinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHieuLucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyLuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.kyLuatTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.KyLuatTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyetDinhKyLuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource)).BeginInit();
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
            this.panel1.Controls.Add(this.dataGridViewQuyetDinhKyLuat);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 491);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label10.Location = new System.Drawing.Point(4, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Tổng";
            // 
            // buttonThoat
            // 
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(786, 71);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(100, 25);
            this.buttonThoat.TabIndex = 6;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // textBoxTong
            // 
            this.textBoxTong.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTong.Location = new System.Drawing.Point(49, 77);
            this.textBoxTong.Name = "textBoxTong";
            this.textBoxTong.ReadOnly = true;
            this.textBoxTong.Size = new System.Drawing.Size(75, 25);
            this.textBoxTong.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.buttonDSNVBiKyLuat);
            this.groupBox1.Controls.Add(this.buttonKyLuatNhanSu);
            this.groupBox1.Controls.Add(this.textBoxTimKiem);
            this.groupBox1.Controls.Add(this.buttonTimKiem);
            this.groupBox1.Controls.Add(this.buttonChiTiet);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Location = new System.Drawing.Point(26, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // buttonDSNVBiKyLuat
            // 
            this.buttonDSNVBiKyLuat.Enabled = false;
            this.buttonDSNVBiKyLuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDSNVBiKyLuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDSNVBiKyLuat.Location = new System.Drawing.Point(337, 18);
            this.buttonDSNVBiKyLuat.Name = "buttonDSNVBiKyLuat";
            this.buttonDSNVBiKyLuat.Size = new System.Drawing.Size(153, 25);
            this.buttonDSNVBiKyLuat.TabIndex = 6;
            this.buttonDSNVBiKyLuat.Text = "D/S N/V Bị Kỷ Luật";
            this.buttonDSNVBiKyLuat.UseVisualStyleBackColor = true;
            this.buttonDSNVBiKyLuat.Click += new System.EventHandler(this.buttonDSNVBiKyLuat_Click);
            // 
            // buttonKyLuatNhanSu
            // 
            this.buttonKyLuatNhanSu.Enabled = false;
            this.buttonKyLuatNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKyLuatNhanSu.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKyLuatNhanSu.Location = new System.Drawing.Point(222, 18);
            this.buttonKyLuatNhanSu.Name = "buttonKyLuatNhanSu";
            this.buttonKyLuatNhanSu.Size = new System.Drawing.Size(109, 25);
            this.buttonKyLuatNhanSu.TabIndex = 5;
            this.buttonKyLuatNhanSu.Text = "Kỷ Luật N/S";
            this.buttonKyLuatNhanSu.UseVisualStyleBackColor = true;
            this.buttonKyLuatNhanSu.Click += new System.EventHandler(this.buttonKyLuatNhanSu_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimKiem.Location = new System.Drawing.Point(507, 18);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(245, 25);
            this.textBoxTimKiem.TabIndex = 4;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(760, 18);
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
            this.buttonChiTiet.Location = new System.Drawing.Point(116, 18);
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
            // dataGridViewQuyetDinhKyLuat
            // 
            this.dataGridViewQuyetDinhKyLuat.AllowUserToAddRows = false;
            this.dataGridViewQuyetDinhKyLuat.AllowUserToDeleteRows = false;
            this.dataGridViewQuyetDinhKyLuat.AutoGenerateColumns = false;
            this.dataGridViewQuyetDinhKyLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuyetDinhKyLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soQuyetDinhDataGridViewTextBoxColumn,
            this.ngayHieuLucDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.liDoDataGridViewTextBoxColumn,
            this.noiDungDataGridViewTextBoxColumn,
            this.hinhThucDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dataGridViewQuyetDinhKyLuat.DataSource = this.kyLuatBindingSource;
            this.dataGridViewQuyetDinhKyLuat.Location = new System.Drawing.Point(4, 108);
            this.dataGridViewQuyetDinhKyLuat.MultiSelect = false;
            this.dataGridViewQuyetDinhKyLuat.Name = "dataGridViewQuyetDinhKyLuat";
            this.dataGridViewQuyetDinhKyLuat.ReadOnly = true;
            this.dataGridViewQuyetDinhKyLuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuyetDinhKyLuat.Size = new System.Drawing.Size(927, 380);
            this.dataGridViewQuyetDinhKyLuat.TabIndex = 0;
            this.dataGridViewQuyetDinhKyLuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuyetDinhKyLuat_CellClick);
            // 
            // soQuyetDinhDataGridViewTextBoxColumn
            // 
            this.soQuyetDinhDataGridViewTextBoxColumn.DataPropertyName = "SoQuyetDinh";
            this.soQuyetDinhDataGridViewTextBoxColumn.HeaderText = "Số Quyết Định";
            this.soQuyetDinhDataGridViewTextBoxColumn.Name = "soQuyetDinhDataGridViewTextBoxColumn";
            this.soQuyetDinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.soQuyetDinhDataGridViewTextBoxColumn.Width = 110;
            // 
            // ngayHieuLucDataGridViewTextBoxColumn
            // 
            this.ngayHieuLucDataGridViewTextBoxColumn.DataPropertyName = "NgayHieuLuc";
            this.ngayHieuLucDataGridViewTextBoxColumn.HeaderText = "Ngày Hiệu Lực";
            this.ngayHieuLucDataGridViewTextBoxColumn.Name = "ngayHieuLucDataGridViewTextBoxColumn";
            this.ngayHieuLucDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayHieuLucDataGridViewTextBoxColumn.Width = 110;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "Ngày Hết Hạn";
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayHetHanDataGridViewTextBoxColumn.Width = 110;
            // 
            // liDoDataGridViewTextBoxColumn
            // 
            this.liDoDataGridViewTextBoxColumn.DataPropertyName = "LiDo";
            this.liDoDataGridViewTextBoxColumn.HeaderText = "Lí Do";
            this.liDoDataGridViewTextBoxColumn.Name = "liDoDataGridViewTextBoxColumn";
            this.liDoDataGridViewTextBoxColumn.ReadOnly = true;
            this.liDoDataGridViewTextBoxColumn.Width = 250;
            // 
            // noiDungDataGridViewTextBoxColumn
            // 
            this.noiDungDataGridViewTextBoxColumn.DataPropertyName = "NoiDung";
            this.noiDungDataGridViewTextBoxColumn.HeaderText = "Nội Dung";
            this.noiDungDataGridViewTextBoxColumn.Name = "noiDungDataGridViewTextBoxColumn";
            this.noiDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hinhThucDataGridViewTextBoxColumn
            // 
            this.hinhThucDataGridViewTextBoxColumn.DataPropertyName = "HinhThuc";
            this.hinhThucDataGridViewTextBoxColumn.HeaderText = "Hình Thức";
            this.hinhThucDataGridViewTextBoxColumn.Name = "hinhThucDataGridViewTextBoxColumn";
            this.hinhThucDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kyLuatBindingSource
            // 
            this.kyLuatBindingSource.DataMember = "KyLuat";
            this.kyLuatBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kyLuatTableAdapter
            // 
            this.kyLuatTableAdapter.ClearBeforeFill = true;
            // 
            // QuyetDinhKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 494);
            this.Controls.Add(this.panel1);
            this.Name = "QuyetDinhKyLuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuyetDinhKyLuat";
            this.Load += new System.EventHandler(this.QuyetDinhKyLuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyetDinhKyLuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewQuyetDinhKyLuat;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource kyLuatBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.KyLuatTableAdapter kyLuatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soQuyetDinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHieuLucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonKyLuatNhanSu;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonDSNVBiKyLuat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTong;
    }
}