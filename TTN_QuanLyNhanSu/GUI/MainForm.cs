using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QuanLyNhanSu.GUI.BaoHiem;
using TTN_QuanLyNhanSu.GUI.BoPhan;
using TTN_QuanLyNhanSu.GUI.ChamCong;
using TTN_QuanLyNhanSu.GUI.DaoTao;
using TTN_QuanLyNhanSu.GUI.HopDongNhanSu;
using TTN_QuanLyNhanSu.GUI.HoSoNhanSu;
using TTN_QuanLyNhanSu.GUI.KhenThuong;
using TTN_QuanLyNhanSu.GUI.KyLuat;
using TTN_QuanLyNhanSu.GUI.Luong;
using TTN_QuanLyNhanSu.GUI.PhongBan;

namespace TTN_QuanLyNhanSu.GUI
{
    public partial class MainForm : Form
    {
        public object KhoaHocDaotao { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonPhongBan_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachPhongBan formDanhSachPhongBan = new DanhSachPhongBan();
            formDanhSachPhongBan.FormClosed += FormDanhSachPhongBan_FormClosed;
            formDanhSachPhongBan.Show();
        }

        private void FormDanhSachPhongBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonBoPhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachBoPhan formDanhSachBoPhan = new DanhSachBoPhan();
            formDanhSachBoPhan.FormClosed += FormDanhSachBoPhan_FormClosed;
            formDanhSachBoPhan.Show();
        }

        private void FormDanhSachBoPhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonHoSoNS_Click(object sender, EventArgs e)
        {
            this.Hide();
            ToanBoNhanSu formToanBoNhanSu = new ToanBoNhanSu();
            formToanBoNhanSu.FormClosed += FormToanBoNhanSu_FormClosed;
            formToanBoNhanSu.Show();
        }

        private void FormToanBoNhanSu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonHopDongNS_Click(object sender, EventArgs e)
        {
            this.Hide();
            ToanBoHopDong formToanBoHopDong = new ToanBoHopDong();
            formToanBoHopDong.FormClosed += FormToanBoHopDong_FormClosed;
            formToanBoHopDong.Show();
        }

        private void FormToanBoHopDong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonBaoHiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachBaoHiem formDanhSachBaoHiem = new DanhSachBaoHiem();
            formDanhSachBaoHiem.FormClosed += FormDanhSachBaoHiem_FormClosed;
            formDanhSachBaoHiem.Show();
        }

        private void FormDanhSachBaoHiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonKhenThuong_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuyetDinhKhenThuong formQuyetDinhKhenThuong = new QuyetDinhKhenThuong();
            formQuyetDinhKhenThuong.FormClosed += FormQuyetDinhKhenThuong_FormClosed;
            formQuyetDinhKhenThuong.Show();
        }

        private void FormQuyetDinhKhenThuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonKyLuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuyetDinhKyLuat formQuyetDinhKyLuat = new QuyetDinhKyLuat();
            formQuyetDinhKyLuat.FormClosed += FormQuyetDinhKyLuat_FormClosed;
            formQuyetDinhKyLuat.Show();
        }

        private void FormQuyetDinhKyLuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonDaoTao_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoaHocDaoTao formKhoaHocDaoTao = new KhoaHocDaoTao();
            formKhoaHocDaoTao.FormClosed += FormKhoaHocDaoTao_FormClosed;
            formKhoaHocDaoTao.Show();
        }

        private void FormKhoaHocDaoTao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonLuong_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachLuong formDanhSachLuong = new DanhSachLuong();
            formDanhSachLuong.FormClosed += FormDanhSachLuong_FormClosed;
            formDanhSachLuong.Show();
        }

        private void FormDanhSachLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonChuyenCa_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKiChuyenCa formDangKiChuyenCa = new DangKiChuyenCa();
            formDangKiChuyenCa.FormClosed += FormDangKiChuyenCa_FormClosed;
            formDangKiChuyenCa.Show();
        }

        private void FormDangKiChuyenCa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonLamThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKiLamThem formDangKiLamThem = new DangKiLamThem();
            formDangKiLamThem.FormClosed += FormDangKiLamThem_FormClosed;
            formDangKiLamThem.Show();
        }

        private void FormDangKiLamThem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonNghi_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKiNghi formDangKiNghi = new DangKiNghi();
            formDangKiNghi.FormClosed += FormDangKiNghi_FormClosed;
            formDangKiNghi.Show();
        }

        private void FormDangKiNghi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
