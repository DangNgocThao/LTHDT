using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Chuong3
{
    public class HinhTron
    {
        private double bk;
        public void nhap()
        {
            Console.Write("Nhap ban kinh: ");
            bk = Convert.ToDouble(Console.ReadLine());
        }
        public double tinhCV()
        {
            return bk * 2 * Math.PI;
        }
        public double tinhDT()
        {
            return bk * bk * Math.PI;
        }
        public void xuat()
        {
            Console.WriteLine("Ban kinh: {0}", bk);
            Console.WriteLine("Chu vi: {0}", tinhCV());
            Console.WriteLine("Dien tich: {0}", tinhDT());
        }
    }
}