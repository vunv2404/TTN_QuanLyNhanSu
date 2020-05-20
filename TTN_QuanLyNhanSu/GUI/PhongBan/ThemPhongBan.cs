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
    public partial class ThemPhongBan : Form
    {

        /// <summary>
        /// - xử lý dữ liệu ngày (regex)
        /// 
        /// - Combobox đưa mã nhân viên lên và là những ai chưa làm trưởng phòng.
        /// 
        /// - Xử lý dữ liệu trước khi thêm.
        /// 
        /// - thông báo có muốn thêm trước khi thêm.
        /// </summary>
        public ThemPhongBan()
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
