namespace TTN_QuanLyNhanSu.GUI
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLamThem = new System.Windows.Forms.Button();
            this.buttonChuyenCa = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonLuong = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonDaoTao = new System.Windows.Forms.Button();
            this.buttonKyLuat = new System.Windows.Forms.Button();
            this.buttonKhenThuong = new System.Windows.Forms.Button();
            this.buttonBaoHiem = new System.Windows.Forms.Button();
            this.buttonHopDongNS = new System.Windows.Forms.Button();
            this.buttonHoSoNS = new System.Windows.Forms.Button();
            this.buttonBoPhan = new System.Windows.Forms.Button();
            this.buttonPhongBan = new System.Windows.Forms.Button();
            this.buttonNghi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 583);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(318, 113);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Phòng Ban";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(659, 448);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(353, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Nhân Sự";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.pictureBox12);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonLamThem);
            this.groupBox1.Controls.Add(this.buttonChuyenCa);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.buttonLuong);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.buttonDaoTao);
            this.groupBox1.Controls.Add(this.buttonKyLuat);
            this.groupBox1.Controls.Add(this.buttonKhenThuong);
            this.groupBox1.Controls.Add(this.buttonBaoHiem);
            this.groupBox1.Controls.Add(this.buttonHopDongNS);
            this.groupBox1.Controls.Add(this.buttonHoSoNS);
            this.groupBox1.Controls.Add(this.buttonBoPhan);
            this.groupBox1.Controls.Add(this.buttonPhongBan);
            this.groupBox1.Controls.Add(this.buttonNghi);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::TTN_QuanLyNhanSu.Properties.Resources.round_device_hub_black_18dp;
            this.pictureBox12.Location = new System.Drawing.Point(14, 310);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(30, 30);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::TTN_QuanLyNhanSu.Properties.Resources.baseline_group_black_18dp;
            this.pictureBox7.Location = new System.Drawing.Point(14, 63);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::TTN_QuanLyNhanSu.Properties.Resources.round_cancel_schedule_send_black_18dp;
            this.pictureBox10.Location = new System.Drawing.Point(14, 227);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::TTN_QuanLyNhanSu.Properties.Resources.baseline_text_snippet_black_18dp;
            this.pictureBox11.Location = new System.Drawing.Point(13, 145);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::TTN_QuanLyNhanSu.Properties.Resources.round_euro_symbol_black_18dp;
            this.pictureBox9.Location = new System.Drawing.Point(13, 350);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::TTN_QuanLyNhanSu.Properties.Resources.baseline_sync_black_18dp;
            this.pictureBox8.Location = new System.Drawing.Point(13, 392);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(29, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TTN_QuanLyNhanSu.Properties.Resources.round_note_add_black_18dp;
            this.pictureBox4.Location = new System.Drawing.Point(14, 430);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TTN_QuanLyNhanSu.Properties.Resources.round_how_to_reg_black_18dp;
            this.pictureBox5.Location = new System.Drawing.Point(14, 186);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::TTN_QuanLyNhanSu.Properties.Resources.baseline_priority_high_black_18dp;
            this.pictureBox6.Location = new System.Drawing.Point(14, 268);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TTN_QuanLyNhanSu.Properties.Resources.baseline_assignment_ind_black_18dp;
            this.pictureBox1.Location = new System.Drawing.Point(14, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLamThem
            // 
            this.buttonLamThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLamThem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamThem.Location = new System.Drawing.Point(11, 427);
            this.buttonLamThem.Name = "buttonLamThem";
            this.buttonLamThem.Size = new System.Drawing.Size(198, 35);
            this.buttonLamThem.TabIndex = 10;
            this.buttonLamThem.Text = "Đăng Kí Làm Thêm";
            this.buttonLamThem.UseVisualStyleBackColor = true;
            this.buttonLamThem.Click += new System.EventHandler(this.buttonLamThem_Click);
            // 
            // buttonChuyenCa
            // 
            this.buttonChuyenCa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChuyenCa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChuyenCa.Location = new System.Drawing.Point(11, 389);
            this.buttonChuyenCa.Name = "buttonChuyenCa";
            this.buttonChuyenCa.Size = new System.Drawing.Size(198, 35);
            this.buttonChuyenCa.TabIndex = 9;
            this.buttonChuyenCa.Text = "Đăng Kí chuyển Ca";
            this.buttonChuyenCa.UseVisualStyleBackColor = true;
            this.buttonChuyenCa.Click += new System.EventHandler(this.buttonChuyenCa_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TTN_QuanLyNhanSu.Properties.Resources.baseline_store_mall_directory_black_18dp;
            this.pictureBox3.Location = new System.Drawing.Point(14, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // buttonLuong
            // 
            this.buttonLuong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLuong.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuong.Location = new System.Drawing.Point(11, 348);
            this.buttonLuong.Name = "buttonLuong";
            this.buttonLuong.Size = new System.Drawing.Size(198, 35);
            this.buttonLuong.TabIndex = 8;
            this.buttonLuong.Text = "Lương";
            this.buttonLuong.UseVisualStyleBackColor = true;
            this.buttonLuong.Click += new System.EventHandler(this.buttonLuong_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TTN_QuanLyNhanSu.Properties.Resources.baseline_airline_seat_flat_black_18dp;
            this.pictureBox2.Location = new System.Drawing.Point(14, 470);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // buttonDaoTao
            // 
            this.buttonDaoTao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDaoTao.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDaoTao.Location = new System.Drawing.Point(11, 307);
            this.buttonDaoTao.Name = "buttonDaoTao";
            this.buttonDaoTao.Size = new System.Drawing.Size(198, 35);
            this.buttonDaoTao.TabIndex = 7;
            this.buttonDaoTao.Text = "Đào Tạo";
            this.buttonDaoTao.UseVisualStyleBackColor = true;
            this.buttonDaoTao.Click += new System.EventHandler(this.buttonDaoTao_Click);
            // 
            // buttonKyLuat
            // 
            this.buttonKyLuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKyLuat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKyLuat.Location = new System.Drawing.Point(11, 266);
            this.buttonKyLuat.Name = "buttonKyLuat";
            this.buttonKyLuat.Size = new System.Drawing.Size(198, 35);
            this.buttonKyLuat.TabIndex = 6;
            this.buttonKyLuat.Text = "Kỷ Luật";
            this.buttonKyLuat.UseVisualStyleBackColor = true;
            this.buttonKyLuat.Click += new System.EventHandler(this.buttonKyLuat_Click);
            // 
            // buttonKhenThuong
            // 
            this.buttonKhenThuong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKhenThuong.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKhenThuong.Location = new System.Drawing.Point(11, 225);
            this.buttonKhenThuong.Name = "buttonKhenThuong";
            this.buttonKhenThuong.Size = new System.Drawing.Size(198, 35);
            this.buttonKhenThuong.TabIndex = 5;
            this.buttonKhenThuong.Text = "Khen Thưởng";
            this.buttonKhenThuong.UseVisualStyleBackColor = true;
            this.buttonKhenThuong.Click += new System.EventHandler(this.buttonKhenThuong_Click);
            // 
            // buttonBaoHiem
            // 
            this.buttonBaoHiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBaoHiem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaoHiem.Location = new System.Drawing.Point(11, 184);
            this.buttonBaoHiem.Name = "buttonBaoHiem";
            this.buttonBaoHiem.Size = new System.Drawing.Size(198, 35);
            this.buttonBaoHiem.TabIndex = 4;
            this.buttonBaoHiem.Text = "Bảo Hiểm";
            this.buttonBaoHiem.UseVisualStyleBackColor = true;
            this.buttonBaoHiem.Click += new System.EventHandler(this.buttonBaoHiem_Click);
            // 
            // buttonHopDongNS
            // 
            this.buttonHopDongNS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHopDongNS.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHopDongNS.Location = new System.Drawing.Point(11, 143);
            this.buttonHopDongNS.Name = "buttonHopDongNS";
            this.buttonHopDongNS.Size = new System.Drawing.Size(200, 35);
            this.buttonHopDongNS.TabIndex = 3;
            this.buttonHopDongNS.Text = "Hợp Đồng Nhân Sự";
            this.buttonHopDongNS.UseVisualStyleBackColor = true;
            this.buttonHopDongNS.Click += new System.EventHandler(this.buttonHopDongNS_Click);
            // 
            // buttonHoSoNS
            // 
            this.buttonHoSoNS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHoSoNS.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHoSoNS.Location = new System.Drawing.Point(11, 102);
            this.buttonHoSoNS.Name = "buttonHoSoNS";
            this.buttonHoSoNS.Size = new System.Drawing.Size(200, 35);
            this.buttonHoSoNS.TabIndex = 2;
            this.buttonHoSoNS.Text = "Hồ Sơ Nhân Sự";
            this.buttonHoSoNS.UseVisualStyleBackColor = true;
            this.buttonHoSoNS.Click += new System.EventHandler(this.buttonHoSoNS_Click);
            // 
            // buttonBoPhan
            // 
            this.buttonBoPhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBoPhan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBoPhan.Location = new System.Drawing.Point(11, 61);
            this.buttonBoPhan.Name = "buttonBoPhan";
            this.buttonBoPhan.Size = new System.Drawing.Size(198, 35);
            this.buttonBoPhan.TabIndex = 1;
            this.buttonBoPhan.Text = "Bộ Phận";
            this.buttonBoPhan.UseVisualStyleBackColor = true;
            this.buttonBoPhan.Click += new System.EventHandler(this.buttonBoPhan_Click);
            // 
            // buttonPhongBan
            // 
            this.buttonPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPhongBan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhongBan.Location = new System.Drawing.Point(11, 20);
            this.buttonPhongBan.Name = "buttonPhongBan";
            this.buttonPhongBan.Size = new System.Drawing.Size(198, 35);
            this.buttonPhongBan.TabIndex = 0;
            this.buttonPhongBan.Text = "Phòng Ban";
            this.buttonPhongBan.UseVisualStyleBackColor = true;
            this.buttonPhongBan.Click += new System.EventHandler(this.buttonPhongBan_Click);
            // 
            // buttonNghi
            // 
            this.buttonNghi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNghi.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNghi.Location = new System.Drawing.Point(11, 468);
            this.buttonNghi.Name = "buttonNghi";
            this.buttonNghi.Size = new System.Drawing.Size(198, 35);
            this.buttonNghi.TabIndex = 11;
            this.buttonNghi.Text = "Đăng Kí Nghỉ";
            this.buttonNghi.UseVisualStyleBackColor = true;
            this.buttonNghi.Click += new System.EventHandler(this.buttonNghi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 583);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNghi;
        private System.Windows.Forms.Button buttonLamThem;
        private System.Windows.Forms.Button buttonChuyenCa;
        private System.Windows.Forms.Button buttonLuong;
        private System.Windows.Forms.Button buttonDaoTao;
        private System.Windows.Forms.Button buttonKyLuat;
        private System.Windows.Forms.Button buttonKhenThuong;
        private System.Windows.Forms.Button buttonBaoHiem;
        private System.Windows.Forms.Button buttonHopDongNS;
        private System.Windows.Forms.Button buttonHoSoNS;
        private System.Windows.Forms.Button buttonBoPhan;
        private System.Windows.Forms.Button buttonPhongBan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}