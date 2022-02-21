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
            Console.Write("Nhap Nhan vien FullTime: ");
            base.Nhap();
        }
        public override void TaoHopDong(string HDFT)
        {
            SoHopDong1 = HDFT + MaNhanVien1 + Ngay1;
        }
    }
}
