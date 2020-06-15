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

namespace TTN_QuanLyNhanSu.GUI.HoSoNhanSu
{
    public partial class ChiTietNhanSu : Form
    {
        private Utility utility = new Utility();
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

            lpb = NhanSuBUS.GetPhongBan();
            comboBoxPhongBan.DataSource = lpb;
            comboBoxPhongBan.ValueMember = "MaPhongBan";
            comboBoxPhongBan.DisplayMember = "TenPhongBan";
            comboBoxPhongBan.Text = NhanSuBUS.GetTenPhongNhanVien(maPhongBan);// ánh xạ mã pb sang tên pban

            lbp = NhanSuBUS.GetBoPhan();
            comboBoxBoPhan.DataSource = lbp;
            comboBoxBoPhan.ValueMember = "MaBoPhan";
            comboBoxBoPhan.DisplayMember = "TenBoPhan";

            textBoxMaNhanVien.Text = maNV;
            textBoxTenNhanVien.Text = hoTenNV;
            comboBoxGioiTinh.Text = gioiTinh;
            comboBoxChucVu.Text = chucVu;
            comboBoxBoPhan.Text = boPhan;
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
            if (!Regex.IsMatch(textBoxNgayVaoCoQuan.Text, @"(((0[1-9]|1[0-2])\/(0|1)[0-9]|2[0-9]|3[0-1])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Ngày vào nhập sai!");
            }
            else if (!Regex.IsMatch(textBoxNgaySinh.Text, @"(((0[1-9]|1[0-2])\/(0|1)[0-9]|2[0-9]|3[0-1])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Ngày sinh nhập sai!");
            }
            else if (textBoxTenNhanVien.Text.ToString() == "" )
            {
                MessageBox.Show("Thiếu tên nhân viên!");
            }
            else if (comboBoxGioiTinh.Text.ToString() == "")
            {
                MessageBox.Show("Thiếu giới tính!");
            }
            else if (textBoxEmail.Text.ToString() == "" )
            {
                MessageBox.Show("Thiếu email!");
            }
            else if (textBoxSDT.Text.ToString() == "")
            {
                MessageBox.Show("Thiếu số điện thoại!");
            }
            else if (comboBoxChucVu.Text == "" )
            {
                MessageBox.Show("Thiếu chức vụ!");
            }
            else if (textBoxQueQuan.Text == "" )
            {
                MessageBox.Show("Thiếu quê quán!");
            }
            else if (comboBoxHocVi.Text == "" )
            {
                MessageBox.Show("Thiếu học vĩ!");
            }
            else if (comboBoxHocHam.Text == "")
            {
                MessageBox.Show("Thiếu học hàm!");
            }
            else
            {
                DTO.HoSoNhanSu hoSoNhanSu = new DTO.HoSoNhanSu();

                hoSoNhanSu.MaNV = ID;
                hoSoNhanSu.HoTenNV = textBoxTenNhanVien.Text;
                hoSoNhanSu.NgaySinh = DateTime.Parse(textBoxNgaySinh.Text);
                hoSoNhanSu.GioiTinh = comboBoxGioiTinh.Text;
                hoSoNhanSu.ChucVu = comboBoxChucVu.SelectedItem.ToString();
                hoSoNhanSu.BoPhan = comboBoxBoPhan.Text;
                hoSoNhanSu.MaPhongBan = comboBoxPhongBan.SelectedValue.ToString();// ánh xạ tên phòng ban sang mã phòng ban.
                hoSoNhanSu.NgayVaoCoQuan = DateTime.Parse(textBoxNgayVaoCoQuan.Text);
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
            utility.DateTimeFiller_TextChanged(sender as TextBox);
        }

        private void textBoxNgayVaoCoQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            utility.DateTimeFiller_KeyPressed(sender as TextBox, e);
        }

        private void textBoxNgaySinh_TextChanged(object sender, EventArgs e)
        {
            utility.DateTimeFiller_TextChanged(sender as TextBox);
        }

        private void textBoxNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBoxPhongBan_TextChanged(object sender, EventArgs e)
        {
            lbp = NhanSuBUS.GetBoPhan(((DTO.PhongBan)comboBoxPhongBan.SelectedItem).MaPhongBan);
            comboBoxBoPhan.DataSource = null;
            comboBoxBoPhan.DataSource = lbp;
            comboBoxBoPhan.ValueMember = "MaBoPhan";
            comboBoxBoPhan.DisplayMember = "TenBoPhan";
        }
    }
}
