using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuong3
{
    public class HinhTron
    {
        private double bk;
        public double R
        {
            get { return bk; }
            set { bk = value; }
        }
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
    }
}