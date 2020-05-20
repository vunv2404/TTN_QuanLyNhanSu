using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.KhenThuong
{
    public partial class KhenThuongNhanVien : Form
    {

        /// <summary>
        /// 
        /// - lấy dữu liệu bên form danh sách khen thưởng  ném vào cột bên trái ,
        /// 
        /// - bên phải dùng combobox mã nhân viên để chọn nhân viên được khen thưởng.
        /// 
        /// - các textbox hiển thị dữ liệu theo mã nhân viên.
        /// 
        /// - khi bấm lưu thì thông báo có muốn lưu thay đổi.
        /// 
        /// </summary>
        public KhenThuongNhanVien()
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
