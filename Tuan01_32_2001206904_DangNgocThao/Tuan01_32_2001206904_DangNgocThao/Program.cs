using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_32_2001206904_DangNgocThao
{
    class Program
    {
        static void Main(string[] args)
        {
            BTVN10 a = new BTVN10();
            a.xuat();
            a.tim();
            a.xuatPT2ChuSo();
            a.xuatPTCoChuSoToanChan();
            a.xuatPTSNT();
            a.xoaLeBoiCua3();
            a.tang1DV();
            a.sapTang();
            a.sapGiam();
            Console.Read();
        }
    }
}
