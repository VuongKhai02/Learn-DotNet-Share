using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet7_btvnLab05
{
    internal class CongNhan : NhanVien
    {
        public int SoLuongSanPham { get; set; } 

        public CongNhan(string ten, string diachi, decimal luongcoban, int soluongsanpham)
        {
            Ten = ten;
            DiaChi = diachi;
            LuongCoBan = luongcoban;
            SoLuongSanPham = soluongsanpham;
        }

        public override void HienThi()
        {
            Console.WriteLine("Tên: {0}, Địa chỉ: {1}, Lương: {2}", Ten, DiaChi, TinhLuong());
        }

        public override decimal TinhLuong()
        {
            return SoLuongSanPham * 50 + LuongCoBan;
        }
    }
}
