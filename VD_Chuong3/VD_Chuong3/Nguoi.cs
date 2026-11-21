using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Chuong3
{
    public class Nguoi
    {
        private string ten;
        private int nam;
        public void nhap()
        {
            Console.Write("Nhap Ten: ");
            ten = Console.ReadLine();
            Console.Write("Nhap Nam Sinh: ");
            nam = Convert.ToInt32(Console.ReadLine());
        }
        public int tinhTuoi()
        {
            return DateTime.Today.Year - nam;
        }
        public void xuat()
        {
            Console.WriteLine("Ten: {0}", ten);
            Console.WriteLine("Tuoi: {0}", tinhTuoi());
        }
    }
}
