using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NgheSy
{
    public abstract class NgheSy
    {
        protected string ma;
        protected string hoten;
        protected int nams;
        protected string gioi;
        protected int stm;
        public static int dongia = 500;

        public int Stm
        {
            get { return stm; }
            set
            {
                if (value >= 1 && value <= 3)
                    stm = value;
                else
                {
                    Console.WriteLine("Loi!");
                    stm = 1;
                }
            }
        }

        public string Ma
        {
            get { return ma; }
            set
            {
                if (value.Length == 8 && value.StartsWith("NS") == true)
                    ma = value;
                else
                {
                    Console.WriteLine("Loi!");
                    ma = "NS000000";
                }
            }
        }

        public NgheSy()
        {
            ma = "NS1234BD";
            hoten = "Tran The Thang";
            gioi = "nam";
            nams = 2010;
            stm = 2;
        }

        public NgheSy(string ma, string hoten)
        {
            this.ma = ma;
            this.hoten = hoten;
            gioi = "nam";
            nams = DateTime.Today.Year - 18;
            stm = 2;
        }

        public void xuat()
        {
            Console.WriteLine("Ma: {0}", Ma);
            Console.WriteLine("Ten: {0}", hoten);
            Console.WriteLine("Gioi tinh: {0}", gioi);
            Console.WriteLine("So tiet muc: {0}", Stm);
        }

        public double tinhPhiQC()
        {
            double t = stm * 30;
            if (stm > 3)
                t -= t * 0.3;
            return t;
        }

        public abstract double tinhHeSoNS();

        public double tinhTongTien()
        {
            return stm * dongia * tinhHeSoNS() - tinhPhiQC();
        }
    }
}