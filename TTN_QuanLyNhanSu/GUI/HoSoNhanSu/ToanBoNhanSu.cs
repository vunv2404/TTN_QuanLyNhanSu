using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.HoSoNhanSu
{
    public partial class ToanBoNhanSu : Form
    {
        /// <summary>
        /// 
        /// - button Thêm sang form Thêm mới 1 hồ sơ nhân sự
        /// 
        /// - click 1 dòng trên data gridview button Chi tiết mở khóa .
        /// 
        /// - combobox Tìm Kiếm -> theo Mã Nhân Viên ,Tên Nhân Viên ,Bộ Phận
        /// - textbox Tìm kiếm -> nhập nội dung
        /// 
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview 
        /// 
        /// 
        /// </summary>
        public ToanBoNhanSu()
        {
            InitializeComponent();
        }

        private void ToanBoNhanSu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.HoSoNhanSu' table. You can move, or remove it, as needed.
            this.hoSoNhanSuTableAdapter.Fill(this.tTN_QLNhanSuDataSet.HoSoNhanSu);

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemMoiNhanSu formThemMoiNhanSu = new ThemMoiNhanSu();
            formThemMoiNhanSu.FormClosed += FormThemMoiNhanSu_FormClosed;
            formThemMoiNhanSu.Show();
        }

        private void FormThemMoiNhanSu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGridViewRow row = dataGridViewHoSoNhanSu.CurrentRow;
            ChiTietNhanSu formChiTietNhanSu = new ChiTietNhanSu(
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                Convert.ToDateTime(row.Cells[2].Value),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString(),
                Convert.ToDateTime(row.Cells[7].Value),
                row.Cells[8].Value.ToString(),
                row.Cells[9].Value.ToString(),
                row.Cells[10].Value.ToString(),
                row.Cells[11].Value.ToString(),
                row.Cells[12].Value.ToString(),
                row.Cells[13].Value.ToString(),
                row.Cells[14].Value.ToString()
                );
            formChiTietNhanSu.FormClosed += FormChiTietNhanSu_FormClosed;
            formChiTietNhanSu.Show();
        }

        private void FormChiTietNhanSu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewHoSoNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonChiTiet.Enabled = true;
        }
    }
}
