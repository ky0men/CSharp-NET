using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        public static void ShowMenu()
        {
            Console.WriteLine("------------ Book Management -------------");
            Console.WriteLine("1. Them moi sach");
            Console.WriteLine("2. Xuat danh sach thong tin sach");
            Console.WriteLine("3. Cap nhat thong tin sach theo ID");
            Console.WriteLine("4. Xoa sach theo ID");
            Console.WriteLine("5. Thoat");
            Console.Write("Lua chon: ");
        }
        static void Main(string[] args)
        {
            BookList bookList = new BookList();
            int choice;
            do
            {
                ShowMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        bookList.ThemMoi();
                        break;
                    case 2:
                        bookList.PrintDetails();
                        break;
                    case 3:
                        bookList.UpdateBook();
                        break;
                    case 4:
                        bookList.DeleteBook();
                        break;
                    case 5:
                        Console.WriteLine("Bye bye!");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le! Chon lai.");
                        break;
                }
            } while (choice != 5);
            Console.ReadKey();
        }
    }
}
