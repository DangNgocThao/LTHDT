using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan06
{
    public class CBLanhDao : NhanVienB4
    {
        string chucVu;
        int thamNien;
        public CBLanhDao()
            : base("NV009", "DieuHien", 4.67)
        {
            this.chucVu = "Giam doc";
            this.thamNien = 10;
        }
        public override double thunhap()
        {
            if (chucVu == "Giam doc")
                return base.thunhap() + 1500 * 7.0;
            else if (chucVu == "truong phong")
                return base.thunhap() + 1500 * 6.0;
            else if (chucVu == "pho phong")
                return base.thunhap() + 1500 * 4.5;
            else
                return base.thunhap() + 1500 * 1.0;
        }
        public override void xuat()
        {
            Console.WriteLine("Chuc vu: {0}", this.chucVu);
            base.xuat();
        }
    }
}
