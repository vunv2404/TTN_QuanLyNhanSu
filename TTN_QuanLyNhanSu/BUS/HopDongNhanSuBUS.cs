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
    class HopDongNhanSuBUS
    {
        public int GetMaNS()
        {
            return (int)DataProvider.Instance.ExecuteScalar("GetMaNS");
        }
        public string GetTenNS(string ma)
        {
            return DataProvider.Instance.ExecuteScalar("GetTenNS '" + ma + "'").ToString();
        }
        public string GetMaHopDong()
        {
            return DataProvider.Instance.ExecuteScalar("GetMaHopDong").ToString();
        }
        public bool AddHopDong(DTO.HopDongNhanSu hd)
        {
            string query = string.Format("AddHopDong '{0}', '{1}', N'{2}', N'{3}', N'{4}', '{5}', '{6}', N'{7}'", hd.SoHopDong, hd.MaNV, hd.HoTenNV, hd.LoaiHopDong, hd.TrangThai, hd.NgayHieuLuc, hd.NgayHetHan, hd.NoiDung);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public DataTable GetDanhSachHopDongFilter(string str1, string str2)
        {
            return DataProvider.Instance.ExecuteQuery("GetDanhSachHopDongFilter N'" + str1 + "', N'" + str2 + "'");
        }
        public bool EditHopDong(string sohd,string ma,string ten,string loaihd,string trangthai, string ngayhieuluc,string ngayhethan, string nd)
        {
            string query = string.Format("EditHopDong '{0}', '{1}', N'{2}', N'{3}', N'{4}', '{5}', '{6}', N'{7}'", sohd, ma, ten, loaihd , trangthai, ngayhieuluc, ngayhethan, nd);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
