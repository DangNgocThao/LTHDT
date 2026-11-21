using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan02
{
    public class HinhChuNhat
    {
        double d, r;

        public double D
        {
            get { return d; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Du lieu sai");
                }
                else d = value;
            }
        }
        public double R
        {
            get { return r; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Du lieu sai");
                }
                else r = value;
            }
        }

        public HinhChuNhat()
        {
            D = R = 0;
        }
        public HinhChuNhat(double a, double b)
        {
            D = a;
            R = b;
        }
        public HinhChuNhat(HinhChuNhat a)
        {
            D = a.D;
            R = a.R;
        }
        public double tinhCV()
        {
            return (D + R) * 2;
        }
        public double tinhDT()
        {
            return D * R;
        }
        public double tinhDC()
        {
            return Math.Sqrt(Math.Pow(D, 2) + Math.Pow(R, 2));
        }
        public void changeSize(double x, double y, int kieu)
        {
            if (kieu == 1)
            {
                D += x;
                R += y;
            }
            else
            {
                D -= x;
                R -= y;
            }
        }
        public void changeSize(HinhChuNhat a, int kieu)
        {
            if (kieu == 1)
            {
                D += a.D;
                R += a.R;
            }
            else
            {
                D -= a.D;
                R -= a.R;
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Dai: {0}.Rong: {1}", D, R);
            Console.WriteLine("DienTich:{0} .ChuVi:{1} .DuongCheo:{2:0.00}", tinhDT(), tinhCV(), tinhDC());
        }
    }
}
