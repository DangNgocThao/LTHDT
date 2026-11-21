using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_32_2001206904_DangNgocThao
{
    public class PhuongTrinhBac2
    {
        private int a, b, c;

        public PhuongTrinhBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void giai()
        {
            if (a == 0)
            {
                PhuongTrinhBac1 ptb1 = new PhuongTrinhBac1(b, c);
                ptb1.giai();
            }
            else
            {
                float delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("PT Vo Nghiem");
                else
                    if (delta == 0)
                        Console.WriteLine("PT Co 1 Nghiem Kep = {0}", -this.b / 2 * this.a);
                    else
                        Console.WriteLine("PT Co 2 Nghiem Phan Biet: x1 = {0,00}, x2 = {1,00}", (-this.b + Math.Sqrt(delta)) / (2 * this.a), (-this.b - Math.Sqrt(delta)) / (2 * this.a));
            }
        }
        public void xuat()
        {
            Console.WriteLine("{0}X^2+{1}X+{2}=0", a, b,c);
        }
    }
}
