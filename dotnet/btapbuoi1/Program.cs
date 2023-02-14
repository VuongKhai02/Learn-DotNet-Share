using System;
using System.Net.NetworkInformation;
using System.Text;

namespace btapbuoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;


            //Viết chương trình thực hiện các yêu cầu sau:
            //Khai báo biến để lưu trữ thông tin của nhân viên bao gồm(Mã nhân viên, họ tên, ngày sinh, địa chỉ, điện thoại, email).
            //Hiển thị thông tin của nhân viên đó trên màn hình.

                //Console.WriteLine("Nhập vào mã nhân viên: ");
                //string maNV = Console.ReadLine();
                //Console.WriteLine("Nhập vào họ tên: ");
                //string name = Console.ReadLine();
                //Console.WriteLine("Nhập vào ngày sinh: ");
                //DateTime.TryParse(Console.ReadLine(), out DateTime ngaysinh);
                //Console.WriteLine("Nhập vào địa chỉ: ");
                //string address = Console.ReadLine();
                //Console.WriteLine("Nhập vào sđt: ");
                //string sdt = Console.ReadLine();
                //Console.WriteLine("Nhập vào email: ");
                //string email = Console.ReadLine();
                //Console.WriteLine("Mã nhân viên: " + maNV);
                //Console.WriteLine("Họ tên: " + name);
                //Console.WriteLine("Ngày sinh: " + ngaysinh);
                //Console.WriteLine("Địa chỉ: " + address);
                //Console.WriteLine("Email: " + email);


            //Viết chương trình thực hiện yêu cầu sau
            //Khai báo biến để lưu trữ thông tin kết quả học tập của sinh viên bao gồm(điểm toán, điểm văn, điểm tiếng anh).
            //Hiển thị điểm TB, xếp loại của sinh viên trên màn hình theo quy tắc: 
            //Điểm TB< 5: loại trung bình
            //5 <= Điểm TB < 8: loại khá
            //Điểm TB > 8: loại giỏi
                Console.WriteLine("Chương trình tính điểm TB! ");
                Console.WriteLine("Vui lòng nhập điểm phẩy với ký tự ','");
                Console.WriteLine("Nhập điểm toán: ");
                var diemToan = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhập điểm Anh: ");
                var diemAnh = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhập điểm Văn: ");
                var diemVan = float.Parse(Console.ReadLine());
                Console.WriteLine("Điểm vừa nhập là: {0} , {1} , {2} ", diemToan,diemAnh, diemVan);

                float diemTBC = (diemToan + diemAnh + diemVan) / 3 ;
                Console.WriteLine("Điểm TBC là:  " + diemTBC);
                Console.WriteLine("Xếp loại tương ứng là:  ");
                if(diemTBC >= 8)
                {
                    Console.WriteLine("Giỏi");
                }
                else if (diemTBC >= 5)
                {
                    Console.WriteLine("Khá");
                }
                else
                {
                    Console.WriteLine("Trung bình");
                }







        }
    }
}
