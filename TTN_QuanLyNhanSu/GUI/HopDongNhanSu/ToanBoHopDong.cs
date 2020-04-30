using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.HopDongNhanSu
{
    public partial class ToanBoHopDong : Form
    {
        public ToanBoHopDong()
        {
            InitializeComponent();
        }

        private void ToanBoHopDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.HopDongNhanSu' table. You can move, or remove it, as needed.
            this.hopDongNhanSuTableAdapter.Fill(this.tTN_QLNhanSuDataSet.HopDongNhanSu);

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
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietHopDong formChiTietHopDong = new ChiTietHopDong();
            formChiTietHopDong.FormClosed += FormChiTietHopDong_FormClosed;
            formChiTietHopDong.Show();

        }

        private void FormChiTietHopDong_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
