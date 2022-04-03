using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id, name;
            int tuoi;
            float toan, van, anh, ly, hoa, tinHoc, tiengPhap;
            Console.Write("Nhap id hoc sinh: ");
            id = Console.ReadLine();
            Console.Write("Nhap ten hoc sinh: ");
            name = Console.ReadLine();

            bool flag = false;
            do
            {
                Console.Write("Nhap tuoi hoc sinh: ");
                tuoi = Convert.ToInt32(Console.ReadLine());
                if (tuoi >= 7 && tuoi <= 18)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Tuoi khong hop le. Nhap lai!");
                }

            } while (!flag);

            if (tuoi >= 7 && tuoi <= 11)
            {
                Console.WriteLine("hoc sinh cap 1");
                Console.Write("Nhap diem toan: ");
                toan = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem toan: ");
                van = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem toan: ");
                anh = float.Parse(Console.ReadLine());

                Cap1 hsCap1 = new Cap1(id, name, tuoi, toan, van, anh);
                Console.WriteLine("Diem trung binh cua {0} la {1}", name, hsCap1.DiemTrungBinh());

            }
            else if (tuoi > 11 && tuoi <= 15)
            {
                Console.WriteLine("Hoc sinh cap 2");
                Console.Write("Nhap diem toan: ");
                toan = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem toan: ");
                van = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem toan: ");
                anh = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem ly: ");
                ly = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem hoa: ");
                hoa = float.Parse(Console.ReadLine());

                Cap2 hsCap2 = new Cap2(id, name, tuoi, toan, van, anh, ly, hoa);
                Console.WriteLine("Diem trung binh cua {0} la {1}", name, hsCap2.DiemTrungBinh());
            }
            else if (tuoi > 15 && tuoi <= 18)
            {
                Console.WriteLine("Hoc sinh cap 3");
                Console.Write("Nhap diem toan: ");
                toan = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem toan: ");
                van = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem toan: ");
                anh = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem ly: ");
                ly = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem hoa: ");
                hoa = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem tin hoc: ");
                tinHoc = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem tieng Phap: ");
                tiengPhap = float.Parse(Console.ReadLine());

                Cap3 hsCap3 = new Cap3(id, name, tuoi, toan, van, anh, ly, hoa, tinHoc, tiengPhap);
                Console.WriteLine("Diem trung binh cua {0} la {1}", name, hsCap3.DiemTrungBinh());
            }
        }

    }
}
