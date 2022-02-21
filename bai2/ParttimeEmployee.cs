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
            Console.WriteLine("Nhập nhân viên PartTime: ");
            base.Nhap();
        }
        public override void TaoHopDong(string HDPT)
        {
            SoHopDong1 = HDPT + MaNhanVien1 + Ngay1;

        }
        public override void Xuat()
        {
            Console.Write("Nhân viên PartTime: ");
            base.Xuat();
        }
    }
}
