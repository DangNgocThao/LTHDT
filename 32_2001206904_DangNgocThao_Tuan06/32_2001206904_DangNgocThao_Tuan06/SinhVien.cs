using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan06
{
    public class SinhVien : Nguoi
    {
        string maSV, heDaoTao;
        int tongTinChi;

        public string MaSV { get => maSV; set => maSV = value; }
        public string HeDaoTao { get => heDaoTao; set => heDaoTao = value; }
        public int TongTinChi { get => tongTinChi; set => tongTinChi = value; }

        public SinhVien(string ten, DateTime ngaySinh, string gioiTinh, string maSV, string heDaoTao)
            : base(ten, ngaySinh, gioiTinh)
        {
            this.maSV = maSV;
            if (heDaoTao != "cao dang" && heDaoTao != "cao dang nghe")
                this.HeDaoTao = "dai hoc";
            else this.HeDaoTao = heDaoTao;
            if (this.HeDaoTao == "dai hoc")
                TongTinChi = 150;
            else if (this.HeDaoTao == "cao dang")
                TongTinChi = 100;
            else TongTinChi = 130;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Ma so sinh vien: {0}\nHe dao tao: {1}\nTong so tin chi: {2}", this.MaSV, this.HeDaoTao, this.TongTinChi);
        }
        public double tinhHocPhi()
        {
            if (HeDaoTao.Equals("dai hoc") == true)
                return TongTinChi * 200000.0;
            else if (HeDaoTao.Equals("cao dang") == true)
                return TongTinChi * 150000.0;
            else return TongTinChi * 120000.0;
        }
    }
}