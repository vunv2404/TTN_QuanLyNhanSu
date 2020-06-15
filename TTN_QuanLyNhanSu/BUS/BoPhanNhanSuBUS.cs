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
    class BoPhanNhanSuBUS
    {
        public bool TaoBoPhanNS(BoPhan bophan)
        {
            string query = string.Format("exec PROC_TaoBoPhanNS '{0}', N'{1}', '{2}', '{3}', '{4}', '{5}' ", bophan.MaBoPhan, bophan.TenBoPhan, bophan.MaPhongBan, bophan.Email, bophan.DienThoai, bophan.Fax);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool SuaPhongBoPhanNS(BoPhan bophan)
        {
            string query = string.Format("exec PROC_SuaPhongBoPhanNS '{0}', N'{1}', '{2}', '{3}', '{4}', '{5}' ", bophan.MaBoPhan, bophan.TenBoPhan, bophan.MaPhongBan, bophan.Email, bophan.DienThoai, bophan.Fax);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public List<BoPhan> XemTatCaBoPhanNS()
        {
            string query = string.Format("exec PROC_XemTatCaBoPhanNS ");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
           new BoPhan(m.Field<string>("MaBoPhan"), m.Field<string>("TenBoPhan"), m.Field<string>("MaPhongBan"), m.Field<string>("Email"), m.Field<string>("DienThoai"), m.Field<string>("Fax"))).ToList();
        }

        public BoPhan XemChiTietBoPhanNS(string mabophan)
        {
            string query = string.Format("exec PROC_XemChiTietBoPhanNS '{0}' ", mabophan);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            BoPhan bophan = new BoPhan();


            bophan.MaBoPhan = dt.Rows[0]["MaBoPhan"].ToString();
            bophan.TenBoPhan = dt.Rows[0]["TenBoPhan"].ToString();
            bophan.MaPhongBan = dt.Rows[0]["MaPhongBan"].ToString();
            bophan.Email = dt.Rows[0]["Email"].ToString();
            bophan.DienThoai = dt.Rows[0]["DienThoai"].ToString();
            bophan.Fax = dt.Rows[0]["Fax"].ToString();

            return bophan;
        }

        public List<BoPhan> TimKiemTenPB(string keyword)
        {
            string query = string.Format("select BoPhan.* from BoPhan join PhongBan on BoPhan.MaPhongban = PhongBan.MaPhongBan where PhongBan.TenPB like N'%" + keyword + "%'");

            return DataProvider.Instance.ExecuteQuery(query).AsEnumerable().Select(m =>
           new BoPhan(m.Field<string>("MaBoPhan"), m.Field<string>("TenBoPhan"), m.Field<string>("MaPhongBan"), m.Field<string>("Email"), m.Field<string>("DienThoai"), m.Field<string>("Fax"))).ToList();
        }
        public DataTable LayTenPB(string maPB)
        {
            string query = string.Format("select TenPB from PhongBan where MaPhongBan = '" + maPB + "' ");

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
