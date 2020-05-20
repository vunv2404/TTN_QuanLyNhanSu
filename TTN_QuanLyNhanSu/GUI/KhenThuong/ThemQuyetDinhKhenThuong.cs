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
    public partial class ThemQuyetDinhKhenThuong : Form
    {

        /// <summary>
        /// 
        /// - Thêm dữ liệu vào các textbox , combox có sãn dữ liệu : Phê duyệt , đang phe duyệt , không phê duyệt
        /// 
        /// - xử lý dư liệu ngày (regex).
        /// 
        /// - khi bấm lưu thì thông báo có muốn thêm .
        /// 
        /// </summary>


        public ThemQuyetDinhKhenThuong()
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
