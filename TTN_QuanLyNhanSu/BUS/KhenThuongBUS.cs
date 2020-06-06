using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN_QuanLyNhanSu.DAL;
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.BUS
{
    class KhenThuongBUS
    {
        //---------------Trung--------------------------//
        private List<KhenThuong> Convert_DT_To_ListKhenThuong(DataTable dt)
        {
            List<KhenThuong> khenThuongs = new List<KhenThuong>();
            khenThuongs = (from DataRow dr in dt.Rows
                           select new KhenThuong()
                           {
                               SoQuyetDinh = dr["SoQuyetDinh"].ToString(),
                               NgayHieuLuc = Convert.ToDateTime(dr["NgayHieuLuc"].ToString()),
                               NgayHetHan = Convert.ToDateTime(dr["NgayHetHan"].ToString()),
                               NoiDung = dr["NoiDung"].ToString(),
                               HinhThuc = dr["HinhThuc"].ToString(),
                               SoTien = (decimal)dr["SoTien"],
                               TrangThai = dr["TrangThai"].ToString()
                           }).ToList();
            return khenThuongs;
        }
        public List<KhenThuong> Show_All_KhenThuongs()
        {
            return Convert_DT_To_ListKhenThuong(DataProvider.Instance.ExecuteQuery("select * from KhenThuong"));
        }
        public List<KhenThuong> Show_1_KhenThuong(string SoQuyetDinh)
        {
            return Convert_DT_To_ListKhenThuong(DataProvider.Instance.ExecuteQuery("" +
                "select * " +
                "from KhenThuong " +
                $"where SoQuyetDinh = N'{SoQuyetDinh}'"));
        }
        public List<KhenThuong> Search_KhenThuong_TheoNoiDung(string noiDung)
        {
            return Convert_DT_To_ListKhenThuong(DataProvider.Instance.ExecuteQuery("" +
                "select * " +
                "from KhenThuong " +
                "where " +
                $"NoiDung like N'%{noiDung}%'"));
        }
        public void Modify_1_KhenThuong(KhenThuong khenThuong)
        {

        }
        //---------------Trung--------------------------//
    }
}
