using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class DangKiNghi
    {
        private string maNV;
        private string hoTenNV;
        DateTime tuNgay;
        DateTime denNgay;
        private string liDo;
        private string trangThai;

        public DangKiNghi() { }

        public DangKiNghi(string maNV, string hoTenNV, DateTime tuNgay, DateTime denNgay, string liDo, string trangThai)
        {
            this.maNV = maNV;
            this.hoTenNV = hoTenNV;
            this.tuNgay = tuNgay;
            this.denNgay = denNgay;
            this.liDo = liDo;
            this.trangThai = trangThai;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public DateTime TuNgay { get => tuNgay; set => tuNgay = value; }
        public DateTime DenNgay { get => denNgay; set => denNgay = value; }
        public string LiDo { get => liDo; set => liDo = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
