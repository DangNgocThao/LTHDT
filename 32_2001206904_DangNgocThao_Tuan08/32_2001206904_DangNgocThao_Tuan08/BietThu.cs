using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan08
{
    public class BietThu : BatDongSan, IPhi
    {
        public BietThu(string ma, double d, double r)
            : base(ma, d, r)
        {
        }
        public override double tinhGiaTri()
        {
            return tinhDT() * 400000;
        }
        public double PhiKinhDoanh()
        {
            return tinhDT() * 1000;
        }
    }
}
