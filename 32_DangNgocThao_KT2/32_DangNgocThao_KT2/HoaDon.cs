using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_DangNgocThao_KT2
{
    public abstract class HoaDon
    {
        protected string ma, ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        protected int solg;

        public int Solg
        {
            get { return solg; }
            set { solg = value; }
        }
        protected double gia;

        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public HoaDon()
        {
            ma = "";
            ten = "";
            solg = 0;
            gia = 0;
        }

        public HoaDon(string ma, string ten, int solg, double gia)
        {
            this.ma = ma;
            this.ten = ten;
            this.solg = solg;
            this.gia = gia;
        }

        public abstract double tinhChietKhau();
        public double tinhThueVAT()
        {
            return 0.1 * solg * gia;
        }
        public double tinhThanhTien()
        {
            return solg * gia - tinhChietKhau() + tinhThueVAT();
        }
        public void xuat()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Ma: {0}", ma);
            Console.WriteLine("Ten: {0}", ten);
            Console.WriteLine("So luong: {0}", solg);
            Console.WriteLine("Don gia: {0}", gia);
            Console.WriteLine("Thanh Tien: {0}", tinhThanhTien());
            Console.WriteLine("Thue VAT: {0}", tinhThueVAT());
            Console.WriteLine("Chiet khau: {0}", tinhChietKhau());
        }
    }
}
