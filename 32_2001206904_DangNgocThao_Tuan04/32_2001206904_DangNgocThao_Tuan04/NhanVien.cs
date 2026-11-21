using System;
using System.Collections.Generic;
using System.Text;

namespace _32_2001206904_DangNgocThao_Tuan04
{
    public class NhanVien
    {
        string ma, ten, phongBan, chucVu;
        double heSoLuong;
        int thamNien, soNgayLam;
        static int luongCoBan = 1210;

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int SoNgayLam { get => soNgayLam; set => soNgayLam = value; }
        public int ThamNien { get => thamNien; set => thamNien = value; }

        public double tinh_heSoThiDua()
        {
            double kq = 1;
            if (ChucVu.Equals("NhanVien") == true)
            {
                if (SoNgayLam > 22)
                    kq = 1;
                else if (SoNgayLam > 20)
                    kq = 0.8;
                else kq = 0.6;
            }
            return kq;
        }
        public int tinh_PhuCap()
        {
            int kq = 0;
            if (ChucVu.Equals("LanhDao") == true)
                kq = 2000;
            return kq;
        }
        public double tinh_Luong()
        {
            return HeSoLuong * NhanVien.luongCoBan * tinh_heSoThiDua() + 1100 + tinh_PhuCap();
        }
        public override string ToString()
        {
            return string.Format("Ma:{0}. Ten:{1}. PhongBan:{2}. ChucVu:{3}. HeSoLuong:{4}. ThamNien:{5}. SoNgayLam:{6}. HSTD:{7}. PhuCap:{8}. Luong:{9}",
                Ma, Ten, PhongBan, ChucVu, HeSoLuong, ThamNien, SoNgayLam, tinh_heSoThiDua(), tinh_PhuCap(), tinh_Luong());
        }
    }
}
