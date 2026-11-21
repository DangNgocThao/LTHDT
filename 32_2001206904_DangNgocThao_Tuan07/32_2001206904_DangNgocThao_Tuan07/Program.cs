using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    class Program
    {
        static void Main(string[] args)
        {
            DSMonHoc a = new DSMonHoc();
            a.nhap("Monhocs.xml");
            a.xuat();
            Console.ReadKey();
        }
    }
}
