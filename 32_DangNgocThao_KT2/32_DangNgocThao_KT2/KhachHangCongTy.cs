using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_DangNgocThao_KT2
{
    public class KhachHangCongTy : HoaDon, IHoTro
    {
        int slNV;

        public int SlNV
        {
            get { return slNV; }
            set { slNV = value; }
        }

        public KhachHangCongTy()
            : base()
        {
            slNV = 0;
        }

        public KhachHangCongTy(string ma, string ten, int solg, double gia, int slNV)
            : base(ma, ten, solg, gia)
        {
            this.slNV = slNV;
        }

        public override double tinhChietKhau()
        {
            double t = 0;
            if (slNV > 1500)
                t = 0.03;
            if (slNV > 6000)
                t = 0.05;
            return t * Gia;
        }


        public double tinhTroGia()
        {
            return Solg * 120000;
        }
    }
}
