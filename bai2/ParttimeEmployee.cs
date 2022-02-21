using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class ParttimeEmployee : Employee
    {
        public override void Nhap()
        {
            Console.Write("Nhap Nhan vien PartTime: ");
            base.Nhap();
        }
        public override void TaoHopDong(string HDPT)
        {
            SoHopDong1 = HDPT + MaNhanVien1 + Ngay1;

        }
    }
}
