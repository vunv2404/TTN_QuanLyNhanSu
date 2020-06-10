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
                               {
                                   Ma = dr["Ma"].ToString(),
                                   MaNV = dr["MaNV"].ToString(),
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
        public bool Insert_1_DangKiChuyenCa(DangKiChuyenCa dangKiChuyenCa)
        {
            return DataProvider.Instance.ExecuteNonQuery("" +
                "insert into DangKiChuyenCa(MaNV,HoTenNV,CaCu,CaMoi,TuNgay,DenNgay,LiDo,TrangThai) " +
                $"values('{dangKiChuyenCa.MaNV}', " +
                $"N'{dangKiChuyenCa.HoTenNV}', " +
                $"N'{dangKiChuyenCa.CaCu}', " +
                $"N'{dangKiChuyenCa.CaMoi}', " +
                $"'{dangKiChuyenCa.TuNgay.Month}/{dangKiChuyenCa.TuNgay.Day}/{dangKiChuyenCa.TuNgay.Year}', " +
                $"'{dangKiChuyenCa.DenNgay.Month}/{dangKiChuyenCa.DenNgay.Day}/{dangKiChuyenCa.DenNgay.Year}', " +
                $"N'{dangKiChuyenCa.LiDo}', " +
                $"N'{dangKiChuyenCa.TrangThai}')") > 0;
        }
        public DataTable Show_All_DangKiNghi()
        {
            return DataProvider.Instance.ExecuteQuery("select * from DangKiNghi");
        }
        public void Insert_1_DangKiNghi(DangKiNghi dangKiNghi)
        {
            DataProvider.Instance.ExecuteNonQuery("" +
                "insert into DangKiNghi(MaNV,HoTenNV,TuNgay,DenNgay,LiDo,TrangThai) " +
                $"values('{dangKiNghi.MaNV}', " +
                $"N'{dangKiNghi.HoTenNV}', " +
                $"'{dangKiNghi.TuNgay.Month}/{dangKiNghi.TuNgay.Day}/{dangKiNghi.TuNgay.Year}', " +
                $"'{dangKiNghi.DenNgay.Month}/{dangKiNghi.DenNgay.Day}/{dangKiNghi.DenNgay.Year}', " +
                $"N'{dangKiNghi.LiDo}', " +
                $"N'{dangKiNghi.TrangThai}')") ;
        }
        public DataTable Show_All_DangKiLamThem()
        {
            return DataProvider.Instance.ExecuteQuery("select * from DangKiLamThem");
        }
        public void Insert_1_DangKiLamThem(DangKiLamThem dangKiLamThem)
        {
            DataProvider.Instance.ExecuteNonQuery("" +
                "insert into DangKiLamThem(MaNV,HoTenNV,TuNgay,DenNgay,LuongTangCa,SoGio,TrangThai) " +
                $"values('{dangKiLamThem.MaNV}', " +
                $"N'{dangKiLamThem.HoTenNV}', " +
                $"'{dangKiLamThem.TuNgay.Month}/{dangKiLamThem.TuNgay.Day}/{dangKiLamThem.TuNgay.Year}', " +
                $"'{dangKiLamThem.DenNgay.Month}/{dangKiLamThem.DenNgay.Day}/{dangKiLamThem.DenNgay.Year}', " +
                $"{dangKiLamThem.LuongTangCa}, " +
                $"{dangKiLamThem.SoGio}, " +
                $"N'{dangKiLamThem.TrangThai}')");
        }
    }
}
