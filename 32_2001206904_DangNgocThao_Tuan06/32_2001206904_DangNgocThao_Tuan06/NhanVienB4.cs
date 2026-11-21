using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan06
{
    public class NhanVienB4
    {
        string ma, ten;
        double hsl;
        static int luongCoBan = 1150;

        public static int LuongCoBan
        {
            get { return NhanVienB4.luongCoBan; }
            set { NhanVienB4.luongCoBan = value; }
        }
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public double HeSoLuong
        {
            get { return hsl; }
            set { hsl = value; }
        }
        public NhanVienB4()
        {
            this.ma = "NV001";
            this.ten = "Dang Ngoc Thao";
            this.hsl = 2.34;
        }
        public NhanVienB4(string ma, string ten, double heSoLuong)
        {
            if (this.ma.StartsWith("NV") == false)
                this.ma = "NV001";
            else this.ma = ma;
            this.ten = ten;
            this.hsl = heSoLuong;
        }
        public virtual double thunhap()
        {
            return (double)this.hsl * NhanVienB4.luongCoBan;
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ma: {0}\nTen: {1}\nHe so: {2}\nThu nhap: {3}", this.ma, this.ten, this.hsl, thunhap());
        }
    }
}
