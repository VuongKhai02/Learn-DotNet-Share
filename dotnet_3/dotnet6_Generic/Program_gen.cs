using System;
using System.ComponentModel;

namespace dotnet6_Generic
{
    internal class Program_gen
    {
        static void Main(string[] args)
        {
            var lstName = new GenericIndexer<string>();
            lstName.Add("Khai Vuong Van");
            lstName.Add("Khai Vuong Van2");
            foreach(var item in lstName.GetData())
            {
                Console.WriteLine(item);
            }

            var lstNum = new GenericIndexer<int>();
            Console.WriteLine("Enter your num which you want to add into Generic: ");
            int.TryParse(Console.ReadLine(), out int num);
            lstNum.Add(num);
            foreach(var item in lstNum.GetData())
            {
                Console.WriteLine(item);
            }

            
            var lstEmpoyee = new GenericIndexer<Employee>();
            lstEmpoyee.Add(new Employee("Khai", "HY", 12));

            
            foreach (var item in lstEmpoyee.GetData())
            {
                item.Display();
            }

        }
    }
}
