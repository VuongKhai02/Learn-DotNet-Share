using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Text;

namespace dotnet8_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // join
            // group by
            // where
            /*
             * order by
             * take
             * skip
             * select
             * tính toán: max, min, average, count, sum
             */


            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            var lstCategory = new List<Category>()
            {
                new Category(1, "Iphone"),
                new Category(2, "Sam Sung"),
                new Category(3, "Xiaomi"),
                new Category(4, "Oppo")
            };

            var lstProduct = new List<Product>()
            {
                new Product("Iphone Xr", 1500,1),
                new Product("Iphone 11Pro max", 2500,1),
                new Product("SamSung Ultra 1", 2000,2),
                new Product("SamSung Z-Flip 2", 2800,2),
                new Product("Xiaomi", 800,3),
                new Product("Xiaomi Note 9", 1000,3),
                new Product("Oppo A37", 900,4),
                new Product("Oppo Neo 9", 1400,4),
            };

            //Linq
            var query = from p in lstProduct
                        join c in lstCategory 
                        on p.CategoryId equals c.CategoryId
                        where string.Equals(c.Name.ToLower(), "iphone") && p.Name.ToLower().Contains("xr")
                        select new
                        {
                            ProductName = p.Name,
                            CategoryName = c.Name,
                            ProductPrice = p.Price,
                        };

            Console.WriteLine("Thông tin các mặt hàng điện thoại:");
            foreach(var p in query)
            {
                Console.WriteLine("{0,-20} - {1,15} - {2,-15}", p.ProductName, p.CategoryName, p.ProductPrice);
            }

            //Tên chứa chữ samsung và giá lớn hơn 2000
            var query1 = from p in lstProduct
                         join c in lstCategory on p.CategoryId equals c.CategoryId
                         where p.Name.ToLower().Contains("samsung") && p.Price > 2000
                         select new
                         {
                             ProductName = p.Name,
                             CategoryName = c.Name,
                             ProductPrice = p.Price,
                         };
            Console.WriteLine("Danh sách sản phẩm mà tên chứa chữ samsung và giá lớn hơn 2000");
            foreach(var p in query1)
            {
                Console.WriteLine("{0,-20} - {1,15} - {2,-15}", p.ProductName, p.CategoryName, p.ProductPrice);
            }

            //Linq - Group By
            var query2 = from c in lstCategory
                         join p in lstProduct on c.CategoryId equals p.CategoryId
                         //into pgrp: 
                         // Có nghĩa là mỗi cụm dc groupby là 1 pgrp (ở bài này có 4 pgrp)


                         //nhóm các Product theo 2 trường trong bảng C (Id và cả Name)
                         group p by c into pgrp
                         //hoặc: 
                         //group p by new {c.CategoryId, c.Name} into pgrp
                         select new
                         {
                             CateName = pgrp.Key.Name,
                             TotalProduct = pgrp.Count(),
                         };
            Console.WriteLine("số lượng sản phẩm các hãng:  ");
            foreach(var obj in query2)
            {
                Console.WriteLine("Hãng: {0} - SLSP: {1}",obj.CateName, obj.TotalProduct);
            }

            //linq method
            var query31 = from p in lstProduct
                         where p.Price > 1200
                         select p;
            var query32 = lstProduct.Where(p => p.Price > 1200).Select(p => p);
             
            //delegate
            //anounymous type
            //lambda expression
            //asp.net core mvc
        }

    }
}
