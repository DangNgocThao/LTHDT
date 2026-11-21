using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeLamThu
{
    public class RapNho:HDCaSi,IHoTro
    {
        int quiMo;
        public override double tinhQC()
        {
            return 10000000 + 2000000 * soTM;
        }
        public double tinhTienHT()
        {
            if (quiMo >= 1 && quiMo <= 3)
                return 1000000;
            return 0;
        }
    }
}
