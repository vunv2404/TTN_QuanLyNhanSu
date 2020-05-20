using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        public ChiTietBoPhan()
        {
            InitializeComponent();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
