using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class Luong
    {
        private string maNV;
        private string soQuyetDinh;
        DateTime ngayKi;
        DateTime ngayHieuLuc;
        private decimal mucLuong;
        private float heSo;
        private int tongNgayCong;
        private decimal congLamThemGio;
        private decimal phuCap;
        private decimal thueThuNhap;
        private decimal tongLuongNhan;

        public Luong() { }

        public Luong(string maNV, string soQuyetDinh, DateTime ngayKi, DateTime ngayHieuLuc, decimal mucLuong
            , float heSo, int tongNgayCong, decimal congLamThemGio, decimal phuCap, decimal thueThuNhap, decimal tongLuongNhan)
        {
            this.maNV = maNV;
            this.soQuyetDinh = soQuyetDinh;
            this.ngayKi = ngayKi;
            this.ngayHieuLuc = ngayHieuLuc;
            this.mucLuong = mucLuong;
            this.heSo = heSo;
            this.tongNgayCong = tongNgayCong;
            this.congLamThemGio = congLamThemGio;
            this.phuCap = phuCap;
            this.thueThuNhap = thueThuNhap;
            this.tongLuongNhan = tongLuongNhan;

        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string SoQuyetDinh { get => soQuyetDinh; set => soQuyetDinh = value; }
        public DateTime NgayKi { get => ngayKi; set => ngayKi = value; }
        public DateTime NgayHieuLuc { get => ngayHieuLuc; set => ngayHieuLuc = value; }
        public decimal MucLuong { get => mucLuong; set => mucLuong = value; }
        public float HeSo { get => heSo; set => heSo = value; }
        public int TongNgayCong { get => tongNgayCong; set => tongNgayCong = value; }
        public decimal CongLamThemGio { get => congLamThemGio; set => congLamThemGio = value; }
        public decimal PhuCap { get => phuCap; set => phuCap = value; }
        public decimal ThueThuNhap { get => thueThuNhap; set => thueThuNhap = value; }
        public decimal TongLuongNhan { get => tongLuongNhan; set => tongLuongNhan = value; }
    }
}
