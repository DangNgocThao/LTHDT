using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuong3
{
    public class DinhThucCap2
    {
        private int[,] mt = new int[2,2];
        private int i, j;
        public void nhap()
        {
            Console.Write("Nhap ma tran vuong (2x2):\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                    mt[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void xuat()
        {
            Console.Write("In ma tran:\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                    Console.Write("{0}  ", mt[i, j]);
                Console.Write("\n");
            }
        }
        public int tinhDinhThuc()
        {
            return mt[0, 0] * mt[1, 1] - mt[0, 1] * mt[1, 0];
        }
    }
}
