using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    public class KyLuat
    {
        private string soQuyetDinh;
        DateTime ngayHieuLuc;
        DateTime ngayHetHan;
        private string liDo;
        private string noiDung;
        private string hinhThuc;
        private string trangThai;
        public KyLuat() { }
        public KyLuat(string soQuyetDinh, DateTime ngayHieuLuc, DateTime ngayHetHan, string liDo,
            string noiDung, string hinhThuc, string trangThai)
        {
            this.soQuyetDinh = soQuyetDinh;
            this.ngayHieuLuc = ngayHieuLuc;
            this.ngayHetHan = ngayHetHan;
            this.liDo = liDo;
            this.noiDung = noiDung;
            this.hinhThuc = hinhThuc;
            this.trangThai = trangThai;
        }

        public string SoQuyetDinh { get => soQuyetDinh; set => soQuyetDinh = value; }
        public DateTime NgayHieuLuc { get => ngayHieuLuc; set => ngayHieuLuc = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public string LiDo { get => liDo; set => liDo = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string HinhThuc { get => hinhThuc; set => hinhThuc = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
