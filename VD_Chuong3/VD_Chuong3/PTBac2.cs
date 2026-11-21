using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Chuong3
{
    public class PTBac2
    {
        private int a, b, c;
        public void nhap()
        {
            do
            {
                Console.Write("Nhap a: ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a == 0);
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());
        }
        public int tinhSoNghiem()
        {
            int delta = b * b - 4 * a * c;
            if (delta > 0) return 2;
            else if (delta == 0) return 1;
            else return 0;
        }
        public void xuat()
        {
            Console.WriteLine("So nghiem cua PT: {0}", tinhSoNghiem());
        }
    }
}
