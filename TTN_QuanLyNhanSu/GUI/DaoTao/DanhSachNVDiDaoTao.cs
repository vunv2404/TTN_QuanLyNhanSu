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

namespace TTN_QuanLyNhanSu.GUI.DaoTao
{
    public partial class DanhSachNVDiDaoTao : Form
    {
        NhanVienBUS nhanVienBUS;
        public DanhSachNVDiDaoTao()
        {
            InitializeComponent();
        }

        public DanhSachNVDiDaoTao(string MaDaoTao)
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
            dataGridViewDSNVDiDaoTao.DataSource = nhanVienBUS.NhanVienKyLuat(MaDaoTao);
        }


        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
