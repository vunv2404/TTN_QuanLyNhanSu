using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.ChamCong
{
    public partial class DangKiLamThem : Form
    {

        /// <summary>
        /// - Ném dữ liệu từ dưới database lên combobox mã nhân viên.
        /// 
        /// - textBox tên nhân viên cũng đồng bộ tên nhaanvieen theo mã
        /// 
        /// - Xử lí dữ liệu trước khi thêm ,thiếu thì đặt focus vào đúng ô thiếu.
        /// 
        /// - hiện thông báo có muốn thêm không
        /// 
        /// - Xử lí dữ liệu ngày
        /// 
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview
        /// 
        /// </summary>
        public DangKiLamThem()
        {
            InitializeComponent();
        }

        private void DangKiLamThem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DangKilamThem' table. You can move, or remove it, as needed.
            this.dangKilamThemTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DangKilamThem);

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
