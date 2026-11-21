using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuong3
{
    public class ThiSinh
    {
        private string hoTen, sbd;
        private int nam;
        private double dlt, dth;
        public void nhap()
        {
            Console.Write("Nhap ho va ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap so bao danh: ");
            sbd = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            nam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem li thuyet: ");
            dlt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem thuc hanh: ");
            dth = Convert.ToInt32(Console.ReadLine());
        }
        public bool ktDau()
        {
            if (dlt + dth > 10 && dlt >= 2 && dth >= 2)
                return true;
            else
                return false;
        }
        public void xuat()
        {
            Console.WriteLine("Ho va ten: {0}",hoTen);
            Console.WriteLine("So bao danh: {0}",sbd);
            Console.WriteLine("Nam sinh: {0}",nam);
            if (ktDau())
                Console.WriteLine("Thi sinh dau");
            else
                Console.WriteLine("Thi sinh rot");
        }
    }
}
