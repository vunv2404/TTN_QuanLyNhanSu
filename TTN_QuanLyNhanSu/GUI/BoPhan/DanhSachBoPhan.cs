using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QuanLyNhanSu.BUS;

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

        BoPhanNhanSuBUS contrlBoPhan = new BoPhanNhanSuBUS();
        string mabophan;

        private static DataGridView dtgvBP;
        public static DataGridView DtgvBP { get => dtgvBP; set => dtgvBP = value; }
        private static TextBox textboxTong;
        public static TextBox TextboxTong { get => textboxTong; set => textboxTong = value; }

        public DanhSachBoPhan()
        {
            InitializeComponent();

            dtgvBP = dataGridViewDanhSachBoPhan;
            textboxTong = textBoxTong;
        }

        private void DanhSachBoPhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.BoPhan' table. You can move, or remove it, as needed.
            //this.boPhanTableAdapter.Fill(this.tTN_QLNhanSuDataSet.BoPhan);
            dataGridViewDanhSachBoPhan.DataSource = contrlBoPhan.XemTatCaBoPhanNS();
            dataGridViewDanhSachBoPhan.Refresh();

            textBoxTong.Text = dataGridViewDanhSachBoPhan.Rows.Count.ToString();
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
            ChiTietBoPhan formChiTietBoPhan = new ChiTietBoPhan(mabophan);
            formChiTietBoPhan.FormClosed += FormChiTietBoPhan_FormClosed;
            formChiTietBoPhan.Show();

            buttonChiTiet.Enabled = true;
        }

        private void FormChiTietBoPhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string keywords = textBoxTimKiem.Text;
            string loaiTT;
            if (comboBoxTimKiem.SelectedItem == null)
            {
                MessageBox.Show("Chọn thông tin cần tìm kiếm");
            }
            else
            {
                loaiTT = comboBoxTimKiem.SelectedItem.ToString();

                List<DTO.BoPhan> dsBoPhan = contrlBoPhan.XemTatCaBoPhanNS();
                List<DTO.BoPhan> items = dsBoPhan;

                switch (loaiTT)
                {
                    case "Tên Bộ Phận":
                        items = dsBoPhan.FindAll(item => item.TenBoPhan.ToUpper().Contains(keywords.ToUpper()));
                        break;
                    case "Tên Phòng Ban":
                        items = contrlBoPhan.TimKiemTenPB(keywords);
                        break;
                    default:
                        break;
                }

                dataGridViewDanhSachBoPhan.DataSource = items;
                dataGridViewDanhSachBoPhan.Refresh();
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewDanhSachBoPhan_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhSachBoPhan.Rows.Count == 0)
            {
                MessageBox.Show("Hãy thêm bộ phận mới");
            }
            else
            {
                int index = dataGridViewDanhSachBoPhan.SelectedRows[0].Index;

                mabophan = dataGridViewDanhSachBoPhan.Rows[index].Cells["maBoPhanDataGridViewTextBoxColumn"].Value.ToString();

                buttonChiTiet.Enabled = true;
            }
        }
    }
}
