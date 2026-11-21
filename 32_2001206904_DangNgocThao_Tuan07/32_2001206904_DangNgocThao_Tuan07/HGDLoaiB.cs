using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public class HGDLoaiB:HoGiaDinh
    {
        public override double tinhSoNuoc()
        {
            int t = csm - csc - 20;
            return t > 0 ? t : 0;
        }
    }
}
