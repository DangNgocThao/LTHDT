using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan06
{
    public class NhanVien
    {
        string ma, ten;

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
        int namVL, soNgayNghi;

        public int SoNgayNghi
        {
            get { return soNgayNghi; }
            set { soNgayNghi = value; }
        }

        public int NamVL
        {
            get { return namVL; }
            set { namVL = value; }
        }
        double hsl;

        public double Hsl
        {
            get { return hsl; }
            set { hsl = value; }
        }
        static int luongCoBan = 1150;

        public static int LuongCoBan
        {
            get { return NhanVien.luongCoBan; }
            set { NhanVien.luongCoBan = value; }
        }
        public NhanVien()
        {
            ma = "NV01";
            ten = "Ho ten SV";
            namVL = 2006;
            soNgayNghi = 1;
            hsl = 3.0;
        }
        public NhanVien(string maso, string hoten, double hsLuong)
        {
            ma = maso;
            ten = hoten;
            hsl = hsLuong;
            namVL = DateTime.Today.Year;
            soNgayNghi = 0;
        }
        public NhanVien(string ma, string ten, int nvl, int nghi, double hsluong)
        {
            this.ma = ma;
            this.ten = ten;
            this.namVL = nvl;
            this.soNgayNghi = nghi;
            this.hsl = hsluong;
        }
        public double phuCapThamNien()
        {
            int thamnien = DateTime.Today.Year - namVL;
            if (thamnien >= 5)
                return thamnien * NhanVien.luongCoBan / 100.0;
            return 0;
        }
        public virtual char xepLoai()
        {
            if (soNgayNghi <= 1) return 'A';
            if (soNgayNghi <= 3) return 'B';
            return 'C';
        }
        public virtual double luong()
        {
            double hsThiDua = 0.5;
            char xl = xepLoai();
            if (xl == 'A') hsThiDua = 1.0;
            if (xl == 'B') hsThiDua = 0.75;
            return NhanVien.luongCoBan * hsl * hsThiDua + phuCapThamNien();
        }
        public virtual void nhap()
        {
            Console.Write("Nhap ma: ");
            ma = Console.ReadLine();
            Console.Write("Nhap ten: ");
            ten = Console.ReadLine();
            Console.Write("Nhap nam vao lam: ");
            namVL = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so ngay nghi: ");
            soNgayNghi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so luong: ");
            hsl = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ma: {0}\nTen: {1}\nNam vao lam: {2}\nSo ngay nghi: {3}\nHe so luong: {4}", ma, ten, namVL, soNgayNghi, hsl);
        }
        public override string ToString()
        {
            return string.Format("Ma: {0}\nTen: {1}\nNam vao lam: {2}\nSo ngay nghi: {3}\nHe so luong: {4}", ma, ten, namVL, soNgayNghi, hsl);
        }
    }
}
