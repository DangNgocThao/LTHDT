using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_DangNgocThao_KT2
{
    public class KhachHangCaNhan : HoaDon, IHoTro
    {
        int kcgh;

        public int Kcgh
        {
            get { return kcgh; }
            set { kcgh = value; }
        }

        public KhachHangCaNhan()
            : base()
        {
            kcgh = 0;
        }

        public KhachHangCaNhan(string ma, string ten, int solg, double gia, int kcgh)
            : base(ma, ten, solg, gia)
        {
            this.kcgh = kcgh;
        }

        public override double tinhChietKhau()
        {
            double ck = 0;
            if (Solg >= 3)
                ck = 0.02 * Gia * Solg;
            if (kcgh < 10)
                ck += (15000 * Solg);
            return ck;
        }

        public double tinhTroGia()
        {
            double tg = Solg * 0.03 * Gia;
            if (Solg > 2)
                tg += 150000;
            return tg;
        }
    }
}
