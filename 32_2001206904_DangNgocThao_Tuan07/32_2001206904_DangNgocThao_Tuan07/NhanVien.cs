using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public abstract class NhanVien
    {
        string ma, ten;
        bool gioitinh;
        int nvl, snn;
        protected double hsl;
        protected static double LuongCoBan = 1150;
        public NhanVien()
        {
            ma = "";
            ten = "";
            gioitinh = true;
            nvl = 2000;
            hsl = 0;
        }
        public NhanVien(string ma, string ten, bool gioitinh, int nvl, double hsl)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.nvl = nvl;
            this.hsl = hsl;
        }
        public double PhuCapThamNien()
        {
            int tn = DateTime.Today.Year - nvl;
            if (tn >= 5)
                return tn * NhanVien.LuongCoBan / 100;
            return 0;
        }
        public double ThuNhap()
        {
            char xl = XepLoai();
            double hsThiDua = 0;
            if (xl == 'A') hsThiDua = 1.0;
            if (xl == 'B') hsThiDua = 0.75;
            if (xl == 'C') hsThiDua = 0.5;
            return hsThiDua * TinhLuong() + PhuCapThamNien();
        }
        public abstract char XepLoai();
        public abstract double TinhLuong();
    }
}
