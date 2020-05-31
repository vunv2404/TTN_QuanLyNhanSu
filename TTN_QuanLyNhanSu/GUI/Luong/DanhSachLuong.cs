using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QuanLyNhanSu.BUS;

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

        LuongBUS contrlLuong = new LuongBUS();
        string maNV;

        private static DataGridView dtgvDSLuong;
        public static DataGridView DtgvDSLuong { get => dtgvDSLuong; set => dtgvDSLuong = value; }
        private static TextBox textboxTong;
        public static TextBox TextboxTong { get => textboxTong; set => textboxTong = value; }

        public DanhSachLuong()
        {
            InitializeComponent();

            dtgvDSLuong = dataGridViewDanhSachLuong;
            textboxTong = textBoxTong;
        }

        private void DanhSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.Luong' table. You can move, or remove it, as needed.
            //this.luongTableAdapter.Fill(this.tTN_QLNhanSuDataSet.Luong);
            dataGridViewDanhSachLuong.DataSource = contrlLuong.TatCaLuongNV();
            dataGridViewDanhSachLuong.Refresh();

            textBoxTong.Text = dataGridViewDanhSachLuong.Rows.Count.ToString();
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
            ChiTietLuongNV formChiTietLuongNV = new ChiTietLuongNV(maNV);
            formChiTietLuongNV.FormClosed += FormChiTietLuongNV_FormClosed;
            formChiTietLuongNV.Show();

            buttonChiTiet.Enabled = true;
        }

        private void FormChiTietLuongNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string keywords = textBoxTimKiem.Text;

            DataTable dsLuong = contrlLuong.TatCaLuongNV();
            DataTable items = dsLuong;

            items = contrlLuong.TimKiemTenNV(keywords);

            dataGridViewDanhSachLuong.DataSource = items;
            dataGridViewDanhSachLuong.Refresh();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewDanhSachLuong_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhSachLuong.Rows.Count == 0)
            {
                MessageBox.Show("Hãy thêm lương mới");
            }
            else
            {
                int index = dataGridViewDanhSachLuong.SelectedRows[0].Index;

                maNV = dataGridViewDanhSachLuong.Rows[index].Cells["maNVDataGridViewTextBoxColumn"].Value.ToString();

                buttonChiTiet.Enabled = true;
            }
        }
    }
}
