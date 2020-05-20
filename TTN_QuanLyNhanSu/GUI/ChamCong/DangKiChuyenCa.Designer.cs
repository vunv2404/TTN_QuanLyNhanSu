namespace TTN_QuanLyNhanSu.GUI.ChamCong
{
    partial class DangKiChuyenCa
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
            this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.comboBoxMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.textBoxCaCu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCaMoi = new System.Windows.Forms.TextBox();
            this.dataGridViewDangKiChuyenCa = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caCuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caMoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dangKiChuyenCaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLiDo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDenNgay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTuNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTenNhanVien = new System.Windows.Forms.TextBox();
            this.dangKiChuyenCaTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.DangKiChuyenCaTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangKiChuyenCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKiChuyenCaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBoxTong);
            this.panel1.Controls.Add(this.comboBoxTrangThai);
            this.panel1.Controls.Add(this.comboBoxMaNhanVien);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonQuayLai);
            this.panel1.Controls.Add(this.buttonLuu);
            this.panel1.Controls.Add(this.textBoxCaCu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxCaMoi);
            this.panel1.Controls.Add(this.dataGridViewDangKiChuyenCa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxLiDo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxDenNgay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxTuNgay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxTenNhanVien);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 567);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Items.AddRange(new object[] {
            "Đã Phê Duyệt",
            "Chưa Phê Duyệt"});
            this.comboBoxTrangThai.Location = new System.Drawing.Point(544, 223);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(252, 25);
            this.comboBoxTrangThai.TabIndex = 46;
            // 
            // comboBoxMaNhanVien
            // 
            this.comboBoxMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxMaNhanVien.FormattingEnabled = true;
            this.comboBoxMaNhanVien.Location = new System.Drawing.Point(121, 89);
            this.comboBoxMaNhanVien.Name = "comboBoxMaNhanVien";
            this.comboBoxMaNhanVien.Size = new System.Drawing.Size(252, 25);
            this.comboBoxMaNhanVien.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 36);
            this.label9.TabIndex = 44;
            this.label9.Text = "Đăng Kí Chuyển Ca";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuayLai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(805, 255);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(90, 30);
            this.buttonQuayLai.TabIndex = 43;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(694, 255);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(90, 30);
            this.buttonLuu.TabIndex = 42;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // textBoxCaCu
            // 
            this.textBoxCaCu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxCaCu.Location = new System.Drawing.Point(121, 183);
            this.textBoxCaCu.Name = "textBoxCaCu";
            this.textBoxCaCu.Size = new System.Drawing.Size(252, 25);
            this.textBoxCaCu.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ca Cũ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ca Mới";
            // 
            // textBoxCaMoi
            // 
            this.textBoxCaMoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxCaMoi.Location = new System.Drawing.Point(121, 228);
            this.textBoxCaMoi.Name = "textBoxCaMoi";
            this.textBoxCaMoi.Size = new System.Drawing.Size(252, 25);
            this.textBoxCaMoi.TabIndex = 41;
            // 
            // dataGridViewDangKiChuyenCa
            // 
            this.dataGridViewDangKiChuyenCa.AutoGenerateColumns = false;
            this.dataGridViewDangKiChuyenCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDangKiChuyenCa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenNVDataGridViewTextBoxColumn,
            this.caCuDataGridViewTextBoxColumn,
            this.caMoiDataGridViewTextBoxColumn,
            this.tuNgayDataGridViewTextBoxColumn,
            this.denNgayDataGridViewTextBoxColumn,
            this.liDoDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewTextBoxColumn});
            this.dataGridViewDangKiChuyenCa.DataSource = this.dangKiChuyenCaBindingSource;
            this.dataGridViewDangKiChuyenCa.Location = new System.Drawing.Point(3, 291);
            this.dataGridViewDangKiChuyenCa.Name = "dataGridViewDangKiChuyenCa";
            this.dataGridViewDangKiChuyenCa.Size = new System.Drawing.Size(927, 273);
            this.dataGridViewDangKiChuyenCa.TabIndex = 0;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 80;
            // 
            // hoTenNVDataGridViewTextBoxColumn
            // 
            this.hoTenNVDataGridViewTextBoxColumn.DataPropertyName = "HoTenNV";
            this.hoTenNVDataGridViewTextBoxColumn.HeaderText = "Họ Tên NV";
            this.hoTenNVDataGridViewTextBoxColumn.Name = "hoTenNVDataGridViewTextBoxColumn";
            this.hoTenNVDataGridViewTextBoxColumn.Width = 160;
            // 
            // caCuDataGridViewTextBoxColumn
            // 
            this.caCuDataGridViewTextBoxColumn.DataPropertyName = "CaCu";
            this.caCuDataGridViewTextBoxColumn.HeaderText = "Ca Cũ";
            this.caCuDataGridViewTextBoxColumn.Name = "caCuDataGridViewTextBoxColumn";
            this.caCuDataGridViewTextBoxColumn.Width = 90;
            // 
            // caMoiDataGridViewTextBoxColumn
            // 
            this.caMoiDataGridViewTextBoxColumn.DataPropertyName = "CaMoi";
            this.caMoiDataGridViewTextBoxColumn.HeaderText = "Ca Mới";
            this.caMoiDataGridViewTextBoxColumn.Name = "caMoiDataGridViewTextBoxColumn";
            this.caMoiDataGridViewTextBoxColumn.Width = 90;
            // 
            // tuNgayDataGridViewTextBoxColumn
            // 
            this.tuNgayDataGridViewTextBoxColumn.DataPropertyName = "TuNgay";
            this.tuNgayDataGridViewTextBoxColumn.HeaderText = "Từ Ngày";
            this.tuNgayDataGridViewTextBoxColumn.Name = "tuNgayDataGridViewTextBoxColumn";
            this.tuNgayDataGridViewTextBoxColumn.Width = 90;
            // 
            // denNgayDataGridViewTextBoxColumn
            // 
            this.denNgayDataGridViewTextBoxColumn.DataPropertyName = "DenNgay";
            this.denNgayDataGridViewTextBoxColumn.HeaderText = "Đến Ngày";
            this.denNgayDataGridViewTextBoxColumn.Name = "denNgayDataGridViewTextBoxColumn";
            this.denNgayDataGridViewTextBoxColumn.Width = 90;
            // 
            // liDoDataGridViewTextBoxColumn
            // 
            this.liDoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.liDoDataGridViewTextBoxColumn.DataPropertyName = "LiDo";
            this.liDoDataGridViewTextBoxColumn.HeaderText = "Lí Do";
            this.liDoDataGridViewTextBoxColumn.Name = "liDoDataGridViewTextBoxColumn";
            // 
            // trangthaiDataGridViewTextBoxColumn
            // 
            this.trangthaiDataGridViewTextBoxColumn.DataPropertyName = "Trangthai";
            this.trangthaiDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trangthaiDataGridViewTextBoxColumn.Name = "trangthaiDataGridViewTextBoxColumn";
            // 
            // dangKiChuyenCaBindingSource
            // 
            this.dangKiChuyenCaBindingSource.DataMember = "DangKiChuyenCa";
            this.dangKiChuyenCaBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Trạng Thái";
            // 
            // textBoxLiDo
            // 
            this.textBoxLiDo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxLiDo.Location = new System.Drawing.Point(544, 178);
            this.textBoxLiDo.Name = "textBoxLiDo";
            this.textBoxLiDo.Size = new System.Drawing.Size(252, 25);
            this.textBoxLiDo.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Lí Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Họ Tên";
            // 
            // textBoxDenNgay
            // 
            this.textBoxDenNgay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxDenNgay.Location = new System.Drawing.Point(544, 132);
            this.textBoxDenNgay.Name = "textBoxDenNgay";
            this.textBoxDenNgay.Size = new System.Drawing.Size(252, 25);
            this.textBoxDenNgay.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Từ Ngày";
            // 
            // textBoxTuNgay
            // 
            this.textBoxTuNgay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTuNgay.Location = new System.Drawing.Point(544, 89);
            this.textBoxTuNgay.Name = "textBoxTuNgay";
            this.textBoxTuNgay.Size = new System.Drawing.Size(252, 25);
            this.textBoxTuNgay.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Đến Ngày";
            // 
            // textBoxTenNhanVien
            // 
            this.textBoxTenNhanVien.Enabled = false;
            this.textBoxTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTenNhanVien.Location = new System.Drawing.Point(121, 137);
            this.textBoxTenNhanVien.Name = "textBoxTenNhanVien";
            this.textBoxTenNhanVien.Size = new System.Drawing.Size(252, 25);
            this.textBoxTenNhanVien.TabIndex = 31;
            // 
            // dangKiChuyenCaTableAdapter
            // 
            this.dangKiChuyenCaTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label10.Location = new System.Drawing.Point(8, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Tổng";
            // 
            // textBoxTong
            // 
            this.textBoxTong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTong.Location = new System.Drawing.Point(53, 260);
            this.textBoxTong.Name = "textBoxTong";
            this.textBoxTong.Size = new System.Drawing.Size(75, 25);
            this.textBoxTong.TabIndex = 47;
            // 
            // DangKiChuyenCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 569);
            this.Controls.Add(this.panel1);
            this.Name = "DangKiChuyenCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKiChuyenCa";
            this.Load += new System.EventHandler(this.DangKiChuyenCa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangKiChuyenCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKiChuyenCaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDangKiChuyenCa;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource dangKiChuyenCaBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.DangKiChuyenCaTableAdapter dangKiChuyenCaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caCuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caMoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxCaCu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCaMoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLiDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDenNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTenNhanVien;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
        private System.Windows.Forms.ComboBox comboBoxMaNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTong;
    }
}