using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class DangKiLamThem
    {
        private string maNV;
        private string hoTenNV;
        DateTime tuNgay;
        DateTime denNgay;
        private decimal luongTangCa;
        private int soGio;
        private string trangThai;

        public DangKiLamThem() { }
        public DangKiLamThem(string maNV, string hoTenNV, DateTime tuNgay, DateTime denNgay, decimal luongTangCa,
            int soGio, string trangThai) 
        {
            this.maNV = maNV;
            this.hoTenNV = hoTenNV;
            this.tuNgay = tuNgay;
            this.denNgay = denNgay;
            this.luongTangCa = luongTangCa;
            this.soGio = soGio;
            this.trangThai = trangThai;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public DateTime TuNgay { get => tuNgay; set => tuNgay = value; }
        public DateTime DenNgay { get => denNgay; set => denNgay = value; }
        public decimal LuongTangCa { get => luongTangCa; set => luongTangCa = value; }
        public int SoGio { get => soGio; set => soGio = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
