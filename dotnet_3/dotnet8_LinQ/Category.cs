using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet8_LinQ
{
    internal class Category
    {
        public Category(int id, string name)
        {
            CategoryId = id;
            Name = name;
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

    }
}
