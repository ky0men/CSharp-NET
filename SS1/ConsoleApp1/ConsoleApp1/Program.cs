using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bai1();
            //Bai2();
            //Bai3();
            //Bai4();
            //Bai5();
            Bai6();
            Console.ReadKey();
        }


        //BAI 1
        static void Bai1()
        {
            Console.Write("Input string: ");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
        }


        //BAI 2
        static void Bai2()
        {
            int a = NhapSo("Nhap so can hien thi: ");
            int b = NhapSo("Nhap chieu dai cua tam giac: ");
            for(int i = 0; i < b; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(a+ " ");
                }
                Console.WriteLine();
            }
        }

        static int NhapSo(string mess)
        {
            
            int flag = 1;
            int a = 0;
            while (flag == 1)
            {
                try
                {
                    Console.Write(mess);
                    a= Int32.Parse(Console.ReadLine());
                    flag = 0;
                }
                catch (Exception)
                {   
                    flag = 1;
                    Console.WriteLine("Hay nhap so!");

                }

            }
            return a;
        }

        //BAI 3
        static void Bai3()
        {
            Console.WriteLine("----------- Dang ky ---------");
            Console.Write("Dang ky Username: ");
            string usr = Console.ReadLine();
            Console.Write("Dang ky password: ");
            string pass = Console.ReadLine();
            Console.WriteLine("----------- Dang nhap ---------");
            
            int count = 0;
            while (count < 3)
            {
                Console.Write("Nhap Username: ");
                string a = Console.ReadLine();
                Console.Write("Nhap password: ");
                string b = Console.ReadLine();

                if (checkIsOk(usr, a) && checkIsOk(pass, b))
                {
                    
                    Console.WriteLine("Dang nhap thanh cong!");
                    break;
                }
                else
                {   
                    if(count < 2) {
                        Console.WriteLine("Username va password khong khop. Dang nhap lai!");
                    
                    }
                    count++;
                }
                if(count == 3)
                {
                    Console.WriteLine("Dang nhap sai 3 lan. Khoa tai khoan!");
                }
            }
        }

        static bool checkIsOk(string regit, string input)
        {
            return regit == input ? true : false;
        }

        //BAI 4

        static void Bai4()
        {
            int a = NhapSo("Hay nhap tuoi: ");
            if(a >= 18)
            {
                Console.WriteLine("Ban da du tuoi bau cu!");
            }
            else
            {
                Console.WriteLine("Ban chua du tuoi bau cu!");

            }
        }

        //BAI 5
        static void Bai5()
        {
            double a = NhapSoThuc("Nhap diem mon Toan: ");
            double b = NhapSoThuc("Nhap diem mon Ly: ");
            double c = NhapSoThuc("Nhap diem mon Hoa: ");
            double d = NhapSoThuc("Nhap tong diem dau: ");
            if((a + b + c) >= d)
            {
                Console.WriteLine("Ban da trung tuyen!");
            }
            else { Console.WriteLine("Ban rot!"); }
        }

        static double NhapSoThuc(string mess)
        {
            int flag = 1;
            double a = 0;
            while (flag == 1)
            {
                try
                {
                    Console.Write(mess);
                    a = Double.Parse(Console.ReadLine());
                    flag = 0;
                }
                catch (Exception)
                {
                    flag = 1;
                    Console.WriteLine("Hay nhap so!");

                }

            }
            return a;

        }

        //BAI 6
        static void Bai6()
        {
            Console.WriteLine("Giai phuong trinh bac 1: ax + b = 0 ");
            double a = NhapSoThuc("Nhap so a: ");
            double b = NhapSoThuc("Nhap so b: ");

            if(a == 0 && b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem!");
            }else if(a == 0 && b != 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem!");

            }
            else
            {
                Console.Write("Phuong trinh co nghiem x = {0}", -b/a);

            }
        }

        //BAI 7
        static void Bai7()
        {
            Console.WriteLine("Giai phuong trinh bac 1: ax2 + bx + c = 0 ");
            double a = NhapSoThuc("Nhap so a: ");
            double b = NhapSoThuc("Nhap so b: ");
            double c = NhapSoThuc("Nhap so c: ");

            double delta = b * b - 4 * a * c;
            if(delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem!");

            }else if(delta == 0)
            {
                Console.Write("Phuong trinh co nghiem kep x1 = x1 = {0}", -b/(2*a));

            }
            else
            {
                Console.WriteLine("Phuong trinh co 2 nghiem x1 = {0}, x2 = {1}", (-b + Math.Sqrt(delta))/(2*a), (-b - Math.Sqrt(delta)) / (2 * a));

            }
        }

        //BAI 9
        static void Bai9()
        {
            double a = NhapSoThuc("Nhap so a: ");
            double b = NhapSoThuc("Nhap so b: ");
            Console.Write("Nhap phep tinh: ");
            string calculate = Console.ReadLine();
            switch (calculate)
            {
                case "*":
                case "x":
                    Console.WriteLine("a * b = {0}", a * b);
                case "-":
                    Console.WriteLine("a - b = {0}", a - b);
                case "+":
                    Console.WriteLine("a + b = {0}", a + b);
                case "/":
                case ":":
                    Console.WriteLine("a/b = {0}", a / b);
                default:
                    Console.WriteLine("Phep toan khong hop le!");
            }
        }
    }
}
