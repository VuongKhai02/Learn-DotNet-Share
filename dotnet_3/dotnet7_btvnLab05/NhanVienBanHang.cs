using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet7_btvnLab05
{
    internal class NhanVienBanHang : NhanVien
    {
        // Khi kế thừa(implement) Thì phải có các method của Lớp cha
        // Ấn chuột vào NhanVien + Ctrl + . (Tự động viết các hàm)
        public int SoLuongBanDuoc { get; set; }
        public NhanVienBanHang(string ten, string diachi, decimal luongcoban, int soluongbanduoc)
        {
            Ten = ten;
            DiaChi = diachi;
            LuongCoBan = luongcoban;
            SoLuongBanDuoc = soluongbanduoc;
        }

        public override void HienThi()
        {
            Console.WriteLine("Tên: {0}, Địa chỉ: {1}, Lương: {2}", Ten, DiaChi, TinhLuong());

        }


        public override decimal TinhLuong()
        {
            return SoLuongBanDuoc * 40 + LuongCoBan;
        }
    }
}
