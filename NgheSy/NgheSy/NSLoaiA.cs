using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NgheSy
{
    public class NSLoaiA : NgheSy, IHoTro
    {
        private int slht;
        private int sldh;
        private double thamnien;

        public override double tinhHeSoNS()
        {
            double hstm = 0;
            if (thamnien > 10)
                hstm = thamnien * 0.1;
            return 3 + hstm + 0.25 * sldh;
        }

        public double tinhHT()
        {
            if (slht >= 5 && slht <= 10)
                return 600;
            else if (slht >= 10)
                return 1000;
            else
                return 100;
        }
    }
}