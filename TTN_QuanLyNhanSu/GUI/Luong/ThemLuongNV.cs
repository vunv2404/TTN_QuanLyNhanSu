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
    public partial class ThemLuongNV : Form
    {
        /// <summary>
        /// 
        /// - lấy dữ liệu ném lên combobox mã nhân viên
        /// 
        /// - Viết hàm tính toán.
        /// - A = (Mức Lương * Hệ SỐ * tổng ngầy công) + công làm thêm giờ 
        /// 
        /// - Tổng Lương nhận = A + Tiền phụ cấp - A*5%(Đây là thuế thu nhập) - 500.000(tiền bảo hiểm).
        /// 
        /// - Vd: A = (250.000*2,3*24) + 120.000*8(tiền * giờ)
        ///     tổng nhận = A + 300.000 - A*5% - 500.000
        ///     
        /// - xử lý ngày (regex).
        /// 
        /// - Xử lý dữ liệu trước khi thêm.
        /// 
        /// - thông báo các textbox trống và đặt focus và đúng ô trống.
        /// 
        /// - thông báo có muốn thêm trc khi thêm.
        /// 
        /// </summary>

        LuongBUS contrlLuong = new LuongBUS();

        public ThemLuongNV()
        {
            InitializeComponent();

            comboBoxMaNhanVien.DataSource = contrlLuong.XemNV();
            comboBoxMaNhanVien.DisplayMember = "MaNV";
            comboBoxMaNhanVien.ValueMember = "MaNV";

            textBoxThueThuNhap.Enabled = false;
        }

        private void buttonThem_Click(object sender, EventArgs e)
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
            else if (!Regex.IsMatch(textBoxNgayKi.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Ngày kí nhập sai");
                textBoxNgayKi.Focus();
            }
            else if (textBoxNgayHieuLuc.Text == "")
            {
                MessageBox.Show("Ngày hiệu lực không Được Để Trống");
                textBoxNgayHieuLuc.Focus();
            }
            else if (!Regex.IsMatch(textBoxNgayHieuLuc.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Ngày hiệu lực nhập sai");
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
                    DialogResult result = MessageBox.Show("Bạn có muốn thêm lương của nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        DTO.Luong luong = new DTO.Luong(comboBoxMaNhanVien.SelectedValue.ToString(), textBoxSoQuyetDinh.Text, DateTime.Parse(textBoxNgayKi.Text), DateTime.Parse(textBoxNgayHieuLuc.Text), decimal.Parse(textBoxMucLuong.Text), float.Parse(textBoxHeSo.Text), Int16.Parse(textBoxTongNgayCong.Text), decimal.Parse(textBoxCongLamThem.Text), decimal.Parse(textBoxPhuCap.Text), 0, 0);

                        if (contrlLuong.ThemLuongNV(luong))
                        {
                            MessageBox.Show("Thêm mới lương thành công");

                            comboBoxMaNhanVien.DataSource = contrlLuong.XemNV();
                            comboBoxMaNhanVien.DisplayMember = "MaNV";
                            comboBoxMaNhanVien.ValueMember = "MaNV";
                            textBoxSoQuyetDinh.Text = "";
                            textBoxNgayKi.Text = "";
                            textBoxNgayHieuLuc.Text = "";
                            textBoxMucLuong.Text = "";
                            textBoxHeSo.Text = "";
                            textBoxTongNgayCong.Text = "";
                            textBoxCongLamThem.Text = "";
                            textBoxPhuCap.Text = "";
                            textBoxThueThuNhap.Text = "";

                            DanhSachLuong.DtgvDSLuong.DataSource = contrlLuong.TatCaLuongNV();
                            DanhSachLuong.DtgvDSLuong.Refresh();

                            int i = DanhSachLuong.DtgvDSLuong.Rows.Count;
                            DanhSachLuong.TextboxTong.Text = i.ToString();
                            DanhSachLuong.TextboxTong.Refresh();
                        }
                        else MessageBox.Show("Thêm mới lương thất bại");
                    }
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxNgayKi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBoxNgayKi.Text.Length == 3 && e.KeyChar == '\b')
            {
                textBoxNgayKi.Text = textBoxNgayKi.Text.Remove(1, 2);
                textBoxNgayKi.SelectionStart = textBoxNgayKi.Text.Length;
                textBoxNgayKi.SelectionLength = 0;
            }
            if (textBoxNgayKi.Text.Length == 6 && e.KeyChar == '\b')
            {
                textBoxNgayKi.Text = textBoxNgayKi.Text.Remove(4, 2);
                textBoxNgayKi.SelectionStart = textBoxNgayKi.Text.Length;
                textBoxNgayKi.SelectionLength = 0;
            }
        }

        private void TextBoxNgayKi_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNgayKi.Text.Length == 2 && Regex.IsMatch(textBoxNgayKi.Text.Substring(0, 2), @"\d") && textBoxNgayKi.Text.Length < 3)
            {
                textBoxNgayKi.Text += "/";
                textBoxNgayKi.SelectionStart = textBoxNgayKi.Text.Length;
                textBoxNgayKi.SelectionLength = 0;
            }
            if (textBoxNgayKi.Text.Length == 5 && Regex.IsMatch(textBoxNgayKi.Text.Substring(3, 2), @"\d"))
            {
                textBoxNgayKi.Text += "/";
                textBoxNgayKi.SelectionStart = textBoxNgayKi.Text.Length;
                textBoxNgayKi.SelectionLength = 0;
            }
        }

        private void TextBoxNgayHieuLuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBoxNgayHieuLuc.Text.Length == 3 && e.KeyChar == '\b')
            {
                textBoxNgayHieuLuc.Text = textBoxNgayHieuLuc.Text.Remove(1, 2);
                textBoxNgayHieuLuc.SelectionStart = textBoxNgayHieuLuc.Text.Length;
                textBoxNgayHieuLuc.SelectionLength = 0;
            }
            if (textBoxNgayHieuLuc.Text.Length == 6 && e.KeyChar == '\b')
            {
                textBoxNgayHieuLuc.Text = textBoxNgayHieuLuc.Text.Remove(4, 2);
                textBoxNgayHieuLuc.SelectionStart = textBoxNgayHieuLuc.Text.Length;
                textBoxNgayHieuLuc.SelectionLength = 0;
            }
        }

        private void TextBoxNgayHieuLuc_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNgayHieuLuc.Text.Length == 2 && Regex.IsMatch(textBoxNgayHieuLuc.Text.Substring(0, 2), @"\d") && textBoxNgayHieuLuc.Text.Length < 3)
            {
                textBoxNgayHieuLuc.Text += "/";
                textBoxNgayHieuLuc.SelectionStart = textBoxNgayHieuLuc.Text.Length;
                textBoxNgayHieuLuc.SelectionLength = 0;
            }
            if (textBoxNgayHieuLuc.Text.Length == 5 && Regex.IsMatch(textBoxNgayHieuLuc.Text.Substring(3, 2), @"\d"))
            {
                textBoxNgayHieuLuc.Text += "/";
                textBoxNgayHieuLuc.SelectionStart = textBoxNgayHieuLuc.Text.Length;
                textBoxNgayHieuLuc.SelectionLength = 0;
            }
        }
    }
}
