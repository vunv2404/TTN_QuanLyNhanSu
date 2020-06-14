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

namespace TTN_QuanLyNhanSu.GUI.BoPhan
{
    public partial class ChiTietBoPhan : Form
    {

        /// <summary>
        /// 
        /// - Dữ liệu được vứt lên các textbox và combobox
        /// 
        /// - Xử lí mã phòng ban bên bảng danh sách bộ phận thành tên phòng ban
        /// 
        /// - khi sửa lại bộ phận thuộc phòng ban nào mới thì phải ánh xạ lại từ tên pb về mã pb
        /// 
        /// - xử lí dữ liệu trước khi cập nhật.(regex)
        /// 
        /// - kiểm ta các trường phải đủ dữ liệu ko thì phải focus đến đúng trường thiếu.
        /// 
        /// 
        /// </summary>


        private string ID;
        BoPhanNhanSuBUS contrlBoPhan = new BoPhanNhanSuBUS();
        PhongBanBUS contrlPhongBan = new PhongBanBUS();

        public ChiTietBoPhan(string mabophan)
        {
            ID = mabophan;

            InitializeComponent();

            textBoxMaBoPhan.Enabled = false;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            bool matchMaBP = Regex.IsMatch(textBoxMaBoPhan.Text, @"^\s");
            bool matchTenBP = Regex.IsMatch(textBoxTenBoPhan.Text, @"^\s");
            bool matchEmail = Regex.IsMatch(textBoxEmail.Text, @"^\s");
            bool matchSDT = Regex.IsMatch(textBoxSoDienThoai.Text, @"^\s");
            bool matchFax = Regex.IsMatch(textBoxFax.Text, @"^\s");

            textBoxMaBoPhan.Text = textBoxMaBoPhan.Text.Trim();
            textBoxTenBoPhan.Text = textBoxTenBoPhan.Text.Trim();
            textBoxEmail.Text = textBoxEmail.Text.Trim();
            textBoxSoDienThoai.Text = textBoxSoDienThoai.Text.Trim();
            textBoxFax.Text = textBoxFax.Text.Trim();

            if (textBoxMaBoPhan.Text == "")
            {
                MessageBox.Show("Mã bộ phận không Được Để Trống");
                textBoxMaBoPhan.Focus();
            }
            else if (textBoxTenBoPhan.Text == "")
            {
                MessageBox.Show("Tên bộ phận không Được Để Trống");
                textBoxTenBoPhan.Focus();
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
                if (matchMaBP)
                {
                    MessageBox.Show("Mã bộ phận không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxMaBoPhan.Focus();
                }
                else if (matchTenBP)
                {
                    MessageBox.Show("Tên bộ phận không Được Để Tất Cả Là Khoảng Trắng");
                    textBoxTenBoPhan.Focus();
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
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa bộ phận?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        DTO.BoPhan bophan = new DTO.BoPhan();

                        bophan.MaBoPhan = ID;
                        bophan.TenBoPhan = textBoxTenBoPhan.Text;
                        bophan.MaPhongBan = comboBoxTenPhongBan.SelectedValue.ToString();
                        bophan.Email = textBoxEmail.Text;
                        bophan.DienThoai = textBoxSoDienThoai.Text;
                        bophan.Fax = textBoxFax.Text;

                        if (contrlBoPhan.SuaPhongBoPhanNS(bophan))
                        {
                            MessageBox.Show("Sửa bộ phận thành công");

                            DanhSachBoPhan.DtgvBP.DataSource = contrlBoPhan.XemTatCaBoPhanNS();
                            DanhSachBoPhan.DtgvBP.Refresh();
                        }
                        else MessageBox.Show("Sửa bộ phận thất bại");
                    }
                }
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTietBoPhan_Load(object sender, EventArgs e)
        {
            textBoxMaBoPhan.Text = contrlBoPhan.XemChiTietBoPhanNS(ID).MaBoPhan;
            textBoxTenBoPhan.Text = contrlBoPhan.XemChiTietBoPhanNS(ID).TenBoPhan;
            textBoxEmail.Text = contrlBoPhan.XemChiTietBoPhanNS(ID).Email;
            textBoxSoDienThoai.Text = contrlBoPhan.XemChiTietBoPhanNS(ID).DienThoai;
            textBoxFax.Text = contrlBoPhan.XemChiTietBoPhanNS(ID).Fax;

            comboBoxTenPhongBan.DataSource = contrlPhongBan.XemTatCaPB();
            comboBoxTenPhongBan.DisplayMember = "TenPB";
            comboBoxTenPhongBan.ValueMember = "MaPhongBan";
        }
    }
}
