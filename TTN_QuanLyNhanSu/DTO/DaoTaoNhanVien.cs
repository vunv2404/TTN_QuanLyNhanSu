using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class DaoTaoNhanVien
    {
        private string maNV;
        private string maDaoTao;

        public DaoTaoNhanVien() { }
        public DaoTaoNhanVien(string maNV, string maDaoTao)
        {
            this.maNV = maNV;
            this.maDaoTao = maDaoTao;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string MaDaoTao { get => maDaoTao; set => maDaoTao = value; }
    }
}
