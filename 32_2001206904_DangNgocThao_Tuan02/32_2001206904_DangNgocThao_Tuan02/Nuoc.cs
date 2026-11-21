using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan02
{
    public class Nuoc
    {
        string ten, donVi;

        public string DonVi
        {
            get { return donVi; }
            set
            {
                if (value == "ket" || value == "thung" || value == "chai" || value == "lon")
                    donVi = value;
                else
                    donVi = "ket";
            }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        int soLg;

        public int SoLg
        {
            get { return soLg; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Du lieu sai");
                else
                    soLg = value;
            }
        }
        float donGia;
        public float DonGia
        {
            get { return donGia; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Du lieu sai");
                else
                    donGia = value;
            }
        }
        public static double thue = 0.1;
        public Nuoc()
        {
            Ten = DonVi = "";
            SoLg = 0;
            DonGia = 0;
        }
        public Nuoc(string ten, string donVi, int soLg, float donGia)
        {
            this.Ten = ten;
            this.DonVi = donVi;
            this.SoLg = soLg;
            this.DonGia = donGia;
        }
        public Nuoc(Nuoc a)
        {
            this.Ten = a.Ten;
            this.DonVi = a.DonVi;
            this.SoLg = a.SoLg;
            this.DonGia = a.DonGia;
        }
        public double tinhThanhTien()
        {
            double thanhTien = soLg * donGia + soLg * donGia * thue;
            if (donVi == "chai")
                return thanhTien / 20;
            else if (donVi == "lon")
                return thanhTien / 24;
            else
                return thanhTien;

        }
        public void Nhap()
        {
            Console.Write("Nhap ten hang: ");
            ten = Console.ReadLine();
            Console.Write("Nhap don vi tinh: ");
            donVi = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            soLg = int.Parse(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            donGia = float.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Ten hang: {0}", ten);
            Console.WriteLine("Don vi tinh: {0}", donVi);
            Console.WriteLine("So luong: {0}", soLg);
            Console.WriteLine("Don gia: {0:0.00}", donGia);
            Console.WriteLine("Thanh Tien: {0:0.00}", tinhThanhTien());
        }
    }
}
