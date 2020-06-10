using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QuanLyNhanSu.BUS;

namespace TTN_QuanLyNhanSu.GUI.HopDongNhanSu
{
    public partial class ToanBoHopDong : Form
    {
        private BUS.HopDongNhanSuBUS hopDongBUS = new HopDongNhanSuBUS();
        /// <summary>
        /// 
        /// - Bấm vào thêm mới sang form thêm mới.
        /// 
        /// - click vào 1 dòng trên data grid thì nút chi tiết mới mở khóa .
        /// 
        /// - Ném dữ liệu của dòng dataGrid sang bên chi tiết hợp đồng.
        /// 
        /// - Tìm kiếm theo 2 loại tên nhân viên và loại hợp đồng.
        /// 
        /// - TextBox Tìm kiếm là nhập nộ dung tìm kiếm theo 1 trong 2 loại trên.
        /// 
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview
        /// 
        /// </summary>

        public ToanBoHopDong()
        {
            InitializeComponent();

            textBoxTong.Text = dataGridViewToanBoHopDong.Rows.Count.ToString();
            comboBoxTimKiem.SelectedItem = "None";
        }

        private void ToanBoHopDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.HopDongNhanSu' table. You can move, or remove it, as needed.
            dataGridViewToanBoHopDong.DataSource = hopDongBUS.GetDanhSachToanBoHopDong();
            textBoxTong.Text = dataGridViewToanBoHopDong.Rows.Count.ToString();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemMoiHopDong formThemMoiHopDong = new ThemMoiHopDong();
            formThemMoiHopDong.FormClosed += FormThemMoiHopDong_FormClosed;
            formThemMoiHopDong.Show();
        }

        private void FormThemMoiHopDong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            dataGridViewToanBoHopDong.DataSource = null;
            dataGridViewToanBoHopDong.DataSource = hopDongBUS.GetDanhSachToanBoHopDong();
            textBoxTong.Text = dataGridViewToanBoHopDong.Rows.Count.ToString();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataGridViewRow row = dataGridViewToanBoHopDong.CurrentRow;
            ChiTietHopDong formChiTietHopDong = new ChiTietHopDong(
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                Convert.ToDateTime(row.Cells[5].Value),
                Convert.ToDateTime(row.Cells[6].Value),
                row.Cells[7].Value.ToString()
                );
            formChiTietHopDong.FormClosed += FormChiTietHopDong_FormClosed;
            formChiTietHopDong.Show();

        }

        private void FormChiTietHopDong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            dataGridViewToanBoHopDong.DataSource = null;
            dataGridViewToanBoHopDong.DataSource = hopDongBUS.GetDanhSachToanBoHopDong();
            textBoxTong.Text = dataGridViewToanBoHopDong.Rows.Count.ToString();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Nhập dữ liệu cần tìm kiếm");
            }
            else
            {
                dataGridViewToanBoHopDong.DataSource = null;
                dataGridViewToanBoHopDong.DataSource = hopDongBUS.GetDanhSachHopDongFilter(comboBoxTimKiem.SelectedItem.ToString(), textBoxTimKiem.Text.Trim());
                textBoxTong.Text = dataGridViewToanBoHopDong.Rows.Count.ToString();
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTimKiem.Text == "None")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.Enabled = false;
                dataGridViewToanBoHopDong.DataSource = null;
                dataGridViewToanBoHopDong.DataSource = hopDongBUS.GetDanhSachHopDongFilter(comboBoxTimKiem.SelectedItem.ToString(), textBoxTimKiem.Text.Trim());
                textBoxTong.Text = dataGridViewToanBoHopDong.Rows.Count.ToString();
            }
            else
            {
                textBoxTimKiem.Enabled = true;
            }
        }

        private void dataGridViewToanBoHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonChiTiet.Enabled = true;
        }
    }
}
