using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.ChamCong
{
    public partial class DangKiNghi : Form
    {
        public DangKiNghi()
        {
            InitializeComponent();
        }

        private void DangKiNghi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DangKiNghi' table. You can move, or remove it, as needed.
            this.dangKiNghiTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DangKiNghi);

        }
    }
}
