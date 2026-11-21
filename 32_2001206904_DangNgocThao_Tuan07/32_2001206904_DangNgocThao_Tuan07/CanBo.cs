using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2001206904_DangNgocThao_Tuan07
{
    public class CanBo:NhanVien
    {
        string chucvu;
        double hspcCV;
        public CanBo()
            : base()
        {
            chucvu = "";
            hspcCV = 0;
        }
        public CanBo(string ma, string ten, bool gioitinh, int nvl, double hsl, string chucvu, double hspcCV)
            : base(ma, ten, gioitinh, nvl, hsl)
        {
            this.chucvu = chucvu;
            this.hspcCV = hspcCV;
        }
        public override char XepLoai()
        {
            return 'A';
        }
        public double PhuCapCV()
        {
            return 1100 * hspcCV;
        }
        public override double TinhLuong()
        {
            return hsl * NhanVien.LuongCoBan + PhuCapCV();
        }
    }
}
