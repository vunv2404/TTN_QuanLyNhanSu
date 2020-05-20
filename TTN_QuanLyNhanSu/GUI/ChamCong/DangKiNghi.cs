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
    public partial class DangKiNghi : Form
    {

        /// <summary>
        /// 
        /// - Ném dữ liệu từ database lên combobox mã nhân viên
        /// 
        /// - textBOx tên nhân viên sẽ cập nhật tên nhân viên theo mã nhân viên.
        /// 
        /// - Xử lí dữ liệu ngày
        /// 
        /// - Xử lí dữ liệu trước khi thêm . thiếu thì đặt focus vào đúng ô thiếu.
        /// 
        /// - hiện thông báo có muốn thêm không.
        /// 
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview
        /// 
        /// </summary>
        public DangKiNghi()
        {
            InitializeComponent();
        }

        private void DangKiNghi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DangKiNghi' table. You can move, or remove it, as needed.
            this.dangKiNghiTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DangKiNghi);

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
