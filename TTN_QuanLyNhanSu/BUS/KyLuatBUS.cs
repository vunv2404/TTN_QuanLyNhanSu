using System;
using TTN_QuanLyNhanSu.DAL;
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.BUS
{
    class KyLuatBUS
    {
        public bool SuaKyLuat(KyLuat kyLuat)
        {
            string query = String.Format("SuaKyLuat '{0}', '{1}', '{2}' , N'{3}', N'{4}', N'{5}', N'{6}'",kyLuat.SoQuyetDinh,kyLuat.NgayHieuLuc.ToString("M/d/yyyy"),kyLuat.NgayHetHan.ToString("M/d/yyyy"), kyLuat.LiDo,kyLuat.NoiDung,kyLuat.HinhThuc,kyLuat.TrangThai);
            return DataProvider.Instance.ExecuteNonQuery(query) >= 1;
        }


        public bool ThemKyLuat(KyLuat kyLuat)
        {
            string query = String.Format("ThemKyLuat '{0}', '{1}', '{2}' , N'{3}', N'{4}', N'{5}', N'{6}'", kyLuat.SoQuyetDinh, kyLuat.NgayHieuLuc.ToString("M/d/yyyy"), kyLuat.NgayHetHan.ToString("M/d/yyyy"), kyLuat.LiDo, kyLuat.NoiDung, kyLuat.HinhThuc, kyLuat.TrangThai);
            return DataProvider.Instance.ExecuteNonQuery(query) >= 1;
        }

        public bool KyLuatNhanVien(string maNV, string soQuyetDinh)
        {
            try
            {
                string query = String.Format("insert into KyLuatNhanVien(MaNV,SoQuyetDinh) values('{0}','{1}')",maNV,soQuyetDinh);
                return DataProvider.Instance.ExecuteNonQuery(query) >= 1;
            }
            catch
            {
                return false;
            }
        }
    }
}
