using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace dotnet4_tinhchatLTHDT
{

    internal class Employee_KeThua: Person_KeThua
    {
        //Tính kế thừa không cho phép kế thừa hàm khởi tạo:
        public decimal Salary { get; set; }

        //khắc phục:
        // Không nhất thiệt phải viết giống thằng cha, nhưng 
        // :base bắt buộc phải lấy đúng biến
        public Employee_KeThua(string name, DateTime dob, int gender ,decimal salary)
            :base(name, dob, gender)
        {
            Salary = salary;
        }

        //Khái niệm hiding method.
        //Thằng cha có hàm này tự động bị ẩn,. chỉ dùng của thằng con\

        //Đa hình: (Ở lớp con phải có override)
        public override void toString()
        {
            Console.WriteLine("Hàm toString của lớp emloyee");
            //base.toString();//Gọi đến hàm cha
            //Console.WriteLine("Thu nhập {0}", Salary);
        }
        public void Work()
        {
            Console.WriteLine("Đang làm việc");
        }
    }
}
