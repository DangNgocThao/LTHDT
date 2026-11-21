using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan04
{
    public class ThiSinh
    {
        string sbd, ten;
        int nams;
        double toan, van, ngoaingu;

        public string Sbd { get => sbd; set => sbd = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Nams { get => nams; set => nams = value; }
        public double Toan { get => toan; set => toan = value; }
        public double Van { get => van; set => van = value; }
        public double Ngoaingu { get => ngoaingu; set => ngoaingu = value; }
        public ThiSinh()
        {
            Sbd = "";
            Ten = "";
            Nams = 2000;
            Toan = 0;
            Van = 0;
            Ngoaingu = 0;
        }
        public ThiSinh(string sbd, string ten, int nam, double toan, double van, double ngoaingu)
        {
            this.Sbd = sbd;
            this.Ten = ten;
            this.Nams = nam;
            this.Toan = toan;
            this.Van = van;
            this.Ngoaingu = ngoaingu;
        }
        public ThiSinh(ThiSinh a)
        {
            this.Sbd = a.Sbd;
            this.Ten = a.Ten;
            this.Nams = a.Nams;
            this.Toan = a.Toan;
            this.Van = a.Van;
            this.Ngoaingu = a.Ngoaingu;
        }
        private double tong;

        public double Tong
        {
            get { return tong = toan + van + ngoaingu * 2; }
        }
        private string ketqua;

        public string Ketqua
        {
            get
            {
                if (tong >= 25) ketqua = "Dau";
                else ketqua = "Rot";
                return ketqua;
            }
        }
        public void xuat()
        {
            Console.WriteLine("{0}, {1}, {2}, Toan: {3}, Van: {4}, Ngoai ngu: {5}, Tong: {6}, {7}", Sbd, Ten, Nams, Toan, Van, Ngoaingu, Tong, Ketqua);
        }
        public void nhap()
        {
            Console.Write("Nhap so bao danh: ");
            Sbd = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            Nams = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem toan: ");
            Toan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem van: ");
            Van = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem ngoai ngu: ");
            Ngoaingu = Convert.ToDouble(Console.ReadLine());
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, Toan: {3}, Van: {4}, Ngoai ngu: {5}, Tong: {6}, {7}", Sbd, Ten, Nams, Toan, Van, Ngoaingu, Tong, Ketqua);
        }
    }
}
