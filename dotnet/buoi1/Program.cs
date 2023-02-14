using System;
using System.Dynamic;
using System.Text;

namespace buoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            //string name = "Khải";
            //var ten = "devmaster";
            //const double pi = 3.14;
            //DateTime dob = new DateTime(year: 2022, month: 10, day: 20);
            ///* Khai bóa biến bằng var */
            ///* Sẽ căn cứ vào biến được khai báo bên vế phải, tự gán kiểu dữ liệu */

            ////Hiển thị ngày sinh theo format
            //Console.WriteLine("Ngày sinh:" + dob.ToString(format:"dd-MM-yyyy"));

            ////Hiển thị ngày sinh đầy đủ
            //// 2 cách hiển thị ra màn hình : Nối chuỗi và sử dụng 0,1
            //Console.WriteLine("Tên: {0}, Ngày {1}", name, dob);
            //Console.WriteLine("name" + name+"Tuổi" + dob);

            ////Lấy dữ liệu ng dùng nhập
            //Console.WriteLine("Nhập tên của bạn: ");
            //string name1 = Console.ReadLine();
            //Console.WriteLine("Tên của bạn là: " + name1);

            //Console.WriteLine("Nhập số của bạn muốn: ");
            //var numStr = Console.ReadLine();
            //var num = int.Parse(numStr);
            //Console.Write("Số bạn vừa nhập là số: ");
            //Console.WriteLine(num % 2 == 0 ? "chăn" : "Lẻ");

            //// yy-mm-dd || dd-mm-yy 
            //Console.WriteLine("Nhập ngày sinh:");
            //var dateStr = Console.ReadLine();
            //var date = DateTime.Parse(dateStr);
            //Console.WriteLine("Mày sinh ngày: " + date);    
            ////Tính tuổi
            //Console.WriteLine("Tuổi của mày là: " + ((DateTime.Now).Year - date.Year));

            ////Sử dụng trypare thay vì parse bình thường.
            //Console.WriteLine("Nhập số của bạn muốn: ");
            //var numStrr = Console.ReadLine();
            //var status = int.TryParse(numStrr   , out int numm);
            //Console.WriteLine("TRẠNG THÁI: " + status);
            //Console.WriteLine("Sau khi convert: " + numm);

            bool isQuit = false;
            while (isQuit == false)
            {
                Console.WriteLine("Nhập số: ");
                int.TryParse(Console.ReadLine(), out int num);

                Console.Write("Sô bạn vừa nhập là: " + num + " và đó là số: ");
                Console.WriteLine(num % 2 == 0 ? "Chẵn" : "Lẻ");

                bool isValid = false;
                while(isValid == false)
                {
                    Console.WriteLine("Bạn muốn nhập tiếp?  (c/k? ");
                    string ans = Console.ReadLine();
                    if (ans == "c")
                    {
                        isQuit = false;
                        isValid = true;
                    }
                    else if (ans == "k")
                    {
                        isValid = true;
                        isQuit = true;
                    }
                    else
                    {
                        Console.WriteLine("Vui lòng nhập đúng câu trả lời (c/k)?");
                        isValid = false;    
                    }
                }
            }

            //Q&A: Hỏi a Dũng
            //Console.WriteLine("Nhập số: ");
            //var isBool = bool.TryParse(Console.ReadLine(), out bool num);

            //Console.Write("Trạng thái: " + isBool);
            //Console.Write("Sô bạn vừa nhập là: " + num);

        }
    }
}
