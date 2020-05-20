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
    public partial class DangKiChuyenCa : Form
    {

        /// <summary>
        /// 
        /// - Dữ liệu dưới database ném lên combobox
        /// 
        /// - cập nhật luôn cả tên nhân viên theo mã 
        /// 
        /// - Xử lí dữ liệu ngày 
        /// 
        /// - Xử lí dữ liệu trước khi thêm , thiếu thì đặt focus vào đúng ô thiếu.
        /// 
        /// - Hiện ra thông báo có muốn thêm không.
        /// 
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview
        /// 
        /// </summary>
        public DangKiChuyenCa()
        {
            InitializeComponent();
        }

        private void DangKiChuyenCa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DangKiChuyenCa' table. You can move, or remove it, as needed.
            this.dangKiChuyenCaTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DangKiChuyenCa);

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
