using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan08
{
    public class NhaO : BatDongSan
    {
        int soLau;
        public NhaO(string ma, double d, double r, int soLau)
            : base(ma, d, r)
        {
            this.soLau = soLau;
        }
        public override double tinhGiaTri()
        {
            return tinhDT() * 10000 + soLau * 100000;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So lau: {0}", soLau);
        }
    }
}
