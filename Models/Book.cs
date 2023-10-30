using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1.Models
{
    internal class Book: Product
    {
        public string AuthorName;
        public uint PageCount;



        public Book(string author, uint pagecount, string name, decimal price, uint count):base(name,price,count)
        {
            AuthorName = author;
            PageCount = pagecount;
        }

        public override void Sell()
        {
            Count--;
            TotalinCome+=Price;
            Console.WriteLine(TotalinCome);
        }




        public override string ShowInfo()
        {
            return $"Id : {Id}\nName :{Name}\nPrice: {Price}\nCount: {Count}\nAuthorName: {AuthorName}\nPageCount: {PageCount}";
        }


       
    }
}
