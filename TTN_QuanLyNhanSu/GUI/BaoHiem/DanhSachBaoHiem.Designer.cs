namespace TTN_QuanLyNhanSu.GUI.BaoHiem
{
    partial class DanhSachBaoHiem
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
            this.dataGridViewdsBaoHiem = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBaoHiemXHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBaoHiemYTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baoHiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.textBoxngaycap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxnoicap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonquaylai = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.textBoxsobaohiemyt = new System.Windows.Forms.TextBox();
            this.textBoxsobaohiemxh = new System.Windows.Forms.TextBox();
            this.textBoxtennhanvien = new System.Windows.Forms.TextBox();
            this.textBoxmanhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baoHiemTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.BaoHiemTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdsBaoHiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoHiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.dataGridViewdsBaoHiem);
            this.panel1.Controls.Add(this.textBoxngaycap);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxnoicap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonquaylai);
            this.panel1.Controls.Add(this.buttonluu);
            this.panel1.Controls.Add(this.textBoxsobaohiemyt);
            this.panel1.Controls.Add(this.textBoxsobaohiemxh);
            this.panel1.Controls.Add(this.textBoxtennhanvien);
            this.panel1.Controls.Add(this.textBoxmanhanVien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 541);
            this.panel1.TabIndex = 2;
            // 
            // dataGridViewdsBaoHiem
            // 
            this.dataGridViewdsBaoHiem.AutoGenerateColumns = false;
            this.dataGridViewdsBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdsBaoHiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenNVDataGridViewTextBoxColumn,
            this.soBaoHiemXHDataGridViewTextBoxColumn,
            this.soBaoHiemYTDataGridViewTextBoxColumn,
            this.noiCapDataGridViewTextBoxColumn,
            this.ngayCapDataGridViewTextBoxColumn});
            this.dataGridViewdsBaoHiem.DataSource = this.baoHiemBindingSource;
            this.dataGridViewdsBaoHiem.Location = new System.Drawing.Point(3, 231);
            this.dataGridViewdsBaoHiem.Name = "dataGridViewdsBaoHiem";
            this.dataGridViewdsBaoHiem.Size = new System.Drawing.Size(778, 307);
            this.dataGridViewdsBaoHiem.TabIndex = 26;
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
            this.hoTenNVDataGridViewTextBoxColumn.Width = 160;
            // 
            // soBaoHiemXHDataGridViewTextBoxColumn
            // 
            this.soBaoHiemXHDataGridViewTextBoxColumn.DataPropertyName = "SoBaoHiemXH";
            this.soBaoHiemXHDataGridViewTextBoxColumn.HeaderText = "Số Bảo Hiểm XH";
            this.soBaoHiemXHDataGridViewTextBoxColumn.Name = "soBaoHiemXHDataGridViewTextBoxColumn";
            this.soBaoHiemXHDataGridViewTextBoxColumn.Width = 110;
            // 
            // soBaoHiemYTDataGridViewTextBoxColumn
            // 
            this.soBaoHiemYTDataGridViewTextBoxColumn.DataPropertyName = "SoBaoHiemYT";
            this.soBaoHiemYTDataGridViewTextBoxColumn.HeaderText = "Số Bảo Hiểm YT";
            this.soBaoHiemYTDataGridViewTextBoxColumn.Name = "soBaoHiemYTDataGridViewTextBoxColumn";
            this.soBaoHiemYTDataGridViewTextBoxColumn.Width = 110;
            // 
            // noiCapDataGridViewTextBoxColumn
            // 
            this.noiCapDataGridViewTextBoxColumn.DataPropertyName = "NoiCap";
            this.noiCapDataGridViewTextBoxColumn.HeaderText = "Nơi Cấp";
            this.noiCapDataGridViewTextBoxColumn.Name = "noiCapDataGridViewTextBoxColumn";
            this.noiCapDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayCapDataGridViewTextBoxColumn
            // 
            this.ngayCapDataGridViewTextBoxColumn.DataPropertyName = "NgayCap";
            this.ngayCapDataGridViewTextBoxColumn.HeaderText = "Ngày Cấp";
            this.ngayCapDataGridViewTextBoxColumn.Name = "ngayCapDataGridViewTextBoxColumn";
            // 
            // baoHiemBindingSource
            // 
            this.baoHiemBindingSource.DataMember = "BaoHiem";
            this.baoHiemBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxngaycap
            // 
            this.textBoxngaycap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxngaycap.Location = new System.Drawing.Point(519, 126);
            this.textBoxngaycap.Name = "textBoxngaycap";
            this.textBoxngaycap.Size = new System.Drawing.Size(252, 25);
            this.textBoxngaycap.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ngày Cấp";
            // 
            // textBoxnoicap
            // 
            this.textBoxnoicap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxnoicap.Location = new System.Drawing.Point(519, 75);
            this.textBoxnoicap.Name = "textBoxnoicap";
            this.textBoxnoicap.Size = new System.Drawing.Size(252, 25);
            this.textBoxnoicap.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nơi Cấp";
            // 
            // buttonquaylai
            // 
            this.buttonquaylai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonquaylai.Location = new System.Drawing.Point(670, 185);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(90, 30);
            this.buttonquaylai.TabIndex = 21;
            this.buttonquaylai.Text = "Quay Lại";
            this.buttonquaylai.UseVisualStyleBackColor = true;
            // 
            // buttonluu
            // 
            this.buttonluu.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonluu.Location = new System.Drawing.Point(519, 185);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(90, 30);
            this.buttonluu.TabIndex = 20;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = true;
            // 
            // textBoxsobaohiemyt
            // 
            this.textBoxsobaohiemyt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxsobaohiemyt.Location = new System.Drawing.Point(131, 177);
            this.textBoxsobaohiemyt.Name = "textBoxsobaohiemyt";
            this.textBoxsobaohiemyt.Size = new System.Drawing.Size(252, 25);
            this.textBoxsobaohiemyt.TabIndex = 19;
            // 
            // textBoxsobaohiemxh
            // 
            this.textBoxsobaohiemxh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxsobaohiemxh.Location = new System.Drawing.Point(131, 126);
            this.textBoxsobaohiemxh.Name = "textBoxsobaohiemxh";
            this.textBoxsobaohiemxh.Size = new System.Drawing.Size(252, 25);
            this.textBoxsobaohiemxh.TabIndex = 18;
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
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số Bảo Hiểm YT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Bảo Hiểm XH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // baoHiemTableAdapter
            // 
            this.baoHiemTableAdapter.ClearBeforeFill = true;
            // 
            // DanhSachBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 545);
            this.Controls.Add(this.panel1);
            this.Name = "DanhSachBaoHiem";
            this.Text = "DanhSachBaoHiem";
            this.Load += new System.EventHandler(this.DanhSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdsBaoHiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoHiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxngaycap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxnoicap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonquaylai;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.TextBox textBoxsobaohiemyt;
        private System.Windows.Forms.TextBox textBoxsobaohiemxh;
        private System.Windows.Forms.TextBox textBoxtennhanvien;
        private System.Windows.Forms.TextBox textBoxmanhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.DataGridView dataGridViewdsBaoHiem;
        private System.Windows.Forms.BindingSource baoHiemBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.BaoHiemTableAdapter baoHiemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBaoHiemXHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBaoHiemYTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapDataGridViewTextBoxColumn;
    }
}