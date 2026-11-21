using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _32_2001206904_DangNgocThao_Tuan04
{
    public class dsToaDo
    {
        List<ToaDo> ds;
        public dsToaDo()
        {
            ds = new List<ToaDo>();
        }
        public ToaDo tim(ToaDo a)
        {
            return ds.Find(x => x.X == a.X && x.Y == a.Y);
        }
        public void themToaDo(ToaDo a)
        {
            if (tim(a) == null)
            {
                ds.Add(a);
                return;
            }
            Console.WriteLine("Toa do da ton tai");
        }
        public void xuat()
        {
            foreach (ToaDo x in ds)
                Console.WriteLine(x);
        }
        public void LoadXMLfile(string filename)
        {
            try
            {
                XmlDocument reader = new XmlDocument();
                reader.Load(filename);
                XmlNodeList nodelist = reader.SelectNodes("dsDiem/diem");
                foreach (XmlNode node in nodelist)
                {
                    ToaDo a = new ToaDo();
                    a.X = int.Parse(node["x"].InnerText);
                    a.Y = int.Parse(node["y"].InnerText);
                    themToaDo(a);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void sort_asc()
        {
            ds = ds.OrderByDescending(x => x.tinh_khoangcach()).ThenByDescending(x => x.X).ToList();
        }
        public List<ToaDo> Lay_trong_O()
        {
            return ds.Where(x => x.tinh_khoangcach() < 1).ToList();
        }
        public List<ToaDo> Lay_mot_phan_tu()
        {
            return ds.Where(x => x.X > 0 && x.Y > 0).ToList();
        }
        public void xoa()
        {
            ds.RemoveAll(x => x.X > 5 && x.X < 8);
        }
    }
}
