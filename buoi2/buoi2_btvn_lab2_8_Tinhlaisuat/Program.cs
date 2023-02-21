using System;
using System.ComponentModel;
using System.Text;

namespace buoi2_btvn_lab2_8_TinhlsNam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Chương trình tính lãi suất ngân hàng: ");

            Console.WriteLine("Nhập số tiền: ");
            Decimal.TryParse(Console.ReadLine(), out var soTien);
            Console.WriteLine("Nhập lãi suất(năm) %:");
            double.TryParse(Console.ReadLine(), out var lsNam);
            Console.WriteLine("Nhập số tháng gửi:");
            int.TryParse(Console.ReadLine(), out var soThang);

            //Tính tóan
            double lsThang = (lsNam / 12) / 100;
            double tienLaiCuoiKy = (double)soTien;
            Console.WriteLine("Tiền lãi từ tháng 1 đến tháng {0} lần lượt là: ", soThang);

            for (int i = 1; i <= soThang; i++)
            {
                double tienLaiThang = tienLaiCuoiKy * lsThang;
                for (int j = i; j == i; j++)
                {
                        Console.Write(i + "-" + tienLaiCuoiKy + "-" + tienLaiThang);//ok
                        tienLaiCuoiKy += tienLaiThang;//ok
                        Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Tổng tiền nhận được sau khi gửi {0} triệu với lãi suất {1}%/năm trong vòng {2} tháng là: {3} ", soTien, lsNam, soThang, tienLaiCuoiKy);


        }
    }
}
