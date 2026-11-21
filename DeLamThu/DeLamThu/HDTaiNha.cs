using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeLamThu
{
    public class HDTaiNha:HDCaSi
    {
        int khoangCach;
        public override double tinhQC()
        {
            if (khoangCach <= 20)
                return 400000 * khoangCach;
            else
            {
                return Math.Min(khoangCach * 300000, 15000000);
            }
        }
    }
}
