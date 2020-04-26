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
    }
}
