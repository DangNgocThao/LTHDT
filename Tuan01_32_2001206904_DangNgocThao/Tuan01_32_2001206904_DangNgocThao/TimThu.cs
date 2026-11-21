using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_32_2001206904_DangNgocThao
{
    public class TimThu
    {
        private int d, m, y;
        public TimThu(int d, int m, int y)
        {
            this.d = d;
            this.m = m;
            this.y = y;
        }
        public void xuat()
        {
            if(m < 3)
            {
                this.m = this.m + 12;
                this.y = this.y - 1;
            }
            int n = (this.d + 2 * this.m + (3 * (this.m + 1)) / 5 + this.y + (this.y / 4)) % 7;
            if (n == 0)
                Console.WriteLine("Ngay {0:00}/{1:00}/{2} la chu nhat", d, m, y);
            else
                Console.WriteLine("Ngay {0:00}/{1:00}/{2} la thu {3}", d, m, y, n + 1);
        }
    }
}
