using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan02
{
    public class VanDongVien
    {
        private string ma, hoten;
        private int hBD, mBD, sBD;
        private int hKT, mKT, sKT;
        private int soAo;
        public static int chuan = 5400;

        public string Ma { get => ma; set => ma = value; }

        public string Hoten { get => hoten; set => hoten = value; }

        public int HBD
        {
            get { return hBD; }
            set
            {
                if (value < 0 || value > 23)
                {
                    Console.WriteLine("Du lieu sai!");
                    hBD = 0;
                }
                else hBD = value;
            }
        }

        public int MBD
        {
            get { return mBD; }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Du lieu sai!");
                    mBD = 0;
                }
                else mBD = value;
            }
        }
        public int SBD
        {
            get { return sBD; }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Du lieu sai!");
                    sBD = 0;
                }
                else sBD = value;
            }
        }

        public int HKT
        {
            get { return hKT; }
            set
            {
                if (value < 0 || value > 23)
                {
                    Console.WriteLine("Du lieu sai!");
                    hKT = 0;
                }
                else hKT = value;
            }
        }

        public int MKT
        {
            get { return mKT; }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Du lieu sai!");
                    mKT = 0;
                }
                else mKT = value;
            }
        }

        public int SKT
        {
            get { return sKT; }
            set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Du lieu sai!");
                    sKT = 0;
                }
                else sKT = value;
            }
        }

        public int SoAo { get => soAo; set => soAo = value; }

        public VanDongVien()
        {
            Ma = "";
            Hoten = "";
            hBD = 0;
            mBD = 0;
            sBD = 0;
            hKT = 0;
            mKT = 0;
            sKT = 0;
            SoAo = 0;
        }

        public VanDongVien(string ma, string hoten, int soAo, int hBD, int mBD, int sBD, int hKT, int mKT, int sKT)
        {
            this.Ma = ma;
            this.Hoten = hoten;
            this.hBD = hBD;
            this.mBD = mBD;
            this.sBD = sBD;
            this.hKT = hKT;
            this.mKT = mKT;
            this.sKT = sKT;
            this.SoAo = soAo;
        }

        public VanDongVien(VanDongVien a)
        {
            Ma = a.Ma;
            Hoten = a.Hoten;
            SoAo = a.SoAo;
            hBD = a.hBD;
            mBD = a.mBD;
            sBD = a.sBD;
            hKT = a.hKT;
            mKT = a.mKT;
            sKT = a.sKT;
        }

        public void nhap()
        {
            Console.Write("Nhap ma so: ");
            Ma = Console.ReadLine();
            Console.Write("Nhap ho ten van dong vien: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap so ao: ");
            SoAo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap thoi gian bat dau: ");
            string thoigian = Console.ReadLine();
            string[] splitBD = thoigian.Split(':');
            hBD = Convert.ToInt32(splitBD[0]);
            mBD = Convert.ToInt32(splitBD[1]);
            sBD = Convert.ToInt32(splitBD[2]);
            Console.Write("Nhap thoi gian ket thuc: ");
            thoigian = Console.ReadLine();
            string[] splitKT = thoigian.Split(':');
            hKT = Convert.ToInt32(splitKT[0]);
            mKT = Convert.ToInt32(splitKT[1]);
            sKT = Convert.ToInt32(splitKT[2]);
        }

        public void xuat()
        {
            Console.WriteLine("Ma so: {0}", Ma);
            Console.WriteLine("Ho va ten: {0}", Hoten);
            Console.WriteLine("So ao: {0}", SoAo);
            Console.WriteLine("Thoi gian bat dau: {0:00}:{1:00}:{2:00}", hBD, mBD, sBD);
            Console.WriteLine("Thoi gian ket thuc: {0:00}:{1:00}:{2:00}", hKT, mKT, sKT);
            if (ktDat() == true)
                Console.WriteLine("Dat!");
            else 
                Console.WriteLine("Khong dat!");
        }

        public int tinhGiay(int h, int m, int s)
        {
            return h * 3600 + m * 60 + s;
        }
        public int tinhThanhTich()
        {
            int sTT = tinhGiay(hKT, mKT, sKT) - tinhGiay(hBD, mBD, sBD);
            int giayTong = sTT;
            int hTT = sTT / 3600;
            sTT = sTT % 3600;
            int mTT = sTT / 60;
            sTT = sTT % 60;
            Console.WriteLine("Thanh tich cua van dong vien {0} la: {1:00}:{2:00}:{3:00}", Hoten, hTT, mTT, sTT);
            return giayTong;
        }

        public bool ktHopLe()
        {
            if (tinhGiay(hBD, mBD, sBD) < tinhGiay(hKT, mKT, sKT))
                return true;
            return false;
        }

        public bool ktDat()
        {
            if (tinhThanhTich() <= chuan)
            {
                return true;
            }
            return false;
        }
    }
}
