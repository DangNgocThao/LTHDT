using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan06
{
    public class NuocGiaiKhat : HangHoa
    {
        string dvt;
        int solg;
        double dongia;
        static double tlck = 1.25;
        public NuocGiaiKhat(string maH, string tenH, string dvt, int solg, double dongia)
            : base(maH, tenH)
        {
            if (dvt != "thung" && dvt != "chai" && dvt != "lon")
                this.dvt = "ket";
            else this.dvt = dvt;
            this.solg = solg;
            this.dongia = dongia;
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Don vi tinh: {0}", dvt);
            Console.WriteLine("So luong: {0}", solg);
            Console.WriteLine("Don gia: {0}", dongia);
        }
        public double tinhTien()
        {
            double t = solg * dongia * tlck;
            if (dvt == "chai") return t / 20.0;
            if (dvt == "lon") return t / 24.0;
            return t;
        }
    }
}
