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
    public partial class ThemBoPhan : Form
    {

        /// <summary>
        /// 
        /// - Đẩy tên phòng ban trong database lên combobox tên phòng ban
        /// 
        /// - Khi thêm phải ánh xạ lại tên phòng ban về mã phòng ban để thêm.
        /// 
        /// - trước khi thêm hiện ra thông báo có muốn thêm.
        /// 
        /// - kiểm ta các trường phải đủ dữ liệu ko thì phải focus đến đúng trường thiếu.
        /// 
        /// - xử lí dữ liệu trước khi thêm.(regex)
        /// </summary>

        BoPhanNhanSuBUS contrlBoPhan = new BoPhanNhanSuBUS();
        PhongBanBUS contrlPhongBan = new PhongBanBUS();

        public ThemBoPhan()
        {
            InitializeComponent();
            comboBoxTenPhongBan.DataSource = contrlPhongBan.XemTatCaPB();
            comboBoxTenPhongBan.DisplayMember = "TenPB";
            comboBoxTenPhongBan.ValueMember = "MaPhongBan";
        }

        private void buttonThem_Click(object sender, EventArgs e)
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
                    DialogResult result = MessageBox.Show("Bạn có muốn thêm bộ phận?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        DTO.BoPhan bophan = new DTO.BoPhan(textBoxMaBoPhan.Text, textBoxTenBoPhan.Text, comboBoxTenPhongBan.SelectedValue.ToString(), textBoxEmail.Text, textBoxSoDienThoai.Text, textBoxFax.Text);

                        if (contrlBoPhan.TaoBoPhanNS(bophan))
                        {
                            MessageBox.Show("Thêm mới bộ phận thành công");

                            textBoxMaBoPhan.Text = "";
                            textBoxTenBoPhan.Text = "";
                            textBoxEmail.Text = "";
                            textBoxSoDienThoai.Text = "";
                            textBoxFax.Text = "";

                            comboBoxTenPhongBan.DataSource = contrlPhongBan.XemTatCaPB();
                            comboBoxTenPhongBan.DisplayMember = "TenPB";
                            comboBoxTenPhongBan.ValueMember = "MaPhongBan";

                            DanhSachBoPhan.DtgvBP.DataSource = contrlBoPhan.XemTatCaBoPhanNS();
                            DanhSachBoPhan.DtgvBP.Refresh();

                            int i = DanhSachBoPhan.DtgvBP.Rows.Count;
                            DanhSachBoPhan.TextboxTong.Text = i.ToString();
                            DanhSachBoPhan.TextboxTong.Refresh();
                        }
                        else MessageBox.Show("Thêm mới bộ phận thất bại");

                    }
                }
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
