using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace dotnet_5
{
    internal class Circle_lopcon:Shape_lopcha
    {
        private const double PI = 3.14;
        public double Bankinh { get; set; }

        public override void Input()
        {
            Console.WriteLine("Nhập vào bán kính của hình tròn: ");
            double.TryParse(Console.ReadLine(), out double bk);
            Bankinh = bk;
        }

        public override void TinhChuVi()
        {
            Console.WriteLine("Chu vi hình tròn là: {0}", 2 * PI * Bankinh);
        }

        public override void TinhDienTich()
        {
            Console.WriteLine("Diện tích hình tròn là: {0}", PI * Bankinh * Bankinh);
        }
    }
}
