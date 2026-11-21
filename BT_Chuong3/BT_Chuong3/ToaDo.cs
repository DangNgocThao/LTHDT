using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuong3
{
    public class ToaDo
    {
        private int x, y;
        public void nhap()
        {
            Console.Write("Nhap toa do x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public double tinhKhoangCach()
        {
            return Math.Sqrt(x * x + y * y); 
        }
    }
}
