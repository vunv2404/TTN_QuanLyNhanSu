using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class BoPhan
    {
        private string maBoPhan;
        private string tenBoPhan;
        private string maPhongBan;
        private string email;
        private string dienThoai;
        private string fax;

        public BoPhan() { }
        public BoPhan(string maBoPhan , string tenBoPhan, string maPhongBan, string email, string dienThoai, string fax)
        {
            this.maBoPhan = maBoPhan;
            this.tenBoPhan = tenBoPhan;
            this.maPhongBan = maPhongBan;
            this.email = email;
            this.dienThoai = dienThoai;
            this.fax = fax;
        }

        public string MaBoPhan { get => maBoPhan; set => maBoPhan = value; }
        public string TenBoPhan { get => tenBoPhan; set => tenBoPhan = value; }
        public string MaPhongBan { get => maPhongBan; set => maPhongBan = value; }
        public string Email { get => email; set => email = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Fax { get => fax; set => fax = value; }
    }
}
