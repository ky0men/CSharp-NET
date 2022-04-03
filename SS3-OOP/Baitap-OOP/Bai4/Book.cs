using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Book : IBook
    {
        public Book()
        {
        }

        public Book(string name, string author, string publisher, int publishYear, string iSBN)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
            PublishYear = publishYear;
            ISBN = iSBN;
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PublishYear { get; set; }
        public string ISBN { get; set; }



    }
}
