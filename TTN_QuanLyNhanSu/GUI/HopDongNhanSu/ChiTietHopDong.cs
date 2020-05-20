using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.HopDongNhanSu
{
    public partial class ChiTietHopDong : Form
    {
        /// <summary>
        /// 
        /// - Ném dữ liệu bên datagrid lên các textbox và combobox .
        /// 
        /// - Cập nhật khi thay đổi dữ liệu nút cập nhật lúc này mưới được bật.
        /// 
        /// - trước khi cập nhật xử lý dữ liệu, tạo thông báo có muốn cập nhật.
        /// 
        /// - xử lí ngày
        /// 
        /// - xử lí dữ liệu trước khi cập nhật.
        /// 
        /// 
        /// </summary>

        public ChiTietHopDong()
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
