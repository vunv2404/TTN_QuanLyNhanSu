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
            this.baoHiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.baoHiemTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.BaoHiemTableAdapter();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.dataGridViewdsBaoHiem = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBaoHiemXHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBaoHiemYTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baoHiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdsBaoHiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // baoHiemTableAdapter
            // 
            this.baoHiemTableAdapter.ClearBeforeFill = true;
            // 
            // buttonThem
            // 
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(19, 19);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(90, 30);
            this.buttonThem.TabIndex = 20;
            this.buttonThem.Text = "+ Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuayLai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(620, 81);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(90, 30);
            this.buttonQuayLai.TabIndex = 21;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTimKiem.Location = new System.Drawing.Point(280, 22);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(349, 25);
            this.textBoxTimKiem.TabIndex = 25;
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
            this.dataGridViewdsBaoHiem.Location = new System.Drawing.Point(3, 125);
            this.dataGridViewdsBaoHiem.Name = "dataGridViewdsBaoHiem";
            this.dataGridViewdsBaoHiem.Size = new System.Drawing.Size(791, 393);
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
            this.noiCapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noiCapDataGridViewTextBoxColumn.DataPropertyName = "NoiCap";
            this.noiCapDataGridViewTextBoxColumn.HeaderText = "Nơi Cấp";
            this.noiCapDataGridViewTextBoxColumn.Name = "noiCapDataGridViewTextBoxColumn";
            // 
            // ngayCapDataGridViewTextBoxColumn
            // 
            this.ngayCapDataGridViewTextBoxColumn.DataPropertyName = "NgayCap";
            this.ngayCapDataGridViewTextBoxColumn.HeaderText = "Ngày Cấp";
            this.ngayCapDataGridViewTextBoxColumn.Name = "ngayCapDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridViewdsBaoHiem);
            this.panel1.Controls.Add(this.buttonQuayLai);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 526);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTimKiem);
            this.groupBox1.Controls.Add(this.buttonChiTiet);
            this.groupBox1.Controls.Add(this.textBoxTimKiem);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Location = new System.Drawing.Point(19, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 64);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(651, 19);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(90, 30);
            this.buttonTimKiem.TabIndex = 22;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // buttonChiTiet
            // 
            this.buttonChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChiTiet.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiTiet.Location = new System.Drawing.Point(154, 19);
            this.buttonChiTiet.Name = "buttonChiTiet";
            this.buttonChiTiet.Size = new System.Drawing.Size(90, 30);
            this.buttonChiTiet.TabIndex = 21;
            this.buttonChiTiet.Text = "Chi Tiết";
            this.buttonChiTiet.UseVisualStyleBackColor = true;
            this.buttonChiTiet.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // DanhSachBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 522);
            this.Controls.Add(this.panel1);
            this.Name = "DanhSachBaoHiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachBaoHiem";
            this.Load += new System.EventHandler(this.DanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baoHiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdsBaoHiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource baoHiemBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.BaoHiemTableAdapter baoHiemTableAdapter;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewdsBaoHiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBaoHiemXHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBaoHiemYTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapDataGridViewTextBoxColumn;
    }
}