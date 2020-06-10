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
                               SoTien = Math.Round((decimal)dr["SoTien"],0),
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
            DataProvider.Instance.ExecuteNonQuery("" +
                "update khenThuong " +
                $"set NgayHieuLuc = '{khenThuong.NgayHieuLuc.Month}/{khenThuong.NgayHieuLuc.Day}/{khenThuong.NgayHieuLuc.Year}', " +
                $"NgayHetHan = '{khenThuong.NgayHetHan.Month}/{khenThuong.NgayHetHan.Day}/{khenThuong.NgayHetHan.Year}', " +
                $"NoiDung = N'{khenThuong.NoiDung}', " +
                $"HinhThuc = N'{khenThuong.HinhThuc}', " +
                $"SoTien = {khenThuong.SoTien}, " +
                $"TrangThai = N'{khenThuong.TrangThai}' " +
                $"where SoQuyetDinh = {khenThuong.SoQuyetDinh}");
        }
        public DataTable Show_NhanVien_DuocKhenThuong(string soQuyetDinh)
        {
            return DataProvider.Instance.ExecuteQuery("" +
                "select MaNV,HoTenNV,MaPhongBan from HoSoNhanSu " +
                "where MaNV in " +
                $"(select MaNV from KhenThuongNhanVien where SoQuyetDinh = {soQuyetDinh})");
        }
        public DataTable Show_NhanVien_KoDuocKhenThuong(string soQuyetDinh)
        {
            return DataProvider.Instance.ExecuteQuery("" +
                "select MaNV from HoSoNhanSu " +
                "where MaNV not in " +
                $"(select MaNV from KhenThuongNhanVien where SoQuyetDinh = {soQuyetDinh})");
        }
        public NhanSu Show_1_NhanSu(string maNV)
        {
            
            DataTable dt = DataProvider.Instance.ExecuteQuery("" +
                "select MaNV,HoTenNV,NgaySinh,GioiTinh,ChucVu,BoPhan,MaPhongBan " +
                "from HoSoNhanSu " +
                $"where MaNV = {maNV}");
            DataRow dr = dt.Rows[0];
            NhanSu nhanSu = new NhanSu(
                dr[0].ToString(),
                dr[1].ToString(),
                Convert.ToDateTime(dr[2].ToString()),
                dr[3].ToString(),
                dr[4].ToString(),
                dr[5].ToString(),
                DataProvider.Instance.ExecuteScalar($"select TenPB from PhongBan where MaPhongBan = '{dr[6]}'").ToString());
            return nhanSu;
        }
        public void Insert_1_KhenThuong(KhenThuong khenThuong)
        {
            DataProvider.Instance.ExecuteNonQuery("" +
                "insert into khenThuong(SoQuyetDinh,NgayHieuLuc,NgayHetHan,NoiDung,HinhThuc,SoTien,TrangThai)" +
                $"values( " +
                $"'{khenThuong.SoQuyetDinh}', " +
                $"'{khenThuong.NgayHieuLuc.Month}/{khenThuong.NgayHieuLuc.Day}/{khenThuong.NgayHieuLuc.Year}', " +
                $"'{khenThuong.NgayHetHan.Month}/{khenThuong.NgayHetHan.Day}/{khenThuong.NgayHetHan.Year}', " +
                $"N'{khenThuong.NoiDung}', " +
                $"N'{khenThuong.HinhThuc}', " +
                $"{khenThuong.SoTien}, " +
                $"N'{khenThuong.TrangThai}')");
                
                
        }
        //---------------Trung--------------------------//
    }
}
