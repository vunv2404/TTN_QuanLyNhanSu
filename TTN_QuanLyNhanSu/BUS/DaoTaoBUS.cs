using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN_QuanLyNhanSu.DAL;
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.BUS
{
    class DaoTaoBUS
    {
        public bool ThemDaoTao(DaoTao daoTao)
        {
            string query = string.Format("ThemDaoTao {0}, '{1}', N'{2}' , {3}, N'{4}', {5}, N'{6}'", daoTao.MaDaoTao, daoTao.NgayLap, daoTao.MucDich, daoTao.SoLuong, daoTao.NguoiPhuTrach, daoTao.ChiPhi, daoTao.TrangThai);
            return DataProvider.Instance.ExecuteNonQuery(query) >= 1;
        }

        public bool SuaDaoTao(DaoTao daoTao)
        {
            string query = string.Format("SuaDaoTao {0}, '{1}', N'{2}' ,{3}, N'{4}', {5}, N'{6}'", daoTao.MaDaoTao, daoTao.NgayLap,daoTao.MucDich, daoTao.SoLuong, daoTao.NguoiPhuTrach, daoTao.ChiPhi, daoTao.TrangThai);
            return DataProvider.Instance.ExecuteNonQuery(query) >= 1;
        }

        public bool DaoTaoNhanVien(string maNV, string maDaoTao)
        {
            try
            {
                string query = String.Format("insert into DaoTaoNhanVien(MaNV,MaDaoTao) values('{0}','{1}')", maNV, maDaoTao);
                return DataProvider.Instance.ExecuteNonQuery(query) >= 1;
            }
            catch
            {
                return false;
            }
        }
    }
}
