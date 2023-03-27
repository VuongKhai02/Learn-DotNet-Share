using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_5_tichchatLLTHDT_TruuTuong
{
    internal interface IPerson_Interface
    {
        //Chỉ khai báo thôi, dùng ở dưới
        //Trong interface k nên khai báo hàm, mặc dù có thể khai báo hàm
        // Nhưng ko sử dụng ở dưới
        // Trong interface có thuộc tính gì, thì các class sau phải sd hết tt đó
        
        void Display();
        void Run();

    }

    internal interface ICompany_Interface
    {
        //Chỉ khai báo thôi, dùng ở dưới

        void DisplayAddr();

    }

    //Lớp staff triển khai thằng Iperson, có thể thực thi 2 interface
    public class Staff: IPerson_Interface
    {
        public void Display()
        {
            Console.WriteLine("Hiển thị thông tin staff: ");
        }
        public void Run()
        {
            Console.WriteLine("Nhân viên chạy đua");
        }
        public void DisplayAddr()
        {
            Console.WriteLine("Công ty ở: ");
        }

    }
    public class StudentA : IPerson_Interface
    {
        public void Display()
        {
            Console.WriteLine("Hiển thị thông tin Student: ");
        }
        public void Run()
        {
            Console.WriteLine("Học sinh chạy đua");
        }

    }
}
