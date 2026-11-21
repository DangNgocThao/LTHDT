using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NgheSy
{
    public class VuDoan : NgheSy, IHoTro
    {
        private int solg;
        private double cpcb;

        public override double tinhHeSoNS()
        {
            double hsn = 0;
            if (solg < 3)
                hsn = 1.2;
            else if (solg <= 5)
                hsn = 1.8;
            else
                hsn = 2.0;
            return 2.5 + hsn;
        }

        public double tinhHT()
        {
            if (solg < 10)
                return 0.5 * cpcb;
            else
                return 0.3 * cpcb + 300;
        }
    }
}