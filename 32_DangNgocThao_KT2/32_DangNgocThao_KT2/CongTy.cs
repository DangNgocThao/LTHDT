using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _32_DangNgocThao_KT2
{
    public class CongTy
    {
        string ten, sdt, diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        List<HoaDon> dsHD = new List<HoaDon>();

        public List<HoaDon> DsHD
        {
            get { return dsHD; }
            set { dsHD = value; }
        }

        public void nhap(string file)
        {
            try
            {
                XmlDocument read = new XmlDocument();
                read.Load(file);
                XmlNode ttNode = read.SelectSingleNode("ThongTin");
                ten = ttNode["TenCongTy"].InnerText;
                sdt = ttNode["SoDienThoai"].InnerText;
                diaChi = ttNode["DiaChi"].InnerText;
                XmlNodeList node = ttNode["DS"].SelectNodes("HoaDon");
                foreach (XmlNode i in node)
                {
                    HoaDon a = xuLyNode(i);
                    if (a != null)
                        dsHD.Add(a);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public HoaDon xuLyNode(XmlNode node)
        {
            HoaDon a = null;
            int loai = int.Parse(node.Attributes["Loai"].Value);
            string ma = node["Ma"].InnerText;
            string ten = node["Ten"].InnerText;
            int sl = int.Parse(node["SoLuong"].InnerText);
            double gia = double.Parse(node["DonGia"].InnerText);
            if (loai == 1)
            {
                int kc = int.Parse(node["KhoangCach"].InnerText);
                a = new KhachHangCaNhan(ma, ten, sl, gia, kc);
            }
            if (loai == 2)
            {
                int tg = int.Parse(node["ThoiGian"].InnerText);
                a = new DaiLyCap1(ma, ten, sl, gia, tg);
            }
            if (loai == 3)
            {
                int slNV = int.Parse(node["SoNV"].InnerText);
                a = new KhachHangCongTy(ma, ten, sl, gia, slNV);
            }
            return a;
        }
        public void xuat()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Ten Cong ty: {0}", ten);
            Console.WriteLine("So dien thoai: {0}", sdt);
            Console.WriteLine("Dia Chi: {0}", diaChi);
            foreach (HoaDon i in dsHD)
            {
                i.xuat();
            }
        }
        public double tinhTongThanhTien()
        {
            double t = 0;
            foreach (HoaDon i in dsHD)
            {
                t += i.tinhThanhTien();
            }
            return t;
        }
        public double tinhTongTroGia()
        {
            return dsHD.Where(t => t is IHoTro).Sum(t => ((IHoTro)t).tinhTroGia());
        }
        public HoaDon slMuaItNhat()
        {
            int sl = dsHD.Min(t => t.Solg);
            foreach (HoaDon i in dsHD)
                if (i.Solg == sl)
                    return i;
            return null;
        }
        public double tinhTongChietKhau()
        {
            return dsHD.Where(t => t is KhachHangCongTy).Sum(t => t.tinhChietKhau());
        }
        public void xuatDLC1()
        {
            int kq = dsHD.Where(t => t is DaiLyCap1).ToList().Count;
            Console.WriteLine("Tong dai li cap 1: {0}", kq);
            dsHD.Where(t => t is DaiLyCap1).ToList().ForEach(t => t.xuat());
        }
        public void sapxep()
        {
            dsHD.OrderByDescending(t => t.Solg).ThenByDescending(t => t.tinhThanhTien()).ToList().ForEach(t => t.xuat());
        }
    }
}
