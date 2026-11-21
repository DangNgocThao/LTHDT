using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan08
{
    public class DatTrong : BatDongSan
    {
        public DatTrong(string ma, double d, double r)
            : base(ma, d, r)
        {
        }
        public override double tinhGiaTri()
        {
            return tinhDT() * 10000;
        }
    }
}
