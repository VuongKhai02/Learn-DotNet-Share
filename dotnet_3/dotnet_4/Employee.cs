using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_4
{
    internal class Employee
    {
        //Hàm khởi tạo
        //Overloading
        //Static
            /*- Class tĩnh: (Trong class tĩnh thì tất cả biến và phương thức đều là tính)
            - Là những biến, phương thức giữ những giá trị CỐ ĐỊNH, KHÔNG THAY ĐỔI Ở TOÀN BỘ CHƯƠNG TRÌNH
            - Là biến, phương thức(Method)
            - Chỉ truy cập dc qua đối tượng(Tên class)
            - Vì nó chỉ truy cập dc qua đối tượng(tên class)
            nên ta ko cần khởi tạo đối tượng(var emp = new Employee()) kiểu vậy
            - Vd như hàm Math.sqrt().
            - Ý nghĩa: Tạo 1 class mà chỉ tạo những phương thức tĩnh, gọi nó ra.
            - Vd Tạo 1 class chỉ chứa các const.
            */
        // Tên biến của hàm public viết hoa chữ đầu
        //Nếu ko có hàm khởi tạo nào thì mặc định là mới tinh
        // Nếu có 1 hoặc nhiều hơn 1 hàm khởi tạo thì sẽ ko phải là mới tính
        //tức là lúc khởi tạo đối tượng, phải .thuộc tính của từng biến rồi gán

        //Có thể có nhiều hàm khởi tạo
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
            Console.WriteLine();
        }
        public Employee(string name, int yob, double sl)
        {
            // Tên biến public hoặc từ khóa this đều được
            Name = name;
            this.YearOfBirth = yob;
            this.SalaryLevel = sl;
            this.BasicSalary = 4000;
        }



        //public Employee(double sl, double bs, string name)
        //{
        //    this.Name = name;
        //    this.SalaryLevel = sl;
        //    this.BasicSalary = bs;
        //}
        public Employee(string name, double sl, double bs)
        {
            this.Name = name;
            this.SalaryLevel = sl;
            this.BasicSalary = bs;
        }
        


        //Nạp trồng phương thức (Overloading)
        public void Work()
        {
            Console.WriteLine("Đang làm việc");
        }

        public void Work(string addr)
        {
            Console.WriteLine("Đang làm việc tại {0}: ", addr);
        }

        public void Work(DateTime workDate)
        {
            Console.WriteLine("Đang làm việc vào thời gian: {0}", workDate);
        }
    }
}
