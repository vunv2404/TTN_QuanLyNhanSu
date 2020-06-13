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

namespace TTN_QuanLyNhanSu.GUI.Luong
{
    public partial class ChiTietLuongNV : Form
    {


        /// <summary>
        /// 
        /// - Ném dữ liệu bên kia sang và vứt vào các textbox .
        /// 
        /// - Đưa dữ liệu lên combobox mã nhân viên.
        /// 
        /// - xử lý ngày regex .
        /// 
        /// - nếu có thay đổi dữ liệu thì cho cập nhật.
        /// 
        /// - thông báo các textbox trống và đặt focus và đúng ô trống.
        /// 
        /// - thông báo có muốn lưu thay đổi trc khi cập nhật.
        /// </summary>

        LuongBUS contrlLuong = new LuongBUS();
        private string ID;
        public ChiTietLuongNV(string IDMaNV)
        {
            ID = IDMaNV;

            InitializeComponent();

            comboBoxMaNhanVien.Enabled = false;

            textBoxThueThuNhap.Enabled = false;
            textBoxTongLuongNhan.Enabled = false;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            bool matchSoQuyetDinh = Regex.IsMatch(textBoxSoQuyetDinh.Text, @"^\s");
            bool matchNgayKi = Regex.IsMatch(textBoxNgayKi.Text, @"^\s");
            bool matchNgayHieuLuc = Regex.IsMatch(textBoxNgayHieuLuc.Text, @"^\s");
            bool matchMucLuong = Regex.IsMatch(textBoxMucLuong.Text, @"^\s");
            bool matchHeSo = Regex.IsMatch(textBoxHeSo.Text, @"^\s");
            bool matchTongNgayCong = Regex.IsMatch(textBoxTongNgayCong.Text, @"^\s");
            bool matchCongLamThemGio = Regex.IsMatch(textBoxCongLamThem.Text, @"^\s");
            bool matchPhuCap = Regex.IsMatch(textBoxPhuCap.Text, @"^\s");

            textBoxSoQuyetDinh.Text = textBoxSoQuyetDinh.Text.Trim();
            textBoxNgayKi.Text = textBoxNgayKi.Text.Trim();
            textBoxNgayHieuLuc.Text = textBoxNgayHieuLuc.Text.Trim();
            textBoxMucLuong.Text = textBoxMucLuong.Text.Trim();
            textBoxHeSo.Text = textBoxHeSo.Text.Trim();
            textBoxTongNgayCong.Text = textBoxTongNgayCong.Text.Trim();
            textBoxCongLamThem.Text = textBoxCongLamThem.Text.Trim();
            textBoxPhuCap.Text = textBoxPhuCap.Text.Trim();

            if (textBoxSoQuyetDinh.Text == "")
            {
                MessageBox.Show("Số quyết định không Được Để Trống");
                textBoxSoQuyetDinh.Focus();
            }
            else if (textBoxNgayKi.Text == "")
            {
                MessageBox.Show("Ngày kí không Được Để Trống");
                textBoxNgayKi.Focus();
            }
            else if (textBoxNgayHieuLuc.Text == "")
            {
                MessageBox.Show("Ngày hiệu lực không Được Để Trống");
                textBoxNgayHieuLuc.Focus();
            }
            else if (textBoxMucLuong.Text == "")
            {
                MessageBox.Show("Mức lương không Được Để Trống");
                textBoxMucLuong.Focus();
            }
            else if (textBoxHeSo.Text == "")
            {
                MessageBox.Show("Hệ số không Được Để Trống");
                textBoxHeSo.Focus();
            }
            else if (textBoxTongNgayCong.Text == "")
            {
                MessageBox.Show("Tổng ngày công không Được Để Trống");
                textBoxTongNgayCong.Focus();
            }
            else if (textBoxCongLamThem.Text == "")
            {
                MessageBox.Show("Công làm thêm không Được Để Trống");
                textBoxCongLamThem.Focus();
            }
            else if (textBoxPhuCap.Text == "")
            {
                MessageBox.Show("Phụ cấp không Được Để Trống");
                textBoxPhuCap.Focus();
            }
            else
            {
                if (matchSoQuyetDinh)
                {
                    MessageBox.Show("Số quyết định không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxSoQuyetDinh.Focus();
                }
                else if (matchNgayKi)
                {
                    MessageBox.Show("Ngày kí không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxNgayKi.Focus();
                }
                else if (matchNgayHieuLuc)
                {
                    MessageBox.Show("Ngày hiệu lựckhông Được Để Tất Cả Là Khoảng Trắng");
                    textBoxNgayHieuLuc.Focus();
                }
                else if (matchMucLuong)
                {
                    MessageBox.Show("Mức lương không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxMucLuong.Focus();
                }
                else if (matchHeSo)
                {
                    MessageBox.Show("Hệ số không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxHeSo.Focus();
                }
                else if (matchTongNgayCong)
                {
                    MessageBox.Show("Tổng ngày công không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxTongNgayCong.Focus();
                }
                else if (matchCongLamThemGio)
                {
                    MessageBox.Show("Công làm thêm giờ không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxCongLamThem.Focus();
                }
                else if (matchPhuCap)
                {
                    MessageBox.Show("Phụ cấp không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxPhuCap.Focus();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa lương của nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        DTO.Luong luong = new DTO.Luong();

                        luong.MaNV = ID;
                        luong.SoQuyetDinh = textBoxSoQuyetDinh.Text;
                        luong.NgayKi = DateTime.Parse(textBoxNgayKi.Text);
                        luong.NgayHieuLuc = DateTime.Parse(textBoxNgayHieuLuc.Text);
                        luong.MucLuong = decimal.Parse(textBoxMucLuong.Text);
                        luong.HeSo = float.Parse(textBoxHeSo.Text);
                        luong.TongNgayCong = Int16.Parse(textBoxTongNgayCong.Text);
                        luong.CongLamThemGio = decimal.Parse(textBoxCongLamThem.Text);
                        luong.PhuCap = decimal.Parse(textBoxPhuCap.Text);

                        if (contrlLuong.SuaLuongNV(luong))
                        {
                            MessageBox.Show("Sửa lương nhân viên thành công");

                            DanhSachLuong.DtgvDSLuong.DataSource = contrlLuong.TatCaLuongNV();
                            DanhSachLuong.DtgvDSLuong.Refresh();
                        }
                        else MessageBox.Show("Sửa lương nhân viên thất bại");
                    }
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTietLuongNV_Load(object sender, EventArgs e)
        {
            comboBoxMaNhanVien.SelectedText = contrlLuong.XemChiTietLuongNV(ID).MaNV;
            textBoxSoQuyetDinh.Text = contrlLuong.XemChiTietLuongNV(ID).SoQuyetDinh;
            textBoxNgayKi.Text = contrlLuong.XemChiTietLuongNV(ID).NgayKi.ToString();
            textBoxNgayHieuLuc.Text = contrlLuong.XemChiTietLuongNV(ID).NgayHieuLuc.ToString();
            textBoxMucLuong.Text = contrlLuong.XemChiTietLuongNV(ID).MucLuong.ToString();
            textBoxHeSo.Text = contrlLuong.XemChiTietLuongNV(ID).HeSo.ToString();
            textBoxTongNgayCong.Text = contrlLuong.XemChiTietLuongNV(ID).TongNgayCong.ToString();
            textBoxCongLamThem.Text = contrlLuong.XemChiTietLuongNV(ID).CongLamThemGio.ToString();
            textBoxPhuCap.Text = contrlLuong.XemChiTietLuongNV(ID).PhuCap.ToString();
            textBoxThueThuNhap.Text = contrlLuong.XemChiTietLuongNV(ID).ThueThuNhap.ToString();
            textBoxTongLuongNhan.Text = contrlLuong.XemChiTietLuongNV(ID).TongLuongNhan.ToString();
        }
    }
}
