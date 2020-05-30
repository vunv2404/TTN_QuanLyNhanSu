using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QuanLyNhanSu.BUS;
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.GUI.HoSoNhanSu
{
    public partial class ThemMoiNhanSu : Form
    {
        /// <summary>
        /// - Đẩy dữ liệu lên 1 số combobox, 1 số combobox dạng có sẵn dữ liệu.
        /// 
        /// - lấy dữ liệu lên combobox tên phòng ban , sau đó trước khi thêm thì ánh xạ từ tên phòng ban sang thành mã phòng ban.
        /// 
        /// - Combobox bộ phận thì phòng ban nào sẽ hiện bộ phận thuộc các phòng ban ấy
        /// 
        /// - thêm nhân sự mới . Kiểm tra dữ liệu trước khi thêm(regex),
        /// 
        /// - trừ 2 trường Chúng chỉ và chuyên môn thì các trường khác bắt buộc kiểm tra đủ thông tin
        /// 
        /// - Tôi đã viết sẵn hàm xử lý ảnh và hàm thêm(không/có) ảnh bên BUS
        /// 
        /// - xử lí ngày (regex)
        /// 
        /// - 2 loại thêm nhân viên xảy ra : có ảnh , không ảnh.
        /// 
        /// - tạo thông báo có muốn thêm không trước khi thêm.
        /// 
        /// </summary>


        private byte[] image;
        private int maNS;
        HoSoNhanSuBUS BUS = new HoSoNhanSuBUS();
        List<DTO.BoPhan> lbp = new List<DTO.BoPhan>();
        List<DTO.PhongBan> lpb = new List<DTO.PhongBan>();
        private Utility utility = new Utility();

        public ThemMoiNhanSu()
        {
            InitializeComponent();
            image = null;

            maNS = BUS.GetMaNS();
            textBoxMaNhanVien.Text = maNS.ToString();

            lbp = BUS.GetBoPhan();
            comboBoxBoPhan.DataSource = lbp;
            comboBoxBoPhan.ValueMember = "MaBoPhan";
            comboBoxBoPhan.DisplayMember = "TenBoPhan";

            lpb = BUS.GetPhongBan();
            comboBoxPhongBan.DataSource = lpb;
            comboBoxPhongBan.ValueMember = "MaPhongBan";
            comboBoxPhongBan.DisplayMember = "TenPhongBan";
        }

        

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxNgayVaoCoQuan.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Ngày vào nhập sai!");
            }
            else if (!Regex.IsMatch(textBoxNgaySinh.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Ngày sinh nhập sai!");
            }
            else if (textBoxTenNhanVien.Text.ToString() == "")
            {
                MessageBox.Show("Thiếu tên nhân viên!");
            }
            else if (comboBoxGioiTinh.Text.ToString() == "")
            {
                MessageBox.Show("Thiếu giới tính!");
            }
            else if (textBoxEmail.Text.ToString() == "")
            {
                MessageBox.Show("Thiếu email!");
            }
            else if (textBoxSDT.Text.ToString() == "")
            {
                MessageBox.Show("Thiếu số điện thoại!");
            }
            else if (comboBoxChucVu.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Thiếu chức vụ!");
            }
            else if (textBoxQueQuan.Text == "")
            {
                MessageBox.Show("Thiếu quê quán!");
            }
            else if (comboBoxHocVi.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Thiếu học vĩ!");
            }
            else if (comboBoxHocHam.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Thiếu học hàm!");
            }
            else
            {
                DTO.HoSoNhanSu nhanSu = new DTO.HoSoNhanSu();
                nhanSu.MaNV = maNS.ToString();
                nhanSu.HoTenNV = textBoxTenNhanVien.Text.ToString();
                nhanSu.GioiTinh = comboBoxGioiTinh.Text.ToString();
                nhanSu.Email = textBoxEmail.Text.ToString();
                nhanSu.SoDienThoai = textBoxSDT.Text.ToString();
                nhanSu.ChucVu = comboBoxChucVu.SelectedItem.ToString();
                nhanSu.BoPhan = comboBoxBoPhan.Text.ToString();
                nhanSu.NgayVaoCoQuan = Convert.ToDateTime(textBoxNgayVaoCoQuan.Text);
                nhanSu.NgaySinh = Convert.ToDateTime(textBoxNgaySinh.Text);
                nhanSu.MaPhongBan = comboBoxPhongBan.SelectedValue.ToString();
                nhanSu.QueQuan = textBoxQueQuan.Text;
                nhanSu.HocVi = comboBoxHocVi.SelectedItem.ToString();
                nhanSu.HocHam = comboBoxHocHam.SelectedItem.ToString();
                nhanSu.ChungChi = textBoxChungChi.Text;
                nhanSu.ChuyenMon = textBoxChuyenMon.Text;
                if (BUS.AddNhanSu(nhanSu, image))
                {
                    MessageBox.Show("Đã Thêm!");
                }
            }
        }

        private void buttonThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK )
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

        private void textBoxNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            utility.DateTimeFiller_KeyPressed(sender as TextBox, e);
        }

        private void textBoxNgaySinh_TextChanged(object sender, EventArgs e)
        {
            utility.DateTimeFiller_TextChanged(sender as TextBox);
        }

        private void textBoxNgayVaoCoQuan_TextChanged(object sender, EventArgs e)
        {
            utility.DateTimeFiller_TextChanged(sender as TextBox);
        }

        private void textBoxNgayVaoCoQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            utility.DateTimeFiller_KeyPressed(sender as TextBox, e);
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
