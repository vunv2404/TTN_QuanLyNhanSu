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

namespace TTN_QuanLyNhanSu.GUI.KyLuat
{
    public partial class DanhSachNVBiKL : Form
    {
        NhanVienBUS nhanVienBUS;
        public DanhSachNVBiKL()
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
        }

        public DanhSachNVBiKL(string SoQuyetDinh)
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
            dataGridViewDSNVBikyLuat.DataSource = nhanVienBUS.NhanVienKyLuat(SoQuyetDinh);
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
