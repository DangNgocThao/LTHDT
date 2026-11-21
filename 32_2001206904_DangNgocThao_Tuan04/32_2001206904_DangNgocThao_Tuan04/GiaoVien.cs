using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan04
{
    public class GiaoVien
    {
        private string ma, hoTen;
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        private bool gioiTinh;
        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private DateTime ngaySinh;
        private int soNhom;
        public int SoNhom
        {
            get { return soNhom; }
            set { soNhom = value; }
        }
        public GiaoVien()
        {
            this.ma = "";
            this.hoTen = "";
            this.gioiTinh = true;
            this.ngaySinh = DateTime.Now;
            this.soNhom = 0;
        }
        public GiaoVien(string ma, string hoTen, bool gioiTinh, DateTime ngaySinh, int soNhom)
        {
            this.ma = ma;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.soNhom = soNhom;
        }
        public override string ToString()
        {
            string gt = (gioiTinh == true) ? "Nam" : "Nu";
            string ns = string.Format("{0}/{1}/{2}", ngaySinh.Day, ngaySinh.Month, ngaySinh.Year);
            return string.Format("{0},{1},{2},{3},{4}", ma, hoTen, gt, ns, soNhom);
        }
        public void xuat()
        {
            string gt = (gioiTinh == true) ? "Nam" : "Nu";
            string ns = string.Format("{0}/{1}/{2}", ngaySinh.Day, ngaySinh.Month, ngaySinh.Year);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", ma, hoTen, gt, ns, soNhom);
        }
    }
}
