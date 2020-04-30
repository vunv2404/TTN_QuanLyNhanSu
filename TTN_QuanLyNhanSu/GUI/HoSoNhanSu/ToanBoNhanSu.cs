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
            ChiTietNhanSu formChiTietNhanSu = new ChiTietNhanSu();
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
    }
}
