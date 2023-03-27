using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet7_RedoLab5
{
    internal class CongNhan : NhanVien
    {
        public int SLSanPham;

        public CongNhan(int slsanpham, string ten, string dc)
        {

            SLSanPham = slsanpham;
            Ten = ten;
            DiaChi = dc;
            LuongCoBan = 2;

        }
        public override void HienThi()
        {
            Console.WriteLine("Công nhân: {0} - {1} - {2} - {3}", SLSanPham,Ten,DiaChi,TinhLuong());
        }

        public override decimal TinhLuong()
        {
            return SLSanPham * LuongCoBan * 5;
        }
    }
}
