using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NgheSy
{
    public class NSLoaiB : NgheSy
    {
        private string theloai;

        public override double tinhHeSoNS()
        {
            int t = DateTime.Today.Year - nams;
            if (t < 18)
                return 1.5;
            else if (theloai == "Nhac tre" || theloai == "bolero")
                return 1.8;
            else
                return 1.3;
        }
    }
}