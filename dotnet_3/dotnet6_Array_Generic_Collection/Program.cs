using System;
using System.Text;

namespace dotnet6_Array_Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            //var numbers = new int[] { 1, 2, 3 };
            //var names = new string[5];
            //names[0] = "Dev";

            //foreach(var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            var lstStu = new Student[2];
            lstStu[0] = new Student("khai", "Hn");
            lstStu[1] = new Student("khai", "Hn");

            foreach(var st in lstStu)
            {
                st.Display();
            }

            /*var test = new TestIndexer(1);
           
            bool isCon = true;
            while(isCon == true)
            {
                Console.WriteLine("Nhập: ");
                var value = Console.ReadLine();

                test.Add(value);
                Console.WriteLine("Tiếp hay k? ");
                var ans = Console.ReadLine();
                if (ans == "k" || ans == "K")
                {
                    isCon = false;
                }
                else
                    isCon = true;
            }

            for(int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }*/

            var testStu = new Prac_Indexer(3);
            testStu[0] = new Student("Khai", "HY");

            Console.WriteLine(testStu[0]);
            testStu[0].ToString();
        }
    }
}
