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
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.GUI.DaoTao
{
    public partial class DaoTaoNhanVien : Form
    {

        /// <summary>
        /// - Ném dữ liệu từ database lên combobox mã nhân viên
        /// 
        /// - tất cả các textbox phía dưới mã nhân viên phải lấy thông tin lên đặt vào .
        /// 
        /// - chỉ việc chọn mã nhân viên ở combobox thì tất cả dữ liệu của nhaanvieen ở các textbox cũng được đồng bộ.
        /// 
        /// - Lấy dữ liệu bên khóa học đào tạo đặt vào các textbox tương ứng .
        /// 
        /// - trước khi thêm hiện ra thông báo có muốn thêm ko.
        /// 
        /// </summary>
        /// 
        List<DTO.NhanSu> nhanSus;
        NhanVienBUS nhanVienBUS;
        DaoTaoBUS daoTaoBUS;
        public DaoTaoNhanVien(DTO.DaoTao daoTao)
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
            daoTaoBUS = new DaoTaoBUS();
            textBoxMaDaoTao.Text = daoTao.MaDaoTao;
            textBoxNgayLap.Text = daoTao.NgayLap.ToString("MM/dd/yyyy");
            textBoxMucDich.Text = daoTao.MucDich;
            textBoxSoLuong.Text = daoTao.SoLuong.ToString();
            textBoxNguoiPhuTrach.Text = daoTao.NguoiPhuTrach;
            textBoxChiPhi.Text = daoTao.ChiPhi.ToString();
            textBoxTinhTrang.Text = daoTao.TrangThai;
        }



        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (daoTaoBUS.DaoTaoNhanVien(comboBoxMaNhanVien.Text, textBoxMaDaoTao.Text))
            {
                MessageBox.Show("Nhân viên đã được thêm vào danh sách đào tạo");
            }
            else
            {
                MessageBox.Show("Không thể thêm nhân viên vào danh sách");
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DaoTaoNhanVien_Load(object sender, EventArgs e)
        {
            nhanSus = nhanVienBUS.DanhSachNhanSu();
            comboBoxMaNhanVien.DisplayMember = "MaNV";
            comboBoxMaNhanVien.DataSource = nhanSus;
            ThongTinNhanVien(0);
        }

        private void ThongTinNhanVien(int i)
        {
            textBoxHoTen.Text = nhanSus[i].HoTenNV;
            textBoxNgaySinh.Text = nhanSus[i].NgaySinh.ToString("MM/dd/yyyy");
            textBoxGioiTinh.Text = nhanSus[i].GioiTinh;
            textBoxChucVu.Text = nhanSus[i].ChucVu;
            textBoxBoPhan.Text = nhanSus[i].BoPhan;
            textBoxPhongBan.Text = nhanSus[i].PhongBan;
        }

        private void comboBoxMaNhanVien_TextChanged(object sender, EventArgs e)
        {

            ThongTinNhanVien(comboBoxMaNhanVien.SelectedIndex);
        }
    }
}
