using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class HopDongNhanSu
    {
        private string soHopDong;
        private string maNV;
        private string hoTenNV;
        private string loaiHopDong;
        private string trangThai;
        DateTime ngayHieuLuc;
        DateTime ngayHetHan;
        private string noiDung;
        public HopDongNhanSu() { }
        public HopDongNhanSu(string soHopDong, string maNV, string hoTenNV, string loaiHopDong, string trangThai,
            DateTime ngayHieuLuc, DateTime ngayHetHan, string noiDung)
        {
            this.soHopDong = soHopDong;
            this.maNV = maNV;
            this.hoTenNV = hoTenNV;
            this.loaiHopDong = loaiHopDong;
            this.trangThai = trangThai;
            this.ngayHieuLuc = ngayHieuLuc;
            this.ngayHetHan = ngayHetHan;
            this.noiDung = noiDung;
        }

        public string SoHopDong { get => soHopDong; set => soHopDong = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string LoaiHopDong { get => loaiHopDong; set => loaiHopDong = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayHieuLuc { get => ngayHieuLuc; set => ngayHieuLuc = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
    }
}
