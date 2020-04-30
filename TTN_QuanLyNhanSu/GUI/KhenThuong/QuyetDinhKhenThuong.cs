using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.KhenThuong
{
    public partial class QuyetDinhKhenThuong : Form
    {
        public QuyetDinhKhenThuong()
        {
            InitializeComponent();
        }

        private void QuyetDinhKhenThuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.KhenThuong' table. You can move, or remove it, as needed.
            this.khenThuongTableAdapter.Fill(this.tTN_QLNhanSuDataSet.KhenThuong);

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemQuyetDinhKhenThuong formThemQuyetDinhKhenThuong = new ThemQuyetDinhKhenThuong();
            formThemQuyetDinhKhenThuong.FormClosed += FormThemQuyetDinhKhenThuong_FormClosed;
            formThemQuyetDinhKhenThuong.Show();
        }

        private void FormThemQuyetDinhKhenThuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietKhenThuong formChiTietKhenThuong = new ChiTietKhenThuong();
            formChiTietKhenThuong.FormClosed += FormChiTietKhenThuong_FormClosed;
            formChiTietKhenThuong.Show();

        }

        private void FormChiTietKhenThuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonKhenThuongNhanSu_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhenThuongNhanVien formKhenThuongNhanVien = new KhenThuongNhanVien();
            formKhenThuongNhanVien.FormClosed += FormKhenThuongNhanVien_FormClosed;
            formKhenThuongNhanVien.Show();
        }

        private void FormKhenThuongNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
