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
    class NhanVienBUS
    {
        public DataTable NhanVienKyLuat(string soQuyetDinh)
        {
            string query = String.Format("NhanVienBiKyLuat '{0}'", soQuyetDinh);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable NhanVienDaoTao(string maDaoTao)
        {
            string query = String.Format("NhanVienDiDaoTao '{0}'", maDaoTao);
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public List<NhanSu> DanhSachNhanSu()
        {
            string query = String.Format("DanhSachNhanVien");
            return (from DataRow dr in DataProvider.Instance.ExecuteQuery(query).Rows
                    select new NhanSu()
                    {
                        MaNV = dr["MaNV"].ToString(),
                        HoTenNV = dr["HoTenNV"].ToString(),
                        NgaySinh = DateTime.ParseExact(dr["NgaySinh"].ToString(), "MM/dd/yyyy", null),
                        GioiTinh = dr["GioiTinh"].ToString(),
                        ChucVu = dr["ChucVu"].ToString(),
                        BoPhan = dr["BoPhan"].ToString(),
                        PhongBan = dr["TenPB"].ToString()
                    }).ToList();

        }
    }
}
