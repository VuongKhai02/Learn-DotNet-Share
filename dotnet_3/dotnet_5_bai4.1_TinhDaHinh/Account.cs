using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace dotnet_5_bai4._1_TinhDaHinh
{
    internal class Account
    {
        //public decimal Balance { get; set;}
        //protected vì xuống nhữn lớp sau có thể sd dc 
        protected decimal balance;

        public Account(decimal initialize)
        {
            balance = initialize;
        }

        public virtual void Deposit(decimal money)
        {
            if(money <= 0)
            {
                Console.WriteLine("Số tiền gửi không hợp lệ");
            }
            else
            {
                balance += money;
                Console.WriteLine("Gửi tiền thành công");
                Console.WriteLine("Số dư: {0}", balance);
            }

        }

        public virtual void Withdraw(decimal money)
        {
            if (money > balance)
            {
                Console.WriteLine("Không đủ tiền để rút!");
            }
            else if (money <= 0)
            {
                Console.WriteLine("Số tiền rút không hợp lệ!");
            }
            else
            {
                balance -= money;
                Console.WriteLine("Rút tiền thành công!");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
