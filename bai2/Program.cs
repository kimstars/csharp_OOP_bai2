using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace bai2
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            var employees = new List<Employee>();
            bool run = true;
            while(run)
            {
                Console.Clear();
                Console.WriteLine("Chọn tính năng :");
                Console.WriteLine("1. Nhập danh sách.");
                Console.WriteLine("2. Hiển thị.");
                Console.WriteLine("3. Sắp xếp danh sách theo mã nhân viên.");
                Console.WriteLine("4. Hiển thị danh sách nhân viên (có lựa chọn ngày vào làm)");
                int c = int.Parse(Console.ReadLine());
                string key;
                switch (c)
                {
                    case 1:
                        {
                            NhapDS(ref employees);
                            break;
                        }
                    case 2:
                        {
                            XuatDS(employees);
                            break;
                        }
                    case 3:
                        {
                            SapXep(ref employees);
                            break;
                        }
                    case 4: 
                        {
                            LocTheoNgay(employees);
                            break;
                        }
                    default:
                        Console.WriteLine("Không có lựa chọn đó!! Hãy chọn lại");
                        break;
                }

                Console.WriteLine("Bạn có muốn tiếp tục ? (Y/N)");
                key = Console.ReadLine().ToUpper();

                if (key == "N")
                {
                    run = false;
                }
                else if (key == "Y")
                {
                    Console.Out.Flush();
                }

            } 


        }
        public static void LocTheoNgay(List<Employee> employees)
        {
            string patten = @"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}";
            Regex validate = new Regex(patten);
            string Ngay;

            Console.WriteLine($"Nhập ngày vào làm để hiển thị(dd/mm/yyyy) : ");
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

            int count = 0;
            foreach (var e in employees)
            {
                if (Ngay.Equals(e.Ngay1))
                {
                    e.Xuat();
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"Danh sách có {count} nhân viên.");
            }
            else
            {
                Console.WriteLine($"Không có nhân viên vào làm việc ngày {Ngay}");

            }


        }
        public static void XuatDS (List<Employee> employees)
        {
            if(employees.Count > 0)
            {
                foreach (var e in employees)
                {
                    e.Xuat();
                }
            }
            else
            {
                Console.WriteLine("Danh sach trong!!!");
            }
            
        }
        public static void NhapDS(ref List<Employee> employees)
        {
            int n;
            Console.WriteLine("Nhap so luong : ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Chon Loai Nhan vien :");
                Console.WriteLine("1. Nhan vien PartTime.");
                Console.WriteLine("2. Nhan vien FullTime.");
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        {
                            ParttimeEmployee temp = new ParttimeEmployee();
                            temp.Nhap();
                            employees.Add(temp);
                            break;
                        }
                    case 2:
                        {
                            FulltimeEmployee temp = new FulltimeEmployee();
                            temp.Nhap();
                            employees.Add(temp);
                            break;
                        }
                    default:
                        Console.WriteLine("Khong co lua chon do");
                        break;
                }
            }
        }

        static void SapXep(ref List<Employee> employees)
        {
            employees.Sort((x, y) => x.MaNhanVien1.CompareTo(y.MaNhanVien1));
            XuatDS(employees);
        }


    }
}
