using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.Luong
{
    public partial class DanhSach : Form
    {
        public DanhSach()
        {
            InitializeComponent();
        }

        private void DanhSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter.Fill(this.tTN_QLNhanSuDataSet.Luong);

        }
    }
}
