using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_32_2001206904_DangNgocThao
{
    public class ThuaSoNT
    {
        int n;
        public void Nhap()
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
        }
        public int KTSoNT(int a)
        {
            if (a == 1 || a == 0)
                return 0;
            int dem = 0;
            for (int i = 1; i <= a; i++)
                if (a % i == 0)
                    dem += 1;
            if (dem == 2)
                return 1;
            return 0;
        }
        public void PhanTichTS()
        {
            int n = this.n;
            Console.Write("Phan tich Thua So Nguyen To {0} = ", n);
            for (int i = 2; n != 1; i++)
                if (KTSoNT(i) == 1)
                {
                    while (n % i == 0 && n != 1)
                    {
                        n = n / i;
                        if (n != 1)
                            Console.Write("{0}.", i);
                        else Console.Write("{0}", i);
                    }
                }
            Console.WriteLine();
            Console.WriteLine("So {0} co {1} chu so", this.n, DemSo());
        }
        public int DemSo()
        {
            int n = this.n;
            int dem = 0;
            while (n != 0)
            {
                n = n / 10;
                dem += 1;
            }
            return dem;
        }
    }
}