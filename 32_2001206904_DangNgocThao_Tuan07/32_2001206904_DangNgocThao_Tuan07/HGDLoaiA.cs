using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public class HGDLoaiA:HoGiaDinh
    {
        int snk;
        public HGDLoaiA()
            : base()
        {
            snk = 0;
        }
        public HGDLoaiA(string ten, string diachi, int csm, int csc, int snk)
            : base(ten, diachi, csm, csc)
        {
            this.snk = snk;
        }
        public override double tinhSoNuoc()
        {
            int t = (csm - csc) - 5 * snk;
            return t > 0 ? t : 0;
        }
    }
}
