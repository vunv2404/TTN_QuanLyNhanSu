using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.KyLuat
{
    public partial class QuyetDinhKyLuat : Form
    {
        public QuyetDinhKyLuat()
        {
            InitializeComponent();
        }

        private void QuyetDinhKyLuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.KyLuat' table. You can move, or remove it, as needed.
            this.kyLuatTableAdapter.Fill(this.tTN_QLNhanSuDataSet.KyLuat);

        }
    }
}
