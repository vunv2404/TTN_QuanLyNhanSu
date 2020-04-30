using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class KyLuatNhanVien
    {
        private string maNV;
        private string soQuyetDinh;

        public KyLuatNhanVien() { }
        public KyLuatNhanVien(string maNV, string soQuyetDinh)
        {
            this.maNV = maNV;
            this.soQuyetDinh = soQuyetDinh;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string SoQuyetDinh { get => soQuyetDinh; set => soQuyetDinh = value; }
    }
}
