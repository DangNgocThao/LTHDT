using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public class NhanVienSX:NhanVien
    {
        int snn;
        static double hsPhuCapNangNhoc = 0.1;
        public NhanVienSX()
            : base()
        {
            snn = 0;
        }
        public NhanVienSX(string ma, string ten, bool gioitinh, int nvl, int snn, double hsl)
            : base(ma, ten, gioitinh, nvl, hsl)
        {
            this.snn = snn;
        }
        public override char XepLoai()
        {
            if (snn <= 1) return 'A';
            if (snn <= 3) return 'A';
            if (snn <= 5) return 'A';
            return 'D';
        }
        public override double TinhLuong()
        {
            return hsl * NhanVien.LuongCoBan * (1 + NhanVienSX.hsPhuCapNangNhoc);
        }
    }
}
