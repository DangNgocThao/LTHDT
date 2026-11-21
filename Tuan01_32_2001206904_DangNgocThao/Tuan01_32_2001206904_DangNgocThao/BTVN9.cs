using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01_32_2001206904_DangNgocThao
{
    public class BTVN9
    {
        private int d, m, y;
        public BTVN9()
        {
            d = 1;
            m = 1;
            y = 2000;
        }
        public BTVN9(int ngay,int thang,int nam)
        {
            d = ngay;
            m = thang;
            y = nam;
        }
        public void nhap()
        {
            Console.Write("Nhap ngay: ");
            string a = Console.ReadLine();
            string[] splitStr = a.Split('/');
            d = Convert.ToInt32(splitStr[0]);
            m = Convert.ToInt32(splitStr[1]);
            y = Convert.ToInt32(splitStr[2]);
        }
        public bool ktNhuan()
        {
            if (y % 400 == 0)
                return true;
            if (y % 4 == 0 && y % 100 != 0)
                return true;
            return false;
        }
        public void xuatHomSau()
        {
            int soNgayCuaThang = 31, ngay = d, thang = m, nam = y;
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                soNgayCuaThang = 30;
            if (thang == 2)
            {
                soNgayCuaThang = 28;
                if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
                    soNgayCuaThang = 29;
            }
            ngay++;
            if (ngay > soNgayCuaThang)
            {
                ngay = 1;
                thang++;
                if (thang == 13)
                {
                    thang = 1;
                    y++;
                }
            }
            Console.WriteLine("Ngay hom sau la:{0:00}/{1:00}/{2}", ngay, thang, nam);
        }
        public void xuatHomTruoc()
        {
            int ngay = d, thang = m, nam = y;
            ngay--;
            if (ngay == 0)
            {
                thang--;
                int soNgayCuaThang = 31;
                if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                    soNgayCuaThang = 30;
                if (thang == 2)
                {
                    soNgayCuaThang = 28;
                    if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
                        soNgayCuaThang = 29;
                }
                ngay = soNgayCuaThang;
                if (thang == 0)
                {
                    thang = 12;
                    nam--;
                }
            }
            Console.WriteLine("Ngay hom truoc la:{0:00}/{1:00}/{2}", ngay, thang, nam);
        }
    }
}
