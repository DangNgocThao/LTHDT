using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_THHDT_LeThanhNam
{
    public class TinhTienDien
    {
        string ten, maso;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        double chiSoCu, chiSoMoi;
        static int dinhMuc = 200;
        static double donGiaDinhMuc = 1500.0f;
        double soDien;
        public TinhTienDien(string ten, string maso, double chiSoCu, double chiSoMoi)
        {
            this.ten = ten;
            this.maso = maso;
            this.chiSoCu = chiSoCu;
            this.chiSoMoi = chiSoMoi;
            soDien = chiSoMoi - chiSoCu;
        }
        public double SoDien
        {
            get { return chiSoMoi-chiSoCu; }
            set 
            {
                value = chiSoMoi - chiSoCu;
                soDien = value;
            }
        }
        public double TinhTien()
        {
            if (soDien <= TinhTienDien.dinhMuc)
                return soDien * TinhTienDien.donGiaDinhMuc;
            return soDien * TinhTienDien.donGiaDinhMuc * 1.5f;
        }
        public override string ToString()
        {
            return string.Format("Ten: {0}. ChiSoCu: {1}. ChiSoMoi: {2}. SoDien:{3}. TienDien:{4}", ten, chiSoCu, chiSoMoi, soDien, TinhTien());
        }
    }
}
