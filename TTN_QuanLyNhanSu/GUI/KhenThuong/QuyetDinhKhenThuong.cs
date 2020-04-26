using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.KhenThuong
{
    public partial class QuyetDinhKhenThuong : Form
    {
        public QuyetDinhKhenThuong()
        {
            InitializeComponent();
        }

        private void QuyetDinhKhenThuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.KhenThuong' table. You can move, or remove it, as needed.
            this.khenThuongTableAdapter.Fill(this.tTN_QLNhanSuDataSet.KhenThuong);

        }
    }
}
