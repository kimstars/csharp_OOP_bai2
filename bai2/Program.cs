﻿using System;
using System.Collections.Generic;
using System.Text;



namespace bai2
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            var employees = new List<Employee>();
            Console.WriteLine("Chon tinh nang :");
            Console.WriteLine("1. Nhap danh sach.");
            Console.WriteLine("2. Sap xep danh sach theo ma nhan vien.");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    {
                        NhapDS(ref employees);
                        break;
                    }

                case 2:
                    {
                        SapXep(ref employees);
                        break;
                    }
                default:
                    Console.WriteLine("Khong co lua chon do");
                    break;
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
                            ParttimeEmployee temp = new ParttimeEmployee();
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
        {baitap\huongdoituong\ba
            employees.Sort((x, y) => x.Ngay1.CompareTo(y.Ngay1));
        }


    }
}