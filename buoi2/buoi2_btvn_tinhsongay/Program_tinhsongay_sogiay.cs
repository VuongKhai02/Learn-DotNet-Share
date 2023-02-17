using System;
using System.Linq.Expressions;
using System.Text;

namespace buoi2_btvn_tinhsongay
{
    internal class Program_tinhsongay_sogiay
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            
                Console.WriteLine("Nhập s: ");
                var giay = int.Parse(Console.ReadLine());
                var rs00 = giay / 3600;
            
                var rs0 = giay / 60;
                if (rs0 < 10)
                {
                    Console.WriteLine(rs0);
                }
                var rs = giay % 60;
                Console.WriteLine("{0} giây tương ứng với định dạng: {1:D2}:{2:D2}:{3:D2}", giay, rs00, rs0, rs);
            

            //TÍNH SỐ NGÀY
            //Console.WriteLine("Chương trình tính số ngày! ");
            //Console.WriteLine("Nhập tháng: ");
            //var thang = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập năm: ");
            //var nam = int.Parse(Console.ReadLine());
            //Cách 2: 
            /*
                int ngay = DateTime.DaysInMonth(nam, thang);
                Console.WriteLine("Ngày trong tháng {0} năm {1} là: {2} ", thang, nam, ngay);
            */
            //Cách 1:
            /*
                bool laNhuan = false;
                int ngay = 0;
                switch (thang)
                {
                    case 2:
                        if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0)
                        {
                            laNhuan = true;
                        }
                        if(laNhuan == true)
                        {
                            ngay = 29;
                        }
                        else
                        {
                            ngay = 28;
                        }
                        break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        ngay = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        ngay = 30;
                        break;
                    default:
                        Console.WriteLine("Dữ liệu không hợp lệ");
                        break;
                }
                
                Console.WriteLine("Ngày trong tháng {0} năm {1} là: {2} ", thang,nam, ngay);
            */

        }
    }
}
