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
    public partial class DanhSachBoPhan : Form
    {

        /// <summary>
        /// 
        /// - Tìm kiếm bộ phận theo tên phòng ban , tên bộ phận (combobox tìm kiếm)
        /// 
        /// - Chọn 1 dòng trên dataGrid mới cho hiện nút chi tiết .
        ///     
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview
        /// </summary>

        public DanhSachBoPhan()
        {
            InitializeComponent();
        }

        private void DanhSachBoPhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.BoPhan' table. You can move, or remove it, as needed.
            this.boPhanTableAdapter.Fill(this.tTN_QLNhanSuDataSet.BoPhan);

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemBoPhan formThemBoPhan = new ThemBoPhan();
            formThemBoPhan.FormClosed += FormThemBoPhan_FormClosed;
            formThemBoPhan.Show();
        }

        private void FormThemBoPhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietBoPhan formChiTietBoPhan = new ChiTietBoPhan();
            formChiTietBoPhan.FormClosed += FormChiTietBoPhan_FormClosed;
            formChiTietBoPhan.Show();
        }

        private void FormChiTietBoPhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
