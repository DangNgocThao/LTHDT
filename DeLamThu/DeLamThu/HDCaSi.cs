using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeLamThu
{
    public abstract class HDCaSi
    {
        protected String ma, ten;
        public String Ma
        {
            get { return ma; }
            set
            {
                ma = value;
                if (!(ma.Length == 6 && ma.StartsWith("HD") == true && ma.Substring(2).All(char.IsDigit) == true))
                    throw new Exception("Loi roi");
            }
        }
        protected int soTM;
        protected DateTime ngayBD;
        protected double donGia, phuPhi;
        public double DonGia
        {
            get { return donGia; }
            set
            {
                donGia = value;
                if (donGia <= 0)
                    throw new Exception("loi don gia");
            }
        }
        public static double TiLeThue = 0.15;
        public HDCaSi()
        {
            ma = "HD3418";
            ten = "Ly Khong Hay";
            soTM = 3;
            ngayBD = new DateTime(2020, 10, 24);
            donGia = 4000000;
            phuPhi = 2000000;
        }
        public HDCaSi(String ma, String ten, double dg)
        {
            this.ma = ma;
            this.ten = ten;
            this.donGia = dg;
            this.soTM = 2;
            phuPhi = 0;
            ngayBD = new DateTime(2020, 12, 24);
        }
        public double tinhTT()
        {
            return soTM * donGia + phuPhi + tinhQC();
        }
        public abstract double tinhQC();
        public double tinhThue()
        {
            return tinhTT() * TiLeThue;
        }
    }
}
