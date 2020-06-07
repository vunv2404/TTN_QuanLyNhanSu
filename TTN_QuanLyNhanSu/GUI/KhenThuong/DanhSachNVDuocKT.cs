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
using TTN_QuanLyNhanSu.DAL;

namespace TTN_QuanLyNhanSu.GUI.KhenThuong
{
    public partial class DanhSachNVDuocKT : Form
    {
        KhenThuongBUS khenThuongController = new KhenThuongBUS();
        public DanhSachNVDuocKT()
        {
            InitializeComponent();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DanhSachNVDuocKT_Load(object sender, EventArgs e)
        {
            dataGridViewDSNVDuocKT.AllowUserToAddRows = false;
            dataGridViewDSNVDuocKT.AllowUserToDeleteRows = false;
            dataGridViewDSNVDuocKT.AllowUserToOrderColumns = false;
            dataGridViewDSNVDuocKT.AllowUserToResizeRows = false;
            dataGridViewDSNVDuocKT.MultiSelect = false;
            dataGridViewDSNVDuocKT.ReadOnly = true;
            dataGridViewDSNVDuocKT.RowHeadersVisible = false;
            dataGridViewDSNVDuocKT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSNVDuocKT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable dt = khenThuongController.Show_NhanVien_DuocKhenThuong(QuyetDinhKhenThuong.soQuyetDinh);
            foreach(DataRow dr in dt.Rows)
            {
                string tenPB = DataProvider.Instance.ExecuteScalar($"select TenPB from PhongBan where MaPhongBan = '{dr[2]}'").ToString();
                dr[2] = tenPB;
            }
            dataGridViewDSNVDuocKT.DataSource = dt;
            dataGridViewDSNVDuocKT.Columns[0].HeaderText = "Mã Nhân Viên";
            dataGridViewDSNVDuocKT.Columns[1].HeaderText = "Tên Nhân Viên";
            dataGridViewDSNVDuocKT.Columns[2].HeaderText = "Tên Phòng Ban";    
        }
    }
}
