using System;
using System.Text;

namespace buoi2_tongCacSoTrong1ChuSo
{
    internal class Program_buoi2_tongcacso
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập: ");

            var num1 = int.Parse(Console.ReadLine());
            var num = num1;

            int tongCacChuSo = 0;
            while(num > 0)
            {
                int soCuoi = num % 10;
                tongCacChuSo += soCuoi;
                num /= 10;
            }

            Console.WriteLine("Tổng các chữ số trong số {0} là: {1}", num1, tongCacChuSo);
        }
    }
}
