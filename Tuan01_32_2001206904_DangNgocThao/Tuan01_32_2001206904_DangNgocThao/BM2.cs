//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tuan01_32_2001206904_DangNgocThao
//{
//    class BM2
//    {
//        static void Main(string[] args)
//        {
//            string mssv, hten;
//            float dtb;
//            string xeploai;
//            Console.WriteLine("Nhap thong tin cua sinh vien: ");
//            Console.WriteLine("Nhap ma so sinh vien: ");
//            mssv = Console.ReadLine();
//            Console.WriteLine("Ho ten sinh vien: ");
//            hten = Console.ReadLine();
//            Console.WriteLine("Diem trung binh: ");
//            dtb = float.Parse(Console.ReadLine());
//            if (dtb >= 8)
//            {
//                xeploai = "Gioi";
//            }
//            else if (dtb >= 6.5)
//                xeploai = "Kha";
//            else if (dtb >= 5)
//                xeploai = "trung binh";
//            else xeploai = "yeu kem";
//            Console.WriteLine("Thong tin sinh vien: \n MSSV:{0} - Ho ten: {1} - DTB: {2:0.00} - Xep loai: {3}", mssv, hten, dtb, xeploai);
//            Console.ReadLine();
//        }
//    }
//}