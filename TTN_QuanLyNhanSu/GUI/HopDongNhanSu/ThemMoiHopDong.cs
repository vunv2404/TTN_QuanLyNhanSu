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
    public partial class ThemMoiHopDong : Form
    {

        /// <summary>
        /// 
        /// - Thêm mới 1 bản ghi
        /// 
        /// - Xử lí ngày 
        /// 
        /// - Đưa dữu liệu từ database lên mã nhân viên.
        /// 
        /// - Họ tên nhân viên đồng bộ theo mã nhân viên.
        /// 
        /// - 
        /// 
        /// - trước khi Thêm xử lý dữ liệu và tạo thông báo có muốn Thêm.
        /// 
        /// 
        /// </summary>

        public ThemMoiHopDong()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
