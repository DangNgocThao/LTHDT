//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tuan01_32_2001206904_DangNgocThao
//{
//    class BM3
//    {
//        static void Main(string[] args)
//        {
//            int n;
//            Console.WriteLine("Nhap so phan tu day so: ");
//            n = int.Parse(Console.ReadLine());
//            List<int> dso = new List<int>(n);
//            Random a = new Random();
//            for (int i = 0; i < n; i++)
//            {
//                int k = a.Next(100);
//                dso.Add(k);
//            }
//            foreach (int t in dso)
//            {
//                Console.Write(t + "   ");
//            }
//            Console.ReadLine();
//        }
//    }
//}