using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public class MonLyThuyet:MonHoc
    {
        double dtl, dgk, dck;
        static double hsTL = 0.2, hsGK = 0.3, hsCK = 0.5;
        public MonLyThuyet(string ma, string ten, int soTC) : base(ma, ten, soTC)
        {
        }
        public override int tinhHP()
        {
            return 250000 * soTC;
        }
        public override double tinhDiem()
        {
            return dtl * hsTL + dgk * hsGK + dck * hsCK;
        }
    }
}
