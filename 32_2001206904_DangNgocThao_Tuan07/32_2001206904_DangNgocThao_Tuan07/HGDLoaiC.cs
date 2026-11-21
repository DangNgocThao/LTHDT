using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public class HGDLoaiC:HoGiaDinh
    {
        int nkpvct;
        public HGDLoaiC()
            : base()
        {
            nkpvct = 0;
        }
        public HGDLoaiC(string ten, string diachi, int csm, int csc, int nkpvct)
            : base(ten, diachi, csm, csc)
        {
            this.nkpvct = nkpvct;
        }
        public override double tinhSoNuoc()
        {
            int t = (csm - csc) - nkpvct * 10;
            return t > 0 ? t : 0;
        }
    }
}
