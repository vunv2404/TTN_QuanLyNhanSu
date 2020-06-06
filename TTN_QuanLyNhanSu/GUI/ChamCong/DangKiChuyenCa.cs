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
using TTN_QuanLyNhanSu.DAL;

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

        List<DTO.DangKiChuyenCa> dangKiChuyenCas;
        ChamCongBUS chamCongController = new ChamCongBUS();
        public DangKiChuyenCa()
        {
            InitializeComponent();
        }

        private void DangKiChuyenCa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DangKiChuyenCa' table. You can move, or remove it, as needed.
            this.dangKiChuyenCaTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DangKiChuyenCa);
            dataGridViewDangKiChuyenCa.AllowUserToAddRows = false;
            dataGridViewDangKiChuyenCa.AllowUserToDeleteRows = false;
            dataGridViewDangKiChuyenCa.AllowUserToResizeRows = false;
            dataGridViewDangKiChuyenCa.MultiSelect = false;
            dataGridViewDangKiChuyenCa.ReadOnly = true;
            dataGridViewDangKiChuyenCa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDangKiChuyenCa.RowHeadersVisible = false;
            List<int> maNVs = new List<int>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("select MaNV from HoSoNhanSu");
            foreach (DataRow dr in dt.Rows)
            {
                maNVs.Add(Convert.ToInt32(dr[0].ToString()));
            }
            maNVs.Sort();
            comboBoxMaNhanVien.DataSource = maNVs;
            comboBoxMaNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateThongTin();
            DataGridViewRow currentRow = dataGridViewDangKiChuyenCa.CurrentRow;
            DataGridViewColumn column1 = new DataGridViewColumn();
            
            comboBoxMaNhanVien.Text = currentRow.Cells[0].Value.ToString();
            textBoxTenNhanVien.Text = currentRow.Cells[1].Value.ToString();
            textBoxCaCu.Text = currentRow.Cells[2].Value.ToString();
            textBoxCaMoi.Text = currentRow.Cells[3].Value.ToString();
            textBoxTuNgay.Text = Convert.ToDateTime(currentRow.Cells[4].Value.ToString()).ToShortDateString();
            textBoxDenNgay.Text = Convert.ToDateTime(currentRow.Cells[5].Value.ToString()).ToShortDateString();
            textBoxLiDo.Text = currentRow.Cells[6].Value.ToString();
            comboBoxTrangThai.Text = currentRow.Cells[7].Value.ToString();
        }
        private void UpdateThongTin()
        {
            dangKiChuyenCas = chamCongController.Show_All_DangKiChuyenCas();
            dataGridViewDangKiChuyenCa.DataSource = dangKiChuyenCas;
            if (dangKiChuyenCas.Count == 0)
            {               
                textBoxTong.Text = "0";
            }
            else
            {
                
                textBoxTong.Text = dangKiChuyenCas.Count.ToString();
            }

        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            UpdateThongTin();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDangKiChuyenCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridViewDangKiChuyenCa.CurrentRow;
            comboBoxMaNhanVien.Text = currentRow.Cells[0].Value.ToString();
            textBoxTenNhanVien.Text = currentRow.Cells[1].Value.ToString();
            textBoxCaCu.Text = currentRow.Cells[2].Value.ToString();
            textBoxCaMoi.Text = currentRow.Cells[3].Value.ToString();
            textBoxTuNgay.Text = Convert.ToDateTime(currentRow.Cells[4].Value.ToString()).ToShortDateString();
            textBoxDenNgay.Text = Convert.ToDateTime(currentRow.Cells[5].Value.ToString()).ToShortDateString();
            textBoxLiDo.Text = currentRow.Cells[6].Value.ToString();
            comboBoxTrangThai.Text = currentRow.Cells[7].Value.ToString();
        }
    }
}
