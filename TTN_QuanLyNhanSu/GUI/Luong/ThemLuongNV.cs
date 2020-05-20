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
    public partial class ThemLuongNV : Form
    {
        /// <summary>
        /// 
        /// - lấy dữ liệu ném lên combobox mã nhân viên
        /// 
        /// - Viết hàm tính toán.
        /// - A = (Mức Lương * Hệ SỐ * tổng ngầy công) + công làm thêm giờ 
        /// 
        /// - Tổng Lương nhận = A + Tiền phụ cấp - A*5%(Đây là thuế thu nhập) - 500.000(tiền bảo hiểm).
        /// 
        /// - Vd: A = (250.000*2,3*24) + 120.000*8(tiền * giờ)
        ///     tổng nhận = A + 300.000 - A*5% - 500.000
        ///     
        /// - xử lý ngày (regex).
        /// 
        /// - Xử lý dữ liệu trước khi thêm.
        /// 
        /// - thông báo các textbox trống và đặt focus và đúng ô trống.
        /// 
        /// - thông báo có muốn thêm trc khi thêm.
        /// 
        /// </summary>

        public ThemLuongNV()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
