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
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.GUI.HopDongNhanSu
{
    public partial class ThemMoiHopDong : Form
    {
        private HopDongNhanSuBUS hopDongBUS = new HopDongNhanSuBUS();
        /// <summary>
        /// 
        /// - Thêm mới 1 bản ghi
        /// 
        /// - Xử lí ngày 
        /// 
        /// - Đưa dữu liệu từ database lên mã nhân viên.
        /// 
        /// - Họ tên nhân viên đồng bộ theo mã nhân viên.
        /// 
        /// - 
        /// 
        /// - trước khi Thêm xử lý dữ liệu và tạo thông báo có muốn Thêm.
        /// 
        /// 
        /// </summary>

        public ThemMoiHopDong()
        {
            InitializeComponent();

            Setcombox();
            textBoxSoHopDong.Text = hopDongBUS.GetMaHopDong();
        }
        private void Setcombox()
        {
            for(int i = 1; i <= hopDongBUS.GetMaNS(); i++)
            {
                comboBoxMaNhanVien.Items.Add(i);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if(textBoxTenNhanVien.Text == "")
            {
                MessageBox.Show("Chọn nhân viên!");
            }
            else if(comboBoxLoaiHopDong.Text == "")
            {
                MessageBox.Show("Chọn loại hợp đồng!");
            }
            else if(comboBoxTrangThai.Text == "")
            {
                MessageBox.Show("Chọn trạng thái hợp đồng!");
            }
            else if(!Regex.IsMatch(textBoxNgayHieuLuc.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Nhập sai ngày hiệu lực!");
            }
            else if(!Regex.IsMatch(textBoxNgayHetHan.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Nhập sai ngày hết hạn!");
            }
            else if(textBoxNoiDung.Text == "")
            {
                MessageBox.Show("Chưa nhập nội dung!");
            }
            else
            {
                DTO.HopDongNhanSu hd = new DTO.HopDongNhanSu(textBoxSoHopDong.Text, comboBoxMaNhanVien.Text,textBoxTenNhanVien.Text,comboBoxLoaiHopDong.Text,comboBoxTrangThai.Text,Convert.ToDateTime( textBoxNgayHieuLuc.Text), Convert.ToDateTime(textBoxNgayHetHan.Text), textBoxNoiDung.Text);
                if (hopDongBUS.AddHopDong(hd))
                {
                    MessageBox.Show("Đã thêm!");
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

        private void comboBoxMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTenNhanVien.Text = hopDongBUS.GetTenNS(comboBoxMaNhanVien.Text);
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
    }
}
