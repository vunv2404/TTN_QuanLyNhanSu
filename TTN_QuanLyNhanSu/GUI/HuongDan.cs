using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI
{
    public partial class HuongDan : Form
    {
        public HuongDan()
        {
            InitializeComponent();
        }
        public static string FormName;

        private void HuongDan_Load(object sender, EventArgs e)
        {
            if (FormName == "GiaoDienChinh")
            {
                tabHuongDan.SelectedTab = tabGiaoDienChinh;
            }
            else if(FormName == "DanhSachPhongBan")
            {
                tabHuongDan.SelectedTab = tabPhongBan;
            }
            else if (FormName == "CTPB")
            {
                tabControlPB.SelectedTab = tabChiTietPhongBan;
            }
            else if (FormName == "BaoHiem")
            {
                tabHuongDan.SelectedTab = tabBaoHiem;
            }
            else if (FormName == "BoPhan")
            {
                tabHuongDan.SelectedTab = tabBoPhan;
            }
            else if (FormName == "ChamCong")
            {
                tabHuongDan.SelectedTab = tabChamCong;
            }
            else if (FormName == "DaoTao")
            {
                tabHuongDan.SelectedTab = tabDaoTao;
            }
            else if (FormName == "HoSoNhanSu")
            {
                tabHuongDan.SelectedTab = tabHoSoNhanSu;
            }
            else if (FormName == "HopDongNhanSu")
            {
                tabHuongDan.SelectedTab = tabHopDongNhanSu;
            }
            else if (FormName == "KhenThuong")
            {
                tabHuongDan.SelectedTab = tabKhenThuong;
            }
            else if (FormName == "KiLuat")
            {
                tabHuongDan.SelectedTab = tabKiLuat;
            }
            else if (FormName == "Luong")
            {
                tabHuongDan.SelectedTab = tabLuong;
            }
        }
    }
}
