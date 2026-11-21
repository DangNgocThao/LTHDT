using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNgocThao
{
    class Program
    {
        static void Main(string[] args)
        {
            NhaXe a = new NhaXe();
            int cn = -1;
            do
            {
                Console.WriteLine("==============================================================");
                Console.WriteLine("menu");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Doc file xml");
                Console.WriteLine("2. Xuat thong tin nha xe");
                Console.WriteLine("3. Tinh tong dung tich xang");
                Console.WriteLine("4. Sap xep xe theo so km tang dan. Neu cung so km thi xep giam dan theo cho ngoi");
                Console.WriteLine("5. Xuat thong tin tai xe Nguyen");
                Console.WriteLine("==============================================================");
                Console.Write("Chon chuc nang: ");
                cn = Convert.ToInt32(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        {
                            a.nhapXML("nhaxe.xml");
                            a.xuat();
                        }
                        break;
                    case 2:
                        {
                            a.xuat();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Tong dung tich xang: {0}", a.tinhDungTich());
                        }
                        break;
                    case 4:
                        {
                            a.sapXep();
                            a.xuat();
                        }
                        break;
                    case 5:
                        {
                            a.xuatNguyen();
                        }
                        break;
                    default:
                        break;
                }
            } while (cn != 0);
        }
    }
}
