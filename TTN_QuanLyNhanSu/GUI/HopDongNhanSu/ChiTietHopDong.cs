using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QuanLyNhanSu.DTO;
using TTN_QuanLyNhanSu.BUS;
using System.Text.RegularExpressions;

namespace TTN_QuanLyNhanSu.GUI.HopDongNhanSu
{
    public partial class ChiTietHopDong : Form
    {
        BUS.HopDongNhanSuBUS hopDongBUS = new HopDongNhanSuBUS();
        /// <summary>
        /// 
        /// - Ném dữ liệu bên datagrid lên các textbox và combobox .
        /// 
        /// - Cập nhật khi thay đổi dữ liệu nút cập nhật lúc này mưới được bật.
        /// 
        /// - trước khi cập nhật xử lý dữ liệu, tạo thông báo có muốn cập nhật.
        /// 
        /// - xử lí ngày
        /// 
        /// - xử lí dữ liệu trước khi cập nhật.
        /// 
        /// 
        /// </summary>

        public ChiTietHopDong(string sohd,string ma,string ten,string loaihd, string trangthai,DateTime ngayhieuluc, DateTime ngayhethan,string nd)
        {
            InitializeComponent();

            textBoxNgayHieuLuc.Text = ThemNgay(ngayhieuluc);
            textBoxNgayHetHan.Text = ThemNgay(ngayhethan);
            textBoxSoHopDong.Text = sohd;
            textBoxMaNhanVien.Text = ma;
            textBoxTenNhanVien.Text = ten;
            comboBoxLoaiHopDong.SelectedItem = loaihd;
            comboBoxTrangThai.SelectedItem = trangthai;
            textBoxNoiDung.Text = nd;
        }

        private string ThemNgay(DateTime ngay)
        {
            string str = ngay.ToShortDateString();
            if (str.Length == 8)
            {
                string[] strs = str.Split('/');
                if (Convert.ToInt32(strs[2]) <= 20)
                {
                    return strs[0] + "/" + strs[1] + "/20" + strs[2];
                }
                else
                {
                    return strs[0] + "/" + strs[1] + "/19" + strs[2];
                }
            }
            else
            {
                return str;
            }
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (comboBoxLoaiHopDong.Text == "")
            {
                MessageBox.Show("Chọn loại hợp đồng!");
            }
            else if (comboBoxTrangThai.Text == "")
            {
                MessageBox.Show("Chọn trạng thái hợp đồng!");
            }
            else if (!Regex.IsMatch(textBoxNgayHieuLuc.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Nhập sai ngày hiệu lực!");
            }
            else if (!Regex.IsMatch(textBoxNgayHetHan.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Nhập sai ngày hết hạn!");
            }
            else if (textBoxNoiDung.Text == "")
            {
                MessageBox.Show("Chưa nhập nội dung!");
            }
            else
            {
                if (hopDongBUS.EditHopDong(textBoxSoHopDong.Text, textBoxMaNhanVien.Text, textBoxTenNhanVien.Text, comboBoxLoaiHopDong.Text, comboBoxTrangThai.Text, textBoxNgayHieuLuc.Text, textBoxNgayHetHan.Text, textBoxNoiDung.Text))
                {
                    MessageBox.Show("Đã sửa!");
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNgayHetHan_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNgayHetHan.Text.Length == 2 && Regex.IsMatch(textBoxNgayHetHan.Text.Substring(0, 2), @"\d") && textBoxNgayHetHan.Text.Length < 3)
            {
                textBoxNgayHetHan.Text += "/";
                textBoxNgayHetHan.SelectionStart = textBoxNgayHetHan.Text.Length;
                textBoxNgayHetHan.SelectionLength = 0;
            }
            if (textBoxNgayHetHan.Text.Length == 5 && Regex.IsMatch(textBoxNgayHetHan.Text.Substring(3, 2), @"\d"))
            {
                textBoxNgayHetHan.Text += "/";
                textBoxNgayHetHan.SelectionStart = textBoxNgayHetHan.Text.Length;
                textBoxNgayHetHan.SelectionLength = 0;
            }
        }

        private void textBoxNgayHetHan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBoxNgayHetHan.Text.Length == 3 && e.KeyChar == '\b')
            {
                textBoxNgayHetHan.Text = textBoxNgayHetHan.Text.Remove(1, 2);
                textBoxNgayHetHan.SelectionStart = textBoxNgayHetHan.Text.Length;
                textBoxNgayHetHan.SelectionLength = 0;
            }
            if (textBoxNgayHetHan.Text.Length == 6 && e.KeyChar == '\b')
            {
                textBoxNgayHetHan.Text = textBoxNgayHetHan.Text.Remove(4, 2);
                textBoxNgayHetHan.SelectionStart = textBoxNgayHetHan.Text.Length;
                textBoxNgayHetHan.SelectionLength = 0;
            }
        }

        private void textBoxNgayHieuLuc_TextChanged(object sender, EventArgs e)
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

        private void textBoxNgayHieuLuc_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
