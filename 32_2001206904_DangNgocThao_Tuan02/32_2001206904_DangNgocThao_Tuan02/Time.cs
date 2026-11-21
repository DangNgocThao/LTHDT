using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan02
{
    public class Time
    {
        int gio, phut, giay;
        string kieu;
        #region contrsuctor
        public int Gio
        {
            get { return gio; }
            set
            {
                if (value < 0 || value > 23)
                {
                    Console.WriteLine("Du lieu sai");
                }
                else gio = value;
            }
        }

        public int Phut
        {
            get { return phut; }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Du lieu sai");
                }
                else phut = value;
            }
        }

        public int Giay
        {
            get { return giay; }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Du lieu sai");
                }
                else giay = value;
            }
        }

        public string Kieu
        {
            get { return kieu; }
            set
            {
                if (!(value == "AM" || value == "PM"))
                {
                    Console.WriteLine("Du lieu sai");
                }
                else kieu = value;
            }
        }
        #endregion
        public Time()
        {
            Gio = Phut = Giay = 0;
        }
        public Time(int gio, int phut, int giay)
        {
            this.Gio = gio;
            this.Phut = phut;
            this.Giay = giay;
        }
        public Time(Time a)
        {
            this.Gio = a.Gio;
            this.Phut = a.Phut;
            this.Giay = a.Giay;
        }
        public void nhap24h()
        {
            do
            {
                Console.Write("Nhap thoi gian dang 24h: ");
                string so = Console.ReadLine();
                string[] splitStr = so.Split(':');
                Gio = Convert.ToInt32(splitStr[0]);
                Phut = Convert.ToInt32(splitStr[1]);
                Giay = Convert.ToInt32(splitStr[2]);
            } while (Gio < 0 || Gio > 23 || Phut < 0 || Phut > 59 || Giay < 0 || Giay > 59);
        }
        public void xuat24h()
        {
            Console.WriteLine("thoi gian dang 24h: {0:00}:{1:00}:{2:00}", Gio, Phut, Giay);
        }
        public void nhap12h()
        {
            do
            {
                Console.Write("Nhap thoi gian dang 12h: ");
                string so = Console.ReadLine();
                string[] splitStr1 = so.Split(' ');
                string[] splitStr2 = splitStr1[0].Split(':');
                Gio = Convert.ToInt32(splitStr2[0]);
                Phut = Convert.ToInt32(splitStr2[1]);
                Giay = Convert.ToInt32(splitStr2[2]);
                Kieu = splitStr1[1];
            } while (Gio < 0 || Gio > 12 || Phut < 0 || Phut > 59 || Giay < 0 || Giay > 59 || !(Kieu == "AM" || Kieu == "PM"));
        }
        public void xuat12h()
        {
            Console.WriteLine("thoi gian dang 12h: {0:00}:{1:00}:{2:00} {3}", Gio, Phut, Giay, Kieu);
        }
        public bool ktThoiGianHopLe()
        {
            if (Gio == DateTime.Now.Hour && Phut == DateTime.Now.Minute)
            {
                return true;
            }
            return false;
        }
        public void tangGio(int soGiay)
        {
            Gio += soGiay / 3600;
            soGiay %= 3600;
            Phut += soGiay / 60;
            soGiay %= 60;
            Giay += soGiay;
            if (Giay > 59)
            {
                Giay -= 60;
                Phut++;
            }
            if (Phut > 59)
            {
                Phut -= 60;
                Gio++;
            }
            if (Gio > 23)
            {
                Gio %= 24;
            }
        }
        public void tangGio(int soGiay, string kieuGio)
        {
            tangGio(soGiay);
            if (kieuGio == "12")
            {
                Console.WriteLine("Sau khi tang gio KIEU GIO 12");
                xuat12h();
            }
            else
            {
                Console.WriteLine("Sau khi tang gio KIEU GIO 24");
                xuat24h();
            }
        }
        public void giamGio(int soGiay)
        {
            Gio -= soGiay / 3600;
            soGiay %= 3600;
            Phut -= soGiay / 60;
            soGiay %= 60;
            Giay -= soGiay;
            if (Giay < 0)
            {
                Giay = 60 + Giay;
                Phut--;
            }
            if (Phut < 0)
            {
                Phut = 60 + Phut;
                Gio--;
            }
            if (Gio < 0)
            {
                Gio = 24 + Gio;
            }
        }
        public void giamGio(int soGiay, string kieuGio)
        {
            giamGio(soGiay);
            if (kieuGio == "12")
            {
                Console.WriteLine("Sau khi giam gio KIEU GIO 12");
                xuat12h();
            }
            else
            {
                Console.WriteLine("Sau khi giam gio KIEU GIO 24");
                xuat24h();
            }
        }
    }
}
