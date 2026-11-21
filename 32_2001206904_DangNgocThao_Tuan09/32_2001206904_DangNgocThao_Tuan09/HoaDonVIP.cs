using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_2001206904_DangNgocThao_Tuan09
{
    public class HoaDonVIP : HoaDon, IHoTro
    {
        public HoaDonVIP(string maHD, string tenKH, DateTime ngayLap, HangHoa hangHoa, int soLuong)
            : base(maHD, tenKH, ngayLap, hangHoa, soLuong)
        {

        }
        public double TinhThanhToanTamUng()
        {
            return 0.4 * TinhThanhTien();
        }

        public double TinhLaiSuatTraCham()
        {
            return 0.02 * (TinhTongThanhTien() - TinhThanhToanTamUng());
        }

        public override double TinhTienKhuyenMai()
        {
            double phamTramKM = 0;
            if (soLuong > 50)
                phamTramKM = 0.05;
            else if (soLuong > 10)
            {
                if (TinhThanhTien() >= 600000)
                    phamTramKM = 0.04;
                else
                    phamTramKM = 0.01;
            }

            return phamTramKM * TinhThanhTien();
        }
        public override void xuat()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Loai: VIP");
            base.xuat();
        }
    }
}
