using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan08
{
    public abstract class BatDongSan
    {
        protected string ma;
        protected double d, r;
        public BatDongSan(string ma, double d, double r)
        {
            this.ma = ma;
            this.d = d;
            this.r = r;
        }
        public double tinhDT()
        {
            return d * r;
        }
        public abstract double tinhGiaTri();
        public virtual void xuat()
        {
            Console.WriteLine("Ma: {0}", ma);
            Console.WriteLine("Chieu dai: {0}", d);
            Console.WriteLine("Chieu rong: {0}", r);
        }
    }
}
