using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_3_bai3._1
{
    internal class lthdt
    {

        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            Employee employee1 = new Employee("Khải", 2002, 3, 2000);
            employee1.Display();
            Employee employee2 = new Employee("Khải", 3, 2000);
            employee2.Display();

        }
    }
}
