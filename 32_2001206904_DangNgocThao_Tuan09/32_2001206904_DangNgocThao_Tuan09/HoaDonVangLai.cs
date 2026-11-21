using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_2001206904_DangNgocThao_Tuan09
{
    public class HoaDonVangLai : HoaDon
    {
        public HoaDonVangLai(string maHD, DateTime ngayLap, HangHoa hangHoa, int soLuong)
            :base(maHD,"",ngayLap,hangHoa,soLuong)
        {
        }
        public override double TinhTienKhuyenMai()
        {
            double phamTramKM = 0;

            if (TinhThanhTien() >= 1000000)
                phamTramKM = 0.03;

            return phamTramKM * TinhThanhTien();
        }
        public override void xuat()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Loai: VangLai");
            base.xuat();
        }
    }
}
