using System;
using System.Text;

namespace dotnet_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            //Dùng hàm khởi tao 1
            Employee employee1 = new Employee(" Khải", 2002, 3);
            employee1.Display();

            //Dùng hàm khởi tao 2
            Employee employee2 = new Employee("Khải", 3, 1000);
            employee2.Display();

            var a = Constant.CutString("  Kh ");
            Console.WriteLine(a);


            //Employee employee2 = new Employee(3, 2000, "Khải");
            //employee2.Display();

        }
    }
}
