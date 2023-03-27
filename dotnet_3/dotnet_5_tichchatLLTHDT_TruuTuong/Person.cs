using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_5_tichchatLLTHDT_TruuTuong
{
    //Tính trừu tượng phải có abstract class
    internal abstract class Person
    {
        //Tính trừu tượng:
        //Có nghĩa là định nghĩa ra 1 giao diện ( hay còn gọi là các hàm, các khung, rồim uốn làm gì
        //Thì implement ở chỗ khác là dc
        /*
         Phương thức ảo (Chỉ khai báo, xử lý ở chỗ khác)
        Ở chỗ khác phải có override
         */
        public abstract void DisplayInfo();
    }
}
