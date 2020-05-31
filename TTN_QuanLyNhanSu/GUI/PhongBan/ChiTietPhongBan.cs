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

namespace TTN_QuanLyNhanSu.GUI.PhongBan
{
    public partial class ChiTietPhongBan : Form
    {

        /// <summary>
        /// 
        /// - xửa lý dữ liệu ngày (regex).
        /// 
        /// - đem dữ liệu bên danh sách phòng ban ném lên các textbox.
        /// 
        /// - thông báo có muốn sửa khi sửa
        /// 
        /// </summary>
        /// 
        PhongBanBUS contrlPhongBan = new PhongBanBUS();
        private string ID;
        public ChiTietPhongBan(string IDPhongBan)
        {
            ID = IDPhongBan;

            InitializeComponent();

            textBoxMaPhongBan.Enabled = false;

            comboBoxMaTruongPhong.DataSource = contrlPhongBan.XemTatCaTruongPhong();
            comboBoxMaTruongPhong.DisplayMember = "MaNV";
            comboBoxMaTruongPhong.ValueMember = "MaNV";
            
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
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
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa phòng ban?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        DTO.PhongBan phongban = new DTO.PhongBan();

                        phongban.MaPhongBan = ID;
                        phongban.TenPB = textBoxTenPhongBan.Text;
                        phongban.NgayThanhLap = DateTime.Parse(textBoxNgayThanhLap.Text);
                        phongban.MaTruongPhong = comboBoxMaTruongPhong.SelectedValue.ToString();
                        phongban.Email = textBoxEmail.Text;
                        phongban.SoDienThoai = textBoxSoDienThoai.Text;
                        phongban.Fax = textBoxFax.Text;

                        if (contrlPhongBan.SuaPhongBan(phongban))
                        {
                            MessageBox.Show("Sửa phòng ban thành công");

                            DanhSachPhongBan.DtgvPB.DataSource = contrlPhongBan.XemTatCaPB();
                            DanhSachPhongBan.DtgvPB.Refresh();
                        }
                        else MessageBox.Show("Sửa phòng ban thất bại");
                    }
                }
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTietPhongBan_Load(object sender, EventArgs e)
        {
            textBoxMaPhongBan.Text = contrlPhongBan.XemChiTietPB(ID).MaPhongBan;
            textBoxTenPhongBan.Text = contrlPhongBan.XemChiTietPB(ID).TenPB;
            textBoxNgayThanhLap.Text = contrlPhongBan.XemChiTietPB(ID).NgayThanhLap.ToString();
            comboBoxMaTruongPhong.SelectedText = contrlPhongBan.XemChiTietPB(ID).MaTruongPhong;
            textBoxEmail.Text = contrlPhongBan.XemChiTietPB(ID).Email;
            textBoxSoDienThoai.Text = contrlPhongBan.XemChiTietPB(ID).SoDienThoai;
            textBoxFax.Text = contrlPhongBan.XemChiTietPB(ID).Fax;
        }
    }
}
