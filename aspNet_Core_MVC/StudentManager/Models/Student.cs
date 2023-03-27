namespace StudentManager.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public DateTime Dob { get; set; }   

        public int Gender { get; set; }        

        public string Email { get; set; }        

        public string Phone { get; set; }

        public Student( string name, DateTime dob, int gender, string email, string phone)
        { 
            Name = name;
            Dob = dob;
            Gender = gender;
            Email = email;
            Phone = phone;
        }
        //Tạo  1 cái trống để ko cần khởi tạo dữ liệu sẵn                       

        public Student()
        {

        }
    }
}
