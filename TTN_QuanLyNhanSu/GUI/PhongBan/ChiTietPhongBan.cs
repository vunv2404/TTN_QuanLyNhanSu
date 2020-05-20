using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.PhongBan
{
    public partial class ChiTietPhongBan : Form
    {

        /// <summary>
        /// 
        /// - xửa lý dữ liệu ngày (regex).
        /// 
        /// - đem dữ liệu bên danh sách phòng ban ném lên các textbox.
        /// 
        /// - thông báo có muốn sửa khi sửa
        /// 
        /// </summary>
        public ChiTietPhongBan()
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
