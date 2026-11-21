using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DangNgocThao
{
    public class NhaXe
    {
        string diachi, mst;

        public string Mst
        {
            get { return mst; }
            set { mst = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        List<ChuyenXe> cacCX;

        public List<ChuyenXe> CacCX
        {
            get { return cacCX; }
            set { cacCX = value; }
        }
        public NhaXe()
        {
            cacCX = new List<ChuyenXe>();
            diachi = "";
            mst = "";
        }
        public void nhapXML(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNode nhaxeNode = read.SelectSingleNode("NhaXe");
            this.diachi = nhaxeNode["DiaChi"].InnerText;
            this.mst = nhaxeNode["MaSoThue"].InnerText;
            XmlNodeList nodeList = nhaxeNode["CacChuyenXe"].SelectNodes("ChuyenXe");
            foreach (XmlNode node in nodeList)
            {
                ChuyenXe a = new ChuyenXe();
                a.Bsx = node["BienSoXe"].InnerText;
                a.Hoten = node["HoTenTX"].InnerText;
                a.Scn = int.Parse(node["SoChoNgoi"].InnerText);
                a.Dtx = double.Parse(node["DungTichXang"].InnerText);
                a.Skm = int.Parse(node["SoKM"].InnerText);
                cacCX.Add(a);
            }
        }
        public void xuat()
        {
            Console.WriteLine("Dia chi: {0}", Diachi);
            Console.WriteLine("Ma so thue: {0}", Mst);
            foreach (ChuyenXe i in CacCX)
            {
                i.xuat();
            }
        }
        public double tinhDungTich()
        {
            return (double)CacCX.Sum(t => t.Dtx);
        }
        public void sapXep()
        {
            cacCX = cacCX.OrderBy(t => t.Skm).ThenByDescending(t => t.Scn).ToList();
        }
        public void xuatNguyen()
        {
            cacCX.Where(t => t.Hoten.StartsWith("Nguyen") == true).ToList().ForEach(t => t.xuat());
        }
    }
}
