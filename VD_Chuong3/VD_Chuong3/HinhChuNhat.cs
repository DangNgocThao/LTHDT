using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Chuong3
{
    public class HinhChuNhat
    {
        private int d, r;
        public void nhap()
        {
            Console.Write("Nhap chieu dai: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            r = Convert.ToInt32(Console.ReadLine());
        }
        public int tinhCV()
        {
            return (d + r) * 2;
        }
        public int tinhDT()
        {
            return d * r;
        }
        public void xuat()
        {
            Console.WriteLine("Chu vi: {0}", tinhCV());
            Console.WriteLine("Dien tich: {0}", tinhDT());
        }
    }
}