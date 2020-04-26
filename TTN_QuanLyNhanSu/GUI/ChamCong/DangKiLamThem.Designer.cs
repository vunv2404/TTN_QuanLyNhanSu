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
            this.dataGridViewDangKiLamThem = new System.Windows.Forms.DataGridView();
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.dangKilamThemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangKilamThemTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.DangKilamThemTableAdapter();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTangCaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxmanhanVien = new System.Windows.Forms.TextBox();
            this.textBoxtennhanvien = new System.Windows.Forms.TextBox();
            this.textBoxtungay = new System.Windows.Forms.TextBox();
            this.textBoxdenngay = new System.Windows.Forms.TextBox();
            this.textBoxluong = new System.Windows.Forms.TextBox();
            this.textBoxsogio = new System.Windows.Forms.TextBox();
            this.textBoxtrangthai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonquaylai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangKiLamThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKilamThemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.buttonquaylai);
            this.panel1.Controls.Add(this.buttonluu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxtrangthai);
            this.panel1.Controls.Add(this.textBoxsogio);
            this.panel1.Controls.Add(this.textBoxluong);
            this.panel1.Controls.Add(this.textBoxdenngay);
            this.panel1.Controls.Add(this.textBoxtungay);
            this.panel1.Controls.Add(this.textBoxtennhanvien);
            this.panel1.Controls.Add(this.textBoxmanhanVien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewDangKiLamThem);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 528);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewDangKiLamThem
            // 
            this.dataGridViewDangKiLamThem.AutoGenerateColumns = false;
            this.dataGridViewDangKiLamThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDangKiLamThem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenNVDataGridViewTextBoxColumn,
            this.tuNgayDataGridViewTextBoxColumn,
            this.denNgayDataGridViewTextBoxColumn,
            this.luongTangCaDataGridViewTextBoxColumn,
            this.soGioDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewTextBoxColumn});
            this.dataGridViewDangKiLamThem.DataSource = this.dangKilamThemBindingSource;
            this.dataGridViewDangKiLamThem.Location = new System.Drawing.Point(3, 244);
            this.dataGridViewDangKiLamThem.Name = "dataGridViewDangKiLamThem";
            this.dataGridViewDangKiLamThem.Size = new System.Drawing.Size(865, 281);
            this.dataGridViewDangKiLamThem.TabIndex = 0;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangKilamThemBindingSource
            // 
            this.dangKilamThemBindingSource.DataMember = "DangKilamThem";
            this.dangKilamThemBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // dangKilamThemTableAdapter
            // 
            this.dangKilamThemTableAdapter.ClearBeforeFill = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // hoTenNVDataGridViewTextBoxColumn
            // 
            this.hoTenNVDataGridViewTextBoxColumn.DataPropertyName = "HoTenNV";
            this.hoTenNVDataGridViewTextBoxColumn.HeaderText = "Họ Tên NV";
            this.hoTenNVDataGridViewTextBoxColumn.Name = "hoTenNVDataGridViewTextBoxColumn";
            this.hoTenNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // tuNgayDataGridViewTextBoxColumn
            // 
            this.tuNgayDataGridViewTextBoxColumn.DataPropertyName = "TuNgay";
            this.tuNgayDataGridViewTextBoxColumn.HeaderText = "Từ Ngày";
            this.tuNgayDataGridViewTextBoxColumn.Name = "tuNgayDataGridViewTextBoxColumn";
            // 
            // denNgayDataGridViewTextBoxColumn
            // 
            this.denNgayDataGridViewTextBoxColumn.DataPropertyName = "DenNgay";
            this.denNgayDataGridViewTextBoxColumn.HeaderText = "Đến Ngày";
            this.denNgayDataGridViewTextBoxColumn.Name = "denNgayDataGridViewTextBoxColumn";
            // 
            // luongTangCaDataGridViewTextBoxColumn
            // 
            this.luongTangCaDataGridViewTextBoxColumn.DataPropertyName = "LuongTangCa";
            this.luongTangCaDataGridViewTextBoxColumn.HeaderText = "Lương Tăng Ca";
            this.luongTangCaDataGridViewTextBoxColumn.Name = "luongTangCaDataGridViewTextBoxColumn";
            this.luongTangCaDataGridViewTextBoxColumn.Width = 120;
            // 
            // soGioDataGridViewTextBoxColumn
            // 
            this.soGioDataGridViewTextBoxColumn.DataPropertyName = "SoGio";
            this.soGioDataGridViewTextBoxColumn.HeaderText = "Số Giờ";
            this.soGioDataGridViewTextBoxColumn.Name = "soGioDataGridViewTextBoxColumn";
            // 
            // trangthaiDataGridViewTextBoxColumn
            // 
            this.trangthaiDataGridViewTextBoxColumn.DataPropertyName = "Trangthai";
            this.trangthaiDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trangthaiDataGridViewTextBoxColumn.Name = "trangthaiDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đến Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số Giờ";
            // 
            // textBoxmanhanVien
            // 
            this.textBoxmanhanVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxmanhanVien.Location = new System.Drawing.Point(143, 25);
            this.textBoxmanhanVien.Name = "textBoxmanhanVien";
            this.textBoxmanhanVien.Size = new System.Drawing.Size(252, 25);
            this.textBoxmanhanVien.TabIndex = 8;
            // 
            // textBoxtennhanvien
            // 
            this.textBoxtennhanvien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxtennhanvien.Location = new System.Drawing.Point(143, 73);
            this.textBoxtennhanvien.Name = "textBoxtennhanvien";
            this.textBoxtennhanvien.Size = new System.Drawing.Size(252, 25);
            this.textBoxtennhanvien.TabIndex = 9;
            // 
            // textBoxtungay
            // 
            this.textBoxtungay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxtungay.Location = new System.Drawing.Point(143, 124);
            this.textBoxtungay.Name = "textBoxtungay";
            this.textBoxtungay.Size = new System.Drawing.Size(252, 25);
            this.textBoxtungay.TabIndex = 10;
            // 
            // textBoxdenngay
            // 
            this.textBoxdenngay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxdenngay.Location = new System.Drawing.Point(143, 175);
            this.textBoxdenngay.Name = "textBoxdenngay";
            this.textBoxdenngay.Size = new System.Drawing.Size(252, 25);
            this.textBoxdenngay.TabIndex = 11;
            // 
            // textBoxluong
            // 
            this.textBoxluong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxluong.Location = new System.Drawing.Point(573, 42);
            this.textBoxluong.Name = "textBoxluong";
            this.textBoxluong.Size = new System.Drawing.Size(252, 25);
            this.textBoxluong.TabIndex = 12;
            // 
            // textBoxsogio
            // 
            this.textBoxsogio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxsogio.Location = new System.Drawing.Point(573, 104);
            this.textBoxsogio.Name = "textBoxsogio";
            this.textBoxsogio.Size = new System.Drawing.Size(252, 25);
            this.textBoxsogio.TabIndex = 13;
            // 
            // textBoxtrangthai
            // 
            this.textBoxtrangthai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxtrangthai.Location = new System.Drawing.Point(573, 157);
            this.textBoxtrangthai.Name = "textBoxtrangthai";
            this.textBoxtrangthai.Size = new System.Drawing.Size(252, 25);
            this.textBoxtrangthai.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Trạng Thái";
            // 
            // buttonluu
            // 
            this.buttonluu.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonluu.Location = new System.Drawing.Point(601, 208);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(90, 30);
            this.buttonluu.TabIndex = 16;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = true;
            // 
            // buttonquaylai
            // 
            this.buttonquaylai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonquaylai.Location = new System.Drawing.Point(756, 208);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(90, 30);
            this.buttonquaylai.TabIndex = 17;
            this.buttonquaylai.Text = "Quay Lại";
            this.buttonquaylai.UseVisualStyleBackColor = true;
            // 
            // DangKiLamThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 531);
            this.Controls.Add(this.panel1);
            this.Name = "DangKiLamThem";
            this.Text = "DangKiLamThem";
            this.Load += new System.EventHandler(this.DangKiLamThem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangKiLamThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKilamThemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDangKiLamThem;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource dangKilamThemBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.DangKilamThemTableAdapter dangKilamThemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTangCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxtrangthai;
        private System.Windows.Forms.TextBox textBoxsogio;
        private System.Windows.Forms.TextBox textBoxluong;
        private System.Windows.Forms.TextBox textBoxdenngay;
        private System.Windows.Forms.TextBox textBoxtungay;
        private System.Windows.Forms.TextBox textBoxtennhanvien;
        private System.Windows.Forms.TextBox textBoxmanhanVien;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonquaylai;
    }
}