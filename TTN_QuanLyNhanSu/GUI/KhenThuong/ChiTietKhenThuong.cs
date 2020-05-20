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
    public partial class ChiTietKhenThuong : Form
    {

        /// <summary>
        /// 
        /// - Ném dữu liệu bên bảng danh sách khên thưởng sang vứt lên các textbox, combobox .
        /// 
        /// - trạng thái có 3 trang thái : phê duyệt , đang phê duyệt , không phê duyệt.
        /// 
        /// - xử lý ngày(regex)
        /// 
        /// - trước khi bấm lưu thông báo có muốn lưu thay đổi.
        /// 
        /// - 
        /// 
        /// </summary>

        public ChiTietKhenThuong()
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
