using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotnet7_btvnLab05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            var lstNhanVien = new List<NhanVien>()
            {
                new NhanVienBanHang("NVaBH1","VN",2000, 100),
                new NhanVienBanHang("NbVBH2","VN",2000, 150),
                new NhanVienBanHang("NVBcH3","VN",2000, 130),
                new NhanVienBanHang("NVdBH4","VN",2000, 140),
                new NhanVienBanHang("NVBHe5","VN",2000, 150),
                new CongNhan("CaN1","HQ",2000, 10),
                new CongNhan("CbN2","HQ",1000, 20),
                new CongNhan("CcN3","HQ",1000, 30),
                new CongNhan("CdN4","HQ",1000, 40),
                new CongNhan("CeN5","HQ",1000, 50)
            };


            DisplayMenu();
            Console.WriteLine("Nhập chức năng: ");
            int.TryParse(Console.ReadLine(), out int chucnang);
            while(true)
            {
                switch (chucnang)
                {
                    case 1:
                        Console.WriteLine("1. Thêm mới Công nhân");
                        Console.WriteLine("1. Thêm mới Nhân viên bán hàng");
                        int.TryParse(Console.ReadLine(), out int status);
                        if(status == 1)
                        {
                            Console.WriteLine("Tên công nhân: ");
                            var ten = Console.ReadLine();
                            Console.WriteLine("Địa chỉ công nhân: ");
                            var diachi = Console.ReadLine();
                            Console.WriteLine("Lương cơ bản công nhân: ");
                            decimal.TryParse(Console.ReadLine(), out decimal luongcoban);
                            Console.WriteLine("Số lượng sản phẩm: ");

                            int soluongsanpham = int.Parse(Console.ReadLine());
                            //int.TryParse(Console.ReadLine(), out int soluongsanpham);

                            var nhanvien = new CongNhan(ten, diachi, luongcoban, soluongsanpham);
                            lstNhanVien.Add(nhanvien);
                        }else if(status == 2)
                        {
                            Console.WriteLine("Tên nhân viên bán hàng: ");
                            var ten = Console.ReadLine();
                            Console.WriteLine("Địa chỉ nhân viên bán hàng: ");
                            var diachi = Console.ReadLine();
                            Console.WriteLine("Lương cơ bản nhân viên bán hàng: ");
                            decimal.TryParse(Console.ReadLine(), out decimal luongcoban);
                            Console.WriteLine("Số lượng sản phẩm: ");
                            int.TryParse(Console.ReadLine(), out int soluongsanpham);
                            try
                            {
                                var nhanvien = new NhanVienBanHang(ten, diachi, luongcoban, soluongsanpham);
                                lstNhanVien.Add(nhanvien);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Lỗi: " + ex.Message);
                                // hoặc thực hiện các hành động xử lý lỗi khác tại đây
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không hợp lệ!");
                        }


                        break;
                    case 2:
                        foreach (var nv in lstNhanVien)
                        {
                            nv.HienThi();
                        }
                        break;
                    case 3:
                        //LinQ
                        var query1 = from nv in lstNhanVien 
                            orderby nv.TinhLuong() descending
                                select nv;

                        foreach (var nhanVien in query1)
                        {
                            nhanVien.HienThi();
                        }


                        break;
                    case 4:

                        var maxSalary = from nv in lstNhanVien select nv.TinhLuong();
                        var queryMaxSalary = from nv in lstNhanVien
                                             where nv.TinhLuong() == maxSalary.Max()
                                             select nv;
                        foreach (var nv in queryMaxSalary)
                        {
                            nv.HienThi();
                        }

                        //Console.WriteLine(lstNhanVien.Count);
                        //var max = lstNhanVien[0];
                        //Console.WriteLine(lstNhanVien[0].HienThi());
                        //for(int i = 0; i < lstNhanVien.Count; i++)
                        //{
                        //    if (lstNhanVien[i].TinhLuong() > max.TinhLuong())
                        //    {
                        //        max = lstNhanVien[i];
                        //    }
                        //}
                        //Console.WriteLine("NV lương cao nhất: {0}", max);
                        break;
                    case 5:
                        //LinQ quêrry
                        Console.WriteLine("Nhập tên nhân viên cần tìm: ");
                        var text = Console.ReadLine();

                        var query = from nv in lstNhanVien
                                    where nv.Ten.ToLower().Contains(text.ToLower())
                                    //select nv;
                                    //foreach (var nv in query)
                                    //{
                                      //  nv.HienThi();
                                    //}
                                    select new
                                    {
                                        Name = nv.Ten,
                                        Salary = nv.TinhLuong()
                                    };
                        foreach(var nv in query)
                        {
                            Console.WriteLine("Tên: {0}, Lương : {1}", nv.Name, nv.Salary);
                        }



                        // == Select * from NhanVien as nv.
                        
                        

                        break;

                    default:
                        Console.WriteLine("Chương trình kết thúc!");
                        return;
                }
                DisplayMenu();
                int.TryParse(Console.ReadLine(), out chucnang);
                Console.WriteLine("haha");
            }

            //Console.WriteLine("Chương trình kết thúc!");


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
