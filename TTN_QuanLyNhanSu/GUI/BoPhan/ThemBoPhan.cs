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
    public partial class ThemBoPhan : Form
    {

        /// <summary>
        /// 
        /// - Đẩy tên phòng ban trong database lên combobox tên phòng ban
        /// 
        /// - Khi thêm phải ánh xạ lại tên phòng ban về mã phòng ban để thêm.
        /// 
        /// - trước khi thêm hiện ra thông báo có muốn thêm.
        /// 
        /// - kiểm ta các trường phải đủ dữ liệu ko thì phải focus đến đúng trường thiếu.
        /// 
        /// - xử lí dữ liệu trước khi thêm.(regex)
        /// </summary>


        public ThemBoPhan()
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
