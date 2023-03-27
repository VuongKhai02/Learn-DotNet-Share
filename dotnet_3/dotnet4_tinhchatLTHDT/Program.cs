using System;
using System.Text;

namespace dotnet4_tinhchatLTHDT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            //Phạm vi truy cập
            /*
             * Public: ok truy cập dc mọi nơi
             * ởivvate: Chỉ truy cập dc trong class đó
             * Protected: 
             * ok truy cập đc với lớp con(kế thừa)
             * Không truy cập đc trong class khác
             * 
             * */

            //public seald class (Không cho pháp class nào kế thừa nó)
            //public 


            // Các tính chất LTHDT: 
            /*
            // Đóng gói - kế thừa- đa hình - trừu tượng
            // 1. Đóng gói dữ liệu và phương thức của 1 ibj lại để tránh bị tác động từ bên ngoài

            */

            //Đóng gói:
            /* 
             * Mình không thể tác động vào biến _chieudai(vì nó là private)
             * Vì vậy nó thể hiện tính đóng gói
             * 
             * Minh họa:
             * Sau khi đã khởi tạo đối tượng qua hàm tạo
             * mình sẽ tính được chu vi thông qua 2 đối số dc truyền vào
             * cùng với đó diên j tichs cũng đc tính thông qua 2 đối số đó
             * Nhưng nếu không có tính đóng gói, ta tính chu vi xong
             * ta lại gán lại _chieudai, thì như vậy sẽ vi phạm tính đóng gói
             *  -- > bản chất private
             * */
            var hcn = new HinhChuNhat_Donggoi(10,5);
            Console.WriteLine(hcn.Chuvi());
            Console.WriteLine(hcn.Dientich());

            //Kế thừa:
            /* 
             * Quy tăc kế thừa: Class : Class
             * 
             * Lưu ý: chỉ được kế thừa 1 class duy nhất(ko thể :cl1:cl2)
             * Những lớp con có thể kế thừa và ghi đè (overloading) các thuộc tính
             * và phương thức của lớp cha
             * * */
            Person_KeThua empl = new Employee_KeThua("Khải", new DateTime(2002,10,12), 0,5000);

            /*
                //Nếu khai báo như thế này, vì cả 2 class đều có hàm tostring, nhưng khi
                //Khai bao như thế này có sẽ chạy theo hàm tostring ở class Person
                Person_KeThua per = new Employee_KeThua("Khải", new DateTime(2002, 10, 12), 0, 5000);
                per.toString();
            */

            /* Đây là code lúc ch có hàm khởi tạo
            empl.Name = "Khải";
            empl.Salary = 5000;//Ghi đè lớp con
            empl.Gender = 0;
            */
            empl.toString();


        }
    }
}
