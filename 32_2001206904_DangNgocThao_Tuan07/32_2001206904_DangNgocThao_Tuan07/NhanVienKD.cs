using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public class NhanVienKD:NhanVien
    {
        double doanhthuTT, doanhthu;
        public NhanVienKD()
            : base()
        {
            doanhthuTT = 0;
            doanhthu = 0;
        }
        public NhanVienKD(string ma, string ten, bool gioitinh, int nvl, double hsl, double doanhthuTT, double doanhthu)
            : base(ma, ten, gioitinh, nvl, hsl)
        {
            this.doanhthuTT = doanhthuTT;
            this.doanhthu = doanhthu;
        }
        public override char XepLoai()
        {
            if (doanhthu < 0.5 * doanhthuTT) return 'D';
            if (doanhthu < doanhthuTT) return 'C';
            if (doanhthu < 2 * doanhthuTT) return 'B';
            return 'A';
        }
        public override double TinhLuong()
        {
            return hsl * NhanVien.LuongCoBan + HoaHong();
        }
        public double HoaHong()
        {
            char xl = XepLoai();
            double vuot = doanhthu - doanhthuTT;
            if (vuot > 0) return 0.15 * vuot;
            return 0;
        }
    }
}
