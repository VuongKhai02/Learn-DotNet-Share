using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet7_RedoLab5
{
    internal class NVBanHang: NhanVien
    {
        public int SLBanDuoc { get; set; }

        public NVBanHang(int slbanduoc, string ten, string dc)
        {

            SLBanDuoc = slbanduoc;
            Ten = ten;  
            DiaChi = dc;
            LuongCoBan = 5;
        }

        public override void HienThi()
        {
            Console.WriteLine("NV BÁN HÀNG: {0} - {1} - {2} - {3}", SLBanDuoc,Ten,DiaChi,TinhLuong());

        }

        public override decimal TinhLuong()
        {
            return SLBanDuoc * LuongCoBan * 7;
        }
    }
}
