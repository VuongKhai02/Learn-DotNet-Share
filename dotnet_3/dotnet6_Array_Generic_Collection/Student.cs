using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet6_Array_Generic_Collection
{
    internal class Student
    {
        public Guid Id { get; set; }    
        public string Name { get; set; }    

        public string Addr { get; set; }    

        public Student(string name,  string addr)
        {
            Id = Guid.NewGuid();   
            Name = name;
            Addr = addr;
        }       

        public void Display()
        {
            Console.WriteLine("ID {0} - Name {1} - Addr {2}", Id,Name,Addr);
        }


        public override string ToString()
        {
            return $"{Name} {Addr}";
        }
    }
}
