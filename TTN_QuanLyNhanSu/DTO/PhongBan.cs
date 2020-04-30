using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class PhongBan
    {
        private string maPhongBan;
        private string tenPhongBan;
        DateTime ngayThanhLap;
        private string maTruongPhong;
        private string email;
        private string soDienThoai;
        private string fax;

        public PhongBan() { }

        public PhongBan(string maPhongBan, string tenPhongBan, DateTime ngayThanhLap, string maTruongPhong,
            string email, string soDienThoai, string fax)
        {
            this.maPhongBan = maPhongBan;
            this.tenPhongBan = tenPhongBan;
            this.ngayThanhLap = ngayThanhLap;
            this.maTruongPhong = maTruongPhong;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.fax = fax;

        }

        public string MaPhongBan { get => maPhongBan; set => maPhongBan = value; }
        public string TenPhongBan { get => tenPhongBan; set => tenPhongBan = value; }
        public DateTime NgayThanhLap { get => ngayThanhLap; set => ngayThanhLap = value; }
        public string MaTruongPhong { get => maTruongPhong; set => maTruongPhong = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Fax { get => fax; set => fax = value; }
    }
}
