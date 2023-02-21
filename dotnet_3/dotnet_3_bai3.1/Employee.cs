using System;

namespace dotnet_3_bai3._1
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }    

        public int YearOfBirth { get; set; }    

        public double SalaryLevel { get; set; } 

        public double BasicSalary { get; set; } 

        public double GetInCome()
        {
            return (SalaryLevel * BasicSalary);
        }

        public void Display()
        {
            Console.WriteLine("Thông tin: ");
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("YearOfBirth: {0}", YearOfBirth);
            Console.WriteLine("BasicSalary: {0}", BasicSalary);
            Console.WriteLine("Income: {0}", GetInCome());
        }
        public Employee( string name, int yob, double sl, double bs )
        {
            this.Name = name;
            this.YearOfBirth = yob;
            this.SalaryLevel = sl;
            this.BasicSalary = bs;
        }
        
        public Employee(string name, double sl, double bs)
        {
            this.Name = name;
            this.SalaryLevel = sl;
            this.BasicSalary = bs;
        }
    }
}
