using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap tu so cua phan so 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap mau so cua phan so 1: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap tu so cua phan so 2: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap mau so cua phan so 2: ");
            int d = Convert.ToInt32(Console.ReadLine());

            PhanSo ps1 = new PhanSo(a, b);
            PhanSo ps2 = new PhanSo(c, d);
            Tong(ps1, ps2);
            Hieu(ps1, ps2);
            Tich(ps1, ps2);
            Thuong(ps1, ps2);
        }

        public static void Tong(PhanSo ps1, PhanSo ps2)
        {
            PhanSo result = new PhanSo();
            result.MauSo = ps1.MauSo * ps2.MauSo;
            result.TuSo = ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo;
            Console.WriteLine("Ket qua tong: {0}/{1}", result.TuSo, result.MauSo);
        }

        public static void Hieu(PhanSo ps1, PhanSo ps2)
        {
            PhanSo result = new PhanSo();
            result.MauSo = ps1.MauSo * ps2.MauSo;
            result.TuSo = ps1.TuSo * ps2.MauSo - ps2.TuSo * ps1.MauSo;
            Console.WriteLine("Ket qua hieu: {0}/{1}", result.TuSo, result.MauSo);
        }

        public static void Tich(PhanSo ps1, PhanSo ps2)
        {
            PhanSo result = new PhanSo();
            result.MauSo = ps1.MauSo * ps2.MauSo;
            result.TuSo = ps1.TuSo * ps2.TuSo;
            Console.WriteLine("Ket qua tich: {0}/{1}", result.TuSo, result.MauSo);
        }

        public static void Thuong(PhanSo ps1, PhanSo ps2)
        {
            PhanSo result = new PhanSo();
            result.TuSo = ps1.TuSo * ps2.MauSo;
            result.MauSo = ps1.MauSo * ps2.TuSo;
            Console.WriteLine("Ket qua thuong: {0}/{1}", result.TuSo, result.MauSo);
        }
    }
}
