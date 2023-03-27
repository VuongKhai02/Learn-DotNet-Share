using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace dotnet_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            //24% 7:09
            Shape_lopcha s = new Shape_lopcha();
            Console.WriteLine("Nhập hình: ");
            var str = Console.ReadLine();
            if (str == "ht")
                s = new Circle_lopcon();
            if (str == "hcn")
                s = new Rectangle_lopcon();

            s.Input();
            s.TinhChuVi();
            s.TinhDienTich();
        }
    }
}
