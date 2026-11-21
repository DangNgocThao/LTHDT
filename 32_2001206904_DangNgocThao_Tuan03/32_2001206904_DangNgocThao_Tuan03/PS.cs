using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan03
{
    public class PS
    {
        int t, m;

        public int T { get => t; set => t = value; }
        public int M
        {
            get { return m; }
            set
            {
                if (value == 0)
                    Console.WriteLine("Du lieu sai");
                else m = value;
            }
        }

        public PS()
        {
            T = M = 1;
        }
        public PS(int tu, int mau)
        {
            this.T = tu;
            this.M = mau;
        }
        public PS(PS a)
        {
            this.T = a.T;
            this.M = a.M;
        }
        public void nhap()
        {
            Console.Write("Nhap phan so: ");
            string so = Console.ReadLine();
            string[] splitStr = so.Split('/');
            t = Convert.ToInt32(splitStr[0]);
            m = Convert.ToInt32(splitStr[1]);
        }
        public void xuat()
        {
            Console.WriteLine("Phan so: {0}/{1}", this.t, this.m);
        }
        public static void doiDauPS(ref PS a)
        {
            if (a.m < 0)
            {
                a.t *= -1;
                a.m *= -1;
            }
        }
        public static int timUSCLN(int a, int b)
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
        public static void rutGonPS(ref PS a)
        {
            int usclc = timUSCLN(a.t, a.m);
            a.t /= usclc;
            a.m /= usclc;
        }
        public PS congPS(PS a)
        {
            PS kq = new PS();
            kq.t = this.t * a.m + this.m * a.t;
            kq.m = this.m * a.m;
            doiDauPS(ref kq);
            rutGonPS(ref kq);
            return kq;
        }
        public PS truPS(PS a)
        {
            PS kq = new PS();
            kq.t = this.t * a.m - this.m * a.t;
            kq.m = this.m * a.m;
            doiDauPS(ref kq);
            rutGonPS(ref kq);
            return kq;
        }
        public PS nhanPS(PS a)
        {
            PS kq = new PS();
            kq.t = this.t * a.t;
            kq.m = this.m * a.m;
            doiDauPS(ref kq);
            rutGonPS(ref kq);
            return kq;
        }
        public PS chiaPS(PS a)
        {
            PS kq = new PS();
            kq.t = this.t * a.m;
            kq.m = this.m * a.t;
            doiDauPS(ref kq);
            rutGonPS(ref kq);
            return kq;
        }
        public static PS operator +(PS a, PS b)
        {
            PS kq = new PS();
            kq.t = a.t * b.m + a.m * b.t;
            kq.m = a.m * b.m;
            doiDauPS(ref kq);
            rutGonPS(ref kq);
            return kq;
        }
        public static PS operator -(PS a, PS b)
        {
            PS kq = new PS();
            kq.t = a.t * b.m - a.m * b.t;
            kq.m = a.m * b.m;
            doiDauPS(ref kq);
            rutGonPS(ref kq);
            return kq;
        }
        public static PS operator *(PS a, PS b)
        {
            PS kq = new PS();
            kq.t = a.t * b.t;
            kq.m = a.m * b.m;
            doiDauPS(ref kq);
            rutGonPS(ref kq);
            return kq;
        }
        public static PS operator /(PS a, PS b)
        {
            PS kq = new PS();
            kq.t = a.t * b.m;
            kq.m = a.m * b.t;
            doiDauPS(ref kq);
            rutGonPS(ref kq);
            return kq;
        }
        public static double tinhGiaTri(PS a)
        {
            return a.t / a.m;
        }
        public static bool operator >(PS a, PS b)
        {
            return tinhGiaTri(a) > tinhGiaTri(b);
        }
        public static bool operator <(PS a, PS b)
        {
            return tinhGiaTri(a) < tinhGiaTri(b);
        }
        public static bool operator >=(PS a, PS b)
        {
            return tinhGiaTri(a) >= tinhGiaTri(b);
        }
        public static bool operator <=(PS a, PS b)
        {
            return tinhGiaTri(a) <= tinhGiaTri(b);
        }
        public static bool operator ==(PS a, PS b)
        {
            return tinhGiaTri(a) == tinhGiaTri(b);
        }
        public static bool operator !=(PS a, PS b)
        {
            return tinhGiaTri(a) != tinhGiaTri(b);
        }
        public static PS operator ++(PS a)
        {
            PS kq = new PS();
            kq.t = a.t + a.m;
            kq.m = a.m;
            doiDauPS(ref kq);
            rutGonPS(ref kq);
            return kq;
        }
        public static PS operator --(PS a)
        {
            PS kq = new PS();
            kq.t = a.t - a.m;
            kq.m = a.m;
            doiDauPS(ref kq);
            rutGonPS(ref kq);
            return kq;
        }
        public static implicit operator PS(int a)
        {
            return new PS(a, 1);
        }
        public static explicit operator int(PS a)
        {
            int kq = a.t / a.m;
            if ((double)a.t / a.m - kq > 0)
                return kq + 1;
            else return kq;
        }
        public static explicit operator PS(double a)
        {
            int n = 0;
            while (a - (int)a != 0)
            {
                n += 1;
                a = a * 10;
            }
            PS kq = new PS((int)a, (int)Math.Pow(10, n));
            rutGonPS(ref kq);
            return kq;
        }
        public static explicit operator double(PS a)
        {
            return (double)a.t / a.m;
        }
        public static PS operator ^(PS a, int n)
        {
            PS kq = new PS();
            kq.t = (int)Math.Pow(a.t, n);
            kq.m = (int)Math.Pow(a.m, n);
            doiDauPS(ref kq);
            rutGonPS(ref kq);
            return kq;
        }
        public void xuatHS()
        {
            int nguyen = this.t / this.m;
            int tu = this.t % this.m;
            Console.WriteLine("Hon so: {0} {1}/{2}", nguyen, tu, m);
        }
    }
}
