using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _32_2001206904_DangNgocThao_Tuan04
{
    public class CongTy
    {
        List<NhanVien> ds;
        public CongTy()
        {
            ds = new List<NhanVien>();
        }
        public bool tim(string ma)
        {
            return (ds.Find(x => x.Ma.Equals(ma) == true) != null ? true : false);
        }
        public void them(NhanVien a)
        {
            if (tim(a.Ma) == true) //true la !=null
                return;
            ds.Add(a);
        }
        public void XmlFile(string filename)
        {
            XmlDocument reader = new XmlDocument();
            reader.Load(filename);
            XmlNodeList nodelist = reader.SelectNodes("congty/nhanvien");
            foreach (XmlNode node in nodelist)
            {
                NhanVien x = new NhanVien();
                x.Ma = node["ma"].InnerText;
                x.Ten = node["ten"].InnerText;
                x.PhongBan = node["phongban"].InnerText;
                x.ChucVu = node["chucvu"].InnerText;
                x.HeSoLuong = double.Parse(node["hesoluong"].InnerText);
                x.ThamNien = int.Parse(node["thamnien"].InnerText);
                x.SoNgayLam = int.Parse(node["songaylam"].InnerText);
                them(x);
            }
        }
        public void doc()
        {
            XmlDocument reader = new XmlDocument();
            reader.Load("congty.xml");
            XmlNodeList nodeList = reader.SelectNodes("congty/nhanvien");
            foreach (XmlNode node in nodeList)
            {
                NhanVien x = new NhanVien();
                x.Ma = node["ma"].InnerText;
                x.Ten = node["ten"].InnerText;
                x.PhongBan = node["phongban"].InnerText;
                x.ChucVu = node["chucvu"].InnerText;
                x.HeSoLuong = double.Parse(node["hesoluong"].InnerText);
                x.ThamNien = int.Parse(node["thamnien"].InnerText);
                x.SoNgayLam = int.Parse(node["songaylam"].InnerText);
                them(x);
            }
        }
        public void xuat()
        {
            foreach (NhanVien x in ds)
                Console.WriteLine(x);
        }
        public void xuat_hesodua()
        {
            ds = ds.OrderBy(x => x.tinh_heSoThiDua()).ToList();
            xuat();
        }
        public List<NhanVien> Lay_theo_phong(string phong)
        {
            ds = ds.Where(x => x.PhongBan.Equals(phong) == true).ToList();
            xuat();
            return ds;
        }
        public List<NhanVien> lay_chucvu()
        {
            ds = ds.Where(x => x.ChucVu.Equals("LanhDao") == true).ToList();
            xuat();
            return ds;
        }
        public double tinh_tongluong()
        {
            return ds.Sum(x => x.tinh_Luong());
        }
        public void xoads()
        {
            ds.RemoveAll(x => x.SoNgayLam < 10);
        }
        public List<NhanVien> Lay_kolanhdao_lonhon22()
        {
            ds = ds.Where(x => (x.ChucVu.Equals("LanhDao") == false && x.SoNgayLam > 22)).ToList();
            return ds;
        }
        public List<NhanVien> Lay_TaiVu()
        {
            return ds.Where(x => (x.PhongBan.Equals("TaiVu") == true && x.HeSoLuong > 4.34)).ToList();
        }

    }
}
