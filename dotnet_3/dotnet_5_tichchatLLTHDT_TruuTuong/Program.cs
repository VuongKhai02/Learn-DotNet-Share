using System;

namespace dotnet_5_tichchatLLTHDT_TruuTuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ví dụ interface
            IPerson_Interface p = new Staff();
            p.Display();
            p.Run();

            //ICompany c = new Staff();
        }
    }
}
