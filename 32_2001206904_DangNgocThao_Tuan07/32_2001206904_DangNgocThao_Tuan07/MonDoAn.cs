using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public class MonDoAn:MonHoc
    {
        double diemGVHD, diemGVBM;
        public MonDoAn(string ma, string ten, int soTC) : base(ma, ten, soTC)
        {
        }
        public override int tinhHP()
        {
            return 2000000;
        }
        public override double tinhDiem()
        {
            return (double)(diemGVHD * 2 + diemGVBM) / 3.0;
        }
    }
}
