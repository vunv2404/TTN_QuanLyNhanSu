using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QuanLyNhanSu.DTO
{
    class BaoHiem
    {
        private string maNV;
        private string hoTenNV;
        private string soBaoHiemXH;
        private string soBaoHiemYT;
        private string noiCap;
        DateTime ngayCap;

        public BaoHiem() { }

        public BaoHiem(string maNV, string hoTenNV, string soBaoHiemXH, string soBaoHiemYT, string noiCap, DateTime ngayCap)
        {
            this.maNV = maNV;
            this.hoTenNV = hoTenNV;
            this.soBaoHiemXH = soBaoHiemXH;
            this.soBaoHiemYT = soBaoHiemYT;
            this.noiCap = noiCap;
            this.ngayCap = ngayCap;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string SoBaoHiemXH { get => soBaoHiemXH; set => soBaoHiemXH = value; }
        public string SoBaoHiemYT { get => soBaoHiemYT; set => soBaoHiemYT = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
    }
}
