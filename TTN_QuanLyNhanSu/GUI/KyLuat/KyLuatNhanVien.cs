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
    public partial class KyLuatNhanVien : Form
    {

        /// <summary>
        /// 
        /// - Ném dữ liệu từ bảng bên form Kỉ luật sang bên này vứt lên các textbox bên trái.
        /// 
        /// - ném dữ liệu dưới database lên vứt vào combobox mã nhân viên ,
        ///      các thông tin của nhaanvieen đồng bộ theo mã nhân viên.
        ///      
        /// - trước khi lưu thông báo có chắc chắn lưu không.
        /// 
        /// </summary>

        public KyLuatNhanVien()
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
