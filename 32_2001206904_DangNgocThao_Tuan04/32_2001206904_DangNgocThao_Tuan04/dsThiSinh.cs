using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _32_2001206904_DangNgocThao_Tuan04
{
    public class dsThiSinh
    {
        List<ThiSinh> dsts;

        public List<ThiSinh> Dsts { get => dsts; set => dsts = value; }
        public dsThiSinh()
        {
            this.Dsts = new List<ThiSinh>();
        }
        public void nhap()
        {
            Console.Write("Nhap so thi sinh: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ThiSinh a = new ThiSinh();
                Console.WriteLine("Nhap thong tin thi sinh");
                a.nhap();
                Dsts.Add(a);
            }
        }
        public void nhapXML(string fileName)
        {
            try
            {
                XmlDocument read = new XmlDocument();
                read.Load(fileName);
                XmlNodeList nodeList = read.SelectNodes("/DSSV/ThiSinh");
                foreach (XmlNode node in nodeList)
                {
                    ThiSinh a = new ThiSinh();
                    a.Sbd = node["SBD"].InnerText;
                    a.Ten = node["HT"].InnerText;
                    a.Nams = int.Parse(node["NamSinh"].InnerText);
                    a.Toan = double.Parse(node["Toan"].InnerText);
                    a.Van = double.Parse(node["Van"].InnerText);
                    a.Ngoaingu = double.Parse(node["NN"].InnerText);
                    dsts.Add(a);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void xuat()
        {
            foreach (ThiSinh i in Dsts)
            {
                i.xuat();
            }
        }
        public void xepTheoDiemGiam()
        {
            Dsts = Dsts.OrderByDescending(t => t.Tong).ToList();
        }
        public void sortDieuKien()
        {
            Dsts = Dsts.OrderBy(t => t.Ten).ThenByDescending(t => t.Toan).ToList();
        }
        public void dsDau()
        {
            foreach (ThiSinh a in Dsts)
            {
                if (a.Ketqua == "Dau")
                    a.xuat();
            }
        }
        public void ThiSinh1995ORToan9()
        {
            foreach (ThiSinh a in Dsts)
            {
                if (a.Nams > 1995 || a.Toan > 90)
                    a.xuat();
            }
        }
    }
}
