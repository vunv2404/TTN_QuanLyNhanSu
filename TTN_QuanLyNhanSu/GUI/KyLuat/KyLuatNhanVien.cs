using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QuanLyNhanSu.BUS;

namespace TTN_QuanLyNhanSu.GUI.KyLuat
{
    public partial class KyLuatNhanVien : Form
    {
        List<DTO.NhanSu> nhanSus;
        NhanVienBUS nhanVienBUS;
        KyLuatBUS kyLuatBUS;
        /// <summary>
        /// 
        /// - Ném dữ liệu từ bảng bên form Kỉ luật sang bên này vứt lên các textbox bên trái.
        /// 
        /// - ném dữ liệu dưới database lên vứt vào combobox mã nhân viên ,
        ///      các thông tin của nhaanvieen đồng bộ theo mã nhân viên.
        ///      
        /// - trước khi lưu thông báo có chắc chắn lưu không.
        /// 
        /// </summary>

        public KyLuatNhanVien()
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
            kyLuatBUS = new KyLuatBUS();
        }

        public KyLuatNhanVien(DTO.KyLuat kyLuat)
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
            kyLuatBUS = new KyLuatBUS();
            textBoxSoQuyetDinh.Text = kyLuat.SoQuyetDinh;
            textBoxNgayHieuLuc.Text = kyLuat.NgayHieuLuc.ToString("MM/dd/yyyy");
            textBoxNgayHetHan.Text = kyLuat.NgayHetHan.ToString("MM/dd/yyyy");
            textBoxNoiDung.Text = kyLuat.NoiDung;
            textBoxLiDo.Text = kyLuat.LiDo;
            textBoxHinhThuc.Text = kyLuat.HinhThuc;
            textBoxTrangThai.Text = kyLuat.TrangThai;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if(kyLuatBUS.KyLuatNhanVien(comboBoxMaNhanVien.Text, textBoxSoQuyetDinh.Text))
            {
                MessageBox.Show("Nhân viên đã được thêm vào danh sách kỉ luật");
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

        private void KyLuatNhanVien_Load(object sender, EventArgs e)
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
            textBoxPhongban.Text = nhanSus[i].PhongBan;
        }

        private void comboBoxMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            
            ThongTinNhanVien(comboBoxMaNhanVien.SelectedIndex);
        }
    }
}
