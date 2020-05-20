using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.Luong
{
    public partial class ChiTietLuongNV : Form
    {


        /// <summary>
        /// 
        /// - Ném dữ liệu bên kia sang và vứt vào các textbox .
        /// 
        /// - Đưa dữ liệu lên combobox mã nhân viên.
        /// 
        /// - xử lý ngày regex .
        /// 
        /// - nếu có thay đổi dữ liệu thì cho cập nhật.
        /// 
        /// - thông báo các textbox trống và đặt focus và đúng ô trống.
        /// 
        /// - thông báo có muốn lưu thay đổi trc khi cập nhật.
        /// </summary>

        public ChiTietLuongNV()
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
