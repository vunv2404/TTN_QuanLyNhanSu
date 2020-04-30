using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.PhongBan
{
    public partial class DanhSachPhongBan : Form
    {
        public DanhSachPhongBan()
        {
            InitializeComponent();
        }

        private void DanhSachPhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.tTN_QLNhanSuDataSet.PhongBan);

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
            ChiTietPhongBan formChiTietPhongBan = new ChiTietPhongBan();
            formChiTietPhongBan.FormClosed += FormChiTietPhongBan_FormClosed;
            formChiTietPhongBan.Show();

        }

        private void FormChiTietPhongBan_FormClosed(object sender, FormClosedEventArgs e)
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
