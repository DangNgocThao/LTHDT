using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan02
{
    class Program
    {
        static void Main(string[] args)
        {
            VanDongVien v = new VanDongVien();
            v.nhap();
            v.xuat();
            Console.ReadKey();
        }
    }
}
