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
    class PhongBanBUS
    {
        public bool TaoPhongBan(PhongBan phongban)
        {
            string query = string.Format("exec PROC_TaoPhongBan '{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}' ", phongban.MaPhongBan, phongban.TenPB, phongban.NgayThanhLap, phongban.MaTruongPhong, phongban.Email, phongban.SoDienThoai, phongban.Fax);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool SuaPhongBan(PhongBan phongban)
        {
            string query = string.Format("exec PROC_SuaPhongBan '{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}' ", phongban.MaPhongBan, phongban.TenPB, phongban.NgayThanhLap, phongban.MaTruongPhong, phongban.Email, phongban.SoDienThoai, phongban.Fax);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public List<PhongBan> XemTatCaPB()
        {
            string query = string.Format("exec PROC_XemTatCaPB ");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
           new PhongBan(m.Field<string>("MaPhongBan"), m.Field<string>("TenPB"), m.Field<DateTime>("NgayThanhLap"), m.Field<string>("MaTruongPhong"), m.Field<string>("Email"), m.Field<string>("SoDienThoai"), m.Field<string>("Fax"))).ToList();
        }

        public PhongBan XemChiTietPB(string maphongban)
        {
            string query = string.Format("exec PROC_XemChiTietPB '{0}' ", maphongban);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            PhongBan phongban = new PhongBan();


            phongban.MaPhongBan = dt.Rows[0]["MaPhongBan"].ToString();
            phongban.TenPB = dt.Rows[0]["TenPB"].ToString();
            phongban.NgayThanhLap = DateTime.Parse(dt.Rows[0]["NgayThanhLap"].ToString());
            phongban.MaTruongPhong = dt.Rows[0]["MaTruongPhong"].ToString();
            phongban.Email = dt.Rows[0]["Email"].ToString();
            phongban.SoDienThoai = dt.Rows[0]["SoDienThoai"].ToString();
            phongban.Fax = dt.Rows[0]["Fax"].ToString();

            return phongban;
        }

        public DataTable XemTatCaTruongPhong()
        {
            string query = string.Format("exec PROC_XemTatCaTruongPhong ");

            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
