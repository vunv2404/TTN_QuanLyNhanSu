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
using TTN_QuanLyNhanSu.DAL;
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.GUI.KhenThuong
{
    public partial class KhenThuongNhanVien : Form
    {

        /// <summary>
        /// 
        /// - lấy dữu liệu bên form danh sách khen thưởng  ném vào cột bên trái ,
        /// 
        /// - bên phải dùng combobox mã nhân viên để chọn nhân viên được khen thưởng.
        /// 
        /// - các textbox hiển thị dữ liệu theo mã nhân viên.
        /// 
        /// - khi bấm lưu thì thông báo có muốn lưu thay đổi.
        /// 
        /// </summary>
        KhenThuongBUS khenThuongController = new KhenThuongBUS();
        DTO.KhenThuong khenThuong;
        public KhenThuongNhanVien()
        {
            InitializeComponent();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin bản ghi ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                try
                {
                    DataProvider.Instance.ExecuteNonQuery("insert into KhenThuongNhanVien(MaNV,SoQuyetDinh) " +
                        $"values('{comboBoxMaNhanVien.Text}','{textBoxSoQuyetDinh.Text}')");
                    LoadInfo();
                    MessageBox.Show("---Thành Công---");
                }
                catch (Exception)
                {
                    MessageBox.Show("---Thất Bại---");
                }
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadInfo()
        {
            List<DTO.KhenThuong> khenThuongs = khenThuongController.Show_1_KhenThuong(QuyetDinhKhenThuong.soQuyetDinh);
            if (khenThuongs.Count != 0)
            {
                khenThuong = khenThuongs[0];
                textBoxSoQuyetDinh.Text = khenThuong.SoQuyetDinh;
                textBoxNgayHieuLuc.Text = khenThuong.NgayHieuLuc.ToShortDateString();
                textBoxNgayHetHan.Text = khenThuong.NgayHetHan.ToShortDateString();
                textBoxNoiDung.Text = khenThuong.NoiDung;
                textBoxHinhThuc.Text = khenThuong.HinhThuc;
                textBoxSoTien.Text = khenThuong.SoTien.ToString();
                textBoxTrangThai.Text = khenThuong.TrangThai;
            }
            DataTable dt = khenThuongController.Show_NhanVien_KoDuocKhenThuong(QuyetDinhKhenThuong.soQuyetDinh);
            List<int> maNVs = new List<int>();
            foreach (DataRow dr in dt.Rows)
            {
                maNVs.Add(Convert.ToInt32(dr[0].ToString()));
            }
            maNVs.Sort();
            comboBoxMaNhanVien.DataSource = maNVs;
        }
        private void KhenThuongNhanVien_Load(object sender, EventArgs e)
        {
            
            comboBoxMaNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadInfo();
        }

        private void comboBoxMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhanSu nhanSu = khenThuongController.Show_1_NhanSu(comboBoxMaNhanVien.Text);
            textBoxHoTen.Text = nhanSu.HoTenNV;
            textBoxNgaySinh.Text = nhanSu.NgaySinh.ToShortDateString();
            textBoxGioiTinh.Text = nhanSu.GioiTinh;
            textBoxChucVu.Text = nhanSu.ChucVu;
            textBoxBoPhan.Text = nhanSu.BoPhan;
            textBoxPhongban.Text = nhanSu.PhongBan;
        }
    }
}
