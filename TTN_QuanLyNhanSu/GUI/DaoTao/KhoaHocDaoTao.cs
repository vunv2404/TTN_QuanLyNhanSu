using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.DaoTao
{
    public partial class KhoaHocDaoTao : Form
    {
        /// <summary>
        /// - Thêm khóa học kích vào Thêm
        /// 
        /// - Kích vào 1 dòng trên dataGrid thì nút Chi tiết và nút thêm nhân viên đi đào tạo kích hoạt và mang dữ liệu sang 2 form.
        /// 
        /// - Tìm kiếm theo 3 loại trên combobox còn nội dung tìm kiếm trên textbox .
        ///     (Số lượng , người phụ trách , chi phí)
        /// 
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview
        /// 
        /// - Đưa ra danh sach nhân viên dduocj đi đào tạo theo mã đào tạo gôm(mã nhân viên , tên nhân viên)button Danh Sách Nhân Sự đào Tạo.
        /// 
        /// </summary>



        public KhoaHocDaoTao()
        {
            InitializeComponent();
        }

        private void KhoaHocDaoTao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DaoTao' table. You can move, or remove it, as needed.
            this.daoTaoTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DaoTao);
            textBoxTong.Text = dataGridViewKhoaHocDaoTao.Rows.Count.ToString();
            comboBoxTimKiem.SelectedIndex = 0;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemKhoaHoc formThemKhoaHoc = new ThemKhoaHoc();
            formThemKhoaHoc.FormClosed += FormThemKhoaHoc_FormClosed;
            formThemKhoaHoc.Show();
        }

        private void FormThemKhoaHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            this.tTN_QLNhanSuDataSet.KyLuat.AcceptChanges();
            this.daoTaoTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DaoTao);
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cell = dataGridViewKhoaHocDaoTao.CurrentRow.Cells;
            this.Hide();
            ChiTietKhoaHoc formChiTietKhoaHoc = new ChiTietKhoaHoc(new DTO.DaoTao(cell[0].Value.ToString(),DateTime.Parse(cell[1].Value.ToString()), cell[2].Value.ToString(),Int32.Parse(cell[3].Value.ToString()), cell[4].Value.ToString(), decimal.Parse(cell[5].Value.ToString()),cell[6].Value.ToString()));
            formChiTietKhoaHoc.FormClosed += FormChiTietKhoaHoc_FormClosed;
            formChiTietKhoaHoc.Show();
        }

        private void FormChiTietKhoaHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            this.tTN_QLNhanSuDataSet.KyLuat.AcceptChanges();
            this.daoTaoTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DaoTao);
        }

        private void buttonDaoTaoNhanSu_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cell = dataGridViewKhoaHocDaoTao.CurrentRow.Cells;
            this.Hide();
            DaoTaoNhanVien formDaoTaoNhanVien = new DaoTaoNhanVien(new DTO.DaoTao(cell[0].Value.ToString(), DateTime.Parse(cell[1].Value.ToString()), cell[2].Value.ToString(), Int32.Parse(cell[3].Value.ToString()), cell[4].Value.ToString(), decimal.Parse(cell[5].Value.ToString()), cell[6].Value.ToString()));
            formDaoTaoNhanVien.FormClosed += FormDaoTaoNhanVien_FormClosed;
            formDaoTaoNhanVien.Show();
        }

        private void FormDaoTaoNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            switch (comboBoxTimKiem.Text)
            {
                case "Người Phụ Trách":
                    {                     
                        dataGridViewKhoaHocDaoTao.DataSource = this.tTN_QLNhanSuDataSet.DaoTao.Select("NguoiPhuTrach like '%"+textBoxTimKiem.Text+"%'");
                        break;
                    }
                case "Chi Phí":
                    {
                        try
                        {
                            dataGridViewKhoaHocDaoTao.DataSource = this.tTN_QLNhanSuDataSet.DaoTao.Select("ChiPhi = " + textBoxTimKiem.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Không thể tìm kiếm");
                        }
                        break;
                    }
                case "Số Lượng": 
                    {
                        try
                        {
                            dataGridViewKhoaHocDaoTao.DataSource = this.tTN_QLNhanSuDataSet.DaoTao.Select("SoLuong =" + textBoxTimKiem.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Không thể tìm kiếm");
                        }
                            break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonDSNhanSuDaoTao_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachNVDiDaoTao danhSachNVDiDaoTao = new DanhSachNVDiDaoTao();
            danhSachNVDiDaoTao.FormClosed += DanhSachNVDiDaoTao_FormClosed;
            danhSachNVDiDaoTao.Show();
        }

        private void DanhSachNVDiDaoTao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void dataGridViewKhoaHocDaoTao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonChiTiet.Enabled = true;
            buttonDaoTaoNhanSu.Enabled = true;
            buttonThem.Enabled = true;
        }
    }
}
