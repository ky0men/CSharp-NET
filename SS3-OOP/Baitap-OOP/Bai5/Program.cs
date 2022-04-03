using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        public static void ShowMenu()
        {
            Console.WriteLine("------ VietNam AirLine -------");
            Console.WriteLine("1. Nhap hanh khach");
            Console.WriteLine("2. Xuat thong tin hanh khach");
            Console.WriteLine("3. Sap xep hanh khach theo gia ve");
            Console.WriteLine("4. Thoat");
            Console.Write("Lua chon: ");
        }

        public static void Input(List<HanhKhach> khachList)
        {
            Console.Write("Nhap so hanh khach can nhap: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                HanhKhach khach = new HanhKhach();
                Console.Write("Nhap ten: ");
                khach.Name = Console.ReadLine();
                Console.Write("Nhap gioi tinh: ");
                khach.Gender = Console.ReadLine();
                Console.Write("Nhap tuoi: ");
                khach.Age = Convert.ToInt32(Console.ReadLine());
                VeMayBay ve = new VeMayBay();
                Console.Write("Nhap ten chuyen bay: ");
                ve.TenChuyen = Console.ReadLine();
                Console.Write("Nhap ngay bay: ");
                ve.NgayBay = Console.ReadLine();
                Console.Write("Nhap gia ve: ");
                ve.GiaVe = float.Parse(Console.ReadLine());
                khach.Ve = ve;
                Console.Write("Nhap so luong ve: ");
                khach.SoLuong = Convert.ToInt32(Console.ReadLine());
                khachList.Add(khach);
            }
        }

        public static void Output(List<HanhKhach> khachList)
        {
            Console.WriteLine("----- Danh sach hanh khach -------");
            Console.WriteLine("{0, -20} {1, -10} {2, -5} {3, -10} {4, -20} {5, -25}", "Ten", "Gioi Tinh", "Tuoi", "So luong", "Gia Ve", "Tong Tien");
            foreach (HanhKhach khach in khachList)
            {
                Console.WriteLine("{0, -20} {1, -10} {2, -5} {3, -10} {4, -20} {5, -25}", khach.Name, khach.Gender, khach.Age, khach.SoLuong, khach.Ve.GiaVe, khach.TongTien());
            }
        }

        public static void SortByMoney(List<HanhKhach> khachList)
        {
            khachList.Sort();
            Output(khachList);
        }

        static void Main(string[] args)
        {
            int choice;
            List<HanhKhach> khachList = new List<HanhKhach>();
            do
            {
                ShowMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Input(khachList);
                        break;
                    case 2:
                        Output(khachList);
                        break;
                    case 3:
                        SortByMoney(khachList);
                        break;
                    case 4:
                        Console.WriteLine("Bye bye!");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le! Chon lai.");
                        break;

                }

            } while (choice != 4);




        }
    }
}
