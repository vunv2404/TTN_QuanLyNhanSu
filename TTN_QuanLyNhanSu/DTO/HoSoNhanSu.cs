using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class HoSoNhanSu
    {
        private string maNV;
        private string hoTenNV;
        DateTime ngaySinh;
        private string gioiTinh;
        private string chucVu;
        private string boPhan;
        private string maPhongBan;
        DateTime ngayVaoCoQuan;
        private string queQuan;
        private string email;
        private string soDienThoai;
        private string hocVi;
        private string hocHam;
        private string chungChi;
        private string chuyenMon;

        public HoSoNhanSu()
        {

        }

        public HoSoNhanSu( string maNV, string hoTenNV, DateTime ngaySinh, string gioiTinh, string chucVu,
            string boPhan, string maPhongBan, DateTime ngayVaoCoQuan, string queQuan, string email,
            string soDienThoai , string hocVi, string hocHam, string chungChi , string chuyenMon)
        {
            this.maNV = maNV;
            this.hoTenNV = hoTenNV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.chucVu = chucVu;
            this.boPhan = boPhan;
            this.maPhongBan = maPhongBan;
            this.ngayVaoCoQuan = ngayVaoCoQuan;
            this.queQuan = queQuan;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.hocVi = hocVi;
            this.hocHam = hocHam;
            this.chungChi = chungChi;
            this.chuyenMon = chuyenMon;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string BoPhan { get => boPhan; set => boPhan = value; }
        public string MaPhongBan { get => maPhongBan; set => maPhongBan = value; }
        public DateTime NgayVaoCoQuan { get => ngayVaoCoQuan; set => ngayVaoCoQuan = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string HocVi { get => hocVi; set => hocVi = value; }
        public string HocHam { get => hocHam; set => hocHam = value; }
        public string ChungChi { get => chungChi; set => chungChi = value; }
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }
    }
}
