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
    class BaoHiemBUS
    {
        //---------------Trung--------------------------//
        public List<BaoHiem> ConvertToListBaoHiem(DataTable dt)
        {
            
            List<BaoHiem> lbh = new List<BaoHiem>();
            lbh = (from DataRow dr in dt.Rows
                    select new BaoHiem()
                   {
                       MaNV = dr["MaNV"].ToString(),
                       HoTenNV = dr["HoTenNV"].ToString(),
                       SoBaoHiemXH = dr["SoBaoHiemXH"].ToString(),
                       SoBaoHiemYT = dr["SoBaoHiemYT"].ToString(),
                       NoiCap = dr["NoiCap"].ToString(),
                       NgayCap = Convert.ToDateTime(dr["NgayCap"].ToString())

                   }).ToList();
            return lbh;
        }
        public List<BaoHiem> Show_All_BaoHiem()
        {
            return ConvertToListBaoHiem(DataProvider.Instance.ExecuteQuery("" +
                "select * " +
                "from BaoHiem"));
        }
        public List<BaoHiem> Show_1_ChiTietBaoHiem(string MaNV)
        {
            return ConvertToListBaoHiem(DataProvider.Instance.ExecuteQuery("" +
                "select * " +
                "from BaoHiem " +
                $"where MaNV = N'{MaNV}'"));
        }
        public List<BaoHiem> Search_MaNV(string MaNV)
        {
            return ConvertToListBaoHiem(DataProvider.Instance.ExecuteQuery("" +
                "select * " +
                "from BaoHiem " +
                $"where MaNV like N'%{MaNV}%'"));
        }
        public void ChuanHoaThongTin(BaoHiem baoHiem)
        {
            baoHiem.NoiCap = baoHiem.NoiCap.Trim();
            while (baoHiem.NoiCap.Contains("  ") == true)
            {
                baoHiem.NoiCap = baoHiem.NoiCap.Replace("  ", " ");
            }
            baoHiem.NoiCap = baoHiem.NoiCap.ToLower();
            List<string> ls = baoHiem.NoiCap.Split(' ').ToList<string>();
            baoHiem.NoiCap = "";
                for (int i = 0; i < ls.Count; i++)
                {
                    int temp = (int)ls[i][0];
                    temp = temp - 32;
                    ls[i] = ls[i].Remove(0, 1);
                    ls[i] = ((char)temp).ToString() + ls[i];
                }
                foreach (string s in ls)
                {
                    baoHiem.NoiCap = baoHiem.NoiCap + s + " ";
                }
            baoHiem.NoiCap = baoHiem.NoiCap.Trim();

            baoHiem.SoBaoHiemXH = baoHiem.SoBaoHiemXH.ToUpper();
            baoHiem.SoBaoHiemYT = baoHiem.SoBaoHiemYT.ToUpper();

        }
        public void Insert_1_BaoHiem(BaoHiem baoHiem)
        {
            //ChuanHoaThongTin(baoHiem);
            DataProvider.Instance.ExecuteNonQuery("" +
                "insert into BaoHiem(MaNV,HoTenNV,SoBaoHiemXH,SoBaoHiemYT,NoiCap,NgayCap) " +
                $"values('{baoHiem.MaNV}',N'{baoHiem.HoTenNV}','{baoHiem.SoBaoHiemXH}'," +
                $"'{baoHiem.SoBaoHiemYT}',N'{baoHiem.NoiCap}','{baoHiem.NgayCap.Month}/{baoHiem.NgayCap.Day}/{baoHiem.NgayCap.Year}')");
        }
        public void Modify_1_BaoHiem(BaoHiem baoHiem)
        {
            //ChuanHoaThongTin(baoHiem);
            DataProvider.Instance.ExecuteNonQuery("" +
                "update BaoHiem " +
                $"set SoBaoHiemXH = N'{baoHiem.SoBaoHiemXH}'," +
                $"SoBaoHiemYT = N'{baoHiem.SoBaoHiemYT}'," +
                $"NoiCap = N'{baoHiem.NoiCap}'," +
                $"NgayCap = '{baoHiem.NgayCap.Month}/{baoHiem.NgayCap.Day}/{baoHiem.NgayCap.Year}'" +
                $"where MaNV = {baoHiem.MaNV}");
        }
        public List<BaoHiem> Search_TenNV(string TenNV)
        {
            if (TenNV.Contains(" ") == true)
            {
                List<string> listTenNV = TenNV.Split(' ').ToList();
                List<BaoHiem> listBaoHiem1 = new List<BaoHiem>();
                List<BaoHiem> listBaoHiem2 = new List<BaoHiem>();
                List<BaoHiem> listBaoHiem = new List<BaoHiem>();
                for (int i = 0; i < listTenNV.Count; i++)
                {
                    if (i == 0)
                    {
                        listBaoHiem1 = ConvertToListBaoHiem(DataProvider.Instance.ExecuteQuery("" +
                            "select * " +
                            "from BaoHiem " +
                            $"where HoTenNV like N'%{listTenNV[i]}%'"));
                    }
                    else
                    {
                        listBaoHiem2 = ConvertToListBaoHiem(DataProvider.Instance.ExecuteQuery("" +
                            "select * " +
                            "from BaoHiem " +
                            $"where HoTenNV like N'%{listTenNV[i]}%'"));
                        foreach (BaoHiem bh in listBaoHiem1)
                        {
                            if (listBaoHiem2.Find(x => x.MaNV == bh.MaNV) != null)
                                listBaoHiem.Add(bh);
                        }
                        listBaoHiem1 = listBaoHiem;
                        listBaoHiem = new List<BaoHiem>();
                    }
                }
                return listBaoHiem1;
            }
            else
                return ConvertToListBaoHiem(DataProvider.Instance.ExecuteQuery("" +
                            "select * " +
                            "from BaoHiem " +
                            $"where HoTenNV like N'%{TenNV}%'"));
        }
        public DataTable DT_NhanVienKoCoBaoHiem()
        {
            return DataProvider.Instance.ExecuteQuery("" +
                "select MaNV " +
                "from HoSoNhanSu " +
                "where MaNV not in " +
                "(select MaNV from BaoHiem)");
        }
        
        //---------------Trung--------------------------//
    }
}
