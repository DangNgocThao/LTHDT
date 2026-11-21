using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_2001206904_DangNgocThao_Tuan09
{
    public class HangHoa
    {
        private string maHH;

        public string MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }
        private string tenHH;

        public string TenHH
        {
            get { return tenHH; }
            set { tenHH = value; }
        }
        private double donGia;

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public HangHoa()
        {
            maHH = "";
            tenHH = "";
            donGia = 0;
        }

        public HangHoa(string maHH, string tenHH, double donGia)
        {
            this.maHH = maHH;
            this.tenHH = tenHH;
            this.donGia = donGia;
        }
        //public void xuat()
        //{
        //    Console.WriteLine ("HH: {0}\t{1}\t{2}",maHH,tenHH,donGia);
        //}
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}",maHH,tenHH,donGia);
        }
    }
}
