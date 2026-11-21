using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Chuong3
{
    public class TaiKhoan
    {
        private string ma;
        private string tenChuTK;
        private double soDuTK;
        public bool napTien(double soTien)
        {
            soDuTK = soDuTK + soTien;
            return true;
        }
        public bool rutTien(double soTien)
        {
            if (soTien > soDuTK)
                return false;
            soDuTK = soDuTK - soTien;
            return true;
        }
    }
}
