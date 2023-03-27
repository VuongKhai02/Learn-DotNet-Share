using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotnet6_Array_Generic_Collection
{
    internal class TestIndexer
    {
        //Bao cái mảng bằng 1 obj
        //Sau đó nó cung cấp các hàm để truy vấn vào các phần tử trong mảng đó

        //Chỉ mục:
        //Có 1 hàm khai báo độ dài, 1 hàm truy cập vào các chỉ mục
        private string[] names;

        private int _currentIndex;
        public int Length { get; set; }    

        public TestIndexer(int length)
        {
            names = new string[length];
            Length = length;
            _currentIndex = 0;
        }

        public void Add(string value)
        {
            names[_currentIndex++] = value;
            _currentIndex++;    
        }

        //Vì obj ko truy cập dc qua chỉ mục [0] như mảng, 
        //Nên cần indexer
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }
}
