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

        /// <summary>
        /// 
        /// - Button Thêm sang form thêm hình thức mới.
        /// 
        /// - Button Chi Tiết : Chọn 1 row dưới datagrid thì mới mở và mang dữ liệu sang form bên kia.
        /// 
        /// - Button nhân viên bị kỉ luật : Chọn 1 row dưới datagrid thì mới mở và mang dữ liệu sang form bên kia,
        ///     nhét vào cột bên  trái.
        /// 
        /// - Button Danh Sách nhân viên bị kỷ luật : chọn 1 dòng dưới datagrid thì mới mở và hiển thị bên form mới:
        ///     Danh sách các nhân viên bị dính kỷ luật đó.
        ///     
        /// - Button Tìm kiếm : Tìm kiếm theo lí do .
        /// 
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview
        /// 
        /// - Đưa ra danh sách nhân viên bị kỷ luật theo số quyết định.(gồm mã nhân viên , tên nhân viên) button danh sách nhân viên bị kỉ luật.
        /// </summary>
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

        private void buttonDSNVBiKyLuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachNVBiKL danhSachNVBiKL = new DanhSachNVBiKL();
            danhSachNVBiKL.FormClosed += DanhSachNVBiKL_FormClosed;
            danhSachNVBiKL.Show();
        }

        private void DanhSachNVBiKL_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
