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

namespace TTN_QuanLyNhanSu.GUI.PhongBan
{
    public partial class DanhSachPhongBan : Form
    {

        /// <summary>
        /// 
        /// - Button Thêm : sang form thêm 1 phòng ban mới
        /// 
        /// - Button CHi Tiết: click vào 1 dòng thì nút này mới hiện lên.
        /// 
        /// - Tìm kiếm theo tên phòng ban
        /// 
        /// - Textbox tổng là tổng só dòng có trên datagrid view.
        /// 
        /// 
        /// </summary>
        PhongBanBUS contrlPhongBan = new PhongBanBUS();
        string maphongban;

        private static DataGridView dtgvPB;
        public static DataGridView DtgvPB { get => dtgvPB; set => dtgvPB = value; }
        private static TextBox textboxTong;
        public static TextBox TextboxTong { get => textboxTong; set => textboxTong = value; }

        public DanhSachPhongBan()
        {
            InitializeComponent();

            dtgvPB = dataGridViewDanhSachPhongBan;
            textboxTong = textBoxTong;
        }

        private void DanhSachPhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.PhongBan' table. You can move, or remove it, as needed.
            //this.phongBanTableAdapter.Fill(this.tTN_QLNhanSuDataSet.PhongBan);
            dataGridViewDanhSachPhongBan.DataSource = contrlPhongBan.XemTatCaPB();
            dataGridViewDanhSachPhongBan.Refresh();

            textBoxTong.Text = dataGridViewDanhSachPhongBan.Rows.Count.ToString();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemPhongBan formThemPhongBan = new ThemPhongBan();
            formThemPhongBan.FormClosed += FormThemPhongBan_FormClosed;
            formThemPhongBan.Show();
        }

        private void FormThemPhongBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietPhongBan formChiTietPhongBan = new ChiTietPhongBan(maphongban);
            formChiTietPhongBan.FormClosed += FormChiTietPhongBan_FormClosed;
            formChiTietPhongBan.Show();

            buttonChiTiet.Enabled = true;
        }

        private void FormChiTietPhongBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string keywords = textBoxTimKiem.Text;

            List<DTO.PhongBan> dsPhongBan = contrlPhongBan.XemTatCaPB();
            List<DTO.PhongBan> items = dsPhongBan;

            items = dsPhongBan.FindAll(item => item.TenPB.ToUpper().Contains(keywords.ToUpper()));

            dataGridViewDanhSachPhongBan.DataSource = items;
            dataGridViewDanhSachPhongBan.Refresh();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewDanhSachPhongBan_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhSachPhongBan.Rows.Count == 0)
            {
                MessageBox.Show("Hãy thêm phòng ban mới");
            }
            else
            {
                int index = dataGridViewDanhSachPhongBan.SelectedRows[0].Index;

                maphongban = dataGridViewDanhSachPhongBan.Rows[index].Cells["maPhongBanDataGridViewTextBoxColumn"].Value.ToString();

                buttonChiTiet.Enabled = true;
            }
        }
    }
}
