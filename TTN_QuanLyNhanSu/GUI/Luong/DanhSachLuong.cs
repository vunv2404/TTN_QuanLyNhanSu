using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.Luong
{
    public partial class DanhSachLuong : Form
    {

        /// <summary>
        /// 
        /// - Button Them sang form thêm mới .
        /// 
        /// - Button CHitieets : click 1 dòng trên dataGrid nút này dc mở và sang form chi tiết.
        /// 
        /// - Tìm Kiếm theo tên nhân viên.
        /// 
        /// - textBox Tổng là số bản ghi hiện tại có trên datagridView
        /// </summary>

        public DanhSachLuong()
        {
            InitializeComponent();
        }

        private void DanhSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter.Fill(this.tTN_QLNhanSuDataSet.Luong);

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemLuongNV formThemLuongNV = new ThemLuongNV();
            formThemLuongNV.FormClosed += FormThemLuongNV_FormClosed;
            formThemLuongNV.Show();
        }

        private void FormThemLuongNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietLuongNV formChiTietLuongNV = new ChiTietLuongNV();
            formChiTietLuongNV.FormClosed += FormChiTietLuongNV_FormClosed;
            formChiTietLuongNV.Show();
        }

        private void FormChiTietLuongNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
