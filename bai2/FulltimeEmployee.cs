using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class FulltimeEmployee : Employee
    {
        public override void Nhap()
        {
            Console.WriteLine("Nhập nhân viên FullTime: ");
            base.Nhap();
        }
        public override void TaoHopDong(string HDFT)
        {
            SoHopDong1 = HDFT + MaNhanVien1 + Ngay1;
        }
        public override void Xuat()
        {
            Console.Write("Nhân viên FullTime: ");
            base.Xuat();   
        }
    }
}
