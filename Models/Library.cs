using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Library
    {
        Book[] books = new Book[0];

        public void AddBook(Book book)
        {
            Array.Resize(ref books,books.Length+1);
            books[books.Length - 1] = book;
        }

        public void  GetBookId(uint id)
        {
            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}
