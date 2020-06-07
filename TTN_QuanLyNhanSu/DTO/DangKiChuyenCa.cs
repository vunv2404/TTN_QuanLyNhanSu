using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class DangKiChuyenCa
    {
        private string ma;
        private string maNV;
        private string hoTenNV;
        private string caCu;
        private string caMoi;
        DateTime tuNgay;
        DateTime denNgay;
        private string liDo;
        private string trangThai;

        public DangKiChuyenCa() { }
        public DangKiChuyenCa(string ma,string maNV, string hoTenNV, string caCu, string caMoi, DateTime tuNgay,
            DateTime denNgay, string liDo, string trangThai)
        {
            this.ma = ma;
            this.maNV = maNV;
            this.hoTenNV = hoTenNV;
            this.caCu = caCu;
            this.caMoi = caMoi;
            this.tuNgay = tuNgay;
            this.denNgay = denNgay;
            this.liDo = liDo;
            this.trangThai = trangThai;
        }
        public string Ma { get => ma; set => ma = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string CaCu { get => caCu; set => caCu = value; }
        public string CaMoi { get => caMoi; set => caMoi = value; }
        public DateTime TuNgay { get => tuNgay; set => tuNgay = value; }
        public DateTime DenNgay { get => denNgay; set => denNgay = value; }
        public string LiDo { get => liDo; set => liDo = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
