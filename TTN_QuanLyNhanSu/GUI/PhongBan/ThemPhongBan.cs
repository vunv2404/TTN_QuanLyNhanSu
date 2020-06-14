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

namespace TTN_QuanLyNhanSu.GUI.PhongBan
{
    public partial class ThemPhongBan : Form
    {

        /// <summary>
        /// - xử lý dữ liệu ngày (regex)
        /// 
        /// - Combobox đưa mã nhân viên lên và là những ai chưa làm trưởng phòng.
        /// 
        /// - Xử lý dữ liệu trước khi thêm.
        /// 
        /// - thông báo có muốn thêm trước khi thêm.
        /// </summary>
        /// 

        PhongBanBUS contrlPhongBan = new PhongBanBUS();

        public ThemPhongBan()
        {
            InitializeComponent();

            comboBoxMaTruongPhong.DataSource = contrlPhongBan.XemTatCaTruongPhong();
            comboBoxMaTruongPhong.DisplayMember = "MaNV";
            comboBoxMaTruongPhong.ValueMember = "MaNV";

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            bool matchMaPB = Regex.IsMatch(textBoxMaPhongBan.Text, @"^\s");
            bool matchTenPB = Regex.IsMatch(textBoxTenPhongBan.Text, @"^\s");
            bool matchNgayThanhLap = Regex.IsMatch(textBoxNgayThanhLap.Text, @"^\s");
            bool matchEmail = Regex.IsMatch(textBoxEmail.Text, @"^\s");
            bool matchSDT = Regex.IsMatch(textBoxSoDienThoai.Text, @"^\s");
            bool matchFax = Regex.IsMatch(textBoxFax.Text, @"^\s");

            textBoxMaPhongBan.Text = textBoxMaPhongBan.Text.Trim();
            textBoxTenPhongBan.Text = textBoxTenPhongBan.Text.Trim();
            textBoxNgayThanhLap.Text = textBoxNgayThanhLap.Text.Trim();
            textBoxEmail.Text = textBoxEmail.Text.Trim();
            textBoxSoDienThoai.Text = textBoxSoDienThoai.Text.Trim();
            textBoxFax.Text = textBoxFax.Text.Trim();

            if (textBoxMaPhongBan.Text == "")
            {
                MessageBox.Show("Mã phòng ban không Được Để Trống");
                textBoxMaPhongBan.Focus();
            }
            else if (textBoxTenPhongBan.Text == "")
            {
                MessageBox.Show("Tên phòng không Được Để Trống");
                textBoxTenPhongBan.Focus();
            }
            else if (textBoxNgayThanhLap.Text == "")
            {
                MessageBox.Show("Ngày thành lập không Được Để Trống");
                textBoxNgayThanhLap.Focus();
            }
            else if (!Regex.IsMatch(textBoxNgayThanhLap.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Ngày thành lập nhập sai");
                textBoxNgayThanhLap.Focus();
            }
            else if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Email không Được Để Trống");
                textBoxEmail.Focus();
            }
            else if (textBoxSoDienThoai.Text == "")
            {
                MessageBox.Show("Số điện thoại không Được Để Trống");
                textBoxSoDienThoai.Focus();
            }
            else if (textBoxFax.Text == "")
            {
                MessageBox.Show("Số fax không Được Để Trống");
                textBoxFax.Focus();
            }
            else
            {
                if (matchMaPB)
                {
                    MessageBox.Show("Mã phòng ban không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxMaPhongBan.Focus();
                }
                else if (matchTenPB)
                {
                    MessageBox.Show("Tên phòng không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxTenPhongBan.Focus();
                }
                else if (matchNgayThanhLap)
                {
                    MessageBox.Show("Ngày thành lập không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxNgayThanhLap.Focus();
                }
                else if (matchEmail)
                {
                    MessageBox.Show("Email không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxEmail.Focus();
                }
                else if (matchSDT)
                {
                    MessageBox.Show("Số điện thoại không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxSoDienThoai.Focus();
                }
                else if (matchFax)
                {
                    MessageBox.Show("Số fax không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxFax.Focus();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn thêm phòng ban?", "Thêm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        DTO.PhongBan phongban = new DTO.PhongBan(textBoxMaPhongBan.Text, textBoxTenPhongBan.Text, DateTime.Parse(textBoxNgayThanhLap.Text), comboBoxMaTruongPhong.SelectedValue.ToString(), textBoxEmail.Text, textBoxSoDienThoai.Text, textBoxFax.Text);

                        if (contrlPhongBan.TaoPhongBan(phongban))
                        {
                            MessageBox.Show("Thêm mới phòng ban thành công");

                            textBoxMaPhongBan.Text = "";
                            textBoxTenPhongBan.Text = "";
                            textBoxNgayThanhLap.Text = "";
                            textBoxEmail.Text = "";
                            textBoxSoDienThoai.Text = "";
                            textBoxFax.Text = "";

                            comboBoxMaTruongPhong.DataSource = contrlPhongBan.XemTatCaTruongPhong();
                            comboBoxMaTruongPhong.DisplayMember = "MaNV";
                            comboBoxMaTruongPhong.ValueMember = "MaNV";

                            DanhSachPhongBan.DtgvPB.DataSource = contrlPhongBan.XemTatCaPB();
                            DanhSachPhongBan.DtgvPB.Refresh();

                            int i = DanhSachPhongBan.DtgvPB.Rows.Count;
                            DanhSachPhongBan.TextboxTong.Text = i.ToString();
                            DanhSachPhongBan.TextboxTong.Refresh();
                        }
                        else MessageBox.Show("Thêm mới thất bại");
                    }

                }
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemPhongBan_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxNgayThanhLap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBoxNgayThanhLap.Text.Length == 3 && e.KeyChar == '\b')
            {
                textBoxNgayThanhLap.Text = textBoxNgayThanhLap.Text.Remove(1, 2);
                textBoxNgayThanhLap.SelectionStart = textBoxNgayThanhLap.Text.Length;
                textBoxNgayThanhLap.SelectionLength = 0;
            }
            if (textBoxNgayThanhLap.Text.Length == 6 && e.KeyChar == '\b')
            {
                textBoxNgayThanhLap.Text = textBoxNgayThanhLap.Text.Remove(4, 2);
                textBoxNgayThanhLap.SelectionStart = textBoxNgayThanhLap.Text.Length;
                textBoxNgayThanhLap.SelectionLength = 0;
            }
        }

        private void TextBoxNgayThanhLap_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNgayThanhLap.Text.Length == 2 && Regex.IsMatch(textBoxNgayThanhLap.Text.Substring(0, 2), @"\d") && textBoxNgayThanhLap.Text.Length < 3)
            {
                textBoxNgayThanhLap.Text += "/";
                textBoxNgayThanhLap.SelectionStart = textBoxNgayThanhLap.Text.Length;
                textBoxNgayThanhLap.SelectionLength = 0;
            }
            if (textBoxNgayThanhLap.Text.Length == 5 && Regex.IsMatch(textBoxNgayThanhLap.Text.Substring(3, 2), @"\d"))
            {
                textBoxNgayThanhLap.Text += "/";
                textBoxNgayThanhLap.SelectionStart = textBoxNgayThanhLap.Text.Length;
                textBoxNgayThanhLap.SelectionLength = 0;
            }
        }
    }
}
