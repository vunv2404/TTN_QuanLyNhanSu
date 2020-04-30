using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.KyLuat
{
    public partial class QuyetDinhKyLuat : Form
    {
        public QuyetDinhKyLuat()
        {
            InitializeComponent();
        }

        private void QuyetDinhKyLuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.KyLuat' table. You can move, or remove it, as needed.
            this.kyLuatTableAdapter.Fill(this.tTN_QLNhanSuDataSet.KyLuat);

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemQuyetDinhKyLuat formThemQuyetDinhKyLuat = new ThemQuyetDinhKyLuat();
            formThemQuyetDinhKyLuat.FormClosed += FormThemQuyetDinhKyLuat_FormClosed;
            formThemQuyetDinhKyLuat.Show();
        }

        private void FormThemQuyetDinhKyLuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietQuyetDinhKyLuat formChiTietQuyetDinhKyLuat = new ChiTietQuyetDinhKyLuat();
            formChiTietQuyetDinhKyLuat.FormClosed += FormChiTietQuyetDinhKyLuat_FormClosed;
            formChiTietQuyetDinhKyLuat.Show();
        }

        private void FormChiTietQuyetDinhKyLuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonKyLuatNhanSu_Click(object sender, EventArgs e)
        {
            this.Hide();
            KyLuatNhanVien formKyLuatNhanVien = new KyLuatNhanVien();
            formKyLuatNhanVien.FormClosed += FormKyLuatNhanVien_FormClosed;
            formKyLuatNhanVien.Show();
        }

        private void FormKyLuatNhanVien_FormClosed(object sender, FormClosedEventArgs e)
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
