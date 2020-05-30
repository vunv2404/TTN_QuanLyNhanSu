using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN_QuanLyNhanSu.DAL;

namespace TTN_QuanLyNhanSu.BUS
{
    class NhanVienBUS
    {
        public DataTable NhanVienKyLuat(string soQuyetDinh)
        {
            string query = String.Format("NhanVienBiKyLuat '{0}'", soQuyetDinh);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
