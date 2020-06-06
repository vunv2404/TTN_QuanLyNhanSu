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
    class ChamCongBUS
    {
        public List<DangKiChuyenCa> Convert_DataTable_To_ListDangKiChuyenCa(DataTable dt)
        {
            List<DangKiChuyenCa> dangKiChuyenCas = new List<DangKiChuyenCa>();
            dangKiChuyenCas = (from DataRow dr in dt.Rows
                               select new DangKiChuyenCa()
                               {MaNV = dr["MaNV"].ToString(),
                               HoTenNV = dr["HoTenNV"].ToString(),
                               CaCu = dr["CaCu"].ToString(),
                               CaMoi = dr["CaMoi"].ToString(),
                               TuNgay = Convert.ToDateTime(dr["TuNgay"].ToString()),
                               DenNgay = Convert.ToDateTime(dr["DenNgay"].ToString()),
                               LiDo = dr["LiDo"].ToString(),
                               TrangThai = dr["TrangThai"].ToString()
                               }).ToList();
            return dangKiChuyenCas;
        }
        public List<DangKiChuyenCa> Show_All_DangKiChuyenCas()
        {
            return Convert_DataTable_To_ListDangKiChuyenCa(DataProvider.Instance.ExecuteQuery("" +
                "select * from DangKiChuyenCa"));
        }
    }
}
