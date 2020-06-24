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
        private Utility utility = new Utility();
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
            else if(!Regex.IsMatch(textBoxNgayHieuLuc.Text, @"(((0[1-9]|1[0-2])\/(0|1)[0-9]|2[0-9]|3[0-1])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Nhập sai ngày hiệu lực! mm/dd/yyyy");
            }
            else if(!Regex.IsMatch(textBoxNgayHetHan.Text, @"(((0[1-9]|1[0-2])\/(0|1)[0-9]|2[0-9]|3[0-1])\/((19|20)\d\d))$"))
            {
                MessageBox.Show("Nhập sai ngày hết hạn! mm/dd/yyyy");
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
                    MessageBox.Show("Đã thêm thành công!");
                    this.Close();
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
            utility.DateTimeFiller_TextChanged(sender as TextBox);
        }

        private void textBoxNgayHieuLuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            utility.DateTimeFiller_KeyPressed(sender as TextBox, e);
        }

        private void textBoxNgayHetHan_TextChanged(object sender, EventArgs e)
        {
            utility.DateTimeFiller_TextChanged(sender as TextBox);
        }

        private void textBoxNgayHetHan_KeyPress(object sender, KeyPressEventArgs e)
        {
            utility.DateTimeFiller_KeyPressed(sender as TextBox, e);
        }
    }
}
