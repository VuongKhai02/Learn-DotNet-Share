using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet8_LinQ
{
    internal class Product
    {
        public Product( string name, decimal price, int categoryId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            CategoryId = categoryId;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public void Display()
        {
            Console.WriteLine("Tên:{0} - Giá: {1}", Name, Price);
        }
    }
}
