using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dotnet7_RedoLab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            //var lstNhanVien = new NhanVien[10];
            //lstNhanVien[0] = new NVBanHang(10, "Khai", "Hung Yen");
            //lstNhanVien[1] = new NVBanHang(10, "Khai", "Hung Yen");
            //lstNhanVien[2] = new NVBanHang(10, "Khai", "Hung Yen");
            //lstNhanVien[3] = new NVBanHang(10, "Khai", "Hung Yen");
            //lstNhanVien[4] = new NVBanHang(10, "Khai", "Hung Yen");

            //lstNhanVien[5] = new CongNhan(5, "Khai CN", "Hung Ha");
            //lstNhanVien[6] = new CongNhan(8, "Khai CN", "Hung Ha");
            //lstNhanVien[7] = new CongNhan(3, "Khai CN", "Hung Ha");
            //lstNhanVien[8] = new CongNhan(9, "Khai CN", "Hung Ha");
            //lstNhanVien[9] = new CongNhan(3, "Khai CN", "Hung Ha");

            var lstNhanVien = new List<NhanVien>()
            {
                new NVBanHang(10, "Khai", "Hung Yen"),
            new NVBanHang(10, "Khai", "Hung Yen"),
             new NVBanHang(10, "Khai", "Hung Yen"),
            new NVBanHang(10, "Khai", "Hung Yen"),
             new NVBanHang(10, "Khai", "Hung Yen"),

             new CongNhan(5, "Khai CN", "Hung Ha"),
            new CongNhan(8, "Khai CN", "Hung Ha"),
             new CongNhan(3, "Khai CN", "Hung Ha"),
           new CongNhan(9, "Khai CN", "Hung Ha"),
             new CongNhan(3, "Khai CN", "Hung Ha")
            };



            int ans = 0;
            DisplayMenu();
            int.TryParse(Console.ReadLine(), out ans);
            while(ans != 6)
            {
                switch (ans)
                {
                    case 1:
                        Console.WriteLine("Thêm NV(1), Thêm CN(0)?");
                        int.TryParse(Console.ReadLine(), out int cn);
                        if(cn == 0)
                        {
                            Console.WriteLine("Nhập thông tin muốn thêm: (SlBán, Tên, Địa Chỉ)");
                            int.TryParse(Console.ReadLine(), out int SlBanDuoc1);
                            var Ten1 = Console.ReadLine();
                            var DiaChi1 = Console.ReadLine();
                            lstNhanVien.Add(new NVBanHang(SlBanDuoc1, Ten1, DiaChi1));
                        }
                        else if(cn == 1)
                        {
                            Console.WriteLine("Nhập thông tin muốn thêm: (SlSP, Tên, Địa Chỉ)");
                            int.TryParse(Console.ReadLine(), out int SlSp);
                            var Ten = Console.ReadLine();
                            var DiaChi = Console.ReadLine();
                            lstNhanVien.Add(new CongNhan(SlSp, Ten, DiaChi));
                        }
                        else
                        {
                            Console.WriteLine("Không hợp lệ");
                        }
                        break;

                    case 2:
                        foreach (var nv in lstNhanVien)
                        {
                            nv.HienThi();
                        }
                        break;
                    case 3:
                        var query1 = from nv in lstNhanVien
                                    orderby nv.TinhLuong() descending
                                    select nv;

                        foreach(var nv in query1)
                        {
                            nv.HienThi();
                        }
                        break;


                    case 5:
                        Console.WriteLine("Nhập tên muốn tìm: ");
                        var text = Console.ReadLine();

                        var query = from nv in lstNhanVien
                                    where nv.Ten.ToLower().Contains(text.ToLower())
                                    select nv;

                        foreach (var nv in query)
                        {
                            nv.HienThi();
                        }

                        //Hoặc:


                        //var query = from nv in lstNhanVien
                        //            where nv.Ten.ToLower().Contains(text.ToLower())
                        //            select new
                        //            {
                        //                Name = nv.Ten,
                        //                Salary = nv.TinhLuong(),
                        //            };

                        //foreach (var nv in query)
                        //{
                        //    Console.WriteLine("Ten: {0}, Lương: {1}", nv.Name, nv.Salary);
                        //}
                        break;

                    default:
                        Console.WriteLine("Kết thúc!");
                        return;
                }
                DisplayMenu();
                int.TryParse(Console.ReadLine(), out ans);
            }
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Menu chức năng: ");
            Console.WriteLine("1: Thêm mới 1 nhân viên vào mảng ");
            Console.WriteLine("2: Hiển thị tất cả các nhân viên trong mảng ");
            Console.WriteLine("3: Sắp xếp nhân viên theo lương GIẢM DẦN ");
            Console.WriteLine("4: Chọn nhân viên LƯƠNG CAO NHẤT ");
            Console.WriteLine("5: Tìm kiếm theo tên ");
            Console.WriteLine("6: Thoát ");
        }

    }
}
