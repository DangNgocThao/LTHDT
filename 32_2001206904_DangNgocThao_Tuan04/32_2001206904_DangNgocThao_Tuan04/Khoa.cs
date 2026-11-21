using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _32_2001206904_DangNgocThao_Tuan04
{
    public class Khoa
    {
        private string tenKhoa;
        private List<GiaoVien> dsGiaoVien;
        public Khoa()
        {
            this.tenKhoa = "";
            this.dsGiaoVien = new List<GiaoVien>();
        }
        public Khoa(string tenKhoa)
        {
            this.tenKhoa = tenKhoa;
            this.dsGiaoVien = new List<GiaoVien>();
        }
        public GiaoVien tim(string ma)
        {
            //foreach (GiaoVien gv in dsGiaoVien)
            //{
            // if (gv.Ma == ma)
            // return gv;
            //}
            //return null;
            return dsGiaoVien.Find(t => t.Ma == ma);
        }
        public void them(GiaoVien a)
        {
            GiaoVien gv = tim(a.Ma);
            if (gv != null)
            {
                Console.WriteLine("Ma giao vien da ton tai!");
                return;
            }
            dsGiaoVien.Add(a);
        }
        public void xuat()
        {
            Console.WriteLine("TenKhoa: " + tenKhoa);
            foreach (GiaoVien gv in dsGiaoVien)
            {
                //Console.WriteLine(gv);
                gv.xuat();
            }
        }
        public void loadXMLFile(string fileName)
        {
            XmlDocument reader = new XmlDocument();
            try
            {
                reader.Load(fileName);
                XmlNode khoaNode = reader.SelectSingleNode("Khoa");
                this.tenKhoa = khoaNode["TenKhoa"].InnerText;
                //XmlNodeList nodeList =
                khoaNode.SelectSingleNode("DanhSachGiaoVien").SelectNodes("GiaoVien");
                XmlNodeList nodeList = khoaNode["DanhSachGiaoVien"].SelectNodes("GiaoVien");
                //XmlNodeList nodeList =
                khoaNode.SelectNodes("DanhSachGiaoVien/GiaoVien");
                foreach (XmlNode node in nodeList)
                {
                    string ma = node["Ma"].InnerText;
                    string hoTen = node["HoTen"].InnerText;
                    bool gioiTinh = bool.Parse(node["GioiTinh"].InnerText);
                    DateTime ngaySinh = DateTime.ParseExact(node["NgaySinh"].InnerText, "dd/MM/yyyy", null);
                    int soNhom = int.Parse(node["SoNhom"].InnerText);
                    GiaoVien gv = new GiaoVien(ma, hoTen, gioiTinh, ngaySinh, soNhom);
                    them(gv);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public int demSLGV()
        {
            return dsGiaoVien.Count;
        }
        public int demSoNhom()
        {
            int count = 0;
            foreach (GiaoVien gv in dsGiaoVien)
            {
                count += gv.SoNhom;
            }
            return count;//return dsGiaoVien.Sum(t => t.SoNhom);
        }
        public void sapXepSoNhomTang()
        {
            dsGiaoVien = dsGiaoVien.OrderBy(t => t.SoNhom).ToList();
        }
        public void sapXepSoNhomGiam_MaTang()
        {
            dsGiaoVien = dsGiaoVien.OrderByDescending(t =>
            t.SoNhom).ThenBy(t => t.Ma).ToList();
        }
        public List<GiaoVien> locGVNam()
        {
            return dsGiaoVien.Where(t => t.GioiTinh == true).ToList();
        }
    }
}
