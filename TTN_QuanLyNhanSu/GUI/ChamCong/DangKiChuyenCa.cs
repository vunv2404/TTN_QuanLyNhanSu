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
    public partial class DangKiChuyenCa : Form
    {
        public DangKiChuyenCa()
        {
            InitializeComponent();
        }

        private void DangKiChuyenCa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DangKiChuyenCa' table. You can move, or remove it, as needed.
            this.dangKiChuyenCaTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DangKiChuyenCa);

        }
    }
}
