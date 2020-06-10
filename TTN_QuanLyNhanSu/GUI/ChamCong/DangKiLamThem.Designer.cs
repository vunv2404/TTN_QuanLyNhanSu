namespace TTN_QuanLyNhanSu.GUI.ChamCong
{
    partial class DangKiLamThem
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
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.textBoxTong = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSoGio = new System.Windows.Forms.TextBox();
            this.textBoxLuong = new System.Windows.Forms.TextBox();
            this.textBoxDenNgay = new System.Windows.Forms.TextBox();
            this.textBoxTuNgay = new System.Windows.Forms.TextBox();
            this.textBoxTenNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDangKiLamThem = new System.Windows.Forms.DataGridView();
            this.dangKilamThemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.dangKilamThemTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.DangKilamThemTableAdapter();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTangCaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangKiLamThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKilamThemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBoxTrangThai);
            this.panel1.Controls.Add(this.textBoxTong);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.buttonQuayLai);
            this.panel1.Controls.Add(this.buttonLuu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxSoGio);
            this.panel1.Controls.Add(this.textBoxLuong);
            this.panel1.Controls.Add(this.textBoxDenNgay);
            this.panel1.Controls.Add(this.textBoxTuNgay);
            this.panel1.Controls.Add(this.textBoxTenNhanVien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewDangKiLamThem);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 702);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label9.Location = new System.Drawing.Point(7, 320);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tổng";
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Items.AddRange(new object[] {
            "Đã Phê Duyệt",
            "Chưa Phê Duyệt"});
            this.comboBoxTrangThai.Location = new System.Drawing.Point(769, 242);
            this.comboBoxTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(337, 30);
            this.comboBoxTrangThai.TabIndex = 20;
            // 
            // textBoxTong
            // 
            this.textBoxTong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTong.Location = new System.Drawing.Point(67, 314);
            this.textBoxTong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTong.Name = "textBoxTong";
            this.textBoxTong.Size = new System.Drawing.Size(99, 29);
            this.textBoxTong.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 86);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(379, 30);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(405, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 46);
            this.label8.TabIndex = 18;
            this.label8.Text = "Đăng Kí Làm Thêm";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuayLai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(955, 305);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(120, 37);
            this.buttonQuayLai.TabIndex = 17;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(760, 305);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(120, 37);
            this.buttonLuu.TabIndex = 16;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(645, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Trạng Thái";
            // 
            // textBoxSoGio
            // 
            this.textBoxSoGio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxSoGio.Location = new System.Drawing.Point(772, 177);
            this.textBoxSoGio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSoGio.Name = "textBoxSoGio";
            this.textBoxSoGio.Size = new System.Drawing.Size(335, 29);
            this.textBoxSoGio.TabIndex = 13;
            // 
            // textBoxLuong
            // 
            this.textBoxLuong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxLuong.Location = new System.Drawing.Point(772, 110);
            this.textBoxLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLuong.Name = "textBoxLuong";
            this.textBoxLuong.Size = new System.Drawing.Size(335, 29);
            this.textBoxLuong.TabIndex = 12;
            // 
            // textBoxDenNgay
            // 
            this.textBoxDenNgay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxDenNgay.Location = new System.Drawing.Point(199, 268);
            this.textBoxDenNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDenNgay.Name = "textBoxDenNgay";
            this.textBoxDenNgay.Size = new System.Drawing.Size(379, 29);
            this.textBoxDenNgay.TabIndex = 11;
            // 
            // textBoxTuNgay
            // 
            this.textBoxTuNgay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTuNgay.Location = new System.Drawing.Point(199, 206);
            this.textBoxTuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTuNgay.Name = "textBoxTuNgay";
            this.textBoxTuNgay.Size = new System.Drawing.Size(379, 29);
            this.textBoxTuNgay.TabIndex = 10;
            // 
            // textBoxTenNhanVien
            // 
            this.textBoxTenNhanVien.Enabled = false;
            this.textBoxTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTenNhanVien.Location = new System.Drawing.Point(199, 143);
            this.textBoxTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTenNhanVien.Name = "textBoxTenNhanVien";
            this.textBoxTenNhanVien.Size = new System.Drawing.Size(379, 29);
            this.textBoxTenNhanVien.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(645, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số Giờ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(645, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lương/1 Giờ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đến Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // dataGridViewDangKiLamThem
            // 
            this.dataGridViewDangKiLamThem.AutoGenerateColumns = false;
            this.dataGridViewDangKiLamThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDangKiLamThem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenNVDataGridViewTextBoxColumn,
            this.tuNgayDataGridViewTextBoxColumn,
            this.denNgayDataGridViewTextBoxColumn,
            this.luongTangCaDataGridViewTextBoxColumn,
            this.soGioDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewTextBoxColumn});
            this.dataGridViewDangKiLamThem.DataSource = this.dangKilamThemBindingSource;
            this.dataGridViewDangKiLamThem.Location = new System.Drawing.Point(5, 352);
            this.dataGridViewDangKiLamThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDangKiLamThem.Name = "dataGridViewDangKiLamThem";
            this.dataGridViewDangKiLamThem.RowHeadersWidth = 51;
            this.dataGridViewDangKiLamThem.Size = new System.Drawing.Size(1153, 346);
            this.dataGridViewDangKiLamThem.TabIndex = 0;
            // 
            // dangKilamThemBindingSource
            // 
            this.dangKilamThemBindingSource.DataMember = "DangKilamThem";
            this.dangKilamThemBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangKilamThemTableAdapter
            // 
            this.dangKilamThemTableAdapter.ClearBeforeFill = true;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.Width = 125;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoTenNVDataGridViewTextBoxColumn
            // 
            this.hoTenNVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoTenNVDataGridViewTextBoxColumn.DataPropertyName = "HoTenNV";
            this.hoTenNVDataGridViewTextBoxColumn.HeaderText = "Họ Tên NV";
            this.hoTenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenNVDataGridViewTextBoxColumn.Name = "hoTenNVDataGridViewTextBoxColumn";
            // 
            // tuNgayDataGridViewTextBoxColumn
            // 
            this.tuNgayDataGridViewTextBoxColumn.DataPropertyName = "TuNgay";
            this.tuNgayDataGridViewTextBoxColumn.HeaderText = "Từ Ngày";
            this.tuNgayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tuNgayDataGridViewTextBoxColumn.Name = "tuNgayDataGridViewTextBoxColumn";
            this.tuNgayDataGridViewTextBoxColumn.Width = 125;
            // 
            // denNgayDataGridViewTextBoxColumn
            // 
            this.denNgayDataGridViewTextBoxColumn.DataPropertyName = "DenNgay";
            this.denNgayDataGridViewTextBoxColumn.HeaderText = "Đến Ngày";
            this.denNgayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denNgayDataGridViewTextBoxColumn.Name = "denNgayDataGridViewTextBoxColumn";
            this.denNgayDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongTangCaDataGridViewTextBoxColumn
            // 
            this.luongTangCaDataGridViewTextBoxColumn.DataPropertyName = "LuongTangCa";
            this.luongTangCaDataGridViewTextBoxColumn.HeaderText = "Lương Tăng Ca";
            this.luongTangCaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongTangCaDataGridViewTextBoxColumn.Name = "luongTangCaDataGridViewTextBoxColumn";
            this.luongTangCaDataGridViewTextBoxColumn.Width = 120;
            // 
            // soGioDataGridViewTextBoxColumn
            // 
            this.soGioDataGridViewTextBoxColumn.DataPropertyName = "SoGio";
            this.soGioDataGridViewTextBoxColumn.HeaderText = "Số Giờ";
            this.soGioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soGioDataGridViewTextBoxColumn.Name = "soGioDataGridViewTextBoxColumn";
            this.soGioDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangthaiDataGridViewTextBoxColumn
            // 
            this.trangthaiDataGridViewTextBoxColumn.DataPropertyName = "Trangthai";
            this.trangthaiDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trangthaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangthaiDataGridViewTextBoxColumn.Name = "trangthaiDataGridViewTextBoxColumn";
            this.trangthaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // DangKiLamThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 704);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DangKiLamThem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKiLamThem";
            this.Load += new System.EventHandler(this.DangKiLamThem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangKiLamThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKilamThemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDangKiLamThem;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource dangKilamThemBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.DangKilamThemTableAdapter dangKilamThemTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSoGio;
        private System.Windows.Forms.TextBox textBoxLuong;
        private System.Windows.Forms.TextBox textBoxDenNgay;
        private System.Windows.Forms.TextBox textBoxTuNgay;
        private System.Windows.Forms.TextBox textBoxTenNhanVien;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTangCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDataGridViewTextBoxColumn;
    }
}