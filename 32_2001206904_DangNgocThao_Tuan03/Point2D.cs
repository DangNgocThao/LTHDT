using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_THHDT_LeThanhNam
{
    public class Point2D
    {
        int x, y;
        #region constructor
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        #endregion
        public Point2D(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        ~Point2D() { }
        public int KT_OxOy()
        {
            if (x == 0 && y == 0)
                return 0;
            if (y == 0)
                return 1;
            if (x == 0)
                return 2;
            return 3;
        }
        public void thayDoiViTri(int x,int y)
        {
            this.x += x;
            this.y += y;
        }
        public void thayDoiViTri(Point2D a)
        {
            this.x += a.x;
            this.y += a.y;
        }
        public double TinhKhoangCach()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public double TinhKhoangCach(Point2D a)
        {
            return Math.Sqrt(Math.Pow(a.x - x, 2) + Math.Pow(a.y - y, 2));
        }
        public Point2D tim_DX_Ox()
        {
            return new Point2D(this.x, -this.y);
        }
        public Point2D tim_DX_Oy()
        {
            return new Point2D(-this.x,this.y);
        }
        public bool KT_SongSong_0x(Point2D a)
        {
            if (this.y == a.y)
                return true;
            return false;
        }
        public bool KT_SongSong_0y(Point2D a)
        {
            if (this.x == a.x)
                return true;
            return false;
        }
        public bool KT_Goc_O(Point2D a)
        {
            return false;
        }
    }
}
