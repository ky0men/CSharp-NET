using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        public static void InputStudents(out string id, out string name, out string phone, out string address)
        {
            Console.WriteLine("--------- Nhap thong tin sinh vien ----------");
            Console.Write("Nhap id: ");
            id = Console.ReadLine();
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            phone = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            address = Console.ReadLine();
        }

        public static void OutputDetails(List<Students> studentList)
        {
            Console.WriteLine("------------ Thong tin sinh vien ---------");
            foreach (var student in studentList)
            {
                Console.WriteLine("ID: {0}, Ten: {1}, SDT: {2}, Dia Chi: {3}", student.Id, student.Name, student.Phone, student.Address);
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("-------- Quan ly sinh vien --------");
            Console.WriteLine("1. Them moi sinh vien");
            Console.WriteLine("2. Tim kiem sinh vien");
            Console.WriteLine("3. Dem so sinh vien");
            Console.WriteLine("4. Cap nhat thong tin sinh vien theo ID");
            Console.WriteLine("5. Xoa sinh vien theo ID");
            Console.WriteLine("6. Thoat");
            Console.Write("Lua chon: ");
        }

        public static void ThemMoiSinhVien(List<Students> studentsList)
        {
            string id, name, phone, address;
            Console.Write("Nhap so sinh vien can them: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                InputStudents(out id, out name, out phone, out address);
                Students std = new Students(id, name, phone, address);
                studentsList.Add(std);
            }
            OutputDetails(studentsList);
        }

        public static void TimKiemSinhVien(List<Students> stdList)
        {
            List<Students> foundList = new List<Students>();
            Console.WriteLine("------- Tim kiem sinh vien theo ten -------");
            Console.Write("Nhap ten sinh vien can tim kiem: ");
            string findName = Console.ReadLine();
            foreach (Students student in stdList)
            {
                if (student.Name.Equals(findName, StringComparison.OrdinalIgnoreCase))
                {
                    foundList.Add(student);
                }
            }

            if (foundList.Count > 0)
            {
                Console.WriteLine("----- Thong tin sinh vien da tim thay -----");
                OutputDetails(foundList);
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien co ten {0}", findName);
            }
        }

        public static void DemSoSinhVien(List<Students> stdList)
        {
            Console.WriteLine("So sinh vien hien co la: {0}", stdList.Count);
        }

        public static void CapNhatSinhVien(List<Students> stdList)
        {
            Console.WriteLine("---- Cap nhat thong tin sinh vien theo ID ------");
            Console.Write("Nhap ID sinh vien can cap nhat: ");
            bool isFound = false;
            string updateID = Console.ReadLine();
            foreach (Students student in stdList)
            {
                if (student.Id.Equals(updateID, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Nhap ten can cap nhat: ");
                    student.Name = Console.ReadLine();
                    Console.Write("Nhap so dien thoai can cap nhat: ");
                    student.Phone = Console.ReadLine();
                    Console.Write("Nhap dia chi can cap nhat: ");
                    student.Address = Console.ReadLine();
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Khong tim thay sinh vien nao co ID {0}", updateID);
            }
            OutputDetails(stdList);
        }

        public static void DeleteSinhVien(List<Students> stdList)
        {
            Console.WriteLine("---- Xoa sinh vien theo ID ------");
            Console.Write("Nhap ID sinh vien can xoa: ");
            string deleteID = Console.ReadLine();
            int index = stdList.FindIndex(s => s.Id.Equals(deleteID, StringComparison.InvariantCultureIgnoreCase));
            if (index >= 0)
            {
                stdList.RemoveAt(index);
                Console.WriteLine("Da xoa thanh cong!");
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien co ID la {0}", deleteID);
            }
        }
        static void Main(string[] args)
        {
            string id, name, phone, address;
            //ArrayList studentsList = new ArrayList();
            List<Students> studentsList = new List<Students>();
            Console.Write("Nhap so sinh vien can nhap: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                InputStudents(out id, out name, out phone, out address);
                Students std = new Students(id, name, phone, address);
                studentsList.Add(std);
            }
            OutputDetails(studentsList);
            ShowMenu();
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 6)
            {
                switch (choice)
                {
                    case 1:
                        ThemMoiSinhVien(studentsList);
                        break;
                    case 2:
                        TimKiemSinhVien(studentsList);
                        break;
                    case 3:
                        DemSoSinhVien(studentsList);
                        break;
                    case 4:
                        CapNhatSinhVien(studentsList);
                        break;
                    case 5:
                        DeleteSinhVien(studentsList);
                        break;
                    case 6:
                        Console.WriteLine("Bye Bye!");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le! Chon lai.");
                        break;
                }
                ShowMenu();
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
