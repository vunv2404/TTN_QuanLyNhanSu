using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QuanLyNhanSu.BUS;

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

        public ThemMoiNhanSu()
        {
            InitializeComponent();
            image = null;
        }

        

        private void buttonThem_Click(object sender, EventArgs e)
        {
            
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
    }
}
