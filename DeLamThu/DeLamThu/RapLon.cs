using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeLamThu
{
    public class RapLon:HDCaSi,IHoTro
    {
        int luongKG;
        public override double tinhQC()
        {
            if (luongKG < 1000000)
                return 30000000;
            else
                return 50000000;
        }
        public double tinhTienHT()
        {
            return Math.Min(luongKG / 100000 * 1000000, 20000000);
        }
    }
}
