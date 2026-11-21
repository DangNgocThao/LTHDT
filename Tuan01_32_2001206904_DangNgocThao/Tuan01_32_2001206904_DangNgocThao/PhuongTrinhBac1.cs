using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_32_2001206904_DangNgocThao
{
    public class PhuongTrinhBac1
    {
        private int a, b;
        public PhuongTrinhBac1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void giai()
        {
            if (this.a == 0 && this.b == 0)
                Console.WriteLine("PT Vo So Nghiem");
            else
                if (this.a == 0 && this.b != 0)
                    Console.WriteLine("PT Vo Nghiem");
                else
                    Console.WriteLine("PT Co 1 Nghiem = {0}", (float)-this.b / this.a);
        }
        public void xuat()
        {
            Console.WriteLine("{0}X+{1}=0", a, b);
        }
        ~PhuongTrinhBac1()
        {
            Console.WriteLine("Da huy doi tuong pt {0}X+{1}=0", a, b);
        }
    }
}
