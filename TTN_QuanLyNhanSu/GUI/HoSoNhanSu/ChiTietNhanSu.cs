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

namespace TTN_QuanLyNhanSu.GUI.HoSoNhanSu
{
    public partial class ChiTietNhanSu : Form
    {
        /// <summary>
        /// - làm 1 số việc rồi 
        /// 
        /// - chỉ còn đưa dữ liệu lên 1 số combobox thôi.(1 số combobox có dữ liệu sẵn )
        /// 
        /// - ánh xạ từ mã phòng ban thành tên phòng ban.
        /// 
        /// - Combobox bộ phận thì phòng ban nào sẽ hiện bộ phận thuộc các phòng ban ấy
        /// 
        /// - Làm check dữu liệu trước khi cập nhật.
        /// 
        /// - xử lý ngày nhập vào (regex).
        /// 
        /// </summary>

        private byte[] image;
        private string ID;
        HoSoNhanSuBUS NhanSuBUS = new HoSoNhanSuBUS();

        public ChiTietNhanSu()
        {
            InitializeComponent();
            image = null;

        }

        public ChiTietNhanSu(string maNV, string hoTenNV, DateTime ngaySinh, string gioiTinh, string chucVu,
            string boPhan, string maPhongBan, DateTime ngayVaoCoQuan, string queQuan, string email,
            string soDienThoai, string hocVi, string hocHam, string chungChi, string chuyenMon)
        {
            InitializeComponent();
            textBoxMaNhanVien.Text = maNV;
            textBoxTenNhanVien.Text = hoTenNV;
            textBoxNgaySinh.Text = ngaySinh.ToString();
            comboBoxGioiTinh.Text = gioiTinh;
            comboBoxChucVu.Text = chucVu;
            comboBoxBoPhan.Text = boPhan;
            comboBoxPhongBan.Text = NhanSuBUS.GetTenPhongNhanVien( maPhongBan);// ánh xạ mã pb sang tên pban
            textBoxNgayVaoCoQuan.Text = ngayVaoCoQuan.ToString();
            textBoxQueQuan.Text = queQuan;
            textBoxEmail.Text = email;
            textBoxSDT.Text = soDienThoai;
            comboBoxHocVi.Text = hocVi;
            comboBoxHocHam.Text = hocHam;
            textBoxChungChi.Text = chungChi;
            textBoxChuyenMon.Text = chuyenMon;
            ID = maNV;
            pictureBoxNhanSu.Image = NhanSuBUS.XemAnhNhanVien(ID);
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            DTO.HoSoNhanSu hoSoNhanSu = new DTO.HoSoNhanSu();

            hoSoNhanSu.MaNV = ID;
            hoSoNhanSu.HoTenNV = textBoxTenNhanVien.Text;
            hoSoNhanSu.NgaySinh = Convert.ToDateTime(textBoxNgaySinh.Text);
            hoSoNhanSu.GioiTinh = comboBoxGioiTinh.Text;
            hoSoNhanSu.ChucVu = comboBoxChucVu.Text;
            hoSoNhanSu.BoPhan = comboBoxBoPhan.Text;
            hoSoNhanSu.MaPhongBan = NhanSuBUS.GetMaPhongNhanVien(comboBoxPhongBan.Text);// ánh xạ tên phòng ban sang mã phòng ban.
            hoSoNhanSu.NgayVaoCoQuan = Convert.ToDateTime(textBoxNgayVaoCoQuan.Text);
            hoSoNhanSu.QueQuan = textBoxQueQuan.Text;
            hoSoNhanSu.Email = textBoxEmail.Text;
            hoSoNhanSu.SoDienThoai = textBoxSDT.Text;
            hoSoNhanSu.HocVi = comboBoxHocVi.Text;
            hoSoNhanSu.HocHam = comboBoxHocHam.Text;
            hoSoNhanSu.ChungChi = textBoxChungChi.Text;
            hoSoNhanSu.ChuyenMon = textBoxChuyenMon.Text;

            if (image == null)
            {
                if (NhanSuBUS.SuaNhanSu(hoSoNhanSu))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                if (NhanSuBUS.SuaNhanSu(hoSoNhanSu,image))
                {
                    MessageBox.Show("Sửa thành công");
                    
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void buttonThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxNhanSu.Image = Image.FromFile(openFileDialog.FileName);
                image = (byte[])(new ImageConverter()).ConvertTo(pictureBoxNhanSu.Image, typeof(byte[]));
            }
            else
            {
                MessageBox.Show("Chưa Chọn Ảnh !!");
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
