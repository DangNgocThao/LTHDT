using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_2001206904_DangNgocThao_Tuan09
{
    public class HoaDonThanThiet : HoaDon, IHoTro
    {
        public HoaDonThanThiet(string maHD, string tenKH, DateTime ngayLap, HangHoa hangHoa, int soLuong)
            :base(maHD,tenKH,ngayLap,hangHoa,soLuong)
        {
        }

        public double TinhThanhToanTamUng()
        {
            return 0.6 * TinhTongThanhTien();
        }

        public double TinhLaiSuatTraCham()
        {
            return 0.03 * (TinhTongThanhTien() - TinhThanhToanTamUng());
        }

        public override double TinhTienKhuyenMai()
        {
            double phamTramKM = 0;
            if (soLuong > 60)
                phamTramKM = 0.04;
            else
            {
                if (TinhThanhTien() >= 800000)
                    phamTramKM = 0.03;
            }
            return phamTramKM * TinhThanhTien();
        }

        public override void xuat()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Loai: ThanThiet");
            base.xuat();
        }
    }
}
