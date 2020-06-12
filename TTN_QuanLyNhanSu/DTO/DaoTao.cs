using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    public class DaoTao
    {
        private string maDaoTao;
        DateTime ngayLap;
        private string mucDich;
        private int soLuong;
        private string nguoiPhuTrach;
        private decimal chiPhi;
        private string trangThai;

        public DaoTao() { }

        public DaoTao(string maDaoTao, DateTime ngayLap, string mucDich, int soLuong, string nguoiPhuTrach,
            decimal chiPhi, string trangThai) 
        {
            this.maDaoTao = maDaoTao;
            this.ngayLap = ngayLap;
            this.mucDich = mucDich;
            this.soLuong = soLuong;
            this.nguoiPhuTrach = nguoiPhuTrach;
            this.chiPhi = chiPhi;
            this.trangThai = trangThai;

        }

        public string MaDaoTao { get => maDaoTao; set => maDaoTao = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MucDich { get => mucDich; set => mucDich = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string NguoiPhuTrach { get => nguoiPhuTrach; set => nguoiPhuTrach = value; }
        public decimal ChiPhi { get => chiPhi; set => chiPhi = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }

    

}
