using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan06
{
    public class HangHoa
    {
        private string maH, tenH;

        public HangHoa()
        {
            this.maH = "";
            this.tenH = "";
        }

        public HangHoa(HangHoa a)
        {
            this.maH = a.maH;
            this.tenH = a.tenH;
        }

        public HangHoa(string maH, string tenH)
        {
            if (maH.Length != 5 || maH.StartsWith("HH") == false || maH[2] + maH[3] + maH[4] > 171 || maH[2] + maH[3] + maH[4] < 144)
                maH = "HH001";
            else this.maH = maH;
            this.tenH = tenH;
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ma hang: {0}", maH);
            Console.WriteLine("Ten hang: {0}", tenH);
        }
    }
}
