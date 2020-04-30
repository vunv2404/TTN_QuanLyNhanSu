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
        public KhoaHocDaoTao()
        {
            InitializeComponent();
        }

        private void KhoaHocDaoTao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DaoTao' table. You can move, or remove it, as needed.
            this.daoTaoTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DaoTao);

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
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietKhoaHoc formChiTietKhoaHoc = new ChiTietKhoaHoc();
            formChiTietKhoaHoc.FormClosed += FormChiTietKhoaHoc_FormClosed;
            formChiTietKhoaHoc.Show();
        }

        private void FormChiTietKhoaHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonDaoTaoNhanSu_Click(object sender, EventArgs e)
        {
            this.Hide();
            DaoTaoNhanVien formDaoTaoNhanVien = new DaoTaoNhanVien();
            formDaoTaoNhanVien.FormClosed += FormDaoTaoNhanVien_FormClosed;
            formDaoTaoNhanVien.Show();
        }

        private void FormDaoTaoNhanVien_FormClosed(object sender, FormClosedEventArgs e)
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
