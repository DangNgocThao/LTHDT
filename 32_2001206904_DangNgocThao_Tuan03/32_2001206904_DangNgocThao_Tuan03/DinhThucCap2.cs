using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan03
{
    public class DinhThucCap2
    {
        int[,] mt = new int[2, 2];
        public int[,] Mt { get => mt; set => mt = value; }
        public DinhThucCap2()
        {
            for (int i = 0; i < mt.GetLength(0); i++)
            {
                for (int j = 0; j < mt.GetLength(1); j++)
                {
                    mt[i, j] = 0;
                }
            }
        }
        ~DinhThucCap2() { }
        public void nhap()
        {
            Random a = new Random();
            for (int i = 0; i < mt.GetLength(0); i++)
            {
                for (int j = 0; j < mt.GetLength(1); j++)
                {
                    mt[i, j] = a.Next(-50, 50);
                }
            }
        }
        public void xuat()
        {
            Console.Write("Xuat ma tran:\n");
            for (int i = 0; i < mt.GetLength(0); i++)
            {
                for (int j = 0; j < mt.GetLength(1); j++)
                    Console.Write("{0,5:D}", mt[i, j]);
                Console.Write("\n");
            }
        }
        public static int tinhDinhThuc(DinhThucCap2 a)
        {
            return a.Mt[0, 0] * a.Mt[1, 1] - a.Mt[0, 1] * a.Mt[1, 0];
        }
        public DinhThucCap2 tong(DinhThucCap2 a)
        {
            DinhThucCap2 kq = new DinhThucCap2();
            for (int i = 0; i < mt.GetLength(0); i++)
            {
                for (int j = 0; j < mt.GetLength(1); j++)
                {
                    kq.Mt[i, j] = this.Mt[i, j] + a.Mt[i, j];
                }
            }
            return kq;
        }
        public static DinhThucCap2 operator +(DinhThucCap2 a, DinhThucCap2 b)
        {
            DinhThucCap2 kq = new DinhThucCap2();
            for (int i = 0; i < a.Mt.GetLength(0); i++)
            {
                for (int j = 0; j < a.Mt.GetLength(1); j++)
                {
                    kq.Mt[i, j] = a.Mt[i, j] + b.Mt[i, j];
                }
            }
            return kq;
        }
        public DinhThucCap2 nhan(int a)
        {
            DinhThucCap2 kq = new DinhThucCap2();
            for (int i = 0; i < mt.GetLength(0); i++)
            {
                for (int j = 0; j < mt.GetLength(1); j++)
                {
                    kq.Mt[i, j] = this.Mt[i, j] * a;
                }
            }
            return kq;
        }
        public static DinhThucCap2 operator *(DinhThucCap2 a, int b)
        {
            DinhThucCap2 kq = new DinhThucCap2();
            for (int i = 0; i < a.Mt.GetLength(0); i++)
            {
                for (int j = 0; j < a.Mt.GetLength(1); j++)
                {
                    kq.Mt[i, j] = a.Mt[i, j] * b;
                }
            }
            return kq;
        }
    }
}
