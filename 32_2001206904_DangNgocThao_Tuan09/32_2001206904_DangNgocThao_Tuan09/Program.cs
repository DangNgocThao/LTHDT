using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan09
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachHoaDon dsHD = new DanhSachHoaDon();
            //Cau 2
            dsHD.loadXMLFile("HoaDon.xml");
            dsHD.xuat();

            //Cau 03
            Console.WriteLine("================================");
            Console.WriteLine("Danh sach cac khach hang vang lai");
            dsHD.xuatHDVangLai();

            //Cau04
            Console.WriteLine("================================");
            Console.WriteLine("Tong tien cac HD: {0:0.000}", dsHD.TinhTongTienCacHoaDon());

            //Cau 05
            Console.WriteLine("================================");
            Console.WriteLine("Hoa don co tong tien cao nhat: ");
            HoaDon hd = dsHD.TimHDCoTongTienCaoNhat();
            hd.xuat();

            //cau 06
            Console.WriteLine("================================");
            int demSLVIP = dsHD.DemSoHDKhachVIP();
            int demSLThanThiet = dsHD.DemSoHDKhachThanThiet();
            Console.WriteLine("So luong hoa don VIP: {0}", demSLVIP);
            Console.WriteLine("So luong hoa don ThanThiet: {0}", demSLThanThiet);

            //Cau 07      
            Console.WriteLine("================================");
            string tenKH = "Nguyen Long";
            double tongTU = dsHD.TongTamUngCuaKhach(tenKH);
            Console.WriteLine("Tong tien tam ung KH {0} la:{1:0.000}",tenKH,tongTU);

            Console.ReadLine();
        }
    }
}
