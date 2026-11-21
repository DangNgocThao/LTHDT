using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_2001206904_DangNgocThao_Tuan09
{
    public abstract class HoaDon
    {
        protected string maHD;

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        protected string tenKH;

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        protected DateTime ngayLap;
        protected HangHoa hangHoa;
        protected int soLuong;

        public HoaDon(string maHD, string tenKH, DateTime ngayLap, HangHoa hangHoa, int soLuong)
        {
            this.maHD = maHD;
            this.tenKH = tenKH;
            this.ngayLap = ngayLap;
            this.hangHoa = hangHoa;
            this.soLuong = soLuong;
        }

        public double TinhTongThanhTien()
        {
            return TinhThanhTien() - TinhTienKhuyenMai();
        }

        public double TinhThanhTien()
        {
            return soLuong * hangHoa.DonGia;
        }

        public abstract double TinhTienKhuyenMai();

        public virtual void xuat()
        {
            Console.WriteLine("================");
            Console.WriteLine("MaHD: {0}",maHD);
            Console.WriteLine("TenKH: {0}", tenKH);
            Console.WriteLine("NgayLap: {0}", ngayLap.ToShortDateString());
            Console.WriteLine("Hang: {0}", (hangHoa==null?"Rong!":hangHoa.ToString()) );
            Console.WriteLine("SoLuong: {0}", soLuong);
            Console.WriteLine("Thanh tien: {0:0.000}", TinhThanhTien());
            Console.WriteLine("Khuyen mai: {0:0.000}", TinhTienKhuyenMai());
            Console.WriteLine("Tong so tien phai tra: {0:0.000}", TinhTongThanhTien());
        }
    }
}
