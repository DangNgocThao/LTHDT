using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public abstract class MonHoc
    {
        protected string ma, ten, khoa;
        protected int soTC;
        double diem;
        public MonHoc(string ma, string ten, int soTC)
        {
            this.ma = ma;
            this.ten = ten;
            this.soTC = soTC;
        }

        public abstract int tinhHP();
        public abstract double tinhDiem();
        public virtual void xuat()
        {
            Console.WriteLine("{0,-10}{1,-30}{2}", ma, ten, soTC);
        }
    }
}
