using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.BaoHiem
{
    public partial class ChiTietBaoHiem : Form
    {

        /// <summary>
        /// - Ném dữ liệu bên danh sách bảo hiểm từ dataGridView vứt vào từng textBox.
        /// 
        /// - Thay đổi dữ liệu . 
        /// 
        /// - button cập nhật được bật lên khi click vào textbox thay đổi dữ liệu.
        /// 
        /// - có bảng thông báo hiện lên có chắc chắn muốn cập nhật bản ghi đó.
        /// 
        /// - Xử lí dữ liệu của ngày cấp.
        /// 
        /// - kiểm tra các trường phải đủ . khi thiếu đặt focus chuột vào nơi thiếu thông tin.
        /// 
        /// - xử lí dữ liệu trước khi cập nhật.(regex)
        /// 
        /// </summary>

        public ChiTietBaoHiem()
        {
            InitializeComponent();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void buttonquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
