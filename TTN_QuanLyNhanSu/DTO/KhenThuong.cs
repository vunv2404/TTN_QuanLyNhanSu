using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class KhenThuong
    {
        private string soQuyetDinh;
        DateTime ngayHieuLuc;
        DateTime ngayHetHan;
        private string noiDung;
        private string hinhThuc;
        private decimal soTien;
        private string trangThai;

        public KhenThuong() { }
        public KhenThuong(string soQuyetDinh, DateTime ngayHieuLuc, DateTime ngayHetHan, string noiDung, 
            string hinhThuc, decimal soTien, string trangThai )
        {
            this.soQuyetDinh = soQuyetDinh;
            this.ngayHieuLuc = ngayHieuLuc;
            this.ngayHetHan = ngayHetHan;
            this.noiDung = noiDung;
            this.hinhThuc = hinhThuc;
            this.soTien = soTien;
            this.trangThai = trangThai;
        }

        public string SoQuyetDinh { get => soQuyetDinh; set => soQuyetDinh = value; }
        public DateTime NgayHieuLuc { get => ngayHieuLuc; set => ngayHieuLuc = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string HinhThuc { get => hinhThuc; set => hinhThuc = value; }
        public decimal SoTien { get => soTien; set => soTien = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
