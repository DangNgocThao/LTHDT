using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan06
{
    public class CanBo:NhanVien
    {
        string chucvu, phongban;
        double hesold;
        public CanBo():base()
        {
            chucvu = "Truong phong";
            phongban = "Phong Hanh Chinh";
            hesold = 5.0;
        }
        public CanBo(string ma, string ten, double hsl, string chucvu, double hesophucapcv)
            : base(ma, ten, DateTime.Today.Year, 1, hsl)
        {
            this.chucvu = chucvu;
            this.hesold = hesophucapcv;
        }
        public CanBo(string ma, string ten, int nvl, int nghi, double hsl, string chucvu, string pb, double hesold)
            : base(ma, ten, nvl, nghi, hsl)
        {
            this.chucvu = chucvu;
            this.phongban = pb;
            this.hesold = hesold;
        }
        public override char xepLoai()
        {
            return 'A';
        }
        public double phuCapCV()
        {
            return hesold * NhanVienB4.LuongCoBan;
        }
        public override double luong()
        {
            return base.luong() + phuCapCV();
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap chuc vu: ");
            chucvu = Console.ReadLine();
            Console.Write("Nhap phong ban: ");
            phongban = Console.ReadLine();
            Console.Write("Nhap he so lanh dao: ");
            hesold = Convert.ToDouble(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("{0}\nChuc vu: {1}\nPhong ban: {2}\nHe so lanh dao: {3}", base.ToString(), chucvu, phongban, hesold);
        }
    }
}
