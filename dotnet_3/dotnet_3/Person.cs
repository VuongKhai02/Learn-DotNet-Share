using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_3
{
    internal class Person
    {
        // Nếu có {get;set}: Thì là thuộc tính, còn không thì là biến
        
        //Tên Phương thức phải viết hoa cái đầu
        

        //Private và Static: là readonly, ko thể truy cập được từ class khác
        //Nếu đặt tên biến là private nên có _: vd _name
        //Và biến đặt trong hàm set thì là biến dc truyề vào

        //1
        //Biến gốc ( ch có gtri)
        private string _name;
        public void SetName (string name)
        {
            //Nếu thỏa mãn thì mới set tham số truyền vào( name  ) thỏa mãn thành _name gốc
            //if ()
            //{
            //}
                _name = name;
        }

        public string GetName()
        {
            return _name;
        }


        //properties: Viết hoa chữ cái đầu
        // ( 1 dòng này bằng 2 hàm setname và getname kia)
        //2
        public string Name { get; set; }

        public DateTime dob;

        private int _gender;
        //Nếu muốn chỉ set, ko get:
        public int Gender { private get; set;}

        public string phone;

        public string email;
        public void DisplayInfo()
        {
            Console.WriteLine("Thông tin: ");
            //1
            Console.WriteLine("Tên: {0}",  _name);
            //2
            Console.WriteLine("Tên: {0}",  Name);
            Console.WriteLine("Ngày sinh: {0}",  dob.ToString(format: "dd/MM/yyyy"));
            Console.WriteLine("Giới tính: {0}", Gender == 1 ? "Nam" : "Nữ");
            Console.WriteLine("Email: {0}",  email);
            Console.WriteLine("Sđt: {0}",  phone);
            Console.WriteLine("Tuổi: {0}",  CalculateAge());
        }

        public int CalculateAge()
        {
            //Now là thuộc tính  ( có cái cà lê )
            var yearNow = DateTime.Now.Year;
            var yearDob = dob.Year;
            return yearNow - yearDob;
        }

        public void Run(int km, DateTime dobb)
        {
            Console.WriteLine("Bạn đã chạy {0}", km);
        }

        /*
        public Person(string name, DateTime dob, byte gender, string phone, string email)
        {
            this.name = name;
            this.dob = dob;
            this.gender = gender;
            this.phone = phone;
            this.email = email;
        }*/
    }
}
