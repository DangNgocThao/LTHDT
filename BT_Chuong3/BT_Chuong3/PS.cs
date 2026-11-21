using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuong3
{
    public class PS
    {
        private int t, m;
        public int T
        {
            get { return t; }
            set { t = value; }
        }
        public int M
        {
            get { return m; }
            set { m = value; }
        }
        public void nhap()
        {
            Console.Write("Nhap phan so: ");
            string so = Console.ReadLine();
            string[] splitStr = so.Split('/');
            t = Convert.ToInt32(splitStr[0]);
            m = Convert.ToInt32(splitStr[1]);
        }
        public void doiDauPS()
        {
            if (m < 0)
            {
                t *= -1;
                m *= -1;
            }
        }
        public int timUSCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0)
                return 1;
            while (a != b)
            {
                if (a >= b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
        public void rutGonPS()
        {
            int usclc = timUSCLN(t, m);
            t /= usclc;
            m /= usclc;
        }
    }
}
