using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _32_2001206904_DangNgocThao_Tuan08
{
    public class DSBatDongSan
    {
        List<BatDongSan> ds = new List<BatDongSan>();
        public void nhap(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList nodelist = read.SelectNodes("/BDSs/BDS");
            foreach (XmlNode node in nodelist)
            {
                BatDongSan bds;
                int loai = Convert.ToInt32(node["Loai"].InnerText);
                string ma = node["Ma"].InnerText;
                double d = Convert.ToDouble(node["Dai"].InnerText);
                double r = Convert.ToDouble(node["Rong"].InnerText);
                if (loai == 1)
                {
                    int so = Convert.ToInt32(node["So"].InnerText);
                    bds = new NhaO(ma, d, r, so);
                }
                else if (loai == 2)
                    bds = new DatTrong(ma, d, r);
                else if (loai == 3)
                    bds = new BietThu(ma, d, r);
                else
                {
                    int so = Convert.ToInt32(node["So"].InnerText);
                    bds = new KhachSan(ma, d, r, so);
                }
                ds.Add(bds);
            }
        }
        public void xuat()
        {

        }
    }
}
