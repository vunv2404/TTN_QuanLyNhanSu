using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.DaoTao
{
    public partial class KhoaHocDaoTao : Form
    {
        public KhoaHocDaoTao()
        {
            InitializeComponent();
        }

        private void KhoaHocDaoTao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DaoTao' table. You can move, or remove it, as needed.
            this.daoTaoTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DaoTao);

        }
    }
}
