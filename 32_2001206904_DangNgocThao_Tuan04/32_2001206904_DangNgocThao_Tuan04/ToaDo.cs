using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan04
{
    public class ToaDo
    {
        int x, y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public double tinh_khoangcach()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y);
        }
        public override string ToString()
        {
            return string.Format("({0},{1}) ", this.x, this.y);
        }
    }
}
