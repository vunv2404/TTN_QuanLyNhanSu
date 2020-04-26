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
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.BaoHiem' table. You can move, or remove it, as needed.
            this.baoHiemTableAdapter.Fill(this.tTN_QLNhanSuDataSet.BaoHiem);

        }
    }
}
