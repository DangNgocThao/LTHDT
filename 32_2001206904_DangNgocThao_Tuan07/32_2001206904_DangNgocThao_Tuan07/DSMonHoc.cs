using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public class DSMonHoc
    {
        List<MonHoc> dsMonHoc = new List<MonHoc>();
        public void nhap(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList nodelist = read.SelectNodes("/Monhocs/MH");
            foreach (XmlNode node in nodelist)
            {
                MonHoc t;
                string loai = node["Loai"].InnerText;
                string ma = node["Ma"].InnerText;
                string ten = node["Ten"].InnerText;
                int soTC = int.Parse(node["SoTc"].InnerText);
                if (loai == "LT")
                    t = new MonLyThuyet(ma, ten, soTC);
                else if (loai == "TH")
                    t = new MonThucHanh(ma, ten, soTC);
                else
                    t = new MonDoAn(ma, ten, soTC);
                dsMonHoc.Add(t);
            }
        }
        public void xuat()
        {
            Console.WriteLine("{0,-10}{1,-30}{2}", "Ma", "Ten", "So tin chi");
            foreach (MonHoc i in dsMonHoc)
            {
                i.xuat();
            }
        }
    }
}
