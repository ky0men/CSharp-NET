using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class BookList
    {
        List<Book> bookList = new List<Book>();
        public void ThemMoi()
        {
            Console.Write("Nhap so sach can them moi: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Book book = new Book();
                Console.Write("Nhap ten sach: ");
                book.Name = Console.ReadLine();
                Console.Write("Nhap ten tac gia: ");
                book.Author = Console.ReadLine();
                Console.Write("Nhap ten nha xuat ban: ");
                book.Publisher = Console.ReadLine();
                Console.Write("Nhap nam xuat ban: ");
                book.PublishYear = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap ISBN: ");
                book.ISBN = Console.ReadLine();
                bookList.Add(book);
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine("--------- Thong tin sach ----------");
            Console.WriteLine("{0, -20} {1, -20} {2, -20} {3, -12} {4, -15}", "Ten Sach", "Ten Tac Gia", "Nha Xuat Ban", "Nam Xuat Ban", "ISBN");
            foreach (Book book in bookList)
            {
                Console.WriteLine("{0, -20} {1, -20} {2, -20} {3, -12} {4, -15}", book.Name, book.Author, book.Publisher, book.PublishYear, book.ISBN);
            }
        }

        public void UpdateBook()
        {
            bool isUpdate = false;
            Console.Write("Nhap ID sach can cap nhat: ");
            string updateID = Console.ReadLine();
            foreach (Book book in bookList)
            {
                if (book.ISBN.Equals(updateID, StringComparison.OrdinalIgnoreCase))
                {
                    isUpdate = true;
                    Console.Write("Nhap ten sach can sua: ");
                    book.Name = Console.ReadLine();
                    Console.Write("Nhap ten tac gia can sua: ");
                    book.Author = Console.ReadLine();
                    Console.Write("Nhap nha xuat ban can sua: ");
                    book.Publisher = Console.ReadLine();
                    Console.Write("Nhap nam xuat ban can sua: ");
                    book.PublishYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Da cap nhat xong!");
                }
            }
            if (!isUpdate)
            {
                Console.WriteLine("Khong tim thay ID sach {0}", updateID);
            }
        }

        public void DeleteBook()
        {
            Console.Write("Nhap ID sach can xoa: ");
            string deleteID = Console.ReadLine();
            int index = bookList.FindIndex(s => s.ISBN.Equals(deleteID, StringComparison.OrdinalIgnoreCase));
            if (index >= 0)
            {
                bookList.RemoveAt(index);
                Console.WriteLine("Da xoa thanh cong!");
            }
            else
            {
                Console.WriteLine("Khong tim thay ID sach {0}", deleteID);
            }
        }
    }
}
