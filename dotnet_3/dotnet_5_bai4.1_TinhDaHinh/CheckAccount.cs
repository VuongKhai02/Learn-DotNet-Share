using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace dotnet_5_bai4._1_TinhDaHinh
{
    internal class CheckAccount:Account
    {
        private decimal _feeTransfer;

        public CheckAccount(decimal initialize, decimal feeTransfer)
            : base(initialize)
        {
            _feeTransfer = feeTransfer;
        }
        public override void Deposit(decimal money)
        {
            if(money > 0)
            {
                balance += money;
                balance -= _feeTransfer;
                Console.WriteLine("Bạn đã gửi thành công: {0}", money);
                Console.WriteLine("Số dư hiện tại là: {0}$", balance);
            }    
            else
            {
                Console.WriteLine("Số tiền gửi không hợp lệ!");
            }    
        }
        public override void Withdraw(decimal money)
        {
            if(money > 0 && money < balance - _feeTransfer)
            {
                balance = balance - money - _feeTransfer;
                Console.WriteLine("Bạn đã rút thành công {0}$", money);
                Console.WriteLine("Số dư còn lại là : {0}$", balance);
            }
            else
            {
                Console.WriteLine("Không rút tiền dc!");
            }
        }
    }
    
}
