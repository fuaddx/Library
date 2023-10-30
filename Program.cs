using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book book = new Book("Fuad",1,"Nagil",34,56);

            Library lib = new Library();

            lib.AddBook(book);

            lib.GetBookId(book.Id);

            Console.WriteLine(book.ShowInfo());

        }
    }
}