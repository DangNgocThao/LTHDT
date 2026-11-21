using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNgocThao
{
    public class ChuyenXe
    {
        string bsx, hoten;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public string Bsx
        {
            get { return bsx; }
            set
            {
                if (value.Length == 10 && value.StartsWith("59-"))
                    bsx = value;
                else
                    bsx = "59-0000000";
            }
        }
        int scn, skm;

        public int Skm
        {
            get { return skm; }
            set
            {
                if (value < 50) skm = 50;
                else skm = value;
            }
        }

        public int Scn
        {
            get { return scn; }
            set
            {
                if (value < 16) scn = 16;
                else scn = value;
            }
        }
        double dtx;

        public double Dtx
        {
            get { return dtx; }
            set
            {
                if (value < 10) dtx = 10;
                else dtx = value;
            }
        }
        string ttdk = "TPHCM";

        public string Ttdk
        {
            get { return ttdk; }
            set { ttdk = value; }
        }
        public ChuyenXe()
        {
            bsx = "59-0000000";
            hoten = "";
            scn = 16;
            dtx = 10;
            skm = 50;
        }
        public ChuyenXe(string bsx, string hoten, int scn, double dtx, int skm)
        {
            this.bsx = bsx;
            this.hoten = hoten;
            this.scn = scn;
            this.dtx = dtx;
            this.skm = skm;
        }
        public ChuyenXe(ChuyenXe a)
        {
            this.bsx = a.Bsx;
            this.hoten = a.Hoten;
            this.scn = a.Scn;
            this.dtx = a.Dtx;
            this.skm = a.Skm;
        }
        public void xuat()
        {
            Console.WriteLine("{0}, {1}, so cho ngoi: {2}, dung tich xang: {3}, so km: {4}, {5}", Bsx, Hoten, Scn, Dtx, Skm, Ttdk);
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, so cho ngoi: {2}, dung tich xang: {3}, so km: {4}, {5}", Bsx, Hoten, Scn, Dtx, Skm, Ttdk);
        }
        public void ktLoTrinhDai()
        {
            if (Skm > 80)
                Console.WriteLine("Lo trinh dai");
            else
                Console.WriteLine("Khong phai lo trinh dai");
        }
    }
}
