using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public abstract class HoGiaDinh
    {
        string ten, diachi;
        protected int csm, csc;
        public HoGiaDinh()
        {
            ten = "";
            diachi = "";
            csm = 0;
            csc = 0;
        }
        public HoGiaDinh(string ten,string diachi,int csm,int csc)
        {
            this.ten = ten;
            this.diachi = diachi;
            this.csm = csm;
            this.csc = csc;
        }
        public abstract double tinhSoNuoc();
        public double tinhTienNuoc()
        {
            return tinhTienNuoc() * 8000;
        }
    }
}
