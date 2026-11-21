using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan03
{
    public class TinhTienDien
    {
        string ten, ma;

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        int chiSoM, chiSoC;

        public int ChiSoC
        {
            get { return chiSoC; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Du lieu sai");
                else chiSoC = value;
            }
        }

        public int ChiSoM
        {
            get { return chiSoM; }
            set
            {
                if (value < 0 || value < chiSoC)
                    Console.WriteLine("Du lieu sai");
                else chiSoM = value;
            }
        }
        public static int dm = 200;
        public static float dgdm = 15000;

        public TinhTienDien()
        {
            ten = "";
            ma = "";
            chiSoM = 0;
            chiSoC = 0;
        }
        public TinhTienDien(string ten, string ma, int chiSoM, int chiSoC)
        {
            this.ten = ten;
            this.ma = ma;
            this.chiSoM = chiSoM;
            this.chiSoC = chiSoC;
        }
        public TinhTienDien(TinhTienDien a)
        {
            this.ten = a.ten;
            this.ma = a.ma;
            this.chiSoM = a.chiSoM;
            this.chiSoC = a.chiSoC;
        }
        public void nhap()
        {
            Console.Write("Ho ten chu ho: ");
            ten = Console.ReadLine();
            Console.Write("Ma so cong to dien: ");
            ma = Console.ReadLine();
            Console.Write("Chi so cu: ");
            chiSoC = Convert.ToInt32(Console.ReadLine());
            Console.Write("Chi so moi: ");
            chiSoM = Convert.ToInt32(Console.ReadLine());
        }
        public float tinh()
        {
            int sd = chiSoM - chiSoC;
            if (sd < dm)
                return sd * dgdm;
            else
                return (float)(dm * dgdm + (sd - dm) * dgdm * 1.5);

        }
        public void xuat()
        {
            Console.WriteLine("Ho ten chu ho: {0}", ten);
            Console.WriteLine("Ma so cong to dien: {0}", ma);
            Console.WriteLine("Chi so cu: {0}", chiSoC);
            Console.WriteLine("Chi so moi: {0}", chiSoM);
            Console.WriteLine("Tien Dien: {0:0.00}", tinh());
        }
    }
}
