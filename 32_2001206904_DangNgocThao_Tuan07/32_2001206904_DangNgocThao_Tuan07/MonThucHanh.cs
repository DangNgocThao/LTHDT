using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public class MonThucHanh:MonHoc
    {
        double d1, d2, d3, d4;
        public MonThucHanh(string ma, string ten, int soTC) : base(ma, ten, soTC)
        {
        }
        public override int tinhHP()
        {
            return 350000 * soTC + 100000;
        }
        public override double tinhDiem()
        {
            return (double)(d1 + d2 + d3 + d4) / 4.0;
        }
    }
}
