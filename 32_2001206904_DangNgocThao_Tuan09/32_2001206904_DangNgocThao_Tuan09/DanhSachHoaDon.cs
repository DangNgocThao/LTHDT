using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _32_2001206904_DangNgocThao_Tuan09
{
    public class DanhSachHoaDon
    {
        private List<HoaDon> dsHoaDon = new List<HoaDon>();

        public void loadXMLFile(string tenFile)
        {
            try
            {
                XmlDocument reader = new XmlDocument();
                reader.Load(tenFile);
                XmlNode dsHDNode = reader.SelectSingleNode("DanhSachHoaDon");
                XmlNodeList nodeList = dsHDNode.SelectNodes("HoaDon");

                HoaDon hd = null;
                foreach (XmlNode node in nodeList)
                {
                    string maHD = node["MaHD"].InnerText;
                    DateTime ngayLap = DateTime.ParseExact(node["NgayLap"].InnerText, "dd/MM/yyyy", null);

                    HangHoa hangHoa = getHangHoaFromXmlNode(node["HangHoa"]);
                    //HangHoa hangHoa = new HangHoa();
                    //XmlNode hangNode = node.SelectSingleNode("HangHoa");
                    //hangHoa.MaHH = hangNode["MaHH"].InnerText;
                    //hangHoa.TenHH = hangNode["TenHH"].InnerText;
                    //hangHoa.DonGia = double.Parse(hangNode["DonGia"].InnerText);

                    int soLuong = int.Parse(node["SoLuong"].InnerText);
                    int loai = int.Parse(node["Loai"].InnerText);
                    if (loai == 3)
                    {
                        hd = new HoaDonVangLai(maHD, ngayLap, hangHoa, soLuong);
                    }
                    else 
                    {
                        string tenKH = node["TenKH"].InnerText;

                        if (loai == 1)
                            hd = new HoaDonVIP(maHD, tenKH, ngayLap, hangHoa, soLuong);
                        else
                            hd = new HoaDonThanThiet(maHD, tenKH, ngayLap, hangHoa, soLuong);
                    }
                    dsHoaDon.Add(hd);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private HangHoa getHangHoaFromXmlNode(XmlNode node)
        {
            string maHH = node["MaHH"].InnerText;
            string tenHH = node["TenHH"].InnerText;
            double donGia = double.Parse( node["DonGia"].InnerText);
            return new HangHoa(maHH, tenHH, donGia);
        }

        public void xuat()
        {
            foreach (HoaDon hd in dsHoaDon)
            {
                hd.xuat();
            }
        }

        //Cau 3
        public void xuatHDVangLai()
        {
            foreach (HoaDon hd in dsHoaDon)
            {
                if (hd is HoaDonVangLai)
                    hd.xuat();
            }

            
        }

        //Cau 4
        public double TinhTongTienCacHoaDon()
        {
            double tongTien = 0.0;
            foreach (HoaDon hd in dsHoaDon)
            {
                tongTien += hd.TinhTongThanhTien();
            }
            return tongTien;
        }

        //Cau 5
        public HoaDon TimHDCoTongTienCaoNhat ()
        {
            return dsHoaDon.OrderByDescending(t => t.TinhTongThanhTien()).First();            
        }

        //Cau 6
        public int DemSoHDKhachVIP()
        {
            return dsHoaDon.Count(t => t is HoaDonVIP);
        }
        public int DemSoHDKhachThanThiet()
        {
            return dsHoaDon.Count(t => t is HoaDonThanThiet);
        }
        public double TongTamUngCuaKhach(string tenKH)
        {
            double tongTU = 0.0;
            foreach (HoaDon hd in dsHoaDon)
            {

                if (hd is IHoTro && hd.TenKH.Equals(tenKH))
                {
                    IHoTro phiHoTro = (IHoTro)hd;
                    tongTU = phiHoTro.TinhThanhToanTamUng();
                }
            }
            return tongTU;
        }
    }
}
