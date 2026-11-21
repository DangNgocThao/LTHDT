using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_32_2001206904_DangNgocThao
{
    public class BTVN10
    {
        ArrayList arr = new ArrayList();
        public BTVN10()
        {
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                arr.Add(r.Next(0, 1000));
            }
        }
        public void xuat()
        {
            Console.Write("Day so: ");
            foreach (int i in arr)
            {
                Console.Write("{0,5:D}", i);
            }
            Console.WriteLine();
        }
        public void dao()
        {
            arr.Reverse();
            Console.Write("Day so sau khi dao: ");
            foreach (int i in arr)
            {
                Console.Write("{0,5:D}", i);
            }
            Console.WriteLine();
        }
        public void tim()
        {
            int x;
            Console.Write("Nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (arr.Contains(x))
                Console.WriteLine("Co {0} trong day so", x);
            else
                Console.WriteLine("Khong co {0} trong day so", x);
        }
        public void xuatPT2ChuSo()
        {
            int d = 0;
            foreach (int i in arr)
            {
                if (i >= 10 && i <= 99)
                {
                    d++;
                    if (d == 1)
                        Console.Write("Day so co 2 chu so: ");
                    Console.Write("{0,5:D}", i);
                }
            }
            if (d != 0)
                Console.WriteLine();
            else
                Console.WriteLine("Khong co so co 2 chu so trong day so");
        }
        public bool ktChuSoToanChan(int n)
        {
            while (n != 0)
            {
                if ((n % 10) % 2 != 0)
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }
        public void xuatPTCoChuSoToanChan()
        {
            int d = 0;
            foreach (int i in arr)
            {
                if (ktChuSoToanChan(i))
                {
                    d++;
                    if (d == 1)
                        Console.Write("Day so co toan chu so chan: ");
                    Console.Write("{0,5:D}", i);
                }
            }
            if (d != 0)
                Console.WriteLine();
            else
                Console.WriteLine("Khong co so co toan chu so chan trong day so");
        }
        public bool ktSNT(int n)
        {
            int d = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0) d++;
            if (d == 2) return true;
            return false;
        }
        public void xuatPTSNT()
        {
            int d = 0;
            foreach (int i in arr)
            {
                if (ktSNT(i))
                {
                    d++;
                    if (d == 1)
                        Console.Write("Day so nguyen to: ");
                    Console.Write("{0,5:D}", i);
                }
            }
            if (d != 0)
                Console.WriteLine();
            else
                Console.WriteLine("Khong co so nguyen to trong day so");
        }
        public void xoaLeBoiCua3()
        {
            for (int i = 0; i < arr.Count; i++)
            {
                int a = (int)arr[i];
                if (a % 2 != 0 && a % 3 == 0)
                {
                    arr.Remove(a);
                    i--;
                }
            }
            Console.WriteLine("Day sau khi xoa");
            xuat();
        }
        public void tang1DV()
        {
            if ((int)arr[0] < (int)arr[1])
                arr[0] = (int)arr[0] + 1;
            for (int i = 1; i < arr.Count - 1; i++)
            {
                if ((int)arr[i - 1] > (int)arr[i] && (int)arr[i + 1] > (int)arr[i])
                    arr[i] = (int)arr[i] + 1;
            }
            if ((int)arr[arr.Count - 1] < (int)arr[arr.Count - 2])
                arr[arr.Count - 1] = (int)arr[arr.Count - 1] + 1;
            Console.WriteLine("Day sau khi tang 1 don vi cho cac so nho hon so lien ke");
            xuat();
        }
        public void sapTang()
        {
            arr.Sort();
            Console.WriteLine("Day sau khi sep tang");
            xuat();
        }
        public void sapGiam()
        {
            arr.Sort();
            arr.Reverse();
            Console.WriteLine("Day sau khi sep giam");
            xuat();
        }
    }
}
