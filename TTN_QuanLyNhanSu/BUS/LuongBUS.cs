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
    class LuongBUS
    {
        public bool ThemLuongNV(Luong luong)
        {
            string query = string.Format("exec PROC_ThemLuongNV '{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}', '{8}' ", luong.MaNV, luong.SoQuyetDinh, luong.NgayKi, luong.NgayHieuLuc, luong.MucLuong, luong.HeSo, luong.TongNgayCong, luong.CongLamThemGio, luong.PhuCap);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool SuaLuongNV(Luong luong)
        {
            string query = string.Format("exec PROC_SuaLuongNV '{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}', '{8}' ", luong.MaNV, luong.SoQuyetDinh, luong.NgayKi, luong.NgayHieuLuc, luong.MucLuong, luong.HeSo, luong.TongNgayCong, luong.CongLamThemGio, luong.PhuCap);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public DataTable TatCaLuongNV()
        {
            string query = string.Format("exec PROC_TatCaLuongNV ");

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public Luong XemChiTietLuongNV(string manhanvien)
        {
            string query = string.Format("exec PROC_XemChiTietLuongNV '{0}' ", manhanvien);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            Luong luong = new Luong();


            luong.MaNV = dt.Rows[0]["MaNV"].ToString();
            luong.SoQuyetDinh = dt.Rows[0]["SoQuyetDinh"].ToString();
            luong.NgayKi = DateTime.Parse(dt.Rows[0]["NgayKi"].ToString());
            luong.NgayHieuLuc = DateTime.Parse(dt.Rows[0]["NgayHieuLuc"].ToString());
            luong.MucLuong = decimal.Parse(dt.Rows[0]["MucLuong"].ToString());
            luong.HeSo = float.Parse(dt.Rows[0]["HeSo"].ToString());
            luong.TongNgayCong = Int16.Parse(dt.Rows[0]["TongNgayCong"].ToString());
            luong.CongLamThemGio = decimal.Parse(dt.Rows[0]["CongLamThemGio"].ToString());
            luong.PhuCap = decimal.Parse(dt.Rows[0]["PhuCap"].ToString());
            luong.ThueThuNhap = decimal.Parse(dt.Rows[0]["ThueThuNhap"].ToString());
            luong.TongLuongNhan = decimal.Parse(dt.Rows[0]["TongLuongNhan"].ToString());

            return luong;
        }

        public DataTable XemNV()
        {
            string query = string.Format("exec PROC_XemNV ");

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemTenNV(string keyword)
        {
            string query = string.Format("select Luong.* from Luong join HoSoNhanSu on Luong.MaNV = HoSoNhanSu.MaNV where HoSoNhanSu.HoTenNV like N'%" + keyword + "%'");

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
