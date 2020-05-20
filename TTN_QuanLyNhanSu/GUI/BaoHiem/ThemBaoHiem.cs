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
    public partial class ThemBaoHiem : Form
    {
        public ThemBaoHiem()
        {
            InitializeComponent();
        }
        /**
            - Đưa dữ liệu từ database lên combobox Mã nhân viên.

            - Textbox tên nhân viên sẽ hiển thị tên nhân viên đồng bộ dữ liệu theo combobox mã nhân viên.

            - Xử lí ngày cấp Convert dạng string.

            - Thêm Bảo hiểm cho 1 nhân viên.

            - Khi thêm hiện ra thông báo có chắc chắn thêm 

            - kiểm tra các trường phải đủ . khi thiếu đặt focus chuột vào nơi thiếu thông tin.
         
            - xử lí dữ liệu trước khi thêm.(regex)
             */
        private void buttonThem_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
