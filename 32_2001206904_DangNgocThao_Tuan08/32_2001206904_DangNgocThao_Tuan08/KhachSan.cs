using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan08
{
    public class KhachSan : BatDongSan, IPhi
    {
        int soSao;
        public KhachSan(string ma, double d, double r, int soSao)
            : base(ma, d, r)
        {
            this.soSao = soSao;
        }
        public override double tinhGiaTri()
        {
            return 100000 + soSao * 50000;
        }
        public double PhiKinhDoanh()
        {
            return r * 5000;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So sao: {0}", soSao);
        }
    }
}
