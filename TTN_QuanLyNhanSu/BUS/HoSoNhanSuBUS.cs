using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTN_QuanLyNhanSu.DAL;
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.BUS
{
    class HoSoNhanSuBUS
    {
        public bool ThemNhanSu(HoSoNhanSu nhanSu)
        {
            string query = string.Format("PROC_THEMNHANVIEN '{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', '{6}', '{7}', {8}, N'{9}', '{10}', '{11}', N'{12}', N'{13}', N'{14}', N'{15}' ",
                nhanSu.MaNV, nhanSu.HoTenNV, nhanSu.NgaySinh, nhanSu.GioiTinh, nhanSu.ChucVu, nhanSu.BoPhan,nhanSu.MaPhongBan, nhanSu.NgayVaoCoQuan, 0,nhanSu.QueQuan ,nhanSu.Email, nhanSu.SoDienThoai,nhanSu.HocVi,nhanSu.HocHam,nhanSu.ChungChi,nhanSu.ChuyenMon);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool ThemNhanSu(HoSoNhanSu nhanSu, byte[] img)
        {
            string query = string.Format("PROC_THEMNHANVIEN '{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', '{6}', '{7}', @AnhDaiDien, N'{8}', '{9}', '{10}', N'{11}', N'{12}', N'{13}', N'{14}' ",
                nhanSu.MaNV, nhanSu.HoTenNV, nhanSu.NgaySinh, nhanSu.GioiTinh, nhanSu.ChucVu, nhanSu.BoPhan, nhanSu.MaPhongBan, nhanSu.NgayVaoCoQuan, nhanSu.QueQuan, nhanSu.Email, nhanSu.SoDienThoai, nhanSu.HocVi, nhanSu.HocHam, nhanSu.ChungChi, nhanSu.ChuyenMon);
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@AnhDaiDien", img);
            return DataProvider.Instance.ExecuteNonQuery(command) > 0;
        }


        public bool SuaNhanSu(HoSoNhanSu nhanSu)
        {
            string query = string.Format("PROC_SUANHANVIEN '{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', '{6}', '{7}', {8}, N'{9}', '{10}', '{11}', N'{12}', N'{13}', N'{14}', N'{15}' ",
                nhanSu.MaNV, nhanSu.HoTenNV, nhanSu.NgaySinh, nhanSu.GioiTinh, nhanSu.ChucVu, nhanSu.BoPhan, nhanSu.MaPhongBan, nhanSu.NgayVaoCoQuan, 0, nhanSu.QueQuan, nhanSu.Email, nhanSu.SoDienThoai, nhanSu.HocVi, nhanSu.HocHam, nhanSu.ChungChi, nhanSu.ChuyenMon);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool SuaNhanSu(HoSoNhanSu nhanSu, byte[] img)
        {
            string query = string.Format("PROC_SUANHANVIEN '{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', '{6}', '{7}', @AnhDaiDien, N'{8}', '{9}', '{10}', N'{11}', N'{12}', N'{13}', N'{14}' ",
                nhanSu.MaNV, nhanSu.HoTenNV, nhanSu.NgaySinh, nhanSu.GioiTinh, nhanSu.ChucVu, nhanSu.BoPhan, nhanSu.MaPhongBan, nhanSu.NgayVaoCoQuan, nhanSu.QueQuan, nhanSu.Email, nhanSu.SoDienThoai, nhanSu.HocVi, nhanSu.HocHam, nhanSu.ChungChi, nhanSu.ChuyenMon);
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@AnhDaiDien", img);
            return DataProvider.Instance.ExecuteNonQuery(command) > 0;
        }


        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch (Exception ex)
            {
                Bitmap bmp = new Bitmap(150, 195);
                using (Graphics graph = Graphics.FromImage(bmp))
                {
                    Rectangle ImageSize = new Rectangle(0, 0, 150, 195);
                    graph.FillRectangle(Brushes.White, ImageSize);
                }
                return bmp;
            }
        }

        public Image XemAnhNhanVien(string maNV)
        {
            string query = string.Format("PROC_XEMANHNHANVIEN '{0}' ", maNV);
            DataTable obj = DataProvider.Instance.ExecuteQuery(query);
            DataRow row = obj.Rows[0];
            try
            {
                byte[] img = (byte[])row[0];
                return byteArrayToImage(img);
            }
            catch
            {
                return byteArrayToImage(new byte[1]);
            }
        }

        public string GetTenPhongNhanVien(string maPB)
        {
            string query = "select TenPB" +
                " from PhongBan " +
                "where " +
                $"MaPhongBan = '{maPB}'";

            return DataProvider.Instance.ExecuteScalar(query).ToString();

        }

        public string GetMaPhongNhanVien(string tenPB)
        {
            string query = "select MaPhongBan" +
                " from PhongBan " +
                "where " +
                $"TenPB = N'{tenPB}'";

            return DataProvider.Instance.ExecuteScalar(query).ToString();

        }

        public DataTable NhanSuKyLuat(string SoQuyetDinh)
        {
            string query = string.Format("NhanVienBiKyLuat '{0}'", SoQuyetDinh);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
