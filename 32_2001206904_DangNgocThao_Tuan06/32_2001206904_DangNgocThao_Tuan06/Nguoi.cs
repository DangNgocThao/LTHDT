using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan06
{
    public class Nguoi
    {
        string ten, gioiTinh;
        DateTime ngaySinh;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public Nguoi()
        {
            this.ten = "";
            this.gioiTinh = "nam";
            ngaySinh = DateTime.Today;
        }
        public Nguoi(string ten, DateTime ngaySinh, string gioiTinh)
        {
            this.ten = ten;
            if (gioiTinh.Equals("nu") == false)
                this.gioiTinh = "nam";
            else this.gioiTinh = "nu";
            this.ngaySinh = ngaySinh;
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ho ten: {0}\nNgay sinh: {1:dd/MM/yyyy}\nGioi tinh: {2}", this.Ten, this.NgaySinh, this.GioiTinh);
        }
    }
}
