using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotnet6_Generic
{
    internal class GenericIndexer<T>
    {
        //<T> Ở đây biểu trung cho kiểu dữ liệu, 
        //SD GI để linh hoạt giữa các kiểu dữ liệu, hãy sang program để rõ hơn
        //Biến private thông thường có dấu gạch dưới

        //Lưu ý: GenericIndexer Không phải là một cái mảng, 
        //Vì vậy để truy cập đc vào các phần tử trong GI, ta phải sd hàm GetData


        private T[] _data;
        private int _currentIndex;

        public GenericIndexer()
        {
            _data = new T[1000];
            _currentIndex = 0;  
        }

        //Kiểu DL T, biến là item
        public void Add(T item)
        {
            _data[_currentIndex] = item;
            _currentIndex++;    
        }

        public T[] GetData()
        {
            //Hàm Take và Skip dùng trong mảng
            return _data.Take(_currentIndex).ToArray();

        }
    }

}
