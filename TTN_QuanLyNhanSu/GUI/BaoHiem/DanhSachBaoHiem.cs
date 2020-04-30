using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.BaoHiem
{
    public partial class DanhSachBaoHiem : Form
    {
        public DanhSachBaoHiem()
        {
            InitializeComponent();
        }

        private void DanhSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.BaoHiem' table. You can move, or remove it, as needed.
            this.baoHiemTableAdapter.Fill(this.tTN_QLNhanSuDataSet.BaoHiem);
            //// TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.BaoHiem' table. You can move, or remove it, as needed.
            //this.baoHiemTableAdapter.Fill(this.tTN_QLNhanSuDataSet.BaoHiem);

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemBaoHiem formThemBaoHiem = new ThemBaoHiem();
            formThemBaoHiem.FormClosed += FormThemBaoHiem_FormClosed;
            formThemBaoHiem.Show();
        }

        private void FormThemBaoHiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietBaoHiem formChiTietBaoHiem = new ChiTietBaoHiem();
            formChiTietBaoHiem.FormClosed += FormChiTietBaoHiem_FormClosed;
            formChiTietBaoHiem.Show();
        }

        private void FormChiTietBaoHiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            

        }
    }
}
