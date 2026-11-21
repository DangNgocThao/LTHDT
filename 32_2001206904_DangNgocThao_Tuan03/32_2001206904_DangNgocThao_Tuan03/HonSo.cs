using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan03
{
    public class HonSo
    {
        int n;
        PS ps = new PS();

        public int N { get => n; set => n = value; }
        public PS Ps { get => ps; set => ps = value; }
        public HonSo()
        {
            n = 1;
            ps = 1;
        }
        public HonSo(int n, int t, int m)
        {
            this.n = n;
            this.Ps.T = t;
            this.Ps.M = m;
        }
        public HonSo(HonSo a)
        {
            this.n = a.n;
            this.ps = a.ps;
        }
        public void nhap()
        {
            Console.Write("nhap hon so: ");
            string hs = Console.ReadLine();
            String[] split = hs.Split(' ');
            string[] split1 = split[1].Split('/');
            n = Convert.ToInt32(split[0]);
            ps.T = Convert.ToInt32(split1[0]);
            ps.M = Convert.ToInt32(split1[1]);
        }
        public void xuat()
        {
            Console.WriteLine("Hon so: {0} {1}/{2}", N, ps.T, ps.M);
        }
        public void doiHSThanhPS()
        {
            ps.T = ps.M * n + ps.T;
            n = 0;
        }
        public void doiPSThanhHS()
        {
            n = ps.T / ps.M;
            ps.T = ps.T % ps.M;
        }
        public static HonSo operator +(HonSo a, HonSo b)
        {
            a.doiHSThanhPS();
            b.doiHSThanhPS();
            HonSo kq = new HonSo();
            kq.ps = a.ps + b.ps;
            kq.doiPSThanhHS();
            return kq;
        }
        public static HonSo operator -(HonSo a, HonSo b)
        {
            a.doiHSThanhPS();
            b.doiHSThanhPS();
            HonSo kq = new HonSo();
            kq.ps = a.ps - b.ps;
            kq.doiPSThanhHS();
            return kq;
        }
        public static HonSo operator *(HonSo a, HonSo b)
        {
            a.doiHSThanhPS();
            b.doiHSThanhPS();
            HonSo kq = new HonSo();
            kq.ps = a.ps * b.ps;
            kq.doiPSThanhHS();
            return kq;
        }
        public static HonSo operator /(HonSo a, HonSo b)
        {
            a.doiHSThanhPS();
            b.doiHSThanhPS();
            HonSo kq = new HonSo();
            kq.ps = a.ps / b.ps;
            kq.doiPSThanhHS();
            return kq;
        }
        public static double tinhGiaTri(HonSo a)
        {
            return a.n + (double)a.ps.T / a.ps.M;
        }
        public static bool operator >(HonSo a, HonSo b)
        {
            return tinhGiaTri(a) > tinhGiaTri(b);
        }
        public static bool operator <(HonSo a, HonSo b)
        {
            return tinhGiaTri(a) < tinhGiaTri(b);
        }
        public static bool operator >=(HonSo a, HonSo b)
        {
            return tinhGiaTri(a) >= tinhGiaTri(b);
        }
        public static bool operator <=(HonSo a, HonSo b)
        {
            return tinhGiaTri(a) <= tinhGiaTri(b);
        }
        public static bool operator ==(HonSo a, HonSo b)
        {
            return tinhGiaTri(a) == tinhGiaTri(b);
        }
        public static bool operator !=(HonSo a, HonSo b)
        {
            return tinhGiaTri(a) != tinhGiaTri(b);
        }
        public static HonSo operator ++(HonSo a)
        {
            a.n++;
            return a;
        }
        public static HonSo operator --(HonSo a)
        {
            a.n--;
            return a;
        }
        public static explicit operator double(HonSo a)
        {
            return a.n + (double)a.ps.T / a.ps.M;
        }
        public static explicit operator HonSo(double a)
        {
            HonSo kq = new HonSo();
            kq.ps = (PS)a;
            kq.doiPSThanhHS();
            return kq;
        }
    }
}
