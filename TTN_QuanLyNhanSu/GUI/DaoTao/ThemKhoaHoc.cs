using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.GUI.DaoTao
{
    public partial class ThemKhoaHoc : Form
    {
        /// <summary>
        /// 
        /// - xử lý ngày lập .
        /// - trước khi thêm tạo thông báo có chắc chắn thêm
        /// 
        /// </summary>
        Utility utility;
        public ThemKhoaHoc()
        {
            InitializeComponent();
            utility = new Utility();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNgayLap_TextChanged(object sender, EventArgs e)
        {
            utility.DateTimeFiller_TextChanged(sender as TextBox);
        }

        private void textBoxNgayLap_KeyPress(object sender, KeyPressEventArgs e)
        {
            utility.DateTimeFiller_KeyPressed(sender as TextBox, e);
        }
    }
}
