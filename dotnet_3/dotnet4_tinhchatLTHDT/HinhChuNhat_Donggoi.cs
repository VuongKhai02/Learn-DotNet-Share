using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet4_tinhchatLTHDT
{
    internal class HinhChuNhat_Donggoi
    {
        //Khai bảo private nhằm không cho bên ngoài(người lập trình)
        //tác động vào biến này khi chương trình đã đ chạy(đối tượng đã đc khởi tạo và run)

        private double _chieudai;
        private double _chieurong;

        public HinhChuNhat_Donggoi(double chieudai, double chieurong)
        {
            _chieudai = chieudai;
            _chieurong = chieurong;
        }

        public double Dientich()
        {
            return _chieudai * _chieurong;
        }

        public double Chuvi()
        {
            return (_chieurong + _chieudai) * 2;
        }
    }
}
