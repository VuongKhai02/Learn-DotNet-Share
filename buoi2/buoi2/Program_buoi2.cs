using System;
using System.Globalization;
using System.Text;

namespace buoi2
{
    internal class Program_buoi2
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.Unicode;

            //labgui - 02 nhập xuất - 25-27-28
            //ấn F5 để chạy debug

            /*
            int n = 15;
            if (n % 2 == 0 && n % 5 == 0)
            {
                Console.WriteLine("n là số chẵn");
            }
            else if (n % 2 == 1)
            {
                Console.WriteLine("n là số lẻ");
            }
            */


            //giai ptb1 ax + b = 0

            /*
            bool isQuit = false;
            while (isQuit == false)
            {

                Console.WriteLine("Nhập vào lần lượt a, b của phương trình bậc 1 ax + b = 0");
                double.TryParse(Console.ReadLine(), out double a);
                double.TryParse(Console.ReadLine(), out double b);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm");
                    }
                }
                else
                {
                    Console.WriteLine("Phương trình có nghiệm x = " + (-b / a));
                }
                Console.WriteLine("Bạn có muốn thoát k? (c/k)");
                var rs = char.Parse(Console.ReadLine());
                if (rs == 'c' || rs == 'C')
                {
                    isQuit = true;
                }
                else
                {
                    isQuit = false;
                }
            }*/


            //Phương trình bậc 2
            /*
            bool isQuit = false;
            while (isQuit == false)
            {

                Console.WriteLine("Nhập vào lần lượt a, b, c của phương trình bậc 1 ax^2 + bx + c = 0");
                double.TryParse(Console.ReadLine(), out double a);
                double.TryParse(Console.ReadLine(), out double b);
                double.TryParse(Console.ReadLine(), out double c);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("Phương trình có vô số nghiệm");
                        }
                        else
                        {
                            Console.WriteLine("Phương trình vô nghiệm");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Phương trình có nghiệm duy nhất x = " + (-c / b));
                    }
                }
                else
                {
                    double denta = b * b - 4 * a * c;
                    if (denta == 0)
                    {
                        Console.WriteLine("Phương trình có nghiệm kép x = " + (-b / 2 * a));
                    }
                    else if (denta < 0)
                    {
                        Console.WriteLine("Phương trình vô nghiệm");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình có nghiệm x1 = " + (-b + Math.Sqrt(denta)) / (2 * a));
                        Console.WriteLine("Phương trình có nghiệm x2 = " + (-b - Math.Sqrt(denta)) / (2 * a));
                    }
                }
                Console.WriteLine("Bạn có muốn thoát k? (c/k)");
                var rs = char.Parse(Console.ReadLine());
                if (rs == 'c' || rs == 'C')
                {
                    isQuit = true;
                }
                else
                {
                    isQuit = false;
                }
            }*/


            //Swith
            /*
            int month = 11;
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Đây là tháng 1 hoặc 2 hoặc 3!");
                    break;
                case 4:
                    Console.WriteLine("Đây là tháng 4!");
                    break;
                case 5:
                    Console.WriteLine("Đây là tháng 5!");
                    break;
                case 6:
                    Console.WriteLine("Đây là tháng 6!");
                    break;
                case 7:
                    Console.WriteLine("Đây là tháng 7!");
                    break;
                case 8:
                    Console.WriteLine("Đây là tháng 8!");
                    break;
                case 9:
                    Console.WriteLine("Đây là tháng 9!");
                    break;
                case 10:
                    Console.WriteLine("Đây là tháng 10!");
                    break;
                case 11:
                    Console.WriteLine("Đây là tháng 11!");
                    break;
                case 12:
                    Console.WriteLine("Đây là tháng 12!");
                    break;
                default:
                    Console.WriteLine("Tháng không hợp lệ");
                    break;
            }*/

            // VÒNG LẶP FOR
            //for(int i = 1; i <= 5; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Hieu
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Tam giac nguoc
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 7; i >= 1; i--)
            {
                for (int j = 0; j < 7-i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= (2*i)-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 7; i++)
            {
                for(int j = i; j < 7; j++)
                {
                    Console.Write(" ");
                }
                    int k = i;
                for(int j = 1; j <= (2*i)-1; j++)
                {
                    Console.Write(k);
                    if ( k == (2*i)-1 )
                    {
                        k--;
                    }
                    else
                        k++;

                }
                Console.WriteLine();    
            }

            //While
            // Viết chương trình tính tổng các chữ số 
            //int n = 1234;
            //int sum = 0;
            //while(n > 0)
            //{
            //    int d = n % 10;
            //    sum += d;
            //    n = n / 10;
            //}
            //Console.WriteLine(sum);

        }
    }
}
