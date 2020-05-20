using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.KyLuat
{
    public partial class ThemQuyetDinhKyLuat : Form
    {

        /// <summary>
        /// 
        /// - xử Lý ngày (regex)
        /// 
        /// - Trạng thái có 3 trạng thái đã được thêm sẵn.
        /// 
        /// - thông báo có muốn thêm trước khi lưu thay đổi
        /// 
        /// </summary>

        public ThemQuyetDinhKyLuat()
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
