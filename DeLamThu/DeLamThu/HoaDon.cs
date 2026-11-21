using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeLamThu
{
    public abstract class HoaDon
    {
        string ma, ten;
        double d, r, gia;
        int solg;
        public HoaDon()
        {
            Ma="HD0001";
            Ten = "op tuong phong khach";
            D = 60;
            R = 40;
            Solg = 1200;
            Gia = 60;
        }
        public HoaDon(string ma, string ten, int solg)
        {
            this.Ma = ma;
            this.Ten = ten;
            D = R = 60;
            Gia = 35;
            this.Solg = solg;
        }

        public string Ma
        {
            get => ma;
            set
            {
                if (value.Length != 6 || value.StartsWith("HD") == false)
                    Console.WriteLine("loi!");
                else ma = value;
            }
        }
        public string Ten { get => ten; set => ten = value; }
        public int Solg
        {
            get => solg;
            set
            {
                if (value <= 10)
                    solg = 11;
                else solg = value;
            }
        }
        public double D { get => d; set => d = value; }
        public double R { get => r; set => r = value; }
        public double Gia { get => gia; set => gia = value; }
        public abstract double giamGia();
        public double tinhThanhTien()
        {
            return solg * gia - giamGia();
        }

    }
}
