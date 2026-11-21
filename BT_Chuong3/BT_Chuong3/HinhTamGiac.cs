using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuong3
{
    public class HinhTamGiac
    {
        private int a, b, c;
        public int tinhCV()
        {
            return a + b + c;
        }
        public double tinhDT()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
