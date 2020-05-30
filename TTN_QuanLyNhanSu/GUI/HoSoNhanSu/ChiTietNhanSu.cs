using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        List<DTO.BoPhan> lbp = new List<DTO.BoPhan>();
        List<DTO.PhongBan> lpb = new List<DTO.PhongBan>();

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

            lbp = NhanSuBUS.GetBoPhan();
            comboBoxBoPhan.DataSource = lbp;
            comboBoxBoPhan.ValueMember = "MaBoPhan";
            comboBoxBoPhan.DisplayMember = "TenBoPhan";

            lpb = NhanSuBUS.GetPhongBan();
            comboBoxPhongBan.DataSource = lpb;
            comboBoxPhongBan.ValueMember = "MaPhongBan";
            comboBoxPhongBan.DisplayMember = "TenPhongBan";

            textBoxMaNhanVien.Text = maNV;
            textBoxTenNhanVien.Text = hoTenNV;
            comboBoxGioiTinh.Text = gioiTinh;
            comboBoxChucVu.Text = chucVu;
            comboBoxBoPhan.Text = boPhan;
            comboBoxPhongBan.Text = NhanSuBUS.GetTenPhongNhanVien( maPhongBan);// ánh xạ mã pb sang tên pban
            textBoxQueQuan.Text = queQuan;
            textBoxEmail.Text = email;
            textBoxSDT.Text = soDienThoai;
            comboBoxHocVi.Text = hocVi;
            comboBoxHocHam.Text = hocHam;
            textBoxChungChi.Text = chungChi;
            textBoxChuyenMon.Text = chuyenMon;
            ID = maNV;
            pictureBoxNhanSu.Image = NhanSuBUS.XemAnhNhanVien(ID);
            ThemNgay(textBoxNgayVaoCoQuan, ngayVaoCoQuan);
            ThemNgay(textBoxNgaySinh, ngaySinh);
        }
        private void ThemNgay(TextBox textBox, DateTime ngay)
        {
            string str = ngay.ToShortDateString();
            if (str.Length == 8)
            {
                string[] strs = str.Split('/');
                if (Convert.ToInt32(strs[2]) <= 20)
                {
                    textBox.Text = strs[0] + "/" + strs[1] + "/20" + strs[2];
                }
                else
                {
                    textBox.Text = strs[0] + "/" + strs[1] + "/19" + strs[2];
                }
            }
            else
            {
                textBox.Text = str;
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxNgayVaoCoQuan.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Ngày vào nhập sai!");
            }
            else if (!Regex.IsMatch(textBoxNgaySinh.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Ngày sinh nhập sai!");
            }
            else
            {
                DTO.HoSoNhanSu hoSoNhanSu = new DTO.HoSoNhanSu();

                hoSoNhanSu.MaNV = ID;
                hoSoNhanSu.HoTenNV = textBoxTenNhanVien.Text;
                hoSoNhanSu.NgaySinh = Convert.ToDateTime(textBoxNgaySinh.Text);
                hoSoNhanSu.GioiTinh = comboBoxGioiTinh.Text;
                hoSoNhanSu.ChucVu = comboBoxChucVu.SelectedItem.ToString();
                hoSoNhanSu.BoPhan = comboBoxBoPhan.Text;
                hoSoNhanSu.MaPhongBan = comboBoxPhongBan.SelectedValue.ToString();// ánh xạ tên phòng ban sang mã phòng ban.
                hoSoNhanSu.NgayVaoCoQuan = Convert.ToDateTime(textBoxNgayVaoCoQuan.Text);
                hoSoNhanSu.QueQuan = textBoxQueQuan.Text;
                hoSoNhanSu.Email = textBoxEmail.Text;
                hoSoNhanSu.SoDienThoai = textBoxSDT.Text;
                hoSoNhanSu.HocVi = comboBoxHocVi.SelectedItem.ToString();
                hoSoNhanSu.HocHam = comboBoxHocHam.SelectedItem.ToString();
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
                    if (NhanSuBUS.SuaNhanSu(hoSoNhanSu, image))
                    {
                        MessageBox.Show("Sửa thành công");

                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
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

        private void textBoxNgayVaoCoQuan_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNgayVaoCoQuan.Text.Length == 2 && Regex.IsMatch(textBoxNgayVaoCoQuan.Text.Substring(0, 2), @"\d") && textBoxNgayVaoCoQuan.Text.Length < 3)
            {
                textBoxNgayVaoCoQuan.Text += "/";
                textBoxNgayVaoCoQuan.SelectionStart = textBoxNgayVaoCoQuan.Text.Length;
                textBoxNgayVaoCoQuan.SelectionLength = 0;
            }
            if (textBoxNgayVaoCoQuan.Text.Length == 5 && Regex.IsMatch(textBoxNgayVaoCoQuan.Text.Substring(3, 2), @"\d"))
            {
                textBoxNgayVaoCoQuan.Text += "/";
                textBoxNgayVaoCoQuan.SelectionStart = textBoxNgayVaoCoQuan.Text.Length;
                textBoxNgayVaoCoQuan.SelectionLength = 0;
            }
        }

        private void textBoxNgayVaoCoQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBoxNgayVaoCoQuan.Text.Length == 3 && e.KeyChar == '\b')
            {
                textBoxNgayVaoCoQuan.Text = textBoxNgayVaoCoQuan.Text.Remove(1, 2);
                textBoxNgayVaoCoQuan.SelectionStart = textBoxNgayVaoCoQuan.Text.Length;
                textBoxNgayVaoCoQuan.SelectionLength = 0;
            }
            if (textBoxNgayVaoCoQuan.Text.Length == 6 && e.KeyChar == '\b')
            {
                textBoxNgayVaoCoQuan.Text = textBoxNgayVaoCoQuan.Text.Remove(4, 2);
                textBoxNgayVaoCoQuan.SelectionStart = textBoxNgayVaoCoQuan.Text.Length;
                textBoxNgayVaoCoQuan.SelectionLength = 0;
            }
        }

        private void textBoxNgaySinh_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNgaySinh.Text.Length == 2 && Regex.IsMatch(textBoxNgaySinh.Text.Substring(0, 2), @"\d") && textBoxNgaySinh.Text.Length < 3)
            {
                textBoxNgaySinh.Text += "/";
                textBoxNgaySinh.SelectionStart = textBoxNgaySinh.Text.Length;
                textBoxNgaySinh.SelectionLength = 0;
            }
            if (textBoxNgaySinh.Text.Length == 5 && Regex.IsMatch(textBoxNgaySinh.Text.Substring(3, 2), @"\d"))
            {
                textBoxNgaySinh.Text += "/";
                textBoxNgaySinh.SelectionStart = textBoxNgaySinh.Text.Length;
                textBoxNgaySinh.SelectionLength = 0;
            }
        }

        private void textBoxNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBoxNgaySinh.Text.Length == 3 && e.KeyChar == '\b')
            {
                textBoxNgaySinh.Text = textBoxNgaySinh.Text.Remove(1, 2);
                textBoxNgaySinh.SelectionStart = textBoxNgaySinh.Text.Length;
                textBoxNgaySinh.SelectionLength = 0;
            }
            if (textBoxNgaySinh.Text.Length == 6 && e.KeyChar == '\b')
            {
                textBoxNgaySinh.Text = textBoxNgaySinh.Text.Remove(4, 2);
                textBoxNgaySinh.SelectionStart = textBoxNgaySinh.Text.Length;
                textBoxNgaySinh.SelectionLength = 0;
            }
        }

        private void textBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
