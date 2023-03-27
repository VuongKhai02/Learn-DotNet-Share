using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_5
{
    internal class Rectangle_lopcon: Shape_lopcha
    {
        public double Chieudai { get; set; }
        public double Chieurong { get; set; }

        public override void Input()
        {
            Console.WriteLine("Nhập chiều dài: ");
            double.TryParse(Console.ReadLine(), out double cd);
            Chieudai = cd;

            Console.WriteLine("Nhập chiều rộng: ");
            double.TryParse(Console.ReadLine(), out double cr);
            Chieurong = cr;
        }

        public override void TinhChuVi()
        {
            Console.WriteLine("Chu vi: {0}", 2 * (Chieudai + Chieurong));
        }
        public override void TinhDienTich()
        {
            Console.WriteLine("Diện tích: {0}", Chieudai * Chieurong);
        }
    }
}
