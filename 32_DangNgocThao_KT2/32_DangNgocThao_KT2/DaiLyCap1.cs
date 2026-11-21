using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_DangNgocThao_KT2
{
    public class DaiLyCap1 : HoaDon
    {
        int tght;

        public int Tght
        {
            get { return tght; }
            set { tght = value; }
        }

        public DaiLyCap1()
            : base()
        {
            tght = 0;
        }

        public DaiLyCap1(string ma, string ten, int solg, double gia, int tght)
            : base(ma, ten, solg, gia)
        {
            this.tght = tght;
        }

        public override double tinhChietKhau()
        {
            double ck = 0.3 * Gia;
            if (tght > 3)
            {
                if (tght >= 25)
                    ck += (ck * 0.25);
                else
                    ck += (ck * tght);
            }
            return ck;
        }
    }
}
