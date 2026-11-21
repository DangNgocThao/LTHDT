//32
//Dang Ngoc Thao
//2001206904
//Lop: THHDT_ST3_C1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_DangNgocThao_KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cn;
            CongTy a = new CongTy();
            do
            {
                menu();
                Console.Write("Ban hay lua chon mot chuc nang: ");
                cn = int.Parse(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        {
                            a.nhap("dsHD.xml");
                            a.xuat();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Tong tien cua tat ca hoa don {0}", a.tinhTongThanhTien());
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Tong tien tro gia {0}", a.tinhTongTroGia());
                        }
                        break;
                    case 4:
                        {
                            HoaDon t = a.slMuaItNhat();
                            Console.WriteLine("Khach co so luong mua it nhat");
                            t.xuat();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Tong tien chiet khau cua khach hang cong ty: {0}", a.tinhTongChietKhau());
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("So luong va thong tin chi tiet cua khach hang dai ly cap 1");
                            a.xuatDLC1();
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Sap xep giam dan theo so luong, neu bang thi giam dan theo thanh tien");
                            a.sapxep();
                        }
                        break;
                    default:
                        break;
                }
            } while (cn != 0);
        }
        static void menu()
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Menu");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("1.Doc va xuat file");
            Console.WriteLine("2.Tinh tong tien cua tat ca hoa don");
            Console.WriteLine("3.Tinh tong tien tro gia");
            Console.WriteLine("4.Cho biet khach co so luong mua it nhat");
            Console.WriteLine("5.Tong tien chiet khau cua khach hang cong ty");
            Console.WriteLine("6.In ra so luong va thong tin chi tiet cua khach hang dai ly cap 1");
            Console.WriteLine("7.Sap xep giam dan theo so luong, neu bang thi giam dan theo thanh tien");
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
