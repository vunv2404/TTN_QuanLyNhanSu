using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.DaoTao
{
    public partial class ChiTietKhoaHoc : Form
    {

        /// <summary>
        /// - Đưa dữ liệu từ bảng danh sách khóa học đào tạo sang ném lên các ô textbox
        /// 
        /// - Khi Có sự thay đổi dữ liệu thì nút cập nhật mưới hiện lên
        /// 
        /// - trước khi cập nhật kiểm tra xử lí dữ liệu.
        /// 
        /// - xử lí ngày nhập nếu có cập nhật dữ liệu
        /// 
        /// - TRước khi cập nhật tạo thông báo có muốn cập nhật
        /// 
        /// </summary>
        public ChiTietKhoaHoc()
        {
            InitializeComponent();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
