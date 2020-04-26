namespace TTN_QuanLyNhanSu.GUI.ChamCong
{
    partial class DangKiNghi
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
            this.dataGridViewDangKiNghi = new System.Windows.Forms.DataGridView();
            this.dangKiNghiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.dangKiNghiTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.DangKiNghiTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxdenngay = new System.Windows.Forms.TextBox();
            this.textBoxtungay = new System.Windows.Forms.TextBox();
            this.textBoxtennhanvien = new System.Windows.Forms.TextBox();
            this.textBoxmanhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonquaylai = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxlido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxtrangthai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangKiNghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKiNghiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDangKiNghi
            // 
            this.dataGridViewDangKiNghi.AutoGenerateColumns = false;
            this.dataGridViewDangKiNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDangKiNghi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenNVDataGridViewTextBoxColumn,
            this.tuNgayDataGridViewTextBoxColumn,
            this.denNgayDataGridViewTextBoxColumn,
            this.liDoDataGridViewTextBoxColumn,
            this.Trangthai});
            this.dataGridViewDangKiNghi.DataSource = this.dangKiNghiBindingSource;
            this.dataGridViewDangKiNghi.Location = new System.Drawing.Point(3, 259);
            this.dataGridViewDangKiNghi.Name = "dataGridViewDangKiNghi";
            this.dataGridViewDangKiNghi.Size = new System.Drawing.Size(795, 289);
            this.dataGridViewDangKiNghi.TabIndex = 0;
            // 
            // dangKiNghiBindingSource
            // 
            this.dangKiNghiBindingSource.DataMember = "DangKiNghi";
            this.dangKiNghiBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangKiNghiTableAdapter
            // 
            this.dangKiNghiTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.textBoxtrangthai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxlido);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonquaylai);
            this.panel1.Controls.Add(this.buttonluu);
            this.panel1.Controls.Add(this.textBoxdenngay);
            this.panel1.Controls.Add(this.textBoxtungay);
            this.panel1.Controls.Add(this.textBoxtennhanvien);
            this.panel1.Controls.Add(this.textBoxmanhanVien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewDangKiNghi);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 551);
            this.panel1.TabIndex = 1;
            // 
            // textBoxdenngay
            // 
            this.textBoxdenngay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxdenngay.Location = new System.Drawing.Point(131, 177);
            this.textBoxdenngay.Name = "textBoxdenngay";
            this.textBoxdenngay.Size = new System.Drawing.Size(252, 25);
            this.textBoxdenngay.TabIndex = 19;
            // 
            // textBoxtungay
            // 
            this.textBoxtungay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxtungay.Location = new System.Drawing.Point(131, 126);
            this.textBoxtungay.Name = "textBoxtungay";
            this.textBoxtungay.Size = new System.Drawing.Size(252, 25);
            this.textBoxtungay.TabIndex = 18;
            // 
            // textBoxtennhanvien
            // 
            this.textBoxtennhanvien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxtennhanvien.Location = new System.Drawing.Point(131, 75);
            this.textBoxtennhanvien.Name = "textBoxtennhanvien";
            this.textBoxtennhanvien.Size = new System.Drawing.Size(252, 25);
            this.textBoxtennhanvien.TabIndex = 17;
            // 
            // textBoxmanhanVien
            // 
            this.textBoxmanhanVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxmanhanVien.Location = new System.Drawing.Point(131, 27);
            this.textBoxmanhanVien.Name = "textBoxmanhanVien";
            this.textBoxmanhanVien.Size = new System.Drawing.Size(252, 25);
            this.textBoxmanhanVien.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Đến Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Từ Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // buttonquaylai
            // 
            this.buttonquaylai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonquaylai.Location = new System.Drawing.Point(674, 214);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(90, 30);
            this.buttonquaylai.TabIndex = 21;
            this.buttonquaylai.Text = "Quay Lại";
            this.buttonquaylai.UseVisualStyleBackColor = true;
            // 
            // buttonluu
            // 
            this.buttonluu.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonluu.Location = new System.Drawing.Point(519, 214);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(90, 30);
            this.buttonluu.TabIndex = 20;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = true;
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
            this.hoTenNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // tuNgayDataGridViewTextBoxColumn
            // 
            this.tuNgayDataGridViewTextBoxColumn.DataPropertyName = "TuNgay";
            this.tuNgayDataGridViewTextBoxColumn.HeaderText = "Từ Ngày";
            this.tuNgayDataGridViewTextBoxColumn.Name = "tuNgayDataGridViewTextBoxColumn";
            this.tuNgayDataGridViewTextBoxColumn.Width = 80;
            // 
            // denNgayDataGridViewTextBoxColumn
            // 
            this.denNgayDataGridViewTextBoxColumn.DataPropertyName = "DenNgay";
            this.denNgayDataGridViewTextBoxColumn.HeaderText = "Đến Ngày";
            this.denNgayDataGridViewTextBoxColumn.Name = "denNgayDataGridViewTextBoxColumn";
            this.denNgayDataGridViewTextBoxColumn.Width = 80;
            // 
            // liDoDataGridViewTextBoxColumn
            // 
            this.liDoDataGridViewTextBoxColumn.DataPropertyName = "LiDo";
            this.liDoDataGridViewTextBoxColumn.HeaderText = "Lí Do";
            this.liDoDataGridViewTextBoxColumn.Name = "liDoDataGridViewTextBoxColumn";
            this.liDoDataGridViewTextBoxColumn.Width = 230;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.Width = 90;
            // 
            // textBoxlido
            // 
            this.textBoxlido.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxlido.Location = new System.Drawing.Point(519, 75);
            this.textBoxlido.Name = "textBoxlido";
            this.textBoxlido.Size = new System.Drawing.Size(252, 25);
            this.textBoxlido.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Lí Do";
            // 
            // textBoxtrangthai
            // 
            this.textBoxtrangthai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxtrangthai.Location = new System.Drawing.Point(519, 126);
            this.textBoxtrangthai.Name = "textBoxtrangthai";
            this.textBoxtrangthai.Size = new System.Drawing.Size(252, 25);
            this.textBoxtrangthai.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Trạng Thái";
            // 
            // DangKiNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 552);
            this.Controls.Add(this.panel1);
            this.Name = "DangKiNghi";
            this.Text = "DangKiNghi";
            this.Load += new System.EventHandler(this.DangKiNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangKiNghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKiNghiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDangKiNghi;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource dangKiNghiBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.DangKiNghiTableAdapter dangKiNghiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxdenngay;
        private System.Windows.Forms.TextBox textBoxtungay;
        private System.Windows.Forms.TextBox textBoxtennhanvien;
        private System.Windows.Forms.TextBox textBoxmanhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonquaylai;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.TextBox textBoxtrangthai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxlido;
        private System.Windows.Forms.Label label5;
    }
}