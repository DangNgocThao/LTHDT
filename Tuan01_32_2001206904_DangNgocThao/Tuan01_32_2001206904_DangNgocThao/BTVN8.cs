using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_32_2001206904_DangNgocThao
{
    public class BTVN8
    {
        int scp;
        public bool ktSCP()
        {
            double a = Math.Sqrt((double)this.scp);
            if (a - (int)a == 0)
                return true;
            else
                return false;
        }
        public void nhap()
        {
            do
            {
                Console.Write("Nhap so chinh phuong: ");
                scp = Convert.ToInt32(Console.ReadLine());
            } while (!ktSCP());
        }
        public void xuat()
        {
            Console.WriteLine("So chinh phuong vua nhap: {0}", scp);
        }
    }
}
