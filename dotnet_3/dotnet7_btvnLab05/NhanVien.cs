using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet7_btvnLab05
{
    internal abstract class NhanVien
    {
        public string Ten { get; set; } 
        public string DiaChi { get; set; }  
        public decimal LuongCoBan { get; set; }   


        public abstract decimal TinhLuong();
        public abstract void HienThi();
    }
}
