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

namespace TTN_QuanLyNhanSu.GUI.KhenThuong
{


    /// <summary>
    /// 
    /// - Button Thêm sang form Thêm mới 1 quyết dịnh khen thưởng .
    /// 
    /// - Button Chi tiết : chọn 1 dòng tren dataGridView thì Enable = true , ném dữ liệu dòng đó sang bên form chi tiết.
    /// 
    /// - Button khen thưởng nhân viên : chọn 1 dòng tren dataGridView thì Enable = true , ném dữ liệu dòng đó sang bên form Khen thưởng nhân viên
    ///     đặt vào các textbox của bên trái. 
    /// 
    /// - Tìm kiến theo nội dung khen thưởng.
    /// 
    /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview
    /// 
    /// - Đưa ra danh sách nhwungx nhaanvieen được khen thưởng theo số quyết dịnh gồm(mã nhân viên, tên nhân viên)
    /// 
    /// </summary>
    public partial class QuyetDinhKhenThuong : Form
    {
        public QuyetDinhKhenThuong()
        {
            InitializeComponent();
        }
        List<DTO.KhenThuong> khenThuongs;
        KhenThuongBUS khenThuongController = new KhenThuongBUS();
        public static string soQuyetDinh = "";
        private void QuyetDinhKhenThuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.KhenThuong' table. You can move, or remove it, as needed.
            this.khenThuongTableAdapter.Fill(this.tTN_QLNhanSuDataSet.KhenThuong);
            dataGridViewQuyetDinhKhenThuong.AllowUserToAddRows = false;
            dataGridViewQuyetDinhKhenThuong.AllowUserToDeleteRows = false;
            dataGridViewQuyetDinhKhenThuong.AllowUserToResizeRows = false;
            dataGridViewQuyetDinhKhenThuong.AllowUserToResizeColumns = false;
            dataGridViewQuyetDinhKhenThuong.MultiSelect = false;
            dataGridViewQuyetDinhKhenThuong.RowHeadersVisible = false;
            dataGridViewQuyetDinhKhenThuong.ReadOnly = true;
            dataGridViewQuyetDinhKhenThuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            khenThuongs = khenThuongController.Show_All_KhenThuongs();
            UpdateThongTin();

        }
        private void UpdateThongTin()
        {
            dataGridViewQuyetDinhKhenThuong.DataSource = khenThuongs;
            textBoxTong.Text = khenThuongs.Count.ToString();
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
            khenThuongs = khenThuongController.Show_All_KhenThuongs();
            UpdateThongTin();
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
            khenThuongs = khenThuongController.Show_All_KhenThuongs();
            UpdateThongTin();
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
            khenThuongs = khenThuongController.Show_All_KhenThuongs();
            UpdateThongTin();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDSNVBiKyLuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachNVDuocKT danhSachNVDuocKT = new DanhSachNVDuocKT();
            danhSachNVDuocKT.FormClosed += DanhSachNVDuocKT_FormClosed;
            danhSachNVDuocKT.Show();
        }

        private void DanhSachNVDuocKT_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if(textBoxTimKiem.Text != "")
            {
                khenThuongs = khenThuongController.Search_KhenThuong_TheoNoiDung(textBoxTimKiem.Text);
                UpdateThongTin();
            }
            else
            {
                khenThuongs = khenThuongController.Show_All_KhenThuongs();
                UpdateThongTin();
            }
            
        }

        private void dataGridViewQuyetDinhKhenThuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonChiTiet.Enabled = true;
            buttonDSNVBiKyLuat.Enabled = true;
            buttonDSNVBiKyLuat.Enabled = true;
            DataGridViewRow currentRow = dataGridViewQuyetDinhKhenThuong.CurrentRow;
            soQuyetDinh = currentRow.Cells[0].Value.ToString();
        }
    }
}
