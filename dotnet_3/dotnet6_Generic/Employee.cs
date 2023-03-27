using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet6_Generic
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Addr { get; set; }
        public int Age { get; set; }

        public Employee( string name, string addr, int age)
        {
            Id = new Guid();
            Name = name;
            Addr = addr;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine("ID {0} - Name {1} - Addr {2} - Age {3}"
                , Id, Name, Addr,Age);

        }
    }
}
