using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public abstract class Product
    {
        public static uint _id = 0 ;
        public uint Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public uint Count { get; set; }

        protected decimal TotalinCome { get; set; }



        public Product(string name,decimal price,uint count)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Count = count;
        }


        public abstract void Sell();
        public abstract string ShowInfo();




    }
}
