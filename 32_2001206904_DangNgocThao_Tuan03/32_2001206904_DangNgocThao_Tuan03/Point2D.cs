using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan03
{
    public class Point2D
    {
        int x, y;

        public int Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Du lieu sai");
                else y = value;
            }
        }

        public int X
        {
            get { return x; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Du lieu sai");
                else x = value;
            }
        }
        public Point2D()
        {
            x = y = 0;
        }
        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point2D(Point2D a)
        {
            this.x = a.x;
            this.y = a.y;
        }
        public void nhap()
        {
            Console.Write("Nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("({0};{1})", x, y);
        }
        public bool ktThuocOx()
        {
            if (y == 0)
                return true;
            else
                return false;
        }
        public bool ktThuocOy()
        {
            if (x == 0)
                return true;
            else
                return false;
        }
        public void thayDoiViTri(int tx, int ty)
        {
            x += tx;
            y += ty;
        }
        public void thayDoiViTri(Point2D a)
        {
            x += a.x;
            y += a.y;
        }
        public float tinhKhoangCach()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }
        public float tinhKhoangCach(Point2D a)
        {
            return (float)Math.Sqrt(Math.Pow(this.x - a.x, 2) + Math.Pow(this.y - a.y, 2));
        }
        public Point2D timDXQuaOx()
        {
            return new Point2D(x, -y);
        }
        public Point2D timDXQuaOy()
        {
            return new Point2D(-x, y);
        }
        public bool ktSSOx(Point2D a)
        {
            if (this.y == a.y)
                return true;
            return false;
        }
        public bool ktSSOy(Point2D a)
        {
            if (this.x == a.x)
                return true;
            return false;
        }
        public bool ktQuaGoc(Point2D a)
        {
            if ((this.y - a.y) * (-this.x) + (a.x - this.x) * (-this.y) == 0)
                return true;
            return false;
        }
    }
}
