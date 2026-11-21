using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan06
{
    class Program
    {
        static void Main(string[] args)
        {
            //NhanVien a = new NhanVien("6904", "Thao", 2002, 0, 9.0);
            //a.xuat();
            //Console.WriteLine("Luong: {0}", a.luong());
            //CanBo b = new CanBo();
            //b.nhap();
            //b.xuat();
            //Console.WriteLine("Luong: {0}", b.luong());
            //SinhVien c = new SinhVien("Vinh", DateTime.Parse("29/06/2002"), "nam", "2001206904", "Dai hoc");
            //c.xuat();
            NuocGiaiKhat d = new NuocGiaiKhat("HH002", "cola", "lon", 50, 17500);
            d.xuat();
            Console.WriteLine("Thanh tien: {0:0.000}", d.tinhTien());
            Console.ReadKey();
        }
    }
}
