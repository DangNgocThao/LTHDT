using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan03
{
    public class SoPhuc
    {
        float thuc;
        public float Thuc
        {
            get { return thuc; }
            set { thuc = value; }
        }
        float ao;
        public float Ao
        {
            get { return ao; }
            set { ao = value; }
        }
        public SoPhuc()
        {
            thuc = ao = 1;
        }
        public SoPhuc(float a, float b)
        {
            this.thuc = a; this.ao = b;
        }
        public SoPhuc(SoPhuc z)
        {
            this.thuc = z.Thuc;
            this.ao = z.Ao;
        }
        public void nhapSP()
        {
            Console.Write("Nhap phan thuc: ");
            thuc = float.Parse(Console.ReadLine());
            Console.Write("Nhap phan ao: ");
            ao = float.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return string.Format("{0:0.00} + {1:0.00}i", thuc, ao);
        }
        public void xuatSP()
        {
            Console.Write("z= {0:0.00} + {1:0.00}", thuc, ao);
        }
        public SoPhuc cong2SP(SoPhuc x)
        {
            return new SoPhuc(thuc + x.thuc, ao + x.ao);
        }
        public bool soSanhBang(SoPhuc x)
        {
            return (thuc == x.thuc && ao == x.ao);
        }

        public static SoPhuc operator +(SoPhuc x, SoPhuc y)
        {
            return new SoPhuc(x.thuc + y.Thuc, x.ao + y.Ao);
        }
        public static bool operator ==(SoPhuc x, SoPhuc y)
        {
            return (x.Thuc == y.Thuc && x.Ao == y.Ao);
        }
        public static bool operator !=(SoPhuc x, SoPhuc y)
        {
            return (x.Thuc != y.Thuc || x.Ao != y.Ao);
        }
    }
}
