using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet4_tinhchatLTHDT
{
    internal class Person_KeThua
    {
        //Guid là 1 kiểu dl, cái mà auto generate ra 1 chuỗi random
        public Guid Id { get; set; }    
        public string Name { get; set; }

        public DateTime Dob { get; set; }

        public int Gender { get; set; }

        //Hàm khởi tạo
        public Person_KeThua(string name, DateTime dob, int gender)
        {
            //Guid là 1 obj, NewGuid() là 1 static
            Id = Guid.NewGuid();
            Name = name;    
            Dob = dob;  
            Gender = gender;    
        }

        //Đa hình: Ở class cha phải có virtual
        //Tính đa hình được thể hiện ở chỗ. Nếu tạo đối tượng và sd hàm tostring(khi này cả 2 clsss đều có hàm này)
        //Khi có tính đa hình, hàm con sẽ truy cập và ghi đè lên hàm cha.
        public virtual void toString()
        {
            Console.WriteLine("Hàm toString perrson ");
            //Console.WriteLine("Tên: {0}", Name);
            //Console.WriteLine("Ngày sinh: {0}", Dob);
            //Console.WriteLine("Giới tính: {0}", Gender == 0?"Nam":"Nữ");
        }

    }
}
