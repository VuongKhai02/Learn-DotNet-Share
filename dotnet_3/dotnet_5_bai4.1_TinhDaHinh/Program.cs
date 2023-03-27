using System;
using System.Text;

namespace dotnet_5_bai4._1_TinhDaHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            //Account ac = new Account(10000);
            Console.WriteLine("Bạn muốn gửi hay rút?(g/r)");
            char.TryParse(Console.ReadLine(), out var ans);
            if(ans == 'g')
            {
                var ac = new SavingAccount(10000, 0.1);
                Console.WriteLine("Tien lai: {0}", ac.GetInterest());
            }
            else if(ans == 'r')
            {
                var ac = new CheckAccount(10000, 10);
                ac.Deposit(3000);
                ac.Withdraw(14000);
            }
            
            

        }
    }
}
