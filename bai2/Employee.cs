using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;


namespace bai2
{
    public abstract class Employee
    {
        private string MaNhanVien;
        private string HoTen;
        private string SoHopDong;
        //private DateTime NgayVao;
        private string Ngay;



        public Employee()
        {
            MaNhanVien = HoTen = "";
            SoHopDong = "0";
            Ngay = "00/00/0000";
        }

        public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string SoHopDong1 { get => SoHopDong; set => SoHopDong = value; }
        //public DateTime NgayVao1 { get => NgayVao; set => NgayVao = value; }
        public string Ngay1 { get => Ngay; set => Ngay = value; }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhập mã nhân viên : ");
            MaNhanVien = Console.ReadLine();

            Console.WriteLine("Nhập họ và tên nhân viên : ");
            HoTen = Console.ReadLine();

            string patten = @"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}";
            Regex validate = new Regex(patten);
            Console.WriteLine($"Nhập ngày vào làm (dd/mm/yyyy) : ");
            do
            {
                Ngay = Console.ReadLine();
                if (!validate.IsMatch(Ngay))
                {
                    Console.WriteLine("Nhập không đúng định dạng (dd/mm/yyyy).\nVui lòng nhập lại");
                }
                else
                {
                    //NgayVao = Convert.ToDateTime(Ngay, new CultureInfo("en-US"));
                    break;
                }
            } while (!validate.IsMatch(Ngay));
        }

        public virtual void Xuat()
        {
            Console.Write($"Mã nhân viên: {MaNhanVien} ");
            Console.Write($"|Họ và tên: {HoTen}");
            Console.Write($"|Số hợp đồng :{SoHopDong}");
            Console.WriteLine($"|Ngày vào làm: {Ngay}");

        }
        public virtual void TaoHopDong(string HD)
        {
            SoHopDong = HD + MaNhanVien + Ngay;
        }


    }
}
