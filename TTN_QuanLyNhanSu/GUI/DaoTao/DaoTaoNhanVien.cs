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
    public partial class DaoTaoNhanVien : Form
    {

        /// <summary>
        /// - Ném dữ liệu từ database lên combobox mã nhân viên
        /// 
        /// - tất cả các textbox phía dưới mã nhân viên phải lấy thông tin lên đặt vào .
        /// 
        /// - chỉ việc chọn mã nhân viên ở combobox thì tất cả dữ liệu của nhaanvieen ở các textbox cũng được đồng bộ.
        /// 
        /// - Lấy dữ liệu bên khóa học đào tạo đặt vào các textbox tương ứng .
        /// 
        /// - trước khi thêm hiện ra thông báo có muốn thêm ko.
        /// 
        /// </summary>
        public DaoTaoNhanVien()
        {
            InitializeComponent();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
